<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class extraedatosxml
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(extraedatosxml))
        Me.directorio = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cadenaleer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.guardarerrores = New System.Windows.Forms.SaveFileDialog()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrfc = New System.Windows.Forms.TextBox()
        Me.SubCarpeta = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.griddatosxml = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.foliog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serieg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cadenaarchivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noAprovacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.filtrofecha = New System.Windows.Forms.CheckBox()
        Me.TabPage3.SuspendLayout()
        CType(Me.griddatosxml, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(712, 167)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Examinar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Coloca el RFC a Buscar"
        '
        'cadenaleer
        '
        Me.cadenaleer.BackColor = System.Drawing.Color.White
        Me.cadenaleer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadenaleer.Location = New System.Drawing.Point(178, 172)
        Me.cadenaleer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cadenaleer.Name = "cadenaleer"
        Me.cadenaleer.ReadOnly = True
        Me.cadenaleer.Size = New System.Drawing.Size(528, 22)
        Me.cadenaleer.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Carpeta de XML"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 267)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Archivos a Consultar:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(178, 213)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 35)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Iniciar Proceso"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(218, 78)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(168, 35)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Proceso Nuevo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 139)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "RFC"
        '
        'txtrfc
        '
        Me.txtrfc.BackColor = System.Drawing.Color.White
        Me.txtrfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrfc.Location = New System.Drawing.Point(178, 133)
        Me.txtrfc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(228, 26)
        Me.txtrfc.TabIndex = 14
        '
        'SubCarpeta
        '
        Me.SubCarpeta.AutoSize = True
        Me.SubCarpeta.Location = New System.Drawing.Point(821, 170)
        Me.SubCarpeta.Name = "SubCarpeta"
        Me.SubCarpeta.Size = New System.Drawing.Size(77, 24)
        Me.SubCarpeta.TabIndex = 16
        Me.SubCarpeta.Text = "SubDir"
        Me.SubCarpeta.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 29)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Extraer Datos XML"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(369, 213)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(145, 35)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "exportar a Excel"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.griddatosxml)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(811, 219)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Resultados"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'griddatosxml
        '
        Me.griddatosxml.AllowUserToAddRows = False
        Me.griddatosxml.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griddatosxml.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.griddatosxml.BackgroundColor = System.Drawing.Color.Linen
        Me.griddatosxml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.griddatosxml.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.foliog, Me.serieg, Me.fechag, Me.cadenaarchivo, Me.version, Me.UUID, Me.noAprovacion, Me.Importe1, Me.FolioRecepcion, Me.OrdenCompra})
        Me.griddatosxml.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griddatosxml.GridColor = System.Drawing.SystemColors.Control
        Me.griddatosxml.Location = New System.Drawing.Point(3, 3)
        Me.griddatosxml.MultiSelect = False
        Me.griddatosxml.Name = "griddatosxml"
        Me.griddatosxml.ReadOnly = True
        Me.griddatosxml.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.griddatosxml.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.griddatosxml.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.griddatosxml.Size = New System.Drawing.Size(805, 213)
        Me.griddatosxml.TabIndex = 9
        Me.griddatosxml.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "rfc"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "razon"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'foliog
        '
        Me.foliog.HeaderText = "folio"
        Me.foliog.Name = "foliog"
        Me.foliog.ReadOnly = True
        Me.foliog.Width = 60
        '
        'serieg
        '
        Me.serieg.HeaderText = "serie"
        Me.serieg.Name = "serieg"
        Me.serieg.ReadOnly = True
        Me.serieg.Width = 50
        '
        'fechag
        '
        Me.fechag.HeaderText = "Fecha"
        Me.fechag.Name = "fechag"
        Me.fechag.ReadOnly = True
        '
        'cadenaarchivo
        '
        Me.cadenaarchivo.HeaderText = "Archivo Original"
        Me.cadenaarchivo.Name = "cadenaarchivo"
        Me.cadenaarchivo.ReadOnly = True
        Me.cadenaarchivo.Width = 200
        '
        'version
        '
        Me.version.HeaderText = "version"
        Me.version.Name = "version"
        Me.version.ReadOnly = True
        '
        'UUID
        '
        Me.UUID.HeaderText = "UUID"
        Me.UUID.Name = "UUID"
        Me.UUID.ReadOnly = True
        '
        'noAprovacion
        '
        Me.noAprovacion.HeaderText = "noAprovacion"
        Me.noAprovacion.Name = "noAprovacion"
        Me.noAprovacion.ReadOnly = True
        '
        'Importe1
        '
        Me.Importe1.HeaderText = "Importe"
        Me.Importe1.Name = "Importe1"
        Me.Importe1.ReadOnly = True
        '
        'FolioRecepcion
        '
        Me.FolioRecepcion.HeaderText = "Folio Recepcion"
        Me.FolioRecepcion.Name = "FolioRecepcion"
        Me.FolioRecepcion.ReadOnly = True
        Me.FolioRecepcion.Width = 150
        '
        'OrdenCompra
        '
        Me.OrdenCompra.HeaderText = "Orden de Compra"
        Me.OrdenCompra.Name = "OrdenCompra"
        Me.OrdenCompra.ReadOnly = True
        Me.OrdenCompra.Width = 180
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(15, 305)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 252)
        Me.TabControl1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(528, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Encontrados: "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(547, 213)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 35)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Guardar Datos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fecha1
        '
        Me.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha1.Location = New System.Drawing.Point(571, 77)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(105, 26)
        Me.fecha1.TabIndex = 22
        Me.fecha1.Visible = False
        '
        'fecha2
        '
        Me.fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha2.Location = New System.Drawing.Point(571, 118)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(105, 26)
        Me.fecha2.TabIndex = 23
        Me.fecha2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Fecha 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(489, 121)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Fecha 2"
        '
        'filtrofecha
        '
        Me.filtrofecha.AutoSize = True
        Me.filtrofecha.Location = New System.Drawing.Point(493, 47)
        Me.filtrofecha.Name = "filtrofecha"
        Me.filtrofecha.Size = New System.Drawing.Size(81, 24)
        Me.filtrofecha.TabIndex = 26
        Me.filtrofecha.Text = "Fechas"
        Me.filtrofecha.UseVisualStyleBackColor = True
        '
        'extraedatosxml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(912, 594)
        Me.Controls.Add(Me.filtrofecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fecha2)
        Me.Controls.Add(Me.fecha1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SubCarpeta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtrfc)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cadenaleer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "extraedatosxml"
        Me.Text = "Lector Xml"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage3.ResumeLayout(False)
        CType(Me.griddatosxml, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents directorio As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cadenaleer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents guardarerrores As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtrfc As System.Windows.Forms.TextBox
    Friend WithEvents SubCarpeta As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents griddatosxml As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents foliog As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serieg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cadenaarchivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents version As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noAprovacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents filtrofecha As System.Windows.Forms.CheckBox

End Class
