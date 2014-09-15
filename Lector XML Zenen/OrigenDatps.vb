
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class OrigenDatps

    Private Sub OrigenDatps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            origendatos()
        Catch ex As Exception
        End Try

        Try
            txtservidor.Text = servidor
            txtuser.Text = usuario
            txtpas.Text = contrasena
            If puerto.Length > 0 Then
                txtpuerto.Text = puerto
            End If
        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub btnentrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnentrar.Click
        If Trim(txtservidor.Text).Length < 1 Or Trim(txtuser.Text).Length < 1 Then
            MsgBox("Dever rellenar todos los campos", MsgBoxStyle.Information, "Configuracion")
            Exit Sub
        End If

        If MsgBox(" Estas seguro de cambiar" & Chr(13) & "la Información de basede datos" & Chr(13) & "Esto Podria Generar Errores.", vbOKCancel, "Confirmación") = vbOK Then
            Cursor.Current = Cursors.WaitCursor
            Try
                File.WriteAllText("inicio.ini", "")
                Dim crear As StreamWriter = File.AppendText("inicio.ini")
                crear.WriteLine(Trim(txtservidor.Text))
                crear.WriteLine(Trim(txtuser.Text))
                crear.WriteLine(Trim(txtpas.Text))
                crear.WriteLine(Trim(txtpuerto.Text))
                crear.Close()
                origendatos()
                Try
                    varconeccion()
                    coneccion.Open()
                    coneccion.Close()
                Catch ex As Exception
                    Cursor.Current = Cursors.Default
                    MsgBox("los datos no son validos", MsgBoxStyle.Critical, "Configuracion")
                    coneccion.Close()
                    Exit Sub
                End Try
                Me.Close()
                Cursor.Current = Cursors.Default
                MsgBox("Origen De datos Registrado", vbOKOnly, "Configuración")
                origendatos()
            Catch ex As Exception
                Cursor.Current = Cursors.Default
                MsgBox("Error..." & ex.Message, vbOKOnly, "Configuración")
            End Try
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button1.Visible = True
            Button2.Visible = True
            TextBox1.Visible = True
        Else
            Button1.Visible = False
            Button2.Visible = False
            TextBox1.Visible = False
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class