Imports MySql.Data.MySqlClient


Public Class contactos

    Dim consulta As String

    Public idprovedor As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        contactosnuevoeditar.nuevo = True
        contactosnuevoeditar.Show()
        contactosnuevoeditar.Txtidprov.Text = idprovedor
        Principal.Enabled = False
    End Sub

    Private Sub clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
             Catch ex As Exception
        End Try

    End Sub

    Private Sub TxtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtnombre.TextChanged
        Try
            consulta = "select * from contactos where nombre like '%" & Txtnombre.Text & "%' and idproveedor='" & idprovedor & "' order by idcontactos"
            consultar(consulta)
        Catch ex As Exception
            MsgBox("Ocurrio un Error al realizar la conexión Consultar Administrador...")
            coneccion.Close()
        End Try
    End Sub

    Private Sub TxtDom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpuesto.TextChanged
        Try
            consulta = "select * from contactos where puesto like '%" & Txtpuesto.Text & "%' and idproveedor='" & idprovedor & "' order by idcontacto"
            consultar(consulta)

        Catch ex As Exception
            MsgBox("Ocurrio un Error al realizar la conexión Consultar Administrador...")
            coneccion.Close()
        End Try


    End Sub

    Public Sub generaresturctura()

        GridClientes.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)
        'campos a mostrar
        GridClientes.Columns("idproveedor").Visible = False
        GridClientes.Columns("nombre").Visible = True
        GridClientes.Columns("puesto").Visible = True
        GridClientes.Columns("telefonos").Visible = True
        GridClientes.Columns("contacto").Visible = True
        GridClientes.Columns("otrosdatos").Visible = True
        GridClientes.Columns("idcontacto").Visible = False

        GridClientes.Columns("idproveedor").HeaderText = "Clave Prov"
        GridClientes.Columns("nombre").HeaderText = "Nombre"
        GridClientes.Columns("puesto").HeaderText = "Puesto"
        GridClientes.Columns("telefonos").HeaderText = "Telefonos"
        GridClientes.Columns("contacto").HeaderText = "Contacto"
        GridClientes.Columns("otrosdatos").HeaderText = "otrosdatos"

        GridClientes.Columns("idproveedor").Width = 100
        GridClientes.Columns("nombre").Width = 200
        GridClientes.Columns("puesto").Width = 200
        GridClientes.Columns("telefonos").Width = 200
        GridClientes.Columns("contacto").Width = 300
        GridClientes.Columns("otrosdatos").Width = 300

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
            vec(5) = GridClientes.Item(5, GridClientes.CurrentRow.Index).Value
            vec(6) = GridClientes.Item(6, GridClientes.CurrentRow.Index).Value
            Principal.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        If GridClientes.RowCount > 0 Then
            datoscliente()
            contactosnuevoeditar.nuevo = False
            contactosnuevoeditar.Show()
         
        End If
    End Sub

    Private Sub GridClientes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridClientes.DoubleClick
        If GridClientes.RowCount > 0 Then
            datoscliente()
            contactosnuevoeditar.nuevo = False
            contactosnuevoeditar.Show()
        End If
    End Sub


    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desactivar.Click
        If GridClientes.RowCount > 0 Then
        Else
            Exit Sub
        End If

        Dim gridid As String = GridClientes.Item(6, GridClientes.CurrentRow.Index).Value
        Dim gridcliente As String = GridClientes.Item(1, GridClientes.CurrentRow.Index).Value
        If MsgBox(" Estas seguro de Elimnar este Contacto A : " + gridcliente, vbOKCancel, "Confirmación") = vbOK Then
            Try
                varconeccion()
                coneccion.Open()
                Dim eliminar As New MySqlCommand
                eliminar.Connection = coneccion
                eliminar.CommandText = "delete from contactos where idcontacto='" & gridid & "'"
                eliminar.ExecuteNonQuery()
                coneccion.Close()
                consultar("select * from contactos where idproveedor='" & idprovedor & "'  order by idcontacto desc")
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
            exportaraexcel(GridClientes, SaveFileDialog1.FileName, "Contactos", "idcontacto", "idproveedor")
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        contactosmasivo.Show()
        contactosmasivo.idproveedor = idprovedor
    End Sub

End Class