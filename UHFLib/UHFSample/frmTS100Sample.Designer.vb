<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTS100Sample
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
        Me.pnlConnect = New System.Windows.Forms.Panel()
        Me.lblRomVersion = New System.Windows.Forms.Label()
        Me.lblSdkVersion = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnWifiSetting = New System.Windows.Forms.Button()
        Me.cbxBaudrate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPort = New System.Windows.Forms.ComboBox()
        Me.btnGetIO_State = New System.Windows.Forms.Button()
        Me.cbRightLight = New System.Windows.Forms.CheckBox()
        Me.cbMidLight = New System.Windows.Forms.CheckBox()
        Me.cbLeftLight = New System.Windows.Forms.CheckBox()
        Me.gbxGPIO = New System.Windows.Forms.GroupBox()
        Me.lblInputState = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.tpDeviceSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnGetActiveMode = New System.Windows.Forms.Button()
        Me.btnSetActiveMode = New System.Windows.Forms.Button()
        Me.cbxActiveMode = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.gbxEventType = New System.Windows.Forms.GroupBox()
        Me.btnGetEventType = New System.Windows.Forms.Button()
        Me.btnSetEventType = New System.Windows.Forms.Button()
        Me.cbxEventType = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.gbxEPCSettings = New System.Windows.Forms.GroupBox()
        Me.btnGetSessionTarget = New System.Windows.Forms.Button()
        Me.btnGetQValue = New System.Windows.Forms.Button()
        Me.cbxSession = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cbxTarget = New System.Windows.Forms.ComboBox()
        Me.cbxQValue = New System.Windows.Forms.ComboBox()
        Me.btnSetSessionTarget = New System.Windows.Forms.Button()
        Me.btnSetQValue = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.gbxScanMode = New System.Windows.Forms.GroupBox()
        Me.btnGetScanMode = New System.Windows.Forms.Button()
        Me.btnSetScanMode = New System.Windows.Forms.Button()
        Me.cbxScanMode = New System.Windows.Forms.ComboBox()
        Me.gbxCommandTriggerState = New System.Windows.Forms.GroupBox()
        Me.btnGetCommandTriggerState = New System.Windows.Forms.Button()
        Me.btnSetCommandTriggerState = New System.Windows.Forms.Button()
        Me.cbxCommandTriggerState = New System.Windows.Forms.ComboBox()
        Me.gbxTrigger = New System.Windows.Forms.GroupBox()
        Me.chkSensor = New System.Windows.Forms.CheckBox()
        Me.chkDigitalInput = New System.Windows.Forms.CheckBox()
        Me.chkCommand = New System.Windows.Forms.CheckBox()
        Me.btnGetTriggerType = New System.Windows.Forms.Button()
        Me.btnSetTriggerType = New System.Windows.Forms.Button()
        Me.gbxFilter = New System.Windows.Forms.GroupBox()
        Me.btnGetFilter = New System.Windows.Forms.Button()
        Me.chkEanUpcEas = New System.Windows.Forms.CheckBox()
        Me.chkEanUpc = New System.Windows.Forms.CheckBox()
        Me.chkRawData = New System.Windows.Forms.CheckBox()
        Me.chkUdc = New System.Windows.Forms.CheckBox()
        Me.btnSetFilter = New System.Windows.Forms.Button()
        Me.gbxInterface = New System.Windows.Forms.GroupBox()
        Me.btnGetOutputInterface = New System.Windows.Forms.Button()
        Me.gbxBinaryOutput = New System.Windows.Forms.GroupBox()
        Me.chkHIDVCom = New System.Windows.Forms.CheckBox()
        Me.chkBLE = New System.Windows.Forms.CheckBox()
        Me.chkTCPClient = New System.Windows.Forms.CheckBox()
        Me.chkTCPServer = New System.Windows.Forms.CheckBox()
        Me.cbxKeyboardSimulation = New System.Windows.Forms.ComboBox()
        Me.lblSingleOutput = New System.Windows.Forms.Label()
        Me.btnSetOutputInterface = New System.Windows.Forms.Button()
        Me.gbxOutputFormat = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chkDelimiterTab = New System.Windows.Forms.CheckBox()
        Me.btnGetDelimiter = New System.Windows.Forms.Button()
        Me.btnSetDelimiter = New System.Windows.Forms.Button()
        Me.chkDelimiterLine = New System.Windows.Forms.CheckBox()
        Me.chkDelimiterCR = New System.Windows.Forms.CheckBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.chkBankEPCASCII = New System.Windows.Forms.CheckBox()
        Me.chkBankUser = New System.Windows.Forms.CheckBox()
        Me.btnGetMemoryBankSelection = New System.Windows.Forms.Button()
        Me.chkBankTID = New System.Windows.Forms.CheckBox()
        Me.btnSetMemoryBankSelection = New System.Windows.Forms.Button()
        Me.chkBankEPC = New System.Windows.Forms.CheckBox()
        Me.chkBankPC = New System.Windows.Forms.CheckBox()
        Me.tpControl = New System.Windows.Forms.TabPage()
        Me.gbxBuzzer = New System.Windows.Forms.GroupBox()
        Me.btnGetBuzzerOperationMode = New System.Windows.Forms.Button()
        Me.btnSetBuzzerOperationMode = New System.Windows.Forms.Button()
        Me.cbxBuzzerOperationMode = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnBuzzerControl = New System.Windows.Forms.Button()
        Me.cbxBuzzerAction = New System.Windows.Forms.ComboBox()
        Me.tpInventory = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbxInventoryEx = New System.Windows.Forms.GroupBox()
        Me.chkInventoryExEANUPCEAS = New System.Windows.Forms.CheckBox()
        Me.chkInventoryExEANUPC = New System.Windows.Forms.CheckBox()
        Me.chkInventoryExRAWDATA = New System.Windows.Forms.CheckBox()
        Me.chkInventoryExUDC = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnStopInventoryEx = New System.Windows.Forms.Button()
        Me.btnStartInventoryEx = New System.Windows.Forms.Button()
        Me.gbxInventory = New System.Windows.Forms.GroupBox()
        Me.cbxInventory = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnStopInventory = New System.Windows.Forms.Button()
        Me.btnStartInventory = New System.Windows.Forms.Button()
        Me.dgvTagList = New System.Windows.Forms.DataGridView()
        Me.clnEPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpReadWriteTag = New System.Windows.Forms.TabPage()
        Me.gbEPCWrite = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbTargetPCEPC = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbEPCWriteHexString = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbEPCWritePassword = New System.Windows.Forms.TextBox()
        Me.btnWriteEPC = New System.Windows.Forms.Button()
        Me.gbWrite = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblEPCHint2 = New System.Windows.Forms.Label()
        Me.lblEPCHint1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxWriteMemoryBank = New System.Windows.Forms.ComboBox()
        Me.nudWriteStart = New System.Windows.Forms.NumericUpDown()
        Me.tbWritePassword = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.tbWriteData = New System.Windows.Forms.TextBox()
        Me.gbRead = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbReadResult = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxReadMemoryBank = New System.Windows.Forms.ComboBox()
        Me.nudReadStart = New System.Windows.Forms.NumericUpDown()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.nudReadLength = New System.Windows.Forms.NumericUpDown()
        Me.tbReadPassword = New System.Windows.Forms.TextBox()
        Me.tpLockKillTag = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.tbKillPassword = New System.Windows.Forms.TextBox()
        Me.btnKillTag = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.tbKillAccessPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnLockTag = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cbxLockAction = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cbxLockBank = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.tbLockAccessPassword = New System.Windows.Forms.TextBox()
        Me.tpBLE = New System.Windows.Forms.TabPage()
        Me.lblBLEROMVersion = New System.Windows.Forms.Label()
        Me.btnGetBLEName = New System.Windows.Forms.Button()
        Me.btnSetBLEName = New System.Windows.Forms.Button()
        Me.tbBLEDeviceName = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pnlConnect.SuspendLayout()
        Me.gbxGPIO.SuspendLayout()
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
        Me.tpDeviceSettings.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.gbxEventType.SuspendLayout()
        Me.gbxEPCSettings.SuspendLayout()
        Me.gbxScanMode.SuspendLayout()
        Me.gbxCommandTriggerState.SuspendLayout()
        Me.gbxTrigger.SuspendLayout()
        Me.gbxFilter.SuspendLayout()
        Me.gbxInterface.SuspendLayout()
        Me.gbxBinaryOutput.SuspendLayout()
        Me.gbxOutputFormat.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.tpControl.SuspendLayout()
        Me.gbxBuzzer.SuspendLayout()
        Me.tpInventory.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbxInventoryEx.SuspendLayout()
        Me.gbxInventory.SuspendLayout()
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReadWriteTag.SuspendLayout()
        Me.gbEPCWrite.SuspendLayout()
        Me.gbWrite.SuspendLayout()
        CType(Me.nudWriteStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRead.SuspendLayout()
        CType(Me.nudReadStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudReadLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLockKillTag.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tpBLE.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlConnect
        '
        Me.pnlConnect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConnect.Controls.Add(Me.lblRomVersion)
        Me.pnlConnect.Controls.Add(Me.lblSdkVersion)
        Me.pnlConnect.Controls.Add(Me.btnConnect)
        Me.pnlConnect.Controls.Add(Me.btnWifiSetting)
        Me.pnlConnect.Controls.Add(Me.cbxBaudrate)
        Me.pnlConnect.Controls.Add(Me.Label2)
        Me.pnlConnect.Controls.Add(Me.Label1)
        Me.pnlConnect.Controls.Add(Me.cbxPort)
        Me.pnlConnect.Location = New System.Drawing.Point(9, 570)
        Me.pnlConnect.Name = "pnlConnect"
        Me.pnlConnect.Size = New System.Drawing.Size(587, 70)
        Me.pnlConnect.TabIndex = 1
        '
        'lblRomVersion
        '
        Me.lblRomVersion.AutoSize = True
        Me.lblRomVersion.Location = New System.Drawing.Point(275, 12)
        Me.lblRomVersion.Name = "lblRomVersion"
        Me.lblRomVersion.Size = New System.Drawing.Size(73, 12)
        Me.lblRomVersion.TabIndex = 8
        Me.lblRomVersion.Text = "ROM Version:"
        '
        'lblSdkVersion
        '
        Me.lblSdkVersion.AutoSize = True
        Me.lblSdkVersion.Location = New System.Drawing.Point(23, 12)
        Me.lblSdkVersion.Name = "lblSdkVersion"
        Me.lblSdkVersion.Size = New System.Drawing.Size(69, 12)
        Me.lblSdkVersion.TabIndex = 7
        Me.lblSdkVersion.Text = "SDK Version:"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(460, 33)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(98, 25)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnWifiSetting
        '
        Me.btnWifiSetting.Enabled = False
        Me.btnWifiSetting.Location = New System.Drawing.Point(15, 34)
        Me.btnWifiSetting.Name = "btnWifiSetting"
        Me.btnWifiSetting.Size = New System.Drawing.Size(95, 25)
        Me.btnWifiSetting.TabIndex = 5
        Me.btnWifiSetting.Text = "Wi-Fi Setting"
        Me.btnWifiSetting.UseVisualStyleBackColor = True
        '
        'cbxBaudrate
        '
        Me.cbxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBaudrate.Font = New System.Drawing.Font("PMingLiU", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbxBaudrate.FormattingEnabled = True
        Me.cbxBaudrate.Location = New System.Drawing.Point(350, 36)
        Me.cbxBaudrate.Name = "cbxBaudrate"
        Me.cbxBaudrate.Size = New System.Drawing.Size(84, 20)
        Me.cbxBaudrate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Baudrate :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Port :"
        '
        'cbxPort
        '
        Me.cbxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPort.Font = New System.Drawing.Font("PMingLiU", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbxPort.FormattingEnabled = True
        Me.cbxPort.Location = New System.Drawing.Point(151, 36)
        Me.cbxPort.Name = "cbxPort"
        Me.cbxPort.Size = New System.Drawing.Size(130, 20)
        Me.cbxPort.TabIndex = 1
        '
        'btnGetIO_State
        '
        Me.btnGetIO_State.Location = New System.Drawing.Point(453, 20)
        Me.btnGetIO_State.Name = "btnGetIO_State"
        Me.btnGetIO_State.Size = New System.Drawing.Size(107, 23)
        Me.btnGetIO_State.TabIndex = 7
        Me.btnGetIO_State.Text = "Get IO State"
        Me.btnGetIO_State.UseVisualStyleBackColor = True
        '
        'cbRightLight
        '
        Me.cbRightLight.AutoSize = True
        Me.cbRightLight.Enabled = False
        Me.cbRightLight.Location = New System.Drawing.Point(368, 25)
        Me.cbRightLight.Name = "cbRightLight"
        Me.cbRightLight.Size = New System.Drawing.Size(52, 16)
        Me.cbRightLight.TabIndex = 5
        Me.cbRightLight.Text = "Port 3"
        Me.cbRightLight.UseVisualStyleBackColor = True
        '
        'cbMidLight
        '
        Me.cbMidLight.AutoSize = True
        Me.cbMidLight.Enabled = False
        Me.cbMidLight.Location = New System.Drawing.Point(314, 25)
        Me.cbMidLight.Name = "cbMidLight"
        Me.cbMidLight.Size = New System.Drawing.Size(52, 16)
        Me.cbMidLight.TabIndex = 4
        Me.cbMidLight.Text = "Port 2"
        Me.cbMidLight.UseVisualStyleBackColor = True
        '
        'cbLeftLight
        '
        Me.cbLeftLight.AutoSize = True
        Me.cbLeftLight.Enabled = False
        Me.cbLeftLight.Location = New System.Drawing.Point(260, 25)
        Me.cbLeftLight.Name = "cbLeftLight"
        Me.cbLeftLight.Size = New System.Drawing.Size(52, 16)
        Me.cbLeftLight.TabIndex = 3
        Me.cbLeftLight.Text = "Port 1"
        Me.cbLeftLight.UseVisualStyleBackColor = True
        '
        'gbxGPIO
        '
        Me.gbxGPIO.Controls.Add(Me.lblInputState)
        Me.gbxGPIO.Controls.Add(Me.Label6)
        Me.gbxGPIO.Controls.Add(Me.Label5)
        Me.gbxGPIO.Controls.Add(Me.btnGetIO_State)
        Me.gbxGPIO.Controls.Add(Me.cbLeftLight)
        Me.gbxGPIO.Controls.Add(Me.cbMidLight)
        Me.gbxGPIO.Controls.Add(Me.cbRightLight)
        Me.gbxGPIO.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxGPIO.Location = New System.Drawing.Point(3, 3)
        Me.gbxGPIO.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxGPIO.Name = "gbxGPIO"
        Me.gbxGPIO.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxGPIO.Size = New System.Drawing.Size(571, 59)
        Me.gbxGPIO.TabIndex = 7
        Me.gbxGPIO.TabStop = False
        Me.gbxGPIO.Text = "GPIO"
        '
        'lblInputState
        '
        Me.lblInputState.AutoSize = True
        Me.lblInputState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblInputState.Location = New System.Drawing.Point(84, 23)
        Me.lblInputState.Name = "lblInputState"
        Me.lblInputState.Size = New System.Drawing.Size(37, 16)
        Me.lblInputState.TabIndex = 10
        Me.lblInputState.Text = "N/A"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Input State : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Output :"
        '
        'tabControl
        '
        Me.tabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.Controls.Add(Me.tpPerformance)
        Me.tabControl.Controls.Add(Me.tpDeviceSettings)
        Me.tabControl.Controls.Add(Me.tpControl)
        Me.tabControl.Controls.Add(Me.tpInventory)
        Me.tabControl.Controls.Add(Me.tpReadWriteTag)
        Me.tabControl.Controls.Add(Me.tpLockKillTag)
        Me.tabControl.Controls.Add(Me.tpBLE)
        Me.tabControl.Location = New System.Drawing.Point(9, 9)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.Padding = New System.Drawing.Point(3, 3)
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(591, 558)
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
        Me.tpPerformance.Location = New System.Drawing.Point(4, 22)
        Me.tpPerformance.Name = "tpPerformance"
        Me.tpPerformance.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPerformance.Size = New System.Drawing.Size(583, 532)
        Me.tpPerformance.TabIndex = 3
        Me.tpPerformance.Text = "Performance"
        Me.tpPerformance.UseVisualStyleBackColor = True
        '
        'gbFrequency
        '
        Me.gbFrequency.Controls.Add(Me.btnGetFrequency)
        Me.gbFrequency.Controls.Add(Me.gbTaiwanFrequency)
        Me.gbFrequency.Controls.Add(Me.gbJapanFrequency)
        Me.gbFrequency.Controls.Add(Me.btnSetFrequency)
        Me.gbFrequency.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbFrequency.Location = New System.Drawing.Point(3, 355)
        Me.gbFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.gbFrequency.Name = "gbFrequency"
        Me.gbFrequency.Padding = New System.Windows.Forms.Padding(2)
        Me.gbFrequency.Size = New System.Drawing.Size(577, 174)
        Me.gbFrequency.TabIndex = 13
        Me.gbFrequency.TabStop = False
        Me.gbFrequency.Text = "Frequency"
        '
        'btnGetFrequency
        '
        Me.btnGetFrequency.Location = New System.Drawing.Point(458, 144)
        Me.btnGetFrequency.Name = "btnGetFrequency"
        Me.btnGetFrequency.Size = New System.Drawing.Size(106, 23)
        Me.btnGetFrequency.TabIndex = 19
        Me.btnGetFrequency.Text = "Get"
        Me.btnGetFrequency.UseVisualStyleBackColor = True
        '
        'gbTaiwanFrequency
        '
        Me.gbTaiwanFrequency.Controls.Add(Me.cb920_25)
        Me.gbTaiwanFrequency.Controls.Add(Me.cb922_25)
        Me.gbTaiwanFrequency.Controls.Add(Me.Button2)
        Me.gbTaiwanFrequency.Location = New System.Drawing.Point(8, 92)
        Me.gbTaiwanFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTaiwanFrequency.Name = "gbTaiwanFrequency"
        Me.gbTaiwanFrequency.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTaiwanFrequency.Size = New System.Drawing.Size(556, 47)
        Me.gbTaiwanFrequency.TabIndex = 18
        Me.gbTaiwanFrequency.TabStop = False
        Me.gbTaiwanFrequency.Text = "Taiwan"
        '
        'cb920_25
        '
        Me.cb920_25.AutoSize = True
        Me.cb920_25.Location = New System.Drawing.Point(7, 20)
        Me.cb920_25.Name = "cb920_25"
        Me.cb920_25.Size = New System.Drawing.Size(57, 16)
        Me.cb920_25.TabIndex = 24
        Me.cb920_25.Text = "920.25"
        Me.cb920_25.UseVisualStyleBackColor = True
        '
        'cb922_25
        '
        Me.cb922_25.AutoSize = True
        Me.cb922_25.Location = New System.Drawing.Point(70, 20)
        Me.cb922_25.Name = "cb922_25"
        Me.cb922_25.Size = New System.Drawing.Size(57, 16)
        Me.cb922_25.TabIndex = 23
        Me.cb922_25.Text = "922.25"
        Me.cb922_25.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(432, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
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
        Me.gbJapanFrequency.Location = New System.Drawing.Point(8, 19)
        Me.gbJapanFrequency.Margin = New System.Windows.Forms.Padding(2)
        Me.gbJapanFrequency.Name = "gbJapanFrequency"
        Me.gbJapanFrequency.Padding = New System.Windows.Forms.Padding(2)
        Me.gbJapanFrequency.Size = New System.Drawing.Size(556, 69)
        Me.gbJapanFrequency.TabIndex = 17
        Me.gbJapanFrequency.TabStop = False
        Me.gbJapanFrequency.Text = "Japan"
        '
        'cb923_2
        '
        Me.cb923_2.AutoSize = True
        Me.cb923_2.Location = New System.Drawing.Point(491, 42)
        Me.cb923_2.Name = "cb923_2"
        Me.cb923_2.Size = New System.Drawing.Size(51, 16)
        Me.cb923_2.TabIndex = 34
        Me.cb923_2.Text = "923.2"
        Me.cb923_2.UseVisualStyleBackColor = True
        '
        'cb923_0
        '
        Me.cb923_0.AutoSize = True
        Me.cb923_0.Location = New System.Drawing.Point(429, 42)
        Me.cb923_0.Name = "cb923_0"
        Me.cb923_0.Size = New System.Drawing.Size(51, 16)
        Me.cb923_0.TabIndex = 33
        Me.cb923_0.Text = "923.0"
        Me.cb923_0.UseVisualStyleBackColor = True
        '
        'cb922_8
        '
        Me.cb922_8.AutoSize = True
        Me.cb922_8.Location = New System.Drawing.Point(363, 42)
        Me.cb922_8.Name = "cb922_8"
        Me.cb922_8.Size = New System.Drawing.Size(51, 16)
        Me.cb922_8.TabIndex = 32
        Me.cb922_8.Text = "922.8"
        Me.cb922_8.UseVisualStyleBackColor = True
        '
        'cb922_6
        '
        Me.cb922_6.AutoSize = True
        Me.cb922_6.Location = New System.Drawing.Point(304, 42)
        Me.cb922_6.Name = "cb922_6"
        Me.cb922_6.Size = New System.Drawing.Size(51, 16)
        Me.cb922_6.TabIndex = 31
        Me.cb922_6.Text = "922.6"
        Me.cb922_6.UseVisualStyleBackColor = True
        '
        'cb922_4
        '
        Me.cb922_4.AutoSize = True
        Me.cb922_4.Location = New System.Drawing.Point(244, 42)
        Me.cb922_4.Name = "cb922_4"
        Me.cb922_4.Size = New System.Drawing.Size(51, 16)
        Me.cb922_4.TabIndex = 30
        Me.cb922_4.Text = "922.4"
        Me.cb922_4.UseVisualStyleBackColor = True
        '
        'cb922_2
        '
        Me.cb922_2.AutoSize = True
        Me.cb922_2.Location = New System.Drawing.Point(184, 42)
        Me.cb922_2.Name = "cb922_2"
        Me.cb922_2.Size = New System.Drawing.Size(51, 16)
        Me.cb922_2.TabIndex = 29
        Me.cb922_2.Text = "922.2"
        Me.cb922_2.UseVisualStyleBackColor = True
        '
        'cb922_0
        '
        Me.cb922_0.AutoSize = True
        Me.cb922_0.Location = New System.Drawing.Point(127, 42)
        Me.cb922_0.Name = "cb922_0"
        Me.cb922_0.Size = New System.Drawing.Size(51, 16)
        Me.cb922_0.TabIndex = 28
        Me.cb922_0.Text = "922.0"
        Me.cb922_0.UseVisualStyleBackColor = True
        '
        'cb921_8
        '
        Me.cb921_8.AutoSize = True
        Me.cb921_8.Location = New System.Drawing.Point(70, 42)
        Me.cb921_8.Name = "cb921_8"
        Me.cb921_8.Size = New System.Drawing.Size(51, 16)
        Me.cb921_8.TabIndex = 27
        Me.cb921_8.Text = "921.8"
        Me.cb921_8.UseVisualStyleBackColor = True
        '
        'cb921_6
        '
        Me.cb921_6.AutoSize = True
        Me.cb921_6.Location = New System.Drawing.Point(7, 42)
        Me.cb921_6.Name = "cb921_6"
        Me.cb921_6.Size = New System.Drawing.Size(51, 16)
        Me.cb921_6.TabIndex = 26
        Me.cb921_6.Text = "921.6"
        Me.cb921_6.UseVisualStyleBackColor = True
        '
        'cb921_4
        '
        Me.cb921_4.AutoSize = True
        Me.cb921_4.Location = New System.Drawing.Point(491, 20)
        Me.cb921_4.Name = "cb921_4"
        Me.cb921_4.Size = New System.Drawing.Size(51, 16)
        Me.cb921_4.TabIndex = 25
        Me.cb921_4.Text = "921.4"
        Me.cb921_4.UseVisualStyleBackColor = True
        '
        'cb921_2
        '
        Me.cb921_2.AutoSize = True
        Me.cb921_2.Location = New System.Drawing.Point(429, 20)
        Me.cb921_2.Name = "cb921_2"
        Me.cb921_2.Size = New System.Drawing.Size(51, 16)
        Me.cb921_2.TabIndex = 24
        Me.cb921_2.Text = "921.2"
        Me.cb921_2.UseVisualStyleBackColor = True
        '
        'cb921_0
        '
        Me.cb921_0.AutoSize = True
        Me.cb921_0.Location = New System.Drawing.Point(363, 20)
        Me.cb921_0.Name = "cb921_0"
        Me.cb921_0.Size = New System.Drawing.Size(51, 16)
        Me.cb921_0.TabIndex = 23
        Me.cb921_0.Text = "921.0"
        Me.cb921_0.UseVisualStyleBackColor = True
        '
        'cb920_8
        '
        Me.cb920_8.AutoSize = True
        Me.cb920_8.Location = New System.Drawing.Point(304, 20)
        Me.cb920_8.Name = "cb920_8"
        Me.cb920_8.Size = New System.Drawing.Size(51, 16)
        Me.cb920_8.TabIndex = 22
        Me.cb920_8.Text = "920.8"
        Me.cb920_8.UseVisualStyleBackColor = True
        '
        'cb920_6
        '
        Me.cb920_6.AutoSize = True
        Me.cb920_6.Location = New System.Drawing.Point(244, 20)
        Me.cb920_6.Name = "cb920_6"
        Me.cb920_6.Size = New System.Drawing.Size(51, 16)
        Me.cb920_6.TabIndex = 21
        Me.cb920_6.Text = "920.6"
        Me.cb920_6.UseVisualStyleBackColor = True
        '
        'cb920_4
        '
        Me.cb920_4.AutoSize = True
        Me.cb920_4.Location = New System.Drawing.Point(184, 20)
        Me.cb920_4.Name = "cb920_4"
        Me.cb920_4.Size = New System.Drawing.Size(51, 16)
        Me.cb920_4.TabIndex = 20
        Me.cb920_4.Text = "920.4"
        Me.cb920_4.UseVisualStyleBackColor = True
        '
        'cb919_2
        '
        Me.cb919_2.AutoSize = True
        Me.cb919_2.Location = New System.Drawing.Point(127, 20)
        Me.cb919_2.Name = "cb919_2"
        Me.cb919_2.Size = New System.Drawing.Size(51, 16)
        Me.cb919_2.TabIndex = 19
        Me.cb919_2.Text = "919.2"
        Me.cb919_2.UseVisualStyleBackColor = True
        '
        'cb918_0
        '
        Me.cb918_0.AutoSize = True
        Me.cb918_0.Location = New System.Drawing.Point(70, 20)
        Me.cb918_0.Name = "cb918_0"
        Me.cb918_0.Size = New System.Drawing.Size(51, 16)
        Me.cb918_0.TabIndex = 18
        Me.cb918_0.Text = "918.0"
        Me.cb918_0.UseVisualStyleBackColor = True
        '
        'cb916_8
        '
        Me.cb916_8.AutoSize = True
        Me.cb916_8.Location = New System.Drawing.Point(7, 20)
        Me.cb916_8.Name = "cb916_8"
        Me.cb916_8.Size = New System.Drawing.Size(51, 16)
        Me.cb916_8.TabIndex = 17
        Me.cb916_8.Text = "916.8"
        Me.cb916_8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Set Frequency"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSetFrequency
        '
        Me.btnSetFrequency.Location = New System.Drawing.Point(347, 144)
        Me.btnSetFrequency.Name = "btnSetFrequency"
        Me.btnSetFrequency.Size = New System.Drawing.Size(106, 23)
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
        Me.GroupBox5.Location = New System.Drawing.Point(3, 312)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(577, 43)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'btnGetInvnetoryRoundInterval
        '
        Me.btnGetInvnetoryRoundInterval.Location = New System.Drawing.Point(458, 13)
        Me.btnGetInvnetoryRoundInterval.Name = "btnGetInvnetoryRoundInterval"
        Me.btnGetInvnetoryRoundInterval.Size = New System.Drawing.Size(106, 23)
        Me.btnGetInvnetoryRoundInterval.TabIndex = 20
        Me.btnGetInvnetoryRoundInterval.Text = "Get"
        Me.btnGetInvnetoryRoundInterval.UseVisualStyleBackColor = True
        '
        'nudInventoryRoundInterval
        '
        Me.nudInventoryRoundInterval.Location = New System.Drawing.Point(219, 13)
        Me.nudInventoryRoundInterval.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudInventoryRoundInterval.Name = "nudInventoryRoundInterval"
        Me.nudInventoryRoundInterval.Size = New System.Drawing.Size(120, 22)
        Me.nudInventoryRoundInterval.TabIndex = 19
        '
        'btnSetInvnetoryRoundInterval
        '
        Me.btnSetInvnetoryRoundInterval.Location = New System.Drawing.Point(347, 13)
        Me.btnSetInvnetoryRoundInterval.Name = "btnSetInvnetoryRoundInterval"
        Me.btnSetInvnetoryRoundInterval.Size = New System.Drawing.Size(106, 23)
        Me.btnSetInvnetoryRoundInterval.TabIndex = 18
        Me.btnSetInvnetoryRoundInterval.Text = "Set"
        Me.btnSetInvnetoryRoundInterval.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 18)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(173, 12)
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
        Me.GroupBox4.Location = New System.Drawing.Point(3, 269)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(577, 43)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'btnGetRemoveThreshold
        '
        Me.btnGetRemoveThreshold.Location = New System.Drawing.Point(458, 12)
        Me.btnGetRemoveThreshold.Name = "btnGetRemoveThreshold"
        Me.btnGetRemoveThreshold.Size = New System.Drawing.Size(106, 23)
        Me.btnGetRemoveThreshold.TabIndex = 20
        Me.btnGetRemoveThreshold.Text = "Get "
        Me.btnGetRemoveThreshold.UseVisualStyleBackColor = True
        '
        'nudTagRemoveThreshold
        '
        Me.nudTagRemoveThreshold.Location = New System.Drawing.Point(219, 13)
        Me.nudTagRemoveThreshold.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudTagRemoveThreshold.Name = "nudTagRemoveThreshold"
        Me.nudTagRemoveThreshold.Size = New System.Drawing.Size(120, 22)
        Me.nudTagRemoveThreshold.TabIndex = 19
        '
        'btnSetRemoveThreshold
        '
        Me.btnSetRemoveThreshold.Location = New System.Drawing.Point(347, 12)
        Me.btnSetRemoveThreshold.Name = "btnSetRemoveThreshold"
        Me.btnSetRemoveThreshold.Size = New System.Drawing.Size(106, 23)
        Me.btnSetRemoveThreshold.TabIndex = 18
        Me.btnSetRemoveThreshold.Text = "Set "
        Me.btnSetRemoveThreshold.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(207, 12)
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
        Me.GroupBox2.Location = New System.Drawing.Point(3, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 42)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btnGetTagPresentRepeatInterval
        '
        Me.btnGetTagPresentRepeatInterval.Location = New System.Drawing.Point(458, 13)
        Me.btnGetTagPresentRepeatInterval.Name = "btnGetTagPresentRepeatInterval"
        Me.btnGetTagPresentRepeatInterval.Size = New System.Drawing.Size(106, 23)
        Me.btnGetTagPresentRepeatInterval.TabIndex = 21
        Me.btnGetTagPresentRepeatInterval.Text = "Get"
        Me.btnGetTagPresentRepeatInterval.UseVisualStyleBackColor = True
        '
        'nudTagPresentRepeatInterval
        '
        Me.nudTagPresentRepeatInterval.Location = New System.Drawing.Point(219, 14)
        Me.nudTagPresentRepeatInterval.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.nudTagPresentRepeatInterval.Name = "nudTagPresentRepeatInterval"
        Me.nudTagPresentRepeatInterval.Size = New System.Drawing.Size(120, 22)
        Me.nudTagPresentRepeatInterval.TabIndex = 20
        '
        'btnSetTagPresentRepeatInterval
        '
        Me.btnSetTagPresentRepeatInterval.Location = New System.Drawing.Point(347, 13)
        Me.btnSetTagPresentRepeatInterval.Name = "btnSetTagPresentRepeatInterval"
        Me.btnSetTagPresentRepeatInterval.Size = New System.Drawing.Size(106, 23)
        Me.btnSetTagPresentRepeatInterval.TabIndex = 18
        Me.btnSetTagPresentRepeatInterval.Text = "Set"
        Me.btnSetTagPresentRepeatInterval.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 18)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(187, 12)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "Tag Present Repeat Interval (1=100ms)"
        '
        'GroupBoxLinkFrequency
        '
        Me.GroupBoxLinkFrequency.Controls.Add(Me.btnGetLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.cbxLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.btnSetLinkFrequency)
        Me.GroupBoxLinkFrequency.Controls.Add(Me.Label50)
        Me.GroupBoxLinkFrequency.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxLinkFrequency.Location = New System.Drawing.Point(3, 182)
        Me.GroupBoxLinkFrequency.Name = "GroupBoxLinkFrequency"
        Me.GroupBoxLinkFrequency.Size = New System.Drawing.Size(577, 45)
        Me.GroupBoxLinkFrequency.TabIndex = 20
        Me.GroupBoxLinkFrequency.TabStop = False
        '
        'btnGetLinkFrequency
        '
        Me.btnGetLinkFrequency.Location = New System.Drawing.Point(457, 17)
        Me.btnGetLinkFrequency.Name = "btnGetLinkFrequency"
        Me.btnGetLinkFrequency.Size = New System.Drawing.Size(107, 23)
        Me.btnGetLinkFrequency.TabIndex = 17
        Me.btnGetLinkFrequency.Text = "Get"
        Me.btnGetLinkFrequency.UseVisualStyleBackColor = True
        '
        'cbxLinkFrequency
        '
        Me.cbxLinkFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinkFrequency.FormattingEnabled = True
        Me.cbxLinkFrequency.Location = New System.Drawing.Point(97, 19)
        Me.cbxLinkFrequency.Name = "cbxLinkFrequency"
        Me.cbxLinkFrequency.Size = New System.Drawing.Size(242, 20)
        Me.cbxLinkFrequency.TabIndex = 13
        '
        'btnSetLinkFrequency
        '
        Me.btnSetLinkFrequency.Location = New System.Drawing.Point(346, 17)
        Me.btnSetLinkFrequency.Name = "btnSetLinkFrequency"
        Me.btnSetLinkFrequency.Size = New System.Drawing.Size(107, 23)
        Me.btnSetLinkFrequency.TabIndex = 16
        Me.btnSetLinkFrequency.Text = "Set"
        Me.btnSetLinkFrequency.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(6, 23)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(79, 12)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Link Frequency"
        '
        'GroupBoxRxDecode
        '
        Me.GroupBoxRxDecode.Controls.Add(Me.btnGetRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.btnSetRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.cbxRxDecode)
        Me.GroupBoxRxDecode.Controls.Add(Me.Label49)
        Me.GroupBoxRxDecode.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxRxDecode.Location = New System.Drawing.Point(3, 142)
        Me.GroupBoxRxDecode.Name = "GroupBoxRxDecode"
        Me.GroupBoxRxDecode.Size = New System.Drawing.Size(577, 40)
        Me.GroupBoxRxDecode.TabIndex = 19
        Me.GroupBoxRxDecode.TabStop = False
        '
        'btnGetRxDecode
        '
        Me.btnGetRxDecode.Location = New System.Drawing.Point(457, 12)
        Me.btnGetRxDecode.Name = "btnGetRxDecode"
        Me.btnGetRxDecode.Size = New System.Drawing.Size(107, 23)
        Me.btnGetRxDecode.TabIndex = 17
        Me.btnGetRxDecode.Text = "Get"
        Me.btnGetRxDecode.UseVisualStyleBackColor = True
        '
        'btnSetRxDecode
        '
        Me.btnSetRxDecode.Location = New System.Drawing.Point(346, 12)
        Me.btnSetRxDecode.Name = "btnSetRxDecode"
        Me.btnSetRxDecode.Size = New System.Drawing.Size(107, 23)
        Me.btnSetRxDecode.TabIndex = 16
        Me.btnSetRxDecode.Text = "Set"
        Me.btnSetRxDecode.UseVisualStyleBackColor = True
        '
        'cbxRxDecode
        '
        Me.cbxRxDecode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRxDecode.FormattingEnabled = True
        Me.cbxRxDecode.Location = New System.Drawing.Point(97, 14)
        Me.cbxRxDecode.Name = "cbxRxDecode"
        Me.cbxRxDecode.Size = New System.Drawing.Size(242, 20)
        Me.cbxRxDecode.TabIndex = 13
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(6, 18)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(59, 12)
        Me.Label49.TabIndex = 12
        Me.Label49.Text = "RX Decode"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGetRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.lblRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.btnSetRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.tbRfSensitivity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 69)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'btnGetRfSensitivity
        '
        Me.btnGetRfSensitivity.Location = New System.Drawing.Point(458, 40)
        Me.btnGetRfSensitivity.Name = "btnGetRfSensitivity"
        Me.btnGetRfSensitivity.Size = New System.Drawing.Size(106, 23)
        Me.btnGetRfSensitivity.TabIndex = 20
        Me.btnGetRfSensitivity.Text = "Get"
        Me.btnGetRfSensitivity.UseVisualStyleBackColor = True
        '
        'lblRfSensitivity
        '
        Me.lblRfSensitivity.AutoSize = True
        Me.lblRfSensitivity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRfSensitivity.Location = New System.Drawing.Point(387, 30)
        Me.lblRfSensitivity.Name = "lblRfSensitivity"
        Me.lblRfSensitivity.Size = New System.Drawing.Size(62, 16)
        Me.lblRfSensitivity.TabIndex = 19
        Me.lblRfSensitivity.Text = "Level 1"
        '
        'btnSetRfSensitivity
        '
        Me.btnSetRfSensitivity.Location = New System.Drawing.Point(458, 14)
        Me.btnSetRfSensitivity.Name = "btnSetRfSensitivity"
        Me.btnSetRfSensitivity.Size = New System.Drawing.Size(106, 23)
        Me.btnSetRfSensitivity.TabIndex = 18
        Me.btnSetRfSensitivity.Text = "Set"
        Me.btnSetRfSensitivity.UseVisualStyleBackColor = True
        '
        'tbRfSensitivity
        '
        Me.tbRfSensitivity.AutoSize = False
        Me.tbRfSensitivity.Location = New System.Drawing.Point(94, 21)
        Me.tbRfSensitivity.Maximum = 14
        Me.tbRfSensitivity.Minimum = 1
        Me.tbRfSensitivity.Name = "tbRfSensitivity"
        Me.tbRfSensitivity.Size = New System.Drawing.Size(284, 30)
        Me.tbRfSensitivity.TabIndex = 14
        Me.tbRfSensitivity.Value = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "RF Sensitivity : "
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
        Me.GroupBox3.Size = New System.Drawing.Size(577, 70)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'btnGetRfPower
        '
        Me.btnGetRfPower.Location = New System.Drawing.Point(457, 41)
        Me.btnGetRfPower.Name = "btnGetRfPower"
        Me.btnGetRfPower.Size = New System.Drawing.Size(107, 23)
        Me.btnGetRfPower.TabIndex = 18
        Me.btnGetRfPower.Text = "Get"
        Me.btnGetRfPower.UseVisualStyleBackColor = True
        '
        'btnSetRfPower
        '
        Me.btnSetRfPower.Location = New System.Drawing.Point(458, 14)
        Me.btnSetRfPower.Name = "btnSetRfPower"
        Me.btnSetRfPower.Size = New System.Drawing.Size(106, 23)
        Me.btnSetRfPower.TabIndex = 17
        Me.btnSetRfPower.Text = "Set"
        Me.btnSetRfPower.UseVisualStyleBackColor = True
        '
        'tbRfPower
        '
        Me.tbRfPower.AutoSize = False
        Me.tbRfPower.Location = New System.Drawing.Point(97, 21)
        Me.tbRfPower.Maximum = 27
        Me.tbRfPower.Minimum = 1
        Me.tbRfPower.Name = "tbRfPower"
        Me.tbRfPower.Size = New System.Drawing.Size(284, 30)
        Me.tbRfPower.TabIndex = 13
        Me.tbRfPower.Value = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 30)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 12)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "RF Power : "
        '
        'lblRfPower
        '
        Me.lblRfPower.AutoSize = True
        Me.lblRfPower.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRfPower.Location = New System.Drawing.Point(387, 27)
        Me.lblRfPower.Name = "lblRfPower"
        Me.lblRfPower.Size = New System.Drawing.Size(64, 16)
        Me.lblRfPower.TabIndex = 14
        Me.lblRfPower.Text = "11 dBm"
        '
        'tpDeviceSettings
        '
        Me.tpDeviceSettings.Controls.Add(Me.GroupBox8)
        Me.tpDeviceSettings.Controls.Add(Me.gbxEventType)
        Me.tpDeviceSettings.Controls.Add(Me.gbxEPCSettings)
        Me.tpDeviceSettings.Controls.Add(Me.gbxScanMode)
        Me.tpDeviceSettings.Controls.Add(Me.gbxCommandTriggerState)
        Me.tpDeviceSettings.Controls.Add(Me.gbxTrigger)
        Me.tpDeviceSettings.Controls.Add(Me.gbxFilter)
        Me.tpDeviceSettings.Controls.Add(Me.gbxInterface)
        Me.tpDeviceSettings.Controls.Add(Me.gbxOutputFormat)
        Me.tpDeviceSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpDeviceSettings.Name = "tpDeviceSettings"
        Me.tpDeviceSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDeviceSettings.Size = New System.Drawing.Size(577, 503)
        Me.tpDeviceSettings.TabIndex = 4
        Me.tpDeviceSettings.Text = "Device Settings"
        Me.tpDeviceSettings.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnGetActiveMode)
        Me.GroupBox8.Controls.Add(Me.btnSetActiveMode)
        Me.GroupBox8.Controls.Add(Me.cbxActiveMode)
        Me.GroupBox8.Controls.Add(Me.Label44)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 530)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(571, 47)
        Me.GroupBox8.TabIndex = 19
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Inventory Active Mode"
        '
        'btnGetActiveMode
        '
        Me.btnGetActiveMode.Location = New System.Drawing.Point(461, 15)
        Me.btnGetActiveMode.Name = "btnGetActiveMode"
        Me.btnGetActiveMode.Size = New System.Drawing.Size(107, 23)
        Me.btnGetActiveMode.TabIndex = 25
        Me.btnGetActiveMode.Text = "Get"
        Me.btnGetActiveMode.UseVisualStyleBackColor = True
        '
        'btnSetActiveMode
        '
        Me.btnSetActiveMode.Location = New System.Drawing.Point(348, 15)
        Me.btnSetActiveMode.Name = "btnSetActiveMode"
        Me.btnSetActiveMode.Size = New System.Drawing.Size(107, 23)
        Me.btnSetActiveMode.TabIndex = 15
        Me.btnSetActiveMode.Text = "Set"
        Me.btnSetActiveMode.UseVisualStyleBackColor = True
        '
        'cbxActiveMode
        '
        Me.cbxActiveMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxActiveMode.FormattingEnabled = True
        Me.cbxActiveMode.Location = New System.Drawing.Point(132, 17)
        Me.cbxActiveMode.Name = "cbxActiveMode"
        Me.cbxActiveMode.Size = New System.Drawing.Size(209, 20)
        Me.cbxActiveMode.TabIndex = 14
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(52, 20)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(74, 12)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Active Mode : "
        '
        'gbxEventType
        '
        Me.gbxEventType.Controls.Add(Me.btnGetEventType)
        Me.gbxEventType.Controls.Add(Me.btnSetEventType)
        Me.gbxEventType.Controls.Add(Me.cbxEventType)
        Me.gbxEventType.Controls.Add(Me.Label26)
        Me.gbxEventType.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxEventType.Location = New System.Drawing.Point(3, 487)
        Me.gbxEventType.Name = "gbxEventType"
        Me.gbxEventType.Size = New System.Drawing.Size(571, 43)
        Me.gbxEventType.TabIndex = 18
        Me.gbxEventType.TabStop = False
        Me.gbxEventType.Text = "Event"
        '
        'btnGetEventType
        '
        Me.btnGetEventType.Location = New System.Drawing.Point(461, 13)
        Me.btnGetEventType.Name = "btnGetEventType"
        Me.btnGetEventType.Size = New System.Drawing.Size(107, 23)
        Me.btnGetEventType.TabIndex = 24
        Me.btnGetEventType.Text = "Get"
        Me.btnGetEventType.UseVisualStyleBackColor = True
        '
        'btnSetEventType
        '
        Me.btnSetEventType.Location = New System.Drawing.Point(348, 14)
        Me.btnSetEventType.Name = "btnSetEventType"
        Me.btnSetEventType.Size = New System.Drawing.Size(107, 23)
        Me.btnSetEventType.TabIndex = 14
        Me.btnSetEventType.Text = "Set"
        Me.btnSetEventType.UseVisualStyleBackColor = True
        '
        'cbxEventType
        '
        Me.cbxEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEventType.FormattingEnabled = True
        Me.cbxEventType.Location = New System.Drawing.Point(133, 15)
        Me.cbxEventType.Name = "cbxEventType"
        Me.cbxEventType.Size = New System.Drawing.Size(208, 20)
        Me.cbxEventType.TabIndex = 13
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(59, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 12)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Event Type : "
        '
        'gbxEPCSettings
        '
        Me.gbxEPCSettings.Controls.Add(Me.btnGetSessionTarget)
        Me.gbxEPCSettings.Controls.Add(Me.btnGetQValue)
        Me.gbxEPCSettings.Controls.Add(Me.cbxSession)
        Me.gbxEPCSettings.Controls.Add(Me.Label33)
        Me.gbxEPCSettings.Controls.Add(Me.cbxTarget)
        Me.gbxEPCSettings.Controls.Add(Me.cbxQValue)
        Me.gbxEPCSettings.Controls.Add(Me.btnSetSessionTarget)
        Me.gbxEPCSettings.Controls.Add(Me.btnSetQValue)
        Me.gbxEPCSettings.Controls.Add(Me.Label31)
        Me.gbxEPCSettings.Controls.Add(Me.Label32)
        Me.gbxEPCSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxEPCSettings.Location = New System.Drawing.Point(3, 419)
        Me.gbxEPCSettings.Name = "gbxEPCSettings"
        Me.gbxEPCSettings.Size = New System.Drawing.Size(571, 68)
        Me.gbxEPCSettings.TabIndex = 17
        Me.gbxEPCSettings.TabStop = False
        Me.gbxEPCSettings.Text = "EPC Settings"
        '
        'btnGetSessionTarget
        '
        Me.btnGetSessionTarget.Location = New System.Drawing.Point(461, 39)
        Me.btnGetSessionTarget.Name = "btnGetSessionTarget"
        Me.btnGetSessionTarget.Size = New System.Drawing.Size(107, 23)
        Me.btnGetSessionTarget.TabIndex = 23
        Me.btnGetSessionTarget.Text = "Get"
        Me.btnGetSessionTarget.UseVisualStyleBackColor = True
        '
        'btnGetQValue
        '
        Me.btnGetQValue.Location = New System.Drawing.Point(461, 13)
        Me.btnGetQValue.Name = "btnGetQValue"
        Me.btnGetQValue.Size = New System.Drawing.Size(107, 23)
        Me.btnGetQValue.TabIndex = 21
        Me.btnGetQValue.Text = "Get"
        Me.btnGetQValue.UseVisualStyleBackColor = True
        '
        'cbxSession
        '
        Me.cbxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSession.FormattingEnabled = True
        Me.cbxSession.Location = New System.Drawing.Point(57, 41)
        Me.cbxSession.Name = "cbxSession"
        Me.cbxSession.Size = New System.Drawing.Size(107, 20)
        Me.cbxSession.TabIndex = 20
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 44)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 12)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Session :"
        '
        'cbxTarget
        '
        Me.cbxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTarget.FormattingEnabled = True
        Me.cbxTarget.Location = New System.Drawing.Point(234, 41)
        Me.cbxTarget.Name = "cbxTarget"
        Me.cbxTarget.Size = New System.Drawing.Size(107, 20)
        Me.cbxTarget.TabIndex = 17
        '
        'cbxQValue
        '
        Me.cbxQValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxQValue.FormattingEnabled = True
        Me.cbxQValue.Location = New System.Drawing.Point(234, 15)
        Me.cbxQValue.Name = "cbxQValue"
        Me.cbxQValue.Size = New System.Drawing.Size(107, 20)
        Me.cbxQValue.TabIndex = 14
        '
        'btnSetSessionTarget
        '
        Me.btnSetSessionTarget.Location = New System.Drawing.Point(348, 39)
        Me.btnSetSessionTarget.Name = "btnSetSessionTarget"
        Me.btnSetSessionTarget.Size = New System.Drawing.Size(107, 23)
        Me.btnSetSessionTarget.TabIndex = 16
        Me.btnSetSessionTarget.Text = "Set"
        Me.btnSetSessionTarget.UseVisualStyleBackColor = True
        '
        'btnSetQValue
        '
        Me.btnSetQValue.Location = New System.Drawing.Point(348, 13)
        Me.btnSetQValue.Name = "btnSetQValue"
        Me.btnSetQValue.Size = New System.Drawing.Size(107, 23)
        Me.btnSetQValue.TabIndex = 1
        Me.btnSetQValue.Text = "Set"
        Me.btnSetQValue.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(179, 18)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(49, 12)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Q Value :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(187, 44)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(41, 12)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Target :"
        '
        'gbxScanMode
        '
        Me.gbxScanMode.Controls.Add(Me.btnGetScanMode)
        Me.gbxScanMode.Controls.Add(Me.btnSetScanMode)
        Me.gbxScanMode.Controls.Add(Me.cbxScanMode)
        Me.gbxScanMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxScanMode.Location = New System.Drawing.Point(3, 378)
        Me.gbxScanMode.Name = "gbxScanMode"
        Me.gbxScanMode.Size = New System.Drawing.Size(571, 41)
        Me.gbxScanMode.TabIndex = 26
        Me.gbxScanMode.TabStop = False
        Me.gbxScanMode.Text = "Scan Mode"
        '
        'btnGetScanMode
        '
        Me.btnGetScanMode.Location = New System.Drawing.Point(462, 12)
        Me.btnGetScanMode.Name = "btnGetScanMode"
        Me.btnGetScanMode.Size = New System.Drawing.Size(107, 23)
        Me.btnGetScanMode.TabIndex = 30
        Me.btnGetScanMode.Text = "Get"
        Me.btnGetScanMode.UseVisualStyleBackColor = True
        '
        'btnSetScanMode
        '
        Me.btnSetScanMode.Location = New System.Drawing.Point(349, 12)
        Me.btnSetScanMode.Name = "btnSetScanMode"
        Me.btnSetScanMode.Size = New System.Drawing.Size(107, 23)
        Me.btnSetScanMode.TabIndex = 29
        Me.btnSetScanMode.Text = "Set"
        Me.btnSetScanMode.UseVisualStyleBackColor = True
        '
        'cbxScanMode
        '
        Me.cbxScanMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxScanMode.FormattingEnabled = True
        Me.cbxScanMode.Location = New System.Drawing.Point(133, 14)
        Me.cbxScanMode.Name = "cbxScanMode"
        Me.cbxScanMode.Size = New System.Drawing.Size(208, 20)
        Me.cbxScanMode.TabIndex = 28
        '
        'gbxCommandTriggerState
        '
        Me.gbxCommandTriggerState.Controls.Add(Me.btnGetCommandTriggerState)
        Me.gbxCommandTriggerState.Controls.Add(Me.btnSetCommandTriggerState)
        Me.gbxCommandTriggerState.Controls.Add(Me.cbxCommandTriggerState)
        Me.gbxCommandTriggerState.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxCommandTriggerState.Location = New System.Drawing.Point(3, 336)
        Me.gbxCommandTriggerState.Name = "gbxCommandTriggerState"
        Me.gbxCommandTriggerState.Size = New System.Drawing.Size(571, 42)
        Me.gbxCommandTriggerState.TabIndex = 25
        Me.gbxCommandTriggerState.TabStop = False
        Me.gbxCommandTriggerState.Text = "Command Trigger State"
        '
        'btnGetCommandTriggerState
        '
        Me.btnGetCommandTriggerState.Location = New System.Drawing.Point(462, 12)
        Me.btnGetCommandTriggerState.Name = "btnGetCommandTriggerState"
        Me.btnGetCommandTriggerState.Size = New System.Drawing.Size(107, 23)
        Me.btnGetCommandTriggerState.TabIndex = 27
        Me.btnGetCommandTriggerState.Text = "Get"
        Me.btnGetCommandTriggerState.UseVisualStyleBackColor = True
        '
        'btnSetCommandTriggerState
        '
        Me.btnSetCommandTriggerState.Location = New System.Drawing.Point(349, 12)
        Me.btnSetCommandTriggerState.Name = "btnSetCommandTriggerState"
        Me.btnSetCommandTriggerState.Size = New System.Drawing.Size(107, 23)
        Me.btnSetCommandTriggerState.TabIndex = 26
        Me.btnSetCommandTriggerState.Text = "Set"
        Me.btnSetCommandTriggerState.UseVisualStyleBackColor = True
        '
        'cbxCommandTriggerState
        '
        Me.cbxCommandTriggerState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCommandTriggerState.FormattingEnabled = True
        Me.cbxCommandTriggerState.Location = New System.Drawing.Point(133, 15)
        Me.cbxCommandTriggerState.Name = "cbxCommandTriggerState"
        Me.cbxCommandTriggerState.Size = New System.Drawing.Size(208, 20)
        Me.cbxCommandTriggerState.TabIndex = 15
        '
        'gbxTrigger
        '
        Me.gbxTrigger.Controls.Add(Me.chkSensor)
        Me.gbxTrigger.Controls.Add(Me.chkDigitalInput)
        Me.gbxTrigger.Controls.Add(Me.chkCommand)
        Me.gbxTrigger.Controls.Add(Me.btnGetTriggerType)
        Me.gbxTrigger.Controls.Add(Me.btnSetTriggerType)
        Me.gbxTrigger.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxTrigger.Location = New System.Drawing.Point(3, 293)
        Me.gbxTrigger.Name = "gbxTrigger"
        Me.gbxTrigger.Size = New System.Drawing.Size(571, 43)
        Me.gbxTrigger.TabIndex = 16
        Me.gbxTrigger.TabStop = False
        Me.gbxTrigger.Text = "Trigger Type"
        '
        'chkSensor
        '
        Me.chkSensor.AutoSize = True
        Me.chkSensor.Location = New System.Drawing.Point(136, 17)
        Me.chkSensor.Name = "chkSensor"
        Me.chkSensor.Size = New System.Drawing.Size(55, 16)
        Me.chkSensor.TabIndex = 23
        Me.chkSensor.Text = "Sensor"
        Me.chkSensor.UseVisualStyleBackColor = True
        '
        'chkDigitalInput
        '
        Me.chkDigitalInput.AutoSize = True
        Me.chkDigitalInput.Location = New System.Drawing.Point(258, 17)
        Me.chkDigitalInput.Name = "chkDigitalInput"
        Me.chkDigitalInput.Size = New System.Drawing.Size(83, 16)
        Me.chkDigitalInput.TabIndex = 22
        Me.chkDigitalInput.Text = "Digital Input"
        Me.chkDigitalInput.UseVisualStyleBackColor = True
        '
        'chkCommand
        '
        Me.chkCommand.AutoSize = True
        Me.chkCommand.Location = New System.Drawing.Point(18, 17)
        Me.chkCommand.Name = "chkCommand"
        Me.chkCommand.Size = New System.Drawing.Size(73, 16)
        Me.chkCommand.TabIndex = 21
        Me.chkCommand.Text = "Command"
        Me.chkCommand.UseVisualStyleBackColor = True
        '
        'btnGetTriggerType
        '
        Me.btnGetTriggerType.Location = New System.Drawing.Point(461, 13)
        Me.btnGetTriggerType.Name = "btnGetTriggerType"
        Me.btnGetTriggerType.Size = New System.Drawing.Size(107, 23)
        Me.btnGetTriggerType.TabIndex = 20
        Me.btnGetTriggerType.Text = "Get"
        Me.btnGetTriggerType.UseVisualStyleBackColor = True
        '
        'btnSetTriggerType
        '
        Me.btnSetTriggerType.Location = New System.Drawing.Point(348, 13)
        Me.btnSetTriggerType.Name = "btnSetTriggerType"
        Me.btnSetTriggerType.Size = New System.Drawing.Size(107, 23)
        Me.btnSetTriggerType.TabIndex = 19
        Me.btnSetTriggerType.Text = "Set"
        Me.btnSetTriggerType.UseVisualStyleBackColor = True
        '
        'gbxFilter
        '
        Me.gbxFilter.Controls.Add(Me.btnGetFilter)
        Me.gbxFilter.Controls.Add(Me.chkEanUpcEas)
        Me.gbxFilter.Controls.Add(Me.chkEanUpc)
        Me.gbxFilter.Controls.Add(Me.chkRawData)
        Me.gbxFilter.Controls.Add(Me.chkUdc)
        Me.gbxFilter.Controls.Add(Me.btnSetFilter)
        Me.gbxFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxFilter.Location = New System.Drawing.Point(3, 228)
        Me.gbxFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxFilter.Name = "gbxFilter"
        Me.gbxFilter.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxFilter.Size = New System.Drawing.Size(571, 65)
        Me.gbxFilter.TabIndex = 15
        Me.gbxFilter.TabStop = False
        Me.gbxFilter.Text = "Filter (Tag Encoded Type)"
        '
        'btnGetFilter
        '
        Me.btnGetFilter.Location = New System.Drawing.Point(461, 37)
        Me.btnGetFilter.Name = "btnGetFilter"
        Me.btnGetFilter.Size = New System.Drawing.Size(107, 23)
        Me.btnGetFilter.TabIndex = 18
        Me.btnGetFilter.Text = "Get"
        Me.btnGetFilter.UseVisualStyleBackColor = True
        '
        'chkEanUpcEas
        '
        Me.chkEanUpcEas.AutoSize = True
        Me.chkEanUpcEas.Location = New System.Drawing.Point(136, 42)
        Me.chkEanUpcEas.Name = "chkEanUpcEas"
        Me.chkEanUpcEas.Size = New System.Drawing.Size(119, 16)
        Me.chkEanUpcEas.TabIndex = 17
        Me.chkEanUpcEas.Text = "EAN/UPC with EAS"
        Me.chkEanUpcEas.UseVisualStyleBackColor = True
        '
        'chkEanUpc
        '
        Me.chkEanUpc.AutoSize = True
        Me.chkEanUpc.Location = New System.Drawing.Point(310, 16)
        Me.chkEanUpc.Name = "chkEanUpc"
        Me.chkEanUpc.Size = New System.Drawing.Size(72, 16)
        Me.chkEanUpc.TabIndex = 16
        Me.chkEanUpc.Text = "EAN/UPC"
        Me.chkEanUpc.UseVisualStyleBackColor = True
        '
        'chkRawData
        '
        Me.chkRawData.AutoSize = True
        Me.chkRawData.Location = New System.Drawing.Point(310, 42)
        Me.chkRawData.Name = "chkRawData"
        Me.chkRawData.Size = New System.Drawing.Size(69, 16)
        Me.chkRawData.TabIndex = 15
        Me.chkRawData.Text = "Raw Data"
        Me.chkRawData.UseVisualStyleBackColor = True
        '
        'chkUdc
        '
        Me.chkUdc.AutoSize = True
        Me.chkUdc.Location = New System.Drawing.Point(136, 16)
        Me.chkUdc.Name = "chkUdc"
        Me.chkUdc.Size = New System.Drawing.Size(48, 16)
        Me.chkUdc.TabIndex = 14
        Me.chkUdc.Text = "UDC"
        Me.chkUdc.UseVisualStyleBackColor = True
        '
        'btnSetFilter
        '
        Me.btnSetFilter.Location = New System.Drawing.Point(461, 12)
        Me.btnSetFilter.Name = "btnSetFilter"
        Me.btnSetFilter.Size = New System.Drawing.Size(107, 23)
        Me.btnSetFilter.TabIndex = 13
        Me.btnSetFilter.Text = "Set"
        Me.btnSetFilter.UseVisualStyleBackColor = True
        '
        'gbxInterface
        '
        Me.gbxInterface.Controls.Add(Me.btnGetOutputInterface)
        Me.gbxInterface.Controls.Add(Me.gbxBinaryOutput)
        Me.gbxInterface.Controls.Add(Me.cbxKeyboardSimulation)
        Me.gbxInterface.Controls.Add(Me.lblSingleOutput)
        Me.gbxInterface.Controls.Add(Me.btnSetOutputInterface)
        Me.gbxInterface.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxInterface.Location = New System.Drawing.Point(3, 108)
        Me.gbxInterface.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxInterface.Name = "gbxInterface"
        Me.gbxInterface.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxInterface.Size = New System.Drawing.Size(571, 120)
        Me.gbxInterface.TabIndex = 14
        Me.gbxInterface.TabStop = False
        Me.gbxInterface.Text = "Output Interface"
        '
        'btnGetOutputInterface
        '
        Me.btnGetOutputInterface.Location = New System.Drawing.Point(461, 87)
        Me.btnGetOutputInterface.Name = "btnGetOutputInterface"
        Me.btnGetOutputInterface.Size = New System.Drawing.Size(107, 23)
        Me.btnGetOutputInterface.TabIndex = 13
        Me.btnGetOutputInterface.Text = "Get"
        Me.btnGetOutputInterface.UseVisualStyleBackColor = True
        '
        'gbxBinaryOutput
        '
        Me.gbxBinaryOutput.Controls.Add(Me.chkHIDVCom)
        Me.gbxBinaryOutput.Controls.Add(Me.chkBLE)
        Me.gbxBinaryOutput.Controls.Add(Me.chkTCPClient)
        Me.gbxBinaryOutput.Controls.Add(Me.chkTCPServer)
        Me.gbxBinaryOutput.Location = New System.Drawing.Point(15, 46)
        Me.gbxBinaryOutput.Name = "gbxBinaryOutput"
        Me.gbxBinaryOutput.Size = New System.Drawing.Size(440, 64)
        Me.gbxBinaryOutput.TabIndex = 12
        Me.gbxBinaryOutput.TabStop = False
        Me.gbxBinaryOutput.Text = "Binary"
        '
        'chkHIDVCom
        '
        Me.chkHIDVCom.AutoSize = True
        Me.chkHIDVCom.Location = New System.Drawing.Point(46, 19)
        Me.chkHIDVCom.Name = "chkHIDVCom"
        Me.chkHIDVCom.Size = New System.Drawing.Size(111, 16)
        Me.chkHIDVCom.TabIndex = 1
        Me.chkHIDVCom.Text = "HID / Virtual Com"
        Me.chkHIDVCom.UseVisualStyleBackColor = True
        '
        'chkBLE
        '
        Me.chkBLE.AutoSize = True
        Me.chkBLE.Location = New System.Drawing.Point(251, 19)
        Me.chkBLE.Name = "chkBLE"
        Me.chkBLE.Size = New System.Drawing.Size(46, 16)
        Me.chkBLE.TabIndex = 2
        Me.chkBLE.Text = "BLE"
        Me.chkBLE.UseVisualStyleBackColor = True
        '
        'chkTCPClient
        '
        Me.chkTCPClient.AutoSize = True
        Me.chkTCPClient.Location = New System.Drawing.Point(46, 41)
        Me.chkTCPClient.Name = "chkTCPClient"
        Me.chkTCPClient.Size = New System.Drawing.Size(114, 16)
        Me.chkTCPClient.TabIndex = 3
        Me.chkTCPClient.Text = "TCP Client (Wi-Fi)"
        Me.chkTCPClient.UseVisualStyleBackColor = True
        '
        'chkTCPServer
        '
        Me.chkTCPServer.AutoSize = True
        Me.chkTCPServer.Location = New System.Drawing.Point(251, 41)
        Me.chkTCPServer.Name = "chkTCPServer"
        Me.chkTCPServer.Size = New System.Drawing.Size(116, 16)
        Me.chkTCPServer.TabIndex = 4
        Me.chkTCPServer.Text = "TCP Server (Wi-Fi)"
        Me.chkTCPServer.UseVisualStyleBackColor = True
        '
        'cbxKeyboardSimulation
        '
        Me.cbxKeyboardSimulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKeyboardSimulation.FormattingEnabled = True
        Me.cbxKeyboardSimulation.Location = New System.Drawing.Point(136, 20)
        Me.cbxKeyboardSimulation.Name = "cbxKeyboardSimulation"
        Me.cbxKeyboardSimulation.Size = New System.Drawing.Size(319, 20)
        Me.cbxKeyboardSimulation.TabIndex = 11
        '
        'lblSingleOutput
        '
        Me.lblSingleOutput.AutoSize = True
        Me.lblSingleOutput.Location = New System.Drawing.Point(13, 23)
        Me.lblSingleOutput.Name = "lblSingleOutput"
        Me.lblSingleOutput.Size = New System.Drawing.Size(113, 12)
        Me.lblSingleOutput.TabIndex = 10
        Me.lblSingleOutput.Text = "Keyboard Simulation : "
        '
        'btnSetOutputInterface
        '
        Me.btnSetOutputInterface.Location = New System.Drawing.Point(461, 58)
        Me.btnSetOutputInterface.Name = "btnSetOutputInterface"
        Me.btnSetOutputInterface.Size = New System.Drawing.Size(107, 23)
        Me.btnSetOutputInterface.TabIndex = 9
        Me.btnSetOutputInterface.Text = "Set"
        Me.btnSetOutputInterface.UseVisualStyleBackColor = True
        '
        'gbxOutputFormat
        '
        Me.gbxOutputFormat.Controls.Add(Me.GroupBox10)
        Me.gbxOutputFormat.Controls.Add(Me.GroupBox9)
        Me.gbxOutputFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxOutputFormat.Location = New System.Drawing.Point(3, 3)
        Me.gbxOutputFormat.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxOutputFormat.Name = "gbxOutputFormat"
        Me.gbxOutputFormat.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxOutputFormat.Size = New System.Drawing.Size(571, 105)
        Me.gbxOutputFormat.TabIndex = 13
        Me.gbxOutputFormat.TabStop = False
        Me.gbxOutputFormat.Text = "Keyboard Output Format"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.chkDelimiterTab)
        Me.GroupBox10.Controls.Add(Me.btnGetDelimiter)
        Me.GroupBox10.Controls.Add(Me.btnSetDelimiter)
        Me.GroupBox10.Controls.Add(Me.chkDelimiterLine)
        Me.GroupBox10.Controls.Add(Me.chkDelimiterCR)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox10.Location = New System.Drawing.Point(2, 59)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(567, 42)
        Me.GroupBox10.TabIndex = 22
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Post Data Delimiter"
        '
        'chkDelimiterTab
        '
        Me.chkDelimiterTab.AutoSize = True
        Me.chkDelimiterTab.Location = New System.Drawing.Point(248, 17)
        Me.chkDelimiterTab.Name = "chkDelimiterTab"
        Me.chkDelimiterTab.Size = New System.Drawing.Size(47, 16)
        Me.chkDelimiterTab.TabIndex = 3
        Me.chkDelimiterTab.Text = "TAB"
        Me.chkDelimiterTab.UseVisualStyleBackColor = True
        '
        'btnGetDelimiter
        '
        Me.btnGetDelimiter.Location = New System.Drawing.Point(457, 13)
        Me.btnGetDelimiter.Name = "btnGetDelimiter"
        Me.btnGetDelimiter.Size = New System.Drawing.Size(107, 23)
        Me.btnGetDelimiter.TabIndex = 20
        Me.btnGetDelimiter.Text = "Get"
        Me.btnGetDelimiter.UseVisualStyleBackColor = True
        '
        'btnSetDelimiter
        '
        Me.btnSetDelimiter.Location = New System.Drawing.Point(346, 13)
        Me.btnSetDelimiter.Name = "btnSetDelimiter"
        Me.btnSetDelimiter.Size = New System.Drawing.Size(107, 23)
        Me.btnSetDelimiter.TabIndex = 8
        Me.btnSetDelimiter.Text = "Set"
        Me.btnSetDelimiter.UseVisualStyleBackColor = True
        '
        'chkDelimiterLine
        '
        Me.chkDelimiterLine.AutoSize = True
        Me.chkDelimiterLine.Location = New System.Drawing.Point(125, 17)
        Me.chkDelimiterLine.Name = "chkDelimiterLine"
        Me.chkDelimiterLine.Size = New System.Drawing.Size(37, 16)
        Me.chkDelimiterLine.TabIndex = 1
        Me.chkDelimiterLine.Text = "LF"
        Me.chkDelimiterLine.UseVisualStyleBackColor = True
        '
        'chkDelimiterCR
        '
        Me.chkDelimiterCR.AutoSize = True
        Me.chkDelimiterCR.Location = New System.Drawing.Point(6, 17)
        Me.chkDelimiterCR.Name = "chkDelimiterCR"
        Me.chkDelimiterCR.Size = New System.Drawing.Size(40, 16)
        Me.chkDelimiterCR.TabIndex = 0
        Me.chkDelimiterCR.Text = "CR"
        Me.chkDelimiterCR.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chkBankEPCASCII)
        Me.GroupBox9.Controls.Add(Me.chkBankUser)
        Me.GroupBox9.Controls.Add(Me.btnGetMemoryBankSelection)
        Me.GroupBox9.Controls.Add(Me.chkBankTID)
        Me.GroupBox9.Controls.Add(Me.btnSetMemoryBankSelection)
        Me.GroupBox9.Controls.Add(Me.chkBankEPC)
        Me.GroupBox9.Controls.Add(Me.chkBankPC)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox9.Location = New System.Drawing.Point(2, 17)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(567, 42)
        Me.GroupBox9.TabIndex = 21
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Memory Bank Selection"
        '
        'chkBankEPCASCII
        '
        Me.chkBankEPCASCII.AutoSize = True
        Me.chkBankEPCASCII.Location = New System.Drawing.Point(248, 16)
        Me.chkBankEPCASCII.Name = "chkBankEPCASCII"
        Me.chkBankEPCASCII.Size = New System.Drawing.Size(86, 16)
        Me.chkBankEPCASCII.TabIndex = 4
        Me.chkBankEPCASCII.Text = "EPC (ASCII)"
        Me.chkBankEPCASCII.UseVisualStyleBackColor = True
        '
        'chkBankUser
        '
        Me.chkBankUser.AutoSize = True
        Me.chkBankUser.Location = New System.Drawing.Point(232, 16)
        Me.chkBankUser.Name = "chkBankUser"
        Me.chkBankUser.Size = New System.Drawing.Size(88, 16)
        Me.chkBankUser.TabIndex = 3
        Me.chkBankUser.Text = "User Memory"
        Me.chkBankUser.UseVisualStyleBackColor = True
        Me.chkBankUser.Visible = False
        '
        'btnGetMemoryBankSelection
        '
        Me.btnGetMemoryBankSelection.Location = New System.Drawing.Point(457, 12)
        Me.btnGetMemoryBankSelection.Name = "btnGetMemoryBankSelection"
        Me.btnGetMemoryBankSelection.Size = New System.Drawing.Size(107, 23)
        Me.btnGetMemoryBankSelection.TabIndex = 19
        Me.btnGetMemoryBankSelection.Text = "Get"
        Me.btnGetMemoryBankSelection.UseVisualStyleBackColor = True
        '
        'chkBankTID
        '
        Me.chkBankTID.AutoSize = True
        Me.chkBankTID.Location = New System.Drawing.Point(160, 16)
        Me.chkBankTID.Name = "chkBankTID"
        Me.chkBankTID.Size = New System.Drawing.Size(43, 16)
        Me.chkBankTID.TabIndex = 2
        Me.chkBankTID.Text = "TID"
        Me.chkBankTID.UseVisualStyleBackColor = True
        '
        'btnSetMemoryBankSelection
        '
        Me.btnSetMemoryBankSelection.Location = New System.Drawing.Point(347, 12)
        Me.btnSetMemoryBankSelection.Name = "btnSetMemoryBankSelection"
        Me.btnSetMemoryBankSelection.Size = New System.Drawing.Size(107, 23)
        Me.btnSetMemoryBankSelection.TabIndex = 12
        Me.btnSetMemoryBankSelection.Text = "Set"
        Me.btnSetMemoryBankSelection.UseVisualStyleBackColor = True
        '
        'chkBankEPC
        '
        Me.chkBankEPC.AutoSize = True
        Me.chkBankEPC.Location = New System.Drawing.Point(79, 16)
        Me.chkBankEPC.Name = "chkBankEPC"
        Me.chkBankEPC.Size = New System.Drawing.Size(45, 16)
        Me.chkBankEPC.TabIndex = 1
        Me.chkBankEPC.Text = "EPC"
        Me.chkBankEPC.UseVisualStyleBackColor = True
        '
        'chkBankPC
        '
        Me.chkBankPC.AutoSize = True
        Me.chkBankPC.Location = New System.Drawing.Point(6, 16)
        Me.chkBankPC.Name = "chkBankPC"
        Me.chkBankPC.Size = New System.Drawing.Size(38, 16)
        Me.chkBankPC.TabIndex = 0
        Me.chkBankPC.Text = "PC"
        Me.chkBankPC.UseVisualStyleBackColor = True
        '
        'tpControl
        '
        Me.tpControl.Controls.Add(Me.gbxBuzzer)
        Me.tpControl.Controls.Add(Me.gbxGPIO)
        Me.tpControl.Location = New System.Drawing.Point(4, 22)
        Me.tpControl.Name = "tpControl"
        Me.tpControl.Padding = New System.Windows.Forms.Padding(3)
        Me.tpControl.Size = New System.Drawing.Size(577, 503)
        Me.tpControl.TabIndex = 0
        Me.tpControl.Text = "Device Control"
        Me.tpControl.UseVisualStyleBackColor = True
        '
        'gbxBuzzer
        '
        Me.gbxBuzzer.Controls.Add(Me.btnGetBuzzerOperationMode)
        Me.gbxBuzzer.Controls.Add(Me.btnSetBuzzerOperationMode)
        Me.gbxBuzzer.Controls.Add(Me.cbxBuzzerOperationMode)
        Me.gbxBuzzer.Controls.Add(Me.Label29)
        Me.gbxBuzzer.Controls.Add(Me.Label25)
        Me.gbxBuzzer.Controls.Add(Me.btnBuzzerControl)
        Me.gbxBuzzer.Controls.Add(Me.cbxBuzzerAction)
        Me.gbxBuzzer.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxBuzzer.Location = New System.Drawing.Point(3, 62)
        Me.gbxBuzzer.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxBuzzer.Name = "gbxBuzzer"
        Me.gbxBuzzer.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxBuzzer.Size = New System.Drawing.Size(571, 78)
        Me.gbxBuzzer.TabIndex = 8
        Me.gbxBuzzer.TabStop = False
        Me.gbxBuzzer.Text = "Buzzer"
        '
        'btnGetBuzzerOperationMode
        '
        Me.btnGetBuzzerOperationMode.Location = New System.Drawing.Point(453, 14)
        Me.btnGetBuzzerOperationMode.Name = "btnGetBuzzerOperationMode"
        Me.btnGetBuzzerOperationMode.Size = New System.Drawing.Size(107, 23)
        Me.btnGetBuzzerOperationMode.TabIndex = 15
        Me.btnGetBuzzerOperationMode.Text = "Get"
        Me.btnGetBuzzerOperationMode.UseVisualStyleBackColor = True
        '
        'btnSetBuzzerOperationMode
        '
        Me.btnSetBuzzerOperationMode.Location = New System.Drawing.Point(337, 14)
        Me.btnSetBuzzerOperationMode.Name = "btnSetBuzzerOperationMode"
        Me.btnSetBuzzerOperationMode.Size = New System.Drawing.Size(107, 23)
        Me.btnSetBuzzerOperationMode.TabIndex = 14
        Me.btnSetBuzzerOperationMode.Text = "Set"
        Me.btnSetBuzzerOperationMode.UseVisualStyleBackColor = True
        '
        'cbxBuzzerOperationMode
        '
        Me.cbxBuzzerOperationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBuzzerOperationMode.FormattingEnabled = True
        Me.cbxBuzzerOperationMode.Items.AddRange(New Object() {"Off", "Once", "Repeat"})
        Me.cbxBuzzerOperationMode.Location = New System.Drawing.Point(102, 16)
        Me.cbxBuzzerOperationMode.Name = "cbxBuzzerOperationMode"
        Me.cbxBuzzerOperationMode.Size = New System.Drawing.Size(229, 20)
        Me.cbxBuzzerOperationMode.TabIndex = 13
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 12)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "Operation Mode : "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(51, 49)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 12)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Action : "
        '
        'btnBuzzerControl
        '
        Me.btnBuzzerControl.Location = New System.Drawing.Point(337, 44)
        Me.btnBuzzerControl.Name = "btnBuzzerControl"
        Me.btnBuzzerControl.Size = New System.Drawing.Size(223, 23)
        Me.btnBuzzerControl.TabIndex = 9
        Me.btnBuzzerControl.Text = "Control Buzzer"
        Me.btnBuzzerControl.UseVisualStyleBackColor = True
        '
        'cbxBuzzerAction
        '
        Me.cbxBuzzerAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBuzzerAction.FormattingEnabled = True
        Me.cbxBuzzerAction.Location = New System.Drawing.Point(102, 46)
        Me.cbxBuzzerAction.Name = "cbxBuzzerAction"
        Me.cbxBuzzerAction.Size = New System.Drawing.Size(229, 20)
        Me.cbxBuzzerAction.TabIndex = 2
        '
        'tpInventory
        '
        Me.tpInventory.Controls.Add(Me.Panel1)
        Me.tpInventory.Controls.Add(Me.gbxInventoryEx)
        Me.tpInventory.Controls.Add(Me.gbxInventory)
        Me.tpInventory.Controls.Add(Me.dgvTagList)
        Me.tpInventory.Location = New System.Drawing.Point(4, 22)
        Me.tpInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.tpInventory.Name = "tpInventory"
        Me.tpInventory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInventory.Size = New System.Drawing.Size(577, 503)
        Me.tpInventory.TabIndex = 2
        Me.tpInventory.Text = "Inventory"
        Me.tpInventory.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lblTotalCount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 390)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(571, 35)
        Me.Panel1.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(471, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.Font = New System.Drawing.Font("PMingLiU", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalCount.Location = New System.Drawing.Point(126, 13)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(12, 12)
        Me.lblTotalCount.TabIndex = 1
        Me.lblTotalCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("PMingLiU", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Tag Count :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbxInventoryEx
        '
        Me.gbxInventoryEx.Controls.Add(Me.chkInventoryExEANUPCEAS)
        Me.gbxInventoryEx.Controls.Add(Me.chkInventoryExEANUPC)
        Me.gbxInventoryEx.Controls.Add(Me.chkInventoryExRAWDATA)
        Me.gbxInventoryEx.Controls.Add(Me.chkInventoryExUDC)
        Me.gbxInventoryEx.Controls.Add(Me.Label34)
        Me.gbxInventoryEx.Controls.Add(Me.btnStopInventoryEx)
        Me.gbxInventoryEx.Controls.Add(Me.btnStartInventoryEx)
        Me.gbxInventoryEx.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxInventoryEx.Location = New System.Drawing.Point(3, 425)
        Me.gbxInventoryEx.Margin = New System.Windows.Forms.Padding(0)
        Me.gbxInventoryEx.Name = "gbxInventoryEx"
        Me.gbxInventoryEx.Size = New System.Drawing.Size(571, 38)
        Me.gbxInventoryEx.TabIndex = 9
        Me.gbxInventoryEx.TabStop = False
        '
        'chkInventoryExEANUPCEAS
        '
        Me.chkInventoryExEANUPCEAS.AutoSize = True
        Me.chkInventoryExEANUPCEAS.Location = New System.Drawing.Point(214, 15)
        Me.chkInventoryExEANUPCEAS.Name = "chkInventoryExEANUPCEAS"
        Me.chkInventoryExEANUPCEAS.Size = New System.Drawing.Size(89, 16)
        Me.chkInventoryExEANUPCEAS.TabIndex = 21
        Me.chkInventoryExEANUPCEAS.Text = "E/U with EAS"
        Me.chkInventoryExEANUPCEAS.UseVisualStyleBackColor = True
        '
        'chkInventoryExEANUPC
        '
        Me.chkInventoryExEANUPC.AutoSize = True
        Me.chkInventoryExEANUPC.Location = New System.Drawing.Point(136, 15)
        Me.chkInventoryExEANUPC.Name = "chkInventoryExEANUPC"
        Me.chkInventoryExEANUPC.Size = New System.Drawing.Size(72, 16)
        Me.chkInventoryExEANUPC.TabIndex = 20
        Me.chkInventoryExEANUPC.Text = "EAN/UPC"
        Me.chkInventoryExEANUPC.UseVisualStyleBackColor = True
        '
        'chkInventoryExRAWDATA
        '
        Me.chkInventoryExRAWDATA.AutoSize = True
        Me.chkInventoryExRAWDATA.Location = New System.Drawing.Point(309, 15)
        Me.chkInventoryExRAWDATA.Name = "chkInventoryExRAWDATA"
        Me.chkInventoryExRAWDATA.Size = New System.Drawing.Size(69, 16)
        Me.chkInventoryExRAWDATA.TabIndex = 19
        Me.chkInventoryExRAWDATA.Text = "Raw Data"
        Me.chkInventoryExRAWDATA.UseVisualStyleBackColor = True
        '
        'chkInventoryExUDC
        '
        Me.chkInventoryExUDC.AutoSize = True
        Me.chkInventoryExUDC.Location = New System.Drawing.Point(82, 15)
        Me.chkInventoryExUDC.Name = "chkInventoryExUDC"
        Me.chkInventoryExUDC.Size = New System.Drawing.Size(48, 16)
        Me.chkInventoryExUDC.TabIndex = 18
        Me.chkInventoryExUDC.Text = "UDC"
        Me.chkInventoryExUDC.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(2, 16)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 12)
        Me.Label34.TabIndex = 7
        Me.Label34.Text = "Inventory Ex : "
        '
        'btnStopInventoryEx
        '
        Me.btnStopInventoryEx.Location = New System.Drawing.Point(471, 11)
        Me.btnStopInventoryEx.Name = "btnStopInventoryEx"
        Me.btnStopInventoryEx.Size = New System.Drawing.Size(84, 23)
        Me.btnStopInventoryEx.TabIndex = 4
        Me.btnStopInventoryEx.TabStop = False
        Me.btnStopInventoryEx.Text = "Stop"
        Me.btnStopInventoryEx.UseVisualStyleBackColor = True
        '
        'btnStartInventoryEx
        '
        Me.btnStartInventoryEx.Location = New System.Drawing.Point(384, 11)
        Me.btnStartInventoryEx.Name = "btnStartInventoryEx"
        Me.btnStartInventoryEx.Size = New System.Drawing.Size(81, 23)
        Me.btnStartInventoryEx.TabIndex = 3
        Me.btnStartInventoryEx.TabStop = False
        Me.btnStartInventoryEx.Text = "Start"
        Me.btnStartInventoryEx.UseVisualStyleBackColor = True
        '
        'gbxInventory
        '
        Me.gbxInventory.Controls.Add(Me.cbxInventory)
        Me.gbxInventory.Controls.Add(Me.Label27)
        Me.gbxInventory.Controls.Add(Me.btnStopInventory)
        Me.gbxInventory.Controls.Add(Me.btnStartInventory)
        Me.gbxInventory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbxInventory.Location = New System.Drawing.Point(3, 463)
        Me.gbxInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.gbxInventory.Name = "gbxInventory"
        Me.gbxInventory.Padding = New System.Windows.Forms.Padding(0)
        Me.gbxInventory.Size = New System.Drawing.Size(571, 37)
        Me.gbxInventory.TabIndex = 6
        Me.gbxInventory.TabStop = False
        '
        'cbxInventory
        '
        Me.cbxInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxInventory.FormattingEnabled = True
        Me.cbxInventory.Location = New System.Drawing.Point(82, 12)
        Me.cbxInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxInventory.Name = "cbxInventory"
        Me.cbxInventory.Size = New System.Drawing.Size(296, 20)
        Me.cbxInventory.TabIndex = 8
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(18, 15)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 12)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Inventory : "
        '
        'btnStopInventory
        '
        Me.btnStopInventory.Location = New System.Drawing.Point(471, 10)
        Me.btnStopInventory.Name = "btnStopInventory"
        Me.btnStopInventory.Size = New System.Drawing.Size(83, 23)
        Me.btnStopInventory.TabIndex = 4
        Me.btnStopInventory.TabStop = False
        Me.btnStopInventory.Text = "Stop"
        Me.btnStopInventory.UseVisualStyleBackColor = True
        '
        'btnStartInventory
        '
        Me.btnStartInventory.Location = New System.Drawing.Point(384, 10)
        Me.btnStartInventory.Name = "btnStartInventory"
        Me.btnStartInventory.Size = New System.Drawing.Size(81, 23)
        Me.btnStartInventory.TabIndex = 3
        Me.btnStartInventory.TabStop = False
        Me.btnStartInventory.Text = "Start"
        Me.btnStartInventory.UseVisualStyleBackColor = True
        '
        'dgvTagList
        '
        Me.dgvTagList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTagList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnEPC, Me.clnTID, Me.clnCount})
        Me.dgvTagList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTagList.Location = New System.Drawing.Point(3, 3)
        Me.dgvTagList.MultiSelect = False
        Me.dgvTagList.Name = "dgvTagList"
        Me.dgvTagList.ReadOnly = True
        Me.dgvTagList.RowTemplate.Height = 24
        Me.dgvTagList.Size = New System.Drawing.Size(571, 497)
        Me.dgvTagList.TabIndex = 7
        '
        'clnEPC
        '
        Me.clnEPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnEPC.FillWeight = 40.0!
        Me.clnEPC.HeaderText = "EPC"
        Me.clnEPC.Name = "clnEPC"
        Me.clnEPC.ReadOnly = True
        '
        'clnTID
        '
        Me.clnTID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnTID.FillWeight = 50.0!
        Me.clnTID.HeaderText = "TID"
        Me.clnTID.Name = "clnTID"
        Me.clnTID.ReadOnly = True
        '
        'clnCount
        '
        Me.clnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clnCount.FillWeight = 10.0!
        Me.clnCount.HeaderText = "Count"
        Me.clnCount.Name = "clnCount"
        Me.clnCount.ReadOnly = True
        '
        'tpReadWriteTag
        '
        Me.tpReadWriteTag.Controls.Add(Me.gbEPCWrite)
        Me.tpReadWriteTag.Controls.Add(Me.gbWrite)
        Me.tpReadWriteTag.Controls.Add(Me.gbRead)
        Me.tpReadWriteTag.Location = New System.Drawing.Point(4, 22)
        Me.tpReadWriteTag.Name = "tpReadWriteTag"
        Me.tpReadWriteTag.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReadWriteTag.Size = New System.Drawing.Size(577, 503)
        Me.tpReadWriteTag.TabIndex = 1
        Me.tpReadWriteTag.Text = "Read/Write Tag"
        Me.tpReadWriteTag.UseVisualStyleBackColor = True
        '
        'gbEPCWrite
        '
        Me.gbEPCWrite.Controls.Add(Me.Label36)
        Me.gbEPCWrite.Controls.Add(Me.tbTargetPCEPC)
        Me.gbEPCWrite.Controls.Add(Me.Label22)
        Me.gbEPCWrite.Controls.Add(Me.Label21)
        Me.gbEPCWrite.Controls.Add(Me.tbEPCWriteHexString)
        Me.gbEPCWrite.Controls.Add(Me.Label19)
        Me.gbEPCWrite.Controls.Add(Me.Label20)
        Me.gbEPCWrite.Controls.Add(Me.tbEPCWritePassword)
        Me.gbEPCWrite.Controls.Add(Me.btnWriteEPC)
        Me.gbEPCWrite.ForeColor = System.Drawing.Color.Green
        Me.gbEPCWrite.Location = New System.Drawing.Point(24, 335)
        Me.gbEPCWrite.Margin = New System.Windows.Forms.Padding(2)
        Me.gbEPCWrite.Name = "gbEPCWrite"
        Me.gbEPCWrite.Padding = New System.Windows.Forms.Padding(2)
        Me.gbEPCWrite.Size = New System.Drawing.Size(530, 121)
        Me.gbEPCWrite.TabIndex = 21
        Me.gbEPCWrite.TabStop = False
        Me.gbEPCWrite.Text = "Tag EPC Write"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(44, 43)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(73, 12)
        Me.Label36.TabIndex = 31
        Me.Label36.Text = "Target PCEPC"
        '
        'tbTargetPCEPC
        '
        Me.tbTargetPCEPC.Location = New System.Drawing.Point(124, 40)
        Me.tbTargetPCEPC.Name = "tbTargetPCEPC"
        Me.tbTargetPCEPC.Size = New System.Drawing.Size(389, 22)
        Me.tbTargetPCEPC.TabIndex = 30
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(122, 99)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(198, 12)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Length: 1 Word = 2 Bytes = 4 Hex String"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(33, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 12)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "EPC (HexString)"
        '
        'tbEPCWriteHexString
        '
        Me.tbEPCWriteHexString.Location = New System.Drawing.Point(124, 67)
        Me.tbEPCWriteHexString.Name = "tbEPCWriteHexString"
        Me.tbEPCWriteHexString.Size = New System.Drawing.Size(389, 22)
        Me.tbEPCWriteHexString.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(357, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(147, 12)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "00000000 is default password."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(35, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 12)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Access Password"
        '
        'tbEPCWritePassword
        '
        Me.tbEPCWritePassword.Location = New System.Drawing.Point(124, 14)
        Me.tbEPCWritePassword.MaxLength = 8
        Me.tbEPCWritePassword.Name = "tbEPCWritePassword"
        Me.tbEPCWritePassword.Size = New System.Drawing.Size(121, 22)
        Me.tbEPCWritePassword.TabIndex = 26
        Me.tbEPCWritePassword.Text = "00000000"
        '
        'btnWriteEPC
        '
        Me.btnWriteEPC.Location = New System.Drawing.Point(406, 94)
        Me.btnWriteEPC.Name = "btnWriteEPC"
        Me.btnWriteEPC.Size = New System.Drawing.Size(107, 23)
        Me.btnWriteEPC.TabIndex = 0
        Me.btnWriteEPC.Text = "Write EPC"
        Me.btnWriteEPC.UseVisualStyleBackColor = True
        '
        'gbWrite
        '
        Me.gbWrite.Controls.Add(Me.Label18)
        Me.gbWrite.Controls.Add(Me.lblEPCHint2)
        Me.gbWrite.Controls.Add(Me.lblEPCHint1)
        Me.gbWrite.Controls.Add(Me.Label17)
        Me.gbWrite.Controls.Add(Me.Label11)
        Me.gbWrite.Controls.Add(Me.Label14)
        Me.gbWrite.Controls.Add(Me.Label15)
        Me.gbWrite.Controls.Add(Me.cbxWriteMemoryBank)
        Me.gbWrite.Controls.Add(Me.nudWriteStart)
        Me.gbWrite.Controls.Add(Me.tbWritePassword)
        Me.gbWrite.Controls.Add(Me.Label13)
        Me.gbWrite.Controls.Add(Me.btnWrite)
        Me.gbWrite.Controls.Add(Me.tbWriteData)
        Me.gbWrite.Location = New System.Drawing.Point(24, 181)
        Me.gbWrite.Name = "gbWrite"
        Me.gbWrite.Size = New System.Drawing.Size(530, 149)
        Me.gbWrite.TabIndex = 20
        Me.gbWrite.TabStop = False
        Me.gbWrite.Text = "Write"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(122, 126)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(198, 12)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Length: 1 Word = 2 Bytes = 4 Hex String"
        '
        'lblEPCHint2
        '
        Me.lblEPCHint2.AutoSize = True
        Me.lblEPCHint2.ForeColor = System.Drawing.Color.Red
        Me.lblEPCHint2.Location = New System.Drawing.Point(302, 78)
        Me.lblEPCHint2.Name = "lblEPCHint2"
        Me.lblEPCHint2.Size = New System.Drawing.Size(202, 12)
        Me.lblEPCHint2.TabIndex = 26
        Me.lblEPCHint2.Text = "Position 1 is PC (only 5 bit can be written)"
        '
        'lblEPCHint1
        '
        Me.lblEPCHint1.AutoSize = True
        Me.lblEPCHint1.ForeColor = System.Drawing.Color.Red
        Me.lblEPCHint1.Location = New System.Drawing.Point(335, 66)
        Me.lblEPCHint1.Name = "lblEPCHint1"
        Me.lblEPCHint1.Size = New System.Drawing.Size(169, 12)
        Me.lblEPCHint1.TabIndex = 25
        Me.lblEPCHint1.Text = "Position 0 is CRC (can't be written)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(358, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 12)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "00000000 is default password."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 12)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Access Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 12)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Start Word Position"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(46, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 12)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Memory Bank"
        '
        'cbxWriteMemoryBank
        '
        Me.cbxWriteMemoryBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWriteMemoryBank.FormattingEnabled = True
        Me.cbxWriteMemoryBank.Location = New System.Drawing.Point(125, 40)
        Me.cbxWriteMemoryBank.Name = "cbxWriteMemoryBank"
        Me.cbxWriteMemoryBank.Size = New System.Drawing.Size(121, 20)
        Me.cbxWriteMemoryBank.TabIndex = 22
        '
        'nudWriteStart
        '
        Me.nudWriteStart.Location = New System.Drawing.Point(124, 66)
        Me.nudWriteStart.Name = "nudWriteStart"
        Me.nudWriteStart.Size = New System.Drawing.Size(122, 22)
        Me.nudWriteStart.TabIndex = 24
        Me.nudWriteStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbWritePassword
        '
        Me.tbWritePassword.Location = New System.Drawing.Point(125, 12)
        Me.tbWritePassword.MaxLength = 8
        Me.tbWritePassword.Name = "tbWritePassword"
        Me.tbWritePassword.Size = New System.Drawing.Size(121, 22)
        Me.tbWritePassword.TabIndex = 23
        Me.tbWritePassword.Text = "00000000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 12)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Write Data (HexString)"
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(406, 121)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(107, 23)
        Me.btnWrite.TabIndex = 6
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'tbWriteData
        '
        Me.tbWriteData.Location = New System.Drawing.Point(124, 93)
        Me.tbWriteData.Name = "tbWriteData"
        Me.tbWriteData.Size = New System.Drawing.Size(389, 22)
        Me.tbWriteData.TabIndex = 15
        '
        'gbRead
        '
        Me.gbRead.Controls.Add(Me.Label16)
        Me.gbRead.Controls.Add(Me.tbReadResult)
        Me.gbRead.Controls.Add(Me.Label10)
        Me.gbRead.Controls.Add(Me.Label7)
        Me.gbRead.Controls.Add(Me.Label12)
        Me.gbRead.Controls.Add(Me.Label8)
        Me.gbRead.Controls.Add(Me.Label9)
        Me.gbRead.Controls.Add(Me.cbxReadMemoryBank)
        Me.gbRead.Controls.Add(Me.nudReadStart)
        Me.gbRead.Controls.Add(Me.btnRead)
        Me.gbRead.Controls.Add(Me.nudReadLength)
        Me.gbRead.Controls.Add(Me.tbReadPassword)
        Me.gbRead.Location = New System.Drawing.Point(24, 8)
        Me.gbRead.Name = "gbRead"
        Me.gbRead.Size = New System.Drawing.Size(530, 168)
        Me.gbRead.TabIndex = 19
        Me.gbRead.TabStop = False
        Me.gbRead.Text = "Read"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(358, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 12)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "00000000 is default password."
        '
        'tbReadResult
        '
        Me.tbReadResult.Location = New System.Drawing.Point(94, 122)
        Me.tbReadResult.Multiline = True
        Me.tbReadResult.Name = "tbReadResult"
        Me.tbReadResult.Size = New System.Drawing.Size(419, 38)
        Me.tbReadResult.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 12)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Access Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 12)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Start Word Position"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 12)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Read Result"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 12)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Reading Word Length"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 12)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Memory Bank"
        '
        'cbxReadMemoryBank
        '
        Me.cbxReadMemoryBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReadMemoryBank.FormattingEnabled = True
        Me.cbxReadMemoryBank.Location = New System.Drawing.Point(125, 40)
        Me.cbxReadMemoryBank.Name = "cbxReadMemoryBank"
        Me.cbxReadMemoryBank.Size = New System.Drawing.Size(121, 20)
        Me.cbxReadMemoryBank.TabIndex = 11
        '
        'nudReadStart
        '
        Me.nudReadStart.Location = New System.Drawing.Point(127, 66)
        Me.nudReadStart.Name = "nudReadStart"
        Me.nudReadStart.Size = New System.Drawing.Size(120, 22)
        Me.nudReadStart.TabIndex = 14
        Me.nudReadStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(407, 96)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(107, 23)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'nudReadLength
        '
        Me.nudReadLength.Location = New System.Drawing.Point(127, 94)
        Me.nudReadLength.Name = "nudReadLength"
        Me.nudReadLength.Size = New System.Drawing.Size(120, 22)
        Me.nudReadLength.TabIndex = 12
        Me.nudReadLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbReadPassword
        '
        Me.tbReadPassword.Location = New System.Drawing.Point(125, 12)
        Me.tbReadPassword.MaxLength = 8
        Me.tbReadPassword.Name = "tbReadPassword"
        Me.tbReadPassword.Size = New System.Drawing.Size(121, 22)
        Me.tbReadPassword.TabIndex = 13
        Me.tbReadPassword.Text = "00000000"
        '
        'tpLockKillTag
        '
        Me.tpLockKillTag.Controls.Add(Me.GroupBox7)
        Me.tpLockKillTag.Controls.Add(Me.GroupBox6)
        Me.tpLockKillTag.Location = New System.Drawing.Point(4, 22)
        Me.tpLockKillTag.Name = "tpLockKillTag"
        Me.tpLockKillTag.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLockKillTag.Size = New System.Drawing.Size(577, 503)
        Me.tpLockKillTag.TabIndex = 5
        Me.tpLockKillTag.Text = "Lock/Kill Tag"
        Me.tpLockKillTag.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.tbKillPassword)
        Me.GroupBox7.Controls.Add(Me.btnKillTag)
        Me.GroupBox7.Controls.Add(Me.Label46)
        Me.GroupBox7.Controls.Add(Me.tbKillAccessPassword)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 86)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(565, 89)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Kill"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(7, 68)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(515, 12)
        Me.Label39.TabIndex = 30
        Me.Label39.Text = "Cannot work successful when the kill password is default as 00000000. Need to cha" &
    "nge the kill password first."
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(27, 46)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(68, 12)
        Me.Label43.TabIndex = 28
        Me.Label43.Text = "Kill Password"
        '
        'tbKillPassword
        '
        Me.tbKillPassword.Location = New System.Drawing.Point(102, 43)
        Me.tbKillPassword.MaxLength = 8
        Me.tbKillPassword.Name = "tbKillPassword"
        Me.tbKillPassword.Size = New System.Drawing.Size(121, 22)
        Me.tbKillPassword.TabIndex = 29
        Me.tbKillPassword.Text = "00000000"
        '
        'btnKillTag
        '
        Me.btnKillTag.Location = New System.Drawing.Point(452, 41)
        Me.btnKillTag.Name = "btnKillTag"
        Me.btnKillTag.Size = New System.Drawing.Size(107, 23)
        Me.btnKillTag.TabIndex = 27
        Me.btnKillTag.Text = "Execute"
        Me.btnKillTag.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(13, 18)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(82, 12)
        Me.Label46.TabIndex = 20
        Me.Label46.Text = "Access Password"
        '
        'tbKillAccessPassword
        '
        Me.tbKillAccessPassword.Location = New System.Drawing.Point(102, 15)
        Me.tbKillAccessPassword.MaxLength = 8
        Me.tbKillAccessPassword.Name = "tbKillAccessPassword"
        Me.tbKillAccessPassword.Size = New System.Drawing.Size(121, 22)
        Me.tbKillAccessPassword.TabIndex = 21
        Me.tbKillAccessPassword.Text = "00000000"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnLockTag)
        Me.GroupBox6.Controls.Add(Me.Label42)
        Me.GroupBox6.Controls.Add(Me.cbxLockAction)
        Me.GroupBox6.Controls.Add(Me.Label41)
        Me.GroupBox6.Controls.Add(Me.cbxLockBank)
        Me.GroupBox6.Controls.Add(Me.Label40)
        Me.GroupBox6.Controls.Add(Me.tbLockAccessPassword)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(565, 74)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Lock"
        '
        'btnLockTag
        '
        Me.btnLockTag.Location = New System.Drawing.Point(452, 42)
        Me.btnLockTag.Name = "btnLockTag"
        Me.btnLockTag.Size = New System.Drawing.Size(107, 23)
        Me.btnLockTag.TabIndex = 27
        Me.btnLockTag.Text = "Execute"
        Me.btnLockTag.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(250, 47)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(63, 12)
        Me.Label42.TabIndex = 25
        Me.Label42.Text = "Lock Action"
        '
        'cbxLockAction
        '
        Me.cbxLockAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLockAction.FormattingEnabled = True
        Me.cbxLockAction.Location = New System.Drawing.Point(319, 44)
        Me.cbxLockAction.Name = "cbxLockAction"
        Me.cbxLockAction.Size = New System.Drawing.Size(121, 20)
        Me.cbxLockAction.TabIndex = 26
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(22, 47)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(73, 12)
        Me.Label41.TabIndex = 23
        Me.Label41.Text = "Memory Bank"
        '
        'cbxLockBank
        '
        Me.cbxLockBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLockBank.FormattingEnabled = True
        Me.cbxLockBank.Location = New System.Drawing.Point(101, 44)
        Me.cbxLockBank.Name = "cbxLockBank"
        Me.cbxLockBank.Size = New System.Drawing.Size(121, 20)
        Me.cbxLockBank.TabIndex = 24
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(13, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(82, 12)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "Access Password"
        '
        'tbLockAccessPassword
        '
        Me.tbLockAccessPassword.Location = New System.Drawing.Point(102, 15)
        Me.tbLockAccessPassword.MaxLength = 8
        Me.tbLockAccessPassword.Name = "tbLockAccessPassword"
        Me.tbLockAccessPassword.Size = New System.Drawing.Size(121, 22)
        Me.tbLockAccessPassword.TabIndex = 21
        Me.tbLockAccessPassword.Text = "00000000"
        '
        'tpBLE
        '
        Me.tpBLE.Controls.Add(Me.lblBLEROMVersion)
        Me.tpBLE.Controls.Add(Me.btnGetBLEName)
        Me.tpBLE.Controls.Add(Me.btnSetBLEName)
        Me.tpBLE.Controls.Add(Me.tbBLEDeviceName)
        Me.tpBLE.Controls.Add(Me.Label48)
        Me.tpBLE.Controls.Add(Me.Label47)
        Me.tpBLE.Location = New System.Drawing.Point(4, 22)
        Me.tpBLE.Name = "tpBLE"
        Me.tpBLE.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBLE.Size = New System.Drawing.Size(577, 503)
        Me.tpBLE.TabIndex = 6
        Me.tpBLE.Text = "BluetoothLE"
        Me.tpBLE.UseVisualStyleBackColor = True
        '
        'lblBLEROMVersion
        '
        Me.lblBLEROMVersion.AutoSize = True
        Me.lblBLEROMVersion.Location = New System.Drawing.Point(154, 13)
        Me.lblBLEROMVersion.Name = "lblBLEROMVersion"
        Me.lblBLEROMVersion.Size = New System.Drawing.Size(145, 12)
        Me.lblBLEROMVersion.TabIndex = 23
        Me.lblBLEROMVersion.Text = "Do Not Support Bluetooth LE"
        '
        'btnGetBLEName
        '
        Me.btnGetBLEName.Location = New System.Drawing.Point(464, 41)
        Me.btnGetBLEName.Name = "btnGetBLEName"
        Me.btnGetBLEName.Size = New System.Drawing.Size(107, 23)
        Me.btnGetBLEName.TabIndex = 22
        Me.btnGetBLEName.Text = "Get"
        Me.btnGetBLEName.UseVisualStyleBackColor = True
        '
        'btnSetBLEName
        '
        Me.btnSetBLEName.Location = New System.Drawing.Point(351, 41)
        Me.btnSetBLEName.Name = "btnSetBLEName"
        Me.btnSetBLEName.Size = New System.Drawing.Size(107, 23)
        Me.btnSetBLEName.TabIndex = 21
        Me.btnSetBLEName.Text = "Set"
        Me.btnSetBLEName.UseVisualStyleBackColor = True
        '
        'tbBLEDeviceName
        '
        Me.tbBLEDeviceName.Location = New System.Drawing.Point(151, 41)
        Me.tbBLEDeviceName.Name = "tbBLEDeviceName"
        Me.tbBLEDeviceName.Size = New System.Drawing.Size(193, 22)
        Me.tbBLEDeviceName.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(9, 13)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(139, 12)
        Me.Label48.TabIndex = 1
        Me.Label48.Text = "Bluetooth LE ROM Version:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(9, 46)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(136, 12)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Bluetooth LE Device Name:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label23.Location = New System.Drawing.Point(5, 5)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(142, 12)
        Me.Label23.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Location = New System.Drawing.Point(147, 5)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 12)
        Me.Label24.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label45.Location = New System.Drawing.Point(5, 5)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(136, 12)
        Me.Label45.TabIndex = 0
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Location = New System.Drawing.Point(141, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(25, 12)
        Me.Label30.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'frmTS100Sample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 652)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.pnlConnect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmTS100Sample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TS100 Sample"
        Me.pnlConnect.ResumeLayout(False)
        Me.pnlConnect.PerformLayout()
        Me.gbxGPIO.ResumeLayout(False)
        Me.gbxGPIO.PerformLayout()
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
        Me.tpDeviceSettings.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.gbxEventType.ResumeLayout(False)
        Me.gbxEventType.PerformLayout()
        Me.gbxEPCSettings.ResumeLayout(False)
        Me.gbxEPCSettings.PerformLayout()
        Me.gbxScanMode.ResumeLayout(False)
        Me.gbxCommandTriggerState.ResumeLayout(False)
        Me.gbxTrigger.ResumeLayout(False)
        Me.gbxTrigger.PerformLayout()
        Me.gbxFilter.ResumeLayout(False)
        Me.gbxFilter.PerformLayout()
        Me.gbxInterface.ResumeLayout(False)
        Me.gbxInterface.PerformLayout()
        Me.gbxBinaryOutput.ResumeLayout(False)
        Me.gbxBinaryOutput.PerformLayout()
        Me.gbxOutputFormat.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.tpControl.ResumeLayout(False)
        Me.gbxBuzzer.ResumeLayout(False)
        Me.gbxBuzzer.PerformLayout()
        Me.tpInventory.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbxInventoryEx.ResumeLayout(False)
        Me.gbxInventoryEx.PerformLayout()
        Me.gbxInventory.ResumeLayout(False)
        Me.gbxInventory.PerformLayout()
        CType(Me.dgvTagList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReadWriteTag.ResumeLayout(False)
        Me.gbEPCWrite.ResumeLayout(False)
        Me.gbEPCWrite.PerformLayout()
        Me.gbWrite.ResumeLayout(False)
        Me.gbWrite.PerformLayout()
        CType(Me.nudWriteStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRead.ResumeLayout(False)
        Me.gbRead.PerformLayout()
        CType(Me.nudReadStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudReadLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLockKillTag.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tpBLE.ResumeLayout(False)
        Me.tpBLE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlConnect As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbxBaudrate As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnWifiSetting As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cbRightLight As System.Windows.Forms.CheckBox
    Friend WithEvents cbMidLight As System.Windows.Forms.CheckBox
    Friend WithEvents cbLeftLight As System.Windows.Forms.CheckBox
    Friend WithEvents btnGetIO_State As System.Windows.Forms.Button
    Friend WithEvents gbxGPIO As System.Windows.Forms.GroupBox
    Friend WithEvents lblInputState As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tpControl As System.Windows.Forms.TabPage
    Friend WithEvents tpReadWriteTag As System.Windows.Forms.TabPage
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxReadMemoryBank As System.Windows.Forms.ComboBox
    Friend WithEvents tbReadPassword As System.Windows.Forms.TextBox
    Friend WithEvents nudReadLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudReadStart As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbWriteData As System.Windows.Forms.TextBox
    Friend WithEvents gbWrite As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbxWriteMemoryBank As System.Windows.Forms.ComboBox
    Friend WithEvents nudWriteStart As System.Windows.Forms.NumericUpDown
    Friend WithEvents tbWritePassword As System.Windows.Forms.TextBox
    Friend WithEvents gbRead As System.Windows.Forms.GroupBox
    Friend WithEvents tbReadResult As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblEPCHint2 As System.Windows.Forms.Label
    Friend WithEvents lblEPCHint1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tpInventory As System.Windows.Forms.TabPage
    Friend WithEvents dgvTagList As System.Windows.Forms.DataGridView
    Friend WithEvents gbxInventory As System.Windows.Forms.GroupBox
    Friend WithEvents btnStopInventory As System.Windows.Forms.Button
    Friend WithEvents btnStartInventory As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTotalCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbxBuzzer As System.Windows.Forms.GroupBox
    Friend WithEvents gbEPCWrite As System.Windows.Forms.GroupBox
    Friend WithEvents btnWriteEPC As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbEPCWritePassword As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tbEPCWriteHexString As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbxBuzzerAction As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuzzerControl As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbxInventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents clnEPC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnTID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpPerformance As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetRfPower As System.Windows.Forms.Button
    Friend WithEvents tbRfPower As System.Windows.Forms.TrackBar
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblRfPower As System.Windows.Forms.Label
    Friend WithEvents gbFrequency As System.Windows.Forms.GroupBox
    Friend WithEvents gbJapanFrequency As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSetFrequency As System.Windows.Forms.Button
    Friend WithEvents gbTaiwanFrequency As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cb923_2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb923_0 As System.Windows.Forms.CheckBox
    Friend WithEvents cb922_8 As System.Windows.Forms.CheckBox
    Friend WithEvents cb922_6 As System.Windows.Forms.CheckBox
    Friend WithEvents cb922_4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb922_2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb922_0 As System.Windows.Forms.CheckBox
    Friend WithEvents cb921_8 As System.Windows.Forms.CheckBox
    Friend WithEvents cb921_6 As System.Windows.Forms.CheckBox
    Friend WithEvents cb921_4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb921_2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb921_0 As System.Windows.Forms.CheckBox
    Friend WithEvents cb920_8 As System.Windows.Forms.CheckBox
    Friend WithEvents cb920_6 As System.Windows.Forms.CheckBox
    Friend WithEvents cb920_4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb919_2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb918_0 As System.Windows.Forms.CheckBox
    Friend WithEvents cb916_8 As System.Windows.Forms.CheckBox
    Friend WithEvents cb920_25 As System.Windows.Forms.CheckBox
    Friend WithEvents cb922_25 As System.Windows.Forms.CheckBox
    Friend WithEvents btnSetBuzzerOperationMode As System.Windows.Forms.Button
    Friend WithEvents cbxBuzzerOperationMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblRomVersion As Label
    Friend WithEvents lblSdkVersion As Label
    Friend WithEvents tpDeviceSettings As TabPage
    Friend WithEvents gbxTrigger As GroupBox
    Friend WithEvents gbxFilter As GroupBox
    Friend WithEvents btnSetFilter As Button
    Friend WithEvents gbxInterface As GroupBox
    Friend WithEvents gbxOutputFormat As GroupBox
    Friend WithEvents btnSetDelimiter As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSetRfSensitivity As Button
    Friend WithEvents tbRfSensitivity As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRfSensitivity As Label
    Friend WithEvents gbxEPCSettings As GroupBox
    Friend WithEvents btnSetQValue As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents cbxSession As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents cbxTarget As ComboBox
    Friend WithEvents btnSetSessionTarget As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents cbxQValue As ComboBox
    Friend WithEvents chkEanUpc As CheckBox
    Friend WithEvents chkRawData As CheckBox
    Friend WithEvents chkUdc As CheckBox
    Friend WithEvents chkEanUpcEas As CheckBox
    Friend WithEvents btnSetOutputInterface As Button
    Friend WithEvents chkTCPServer As CheckBox
    Friend WithEvents chkTCPClient As CheckBox
    Friend WithEvents chkBLE As CheckBox
    Friend WithEvents chkHIDVCom As CheckBox
    Friend WithEvents gbxEventType As GroupBox
    Friend WithEvents btnSetEventType As Button
    Friend WithEvents cbxEventType As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnSetMemoryBankSelection As Button
    Friend WithEvents cbxKeyboardSimulation As ComboBox
    Friend WithEvents lblSingleOutput As Label
    Friend WithEvents gbxBinaryOutput As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSetTagPresentRepeatInterval As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSetRemoveThreshold As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents gbxInventoryEx As GroupBox
    Friend WithEvents Label34 As Label
    Friend WithEvents btnStopInventoryEx As Button
    Friend WithEvents btnStartInventoryEx As Button
    Friend WithEvents chkInventoryExEANUPCEAS As CheckBox
    Friend WithEvents chkInventoryExEANUPC As CheckBox
    Friend WithEvents chkInventoryExRAWDATA As CheckBox
    Friend WithEvents chkInventoryExUDC As CheckBox
    Friend WithEvents Label36 As Label
    Friend WithEvents tbTargetPCEPC As TextBox
    Friend WithEvents nudTagRemoveThreshold As NumericUpDown
    Friend WithEvents nudTagPresentRepeatInterval As NumericUpDown
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents nudInventoryRoundInterval As NumericUpDown
    Friend WithEvents btnSetInvnetoryRoundInterval As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents tpLockKillTag As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label40 As Label
    Friend WithEvents tbLockAccessPassword As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents cbxLockBank As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents cbxLockAction As ComboBox
    Friend WithEvents btnLockTag As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnKillTag As Button
    Friend WithEvents Label46 As Label
    Friend WithEvents tbKillAccessPassword As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents tbKillPassword As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btnSetActiveMode As Button
    Friend WithEvents cbxActiveMode As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents btnGetRfPower As Button
    Friend WithEvents btnGetRfSensitivity As Button
    Friend WithEvents btnGetTagPresentRepeatInterval As Button
    Friend WithEvents btnGetRemoveThreshold As Button
    Friend WithEvents btnGetInvnetoryRoundInterval As Button
    Friend WithEvents btnGetFrequency As Button
    Friend WithEvents btnGetMemoryBankSelection As Button
    Friend WithEvents btnGetDelimiter As Button
    Friend WithEvents btnGetOutputInterface As Button
    Friend WithEvents btnGetFilter As Button
    Friend WithEvents btnGetSessionTarget As Button
    Friend WithEvents btnGetQValue As Button
    Friend WithEvents btnGetActiveMode As Button
    Friend WithEvents btnGetEventType As Button
    Friend WithEvents btnGetBuzzerOperationMode As Button
    Friend WithEvents chkSensor As CheckBox
    Friend WithEvents chkDigitalInput As CheckBox
    Friend WithEvents chkCommand As CheckBox
    Friend WithEvents btnGetTriggerType As Button
    Friend WithEvents btnSetTriggerType As Button
    Friend WithEvents gbxCommandTriggerState As GroupBox
    Friend WithEvents btnGetCommandTriggerState As Button
    Friend WithEvents btnSetCommandTriggerState As Button
    Friend WithEvents cbxCommandTriggerState As ComboBox
    Friend WithEvents gbxScanMode As GroupBox
    Friend WithEvents btnGetScanMode As Button
    Friend WithEvents btnSetScanMode As Button
    Friend WithEvents cbxScanMode As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents chkDelimiterTab As CheckBox
    Friend WithEvents chkDelimiterLine As CheckBox
    Friend WithEvents chkDelimiterCR As CheckBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents chkBankEPCASCII As CheckBox
    Friend WithEvents chkBankUser As CheckBox
    Friend WithEvents chkBankTID As CheckBox
    Friend WithEvents chkBankEPC As CheckBox
    Friend WithEvents chkBankPC As CheckBox
    Friend WithEvents tpBLE As TabPage
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnGetBLEName As Button
    Friend WithEvents btnSetBLEName As Button
    Friend WithEvents tbBLEDeviceName As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents lblBLEROMVersion As Label
    Friend WithEvents GroupBoxRxDecode As GroupBox
    Friend WithEvents cbxRxDecode As ComboBox
    Friend WithEvents Label49 As Label
    Friend WithEvents btnGetRxDecode As Button
    Friend WithEvents btnSetRxDecode As Button
    Friend WithEvents GroupBoxLinkFrequency As GroupBox
    Friend WithEvents btnGetLinkFrequency As Button
    Friend WithEvents cbxLinkFrequency As ComboBox
    Friend WithEvents btnSetLinkFrequency As Button
    Friend WithEvents Label50 As Label
End Class
