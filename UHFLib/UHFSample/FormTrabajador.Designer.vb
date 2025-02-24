<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTrabajador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTrabajador))
        Me.ClaveTrabajador = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbContUsuario = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCodTrabajador = New System.Windows.Forms.TextBox()
        Me.panelUsuario = New System.Windows.Forms.Panel()
        Me.iconPassword = New System.Windows.Forms.PictureBox()
        Me.iconUsuario = New System.Windows.Forms.PictureBox()
        Me.tbContClave = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.labelUsuario = New System.Windows.Forms.Label()
        Me.labelClave = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panelBotones = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.buttonCancelar = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1.SuspendLayout
        Me.tbContUsuario.SuspendLayout
        CType(Me.iconPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbContClave.SuspendLayout()
        Me.panelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClaveTrabajador
        '
        Me.ClaveTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClaveTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClaveTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaveTrabajador.ForeColor = System.Drawing.Color.Gray
        Me.ClaveTrabajador.Location = New System.Drawing.Point(3, 3)
        Me.ClaveTrabajador.Name = "ClaveTrabajador"
        Me.ClaveTrabajador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ClaveTrabajador.Size = New System.Drawing.Size(255, 31)
        Me.ClaveTrabajador.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(473, 259)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.tbContUsuario, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.iconPassword, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.iconUsuario, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.tbContClave, 2, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.labelUsuario, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.labelClave, 1, 1)
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(20, 76)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(450, 100)
        Me.tableLayoutPanel1.TabIndex = 7
        '
        'tbContUsuario
        '
        Me.tbContUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbContUsuario.ColumnCount = 1
        Me.tbContUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbContUsuario.Controls.Add(Me.txtCodTrabajador, 0, 0)
        Me.tbContUsuario.Controls.Add(Me.panelUsuario, 0, 1)
        Me.tbContUsuario.Location = New System.Drawing.Point(192, 3)
        Me.tbContUsuario.Name = "tbContUsuario"
        Me.tbContUsuario.RowCount = 2
        Me.tbContUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tbContUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tbContUsuario.Size = New System.Drawing.Size(255, 44)
        Me.tbContUsuario.TabIndex = 6
        '
        'txtCodTrabajador
        '
        Me.txtCodTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtCodTrabajador.ForeColor = System.Drawing.Color.Gray
        Me.txtCodTrabajador.Location = New System.Drawing.Point(3, 3)
        Me.txtCodTrabajador.Name = "txtCodTrabajador"
        Me.txtCodTrabajador.Size = New System.Drawing.Size(249, 31)
        Me.txtCodTrabajador.TabIndex = 0
        Me.txtCodTrabajador.Text = "Ingrese su usuario..."
        '
        'panelUsuario
        '
        Me.panelUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelUsuario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelUsuario.Location = New System.Drawing.Point(3, 42)
        Me.panelUsuario.Name = "panelUsuario"
        Me.panelUsuario.Size = New System.Drawing.Size(249, 1)
        Me.panelUsuario.TabIndex = 4
        '
        'iconPassword
        '
        Me.iconPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconPassword.Image = Global.UHF_Sample.My.Resources.Resources.password
        Me.iconPassword.Location = New System.Drawing.Point(0, 50)
        Me.iconPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.iconPassword.Name = "iconPassword"
        Me.iconPassword.Size = New System.Drawing.Size(54, 50)
        Me.iconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconPassword.TabIndex = 5
        Me.iconPassword.TabStop = False
        '
        'iconUsuario
        '
        Me.iconUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconUsuario.Image = Global.UHF_Sample.My.Resources.Resources.women_user
        Me.iconUsuario.Location = New System.Drawing.Point(0, 0)
        Me.iconUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.iconUsuario.Name = "iconUsuario"
        Me.iconUsuario.Size = New System.Drawing.Size(54, 50)
        Me.iconUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconUsuario.TabIndex = 4
        Me.iconUsuario.TabStop = False
        '
        'tbContClave
        '
        Me.tbContClave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbContClave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tbContClave.ColumnCount = 1
        Me.tbContClave.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbContClave.Controls.Add(Me.panel1, 0, 1)
        Me.tbContClave.Controls.Add(Me.ClaveTrabajador, 0, 0)
        Me.tbContClave.Location = New System.Drawing.Point(189, 50)
        Me.tbContClave.Margin = New System.Windows.Forms.Padding(0)
        Me.tbContClave.Name = "tbContClave"
        Me.tbContClave.RowCount = 2
        Me.tbContClave.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tbContClave.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tbContClave.Size = New System.Drawing.Size(261, 50)
        Me.tbContClave.TabIndex = 3
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panel1.Location = New System.Drawing.Point(3, 48)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(255, 1)
        Me.panel1.TabIndex = 4
        '
        'labelUsuario
        '
        Me.labelUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelUsuario.AutoSize = True
        Me.labelUsuario.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelUsuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.labelUsuario.Location = New System.Drawing.Point(68, 9)
        Me.labelUsuario.Name = "labelUsuario"
        Me.labelUsuario.Size = New System.Drawing.Size(118, 32)
        Me.labelUsuario.TabIndex = 6
        Me.labelUsuario.Text = "Usuario"
        Me.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelClave
        '
        Me.labelClave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelClave.AutoSize = True
        Me.labelClave.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.labelClave.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.labelClave.Location = New System.Drawing.Point(98, 59)
        Me.labelClave.Name = "labelClave"
        Me.labelClave.Size = New System.Drawing.Size(88, 32)
        Me.labelClave.TabIndex = 5
        Me.labelClave.Text = "Clave"
        Me.labelClave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.Window
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTitulo.Location = New System.Drawing.Point(115, 27)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(255, 40)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Iniciar Sessión"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelBotones
        '
        Me.panelBotones.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.panelBotones.BackColor = System.Drawing.SystemColors.Window
        Me.panelBotones.Controls.Add(Me.ButtonOk)
        Me.panelBotones.Controls.Add(Me.buttonCancelar)
        Me.panelBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.panelBotones.Location = New System.Drawing.Point(20, 212)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(450, 50)
        Me.panelBotones.TabIndex = 9
        '
        'ButtonOk
        '
        Me.ButtonOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonOk.ForeColor = System.Drawing.Color.White
        Me.ButtonOk.Location = New System.Drawing.Point(307, 3)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(140, 40)
        Me.ButtonOk.TabIndex = 2
        Me.ButtonOk.Text = "Iniciar Sesión"
        Me.ButtonOk.UseVisualStyleBackColor = False
        '
        'buttonCancelar
        '
        Me.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.buttonCancelar.ForeColor = System.Drawing.Color.White
        Me.buttonCancelar.Location = New System.Drawing.Point(161, 3)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(140, 40)
        Me.buttonCancelar.TabIndex = 10
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = False
        '
        'FormTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(491, 277)
        Me.Controls.Add(Me.panelBotones)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTrabajador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Acceso al Sistema"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.tbContUsuario.ResumeLayout(False)
        Me.tbContUsuario.PerformLayout()
        CType(Me.iconPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbContClave.ResumeLayout(False)
        Me.tbContClave.PerformLayout()
        Me.panelBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClaveTrabajador As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents iconPassword As PictureBox
    Private WithEvents iconUsuario As PictureBox
    Private WithEvents tbContClave As TableLayoutPanel
    Private WithEvents panel1 As Panel
    Private WithEvents labelUsuario As Label
    Private WithEvents labelClave As Label
    Private WithEvents lblTitulo As Label
    Private WithEvents panelBotones As FlowLayoutPanel
    Private WithEvents ButtonOk As Button
    Private WithEvents buttonCancelar As Button
    Private WithEvents tbContUsuario As TableLayoutPanel
    Private WithEvents txtCodTrabajador As TextBox
    Private WithEvents panelUsuario As Panel
End Class
