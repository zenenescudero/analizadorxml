Imports System.IO
Imports System.Xml

Public Class leerxml

    Dim versioncfdi As String = ""
    Dim uuidCFDI As String = ""
    Dim numeroaprobacion As String = ""
    Dim seriefolio As Boolean = True

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        directorio.Reset()
        directorio.ShowDialog()

        If directorio.SelectedPath.Length > 0 Then

            cadenaleer.Text = directorio.SelectedPath
            grillaarchivos.Rows.Clear()

            If SubCarpeta.Checked = True Then

                For Each ARCHIVOd As String In Directory.GetFiles(directorio.SelectedPath, "*.xml", SearchOption.AllDirectories)
                    Dim arc As New OpenFileDialog
                    arc.FileName = ARCHIVOd
                    If obtenerextension(arc).ToUpper = ".XML" Then
                        grillaarchivos.Rows.Add(ARCHIVOd)
                    End If
                Next
            Else
                For Each ARCHIVOd As String In Directory.GetFiles(directorio.SelectedPath, "*.xml", SearchOption.TopDirectoryOnly)
                    Dim arc As New OpenFileDialog
                    arc.FileName = ARCHIVOd
                    If obtenerextension(arc).ToUpper = ".XML" Then
                        grillaarchivos.Rows.Add(ARCHIVOd)
                    End If
                Next
            End If

            Label5.Text = "Archivos a Remplazar: " & grillaarchivos.Rows.Count

        Else
            MsgBox("No selecciono carpeta para Guardar")
            cadenaleer.Text = ""
            grillaarchivos.Rows.Clear()
            Label5.Text = "Archivos a Remplazar: 0"
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        directorio.Reset()
        directorio.ShowDialog()

        If directorio.SelectedPath.Length > 0 Then
            cadenaguardar.Text = directorio.SelectedPath
        Else
            MsgBox("No selecciono carpeta para Guardar")
            cadenaguardar.Text = ""
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        txtsuc.Text = Trim(txtsuc.Text)
        If cadenaguardar.Text.Length > 0 Then
        Else
            MsgBox("No selecciono directorio donde guardar renombrados", MsgBoxStyle.Exclamation, "Directorio")
            Exit Sub
        End If

        If cadenaleer.Text.Length > 0 Then
        Else
            MsgBox("No tiene direcctorio de Lectura", MsgBoxStyle.Exclamation, "Directorio")
            Exit Sub
        End If

        grillaerrores.Rows.Clear()
        griddatosxml.Rows.Clear()
        griddatosxml.Rows.Clear()
        Cursor = Cursors.WaitCursor

        For x As Integer = 0 To grillaarchivos.Rows.Count - 1

            Try

                Dim variablesformadas As String = ""
                Try
                    If Trim(txtsuc.Text).Length > 0 Then
                        variablesformadas = txtsuc.Text & "_" & ExtraerVariables(grillaarchivos.Item(0, x).Value)
                    Else
                        variablesformadas = ExtraerVariables(grillaarchivos.Item(0, x).Value)
                    End If

                    If seriefolio = False Then
                        versioncfdi = "SinSerieFolio"
                    End If

                    If Directory.Exists(cadenaguardar.Text & "\" & versioncfdi) Then
                    Else
                        Try
                            Directory.CreateDirectory(cadenaguardar.Text & "\" & versioncfdi)
                        Catch ex As Exception
                        End Try
                    End If
                    If variablesformadas = "__" Then
                        grillaerrores.Rows.Add(grillaarchivos.Item(0, x).Value, "No se pudo Leer La Estructura del Archivo XML")
                    Else
                        If File.Exists(cadenaguardar.Text & "\" & versioncfdi & "\" & variablesformadas & ".xml") Then
                            grillaerrores.Rows.Add(grillaarchivos.Item(0, x).Value, "existe un archivo con el mismo nombre: " & variablesformadas & ".xml")
                        Else
                            FileCopy(grillaarchivos.Item(0, x).Value, cadenaguardar.Text & "\" & versioncfdi & "\" & variablesformadas & ".xml")
                        End If
                    End If
                Catch ex As Exception
                    grillaerrores.Rows.Add(grillaarchivos.Item(0, x).Value, ex.Message)
                End Try
            Catch ex As Exception
            End Try

        Next
        Cursor = Cursors.Default
        grillaarchivos.Rows.Clear()
        MsgBox("Proceso Terminado", MsgBoxStyle.Information, "Finalizar")

        If grillaerrores.Rows.Count > 0 Then
            MsgBox("Existen Errores: " & grillaerrores.Rows.Count & " Errores", MsgBoxStyle.Information, "Finalizar")
        Else
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = "Renombra archivos de acuerdo a los datos en cada XML" & Chr(13) & " Forma: SUC_RFC_SERIE Y FOLIO_FECHA DOCUMENTO"
    End Sub

    Private Function VarXml(ByRef xAtt As XmlElement, ByVal strVar As String) As String
        VarXml = xAtt.GetAttribute(strVar)
        If VarXml = Nothing Then VarXml = ""
    End Function

    Private Function ExtraerVariables(ByVal strXML) As String
        Dim xDoc As XmlDocument
        Dim xNodo As XmlNodeList
        Dim xAtt As XmlElement
        Dim rfc As String = ""
        Dim serie As String = ""
        Dim folio As String = ""
        Dim fecha As String = ""
        Dim total As String = ""
        Dim foliorecepcion As String = ""
        Dim ordencompra As String = ""

        versioncfdi = ""
        uuidCFDI = ""
        numeroaprobacion = ""
        Dim razon As String = ""
        Dim RESULTADO As String = ""
        xDoc = New XmlDocument
        xDoc.Load(strXML)
        xNodo = xDoc.GetElementsByTagName("cfdi:Comprobante")
        If xNodo.Count > 0 Then
            For Each xAtt In xNodo
                serie = VarXml(xAtt, "serie")
                folio = VarXml(xAtt, "folio")
                fecha = VarXml(xAtt, "fecha")
                versioncfdi = VarXml(xAtt, "version")
                total = VarXml(xAtt, "total")
                Try
                    Dim vec() As String
                    vec = Split(fecha, "T")
                    fecha = vec(0)
                Catch ex As Exception
                    fecha = "ERROR FECHA"
                End Try
            Next
        End If

        xNodo = xDoc.GetElementsByTagName("cfdi:Emisor")
        If xNodo.Count > 0 Then
            For Each xAtt In xNodo
                rfc = VarXml(xAtt, "rfc")
                razon = VarXml(xAtt, "nombre")
            Next
        End If

        xNodo = xDoc.GetElementsByTagName("tfd:TimbreFiscalDigital")
        If xNodo.Count > 0 Then
            For Each xAtt In xNodo
                uuidCFDI = VarXml(xAtt, "UUID")
            Next
        End If

        If versioncfdi <> "3.2" Then
            xDoc = New XmlDocument
            xDoc.Load(strXML)
            xNodo = xDoc.GetElementsByTagName("Comprobante")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo
                    'strTipoComprobante = VarXml(xAtt, "tipoDeComprobante")
                    serie = VarXml(xAtt, "serie")
                    folio = VarXml(xAtt, "folio")
                    fecha = VarXml(xAtt, "fecha")
                    versioncfdi = VarXml(xAtt, "version")
                    numeroaprobacion = VarXml(xAtt, "noAprobacion")
                    total = VarXml(xAtt, "total")

                    Try
                        Dim vec() As String
                        vec = Split(fecha, "T")
                        fecha = vec(0)
                    Catch ex As Exception
                        fecha = "ERROR FECHA"
                    End Try
                Next
            End If

            xNodo = xDoc.GetElementsByTagName("Emisor")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo
                    rfc = VarXml(xAtt, "rfc")
                    razon = VarXml(xAtt, "nombre")
                Next
            End If
        End If

        If serie.Length > 0 Or folio.Length > 0 Then
            seriefolio = True
            RESULTADO = rfc & "_" & serie & folio & "_" & fecha
        Else
            seriefolio = False
            If versioncfdi <> "3.2" Then
                RESULTADO = rfc & "_" & numeroaprobacion & "_" & fecha
            Else
                RESULTADO = rfc & "_" & uuidCFDI & "_" & fecha
            End If
        End If


        If RESULTADO = "__" Then
            griddatosxml.Rows.Add("No encontrado", "No encontrado", "No encontrado", "No encontrado", "No encontrado", strXML, "No encontrado", "No encontrado", "No encontrado", total, foliorecepcion, ordencompra)
        Else
            griddatosxml.Rows.Add(rfc, razon, folio, serie, fecha, strXML, versioncfdi, uuidCFDI, numeroaprobacion, total, foliorecepcion, ordencompra)
        End If

        Return RESULTADO

    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If grillaerrores.RowCount < 1 Then
            Exit Sub
        End If
        guardarerrores.FileName = ""
        guardarerrores.Filter = "Excel 2007 y Superior|*.xlsx| Excel 2003|*.xls"
        guardarerrores.Title = "Exportar Errores A Excel"
        guardarerrores.ShowDialog()

        If guardarerrores.FileName.Length > 1 Then
            exportaraexcel(grillaerrores, guardarerrores.FileName, "Errores")
        Else
            MsgBox("Elige donde Guardar...", MsgBoxStyle.Critical, "Importa Excel")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        limpiarCuadrosdetexto(Me)
        grillaarchivos.Rows.Clear()
        grillaerrores.Rows.Clear()
        griddatosxml.Rows.Clear()
        Label5.Text = "Archivos a Remplazar: 0"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        guardarerrores.FileName = ""
        guardarerrores.Filter = "Excel 2007 y Superior|*.xlsx| Excel 2003|*.xls"
        guardarerrores.Title = "Exportar Errores A Excel"
        guardarerrores.ShowDialog()

        exportaraexcel(griddatosxml, guardarerrores.FileName, "datosxml")

    End Sub
End Class
