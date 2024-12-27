<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.functionCallStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.connectionStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.configToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.operacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VinculacionStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.connectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ConexionStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableroStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.configToolStripMenuItem, Me.operacionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.functionCallStatusLabel, Me.connectionStatusLabel, Me.connectionStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 494)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'functionCallStatusLabel
        '
        Me.functionCallStatusLabel.AutoSize = False
        Me.functionCallStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.functionCallStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.functionCallStatusLabel.Margin = New System.Windows.Forms.Padding(2, 3, 0, 2)
        Me.functionCallStatusLabel.Name = "functionCallStatusLabel"
        Me.functionCallStatusLabel.Size = New System.Drawing.Size(43, 19)
        Me.functionCallStatusLabel.Text = "Ready"
        Me.functionCallStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'connectionStatusLabel
        '
        Me.connectionStatusLabel.Name = "connectionStatusLabel"
        Me.connectionStatusLabel.Size = New System.Drawing.Size(0, 19)
        '
        'configToolStripMenuItem
        '
        Me.configToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConexionStripMenuItem1, Me.TableroStripMenuItem1})
        Me.configToolStripMenuItem.Name = "configToolStripMenuItem"
        Me.configToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.configToolStripMenuItem.Text = "Configuración Tablero"
        '
        'operacionToolStripMenuItem
        '
        Me.operacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VinculacionStripMenuItem1})
        Me.operacionToolStripMenuItem.Name = "operacionToolStripMenuItem"
        Me.operacionToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.operacionToolStripMenuItem.Text = "Operaciones"
        '
        'VinculacionStripMenuItem1
        '
        Me.VinculacionStripMenuItem1.Name = "VinculacionStripMenuItem1"
        Me.VinculacionStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.VinculacionStripMenuItem1.Text = "Vinculación"
        '
        'connectionStatus
        '
        Me.connectionStatus.AutoSize = False
        Me.connectionStatus.BackgroundImage = Global.UHF_Sample.My.Resources.Resources.disconnected
        Me.connectionStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.connectionStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.connectionStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.connectionStatus.Name = "connectionStatus"
        Me.connectionStatus.Size = New System.Drawing.Size(50, 19)
        Me.connectionStatus.Text = "Disconnected"
        '
        'ConexionStripMenuItem1
        '
        Me.ConexionStripMenuItem1.Image = Global.UHF_Sample.My.Resources.Resources.conex_1
        Me.ConexionStripMenuItem1.Name = "ConexionStripMenuItem1"
        Me.ConexionStripMenuItem1.Size = New System.Drawing.Size(196, 38)
        Me.ConexionStripMenuItem1.Text = "Conexion"
        '
        'TableroStripMenuItem1
        '
        Me.TableroStripMenuItem1.Image = Global.UHF_Sample.My.Resources.Resources.icon_rfid
        Me.TableroStripMenuItem1.Name = "TableroStripMenuItem1"
        Me.TableroStripMenuItem1.Size = New System.Drawing.Size(196, 38)
        Me.TableroStripMenuItem1.Text = "Tablero"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 518)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lector RFID"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Private WithEvents connectionStatusLabel As ToolStripStatusLabel
    Private WithEvents connectionStatus As ToolStripStatusLabel
    Private WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents functionCallStatusLabel As ToolStripStatusLabel
    Friend WithEvents configToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConexionStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TableroStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents operacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VinculacionStripMenuItem1 As ToolStripMenuItem
End Class
