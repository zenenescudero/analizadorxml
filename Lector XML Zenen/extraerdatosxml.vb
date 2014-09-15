Imports System.IO
Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class extraedatosxml

    Dim versioncfdi As String = ""
    Dim uuidCFDI As String = ""
    Dim numeroaprobacion As String = ""
    Dim seriefolio As Boolean = True

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        directorio.Reset()
        directorio.ShowDialog()
        If directorio.SelectedPath.Length > 0 Then
            cadenaleer.Text = directorio.SelectedPath

            If SubCarpeta.Checked = True Then
                Label5.Text = "Archivos a Consultar:  " & Directory.GetFiles(directorio.SelectedPath, "*.xml", SearchOption.AllDirectories).Count()
            Else
                Label5.Text = "Archivos a Consultar:  " & Directory.GetFiles(directorio.SelectedPath, "*.xml", SearchOption.TopDirectoryOnly).Count()
            End If

        Else
            MsgBox("Selecciona una Carpeta")
            cadenaleer.Text = ""
            Label5.Text = "Archivos a Consultar: 0"
            Label3.Text = ""
        End If

    End Sub

    Function fechadentro(ByVal archivo As String) As Boolean


        Dim vec() As String = Split(archivo, "\")
        Dim aux As String = vec(vec.Length - 1).Substring(0, 8)

        aux = aux.Substring(6, 2) & "/" & aux.Substring(4, 2) & "/" & aux.Substring(0, 4)

        Dim fecha As Date


        Try
            fecha = aux
            If fecha >= fecha1.Value.ToShortDateString And fecha <= fecha2.Value.ToShortDateString Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        txtrfc.Text = Trim(txtrfc.Text)

        If cadenaleer.Text.Length > 0 Then
        Else
            MsgBox("No tiene direcctorio de Lectura", MsgBoxStyle.Exclamation, "Directorio")
            Exit Sub
        End If

        griddatosxml.Rows.Clear()
        Cursor = Cursors.WaitCursor


        If SubCarpeta.Checked = True Then

            For Each ARCHIVOd As String In Directory.GetFiles(directorio.SelectedPath, "*.xml", SearchOption.AllDirectories)
                If txtrfc.Text.Length > 0 Then
                    If InStr(ARCHIVOd, txtrfc.Text) > 0 Then
                        ExtraerVariables(ARCHIVOd)
                    End If
                Else
                    If filtrofecha.Checked Then
                        If fechadentro(ARCHIVOd) Then
                            ExtraerVariables(ARCHIVOd)
                        End If
                    Else
                        ExtraerVariables(ARCHIVOd)
                    End If
                End If
            Next
        Else

            For Each ARCHIVOd As String In Directory.GetFiles(directorio.SelectedPath, "*.xml", SearchOption.TopDirectoryOnly)
                If fechadentro(ARCHIVOd) Then

                End If

                If txtrfc.Text.Length > 0 Then
                    If InStr(ARCHIVOd, txtrfc.Text) > 0 Then
                        ExtraerVariables(ARCHIVOd)
                    End If
                Else
                    If filtrofecha.Checked Then
                        If fechadentro(ARCHIVOd) Then
                            ExtraerVariables(ARCHIVOd)
                        End If
                    Else
                        ExtraerVariables(ARCHIVOd)
                    End If
                End If
            Next
        End If



        Cursor = Cursors.Default
        Label3.Text = "Encontrados: " & griddatosxml.RowCount
        MsgBox("Proceso Terminado", MsgBoxStyle.Information, "Finalizar")


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Function VarXml(ByRef xAtt As XmlElement, ByVal strVar As String) As String
        VarXml = xAtt.GetAttribute(strVar)
        If VarXml = Nothing Then VarXml = ""
    End Function

    Private Function ExtraerVariables(ByVal strXML) As Boolean
        Dim xDoc As XmlDocument
        Dim xNodo As XmlNodeList
        Dim xAtt As XmlElement
        Dim rfc As String = ""
        Dim serie As String = ""
        Dim folio As String = ""
        Dim fecha As String = ""
        Dim total As String = ""
        Dim nooc As String = ""
        Dim foliorecepcion As String = ""
        Dim ordencompra As String = ""
        versioncfdi = ""
        uuidCFDI = ""
        numeroaprobacion = ""
        Dim razon As String = ""
        xDoc = New XmlDocument

        Try
            xDoc.Load(strXML)

            xNodo = xDoc.GetElementsByTagName("cfdi:Emisor")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo
                    rfc = VarXml(xAtt, "rfc")
                    razon = VarXml(xAtt, "nombre")
                Next
            End If


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

            Dim bandera1 As Boolean = False
            Dim bandera2 As Boolean = False

            ' PARTE PARA EXTRAER ADDENDA
            Dim reader As XmlTextReader = New XmlTextReader(strXML.ToString)

            Do While (reader.Read())
                Select Case reader.NodeType
                    Case XmlNodeType.Text 'Mostrar el texto de cada elemento.
                        If bandera1 Then
                            foliorecepcion = reader.Value
                            bandera1 = False
                        End If
                        If bandera2 Then
                            ordencompra = reader.Value
                            bandera2 = False
                        End If
                        If reader.Value = "Folio de Recepción" Then
                            bandera1 = True
                        End If
                        If reader.Value = "Orden de Compra" Then
                            bandera2 = True
                        End If
                End Select
            Loop
            'FINAL PARTE EXTRAE ADDENDA
            griddatosxml.Rows.Add(rfc, razon, folio, serie, fecha, strXML, versioncfdi, uuidCFDI, numeroaprobacion, total, foliorecepcion, ordencompra)
            Return True
        Catch ex As Exception
            griddatosxml.Rows.Add(rfc, razon, folio, serie, fecha, strXML, "Error: " & ex.Message, uuidCFDI, numeroaprobacion, total, foliorecepcion, ordencompra)
            Return False
        End Try

    End Function

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        limpiarCuadrosdetexto(Me)
        griddatosxml.Rows.Clear()
        Label5.Text = "Archivos Consultar: 0"
        Label3.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        guardarerrores.FileName = ""
        guardarerrores.Filter = "Excel 2007 y Superior|*.xlsx| Excel 2003|*.xls"
        guardarerrores.Title = "Exportar Errores A Excel"
        guardarerrores.ShowDialog()
        exportaraexcel(griddatosxml, guardarerrores.FileName, "datosxml")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If griddatosxml.RowCount > 0 Then
        Else
            MsgBox("No existen datos en la tabla para guardar", MsgBoxStyle.Information, "Datos XML")
        End If

        Try
            Cursor.Current = Cursors.WaitCursor
            guardar()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Public Sub guardar()

        varconeccion()

        Try
            coneccion.Open()
            Dim comando As New MySqlCommand("delete from datosxml where username='" & username & "'", coneccion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 0
            comando.ExecuteNonQuery()
            coneccion.Close()
        Catch ex As Exception
            coneccion.Close()
        End Try


        Dim agrega As String = "insert into datosxml values("

        For x As Integer = 1 To griddatosxml.Columns.Count
            agrega = agrega & "@v" & x
            If x < griddatosxml.Columns.Count Then
                agrega = agrega & ","
            End If
        Next
        agrega = agrega & ",@username,@texto)"

        For x As Integer = 0 To griddatosxml.RowCount - 1
            Try
                coneccion.Open()
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text

                For y As Integer = 0 To griddatosxml.Columns.Count - 1
                    comando.Parameters.AddWithValue("@v" & (y + 1), griddatosxml.Item(y, x).Value)
                Next

                comando.Parameters.AddWithValue("@username", username)
                comando.Parameters.AddWithValue("@texto", griddatosxml.Item(griddatosxml.Columns("serieg").Index, x).Value & griddatosxml.Item(griddatosxml.Columns("foliog").Index, x).Value)
                comando.ExecuteNonQuery()
                coneccion.Close()

            Catch ex As Exception
                Label1.Text = ""
                Cursor.Current = Cursors.Default
                MsgBox("Error fila: " & x + 1 & " Tipo Error: " & ex.Message, MsgBoxStyle.Exclamation, "Error al guardar Datos")
                coneccion.Close()
                MsgBox("No se Agregaron datos", MsgBoxStyle.Information, "Error")
                Exit Sub
            End Try

        Next

        Cursor.Current = Cursors.Default
        MsgBox("Datos guardados..." & Chr(13) & "Registros Guardados: " & consultaruncampo("select count(*) from datosxml where username='" & username & "'"), MsgBoxStyle.Information, "Trabajo Terminado")
        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrofecha.CheckedChanged
        If filtrofecha.Checked Then
            fecha1.Visible = True
            fecha2.Visible = True
            txtrfc.Text = ""
            txtrfc.Enabled = False
        Else
            fecha1.Visible = False
            fecha2.Visible = False
            txtrfc.Enabled = True
        End If
    End Sub
End Class
