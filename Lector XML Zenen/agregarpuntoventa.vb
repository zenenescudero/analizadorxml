Imports MySql.Data.MySqlClient

Public Class agregarpuntoventa
    Dim consulta As String
    Dim dset As DataSet
    Dim referencia As String = ""
    Dim iva, ieps, punitario, subtotal, pventa, retisr, retiva, cantidad As Double
    Dim valiva, valieps, valretiva, valretisr, descuento As Double
    Dim desvalor As Double = 0
    Dim excento As String = ""

    Public Sub calcularprecios()

        Try
            pventa = Convert.ToDouble(txtpventa.Text)
            pventa = Math.Round(pventa, 2)
        Catch ex As Exception
            pventa = 0
        End Try

        Try
            punitario = Convert.ToDouble(txtpunitario.Text)
            punitario = Math.Round(punitario, 2)
        Catch ex As Exception
            punitario = 0
        End Try

        Try
            cantidad = Convert.ToDouble(txtcantidad.Text)
            cantidad = Math.Round(cantidad, 3)
        Catch ex As Exception
            cantidad = 0
        End Try

        Try
            subtotal = pventa * cantidad
            subtotal = Math.Round(subtotal, 2)
        Catch ex As Exception
            subtotal = 0
        End Try
        totalventa.Text = Format(subtotal, "###,###,###.#0")
        Try
            subtotal = punitario * cantidad
            subtotal = Math.Round(subtotal, 2)
        Catch ex As Exception
            subtotal = 0
        End Try

        txtsubtotal.Text = Format(subtotal, "###,###,###.#0")


    End Sub

    Private Sub compraagregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opcionescombo(articulobox, "select id,descripcion from conceptos order by descripcion")
    End Sub

    Public Sub limpiar()
        Label11.Visible = False
        referencia = ""
        txtrefe.Text = ""
        txtcodigobarras.Text = ""
        txtunidad.Text = ""
        txtsubtotal.Text = 0
        txtunidad.Text = ""
        txtpventa.Text = 0
        txtsubtotal.Text = 0
        txtpunitario.Text = 0
        txtieps.Text = 0
        txtiva.Text = 0
        txtretiva.Text = 0
        txtretisr.Text = 0
        excento = ""
        iva = 0
        ieps = 0
        valiva = 0
        valieps = 0
        retiva = 0
        retisr = 0
        valretiva = 0
        valretisr = 0
        punitario = 0
        pventa = 0
        subtotal = 0
        cantidad = 0
        calcularprecios()
    End Sub

    Public Sub rellenarcampos()
        Label11.Visible = False
        txtcantidad.Text = ""
        excento = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("excento"))

        If excento = "SI" Then
            Label11.Visible = True
        End If
        txtrefe.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("id"))
        articulobox.SelectedValue = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("id"))
        referencia = txtrefe.Text
        txtcodigobarras.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("codigobarras"))
        txtunidad.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("unidad"))
        txtsubtotal.Text = subtotal
        txtieps.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("ieps"))
        txtiva.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("iva"))
        txtretiva.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("retiva"))
        txtretisr.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("retisr"))
        txtpunitario.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("punitario"))
        txtpunitario.Text = Format(Math.Round(Convert.ToDouble(txtpunitario.Text), 2), "###,###,###.#0")
        txtpventa.Text = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("pventa"))
        txtpventa.Text = Format(Math.Round(Convert.ToDouble(txtpventa.Text), 2), "###,###,###.#0")
        ieps = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("ieps"))
        ieps = Math.Round(ieps, 4)
        valieps = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("valieps"))
        valieps = Math.Round(valieps, 2)
        iva = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("iva"))
        iva = Math.Round(iva, 4)
        valiva = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("valiva"))
        valiva = Math.Round(valiva, 2)
        retiva = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("retiva"))
        retiva = Math.Round(retiva, 4)
        valretiva = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("valretiva"))
        valretiva = Math.Round(valretiva, 2)
        retisr = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("retisr"))
        retisr = Math.Round(retisr, 4)
        valretisr = dset.Tables(0).Rows(0)(dset.Tables(0).Columns("valretisr"))
        valretisr = Math.Round(valretisr, 2)

        calcularprecios()

    End Sub

    Private Sub articulobox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles articulobox.SelectedIndexChanged
        consulta = "select id,codigobarras,unidad,ieps,valieps,iva,valiva,retiva,valretiva,retisr,valretisr,punitario,pventa,excento from conceptos where id='" & articulobox.SelectedValue.ToString & "'"
        Try
            consultar(consulta)
            If dset.Tables(0).Rows.Count < 1 Then
                limpiar()
                Exit Sub
            End If
            rellenarcampos()
        Catch ex As Exception
            coneccion.Close()
            limpiar()
        End Try

    End Sub

    Public Sub consultar(ByVal consulta As String)
        Try
            varconeccion()
            coneccion.Open()
            dset = New DataSet
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand(consulta, coneccion)
            dadaptador.Fill(dset)
            coneccion.Close()

        Catch ex As Exception
            coneccion.Close()
        End Try

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsubtotal.KeyPress, txtiva.KeyPress, txtcantidad.KeyPress, txtdescuento.KeyPress
        If InStr(1, "0123456789.," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub compraagregar_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnentrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnentrar.Click
        If dset.Tables(0).Rows.Count < 1 Then
            MsgBox("Selecciona algun concepto", MsgBoxStyle.Exclamation, "Conceptos")
            Exit Sub
        End If

        If cantidad <= 0 Then
            MsgBox("No has asignado cantidad", MsgBoxStyle.Exclamation, "Cantidad cero")
            Exit Sub
        End If

        Try
            descuento = Convert.ToDouble(txtdescuento.Text)
            descuento = Math.Round(descuento, 2)
        Catch ex As Exception
            descuento = 0
        End Try

        If descuento > 0 Then
            calculardescuento()
        End If

        puntodeventa.gridconceptos.Rows.Add(cantidad, txtunidad.Text, txtcodigobarras.Text, articulobox.Text, iva, Math.Round(valiva * cantidad, 2), ieps, Math.Round(valieps * cantidad, 2), retiva, Math.Round(valretiva * cantidad, 2), retisr, Math.Round(valretisr * cantidad, 2), Math.Round(Convert.ToDouble(txtpunitario.Text), 2), txtsubtotal.Text, descuento, desvalor, excento, consultaruncampo("select predial from conceptos where id='" & txtrefe.Text & "'"))
        Me.Close()
    End Sub
    Public Sub calculardescuento()
        Dim punitariomasieps As Double = 0

        Try
            desvalor = (descuento / 100) * punitario
            desvalor = Math.Round(desvalor, 2)
            punitario = punitario - desvalor
            punitario = Math.Round(punitario, 2)
        Catch ex As Exception
            punitario = 0
        End Try
        Try
            ieps = Convert.ToDouble(txtieps.Text)
            ieps = Math.Round(ieps, 4)
            valieps = (ieps / 100) * punitario
            valieps = Math.Round(valieps, 2)
        Catch ex As Exception
            ieps = 0
            valieps = 0
        End Try

        Try
            punitariomasieps = punitario + valieps
            punitariomasieps = Math.Round(punitariomasieps, 2)
        Catch ex As Exception
            punitariomasieps = 0
        End Try
        Try
            iva = Convert.ToDouble(txtiva.Text)
            iva = Math.Round(iva, 4)
            valiva = (iva / 100) * (punitariomasieps)
            valiva = Math.Round(valiva, 2)

        Catch ex As Exception
            iva = 0
            valiva = 0
        End Try

        'retenciones
        Try
            retiva = Convert.ToDouble(txtretiva.Text)
            retiva = Math.Round(retiva, 4)
            valretiva = (retiva / 100) * (valiva)
            valretiva = Math.Round(valretiva, 2)

        Catch ex As Exception
            retiva = 0
            valretiva = 0
        End Try
        Try
            retisr = Convert.ToDouble(txtretisr.Text)
            retisr = Math.Round(retisr, 4)
            valretisr = (retisr / 100) * (punitario)
            valretisr = Math.Round(valretisr, 2)

        Catch ex As Exception
            retisr = 0
            valretisr = 0
        End Try

        desvalor = desvalor * cantidad
        desvalor = Math.Round(desvalor, 2)

    End Sub
    Private Sub txtrefe_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrefe.KeyDown

        consulta = "select id,codigobarras,unidad,ieps,valieps,iva,valiva,retiva,valretiva,retisr,valretisr,punitario,pventa,excento from conceptos where id='" & Trim(txtrefe.Text) & "'"

        If e.KeyValue = Keys.Enter Then
            Try
                consultar(consulta)
                If dset.Tables(0).Rows.Count > 0 Then
                    rellenarcampos()
                Else
                    MsgBox("No se encontro el Concepto", MsgBoxStyle.Information, "Consulta vacia")
                    limpiar()
                    Exit Sub
                End If
            Catch ex As Exception
                coneccion.Close()
                limpiar()
                MsgBox("No se encontro el Concepto", MsgBoxStyle.Information, "Consulta vacia")
            End Try
        End If

    End Sub

    Private Sub txtbarras_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodigobarras.KeyDown

        consulta = "select id,codigobarras,unidad,ieps,valieps,iva,valiva,retiva,valretiva,retisr,valretisr,punitario,pventa,excento from conceptos where codigobarras='" & Trim(txtcodigobarras.Text) & "'"
        If e.KeyValue = Keys.Enter Then
            Try
                consultar(consulta)
                If dset.Tables(0).Rows.Count > 0 Then
                    rellenarcampos()
                Else
                    MsgBox("No se encontro el Concepto", MsgBoxStyle.Information, "Consulta vacia")
                    limpiar()
                    Exit Sub
                End If
            Catch ex As Exception
                coneccion.Close()
                limpiar()
                MsgBox("No se encontro el Concepto", MsgBoxStyle.Information, "Consulta vacia")
            End Try
        End If

    End Sub

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged
        calcularprecios()
    End Sub


    Private Sub txtcantidad_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.LostFocus
        calcularprecios()
        txtcantidad.Text = Format(cantidad, "###,###,###.##0")
    End Sub


    Private Sub txtdescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescuento.TextChanged

    End Sub
End Class