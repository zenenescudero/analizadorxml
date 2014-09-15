Imports MySql.Data.MySqlClient

Public Class nuevoproveedores

    Dim valido As Boolean
    Dim consulta As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Principal.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TxtRFC.Text = Trim(TxtRFC.Text)
        TxtNom.Text = Trim(TxtNom.Text)
        TxtCom.Text = Trim(TxtCom.Text)
        Txtclave.Text = Trim(Txtclave.Text)


        Dim existe As String = consultaruncampo("Select Razon_Social from proveedores where clave='" & Txtclave.Text & "'")

        If existe.Length > 0 Then
            MsgBox("la Clave: " & Txtclave.Text & "  Esta registrada para la Razon Social: " & existe, MsgBoxStyle.Exclamation, "Clave Duplicada")
            Exit Sub
        End If

      
        If Trim(TxtNom.Text).Length > 0 Then
        Else
            MsgBox("Razon Social es Obligatorio", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If Trim(Txtclave.Text).Length > 0 Then
        Else
            MsgBox("Clave es Obligatorio", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If validasolomayusculasynumeros(TxtRFC.Text) Then
        Else
            MsgBox("El RFC solo puede contener Letras Mayusculas y Numeros, 12 o 13 caracteres")
            Exit Sub
        End If

        existe = consultaruncampo("Select Razon_Social from proveedores where rfc='" & TxtRFC.Text & "'")
        If existe.Length > 0 Then
            MsgBox("El RFC: " & TxtRFC.Text & "  Esta registrada para la Razon Social: " & existe, MsgBoxStyle.Exclamation, "Clave Duplicada")
            Exit Sub
        End If


        Try

            varconeccion()
            coneccion.Open()
            'metodo nuevo agrgar

            Dim agrega As String = "insert into proveedores values (@clave,@rfc,@nombre,@observaciones,default)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@clave", Txtclave.Text)
            comando.Parameters.AddWithValue("@rfc", TxtRFC.Text)
            comando.Parameters.AddWithValue("@nombre", TxtNom.Text)
            comando.Parameters.AddWithValue("@observaciones", TxtCom.Text)
            comando.ExecuteNonQuery()
            'metodo nuevo
            coneccion.Close()
            MsgBox("Proveedor Registrado Correctamente")
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



    Private Sub noescribirpipe(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNom.KeyPress, TxtRFC.KeyPress, Txtclave.KeyPress
        If e.KeyChar = "|" Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub nuevocliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class