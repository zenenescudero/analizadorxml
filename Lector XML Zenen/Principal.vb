Imports System.IO
Imports System.Security.Principal



Public Class Principal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            origendatos()
        Catch ex As Exception
        End Try

        If getValidaUserName("NO") = False Then
            Me.Close()
        End If

    End Sub


    Private Sub FacturaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem1.Click
        formlocal = leerxml
        mostrarform(formlocal)
    End Sub



    Private Sub OrigenDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrigenDeDatosToolStripMenuItem.Click
        OrigenDatps.Show()
    End Sub

    Private Sub ConfigurarCorreoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurarCorreoToolStripMenuItem.Click
        formlocal = zmmmasivo
        mostrarform(formlocal)
    End Sub

    Private Sub CargaDeCertificadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargaDeCertificadosToolStripMenuItem.Click
        formlocal = mir6masivo
        mostrarform(formlocal)
    End Sub

    Private Sub ReportesZMMMIR6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesZMMMIR6ToolStripMenuItem.Click
        formlocal = consulta
        mostrarform(formlocal)
    End Sub

    Private Sub salirdelsistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirdelsistemaToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click

        If getPermisosFormulario("proveedores") Then
        Else
            MsgBox("No tienes permiso para este formulario" & Chr(13) & "Solicitalo con Zenen Escudero (zcruz@chedraui.com.mx)")
            Exit Sub
        End If

        formlocal = proveedores
        mostrarform(formlocal)


    End Sub

    Private Sub InformacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionToolStripMenuItem.Click

        Acerca_de.Show()

    End Sub

    Private Sub ExtraerDatosXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraerDatosXMLToolStripMenuItem.Click

        formlocal = extraedatosxml
        mostrarform(formlocal)

    End Sub
End Class
