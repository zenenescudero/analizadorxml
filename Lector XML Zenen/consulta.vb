Imports MySql.Data.MySqlClient

Public Class consulta

    Private Sub gridtabla_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles gridtabla.RowsAdded
        REGISTROS.Text = "Registros: " & gridtabla.Rows.Count
    End Sub

    Private Sub gridtabla_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles gridtabla.RowsRemoved
        REGISTROS.Text = "Registros: " & gridtabla.Rows.Count
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub zmmmasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mir6 As Integer = 0
        Dim zmm As Integer = 0

        Try
            mir6 = consultaruncampo("select count(*) from mir6 where username1='" & username & "'")
        Catch ex As Exception
            mir6 = 0
        End Try
        Try
            zmm = consultaruncampo("select count(*) from zmm where username='" & username & "'")
        Catch ex As Exception
            zmm = 0
        End Try

        If mir6 > 0 Then
        Else
            MsgBox("No hay datos de la Tabla ZMIR6" & Chr(13) & "Cargalos en el Menu Operaciones" & Chr(13) & " --> Cargar Datos ZMIR6")
        End If

        If zmm > 0 Then
        Else
            MsgBox("No hay datos de la Tabla ZMM" & Chr(13) & "Cargalos en el Menu Operaciones" & Chr(13) & " --> Cargar Datos ZMM")
        End If

        Try
            Label1.Text = "Tabla ZMM Total Registros: " & zmm & "           Tabla ZMIR6 Total Registros: " & mir6 & ""
        Catch ex As Exception
            Label1.Text = ""
        End Try

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        Dim cadenasql As String = "select * from zmmvsmir6 "
        cadenasql = cadenasql & " where username='" & username & "'"

        Try

            gridtabla.Columns.Clear()
        Catch ex As Exception
        End Try

        If RadioButton3.Checked = True Then
            Try
                gridtabla.DataSource = consultartabla(cadenasql)
                Try
                    gridtabla.Columns("id").Visible = False

                    gridtabla.Columns("username").Visible = False
                    gridtabla.Columns("username1").Visible = False
                Catch ex As Exception

                End Try
                validarunion()
            Catch ex As Exception
                MsgBox("error: " & ex.Message)
                Try
                    gridtabla.Rows.Clear()
                Catch ex1 As Exception
                End Try
            End Try
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If gridtabla.RowCount < 1 Then
            Exit Sub
        End If
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx| Excel 2003|*.xls"
        SaveFileDialog1.Title = "Exportar Errores A Excel"
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.Length > 1 Then

            'zmm que no estan en mir6
            If RadioButton1.Checked Then
                exportaraexcel(gridtabla, SaveFileDialog1.FileName, RadioButton1.Text, "username", "referencia")
            End If

            'zmir6 que no estan en zmm
            If RadioButton2.Checked Then
                exportaraexcel(gridtabla, SaveFileDialog1.FileName, RadioButton2.Text, "username", "rfc_proveedor")
            End If

            'consulta de ambas tablas
            If RadioButton3.Checked Then
                exportaraexcel(gridtabla, SaveFileDialog1.FileName, RadioButton3.Text, "username", "username1")
            End If

            'consulta de zmm mir6 faltantes por oc
            If RadioFALTANTES.Checked Then
                exportaraexcel(gridtabla, SaveFileDialog1.FileName, RadioFALTANTES.Text, "username", "username1", "id", "referencia1", "rfcproveedor1")
            End If

            'consulta xml vs mir6 faltantes
            If RadioXML.Checked Then
                exportaraexcel(gridtabla, SaveFileDialog1.FileName, RadioXML.Text, "username", "username1")
            End If
        Else
            MsgBox("Elige donde Guardar...", MsgBoxStyle.Critical, "Importa Excel")
        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            gridtabla.Columns.Clear()
        Catch ex As Exception
        End Try

        If RadioButton1.Checked = True Then
            Try
                '   gridtabla.DataSource = consultartabla("select z.*,m.REFERENCIA from zmm z left join mir6 m on ((z.RFC_PROVEEDOR=m.REFERENCIA and z.UUID=m.CODIGO_FISCAL_DIGITAL_POR_INTERNET and z.username=m.username) OR (Z.SERIE_FOLIO=m.TEXTO and z.RFC_PROVEEDOR=m.REFERENCIA and z.username=m.username) or (z.UUID=m.CODIGO_FISCAL_DIGITAL_POR_INTERNET and z.username=m.username) or (Z.SERIE_FOLIO=m.TEXTO and z.ORDEN_COMPRA=m.OC and z.username=m.username)  or (z.UUID=m.CODIGO_FISCAL_DIGITAL_POR_INTERNET and z.ORDEN_COMPRA=m.OC and z.username=m.username))   where m.REFERENCIA is null and z.username='" & username & "'")
                gridtabla.DataSource = consultartabla(" select * from solozmm where username='" & username & "'")

                Try
                    gridtabla.Columns("username").Visible = False
                    gridtabla.Columns("referencia").Visible = False
                Catch ex As Exception

                End Try
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Try
                    gridtabla.Rows.Clear()
                Catch ex1 As Exception
                End Try
               
            End Try
        End If

    End Sub


    Public Sub validarunion()

        Try
            For x As Integer = 0 To gridtabla.Rows.Count - 1

                Try
                    ' validar rfc
                    If gridtabla.Item(gridtabla.Columns("ValidarRFC").Index, x).Value = "Es Correcto" Then
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarRFC").Index).Style.ForeColor = Color.Blue
                    Else
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarRFC").Index).Style.ForeColor = Color.Red
                    End If
                Catch ex As Exception
                End Try

                Try
                    'validar uuid
                    If gridtabla.Item(gridtabla.Columns("ValidarUUID").Index, x).Value = "Es Correcto" Then
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarUUID").Index).Style.ForeColor = Color.Blue
                    Else
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarUUID").Index).Style.ForeColor = Color.Red
                    End If
                Catch ex As Exception
                End Try

                Try
                    'validar texto
                    If gridtabla.Item(gridtabla.Columns("ValidarTexto").Index, x).Value = "Es Correcto" Then
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarTexto").Index).Style.ForeColor = Color.Blue
                    Else
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarTexto").Index).Style.ForeColor = Color.Red
                    End If
                Catch ex As Exception
                End Try

                Try
                    'validar importe total
                    If gridtabla.Item(gridtabla.Columns("ValidarTotal").Index, x).Value = "Es Correcto" Then
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarTotal").Index).Style.ForeColor = Color.Blue
                    Else
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarTotal").Index).Style.ForeColor = Color.Red
                    End If
                Catch ex As Exception
                End Try

                Try
                    'validar impuesto
                    If gridtabla.Item(gridtabla.Columns("ValidarImpuesto").Index, x).Value = "Es Correcto" Then
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarImpuesto").Index).Style.ForeColor = Color.Blue
                    Else
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarImpuesto").Index).Style.ForeColor = Color.Red
                    End If
                Catch ex As Exception
                End Try

                Try
                    'validar oc
                    If gridtabla.Item(gridtabla.Columns("ValidarOC").Index, x).Value = "Es Correcto" Then
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarOC").Index).Style.ForeColor = Color.Blue
                    Else
                        gridtabla.Rows(x).Cells(gridtabla.Columns("ValidarOC").Index).Style.ForeColor = Color.Red
                    End If
                Catch ex As Exception
                End Try
            Next

        Catch ex As Exception
        End Try

        
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try

            gridtabla.Columns.Clear()
        Catch ex As Exception
        End Try

        If RadioButton2.Checked = True Then
            Try
                gridtabla.DataSource = consultartabla("select * from solomir6 where username1='" & username & "'")
                gridtabla.Columns("username1").Visible = False
                gridtabla.Columns("rfc_proveedor").Visible = False

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Try
                    gridtabla.Rows.Clear()
                Catch ex1 As Exception
                End Try
            End Try
        End If
    End Sub

    Private Sub gridtabla_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridtabla.CellDoubleClick

        If RadioButton3.Checked = True Or RadioFALTANTES.Checked = True Then
        Else
            If RadioXML.Checked = True Then
                Comparacionesxml.Show()
                Try
                    'parte de xml
                    Comparacionesxml.xmluuid.Text = gridtabla.Item(gridtabla.Columns("UUID").Index, gridtabla.CurrentRow.Index).Value
                    Comparacionesxml.xmltexto.Text = gridtabla.Item(gridtabla.Columns("texto").Index, gridtabla.CurrentRow.Index).Value
                    Comparacionesxml.xmlimporte.Text = Format(Convert.ToDouble(gridtabla.Item(gridtabla.Columns("importe").Index, gridtabla.CurrentRow.Index).Value), "###,###,###.#0")
                    Comparacionesxml.xmlrfc.Text = gridtabla.Item(gridtabla.Columns("rfc").Index, gridtabla.CurrentRow.Index).Value
                    Comparacionesxml.xmloc.Text = gridtabla.Item(gridtabla.Columns("ordendecompra").Index, gridtabla.CurrentRow.Index).Value
                    Comparacionesxml.xmlrecibo.Text = gridtabla.Item(gridtabla.Columns("foliorecepcion").Index, gridtabla.CurrentRow.Index).Value
                Catch ex As Exception
                End Try
                Try
                    'parte de la zmir6
                    Comparacionesxml.mir6uuid.Text = gridtabla.Item(gridtabla.Columns("CODIGO_FISCAL_DIGITAL_POR_INTERNET").Index, gridtabla.CurrentRow.Index).Value
                    Comparacionesxml.mir6texto.Text = gridtabla.Item(gridtabla.Columns("TEXTO1").Index, gridtabla.CurrentRow.Index).Value
                    Comparacionesxml.mir6importe.Text = Format(Convert.ToDouble(gridtabla.Item(gridtabla.Columns("IMPORTE_BRUTO").Index, gridtabla.CurrentRow.Index).Value), "###,###,###.#0")
                    Comparacionesxml.mir6rfc.Text = gridtabla.Item(gridtabla.Columns("REFERENCIA").Index, gridtabla.CurrentRow.Index).Value
                    Comparacionesxml.mir6pedido.Text = gridtabla.Item(gridtabla.Columns("OC").Index, gridtabla.CurrentRow.Index).Value
                    Comparacionesxml.mir6nodoc.Text = gridtabla.Item(gridtabla.Columns("NO_DOCUMENTO").Index, gridtabla.CurrentRow.Index).Value
                Catch ex As Exception
                End Try

                If gridtabla.Item(gridtabla.Columns("ValidarUUID").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
                Else
                    Comparacionesxml.xmluuid.ForeColor = Color.Red
                    Comparacionesxml.mir6uuid.ForeColor = Color.Red
                End If

                If gridtabla.Item(gridtabla.Columns("ValidarTexto").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
                Else
                    Comparacionesxml.xmltexto.ForeColor = Color.Red
                    Comparacionesxml.mir6texto.ForeColor = Color.Red
                End If

                If gridtabla.Item(gridtabla.Columns("ValidarTotal").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
                Else
                    Comparacionesxml.mir6importe.ForeColor = Color.Red
                    Comparacionesxml.xmlimporte.ForeColor = Color.Red
                End If

            End If
            Exit Sub
        End If

        Comparaciones.Show()

        Try
            'parte de zmmm
            Comparaciones.TextBox1.Text = gridtabla.Item(gridtabla.Columns("UUID").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox2.Text = gridtabla.Item(gridtabla.Columns("SERIE_FOLIO").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox3.Text = Format(Convert.ToDouble(gridtabla.Item(gridtabla.Columns("TOTAL").Index, gridtabla.CurrentRow.Index).Value), "###,###,###.#0")
            Comparaciones.TextBox4.Text = Format(Convert.ToDouble(gridtabla.Item(gridtabla.Columns("IMPUESTO").Index, gridtabla.CurrentRow.Index).Value), "###,###,###.#0")
            Comparaciones.TextBox9.Text = gridtabla.Item(gridtabla.Columns("RFC_PROVEEDOR").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox10.Text = gridtabla.Item(gridtabla.Columns("ORDEN_COMPRA").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox13.Text = gridtabla.Item(gridtabla.Columns("SUCURSAL").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox15.Text = gridtabla.Item(gridtabla.Columns("ORDEN_RECIBO").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox16.Text = gridtabla.Item(gridtabla.Columns("DESCRIPCION_ERROR").Index, gridtabla.CurrentRow.Index).Value
            Try
                Comparaciones.TextBox18.Text = gridtabla.Item(gridtabla.Columns("FECHA_FACTURA").Index, gridtabla.CurrentRow.Index).Value
                Comparaciones.TextBox19.Text = gridtabla.Item(gridtabla.Columns("FECHA_TIMBRADO").Index, gridtabla.CurrentRow.Index).Value
                Comparaciones.TextBox20.Text = gridtabla.Item(gridtabla.Columns("FECHA_RECEPCION").Index, gridtabla.CurrentRow.Index).Value

            Catch ex As Exception

            End Try
            
        Catch ex As Exception
        End Try
        Try
            'parte de la zmir6
            Comparaciones.TextBox8.Text = gridtabla.Item(gridtabla.Columns("CODIGO_FISCAL_DIGITAL_POR_INTERNET").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox7.Text = gridtabla.Item(gridtabla.Columns("TEXTO").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox6.Text = Format(Convert.ToDouble(gridtabla.Item(gridtabla.Columns("IMPORTE_BRUTO").Index, gridtabla.CurrentRow.Index).Value), "###,###,###.#0")
            Comparaciones.TextBox5.Text = Format(Convert.ToDouble(gridtabla.Item(gridtabla.Columns("IMPORTE_IMPUESTO").Index, gridtabla.CurrentRow.Index).Value), "###,###,###.#0")
            Comparaciones.TextBox12.Text = gridtabla.Item(gridtabla.Columns("REFERENCIA").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox11.Text = gridtabla.Item(gridtabla.Columns("OC").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox14.Text = gridtabla.Item(gridtabla.Columns("SUC").Index, gridtabla.CurrentRow.Index).Value
            Comparaciones.TextBox17.Text = gridtabla.Item(gridtabla.Columns("NO_DOCUMENTO").Index, gridtabla.CurrentRow.Index).Value
            Try
                Comparaciones.TextBox21.Text = gridtabla.Item(gridtabla.Columns("FECHA_ENTREGA").Index, gridtabla.CurrentRow.Index).Value
                Comparaciones.TextBox22.Text = gridtabla.Item(gridtabla.Columns("Fecha_Timbrado1").Index, gridtabla.CurrentRow.Index).Value
                Comparaciones.TextBox23.Text = gridtabla.Item(gridtabla.Columns("FECHA_CONTABLE").Index, gridtabla.CurrentRow.Index).Value

            Catch ex As Exception

            End Try
            
        Catch ex As Exception
        End Try

        If gridtabla.Item(gridtabla.Columns("ValidarUUID").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
        Else
            Comparaciones.TextBox1.ForeColor = Color.Red
            Comparaciones.TextBox8.ForeColor = Color.Red
        End If

        If gridtabla.Item(gridtabla.Columns("ValidarTexto").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
        Else
            Comparaciones.TextBox2.ForeColor = Color.Red
            Comparaciones.TextBox7.ForeColor = Color.Red
        End If

        If gridtabla.Item(gridtabla.Columns("ValidarTotal").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
        Else
            Comparaciones.TextBox3.ForeColor = Color.Red
            Comparaciones.TextBox6.ForeColor = Color.Red
        End If

        If gridtabla.Item(gridtabla.Columns("ValidarImpuesto").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
        Else
            Comparaciones.TextBox4.ForeColor = Color.Red
            Comparaciones.TextBox5.ForeColor = Color.Red
        End If

        If gridtabla.Item(gridtabla.Columns("ValidarRFC").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
        Else
            Comparaciones.TextBox9.ForeColor = Color.Red
            Comparaciones.TextBox12.ForeColor = Color.Red
        End If

        If gridtabla.Item(gridtabla.Columns("ValidarOC").Index, gridtabla.CurrentRow.Index).Value = "Es Correcto" Then
        Else
            Comparaciones.TextBox10.ForeColor = Color.Red
            Comparaciones.TextBox11.ForeColor = Color.Red
        End If

        Principal.Enabled = False

    End Sub

    Private Sub gridtabla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridtabla.CellContentClick
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If Convert.ToUInt32(consultaruncampo("select count(*) from zmmvsmir6 where username='" & username & "'")) > 0 Then
                If (MsgBox("Estas Seguro de Generar Las Consultas de NUevo ---> Si ya habias marcado algunos como revisados se Perderia este dato", MsgBoxStyle.YesNo, "Generar Consultas") = vbYes) Then
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
        End Try

        Try
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioFALTANTES.Checked = False
            RadioXML.Checked = False
            gridtabla.Columns.Clear()
        Catch ex As Exception
        End Try

        Try
            Try
                Cursor.Current = Cursors.WaitCursor
                coneccion.Open()
                Dim comando As New MySqlCommand("call generarunion(@usuario)", coneccion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@usuario", username)
                comando.CommandTimeout = 0
                comando.ExecuteNonQuery()
                coneccion.Close()
                Cursor.Current = Cursors.Default
               Catch ex As Exception
                coneccion.Close()
                Cursor.Current = Cursors.Default
                MsgBox("Error" & ex.Message)
            End Try
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("Error" & ex.Message)
        End Try

        Try
            Try
                Cursor.Current = Cursors.WaitCursor
                coneccion.Open()
                Dim comando As New MySqlCommand("call unionesadicionales(@usuario)", coneccion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@usuario", username)
                comando.CommandTimeout = 0
                comando.ExecuteNonQuery()
                coneccion.Close()
                Cursor.Current = Cursors.Default
            Catch ex As Exception
                coneccion.Close()
                Cursor.Current = Cursors.Default
                MsgBox("Error" & ex.Message)
            End Try
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("Error" & ex.Message)
        End Try

        MsgBox("Generacion De Consultas Terminada")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If gridtabla.RowCount > 0 Then
            Try
                validarunion()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub RadioFALTANTES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioFALTANTES.CheckedChanged

        Dim cadenasql As String = "select * from zmmvsmir6oc "
        cadenasql = cadenasql & " where username='" & username & "'"

        Try
            gridtabla.Columns.Clear()
        Catch ex As Exception
        End Try

        If RadioFALTANTES.Checked = True Then
            Try
                gridtabla.DataSource = consultartabla(cadenasql)

                Try

                    gridtabla.Columns("id").Visible = False
                    gridtabla.Columns("username").Visible = False
                    gridtabla.Columns("username1").Visible = False
                    gridtabla.Columns("referencia1").Visible = False
                    gridtabla.Columns("rfcproveedor1").Visible = False

                Catch ex As Exception

                End Try
                validarunion()
            Catch ex As Exception
                MsgBox("error: " & ex.Message)
                Try
                    gridtabla.Rows.Clear()
                Catch ex1 As Exception
                End Try
            End Try
        End If

    End Sub

    Private Sub RadioXML_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioXML.CheckedChanged

        Dim cadenasql As String = "select * from xmlvsmir6 "
        cadenasql = cadenasql & " where username='" & username & "'"

        Try
            gridtabla.Columns.Clear()
        Catch ex As Exception
        End Try

        If RadioXML.Checked = True Then
            Try
                gridtabla.DataSource = consultartabla(cadenasql)
                Try
                    gridtabla.Columns("username").Visible = False
                    gridtabla.Columns("username1").Visible = False
                Catch ex As Exception
                End Try
            Catch ex As Exception
                MsgBox("error: " & ex.Message)
                Try
                    gridtabla.Rows.Clear()
                Catch ex1 As Exception
                End Try
            End Try
        End If

    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If MsgBox("Esta Accion elimnara los datos de todas las consultas y tablas ¿Deseas Continuar?", MsgBoxStyle.OkCancel, "Eliminar Datos") = vbOK Then
            Try
                Cursor.Current = Cursors.WaitCursor
                coneccion.Open()
                Dim comando As New MySqlCommand("call Eliminardatos(@usuario)", coneccion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@usuario", username)
                comando.CommandTimeout = 0
                comando.ExecuteNonQuery()
                coneccion.Close()
                Cursor.Current = Cursors.Default
            Catch ex As Exception
                coneccion.Close()
                Cursor.Current = Cursors.Default
                MsgBox("Error" & ex.Message)
            End Try
        Else
            Exit Sub
        End If

    End Sub
End Class
