Imports MySql.Data.MySqlClient

Public Class contactosnuevoeditar

    Public nuevo As Boolean
    Dim consulta As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Principal.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Txtpuesto.Text = Trim(Txtpuesto.Text)
        Txtnombre.Text = Trim(Txtnombre.Text)
        Txttelefonos.Text = Trim(Txttelefonos.Text)
        txtotrosdatos.Text = Trim(txtotrosdatos.Text)
        Txtcontacto.Text = Trim(Txtcontacto.Text)
        If Trim(Txtnombre.Text).Length > 0 Then
        Else
            MsgBox("Nombre es Obligatorio", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        Try

            If nuevo Then
                varconeccion()
                coneccion.Open()
                'metodo nuevo agrgar

                Dim agrega As String = "insert into contactos values (@idproveedor,@nombre,@puesto,@telefonos,@contacto,@otrosdatos,default)"
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@idproveedor", Txtidprov.Text)
                comando.Parameters.AddWithValue("@nombre", Txtnombre.Text)
                comando.Parameters.AddWithValue("@puesto", Txtpuesto.Text)
                comando.Parameters.AddWithValue("@telefonos", Txttelefonos.Text)
                comando.Parameters.AddWithValue("@contacto", Txtcontacto.Text)
                comando.Parameters.AddWithValue("@otrosdatos", txtotrosdatos.Text)
                comando.ExecuteNonQuery()
                'metodo nuevo
                coneccion.Close()
                MsgBox("Contacto Registrado Correctamente")
                contactos.consultar("select * from contactos where idproveedor='" & Txtidprov.Text & "' order by idcontacto desc")
                Me.Close()
            Else


                varconeccion()
                coneccion.Open()
                'metodo nuevo agrgar

                Dim agrega As String = "update contactos set nombre=@nombre,puesto=@puesto,telefonos=@telefonos,contacto=@contacto,otrosdatos=@otrosdatos where idcontacto=@idcontacto"
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                 comando.Parameters.AddWithValue("@nombre", Txtnombre.Text)
                comando.Parameters.AddWithValue("@puesto", Txtpuesto.Text)
                comando.Parameters.AddWithValue("@telefonos", Txttelefonos.Text)
                comando.Parameters.AddWithValue("@contacto", Txtcontacto.Text)
                comando.Parameters.AddWithValue("@otrosdatos", txtotrosdatos.Text)
                comando.Parameters.AddWithValue("@idcontacto", vec(6))

                comando.ExecuteNonQuery()
                'metodo nuevo
                coneccion.Close()
                MsgBox("Contacto Editado Correctamente")
                contactos.consultar("select * from contactos where idproveedor='" & Txtidprov.Text & "' order by idcontacto desc")
                Me.Close()
            End If
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



    Private Sub noescribirpipe(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtnombre.KeyPress, Txtpuesto.KeyPress, Txtidprov.KeyPress
        If e.KeyChar = "|" Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub nuevocliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If nuevo = False Then
            Txtidprov.Text = vec(0)
            Txtnombre.Text = vec(1)
            Txtpuesto.Text = vec(2)
            Txttelefonos.Text = vec(3)
            Txtcontacto.Text = vec(4)
            txtotrosdatos.Text = vec(5)
        Else

        End If



    End Sub
End Class