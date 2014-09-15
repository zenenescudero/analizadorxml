Imports MySql.Data.MySqlClient

Public Class editarproveedor

    Dim valido As Boolean

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Principal.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TxtRFC.Text = Trim(TxtRFC.Text)
        TxtNom.Text = Trim(TxtNom.Text)
        TxtCom.Text = Trim(TxtCom.Text)
        txtclave.Text = Trim(txtclave.Text)
        
        If Trim(TxtNom.Text).Length > 0 Then
        Else
            MsgBox("Razon Social es Obligatorio", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If Trim(txtclave.Text).Length > 0 Then
        Else
            MsgBox("Clave es Obligatorio", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
     
        If validasolomayusculasynumeros(TxtRFC.Text) Then
        Else
            MsgBox("El RFC solo puede contener Letras Mayusculas y Numeros, 12 o 13 caracteres")
            Exit Sub
        End If

        Try

            varconeccion()
            coneccion.Open()
            'metodo nuevo agrgar
            Dim agrega As String = "update proveedores set rfc=@rfc,razon_social=@nombre,observaciones=@observaciones,clave=@clave where id=@idref"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@rfc", TxtRFC.Text)
            comando.Parameters.AddWithValue("@nombre", TxtNom.Text)
            comando.Parameters.AddWithValue("@observaciones", TxtCom.Text)
            comando.Parameters.AddWithValue("@clave", txtclave.Text)
            comando.Parameters.AddWithValue("@idref", Convert.ToInt32(vec(4)))
            comando.ExecuteNonQuery()
            'metodo nuevo
            coneccion.Close()
            MsgBox("Proveedor Editado Correctamente")
            proveedores.consultar("select * from proveedores order by clave desc")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error..." & ex.Message, MsgBoxStyle.Critical, "Error")
            coneccion.Close()
        End Try

    End Sub


    Private Sub solonumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub nuevocliente_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Enabled = True
    End Sub


    Private Sub noescribirpipe(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNom.KeyPress, TxtRFC.KeyPress
        If e.KeyChar = "|" Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub editarcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNom.Text = vec(2)
        TxtRFC.Text = vec(1)
        txtclave.Text = vec(0)
        TxtCom.Text = vec(3)
        
    End Sub

    Private Sub TxtCom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCom.TextChanged

    End Sub
End Class