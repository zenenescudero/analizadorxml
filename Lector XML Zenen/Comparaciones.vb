Imports MySql.Data.MySqlClient

Public Class Comparaciones

    Private Sub Comparaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Comparaciones_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If consulta.RadioFALTANTES.Checked = True Then
            Try

                Try
                    Cursor.Current = Cursors.WaitCursor
                    coneccion.Open()
                    Dim comando As New MySqlCommand("update zmmvsmir6oc set revisado='SI' where id='" & consulta.gridtabla.Item(consulta.gridtabla.Columns("id").Index, consulta.gridtabla.CurrentRow.Index).Value & "'", coneccion)
                    comando.CommandType = CommandType.Text
                    comando.CommandTimeout = 0
                    comando.ExecuteNonQuery()
                    coneccion.Close()
                    Cursor.Current = Cursors.Default
                Catch ex As Exception
                    coneccion.Close()
                    Cursor.Current = Cursors.Default
                End Try
                consulta.gridtabla.Item(consulta.gridtabla.Columns("REVISADO").Index, consulta.gridtabla.CurrentRow.Index).Value = "SI"
                Me.Close()
            Catch ex As Exception
            End Try
        Else
            Try

                Try
                    Cursor.Current = Cursors.WaitCursor
                    coneccion.Open()
                    Dim comando As New MySqlCommand("update zmmvsmir6 set revisado='SI' where id='" & consulta.gridtabla.Item(consulta.gridtabla.Columns("id").Index, consulta.gridtabla.CurrentRow.Index).Value & "'", coneccion)
                    comando.CommandType = CommandType.Text
                    comando.CommandTimeout = 0
                    comando.ExecuteNonQuery()
                    coneccion.Close()
                    Cursor.Current = Cursors.Default
                Catch ex As Exception
                    coneccion.Close()
                    Cursor.Current = Cursors.Default
                End Try
                consulta.gridtabla.Item(consulta.gridtabla.Columns("REVISADO").Index, consulta.gridtabla.CurrentRow.Index).Value = "SI"
                Me.Close()
            Catch ex As Exception
            End Try
        End If
        
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class