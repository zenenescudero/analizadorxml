<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(proveedores))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridClientes = New System.Windows.Forms.DataGridView()
        Me.Txtrfc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtrazonsocial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.editar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.desactivar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.provecontactos = New System.Windows.Forms.DataGridView()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.provecontactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedores"
        '
        'GridClientes
        '
        Me.GridClientes.AllowUserToAddRows = False
        Me.GridClientes.AllowUserToResizeRows = False
        Me.GridClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridClientes.BackgroundColor = System.Drawing.Color.Linen
        Me.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientes.GridColor = System.Drawing.SystemColors.Control
        Me.GridClientes.Location = New System.Drawing.Point(5, 141)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.ReadOnly = True
        Me.GridClientes.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.GridClientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridClientes.Size = New System.Drawing.Size(882, 360)
        Me.GridClientes.TabIndex = 2
        Me.GridClientes.TabStop = False
        '
        'Txtrfc
        '
        Me.Txtrfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtrfc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrfc.Location = New System.Drawing.Point(366, 77)
        Me.Txtrfc.Name = "Txtrfc"
        Me.Txtrfc.Size = New System.Drawing.Size(331, 22)
        Me.Txtrfc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RFC"
        '
        'Txtrazonsocial
        '
        Me.Txtrazonsocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtrazonsocial.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrazonsocial.Location = New System.Drawing.Point(366, 105)
        Me.Txtrazonsocial.Name = "Txtrazonsocial"
        Me.Txtrazonsocial.Size = New System.Drawing.Size(331, 22)
        Me.Txtrazonsocial.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Razon Social"
        '
        'editar
        '
        Me.editar.BackgroundImage = CType(resources.GetObject("editar.BackgroundImage"), System.Drawing.Image)
        Me.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.editar.Location = New System.Drawing.Point(116, 53)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(49, 51)
        Me.editar.TabIndex = 8
        Me.editar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.editar, "Editar Registro Seleccionado")
        Me.editar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.BackgroundImage = CType(resources.GetObject("nuevo.BackgroundImage"), System.Drawing.Image)
        Me.nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.Location = New System.Drawing.Point(5, 53)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(49, 51)
        Me.nuevo.TabIndex = 1
        Me.nuevo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.nuevo, "Nuevo Registro")
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'desactivar
        '
        Me.desactivar.AccessibleDescription = ""
        Me.desactivar.BackgroundImage = CType(resources.GetObject("desactivar.BackgroundImage"), System.Drawing.Image)
        Me.desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.desactivar.Location = New System.Drawing.Point(61, 53)
        Me.desactivar.Name = "desactivar"
        Me.desactivar.Size = New System.Drawing.Size(49, 51)
        Me.desactivar.TabIndex = 35
        Me.desactivar.TabStop = False
        Me.desactivar.Tag = ""
        Me.ToolTip1.SetToolTip(Me.desactivar, "Eliminar Registro")
        Me.desactivar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = ""
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(228, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 51)
        Me.Button1.TabIndex = 38
        Me.Button1.TabStop = False
        Me.Button1.Tag = ""
        Me.ToolTip1.SetToolTip(Me.Button1, "Exportar Registros a Excel")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Button2
        '
        Me.Button2.AccessibleDescription = ""
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(739, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 40
        Me.Button2.TabStop = False
        Me.Button2.Tag = ""
        Me.ToolTip1.SetToolTip(Me.Button2, "Cerrar")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AccessibleDescription = ""
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(173, 53)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 51)
        Me.Button3.TabIndex = 43
        Me.Button3.TabStop = False
        Me.Button3.Tag = ""
        Me.ToolTip1.SetToolTip(Me.Button3, "Ver Contactos")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AccessibleDescription = ""
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(703, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 51)
        Me.Button4.TabIndex = 44
        Me.Button4.TabStop = False
        Me.Button4.Tag = ""
        Me.ToolTip1.SetToolTip(Me.Button4, "Todos Prov-Contactos")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.AccessibleDescription = ""
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(758, 73)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 51)
        Me.Button5.TabIndex = 45
        Me.Button5.TabStop = False
        Me.Button5.Tag = ""
        Me.ToolTip1.SetToolTip(Me.Button5, "Cargar Proveedores")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Registros"
        '
        'txtclave
        '
        Me.txtclave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtclave.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(366, 46)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(331, 22)
        Me.txtclave.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(309, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Clave"
        '
        'provecontactos
        '
        Me.provecontactos.AllowUserToAddRows = False
        Me.provecontactos.AllowUserToResizeRows = False
        Me.provecontactos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.provecontactos.BackgroundColor = System.Drawing.Color.Linen
        Me.provecontactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.provecontactos.GridColor = System.Drawing.SystemColors.Control
        Me.provecontactos.Location = New System.Drawing.Point(792, 12)
        Me.provecontactos.Name = "provecontactos"
        Me.provecontactos.ReadOnly = True
        Me.provecontactos.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.provecontactos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.provecontactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.provecontactos.Size = New System.Drawing.Size(95, 53)
        Me.provecontactos.TabIndex = 46
        Me.provecontactos.TabStop = False
        Me.provecontactos.Visible = False
        '
        'proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(899, 538)
        Me.Controls.Add(Me.provecontactos)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.desactivar)
        Me.Controls.Add(Me.editar)
        Me.Controls.Add(Me.Txtrazonsocial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtrfc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridClientes)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.provecontactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents GridClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Txtrfc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtrazonsocial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents editar As System.Windows.Forms.Button
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RfcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MunicipioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CallenumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentariosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViclientesBindingSource As System.Windows.Forms.BindingSource


    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desactivar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents provecontactos As System.Windows.Forms.DataGridView

End Class
