Imports MySql.Data.MySqlClient

Public Class proveedoresmasivo


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Length > 0 Then
            gridtabla.Columns.Clear()

            Try
                Dim workbook1 = New ClosedXML.Excel.XLWorkbook(OpenFileDialog1.FileName)
                Dim worksheet = workbook1.Worksheet(1)
                Dim x As Integer = 1
                Dim texto2 As String = worksheet.Cell(1, 1).Value
                While (texto2.Length > 0)
                    gridtabla.Columns.Add(texto2, texto2)
                    x = x + 1
                    texto2 = Trim(worksheet.Cell(1, x).Value)
                End While
                Dim columnas As Integer = x

                Dim vector(columnas) As String
                x = 2
                Dim texto As String = worksheet.Cell(2, 1).Value

                While (texto.Length > 0)
                    For y As Integer = 1 To columnas
                        vector(y - 1) = Trim(worksheet.Cell(x, y).Value)
                    Next
                    gridtabla.Rows.Add(vector)
                    x = x + 1
                    texto = Trim(worksheet.Cell(x, 1).Value)
                End While

                MsgBox("Termino la Importación de datos", MsgBoxStyle.Information, "Datos de Excel")
            Catch ex As Exception
                MsgBox("Error al abrir el archivo", MsgBoxStyle.Critical, "Error al Importar")
            End Try
        Else
            MsgBox("Elige el Origen de datos", MsgBoxStyle.Critical, "Error al Importar")
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            If MsgBox("Estas seguro de elimnar los datos Existentes en la Base de Datos", MsgBoxStyle.OkCancel, "Eliminar datos Existentes") = vbOK Then
            Else
                Exit Sub
            End If
        End If

        If gridtabla.Rows.Count > 0 Then
        Else
            MsgBox("No existen datos", MsgBoxStyle.Information, "Sin datos")
            Exit Sub
        End If

        guardar()

    End Sub

    Public Sub guardar()

        Dim idinicial As Integer

        Try
            idinicial = consultaruncampo("select max(id) from proveedores")
        Catch ex As Exception
            idinicial = 0
        End Try

        varconeccion()

        Dim agrega As String = "insert into proveedores values(" '" & Trim(TABLA.Text) & " values("
        For x As Integer = 1 To gridtabla.Columns.Count
            agrega = agrega & "@v" & x
            If x < gridtabla.Columns.Count Then
                agrega = agrega & ","
            End If
        Next
        agrega = agrega & ")"

        For x As Integer = 0 To gridtabla.RowCount - 1
            Try
                coneccion.Open()
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                For y As Integer = 0 To gridtabla.Columns.Count - 1
                    comando.Parameters.AddWithValue("@v" & (y + 1), gridtabla.Item(y, x).Value)
                Next

                comando.ExecuteNonQuery()
                coneccion.Close()

            Catch ex As Exception
                MsgBox("Error fila: " & x + 1 & " Tipo Error: " & ex.Message, MsgBoxStyle.Exclamation, "Error al guardar Datos")
                coneccion.Close()
                cargafail(idinicial)
                MsgBox("No se Agregaron datos", MsgBoxStyle.Information, "Error")
                Exit Sub
            End Try
        Next

        If CheckBox1.Checked Then
            Try
                coneccion.Open()
                Dim coman As New MySqlCommand("delete from proveedores where id<=" & idinicial & "", coneccion)
                coman.CommandType = CommandType.Text
                coman.ExecuteNonQuery()
                coneccion.Close()
            Catch ex As Exception
                coneccion.Close()
                MsgBox("fallo la eliminacion de datos")
                Exit Sub
            End Try
        End If

        MsgBox("Datos guardados...", MsgBoxStyle.Information, "Trabajo Terminado")
        proveedores.consultar("Select * from proveedores order by clave desc")
        Me.Close()

    End Sub

    Public Sub cargafail(ByVal fila As Integer)
        Try
            coneccion.Open()
            Dim coman As New MySqlCommand("delete from facturas where id>" & fila & "", coneccion)
            coman.CommandType = CommandType.Text
            coman.ExecuteNonQuery()
            coneccion.Close()
        Catch ex As Exception
            coneccion.Close()
            MsgBox("fallo la eliminacion de datos")
            Exit Sub
        End Try
    End Sub

    Private Sub gridtabla_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles gridtabla.RowsAdded
        REGISTROS.Text = "Registros: " & gridtabla.Rows.Count
    End Sub

    Private Sub gridtabla_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles gridtabla.RowsRemoved
        REGISTROS.Text = "Registros: " & gridtabla.Rows.Count
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        gridtabla.Columns.Clear()
    End Sub


    Private Sub facturasmasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
