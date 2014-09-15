Imports MySql.Data.MySqlClient

Public Class contactosmasivo

    Public idproveedor As String

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

        If gridtabla.Rows.Count > 0 Then
        Else
            MsgBox("No existen datos", MsgBoxStyle.Information, "Sin datos")
            Exit Sub
        End If

        Cursor.Current = Cursors.WaitCursor
        guardar()
        Cursor.Current = Cursors.Default

    End Sub

    Public Sub guardar()


        For x As Integer = 0 To gridtabla.RowCount - 1
            Try

                varconeccion()
                coneccion.Open()
                Dim agrega As String = "insert into contactos values (@idproveedor,@nombre,@puesto,@telefonos,@contacto,@otrosdatos,default)"
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@idproveedor", idproveedor)
                comando.Parameters.AddWithValue("@nombre", gridtabla.Item(1, x).Value)
                comando.Parameters.AddWithValue("@puesto", gridtabla.Item(2, x).Value)
                comando.Parameters.AddWithValue("@telefonos", gridtabla.Item(3, x).Value)
                comando.Parameters.AddWithValue("@contacto", gridtabla.Item(4, x).Value)
                comando.Parameters.AddWithValue("@otrosdatos", gridtabla.Item(5, x).Value)
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Cursor.Current = Cursors.Default
                MsgBox("Error fila: " & x + 1 & " Tipo Error: " & ex.Message, MsgBoxStyle.Exclamation, "Error al guardar Datos")
                coneccion.Close()
                Exit For
            End Try
        Next
        Cursor.Current = Cursors.Default
        MsgBox("Datos guardados...", MsgBoxStyle.Information, "Trabajo Terminado")
        contactos.consultar("Select * from contactos where idproveedor='" & idproveedor & "' order by idcontacto desc")
        Me.Close()

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
