<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlerta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlerta))
        Me.MSNAlerta = New System.Windows.Forms.Label()
        Me.FranjaTop = New System.Windows.Forms.Panel()
        Me.tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.icon_info = New System.Windows.Forms.PictureBox()
        Me.icon_error = New System.Windows.Forms.PictureBox()
        Me.icon_ok = New System.Windows.Forms.PictureBox()
        CType(Me.icon_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icon_error, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icon_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSNAlerta
        '
        Me.MSNAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSNAlerta.ForeColor = System.Drawing.Color.DarkOrange
        Me.MSNAlerta.Location = New System.Drawing.Point(86, 14)
        Me.MSNAlerta.Name = "MSNAlerta"
        Me.MSNAlerta.Size = New System.Drawing.Size(220, 48)
        Me.MSNAlerta.TabIndex = 9
        Me.MSNAlerta.Text = "label1"
        '
        'FranjaTop
        '
        Me.FranjaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.FranjaTop.Location = New System.Drawing.Point(0, 0)
        Me.FranjaTop.Name = "FranjaTop"
        Me.FranjaTop.Size = New System.Drawing.Size(311, 8)
        Me.FranjaTop.TabIndex = 5
        '
        'tiempo
        '
        '
        'icon_info
        '
        Me.icon_info.Image = CType(resources.GetObject("icon_info.Image"), System.Drawing.Image)
        Me.icon_info.Location = New System.Drawing.Point(10, 10)
        Me.icon_info.Name = "icon_info"
        Me.icon_info.Size = New System.Drawing.Size(60, 60)
        Me.icon_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon_info.TabIndex = 8
        Me.icon_info.TabStop = False
        '
        'icon_error
        '
        Me.icon_error.Image = CType(resources.GetObject("icon_error.Image"), System.Drawing.Image)
        Me.icon_error.Location = New System.Drawing.Point(10, 10)
        Me.icon_error.Name = "icon_error"
        Me.icon_error.Size = New System.Drawing.Size(60, 60)
        Me.icon_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon_error.TabIndex = 7
        Me.icon_error.TabStop = False
        '
        'icon_ok
        '
        Me.icon_ok.Image = CType(resources.GetObject("icon_ok.Image"), System.Drawing.Image)
        Me.icon_ok.Location = New System.Drawing.Point(10, 10)
        Me.icon_ok.Name = "icon_ok"
        Me.icon_ok.Size = New System.Drawing.Size(60, 60)
        Me.icon_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon_ok.TabIndex = 6
        Me.icon_ok.TabStop = False
        '
        'FormAlerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 71)
        Me.Controls.Add(Me.MSNAlerta)
        Me.Controls.Add(Me.icon_info)
        Me.Controls.Add(Me.icon_error)
        Me.Controls.Add(Me.icon_ok)
        Me.Controls.Add(Me.FranjaTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAlerta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAlerta"
        CType(Me.icon_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icon_error, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icon_ok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents MSNAlerta As Label
    Private WithEvents icon_info As PictureBox
    Private WithEvents icon_error As PictureBox
    Private WithEvents icon_ok As PictureBox
    Private WithEvents FranjaTop As Panel
    Private WithEvents tiempo As Timer
End Class
