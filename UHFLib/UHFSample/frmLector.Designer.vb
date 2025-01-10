<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLector))
        Me.pnlConnect = New System.Windows.Forms.Panel()
        Me.lblRomVersion = New System.Windows.Forms.Label()
        Me.lblSdkVersion = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnWifiSetting = New System.Windows.Forms.Button()
        Me.cbxBaudrate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPort = New System.Windows.Forms.ComboBox()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tpPerformance = New System.Windows.Forms.TabPage()
        Me.gbFrequency = New System.Windows.Forms.GroupBox()
        Me.btnGetFrequency = New System.Windows.Forms.Button()
        Me.gbTaiwanFrequency = New System.Windows.Forms.GroupBox()
        Me.cb920_25 = New System.Windows.Forms.CheckBox()
        Me.cb922_25 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gbJapanFrequency = New System.Windows.Forms.GroupBox()
        Me.cb923_2 = New System.Windows.Forms.CheckBox()
        Me.cb923_0 = New System.Windows.Forms.CheckBox()
        Me.cb922_8 = New System.Windows.Forms.CheckBox()
        Me.cb922_6 = New System.Windows.Forms.CheckBox()
        Me.cb922_4 = New System.Windows.Forms.CheckBox()
        Me.cb922_2 = New System.Windows.Forms.CheckBox()
        Me.cb922_0 = New System.Windows.Forms.CheckBox()
        Me.cb921_8 = New System.Windows.Forms.CheckBox()
        Me.cb921_6 = New System.Windows.Forms.CheckBox()
        Me.cb921_4 = New System.Windows.Forms.CheckBox()
        Me.cb921_2 = New System.Windows.Forms.CheckBox()
        Me.cb921_0 = New System.Windows.Forms.CheckBox()
        Me.cb920_8 = New System.Windows.Forms.CheckBox()
        Me.cb920_6 = New System.Windows.Forms.CheckBox()
        Me.cb920_4 = New System.Windows.Forms.CheckBox()
        Me.cb919_2 = New System.Windows.Forms.CheckBox()
        Me.cb918_0 = New System.Windows.Forms.CheckBox()
        Me.cb916_8 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSetFrequency = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnGetInvnetoryRoundInterval = New System.Windows.Forms.Button()
        Me.nudInventoryRoundInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnSetInvnetoryRoundInterval = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGetRemoveThreshold = New System.Windows.Forms.Button()
        Me.nudTagRemoveThreshold = New System.Windows.Forms.NumericUpDown()
        Me.btnSetRemoveThreshold = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGetTagPresentRepeatInterval = New System.Windows.Forms.Button()
        Me.nudTagPresentRepeatInterval = New System.Windows.Forms.NumericUpDown()
        Me.btnSetTagPresentRepeatInterval = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBoxLinkFrequency = New System.Windows.Forms.GroupBox()
        Me.btnGetLinkFrequency = New System.Windows.Forms.Button()
        Me.cbxLinkFrequency = New System.Windows.Forms.ComboBox()
        Me.btnSetLinkFrequency = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.GroupBoxRxDecode = New System.Windows.Forms.GroupBox()
        Me.btnGetRxDecode = New System.Windows.Forms.Button()
        Me.btnSetRxDecode = New System.Windows.Forms.Button()
        Me.cbxRxDecode = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGetRfSensitivity = New System.Windows.Forms.Button()
        Me.lblRfSensitivity = New System.Windows.Forms.Label()
        Me.btnSetRfSensitivity = New System.Windows.Forms.Button()
        Me.tbRfSensitivity = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGetRfPower = New System.Windows.Forms.Button()
        Me.btnSetRfPower = New System.Windows.Forms.Button()
        Me.tbRfPower = New System.Windows.Forms.TrackBar()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblRfPower = New System.Windows.Forms.Label()
        Me.tpInventory = New System.Windows.Forms.TabPage()
        Me.gbxInventoryEx = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxInventory = New System.Windows.Forms.ComboBox()
        Me.dgvTagList = New System.Windows.Forms.DataGridView()
        Me.clnEPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.op = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.corte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.CodBarras = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsnVincular = New System.Windows.Forms.Label()
        Me.pnlConnect.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tpPerformance.SuspendLayout()
        Me.gbFrequency.SuspendLayout()
        Me.gbTaiwanFrequency.SuspendLayout()
        Me.gbJapanFrequency.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudInventoryRoundInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudTagRemoveThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudTagPresentRepeatInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxLinkFrequency.SuspendLayout()
        Me.GroupBoxRxDecode.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbRfSensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tbRfPower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpInventory.SuspendLayout()
        Me.gbxInventoryEx.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlConnect
        '
        Me.pnlConnect.Controls.Add(Me.lblRomVersion)
        Me.pnlConnect.Controls.Add(Me.lblSdkVersion)
        Me.pnlConnect.Controls.Add(Me.btnConnect)
        Me.pnlConnect.Controls.Add(Me.btnWifiSetting)
        Me.pnlConnect.Controls.Add(Me.cbxBaudrate)
        Me.pnlConnect.Controls.Add(Me.Label2)
        Me.pnlConnect.Controls.Add(Me.Label1)
        Me.pnlConnect.Controls.Add(Me.cbxPort)
        Me.pnlConnect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlConnect.Location = New System.Drawing.Point(0, 647)
        Me.pnlConnect.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.pnlConnect.Name = "pnlConnect"
        Me.pnlConnect.Size = New System.Drawing.Size(609, 76)
        Me.pnlConnect.TabIndex = 1
        '
        'lblRomVersion
        '
        Me.lblRomVersion.AutoSize = True
        Me.lblRomVersion.Location = New System.Drawing.Point(273, 13)
        Me.lblRomVersion.Name = "lblRomVersion"
        Me.lblRomVersion.Size = New System.Drawing.Size(73, 13)
        Me.lblRomVersion.TabIndex = 8
        Me.lblRomVersion.Text = "ROM Version:"
        '
        'lblSdkVersion
        '
        Me.lblSdkVersion.AutoSize = True
        Me.lblSdkVersion.Location = New System.Drawing.Point(23, 13)
        Me.lblSdkVersion.Name = "lblSdkVersion"
        Me.lblSdkVersion.Size = New System.Drawing.Size(70, 13)
        Me.lblSdkVersion.TabIndex = 7
        Me.lblSdkVersion.Text = "SDK Version:"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(460, 36)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(98, 27)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Conectar"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnWifiSetting
        '
        Me.btnWifiSetting.Enabled = False
        Me.btnWifiSetting.Location = New System.Drawing.Point(15, 37)
        Me.btnWifiSetting.Name = "btnWifiSetting"
        Me.btnWifiSetting.Size = New System.Drawing.Size(95, 27)
        Me.btnWifiSetting.TabIndex = 5
        Me.btnWifiSetting.Text = "Wi-Fi Setting"
        Me.btnWifiSetting.UseVisualStyleBackColor = True
        '
        'cbxBaudrate
        '
        Me.cbxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBaudrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbxBaudrate.FormattingEnabled = True
        Me.cbxBaudrate.Location = New System.Drawing.Point(350, 39)
        Me.cbxBaudrate.Name = "cbxBaudrate"
        Me.cbxBaudrate.Size = New System.Drawing.Size(84, 23)
        Me.cbxBaudrate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Baudrate :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Port :"
        '
        'cbxPort
        '
        Me.cbxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbxPort.FormattingEnabled = True
        Me.cbxPort.Location = New System.Drawing.Point(151, 39)
        Me.cbxPort.Name = "cbxPort"
        Me.cbxPort.Size = New System.Drawing.Size(130, 23)
        Me.cbxPort.TabIndex = 1
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tpPerformance)
        Me.tabControl.Controls.Add(Me.tpInventory)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.ItemSize = New System.Drawing.Size(77, 30)
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(609, 647)
        Me.tabControl.TabIndex = 8
        '
        'tpPerformance
        '
        Me.tpPerformance.Controls.Add(Me.gbFrequency)
        Me.tpPerformance.Controls.Add(Me.GroupBox5)
        Me.tpPerformance.Controls.Add(Me.GroupBox4)
        Me.tpPerformance.Controls.Add(Me.GroupBox2)
        Me.tpPerformance.Controls.Add(Me.GroupBoxLinkFrequency)
        Me.tpPerformance.Controls.Add(Me.GroupBoxRxDecode)
        Me.tpPerformance.Controls.Add(Me.GroupBox1)
        Me.tpPerformance.Controls.Add(Me.GroupBox3)
        Me.tpPerformance.Location = New System.Drawing.Point(4, 34)
        Me.tpPerformance.Name = "tpPerformance"
        Me.tpPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPerformance.Size = New System.Drawing.Size(601, 609)
        Me.tpPerformance.TabIndex = 3
        Me.tpPerformance.Text = "Configuración"
        Me.tpPerformance.UseVisualStyleBackColor = True
        Me.tpPerformance.Visible = False
        '
        'gbFrequency
        '
        Me.gbFrequency.Controls.Add(Me.btnGetFrequency)
        Me.gbFrequency.Controls.Add(Me.gbTaiwanFrequency)
        Me.gbFrequency.Controls.Add(Me.gbJapanFrequency)
        Me.gbFrequency.Controls.Add(Me.btnSetFrequency)
        Me.gbFrequency.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbFrequency.Location = New System.Drawing.Point(3, 386)
        Me.gbFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.gbFrequency.Name = "gbFrequency"
        Me.gbFrequency.Padding = New System.Windows.Forms.Padding(2)
        Me.gbFrequency.Size = New System.Drawing.Size(595, 195)
        Me.gbFrequency.TabIndex = 19
        Me.gbFrequency.TabStop = False
        Me.gbFrequency.Text = "Fecuencia"
        '
        'btnGetFrequency
        '
        Me.btnGetFrequency.Location = New System.Drawing.Point(458, 156)
        Me.btnGetFrequency.Name = "btnGetFrequency"
        Me.btnGetFrequency.Size = New System.Drawing.Size(106, 25)
        Me.btnGetFrequency.TabIndex = 19
        Me.btnGetFrequency.Text = "Get"
        Me.btnGetFrequency.UseVisualStyleBackColor = True
        '
        'gbTaiwanFrequency
        '
        Me.gbTaiwanFrequency.Controls.Add(Me.cb920_25)
        Me.gbTaiwanFrequency.Controls.Add(Me.cb922_25)
        Me.gbTaiwanFrequency.Controls.Add(Me.Button2)
        Me.gbTaiwanFrequency.Location = New System.Drawing.Point(8, 100)
        Me.gbTaiwanFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTaiwanFrequency.Name = "gbTaiwanFrequency"
        Me.gbTaiwanFrequency.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTaiwanFrequency.Size = New System.Drawing.Size(556, 51)
        Me.gbTaiwanFrequency.TabIndex = 18
        Me.gbTaiwanFrequency.TabStop = False
        Me.gbTaiwanFrequency.Text = "Taiwan"
        '
        'cb920_25
        '
        Me.cb920_25.AutoSize = True
        Me.cb920_25.Location = New System.Drawing.Point(7, 22)
        Me.cb920_25.Name = "cb920_25"
        Me.cb920_25.Size = New System.Drawing.Size(59, 17)
        Me.cb920_25.TabIndex = 24
        Me.cb920_25.Text = "920.25"
        Me.cb920_25.UseVisualStyleBackColor = True
        '
        'cb922_25
        '
        Me.cb922_25.AutoSize = True
        Me.cb922_25.Location = New System.Drawing.Point(70, 22)
        Me.cb922_25.Name = "cb922_25"
        Me.cb922_25.Size = New System.Drawing.Size(59, 17)
        Me.cb922_25.TabIndex = 23
        Me.cb922_25.Text = "922.25"
        Me.cb922_25.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(432, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 25)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Set Frequency"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gbJapanFrequency
        '
        Me.gbJapanFrequency.Controls.Add(Me.cb923_2)
        Me.gbJapanFrequency.Controls.Add(Me.cb923_0)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_8)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_6)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_4)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_2)
        Me.gbJapanFrequency.Controls.Add(Me.cb922_0)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_8)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_6)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_4)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_2)
        Me.gbJapanFrequency.Controls.Add(Me.cb921_0)
        Me.gbJapanFrequency.Controls.Add(Me.cb920_8)
        Me.gbJapanFrequency.Controls.Add(Me.cb920_6)
        Me.gbJapanFrequency.Controls.Add(Me.cb920_4)
        Me.gbJapanFrequency.Controls.Add(Me.cb919_2)
        Me.gbJapanFrequency.Controls.Add(Me.cb918_0)
        Me.gbJapanFrequency.Controls.Add(Me.cb916_8)
        Me.gbJapanFrequency.Controls.Add(Me.Button1)
        Me.gbJapanFrequency.Location = New System.Drawing.Point(8, 21)
        Me.gbJapanFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.gbJapanFrequency.Name = "gbJapanFrequency"
        Me.gbJapanFrequency.Padding = New System.Windows.Forms.Padding(2)
        Me.gbJapanFrequency.Size = New System.Drawing.Size(556, 75)
        Me.gbJapanFrequency.TabIndex = 17
        Me.gbJapanFrequency.TabStop = False
        Me.gbJapanFrequency.Text = "Japon"
        '
        'cb923_2
        '
        Me.cb923_2.AutoSize = True
        Me.cb923_2.Location = New System.Drawing.Point(491, 46)
        Me.cb923_2.Name = "cb923_2"
        Me.cb923_2.Size = New System.Drawing.Size(53, 17)
        Me.cb923_2.TabIndex = 34
        Me.cb923_2.Text = "923.2"
        Me.cb923_2.UseVisualStyleBackColor = True
        '
        'cb923_0
        '
        Me.cb923_0.AutoSize = True
        Me.cb923_0.Location = New System.Drawing.Point(429, 46)
        Me.cb923_0.Name = "cb923_0"
        Me.cb923_0.Size = New System.Drawing.Size(53, 17)
        Me.cb923_0.TabIndex = 33
        Me.cb923_0.Text = "923.0"
        Me.cb923_0.UseVisualStyleBackColor = True
        '
        'cb922_8
        '
        Me.cb922_8.AutoSize = True
        Me.cb922_8.Location = New System.Drawing.Point(363, 46)
        Me.cb922_8.Name = "cb922_8"
        Me.cb922_8.Size = New System.Drawing.Size(53, 17)
        Me.cb922_8.TabIndex = 32
        Me.cb922_8.Text = "922.8"
        Me.cb922_8.UseVisualStyleBackColor = True
        '
        'cb922_6
        '
        Me.cb922_6.AutoSize = True
        Me.cb922_6.Location = New System.Drawing.Point(304, 46)
        Me.cb922_6.Name = "cb922_6"
        Me.cb922_6.Size = New System.Drawing.Size(53, 17)
        Me.cb922_6.TabIndex = 31
        Me.cb922_6.Text = "922.6"
        Me.cb922_6.UseVisualStyleBackColor = True
        '
        'cb922_4
        '
        Me.cb922_4.AutoSize = True
        Me.cb922_4.Location = New System.Drawing.Point(244, 46)
        Me.cb922_4.Name = "cb922_4"
        Me.cb922_4.Size = New System.Drawing.Size(53, 17)
        Me.cb922_4.TabIndex = 30
        Me.cb922_4.Text = "922.4"
        Me.cb922_4.UseVisualStyleBackColor = True
        '
        'cb922_2
        '
        Me.cb922_2.AutoSize = True
        Me.cb922_2.Location = New System.Drawing.Point(184, 46)
        Me.cb922_2.Name = "cb922_2"
        Me.cb922_2.Size = New System.Drawing.Size(53, 17)
        Me.cb922_2.TabIndex = 29
        Me.cb922_2.Text = "922.2"
        Me.cb922_2.UseVisualStyleBackColor = True
        '
        'cb922_0
        '
        Me.cb922_0.AutoSize = True
        Me.cb922_0.Location = New System.Drawing.Point(127, 46)
        Me.cb922_0.Name = "cb922_0"
        Me.cb922_0.Size = New System.Drawing.Size(53, 17)
        Me.cb922_0.TabIndex = 28
        Me.cb922_0.Text = "922.0"
        Me.cb922_0.UseVisualStyleBackColor = True
        '
        'cb921_8
        '
        Me.cb921_8.AutoSize = True
        Me.cb921_8.Location = New System.Drawing.Point(70, 46)
        Me.cb921_8.Name = "cb921_8"
        Me.cb921_8.Size = New System.Drawing.Size(53, 17)
        Me.cb921_8.TabIndex = 27
        Me.cb921_8.Text = "921.8"
        Me.cb921_8.UseVisualStyleBackColor = True
        '
        'cb921_6
        '
        Me.cb921_6.AutoSize = True
        Me.cb921_6.Location = New System.Drawing.Point(7, 46)
        Me.cb921_6.Name = "cb921_6"
        Me.cb921_6.Size = New System.Drawing.Size(53, 17)
        Me.cb921_6.TabIndex = 26
        Me.cb921_6.Text = "921.6"
        Me.cb921_6.UseVisualStyleBackColor = True
        '
        'cb921_4
        '
        Me.cb921_4.AutoSize = True
        Me.cb921_4.Location = New System.Drawing.Point(491, 22)
        Me.cb921_4.Name = "cb921_4"
        Me.cb921_4.Size = New System.Drawing.Size(53, 17)
        Me.cb921_4.TabIndex = 25
        Me.cb921_4.Text = "921.4"
        Me.cb921_4.UseVisualStyleBackColor = True
        '
        'cb921_2
        '
        Me.cb921_2.AutoSize = True
        Me.cb921_2.Location = New System.Drawing.Point(429, 22)
        Me.cb921_2.Name = "cb921_2"
        Me.cb921_2.Size = New System.Drawing.Size(53, 17)
        Me.cb921_2.TabIndex = 24
        Me.cb921_2.Text = "921.2"
        Me.cb921_2.UseVisualStyleBackColor = True
        '
        'cb921_0
        '
        Me.cb921_0.AutoSize = True
        Me.cb921_0.Location = New System.Drawing.Point(363, 22)
        Me.cb921_0.Name = "cb921_0"
        Me.cb921_0.Size = New System.Drawing.Size(53, 17)
        Me.cb921_0.TabIndex = 23
        Me.cb921_0.Text = "921.0"
        Me.cb921_0.UseVisualStyleBackColor = True
        '
        'cb920_8
        '
        Me.cb920_8.AutoSize = True
        Me.cb920_8.Location = New System.Drawing.Point(304, 22)
        Me.cb920_8.Name = "cb920_8"
        Me.cb920_8.Size = New System.Drawing.Size(53, 17)
        Me.cb920_8.TabIndex = 22
        Me.cb920_8.Text = "920.8"
        Me.cb920_8.UseVisualStyleBackColor = True
        '
        'cb920_6
        '
        Me.cb920_6.AutoSize = True
        Me.cb920_6.Location = New System.Drawing.Point(244, 22)
        Me.cb920_6.Name = "cb920_6"
        Me.cb920_6.Size = New System.Drawing.Size(53, 17)
        Me.cb920_6.TabIndex = 21
        Me.cb920_6.Text = "920.6"
        Me.cb920_6.UseVisualStyleBackColor = True
        '
        'cb920_4
        '
        Me.cb920_4.AutoSize = True
        Me.cb920_4.Location = New System.Drawing.Point(184, 22)
        Me.cb920_4.Name = "cb920_4"
        Me.cb920_4.Size = New System.Drawing.Size(53, 17)
        Me.cb920_4.TabIndex = 20
        Me.cb920_4.Text = "920.4"
        Me.cb920_4.UseVisualStyleBackColor = True
        '
        'cb919_2
        '
        Me.cb919_2.AutoSize = True
        Me.cb919_2.Location = New System.Drawing.Point(127, 22)
        Me.cb919_2.Name = "cb919_2"
        Me.cb919_2.Size = New System.Drawing.Size(53, 17)
        Me.cb919_2.TabIndex = 19
        Me.cb919_2.Text = "919.2"
        Me.cb919_2.UseVisualStyleBackColor = True
        '
        'cb918_0
        '
        Me.cb918_0.AutoSize = True
        Me.cb918_0.Location = New System.Drawing.Point(70, 22)
        Me.cb918_0.Name = "cb918_0"
        Me.cb918_0.Size = New System.Drawing.Size(53, 17)
        Me.cb918_0.TabIndex = 18
        Me.cb918_0.Text = "918.0"
        Me.cb918_0.UseVisualStyleBackColor = True
        '
        'cb916_8
        '
        Me.cb916_8.AutoSize = True
        Me.cb916_8.Location = New System.Drawing.Point(7, 22)
        Me.cb916_8.Name = "cb916_8"
        Me.cb916_8.Size = New System.Drawing.Size(53, 17)
        Me.cb916_8.TabIndex = 17
        Me.cb916_8.Text = "916.8"
        Me.cb916_8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 25)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Set Frequency"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSetFrequency
        '
        Me.btnSetFrequency.Location = New System.Drawing.Point(347, 156)
        Me.btnSetFrequency.Name = "btnSetFrequency"
        Me.btnSetFrequency.Size = New System.Drawing.Size(106, 25)
        Me.btnSetFrequency.TabIndex = 16
        Me.btnSetFrequency.Text = "Set"
        Me.btnSetFrequency.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnGetInvnetoryRoundInterval)
        Me.GroupBox5.Controls.Add(Me.nudInventoryRoundInterval)
        Me.GroupBox5.Controls.Add(Me.btnSetInvnetoryRoundInterval)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 339)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(595, 47)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        '
        'btnGetInvnetoryRoundInterval
        '
        Me.btnGetInvnetoryRoundInterval.Location = New System.Drawing.Point(458, 14)
        Me.btnGetInvnetoryRoundInterval.Name = "btnGetInvnetoryRoundInterval"
        Me.btnGetInvnetoryRoundInterval.Size = New System.Drawing.Size(106, 25)
        Me.btnGetInvnetoryRoundInterval.TabIndex = 20
        Me.btnGetInvnetoryRoundInterval.Text = "Obtener"
        Me.btnGetInvnetoryRoundInterval.UseVisualStyleBackColor = True
        '
        'nudInventoryRoundInterval
        '
        Me.nudInventoryRoundInterval.Location = New System.Drawing.Point(219, 14)
        Me.nudInventoryRoundInterval.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudInventoryRoundInterval.Name = "nudInventoryRoundInterval"
        Me.nudInventoryRoundInterval.Size = New System.Drawing.Size(120, 20)
        Me.nudInventoryRoundInterval.TabIndex = 19
        '
        'btnSetInvnetoryRoundInterval
        '
        Me.btnSetInvnetoryRoundInterval.Location = New System.Drawing.Point(347, 14)
        Me.btnSetInvnetoryRoundInterval.Name = "btnSetInvnetoryRoundInterval"
        Me.btnSetInvnetoryRoundInterval.Size = New System.Drawing.Size(106, 25)
        Me.btnSetInvnetoryRoundInterval.TabIndex = 18
        Me.btnSetInvnetoryRoundInterval.Text = "Establecer"
        Me.btnSetInvnetoryRoundInterval.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 20)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(170, 13)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "Inventory Round Interval (1=10ms)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGetRemoveThreshold)
        Me.GroupBox4.Controls.Add(Me.nudTagRemoveThreshold)
        Me.GroupBox4.Controls.Add(Me.btnSetRemoveThreshold)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 292)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(595, 47)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'btnGetRemoveThreshold
        '
        Me.btnGetRemoveThreshold.Location = New System.Drawing.Point(458, 13)
        Me.btnGetRemoveThreshold.Name = "btnGetRemoveThreshold"
        Me.btnGetRemoveThreshold.Size = New System.Drawing.Size(106, 25)
        Me.btnGetRemoveThreshold.TabIndex = 20
        Me.btnGetRemoveThreshold.Text = "Obtener"
        Me.btnGetRemoveThreshold.UseVisualStyleBackColor = True
        '
        'nudTagRemoveThreshold
        '
        Me.nudTagRemoveThreshold.Location = New System.Drawing.Point(219, 14)
        Me.nudTagRemoveThreshold.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudTagRemoveThreshold.Name = "nudTagRemoveThreshold"
        Me.nudTagRemoveThreshold.Size = New System.Drawing.Size(120, 20)
        Me.nudTagRemoveThreshold.TabIndex = 19
        '
        'btnSetRemoveThreshold
        '
        Me.btnSetRemoveThreshold.Location = New System.Drawing.Point(347, 13)
        Me.btnSetRemoveThreshold.Name = "btnSetRemoveThreshold"
        Me.btnSetRemoveThreshold.Size = New System.Drawing.Size(106, 25)
        Me.btnSetRemoveThreshold.TabIndex = 18
        Me.btnSetRemoveThreshold.Text = "Establecer"
        Me.btnSetRemoveThreshold.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(207, 13)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "Tag Remove Threshold (Inventory Round)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGetTagPresentRepeatInterval)
        Me.GroupBox2.Controls.Add(Me.nudTagPresentRepeatInterval)
        Me.GroupBox2.Controls.Add(Me.btnSetTagPresentRepeatInterval)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 46)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'btnGetTagPresentRepeatInterval
        '
        Me.btnGetTagPresentRepeatInterval.Location = New System.Drawing.Point(458, 14)
        Me.btnGetTagPresentRepeatInterval.Name = "btnGetTagPresentRepeatInterval"
        Me.btnGetTagPresentRepeatInterval.Size = New System.Drawing.Size(106, 25)
        Me.btnGetTagPresentRepeatInterval.TabIndex = 21
        Me.btnGetTagPresentRepeatInterval.Text = "Obtener"
        Me.btnGetTagPresentRepeatInterval.UseVisualStyleBackColor = True
        '
        'nudTagPresentRepeatInterval
        '
        Me.nudTagPresentRepeatInterval.Location = New System.Drawing.Point(219, 15)
        Me.nudTagPresentRepeatInterval.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudTagPresentRepeatInterval.Name = "nudTagPresentRepeatInterval"
        Me.nudTagPresentRepeatInterval.Size = New System.Drawing.Size(120, 20)
        Me.nudTagPresentRepeatInterval.TabIndex = 20
        '
        'btnSetTagPresentRepeatInterval
        '
        Me.btnSetTagPresentRepeatInterval.Location = New System.Drawing.Point(347, 14)
        Me.btnSetTagPresentRepeatInterval.Name = "btnSetTagPresentRepeatInterval"
        Me.btnSetTagPresentRepeatInterval.Size = New System.Drawing.Size(106, 25)
        Me.btnSetTagPresentRepeatInterval.TabIndex = 18
        Me.btnSetTagPresentRepeatInterval.Text = "Establecer"
        Me.btnSetTagPresentRepeatInterval.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(9, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(202, 13)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "Tag Premite Repetir Intervalos (1=100ms)"
        '
        'GroupBoxLinkFrequency
        '
        Me.GroupBoxLinkFrequency.Controls.Add(Me.btnGetLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.cbxLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.btnSetLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.Label50)
        Me.GroupBoxLinkFrequency.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxLinkFrequency.Location = New System.Drawing.Point(3, 197)
        Me.GroupBoxLinkFrequency.Name = "GroupBoxLinkFrequency"
        Me.GroupBoxLinkFrequency.Size = New System.Drawing.Size(595, 49)
        Me.GroupBoxLinkFrequency.TabIndex = 26
        Me.GroupBoxLinkFrequency.TabStop = False
        '
        'btnGetLinkFrequency
        '
        Me.btnGetLinkFrequency.Location = New System.Drawing.Point(457, 18)
        Me.btnGetLinkFrequency.Name = "btnGetLinkFrequency"
        Me.btnGetLinkFrequency.Size = New System.Drawing.Size(107, 25)
        Me.btnGetLinkFrequency.TabIndex = 17
        Me.btnGetLinkFrequency.Text = "Obtener"
        Me.btnGetLinkFrequency.UseVisualStyleBackColor = True
        '
        'cbxLinkFrequency
        '
        Me.cbxLinkFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinkFrequency.FormattingEnabled = True
        Me.cbxLinkFrequency.Location = New System.Drawing.Point(97, 21)
        Me.cbxLinkFrequency.Name = "cbxLinkFrequency"
        Me.cbxLinkFrequency.Size = New System.Drawing.Size(242, 21)
        Me.cbxLinkFrequency.TabIndex = 13
        '
        'btnSetLinkFrequency
        '
        Me.btnSetLinkFrequency.Location = New System.Drawing.Point(346, 18)
        Me.btnSetLinkFrequency.Name = "btnSetLinkFrequency"
        Me.btnSetLinkFrequency.Size = New System.Drawing.Size(107, 25)
        Me.btnSetLinkFrequency.TabIndex = 16
        Me.btnSetLinkFrequency.Text = "Establecer"
        Me.btnSetLinkFrequency.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(6, 25)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(83, 13)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Link Frecuencia"
        '
        'GroupBoxRxDecode
        '
        Me.GroupBoxRxDecode.Controls.Add(Me.btnGetRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.btnSetRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.cbxRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.Label49)
        Me.GroupBoxRxDecode.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxRxDecode.Location = New System.Drawing.Point(3, 154)
        Me.GroupBoxRxDecode.Name = "GroupBoxRxDecode"
        Me.GroupBoxRxDecode.Size = New System.Drawing.Size(595, 43)
        Me.GroupBoxRxDecode.TabIndex = 25
        Me.GroupBoxRxDecode.TabStop = False
        '
        'btnGetRxDecode
        '
        Me.btnGetRxDecode.Location = New System.Drawing.Point(457, 13)
        Me.btnGetRxDecode.Name = "btnGetRxDecode"
        Me.btnGetRxDecode.Size = New System.Drawing.Size(107, 25)
        Me.btnGetRxDecode.TabIndex = 17
        Me.btnGetRxDecode.Text = "Obtener"
        Me.btnGetRxDecode.UseVisualStyleBackColor = True
        '
        'btnSetRxDecode
        '
        Me.btnSetRxDecode.Location = New System.Drawing.Point(346, 13)
        Me.btnSetRxDecode.Name = "btnSetRxDecode"
        Me.btnSetRxDecode.Size = New System.Drawing.Size(107, 25)
        Me.btnSetRxDecode.TabIndex = 16
        Me.btnSetRxDecode.Text = "Establecer"
        Me.btnSetRxDecode.UseVisualStyleBackColor = True
        '
        'cbxRxDecode
        '
        Me.cbxRxDecode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRxDecode.FormattingEnabled = True
        Me.cbxRxDecode.Location = New System.Drawing.Point(97, 15)
        Me.cbxRxDecode.Name = "cbxRxDecode"
        Me.cbxRxDecode.Size = New System.Drawing.Size(242, 21)
        Me.cbxRxDecode.TabIndex = 13
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(6, 20)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(79, 13)
        Me.Label49.TabIndex = 12
        Me.Label49.Text = "Decodificar RX"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGetRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.lblRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.btnSetRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.tbRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 75)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'btnGetRfSensitivity
        '
        Me.btnGetRfSensitivity.Location = New System.Drawing.Point(458, 43)
        Me.btnGetRfSensitivity.Name = "btnGetRfSensitivity"
        Me.btnGetRfSensitivity.Size = New System.Drawing.Size(106, 25)
        Me.btnGetRfSensitivity.TabIndex = 20
        Me.btnGetRfSensitivity.Text = "Obtener"
        Me.btnGetRfSensitivity.UseVisualStyleBackColor = True
        '
        'lblRfSensitivity
        '
        Me.lblRfSensitivity.AutoSize = True
        Me.lblRfSensitivity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRfSensitivity.Location = New System.Drawing.Point(387, 33)
        Me.lblRfSensitivity.Name = "lblRfSensitivity"
        Me.lblRfSensitivity.Size = New System.Drawing.Size(64, 21)
        Me.lblRfSensitivity.TabIndex = 19
        Me.lblRfSensitivity.Text = "Nivel 1"
        '
        'btnSetRfSensitivity
        '
        Me.btnSetRfSensitivity.Location = New System.Drawing.Point(458, 15)
        Me.btnSetRfSensitivity.Name = "btnSetRfSensitivity"
        Me.btnSetRfSensitivity.Size = New System.Drawing.Size(106, 25)
        Me.btnSetRfSensitivity.TabIndex = 18
        Me.btnSetRfSensitivity.Text = "Establecer"
        Me.btnSetRfSensitivity.UseVisualStyleBackColor = True
        '
        'tbRfSensitivity
        '
        Me.tbRfSensitivity.AutoSize = False
        Me.tbRfSensitivity.Location = New System.Drawing.Point(94, 23)
        Me.tbRfSensitivity.Maximum = 14
        Me.tbRfSensitivity.Minimum = 1
        Me.tbRfSensitivity.Name = "tbRfSensitivity"
        Me.tbRfSensitivity.Size = New System.Drawing.Size(284, 33)
        Me.tbRfSensitivity.TabIndex = 14
        Me.tbRfSensitivity.Value = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "RF Sensibilidad : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGetRfPower)
        Me.GroupBox3.Controls.Add(Me.btnSetRfPower)
        Me.GroupBox3.Controls.Add(Me.tbRfPower)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.lblRfPower)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(595, 76)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'btnGetRfPower
        '
        Me.btnGetRfPower.Location = New System.Drawing.Point(457, 44)
        Me.btnGetRfPower.Name = "btnGetRfPower"
        Me.btnGetRfPower.Size = New System.Drawing.Size(107, 25)
        Me.btnGetRfPower.TabIndex = 18
        Me.btnGetRfPower.Text = "Obtener"
        Me.btnGetRfPower.UseVisualStyleBackColor = True
        '
        'btnSetRfPower
        '
        Me.btnSetRfPower.Location = New System.Drawing.Point(458, 15)
        Me.btnSetRfPower.Name = "btnSetRfPower"
        Me.btnSetRfPower.Size = New System.Drawing.Size(106, 25)
        Me.btnSetRfPower.TabIndex = 17
        Me.btnSetRfPower.Text = "Establecer"
        Me.btnSetRfPower.UseVisualStyleBackColor = True
        '
        'tbRfPower
        '
        Me.tbRfPower.AutoSize = False
        Me.tbRfPower.Location = New System.Drawing.Point(97, 23)
        Me.tbRfPower.Maximum = 27
        Me.tbRfPower.Minimum = 1
        Me.tbRfPower.Name = "tbRfPower"
        Me.tbRfPower.Size = New System.Drawing.Size(284, 33)
        Me.tbRfPower.TabIndex = 13
        Me.tbRfPower.Value = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(31, 33)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 13)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "RF Potencia : "
        '
        'lblRfPower
        '
        Me.lblRfPower.AutoSize = True
        Me.lblRfPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRfPower.Location = New System.Drawing.Point(387, 29)
        Me.lblRfPower.Name = "lblRfPower"
        Me.lblRfPower.Size = New System.Drawing.Size(67, 21)
        Me.lblRfPower.TabIndex = 14
        Me.lblRfPower.Text = "11 dBm"
        '
        'tpInventory
        '
        Me.tpInventory.Controls.Add(Me.gbxInventoryEx)
        Me.tpInventory.Location = New System.Drawing.Point(4, 34)
        Me.tpInventory.Name = "tpInventory"
        Me.tpInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInventory.Size = New System.Drawing.Size(601, 609)
        Me.tpInventory.TabIndex = 2
        Me.tpInventory.Text = "Vincular"
        Me.tpInventory.UseVisualStyleBackColor = True
        '
        'gbxInventoryEx
        '
        Me.gbxInventoryEx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInventoryEx.Controls.Add(Me.TableLayoutPanel2)
        Me.gbxInventoryEx.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.gbxInventoryEx.Location = New System.Drawing.Point(3, 3)
        Me.gbxInventoryEx.Margin = New System.Windows.Forms.Padding(0)
        Me.gbxInventoryEx.Name = "gbxInventoryEx"
        Me.gbxInventoryEx.Size = New System.Drawing.Size(595, 603)
        Me.gbxInventoryEx.TabIndex = 8
        Me.gbxInventoryEx.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(589, 584)
        Me.TableLayoutPanel2.TabIndex = 28
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotalCount, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 148)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(583, 23)
        Me.TableLayoutPanel1.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Timbradas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalCount.Location = New System.Drawing.Point(61, 0)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(19, 20)
        Me.lblTotalCount.TabIndex = 1
        Me.lblTotalCount.Text = "0"
        Me.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cbxInventory, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dgvTagList, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 90)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(583, 52)
        Me.TableLayoutPanel4.TabIndex = 39
        '
        'cbxInventory
        '
        Me.cbxInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxInventory.FormattingEnabled = True
        Me.cbxInventory.Location = New System.Drawing.Point(60, 2)
        Me.cbxInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxInventory.Name = "cbxInventory"
        Me.cbxInventory.Size = New System.Drawing.Size(47, 21)
        Me.cbxInventory.TabIndex = 34
        Me.cbxInventory.Visible = False
        '
        'dgvTagList
        '
        Me.dgvTagList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTagList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnEPC, Me.clnTID, Me.clnCount})
        Me.dgvTagList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTagList.Location = New System.Drawing.Point(119, 3)
        Me.dgvTagList.Name = "dgvTagList"
        Me.dgvTagList.RowTemplate.Height = 24
        Me.dgvTagList.Size = New System.Drawing.Size(461, 46)
        Me.dgvTagList.TabIndex = 39
        '
        'clnEPC
        '
        Me.clnEPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnEPC.FillWeight = 40.0!
        Me.clnEPC.HeaderText = "RFID"
        Me.clnEPC.Name = "clnEPC"
        Me.clnEPC.ReadOnly = True
        '
        'clnTID
        '
        Me.clnTID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnTID.FillWeight = 40.0!
        Me.clnTID.HeaderText = "TID"
        Me.clnTID.Name = "clnTID"
        Me.clnTID.ReadOnly = True
        '
        'clnCount
        '
        Me.clnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnCount.FillWeight = 20.0!
        Me.clnCount.HeaderText = "CANTIDAD"
        Me.clnCount.Name = "clnCount"
        Me.clnCount.ReadOnly = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(52, 46)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.op, Me.corte, Me.subcorte, Me.talla, Me.linea, Me.id_talla, Me.fecha})
        Me.TableLayoutPanel2.SetColumnSpan(Me.DataGridView1, 3)
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(583, 404)
        Me.DataGridView1.TabIndex = 37
        '
        'op
        '
        Me.op.HeaderText = "OP"
        Me.op.Name = "op"
        '
        'corte
        '
        Me.corte.HeaderText = "Corte"
        Me.corte.Name = "corte"
        '
        'subcorte
        '
        Me.subcorte.HeaderText = "Sub Corte"
        Me.subcorte.Name = "subcorte"
        '
        'talla
        '
        Me.talla.HeaderText = "Talla"
        Me.talla.Name = "talla"
        '
        'linea
        '
        Me.linea.HeaderText = "Linea"
        Me.linea.Name = "linea"
        '
        'id_talla
        '
        Me.id_talla.HeaderText = "ID"
        Me.id_talla.Name = "id_talla"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClear, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label34, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CodBarras, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(583, 52)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClear.Location = New System.Drawing.Point(480, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 25)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Limpiar"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(2, 0)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(123, 20)
        Me.Label34.TabIndex = 24
        Me.Label34.Text = "Código Barras"
        '
        'CodBarras
        '
        Me.CodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodBarras.Location = New System.Drawing.Point(131, 3)
        Me.CodBarras.Name = "CodBarras"
        Me.CodBarras.Size = New System.Drawing.Size(299, 30)
        Me.CodBarras.TabIndex = 25
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.MsnVincular, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 61)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(583, 23)
        Me.TableLayoutPanel6.TabIndex = 38
        '
        'MsnVincular
        '
        Me.MsnVincular.AutoSize = True
        Me.MsnVincular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsnVincular.Location = New System.Drawing.Point(3, 0)
        Me.MsnVincular.Name = "MsnVincular"
        Me.MsnVincular.Size = New System.Drawing.Size(0, 20)
        Me.MsnVincular.TabIndex = 28
        '
        'frmLector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 723)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.pnlConnect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TS800 Sample"
        Me.pnlConnect.ResumeLayout(False)
        Me.pnlConnect.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.tpPerformance.ResumeLayout(False)
        Me.gbFrequency.ResumeLayout(False)
        Me.gbTaiwanFrequency.ResumeLayout(False)
        Me.gbTaiwanFrequency.PerformLayout()
        Me.gbJapanFrequency.ResumeLayout(False)
        Me.gbJapanFrequency.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudInventoryRoundInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nudTagRemoveThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudTagPresentRepeatInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxLinkFrequency.ResumeLayout(False)
        Me.GroupBoxLinkFrequency.PerformLayout()
        Me.GroupBoxRxDecode.ResumeLayout(False)
        Me.GroupBoxRxDecode.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbRfSensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tbRfPower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpInventory.ResumeLayout(False)
        Me.gbxInventoryEx.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlConnect As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbxBaudrate As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnWifiSetting As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tpPerformance As System.Windows.Forms.TabPage
    Friend WithEvents lblRomVersion As Label
    Friend WithEvents lblSdkVersion As Label
    Friend WithEvents gbFrequency As GroupBox
    Friend WithEvents btnGetFrequency As Button
    Friend WithEvents gbTaiwanFrequency As GroupBox
    Friend WithEvents cb920_25 As CheckBox
    Friend WithEvents cb922_25 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents gbJapanFrequency As GroupBox
    Friend WithEvents cb923_2 As CheckBox
    Friend WithEvents cb923_0 As CheckBox
    Friend WithEvents cb922_8 As CheckBox
    Friend WithEvents cb922_6 As CheckBox
    Friend WithEvents cb922_4 As CheckBox
    Friend WithEvents cb922_2 As CheckBox
    Friend WithEvents cb922_0 As CheckBox
    Friend WithEvents cb921_8 As CheckBox
    Friend WithEvents cb921_6 As CheckBox
    Friend WithEvents cb921_4 As CheckBox
    Friend WithEvents cb921_2 As CheckBox
    Friend WithEvents cb921_0 As CheckBox
    Friend WithEvents cb920_8 As CheckBox
    Friend WithEvents cb920_6 As CheckBox
    Friend WithEvents cb920_4 As CheckBox
    Friend WithEvents cb919_2 As CheckBox
    Friend WithEvents cb918_0 As CheckBox
    Friend WithEvents cb916_8 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSetFrequency As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnGetInvnetoryRoundInterval As Button
    Friend WithEvents nudInventoryRoundInterval As NumericUpDown
    Friend WithEvents btnSetInvnetoryRoundInterval As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnGetRemoveThreshold As Button
    Friend WithEvents nudTagRemoveThreshold As NumericUpDown
    Friend WithEvents btnSetRemoveThreshold As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGetTagPresentRepeatInterval As Button
    Friend WithEvents nudTagPresentRepeatInterval As NumericUpDown
    Friend WithEvents btnSetTagPresentRepeatInterval As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGetRfSensitivity As Button
    Friend WithEvents lblRfSensitivity As Label
    Friend WithEvents btnSetRfSensitivity As Button
    Friend WithEvents tbRfSensitivity As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnGetRfPower As Button
    Friend WithEvents btnSetRfPower As Button
    Friend WithEvents tbRfPower As TrackBar
    Friend WithEvents Label28 As Label
    Friend WithEvents lblRfPower As Label
    Friend WithEvents GroupBoxLinkFrequency As GroupBox
    Friend WithEvents btnGetLinkFrequency As Button
    Friend WithEvents cbxLinkFrequency As ComboBox
    Friend WithEvents btnSetLinkFrequency As Button
    Friend WithEvents Label50 As Label
    Friend WithEvents GroupBoxRxDecode As GroupBox
    Friend WithEvents btnGetRxDecode As Button
    Friend WithEvents btnSetRxDecode As Button
    Friend WithEvents cbxRxDecode As ComboBox
    Friend WithEvents Label49 As Label
    Friend WithEvents tpInventory As TabPage
    Friend WithEvents gbxInventoryEx As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents MsnVincular As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label34 As Label
    Friend WithEvents CodBarras As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents op As DataGridViewTextBoxColumn
    Friend WithEvents corte As DataGridViewTextBoxColumn
    Friend WithEvents subcorte As DataGridViewTextBoxColumn
    Friend WithEvents talla As DataGridViewTextBoxColumn
    Friend WithEvents linea As DataGridViewTextBoxColumn
    Friend WithEvents id_talla As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents cbxInventory As ComboBox
    Friend WithEvents dgvTagList As DataGridView
    Friend WithEvents clnEPC As DataGridViewTextBoxColumn
    Friend WithEvents clnTID As DataGridViewTextBoxColumn
    Friend WithEvents clnCount As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents Label3 As Label
End Class
