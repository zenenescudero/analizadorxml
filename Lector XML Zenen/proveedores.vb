Imports MySql.Data.MySqlClient


Public Class proveedores

    Dim consulta As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        nuevoproveedores.Show()
        Principal.Enabled = False
    End Sub

    Private Sub clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            consulta = "select * from proveedores order by clave desc"
            consultar(consulta)
            generaresturctura()
        Catch ex As Exception
            MsgBox("Ocurrio un Error al realizar la conexión...")
            coneccion.Close()
        End Try

    End Sub

    Private Sub TxtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtrfc.TextChanged
        Try
            consulta = "select * from proveedores where rfc like '%" & Txtrfc.Text & "%'"
            consultar(consulta)

        Catch ex As Exception
            MsgBox("Ocurrio un Error al realizar la conexión Consultar Administrador...")
            coneccion.Close()
        End Try

    End Sub

    Private Sub TxtDom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtrazonsocial.TextChanged
        Try
            consulta = "select * from proveedores where razon_social like '%" & Txtrazonsocial.Text & "%' order by id"
            consultar(consulta)
        Catch ex As Exception
            MsgBox("Ocurrio un Error al realizar la conexión Consultar Administrador...")
            coneccion.Close()
        End Try


    End Sub

    Public Sub generaresturctura()

        GridClientes.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)
        'campos a mostrar
        GridClientes.Columns("clave").Visible = True
        GridClientes.Columns("rfc").Visible = True
        GridClientes.Columns("razon_social").Visible = True
        GridClientes.Columns("Observaciones").Visible = True
        GridClientes.Columns("id").Visible = False
        GridClientes.Columns("clave").HeaderText = "CLAVE"
        GridClientes.Columns("rfc").HeaderText = "RFC"
        GridClientes.Columns("Razon_Social").HeaderText = "Razon Social"
        GridClientes.Columns("Observaciones").HeaderText = "Observaciones"
        GridClientes.Columns("clave").Width = 100
        GridClientes.Columns("rfc").Width = 200
        GridClientes.Columns("razon_social").Width = 300
        GridClientes.Columns("Observaciones").Width = 400

        'fin tamaño campos
    End Sub
    Public Sub consultar(ByVal consulta As String)
        Try
            varconeccion()
            coneccion.Open()
            Dim dset As New DataSet
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand(consulta, coneccion)
            dadaptador.Fill(dset)
            coneccion.Close()
            GridClientes.DataSource = dset.Tables(0)
        Catch ex As Exception
            coneccion.Close()
        End Try
    End Sub

    Public Sub datoscliente()
        Try
            vec(0) = GridClientes.Item(0, GridClientes.CurrentRow.Index).Value
            vec(1) = GridClientes.Item(1, GridClientes.CurrentRow.Index).Value
            vec(2) = GridClientes.Item(2, GridClientes.CurrentRow.Index).Value
            vec(3) = GridClientes.Item(3, GridClientes.CurrentRow.Index).Value
            vec(4) = GridClientes.Item(4, GridClientes.CurrentRow.Index).Value
            editarproveedor.Show()
            Principal.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        If GridClientes.RowCount > 0 Then
            datoscliente()
        End If
    End Sub

    Private Sub GridClientes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridClientes.DoubleClick
        If GridClientes.RowCount > 0 Then
            datoscliente()
        End If
    End Sub


    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desactivar.Click
        If GridClientes.RowCount > 0 Then
        Else
            Exit Sub
        End If

        Dim gridid As String = GridClientes.Item(4, GridClientes.CurrentRow.Index).Value
        Dim gridcliente As String = GridClientes.Item(1, GridClientes.CurrentRow.Index).Value
        If MsgBox(" Estas seguro de Elimnar este RFC A : " + gridcliente, vbOKCancel, "Confirmación") = vbOK Then
            Try
                varconeccion()
                coneccion.Open()
                Dim eliminar As New MySqlCommand
                eliminar.Connection = coneccion
                eliminar.CommandText = "delete from proveedores where id='" & gridid & "'"
                eliminar.ExecuteNonQuery()
                coneccion.Close()
                consultar("select * from proveedores order by CLAVE desc")
            Catch ex As Exception
                coneccion.Close()
                MsgBox("se produjo un error " & ex.Message, vbQuestion, "Error del Sistema")
            End Try
        Else
        End If

    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GridClientes.RowCount < 1 Then
            Exit Sub
        End If

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx| Excel 2003|*.xls"
        SaveFileDialog1.Title = "Exportar A Excel"
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.Length > 1 Then
            exportaraexcel(GridClientes, SaveFileDialog1.FileName, "Proveedores", "id")
        Else
            MsgBox("Elige donde Guardar...", MsgBoxStyle.Critical, "Importa Excel")
        End If
    End Sub

    Private Sub GridClientes_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles GridClientes.RowsAdded
        Label4.Text = "Registros: " & GridClientes.Rows.Count
    End Sub

    Private Sub GridClientes_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles GridClientes.RowsRemoved
        Label4.Text = "Registros: " & GridClientes.Rows.Count
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        proveedoresmasivo.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If GridClientes.RowCount > 0 Then
        Else
            Exit Sub
        End If
        Try
            contactos.Label1.Text = "Contactos Proveedor: " & GridClientes.Item(2, GridClientes.CurrentRow.Index).Value
            contactos.consultar("select * from contactos where idproveedor='" & GridClientes.Item(4, GridClientes.CurrentRow.Index).Value & "'")
            contactos.idprovedor = GridClientes.Item(4, GridClientes.CurrentRow.Index).Value
            contactos.generaresturctura()
            contactos.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtclave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtclave.TextChanged
        Try
            consulta = "select * from proveedores where clave like '%" & txtclave.Text & "%' order by id"
            consultar(consulta)
        Catch ex As Exception
            MsgBox("Ocurrio un Error al realizar la conexión Consultar Administrador...")
            coneccion.Close()
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
       
        Try
            Cursor.Current = Cursors.WaitCursor
            provecontactos.DataSource = consultartabla("select p.clave,p.RFC,p.RAZON_SOCIAL,p.Observaciones,c.Nombre,c.Puesto,c.Telefonos,c.Contacto,c.OtrosDatos from proveedores p left join contactos c on (p.id=C.idproveedor)")
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Exit Sub
        End Try


        If provecontactos.RowCount > 0 Then
            SaveFileDialog1.FileName = ""
            SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx| Excel 2003|*.xls"
            SaveFileDialog1.Title = "Exportar A Excel"
            SaveFileDialog1.ShowDialog()

            If SaveFileDialog1.FileName.Length > 1 Then
                exportaraexcel(provecontactos, SaveFileDialog1.FileName, "ProvContactos")
            Else
                MsgBox("Elige donde Guardar...", MsgBoxStyle.Critical, "Importa Excel")
            End If
        Else
            MsgBox("La consulta no Encontro datos", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

    End Sub
End Class