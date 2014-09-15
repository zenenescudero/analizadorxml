Imports MySql.Data.MySqlClient
Imports System.IO
Imports ClosedXML.Excel
Imports System.Text.RegularExpressions

Module codigosespeciales
    Public formactivo As Form
    Public formlocal As Form
    Public vec(20) As String
    Public coneccion As New MySqlConnection
    Public servidor As String
    Public usuario As String
    Public contrasena As String
    Public puerto As String
    Public emailclienteenvio As String = ""
    Public varurltimbrado As String = ""
    Public varurlcancelar As String = ""
    Public varusuariotimbre As String = ""
    Public varpasstimbre As String = ""
    Public impresora As String = ""
    Public erroralrimbrarnomina As Boolean = False
    Public patron As Regex
    Public username As String = ""


    Public Function getPermisosFormulario(ByVal formulario As String) As Boolean

        Try
            If consultaruncampo("select usuario from permisos where formulario ='" & formulario & "' and usuario = '" & username & "'") = username Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getValidaUserName(ByRef activo As String) As Boolean

        Try
            username = Environment.UserName()
        Catch ex As Exception
            username = ""
            username = InputBox(activo & Chr(13) & "Cual es tu nombre de Usuario: ")
        End Try

        Try
            activo = consultaruncampo("Select activo from usuarios where username='" & username & "' ")
        Catch ex1 As Exception
            activo = "NO"
        End Try

        If activo = "SI" Then
            Return True
        Else
            MsgBox("El Usuario: --- " & username & " --- no esta registrado para usar la Aplicacción" & Chr(13) & "Solicita Permiso con : Zenen Escudero " & Chr(13) & "(zcruz@chedraui.com.mx)")
            activo = "NO"
            Return False
        End If

    End Function



    Public Function validasolomayusculasynumeros(ByVal cadena As String) As Boolean
        patron = New Regex("^[A-Z0-9]*$")

        If (patron.IsMatch(cadena)) And (cadena.Length >= 12 And cadena.Length <= 13) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function validarcandena(ByVal cadena As String) As Boolean
        patron = New Regex("^[A-Z0-9]*$")

        If (patron.IsMatch(cadena)) Then
            Return True
        Else
            Return False
        End If

    End Function


    'metood para sumar una columna de una grilla
    Public Function sumarcolumnadegrilla(ByVal grilla As DataGridView, ByVal idcampo As Integer) As Double
        Dim suma As Double = 0
        For r As Integer = 0 To grilla.RowCount
            Try
                suma = suma + Convert.ToDouble(grilla.Item(idcampo, r).Value)
            Catch ex As Exception
            End Try
        Next
        Return suma
    End Function


    Public Sub generartxtdetabla(ByVal tabla As DataTable, ByVal archivo As String)
        Dim crear As StreamWriter = File.AppendText(archivo)

        For Each r As DataRow In tabla.Rows
            For c As Integer = 0 To tabla.Columns.Count - 1
                crear.Write(r.Item(c) & "|")
            Next
            crear.WriteLine()
        Next
        crear.Close()

    End Sub

    Public Sub cargarbasededatos(ByVal carpetarespaldo As String)

        For Each arc As String In Directory.EnumerateFiles(carpetarespaldo)
            Dim tabla As String = ""
            Try 'eliminar datos de la tabla
                varconeccion()
                coneccion.Open()
                Dim eliminar As New MySqlCommand
                eliminar.Connection = coneccion
                Dim vec1() As String = Split(arc, "\")
                tabla = vec1(vec1.Length - 1)
                eliminar.CommandText = "delete from " & tabla
                eliminar.ExecuteNonQuery()
                coneccion.Close()
            Catch ex As Exception
                coneccion.Close()
            End Try

            Dim leer As StreamReader = File.OpenText(arc)
            Dim linea As String = ""
            Try
                linea = leer.ReadLine.ToString
            Catch ex As Exception
                linea = ""
            End Try

            While (linea.Length > 0) 'leer todas las lineas asta que sea vacio

                Dim vec() As String = Split(linea, "|")
                Dim valores As String = "("
                For x As Integer = 0 To vec.Length - 2
                    If x = vec.Length - 2 Then
                        valores = valores & "@v" & x & ")"
                    Else
                        valores = valores & "@v" & x & ","
                    End If
                Next

                'insertamos el el registro en la base de datos
                Try
                    varconeccion()
                    coneccion.Open()
                    'nueva forma de agregar
                    Dim agrega As String = "insert into  " & tabla & " values" & valores
                    Dim comando As New MySqlCommand(agrega, coneccion)
                    comando.CommandType = CommandType.Text
                    For x As Integer = 0 To vec.Length - 2
                        If IsDate(vec(x)) Then
                            Try
                                Dim f As DateTime = vec(x)
                                comando.Parameters.AddWithValue("@v" & x, f)
                            Catch ex As Exception
                            End Try
                        Else
                            comando.Parameters.AddWithValue("@v" & x, vec(x))
                        End If

                    Next
                    comando.ExecuteNonQuery()
                    coneccion.Close()
                Catch ex As Exception
                    coneccion.Close()
                End Try
                Try
                    linea = leer.ReadLine.ToString
                Catch ex As Exception
                    linea = ""
                End Try
            End While
            leer.Close()
        Next

    End Sub

    Public Sub respaldartablasdebase(ByVal carpetarespaldo As String)


        If Directory.Exists(carpetarespaldo) Then
        Else
            Try
                Directory.CreateDirectory(carpetarespaldo)
            Catch ex As Exception
            End Try
        End If

        Dim tablasdelabase As New DataTable
        tablasdelabase = consultartabla("show tables")
        For Each tabla As DataRow In tablasdelabase.Rows
            File.WriteAllText(carpetarespaldo & "\" & tabla.Item(0) & "", "")
            generartxtdetabla(consultartabla("select * from " & tabla.Item(0) & ""), carpetarespaldo & "\" & tabla.Item(0) & "")
        Next
    End Sub


    'metodo para limpiar los cuador de texto de un formulario
    Public Sub limpiarCuadrosdetexto(ByVal formulario As Form)

        Dim Text As Object
        For Each Text In formulario.Controls
            If TypeOf Text Is TextBox Then
                Dim txtTemp As TextBox = CType(Text, TextBox)
                txtTemp.Text = ""
            End If
        Next
    End Sub

    Public Function consultartabla(ByVal consulta As String) As DataTable

        Dim dset As New DataSet
        Try
            varconeccion()
            coneccion.Open()
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand(consulta, coneccion)
            dadaptador.Fill(dset)
            coneccion.Close()

        Catch ex As Exception
            coneccion.Close()
        End Try

        Return dset.Tables(0)

    End Function


    Public Sub exportaraexcel(ByVal grid As DataGridView, ByVal ruta As String, ByVal proviene As String, ByVal ParamArray ocultar() As String)
        Try

            Cursor.Current = Cursors.WaitCursor


            Dim gridextra As New DataGridView
            gridextra.ColumnCount = grid.ColumnCount
            For x As Integer = 0 To grid.ColumnCount - 1
                gridextra.Columns(x).Name = grid.Columns(x).Name
                gridextra.Columns(x).HeaderText = grid.Columns(x).HeaderText
            Next

            For X As Integer = 0 To grid.RowCount - 1
                gridextra.Rows.Add()
                For y As Integer = 0 To grid.ColumnCount - 1
                    gridextra.Item(y, X).Value = grid.Item(y, X).Value
                Next
            Next

            For Each valor As String In ocultar
                Try
                    gridextra.Columns.Remove(valor)
                Catch ex As Exception
                End Try
            Next


            Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
            Dim worksheet = workbook1.Worksheets.Add(proviene)

            ' asigana encabezados
            For x1 As Integer = 0 To gridextra.ColumnCount - 1
                worksheet.Cell(1, x1 + 1).Value = gridextra.Columns(x1).HeaderText
            Next
            'Asgina filas

            For X As Integer = 0 To gridextra.RowCount - 1

                For y As Integer = 0 To gridextra.ColumnCount - 1
                    worksheet.Cell(X + 2, y + 1).Value = gridextra.Item(y, X).Value
                Next

            Next
            ruta = ruta
            workbook1.SaveAs(ruta)
            Cursor.Current = Cursors.Default

            If MsgBox("Deseas Abrir El archivo", MsgBoxStyle.YesNo, "Exportacion Finalizada...") = MsgBoxResult.Yes Then

                System.Diagnostics.Process.Start(ruta) 'Abre el archivo 
            Else

            End If
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Sub origendatos()
        Dim leer As StreamReader = File.OpenText("inicio.ini")
        servidor = leer.ReadLine()
        usuario = leer.ReadLine()
        contrasena = leer.ReadLine()
        puerto = leer.ReadLine()
        leer.Close()

    End Sub

    'fin variables usuario

    'cargar formularios en panel
    Public Sub mostrarform(ByVal Formlocal)

        If formactivo Is Nothing Then
        Else
            If Formlocal.Equals(formactivo) Then
            Else
                formactivo.Close()
                formactivo.Dispose()
            End If
        End If
        formactivo = Formlocal
        formactivo.TopLevel = False
        formactivo.Parent = Principal.contenedor()
        formactivo.Show()

    End Sub
    ' fin cargar formularios en panel

    Public Sub varconeccion()
        coneccion.ConnectionString = "server=" & servidor & ";userid=" & usuario & ";password=" & contrasena & ";database=mir6;port=" & puerto & ""
    End Sub


    Public Sub opcionescombo( _
        ByVal ComboBox As ComboBox, _
        ByVal sql As String)
        'se rellena el combo el primer valor sera el identificador el segundo sera la descripcion.
        varconeccion()
        Try
            ' Abrir la conexión a Sql  
            coneccion.Open()
            ' Pasar la consulta sql y la conexión al Sql Command   
            Dim cmd As New MySqlCommand(sql, coneccion)
            ' Inicializar un nuevo SqlDataAdapter   
            Dim da As New MySqlDataAdapter(cmd)
            'Crear y Llenar un Dataset  
            Dim ds As New DataSet
            da.Fill(ds)
            ' asignar el DataSource al combobox  
            ComboBox.DataSource = ds.Tables(0)
            ' Asignar el campo a la propiedad DisplayMember del combo   
            ComboBox.DisplayMember = ds.Tables(0).Columns(1).Caption.ToString
            ComboBox.ValueMember = ds.Tables(0).Columns(0).Caption.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, _
                            "error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            coneccion.Close()

        Finally
            If coneccion.State = ConnectionState.Open Then
                coneccion.Close()
            End If
        End Try

    End Sub
    Public Function consultaruncampo(ByVal consulta As String) As String
        Dim dset As New DataSet
        Dim respuesta As String
        Try
            varconeccion()
            coneccion.Open()
            Dim dadaptador As New MySqlDataAdapter

            dadaptador.SelectCommand = New MySqlCommand(consulta, coneccion)
            dadaptador.Fill(dset)
            coneccion.Close()

        Catch ex As Exception
            coneccion.Close()
        End Try
        Try
            respuesta = dset.Tables(0).Rows(0)(0)
        Catch ex As Exception
            respuesta = ""
        End Try

        Return respuesta
    End Function
    Public Function obtenerextension(ByVal archivoselecionado As OpenFileDialog) As String
        Dim extension As String = ""

        Try
            Dim archivo As String = archivoselecionado.SafeFileName
            archivo = StrReverse(archivo)
            Dim cadenas() As String = Split(archivo, ".")
            extension = StrReverse(cadenas(0))
        Catch ex As Exception
            extension = ""
        End Try
        Return "." & extension
    End Function

    Public Sub convertirdebinarioaarchivo(ByVal aByte() As Byte, _
                           ByVal fileName As String, ByVal visualizar As String)

        ' El procedimiento creará un archivo con la secuencia de bytes
        ' especificada en el argumento.

        ' Compruebo los distintos parámetros pasados a la función.
        '
        If (aByte Is Nothing) Then _
            Throw New ArgumentNullException("aByte", "No se ha especificado ningún array de Bytes.")

        If (String.IsNullOrEmpty(fileName)) Then _
            Throw New ArgumentNullException("fileName", "No se ha especificado el archivo de destino.")

        Try
            ' Compruebo si existe el archivo especificado.
            '
            If visualizar <> "SI" Then
                If (File.Exists(fileName)) Then
                    If (MessageBox.Show("Ya existe un archivo con el mismo nombre. " & _
                        "¿Desea sobrescribirlo?", _
                        "Grabar archivo", _
                        MessageBoxButtons.YesNo, _
                        MessageBoxIcon.Question) = _
                        Windows.Forms.DialogResult.No) Then Return

                    ' Elimino el archivo
                    File.Delete(fileName)
                End If
            Else
                File.Delete(fileName)
            End If


            ' Número de bytes que se van a escribir
            Dim data As Integer = aByte.Length

            ' Obtengo el nombre de un archivo temporal, donde
            ' primeramente se guardará el documento.
            '
            Dim tempFileName As String = Path.GetTempFileName()

            ' Abrimos o creamos el archivo.
            Using fs As New FileStream(tempFileName, FileMode.OpenOrCreate)

                ' Crea el escritor para los datos.
                Dim bw As New BinaryWriter(fs)

                ' Escribimos en el archivo los datos realmente leídos.
                bw.Write(aByte, 0, data)

                ' Borra todos los búferes del sistema de escritura actual y hace
                ' que todos los datos almacenados en el búfer se escriban en el
                ' dispositivo subyacente. 
                bw.Flush()

                bw = Nothing

            End Using

            ' Muevo el archivo a la ruta indicada.
            '
            File.Move(tempFileName, fileName)

            If visualizar = "SI" Then
                Process.Start(fileName)
            Else
                MsgBox("El archivo se descargo :) " & fileName, MsgBoxStyle.Information, "Descarga de Comprobante")
            End If

        Catch ex As Exception
            ' Devolvemos la excepción al procedimiento llamador.
            '
            Throw

        End Try

    End Sub

    Public Function convertirabinario(ByVal fileName As String) As Byte()

        ' Si no existe el archivo, abandono la función.
        '
        If (Not (File.Exists(fileName))) Then Return Nothing

        Try
            ' Creamos un objeto Stream para poder leer el archivo especificado.
            '
            Using fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)

                ' Creamos un array de bytes, cuyo límite superior se corresponderá
                ' con la longitud en bytes de la secuencia menos una unidad.
                '
                Dim length As Int32 = Convert.ToInt32(fs.Length - 1)

                Dim data() As Byte = New Byte(length) {}

                ' Al leer la secuencia, se rellenará la matriz.
                '
                fs.Read(data, 0, length)

                ' Devolvemos el array de bytes.
                '
                Return data

            End Using

        Catch ex As Exception
            ' Devolvemos la excepción al procedimiento llamador.
            '
            Throw
        End Try
    End Function

End Module

