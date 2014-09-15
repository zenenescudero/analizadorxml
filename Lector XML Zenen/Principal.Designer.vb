<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.contenedor = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaDeCertificadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.salirdelsistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesZMMMIR6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrigenDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraerDatosXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'contenedor
        '
        Me.contenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contenedor.AutoScroll = True
        Me.contenedor.BackColor = System.Drawing.Color.Gainsboro
        Me.contenedor.Location = New System.Drawing.Point(27, 42)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(897, 594)
        Me.contenedor.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(949, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaToolStripMenuItem1, Me.ExtraerDatosXMLToolStripMenuItem, Me.ConfigurarCorreoToolStripMenuItem, Me.CargaDeCertificadosToolStripMenuItem, Me.salirdelsistemaToolStripMenuItem})
        Me.FacturaToolStripMenuItem.Image = CType(resources.GetObject("FacturaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.FacturaToolStripMenuItem.Text = "Opciones"
        '
        'FacturaToolStripMenuItem1
        '
        Me.FacturaToolStripMenuItem1.Image = CType(resources.GetObject("FacturaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.FacturaToolStripMenuItem1.Name = "FacturaToolStripMenuItem1"
        Me.FacturaToolStripMenuItem1.Size = New System.Drawing.Size(200, 24)
        Me.FacturaToolStripMenuItem1.Text = "Renombrar XML"
        '
        'ConfigurarCorreoToolStripMenuItem
        '
        Me.ConfigurarCorreoToolStripMenuItem.Image = CType(resources.GetObject("ConfigurarCorreoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfigurarCorreoToolStripMenuItem.Name = "ConfigurarCorreoToolStripMenuItem"
        Me.ConfigurarCorreoToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.ConfigurarCorreoToolStripMenuItem.Text = "Cargar Datos ZMM"
        '
        'CargaDeCertificadosToolStripMenuItem
        '
        Me.CargaDeCertificadosToolStripMenuItem.Image = CType(resources.GetObject("CargaDeCertificadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CargaDeCertificadosToolStripMenuItem.Name = "CargaDeCertificadosToolStripMenuItem"
        Me.CargaDeCertificadosToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.CargaDeCertificadosToolStripMenuItem.Text = "Cargar Datos ZMIR6"
        '
        'salirdelsistemaToolStripMenuItem
        '
        Me.salirdelsistemaToolStripMenuItem.Image = CType(resources.GetObject("salirdelsistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.salirdelsistemaToolStripMenuItem.Name = "salirdelsistemaToolStripMenuItem"
        Me.salirdelsistemaToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.salirdelsistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesZMMMIR6ToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Image = CType(resources.GetObject("ConsultasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ReportesZMMMIR6ToolStripMenuItem
        '
        Me.ReportesZMMMIR6ToolStripMenuItem.Name = "ReportesZMMMIR6ToolStripMenuItem"
        Me.ReportesZMMMIR6ToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.ReportesZMMMIR6ToolStripMenuItem.Text = "Reportes ZMM - MIR6"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionToolStripMenuItem, Me.OrigenDeDatosToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.Image = CType(resources.GetObject("InformacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.InformacionToolStripMenuItem.Text = "Informacion"
        '
        'OrigenDeDatosToolStripMenuItem
        '
        Me.OrigenDeDatosToolStripMenuItem.Name = "OrigenDeDatosToolStripMenuItem"
        Me.OrigenDeDatosToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.OrigenDeDatosToolStripMenuItem.Text = "Origen de datos"
        '
        'ExtraerDatosXMLToolStripMenuItem
        '
        Me.ExtraerDatosXMLToolStripMenuItem.Name = "ExtraerDatosXMLToolStripMenuItem"
        Me.ExtraerDatosXMLToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.ExtraerDatosXMLToolStripMenuItem.Text = "Extraer Datos XML"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(949, 662)
        Me.Controls.Add(Me.contenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analisis Mercaderias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salirdelsistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contenedor As System.Windows.Forms.Panel
    Friend WithEvents ConfigurarCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargaDeCertificadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrigenDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesZMMMIR6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraerDatosXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
