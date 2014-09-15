Imports MySql.Data.MySqlClient

Public Class zmmmasivo


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Cursor.Current = Cursors.WaitCursor

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Length > 0 Then
            gridtabla.Columns.Clear()

            Try
                Dim workbook1 = New ClosedXML.Excel.XLWorkbook(OpenFileDialog1.FileName)
                Dim worksheet = workbook1.Worksheet(1)
                Dim x As Integer = 1
                Dim texto2 As String = Trim(worksheet.Cell(1, 1).Value)
                While (texto2.Length > 0)
                    gridtabla.Columns.Add(texto2, texto2)
                    x = x + 1
                    texto2 = Trim(worksheet.Cell(1, x).Value)
                End While
                Dim columnas As Integer = x

                Dim vector(columnas) As String
                x = 2
                Dim texto As String = Trim(worksheet.Cell(2, 1).Value)

                While (texto.Length > 0)

                    For y As Integer = 1 To columnas
                        If y = 13 Then
                            Try
                                vector(y - 1) = separartexto(Trim(worksheet.Cell(x, y).Value))
                            Catch ex As Exception
                                vector(y - 1) = Trim(worksheet.Cell(x, y).Value)
                            End Try
                        Else
                            vector(y - 1) = Trim(worksheet.Cell(x, y).Value)
                        End If
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
            MsgBox("Eligue el Origen de datos", MsgBoxStyle.Critical, "Error al Importar")
        End If
        Cursor.Current = Cursors.Default

    End Sub

    Public Function separartexto(ByVal texto As String) As String
        Dim serie As String = ""
        Dim folio As String = ""

        Try
            For x = 0 To texto.Length - 1
                If IsNumeric(texto.Chars(x)) Then
                    Try
                        serie = Mid(texto, 1, x)
                        folio = Convert.ToUInt64(Mid(texto, x + 1))
                    Catch ex As Exception
                        serie = texto
                        folio = ""
                    End Try
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
        Return serie & folio

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor.Current = Cursors.WaitCursor
        Label1.Text = "Guardando Registros..... espere...."
        If gridtabla.Rows.Count > 0 Then
        Else
            Cursor.Current = Cursors.Default
            Label1.Text = ""
            MsgBox("No existen datos", MsgBoxStyle.Information, "Sin datos")
            Exit Sub
        End If

        guardar()
        Cursor.Current = Cursors.Default

    End Sub

    Public Sub guardar()

        
        varconeccion()


        Try
            coneccion.Open()
            Dim comando As New MySqlCommand("delete from zmm where username='" & username & "'", coneccion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 0
            comando.ExecuteNonQuery()
            coneccion.Close()
        Catch ex As Exception
            coneccion.Close()
        End Try


        Try
            coneccion.Open()
            Dim comando As New MySqlCommand("call EliminarConsultas(@usuario)", coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@usuario", username)
            comando.CommandTimeout = 0
            comando.ExecuteNonQuery()
            coneccion.Close()
        Catch ex As Exception
            coneccion.Close()
        End Try



        Dim agrega As String = "insert into zmm values("
        For x As Integer = 1 To gridtabla.Columns.Count
            agrega = agrega & "@v" & x
            If x < gridtabla.Columns.Count Then
                agrega = agrega & ","
            End If
        Next
        agrega = agrega & ",@username)"

        For x As Integer = 0 To gridtabla.RowCount - 1
            Try
                coneccion.Open()
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                For y As Integer = 0 To gridtabla.Columns.Count - 1
                    comando.Parameters.AddWithValue("@v" & (y + 1), gridtabla.Item(y, x).Value)
                Next
                comando.Parameters.AddWithValue("@username", username)

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
        Label1.Text = "Registros Guardados correctamente"
        Cursor.Current = Cursors.Default
        MsgBox("Datos guardados..." & Chr(13) & "Registros Guardados: " & consultaruncampo("select count(*) from zmm where username='" & username & "'"), MsgBoxStyle.Information, "Trabajo Terminado")
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

    Private Sub zmmmasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = ""

        '   gridtabla.DataSource = consultartabla("select * from zmm where sociedad='n'")

        Try
            '   gridtabla.Columns("username").Visible = False
        Catch ex As Exception
        End Try
    End Sub
End Class
