Imports MySql.Data.MySqlClient

Public Class Comparacionesxml

    Private Sub Comparaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Comparaciones_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Enabled = True
    End Sub

End Class