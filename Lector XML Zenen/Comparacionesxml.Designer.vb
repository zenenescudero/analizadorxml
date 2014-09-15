<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comparacionesxml
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xmluuid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.xmltexto = New System.Windows.Forms.TextBox()
        Me.xmlimporte = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.xmlrecibo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.xmloc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.xmlrfc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mir6nodoc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.mir6pedido = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mir6rfc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mir6importe = New System.Windows.Forms.TextBox()
        Me.mir6texto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mir6uuid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datos XML"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(420, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tabla ZMIR6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Texto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "UUID"
        '
        'xmluuid
        '
        Me.xmluuid.Location = New System.Drawing.Point(45, 15)
        Me.xmluuid.Multiline = True
        Me.xmluuid.Name = "xmluuid"
        Me.xmluuid.Size = New System.Drawing.Size(316, 53)
        Me.xmluuid.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Importe"
        '
        'xmltexto
        '
        Me.xmltexto.Location = New System.Drawing.Point(45, 74)
        Me.xmltexto.Name = "xmltexto"
        Me.xmltexto.Size = New System.Drawing.Size(316, 20)
        Me.xmltexto.TabIndex = 7
        '
        'xmlimporte
        '
        Me.xmlimporte.Location = New System.Drawing.Point(63, 101)
        Me.xmlimporte.Name = "xmlimporte"
        Me.xmlimporte.Size = New System.Drawing.Size(298, 20)
        Me.xmlimporte.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.Controls.Add(Me.xmlrecibo)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.xmloc)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.xmlrfc)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.xmlimporte)
        Me.Panel1.Controls.Add(Me.xmltexto)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.xmluuid)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 243)
        Me.Panel1.TabIndex = 3
        '
        'xmlrecibo
        '
        Me.xmlrecibo.Location = New System.Drawing.Point(63, 204)
        Me.xmlrecibo.Name = "xmlrecibo"
        Me.xmlrecibo.Size = New System.Drawing.Size(298, 20)
        Me.xmlrecibo.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Recibo"
        '
        'xmloc
        '
        Me.xmloc.Location = New System.Drawing.Point(63, 166)
        Me.xmloc.Name = "xmloc"
        Me.xmloc.Size = New System.Drawing.Size(298, 20)
        Me.xmloc.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "OC"
        '
        'xmlrfc
        '
        Me.xmlrfc.Location = New System.Drawing.Point(63, 129)
        Me.xmlrfc.Name = "xmlrfc"
        Me.xmlrfc.Size = New System.Drawing.Size(298, 20)
        Me.xmlrfc.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "RFC"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OldLace
        Me.Panel2.Controls.Add(Me.mir6nodoc)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.mir6pedido)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.mir6rfc)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.mir6importe)
        Me.Panel2.Controls.Add(Me.mir6texto)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.mir6uuid)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(423, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 246)
        Me.Panel2.TabIndex = 4
        '
        'mir6nodoc
        '
        Me.mir6nodoc.Location = New System.Drawing.Point(63, 200)
        Me.mir6nodoc.Name = "mir6nodoc"
        Me.mir6nodoc.Size = New System.Drawing.Size(297, 20)
        Me.mir6nodoc.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 204)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "No. Doc"
        '
        'mir6pedido
        '
        Me.mir6pedido.Location = New System.Drawing.Point(63, 169)
        Me.mir6pedido.Name = "mir6pedido"
        Me.mir6pedido.Size = New System.Drawing.Size(297, 20)
        Me.mir6pedido.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Pedido"
        '
        'mir6rfc
        '
        Me.mir6rfc.Location = New System.Drawing.Point(63, 136)
        Me.mir6rfc.Name = "mir6rfc"
        Me.mir6rfc.Size = New System.Drawing.Size(297, 20)
        Me.mir6rfc.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "RFC"
        '
        'mir6importe
        '
        Me.mir6importe.Location = New System.Drawing.Point(63, 108)
        Me.mir6importe.Name = "mir6importe"
        Me.mir6importe.Size = New System.Drawing.Size(297, 20)
        Me.mir6importe.TabIndex = 9
        '
        'mir6texto
        '
        Me.mir6texto.Location = New System.Drawing.Point(45, 79)
        Me.mir6texto.Name = "mir6texto"
        Me.mir6texto.Size = New System.Drawing.Size(315, 20)
        Me.mir6texto.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Importe"
        '
        'mir6uuid
        '
        Me.mir6uuid.Location = New System.Drawing.Point(45, 20)
        Me.mir6uuid.Multiline = True
        Me.mir6uuid.Name = "mir6uuid"
        Me.mir6uuid.Size = New System.Drawing.Size(315, 53)
        Me.mir6uuid.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "UUID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Texto"
        '
        'Comparacionesxml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(834, 297)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Comparacionesxml"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparaciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xmluuid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents xmltexto As System.Windows.Forms.TextBox
    Friend WithEvents xmlimporte As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents mir6importe As System.Windows.Forms.TextBox
    Friend WithEvents mir6texto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mir6uuid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents xmloc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents xmlrfc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mir6pedido As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mir6rfc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents xmlrecibo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mir6nodoc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
