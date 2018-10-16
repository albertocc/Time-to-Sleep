<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpciones
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Op_HorasTxt = New System.Windows.Forms.NumericUpDown()
        Me.Op_MinutosTxt = New System.Windows.Forms.NumericUpDown()
        Me.Op_SegundosTxt = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PorcentajeBrillo = New System.Windows.Forms.TrackBar()
        Me.lblBrillo = New System.Windows.Forms.Label()
        Me.Op_Combo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Op_HorasTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Op_MinutosTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Op_SegundosTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PorcentajeBrillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(214, 129)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 36)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(124, 129)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 36)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "&Aceptar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hibernar o apagar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Brillo de pantalla:"
        '
        'Op_HorasTxt
        '
        Me.Op_HorasTxt.Location = New System.Drawing.Point(137, 85)
        Me.Op_HorasTxt.Name = "Op_HorasTxt"
        Me.Op_HorasTxt.Size = New System.Drawing.Size(44, 20)
        Me.Op_HorasTxt.TabIndex = 4
        '
        'Op_MinutosTxt
        '
        Me.Op_MinutosTxt.Location = New System.Drawing.Point(196, 85)
        Me.Op_MinutosTxt.Name = "Op_MinutosTxt"
        Me.Op_MinutosTxt.Size = New System.Drawing.Size(42, 20)
        Me.Op_MinutosTxt.TabIndex = 5
        '
        'Op_SegundosTxt
        '
        Me.Op_SegundosTxt.Location = New System.Drawing.Point(253, 85)
        Me.Op_SegundosTxt.Name = "Op_SegundosTxt"
        Me.Op_SegundosTxt.Size = New System.Drawing.Size(41, 20)
        Me.Op_SegundosTxt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = ":"
        '
        'PorcentajeBrillo
        '
        Me.PorcentajeBrillo.Location = New System.Drawing.Point(130, 43)
        Me.PorcentajeBrillo.Maximum = 100
        Me.PorcentajeBrillo.Name = "PorcentajeBrillo"
        Me.PorcentajeBrillo.Size = New System.Drawing.Size(131, 45)
        Me.PorcentajeBrillo.TabIndex = 9
        '
        'lblBrillo
        '
        Me.lblBrillo.AutoSize = True
        Me.lblBrillo.Location = New System.Drawing.Point(267, 54)
        Me.lblBrillo.Name = "lblBrillo"
        Me.lblBrillo.Size = New System.Drawing.Size(15, 13)
        Me.lblBrillo.TabIndex = 11
        Me.lblBrillo.Text = "%"
        '
        'Op_Combo
        '
        Me.Op_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Op_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Op_Combo.FormattingEnabled = True
        Me.Op_Combo.Items.AddRange(New Object() {"Hibernar", "Suspender", "Apagar"})
        Me.Op_Combo.Location = New System.Drawing.Point(137, 15)
        Me.Op_Combo.Name = "Op_Combo"
        Me.Op_Combo.Size = New System.Drawing.Size(157, 21)
        Me.Op_Combo.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tiempo restante:"
        '
        'frmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(310, 178)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Op_SegundosTxt)
        Me.Controls.Add(Me.Op_MinutosTxt)
        Me.Controls.Add(Me.Op_HorasTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Op_Combo)
        Me.Controls.Add(Me.lblBrillo)
        Me.Controls.Add(Me.PorcentajeBrillo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valores por defecto"
        CType(Me.Op_HorasTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Op_MinutosTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Op_SegundosTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PorcentajeBrillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Op_HorasTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Op_MinutosTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Op_SegundosTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PorcentajeBrillo As System.Windows.Forms.TrackBar
    Friend WithEvents lblBrillo As System.Windows.Forms.Label
    Friend WithEvents Op_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
