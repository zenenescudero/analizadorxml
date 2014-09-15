<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulta
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
        Me.gridtabla = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.REGISTROS = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RadioXML = New System.Windows.Forms.RadioButton()
        Me.RadioFALTANTES = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.gridtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridtabla
        '
        Me.gridtabla.AllowUserToAddRows = False
        Me.gridtabla.AllowUserToDeleteRows = False
        Me.gridtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridtabla.Location = New System.Drawing.Point(26, 154)
        Me.gridtabla.Margin = New System.Windows.Forms.Padding(4)
        Me.gridtabla.Name = "gridtabla"
        Me.gridtabla.RowHeadersVisible = False
        Me.gridtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridtabla.Size = New System.Drawing.Size(939, 327)
        Me.gridtabla.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 18)
        Me.Label3.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'REGISTROS
        '
        Me.REGISTROS.AutoSize = True
        Me.REGISTROS.Location = New System.Drawing.Point(23, 132)
        Me.REGISTROS.Name = "REGISTROS"
        Me.REGISTROS.Size = New System.Drawing.Size(16, 18)
        Me.REGISTROS.TabIndex = 16
        Me.REGISTROS.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 29)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Consultas ZMM - ZMIR6"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(26, 69)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(177, 20)
        Me.RadioButton1.TabIndex = 21
        Me.RadioButton1.Text = "ZMM- No estan en ZMIR6"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(26, 97)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(180, 20)
        Me.RadioButton2.TabIndex = 22
        Me.RadioButton2.Text = "ZMIR6 - No estan en ZMM"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(26, 41)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(159, 20)
        Me.RadioButton3.TabIndex = 23
        Me.RadioButton3.Text = "ZMM - ZMIR6 (Ambos)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(247, 73)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 26)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Exportar a  Excel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(247, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 27)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "GenerarConsultas"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(390, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 27)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(390, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 26)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Colorear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RadioXML
        '
        Me.RadioXML.AutoSize = True
        Me.RadioXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioXML.Location = New System.Drawing.Point(499, 48)
        Me.RadioXML.Name = "RadioXML"
        Me.RadioXML.Size = New System.Drawing.Size(101, 20)
        Me.RadioXML.TabIndex = 29
        Me.RadioXML.Text = "XML - ZMIR6"
        Me.RadioXML.UseVisualStyleBackColor = True
        '
        'RadioFALTANTES
        '
        Me.RadioFALTANTES.AutoSize = True
        Me.RadioFALTANTES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioFALTANTES.Location = New System.Drawing.Point(499, 84)
        Me.RadioFALTANTES.Name = "RadioFALTANTES"
        Me.RadioFALTANTES.Size = New System.Drawing.Size(193, 20)
        Me.RadioFALTANTES.TabIndex = 30
        Me.RadioFALTANTES.Text = "ZMM - ZMIR6 (Faltantes OC)"
        Me.RadioFALTANTES.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(247, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 26)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Eliminar Datos"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(991, 521)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.RadioFALTANTES)
        Me.Controls.Add(Me.RadioXML)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.REGISTROS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gridtabla)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "consulta"
        Me.Text = "Cargar Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridtabla As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents REGISTROS As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RadioXML As System.Windows.Forms.RadioButton
    Friend WithEvents RadioFALTANTES As System.Windows.Forms.RadioButton
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
