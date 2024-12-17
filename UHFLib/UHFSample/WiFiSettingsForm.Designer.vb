<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiFiSettingsForm
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkDHCPEnabled = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.txtSubnetMask = New System.Windows.Forms.TextBox
        Me.txtGateway = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.labMsg = New System.Windows.Forms.Label
        Me.TimerWaitMsg = New System.Windows.Forms.Timer(Me.components)
        Me.btnRefreshAPList = New System.Windows.Forms.Button
        Me.cboSSID = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMacAddress = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SSID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDHCPEnabled
        '
        Me.chkDHCPEnabled.AutoSize = True
        Me.chkDHCPEnabled.Checked = True
        Me.chkDHCPEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDHCPEnabled.Location = New System.Drawing.Point(43, 119)
        Me.chkDHCPEnabled.Name = "chkDHCPEnabled"
        Me.chkDHCPEnabled.Size = New System.Drawing.Size(140, 23)
        Me.chkDHCPEnabled.TabIndex = 2
        Me.chkDHCPEnabled.Text = "DHCP Enabled"
        Me.chkDHCPEnabled.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Static IP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Subnet Mask"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gateway"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(194, 79)
        Me.txtPassword.MaxLength = 64
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(355, 30)
        Me.txtPassword.TabIndex = 7
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(194, 148)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(355, 30)
        Me.txtIP.TabIndex = 8
        Me.txtIP.Text = "192.168.101.200"
        '
        'txtSubnetMask
        '
        Me.txtSubnetMask.Location = New System.Drawing.Point(194, 184)
        Me.txtSubnetMask.Name = "txtSubnetMask"
        Me.txtSubnetMask.Size = New System.Drawing.Size(355, 30)
        Me.txtSubnetMask.TabIndex = 9
        Me.txtSubnetMask.Text = "255.255.254.0"
        '
        'txtGateway
        '
        Me.txtGateway.Location = New System.Drawing.Point(194, 220)
        Me.txtGateway.Name = "txtGateway"
        Me.txtGateway.Size = New System.Drawing.Size(355, 30)
        Me.txtGateway.TabIndex = 10
        Me.txtGateway.Text = "192.168.100.253"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(87, 299)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(189, 37)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(316, 299)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(189, 37)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'labMsg
        '
        Me.labMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMsg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.labMsg.Location = New System.Drawing.Point(0, 348)
        Me.labMsg.Name = "labMsg"
        Me.labMsg.Size = New System.Drawing.Size(592, 29)
        Me.labMsg.TabIndex = 13
        Me.labMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimerWaitMsg
        '
        Me.TimerWaitMsg.Interval = 250
        '
        'btnRefreshAPList
        '
        Me.btnRefreshAPList.Location = New System.Drawing.Point(361, 44)
        Me.btnRefreshAPList.Name = "btnRefreshAPList"
        Me.btnRefreshAPList.Size = New System.Drawing.Size(188, 29)
        Me.btnRefreshAPList.TabIndex = 14
        Me.btnRefreshAPList.Text = "Refresh SSID List"
        Me.btnRefreshAPList.UseVisualStyleBackColor = True
        '
        'cboSSID
        '
        Me.cboSSID.FormattingEnabled = True
        Me.cboSSID.Location = New System.Drawing.Point(194, 14)
        Me.cboSSID.Name = "cboSSID"
        Me.cboSSID.Size = New System.Drawing.Size(355, 27)
        Me.cboSSID.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Mac Address"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMacAddress
        '
        Me.txtMacAddress.Enabled = False
        Me.txtMacAddress.Location = New System.Drawing.Point(194, 259)
        Me.txtMacAddress.Name = "txtMacAddress"
        Me.txtMacAddress.ReadOnly = True
        Me.txtMacAddress.Size = New System.Drawing.Size(355, 30)
        Me.txtMacAddress.TabIndex = 17
        Me.txtMacAddress.Text = "00:00:00:00:00:00"
        '
        'frmWiFiSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 377)
        Me.Controls.Add(Me.txtMacAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboSSID)
        Me.Controls.Add(Me.btnRefreshAPList)
        Me.Controls.Add(Me.labMsg)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtGateway)
        Me.Controls.Add(Me.txtSubnetMask)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkDHCPEnabled)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("PMingLiU", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWiFiSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WiFi Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkDHCPEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtSubnetMask As System.Windows.Forms.TextBox
    Friend WithEvents txtGateway As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents labMsg As System.Windows.Forms.Label
    Friend WithEvents TimerWaitMsg As System.Windows.Forms.Timer
    Friend WithEvents btnRefreshAPList As System.Windows.Forms.Button
    Friend WithEvents cboSSID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMacAddress As System.Windows.Forms.TextBox
End Class
