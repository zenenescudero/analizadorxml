<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leerxml
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(leerxml))
        Me.directorio = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cadenaleer = New System.Windows.Forms.TextBox()
        Me.cadenaguardar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grillaerrores = New System.Windows.Forms.DataGridView()
        Me.ARCHIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOERROR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grillaarchivos = New System.Windows.Forms.DataGridView()
        Me.ARCHIVOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.griddatosxml = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.guardarerrores = New System.Windows.Forms.SaveFileDialog()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsuc = New System.Windows.Forms.TextBox()
        Me.SubCarpeta = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
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
        CType(Me.grillaerrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grillaarchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.griddatosxml, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(712, 219)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Examinar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(715, 263)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Examinar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lector XML"
        '
        'cadenaleer
        '
        Me.cadenaleer.BackColor = System.Drawing.Color.White
        Me.cadenaleer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadenaleer.Location = New System.Drawing.Point(229, 224)
        Me.cadenaleer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cadenaleer.Name = "cadenaleer"
        Me.cadenaleer.ReadOnly = True
        Me.cadenaleer.Size = New System.Drawing.Size(477, 22)
        Me.cadenaleer.TabIndex = 3
        '
        'cadenaguardar
        '
        Me.cadenaguardar.BackColor = System.Drawing.Color.White
        Me.cadenaguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadenaguardar.Location = New System.Drawing.Point(229, 268)
        Me.cadenaguardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cadenaguardar.Name = "cadenaguardar"
        Me.cadenaguardar.ReadOnly = True
        Me.cadenaguardar.Size = New System.Drawing.Size(477, 22)
        Me.cadenaguardar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 227)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Carpeta de XML Originales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 274)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Carpeta XML Renombrados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Lector XML"
        '
        'grillaerrores
        '
        Me.grillaerrores.AllowUserToAddRows = False
        Me.grillaerrores.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grillaerrores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grillaerrores.BackgroundColor = System.Drawing.Color.Linen
        Me.grillaerrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaerrores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ARCHIVO, Me.TIPOERROR})
        Me.grillaerrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grillaerrores.GridColor = System.Drawing.SystemColors.Control
        Me.grillaerrores.Location = New System.Drawing.Point(3, 3)
        Me.grillaerrores.MultiSelect = False
        Me.grillaerrores.Name = "grillaerrores"
        Me.grillaerrores.ReadOnly = True
        Me.grillaerrores.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = Nothing
        Me.grillaerrores.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grillaerrores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaerrores.Size = New System.Drawing.Size(805, 161)
        Me.grillaerrores.TabIndex = 8
        Me.grillaerrores.TabStop = False
        '
        'ARCHIVO
        '
        Me.ARCHIVO.HeaderText = "ARCHIVO Origen"
        Me.ARCHIVO.Name = "ARCHIVO"
        Me.ARCHIVO.ReadOnly = True
        Me.ARCHIVO.Width = 300
        '
        'TIPOERROR
        '
        Me.TIPOERROR.HeaderText = "ERROR"
        Me.TIPOERROR.Name = "TIPOERROR"
        Me.TIPOERROR.ReadOnly = True
        Me.TIPOERROR.Width = 500
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 319)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Archivos a Remplazar:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(15, 376)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 200)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grillaarchivos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(811, 167)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Archivos Xml"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grillaarchivos
        '
        Me.grillaarchivos.AllowUserToAddRows = False
        Me.grillaarchivos.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grillaarchivos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grillaarchivos.BackgroundColor = System.Drawing.Color.Linen
        Me.grillaarchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaarchivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ARCHIVOL})
        Me.grillaarchivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grillaarchivos.GridColor = System.Drawing.SystemColors.Control
        Me.grillaarchivos.Location = New System.Drawing.Point(3, 3)
        Me.grillaarchivos.MultiSelect = False
        Me.grillaarchivos.Name = "grillaarchivos"
        Me.grillaarchivos.ReadOnly = True
        Me.grillaarchivos.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.NullValue = Nothing
        Me.grillaarchivos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grillaarchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaarchivos.Size = New System.Drawing.Size(805, 161)
        Me.grillaarchivos.TabIndex = 9
        Me.grillaarchivos.TabStop = False
        '
        'ARCHIVOL
        '
        Me.ARCHIVOL.HeaderText = "ARCHIVO"
        Me.ARCHIVOL.Name = "ARCHIVOL"
        Me.ARCHIVOL.ReadOnly = True
        Me.ARCHIVOL.Width = 700
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grillaerrores)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(811, 167)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Errores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.griddatosxml)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(811, 167)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Resultados"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'griddatosxml
        '
        Me.griddatosxml.AllowUserToAddRows = False
        Me.griddatosxml.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griddatosxml.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.NullValue = Nothing
        Me.griddatosxml.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.griddatosxml.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.griddatosxml.Size = New System.Drawing.Size(805, 161)
        Me.griddatosxml.TabIndex = 9
        Me.griddatosxml.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(282, 304)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(259, 35)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Iniciar Proceso"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(567, 354)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 35)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Exportar Errores en Excel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(532, 74)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(259, 35)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Proceso Nuevo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Sucursal"
        '
        'txtsuc
        '
        Me.txtsuc.BackColor = System.Drawing.Color.White
        Me.txtsuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsuc.Location = New System.Drawing.Point(229, 188)
        Me.txtsuc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsuc.Name = "txtsuc"
        Me.txtsuc.Size = New System.Drawing.Size(186, 26)
        Me.txtsuc.TabIndex = 14
        '
        'SubCarpeta
        '
        Me.SubCarpeta.AutoSize = True
        Me.SubCarpeta.Location = New System.Drawing.Point(821, 222)
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
        Me.Label7.Size = New System.Drawing.Size(309, 29)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Renombrar Archivos XML"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(312, 354)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 35)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "exportar leidos Excel"
        Me.Button7.UseVisualStyleBackColor = True
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
        Me.OrdenCompra.HeaderText = "Orden De Compra"
        Me.OrdenCompra.Name = "OrdenCompra"
        Me.OrdenCompra.ReadOnly = True
        Me.OrdenCompra.Width = 180
        '
        'leerxml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(912, 594)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SubCarpeta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsuc)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cadenaguardar)
        Me.Controls.Add(Me.cadenaleer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "leerxml"
        Me.Text = "Lector Xml"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grillaerrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grillaarchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.griddatosxml, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents directorio As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cadenaleer As System.Windows.Forms.TextBox
    Friend WithEvents cadenaguardar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grillaerrores As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grillaarchivos As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents guardarerrores As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsuc As System.Windows.Forms.TextBox
    Friend WithEvents ARCHIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOERROR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ARCHIVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCarpeta As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents griddatosxml As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
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

End Class
