<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Atenuar = New System.Windows.Forms.CheckBox()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.Menú = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Contador = New System.Windows.Forms.Timer(Me.components)
        Me.Horas = New System.Windows.Forms.NumericUpDown()
        Me.Minutos = New System.Windows.Forms.NumericUpDown()
        Me.Segundos = New System.Windows.Forms.NumericUpDown()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Menú.SuspendLayout()
        CType(Me.Horas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Segundos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Atenuar
        '
        Me.Atenuar.AutoSize = True
        Me.Atenuar.BackColor = System.Drawing.Color.Transparent
        Me.Atenuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Atenuar.ForeColor = System.Drawing.Color.Transparent
        Me.Atenuar.Location = New System.Drawing.Point(139, 124)
        Me.Atenuar.Name = "Atenuar"
        Me.Atenuar.Size = New System.Drawing.Size(115, 19)
        Me.Atenuar.TabIndex = 18
        Me.Atenuar.Text = "Atenuar pantalla"
        Me.Atenuar.UseVisualStyleBackColor = False
        '
        'btnActivar
        '
        Me.btnActivar.BackColor = System.Drawing.Color.Transparent
        Me.btnActivar.ForeColor = System.Drawing.Color.DimGray
        Me.btnActivar.Location = New System.Drawing.Point(82, 167)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(228, 48)
        Me.btnActivar.TabIndex = 14
        Me.btnActivar.Text = "▶"
        Me.btnActivar.UseVisualStyleBackColor = False
        '
        'Menú
        '
        Me.Menú.BackColor = System.Drawing.Color.Transparent
        Me.Menú.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.Menú.Location = New System.Drawing.Point(0, 0)
        Me.Menú.Name = "Menú"
        Me.Menú.Size = New System.Drawing.Size(392, 24)
        Me.Menú.TabIndex = 19
        Me.Menú.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.Gray
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.Gray
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de..."
        '
        'Contador
        '
        Me.Contador.Interval = 1000
        '
        'Horas
        '
        Me.Horas.BackColor = System.Drawing.Color.Silver
        Me.Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Horas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Horas.Location = New System.Drawing.Point(82, 58)
        Me.Horas.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(60, 38)
        Me.Horas.TabIndex = 23
        Me.Horas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Minutos
        '
        Me.Minutos.BackColor = System.Drawing.Color.Silver
        Me.Minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Minutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Minutos.Location = New System.Drawing.Point(166, 58)
        Me.Minutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(60, 38)
        Me.Minutos.TabIndex = 24
        Me.Minutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Segundos
        '
        Me.Segundos.BackColor = System.Drawing.Color.Silver
        Me.Segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Segundos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Segundos.Location = New System.Drawing.Point(250, 58)
        Me.Segundos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Segundos.Name = "Segundos"
        Me.Segundos.Size = New System.Drawing.Size(60, 38)
        Me.Segundos.TabIndex = 25
        Me.Segundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPuntos.Location = New System.Drawing.Point(227, 59)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(22, 31)
        Me.lblPuntos.TabIndex = 26
        Me.lblPuntos.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(144, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 31)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = ":"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HoraDeDormir.My.Resources.Resources.nocheestrellada
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(392, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.Horas)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Segundos)
        Me.Controls.Add(Me.Menú)
        Me.Controls.Add(Me.Atenuar)
        Me.Controls.Add(Me.btnActivar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "¡Hora de dormir!"
        Me.Menú.ResumeLayout(False)
        Me.Menú.PerformLayout()
        CType(Me.Horas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Segundos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Atenuar As System.Windows.Forms.CheckBox
    Friend WithEvents btnActivar As System.Windows.Forms.Button
    Friend WithEvents Menú As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Contador As System.Windows.Forms.Timer
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Horas As System.Windows.Forms.NumericUpDown
    Friend WithEvents Minutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Segundos As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPuntos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
