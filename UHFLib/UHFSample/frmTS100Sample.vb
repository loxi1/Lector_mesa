Imports System.IO
Imports com.gigatms
Imports com.gigatms.Parameters

Public Class frmTS100Sample
    Private Const TIME_OUT As Integer = 3
    Private Const RETRY_TIMES As Integer = 3

    Private WithEvents _host As Host
    Private WithEvents _ts100 As TS100 = Nothing

    Private _settingsList As New List(Of String)
    Private _title As String = My.Application.Info.Title
    Private _tagList As List(Of String)
    Private _FrequencyItems As List(Of CheckBox)

    Private Sub frmInitial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "TS100 Sample" & " V" &
                    My.Application.Info.Version.Major & "." &
                    My.Application.Info.Version.Minor & "R" &
                    My.Application.Info.Version.Revision

        _host = New Host()
        _ts100 = New TS100(TIME_OUT, RETRY_TIMES)
        lblSdkVersion.Text = "SDK Version: " & _ts100.SdkVersion
        RefreshPortList(GetSetting(_title, "Comm", "LastCommPort", "Auto"))
        _tagList = New List(Of String)

        With cbxBaudrate.Items
            .Clear()
            .Add("AUTO")
            .Add("115200")
            .Add("57600")
            .Add("38400")
            .Add("19200")
            .Add("9600")
            .Add("4800")
            .Add("2400")
        End With
        cbxBaudrate.SelectedIndex = 0   'default settting to select auto        

        With cbxRxDecode.Items
            .Clear()
            .Add(New ComboBoxItem(RxDecodeType.FM0, "FM0"))
            .Add(New ComboBoxItem(RxDecodeType.Miller_2, "Miller_2"))
            .Add(New ComboBoxItem(RxDecodeType.Miller_4, "Miller_4"))
            .Add(New ComboBoxItem(RxDecodeType.Miller_8, "Miller_8"))
        End With

        With cbxLinkFrequency.Items
            .Clear()
            .Add(New ComboBoxItem(LinkFrequencyType.LF_40kHz, "40kHz"))
            .Add(New ComboBoxItem(LinkFrequencyType.LF_80kHz, "80kHz"))
            .Add(New ComboBoxItem(LinkFrequencyType.LF_160kHz, "160kHz"))
            .Add(New ComboBoxItem(LinkFrequencyType.LF_213_3kHz, "213.3kHz"))
            .Add(New ComboBoxItem(LinkFrequencyType.LF_256kHz, "256kHz"))
            .Add(New ComboBoxItem(LinkFrequencyType.LF_320kHz, "320kHz"))
            .Add(New ComboBoxItem(LinkFrequencyType.LF_640kHz, "640kHz"))

        End With

        With cbxKeyboardSimulation.Items
            .Clear()
            .Add(New ComboBoxItem(True, KeyboardSimulation.Disable, "Disable"))
            .Add(New ComboBoxItem(KeyboardSimulation.HID, "USB HID"))
            .Add(New ComboBoxItem(KeyboardSimulation.BLE, "Bluetooth LE"))
        End With

        gbxTrigger.Visible = False              'Don't display this setting because TS100 does not support this function
        gbxCommandTriggerState.Visible = False  'Don't display this setting because TS100 does not support this function
        With cbxCommandTriggerState.Items
            .Clear()
            .Add(New ComboBoxItem(True, State.OFF, "Off"))
            .Add(New ComboBoxItem(State.ON, "On"))
        End With

        gbxScanMode.Visible = False             'Don't display this setting because TS100 does not support this function
        'With cbxScanMode.Items
        '    .Clear()
        '    .Add(New ComboBoxItem(True, TS100.ScanMode.AlwaysScan, "Always Scan"))
        '    .Add(New ComboBoxItem(TS100.ScanMode.Trigger_A_LevelControl, "Trigger A Level Control"))
        'End With

        With cbxQValue.Items
            .Clear()
            .Add(New ComboBoxItem(0, "0"))
            .Add(New ComboBoxItem(1, "1"))
            .Add(New ComboBoxItem(2, "2"))
            .Add(New ComboBoxItem(3, "3"))
            .Add(New ComboBoxItem(True, 4, "4"))
            .Add(New ComboBoxItem(5, "5"))
            .Add(New ComboBoxItem(6, "6"))
            .Add(New ComboBoxItem(7, "7"))
            .Add(New ComboBoxItem(8, "8"))
            .Add(New ComboBoxItem(9, "9"))
            .Add(New ComboBoxItem(10, "10"))
            .Add(New ComboBoxItem(11, "11"))
            .Add(New ComboBoxItem(12, "12"))
            .Add(New ComboBoxItem(13, "13"))
            .Add(New ComboBoxItem(14, "14"))
            .Add(New ComboBoxItem(15, "15"))
        End With

        With cbxSession.Items
            .Add(New ComboBoxItem(True, Session.S0, "S0"))
            .Add(New ComboBoxItem(Session.S1, "S1"))
            .Add(New ComboBoxItem(Session.S2, "S2"))
            .Add(New ComboBoxItem(Session.S3, "S3"))
            .Add(New ComboBoxItem(Session.SL, "SL"))
        End With

        cbxTarget.Items.AddRange(m_oSessionSLItems)

        With cbxEventType.Items
            .Clear()
            .Add(New ComboBoxItem(True, EventType.TagPresented, "Tag Presented Event"))
            .Add(New ComboBoxItem(EventType.TagPresentedWithRemoved, "Tag Presented With Removed Event"))
            .Add(New ComboBoxItem(EventType.TagPresentedEx, "Tag Presented Extend Event"))
        End With

        With cbxActiveMode.Items
            .Clear()
            .Add(New ComboBoxItem(ActiveMode.READ, "Read"))
            .Add(New ComboBoxItem(True, ActiveMode.COMMAND, "Command"))
            .Add(New ComboBoxItem(ActiveMode.TAG_ANALYSIS, "Tag Analysis"))
            'TS100 does not support these two modes.
            '.Add(New ComboBoxItem(ActiveMode.VERIFY, "Verify"))
            '.Add(New ComboBoxItem(ActiveMode.ENCODE, "Encode"))
            .Add(New ComboBoxItem(ActiveMode.CUSTOMIZED_READ, "Customized Read"))
            .Add(New ComboBoxItem(ActiveMode.DEACTIVATE, "Deactivate"))
            .Add(New ComboBoxItem(ActiveMode.REACTIVATE, "Reactivate"))
            .Add(New ComboBoxItem(ActiveMode.DEACTIVATE_USER_BANK, "Deactivate User Bank"))
            .Add(New ComboBoxItem(ActiveMode.REACTIVATE_USER_BANK, "Reactivate User Bank"))
        End With

        gbxGPIO.Visible = False         'Don't display this setting because TS100 does not support this function

        With cbxBuzzerOperationMode.Items
            .Clear()
            .Add(New ComboBoxItem(BuzzerOperationMode.OFF, "Off"))
            .Add(New ComboBoxItem(BuzzerOperationMode.ONCE, "Once"))
            .Add(New ComboBoxItem(BuzzerOperationMode.REPEAT, "Repeat"))
        End With

        With cbxBuzzerAction.Items
            .Clear()
            .Add(New ComboBoxItem(True, BuzzerAction.Disable, "Disable"))
            .Add(New ComboBoxItem(BuzzerAction.Success, "Success"))
            .Add(New ComboBoxItem(BuzzerAction.Failure, "Failure"))
            .Add(New ComboBoxItem(BuzzerAction.Auto, "Auto"))
        End With

        With cbxInventory.Items
            .Clear()
            .Add(New ComboBoxItem(True, TagPresentedType.PC_EPC, "EPC"))
            .Add(New ComboBoxItem(TagPresentedType.PC_EPC_TID, "EPC + TID"))
        End With

        With cbxReadMemoryBank.Items
            .Clear()
            .Add(New ComboBoxItem(True, MemoryBank.RESERVED, "Reserved"))
            .Add(New ComboBoxItem(MemoryBank.EPC, "EPC"))
            .Add(New ComboBoxItem(MemoryBank.TID, "TID"))
            .Add(New ComboBoxItem(MemoryBank.USER, "User"))
        End With

        With cbxWriteMemoryBank.Items
            .Clear()
            .Add(New ComboBoxItem(True, MemoryBank.RESERVED, "Reserved"))
            .Add(New ComboBoxItem(MemoryBank.EPC, "EPC"))
            .Add(New ComboBoxItem(MemoryBank.TID, "TID"))
            .Add(New ComboBoxItem(MemoryBank.USER, "User"))
        End With

        With cbxLockBank.Items
            .Clear()
            .Add(New ComboBoxItem(True, MemoryBank.EPC, "EPC"))
            .Add(New ComboBoxItem(MemoryBank.USER, "User"))
            .Add(New ComboBoxItem(MemoryBank.KILL_PASSWORD, "Kill Password"))
            .Add(New ComboBoxItem(MemoryBank.ACCESS_PASSWORD, "Access Password"))
        End With

        With cbxLockAction.Items
            .Clear()
            .Add(New ComboBoxItem(True, LockAction.UNLOCK, "Unlock"))
            .Add(New ComboBoxItem(LockAction.LOCK, "Lock"))
            .Add(New ComboBoxItem(LockAction.PERMANENT_UNLOCK, "Permanent Unlock"))
            .Add(New ComboBoxItem(LockAction.PERMANENT_LOCK, "Permanent Lock"))
        End With

        tabControl.Enabled = False
        _FrequencyItems = New List(Of CheckBox)
        _host.NetDeviceSearcherEnabled = True
    End Sub

    Private Sub StartConnection()
        Dim oPortList As New List(Of Object)
        Dim szBaudrate As String
        Dim bResult As Boolean
        Dim iCount As Integer
        Dim szPort As String
        Dim oPort As Object
        Dim I As Integer
        Dim cursor As Cursor
        bResult = False
        _host.NetDeviceSearcherEnabled = False
        DisconnectDevice()
        cursor = Me.Cursor
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With cbxPort
            If .SelectedIndex = 0 Then  ' Select Auto port
                RefreshPortList()
            Else
                oPortList.Add(.SelectedItem)
            End If
        End With
        szBaudrate = TryCast(cbxBaudrate.SelectedItem, String)
        iCount = oPortList.Count
        For I = 0 To (iCount - 1)
            With _ts100
                If .IsConnected Then
                    .Disconnect()
                End If
                .DeviceAddress = 0  '0 = no specify device ID
                oPort = oPortList(I)
                szPort = oPort.ToString()
                bResult = False
                If .Connect(szPort, szBaudrate) Then
                    bResult = True

                    'Dim szFirmware As String
                    'If _ts100.StopInventory() Then
                    '    szFirmware = _ts100.GetFirmwareVersion()
                    '    If szFirmware IsNot Nothing Then
                    '        lblRomVersion.Text = "ROM Version: " & szFirmware
                    '    Else
                    '        MsgBox("Get FW Version Failed.")
                    '    End If
                    'Else
                    '    MsgBox("Stop Inventory Failed.")
                    'End If
                Else
                    MsgBox("Open Port Failed! (" & szPort & ")")
                End If
                'If .Connect(szPort, szBaudrate) Then
                '    Dim szFirmware As String
                '    _ts100.StopInventory()
                '    szFirmware = _ts100.GetFirmwareVersion
                '    lblRomVersion.Text = "ROM Version: " & szFirmware
                '    Try
                '        cbxPort.SelectedItem = oPort
                '    Catch ex As Exception
                '        Debug.Print("Set CommPort Error: " & ex.ToString())
                '    End Try
                '    bResult = True
                '    Exit For
                'ElseIf .IsOpenPortError Then
                '    Exit For
                'End If
                'If bResult Then
                '    Exit For
                'ElseIf .IsConnected Then
                '    MsgBox("Connect Failed! (" & szPort & ")")
                '    .Disconnect()
                'Else
                '    MsgBox("Open Port Failed! (" & szPort & ")")
                'End If
            End With
        Next I

        If bResult = True Then
            cbxPort.Enabled = False
            cbxBaudrate.Enabled = False
            tabControl.Enabled = True
            btnWifiSetting.Enabled = True
            btnConnect.Text = "Disconnect"
            MsgBox("Conexion exitosa al reader.")
        End If
        _host.NetDeviceSearcherEnabled = True
        Me.Cursor = cursor
    End Sub

    Private Sub DisconnectDevice()
        With _ts100
            If .IsConnected = True Then
                If .Disconnect() Then
                    changeDisconnectionStatus()
                End If
            Else
                changeDisconnectionStatus()
            End If
        End With
    End Sub

    Private Sub ConnectDevice()
        Try
            StartConnection()
            InitializeUI()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Select Case btnConnect.Text
            Case "Connect"
                ConnectDevice()
            Case "Disconnect"
                DisconnectDevice()
        End Select
    End Sub

    Private Sub ShowWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        With Me
            If .Visible = False Then
                .Enabled = True
                .Visible = True
                .Refresh()
            End If
        End With
    End Sub

    Private Sub ShowWindow_Activated(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender IsNot Nothing Then
            CType(sender, Form).BringToFront()
        End If
    End Sub

    Private Sub RefreshPortList()
        RefreshPortList(Nothing)
    End Sub

    Private Sub RefreshPortList(ByVal szDefaultPort As String)
        Dim iNumberOfPorts As Integer
        Dim szSelectedPort As String
        Dim szPort As String
        Dim iSelectedItem As Integer
        Dim I As Integer
        iNumberOfPorts = _host.GetPortCount()
        iSelectedItem = -1
        With cbxPort
            szSelectedPort = .SelectedText
            If szSelectedPort Is Nothing OrElse szSelectedPort.Length = 0 Then
                szSelectedPort = szDefaultPort
            End If
            If szSelectedPort IsNot Nothing Then
                If szSelectedPort.Length = 0 Then
                    szSelectedPort = Nothing
                End If
            End If
            With .Items
                .Clear()
                .Add("Auto")
                For I = 0 To (iNumberOfPorts - 1)
                    szPort = _host.GetPortName(I)
                    If szSelectedPort IsNot Nothing AndAlso String.Equals(szSelectedPort, szPort) Then
                        iSelectedItem = .Add(szPort)
                    Else
                        .Add(szPort)
                    End If
                Next I
                If iSelectedItem = -1 AndAlso .Count > 0 Then
                    iSelectedItem = 0
                End If
            End With
            Try
                .SelectedIndex = iSelectedItem
            Catch ex As Exception
                Debug.Print("RefreshPortList: " & ex.ToString())
            End Try
        End With
    End Sub

    Private Sub btnWifiSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWifiSetting.Click
        Using oWiFiSettings As New WiFiSettingsForm()
            oWiFiSettings.ShowWiFiSettings(_ts100)
        End Using
    End Sub

    Private Sub changeDisconnectionStatus()
        cbxBaudrate.Enabled = True
        cbxPort.Enabled = True
        btnWifiSetting.Enabled = False
        tabControl.Enabled = False
        btnConnect.Text = "Connect"
        lblRomVersion.Text = "ROM Version: "
    End Sub

    Private m_bIsInventoryProcessing As Boolean
    Private Sub btnStartInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartInventory.Click
        Dim result As Boolean
        Dim tagPresetnedType As TagPresentedType
        ClearTagListView()
        tagPresetnedType = ComboBoxItem.GetCurrentItemValue(cbxInventory)
        Select Case tagPresetnedType
            Case TagPresentedType.PC_EPC
                dgvTagList.Columns.Item(1).Visible = False
            Case TagPresentedType.PC_EPC_TID
                dgvTagList.Columns.Item(1).Visible = True
        End Select
        result = _ts100.StartInventory(tagPresetnedType)
        If result Then
            m_bIsInventoryProcessing = True
            btnStartInventory.Enabled = False
            btnStopInventory.Enabled = True
            btnStartInventoryEx.Enabled = False
            btnStopInventoryEx.Enabled = True
        End If
    End Sub

    Private Sub btnStopInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopInventory.Click, btnStopInventoryEx.Click
        Dim result As Boolean
        result = _ts100.StopInventory()
        If result Then
            m_bIsInventoryProcessing = False
            btnStartInventory.Enabled = True
            btnStopInventory.Enabled = False
            btnStartInventoryEx.Enabled = True
            btnStopInventoryEx.Enabled = False
        End If
    End Sub

    Private Sub ClearTagListView()
        dgvTagList.Rows.Clear()
        _tagList.Clear()
        CountTags()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        dgvTagList.Rows.Clear()
        _tagList.Clear()
        CountTags()
    End Sub

    Private Sub CountTags()
        lblTotalCount.Text = _tagList.Count
    End Sub

    Private Sub _ts10O_OnTagPresented(ByVal sender As Object, ByVal tagInformation As TagInformationFormat) Handles _ts100.OnTagPresented
        Dim oRow As DataGridViewRow
        Dim iRowIndex As Integer
        Dim szPCEPC As String = tagInformation.PcEpcHex
        Dim szTID As String = tagInformation.TidHex

        iRowIndex = _tagList.IndexOf(szPCEPC)
        If iRowIndex <> -1 Then
            oRow = dgvTagList.Rows(iRowIndex)
            oRow.Cells(2).Value = oRow.Cells(2).Value + 1
        Else
            _tagList.Add(szPCEPC)
            iRowIndex = dgvTagList.Rows.Add()
            oRow = dgvTagList.Rows(iRowIndex)
            oRow.Cells(0).Value = szPCEPC
            oRow.Cells(1).Value = szTID
            oRow.Cells(2).Value = 1
            CountTags()
        End If
    End Sub

    Private Sub _ts100_OnTagPresentedEx(sender As Object, tagDecodeInformation As DecodedTagData) Handles _ts100.OnTagPresentedEx
        Dim oRow As DataGridViewRow
        Dim iRowIndex As Integer
        Dim szPCEPC As String
        Dim szTID As String

        For Each oData In tagDecodeInformation.Data
            Select Case oData.OutputDataType
                Case oData.DataType.TagData_PC_EPC, oData.DataType.TagData_EPC
                    szPCEPC = oData.ToString

                Case oData.DataType.EAN_UPC_WithoutEAS
                    szPCEPC = oData.ToString

            End Select
        Next oData
        szTID = tagDecodeInformation.TID.ToHexString

        iRowIndex = _tagList.IndexOf(szPCEPC)

        If iRowIndex <> -1 Then
            oRow = dgvTagList.Rows(iRowIndex)
            oRow.Cells(2).Value = oRow.Cells(2).Value + 1
        Else
            _tagList.Add(szPCEPC)
            iRowIndex = dgvTagList.Rows.Add()
            oRow = dgvTagList.Rows(iRowIndex)
            oRow.Cells(0).Value = szPCEPC
            oRow.Cells(1).Value = szTID
            oRow.Cells(2).Value = 1
            CountTags()
        End If
    End Sub

    'Private Sub _ts800_OnIOStateChanged(ByVal sender As Object, ByVal ioEventArgs As IOEventArgs) Handles _ts800.OnIOStateChanged
    '    With ioEventArgs
    '        If .IONumber = IONumber.Input_Pin_0 Then
    '            If .IOState = IOState.Low Then
    '                lblInputState.Text = "Low"
    '            ElseIf .IOState = IOState.High Then
    '                lblInputState.Text = "High"
    '            Else
    '                lblInputState.Text = "Error"
    '            End If
    '        End If
    '    End With
    'End Sub

    Private Sub cbLeftLight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLeftLight.CheckedChanged
        '    If cbLeftLight.Checked Then
        '        _ts100.SetIOState(IONumber.Output_Pin_0, IOState.High)
        '    Else
        '        _ts100.SetIOState(IONumber.Output_Pin_0, IOState.Low)
        '    End If
    End Sub

    Private Sub cbMidLight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMidLight.CheckedChanged
        '    If cbMidLight.Checked Then
        '        _ts100.SetIOState(IONumber.Output_Pin_1, IOState.High)
        '    Else
        '        _ts100.SetIOState(IONumber.Output_Pin_1, IOState.Low)
        '    End If
    End Sub

    Private Sub cbRightLight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRightLight.CheckedChanged
        '    If cbRightLight.Checked Then
        '        _ts100.SetIOState(IONumber.Output_Pin_2, IOState.High)
        '    Else
        '        _ts100.SetIOState(IONumber.Output_Pin_2, IOState.Low)
        '    End If
    End Sub

    Private Sub btnGetIO_State_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetIO_State.Click
        '    Dim resultMessage As String = ""
        '    Dim state As String = ""
        '    Dim stateOutputPin0 As IOState
        '    Dim stateOutputPin1 As IOState
        '    Dim stateOutputPin2 As IOState
        '    If (_ts100.GetIOState) Then
        '        stateOutputPin0 = _ts100.OutputPin0State
        '        stateOutputPin1 = _ts100.OutputPin1State
        '        stateOutputPin2 = _ts100.OutputPin2State
        '        If stateOutputPin0 = IOState.High Then
        '            state = "High"
        '        Else
        '            state = "Low"
        '        End If
        '        resultMessage = "Output Pin 0 is " & state

        '        If stateOutputPin1 = IOState.High Then
        '            state = "High"
        '        Else
        '            state = "Low"
        '        End If
        '        resultMessage = resultMessage & vbCrLf & "Output Pin 1 is " & state

        '        If stateOutputPin2 = IOState.High Then
        '            state = "High"
        '        Else
        '            state = "Low"
        '        End If
        '        resultMessage = resultMessage & vbCrLf & "Output Pin 2 is " & state
        '        MsgBox(resultMessage)
        '    Else
        '        MsgBox("Get Light State Failed.")
        '    End If
    End Sub

    'Private Sub updateInputState()
    '    Dim state As IOState
    '    state = _ts100.InputPin0State
    '    If state = IOState.Low Then
    '        lblInputState.Text = "Low"
    '    Else
    '        lblInputState.Text = "High"
    '    End If
    'End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        Dim bResult As Byte() = Nothing
        Dim szPassword As String
        Dim memoryBank As MemoryBank
        Dim iNudStart As Integer
        Dim iNudLength As Integer

        szPassword = tbReadPassword.Text
        memoryBank = ComboBoxItem.GetCurrentItemValue(cbxReadMemoryBank)

        iNudStart = nudReadStart.Value
        iNudLength = nudReadLength.Value

        bResult = _ts100.ReadTag(szPassword, memoryBank, iNudStart, iNudLength)

        If bResult IsNot Nothing Then
            Dim szReadData As String = ""
            For I = 0 To (bResult.Length - 1)
                szReadData = szReadData & bResult(I).ToString("X02") & ""
            Next I
            tbReadResult.Text = szReadData
        Else
            MsgBox("Read Specified Memory Bank Failed.")
        End If
    End Sub

    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click
        Dim writeDataByte As Byte()
        Dim szPassword As String
        Dim iNudStart As Integer
        Dim memoryBank As MemoryBank
        Dim bResult As Boolean = False
        Dim szData As String
        szPassword = tbWritePassword.Text
        memoryBank = ComboBoxItem.GetCurrentItemValue(cbxWriteMemoryBank)
        iNudStart = nudWriteStart.Value()
        szData = tbWriteData.Text
        writeDataByte = HexStringToByteArray(szData)
        bResult = _ts100.WriteTag(UHF.DEFAULT_PASSWORD, memoryBank, iNudStart, writeDataByte)
        If bResult Then
            MsgBox("Write Successful.")
        Else
            MsgBox("Write Failed.")
        End If
    End Sub

    Private Sub btnWriteEPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteEPC.Click
        Dim writeDataByte As Byte()
        Dim bResult As Boolean
        Dim szData As String
        Dim szSelectedTagEPCHexString As String
        Dim szPassword As String
        szPassword = tbEPCWritePassword.Text
        szSelectedTagEPCHexString = tbTargetPCEPC.Text
        If szSelectedTagEPCHexString.Trim().Length = 0 Then
            szSelectedTagEPCHexString = Nothing
        End If
        szData = tbEPCWriteHexString.Text
        writeDataByte = HexStringToByteArray(szData)
        bResult = _ts100.WriteEPC(szSelectedTagEPCHexString, szPassword, writeDataByte)
        'When szSelectedTagEPCHexString is Nothing, It is the same as following
        '   bResult = _ts100.WriteEPC(szPassword, writeDataByte)
        If bResult Then
            MsgBox("Write EPC Successful.")
        Else
            MsgBox("Write EPC Failed.")
        End If
    End Sub

    Private Shared Function HexStringToByteArray(ByVal hexString As String) As Byte()
        ' remove any spaces
        hexString = hexString.Replace(" "c, "")
        ' make sure we have an even number of digits
        If (hexString.Length And 1) = 1 Then
            MsgBox("Odd string length when even string length is required.")
        End If

        ' calculate the length of the byte array and dim an array to that
        Dim iLength = hexString.Length \ 2
        Dim bResult(iLength - 1) As Byte

        ' pick out every two bytes and convert them from hex representation
        For I = 0 To iLength - 1
            bResult(I) = Convert.ToByte(hexString.Substring(I * 2, 2), 16)
        Next I

        Return bResult
    End Function

    Private Sub cbWriteMemoryBank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxWriteMemoryBank.SelectedIndexChanged
        If cbxWriteMemoryBank.SelectedIndex = MemoryBank.EPC Then
            nudWriteStart.Minimum = 1
            lblEPCHint1.Visible = True
            lblEPCHint2.Visible = True
        Else
            nudWriteStart.Minimum = 0
            lblEPCHint1.Visible = False
            lblEPCHint2.Visible = False
        End If
    End Sub

    Private Sub btnBuzzerControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuzzerControl.Click
        Dim buzzerActionValue As BuzzerAction
        Dim result As Boolean = False
        buzzerActionValue = ComboBoxItem.GetCurrentItemValue(cbxBuzzerAction)
        result = _ts100.ControlBuzzer(buzzerActionValue)
        If result = False Then
            MsgBox("Control Buzzer Failed.")
        End If
    End Sub

    Private Sub btnSetDelimiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDelimiter.Click
        Dim delimiterValue As New HashSet(Of PostDataDelimiter)
        Dim result As Boolean
        If chkDelimiterCR.Checked Then
            delimiterValue.Add(PostDataDelimiter.CR)
        End If
        If chkDelimiterLine.Checked Then
            delimiterValue.Add(PostDataDelimiter.LF)
        End If
        If chkDelimiterTab.Checked Then
            delimiterValue.Add(PostDataDelimiter.TAB)
        End If
        result = _ts100.SetPostDataDelimiter(False, delimiterValue)
        If result Then
            MsgBox("Set Post Data Delimiter Successful.")
        Else
            MsgBox("Set Post Data Delimiter Failed.")
        End If
    End Sub

    Private Sub btnGetDelimiter_Click(sender As Object, e As EventArgs) Handles btnGetDelimiter.Click
        Dim postDelimiterSet As HashSet(Of PostDataDelimiter)
        postDelimiterSet = _ts100.GetPostDataDelimiter(False)
        chkDelimiterCR.Checked = False
        chkDelimiterLine.Checked = False
        chkDelimiterTab.Checked = False
        For Each delimiter As PostDataDelimiter In postDelimiterSet
            Select Case delimiter
                Case PostDataDelimiter.CR
                    chkDelimiterCR.Checked = True
                Case PostDataDelimiter.LF
                    chkDelimiterLine.Checked = True
                Case PostDataDelimiter.TAB
                    chkDelimiterTab.Checked = True
            End Select
        Next delimiter
    End Sub

    Private Sub BtnSetMemoryBankSelection_Click(sender As Object, e As EventArgs) Handles btnSetMemoryBankSelection.Click
        Dim memoryBankSet As New HashSet(Of MemoryBankSelection)
        Dim result As Boolean
        If chkBankPC.Checked Then
            memoryBankSet.Add(MemoryBankSelection.PC)
        End If
        If chkBankEPC.Checked Then
            memoryBankSet.Add(MemoryBankSelection.EPC)
        End If
        If chkBankTID.Checked Then
            memoryBankSet.Add(MemoryBankSelection.TID)
        End If
        'TS100 does not support this.
        'If chkBankUser.Checked Then
        '    memoryBankSet.Add(MemoryBankSelection.USER)
        'End If
        If chkBankEPCASCII.Checked Then
            memoryBankSet.Add(MemoryBankSelection.EPC_ASCII)
        End If
        result = _ts100.SetMemoryBankSelection(False, memoryBankSet)
        If result Then
            MsgBox("Set Memory Bank Selection Successful.")
        Else
            MsgBox("Set Memory Bank Selection Failed.")
        End If
    End Sub

    Private Sub btnGetMemoryBankSelection_Click(sender As Object, e As EventArgs) Handles btnGetMemoryBankSelection.Click
        Dim memoryBankSet As HashSet(Of MemoryBankSelection)
        memoryBankSet = _ts100.GetMemoryBankSelection(False)
        chkBankPC.Checked = False
        chkBankEPC.Checked = False
        chkBankTID.Checked = False
        'TS100 does not support this.
        'chkBankUser.Checked = False
        chkBankEPCASCII.Checked = False
        For Each memoryBank As MemoryBankSelection In memoryBankSet
            Select Case memoryBank
                Case MemoryBankSelection.PC
                    chkBankPC.Checked = True
                Case MemoryBankSelection.EPC
                    chkBankEPC.Checked = True
                Case MemoryBankSelection.TID
                    chkBankTID.Checked = True
                'TS100 does not support this.
                'Case MemoryBankSelection.USER
                '    chkBankUser.Checked = True
                Case MemoryBankSelection.EPC_ASCII
                    chkBankEPCASCII.Checked = True
            End Select
        Next memoryBank
    End Sub

    Private Sub btnSetFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetFilter.Click
        Dim encodeTypeSet As HashSet(Of TagDataEncodeType)
        Dim result As Boolean
        encodeTypeSet = New HashSet(Of TagDataEncodeType)
        If (chkUdc.Checked) Then
            encodeTypeSet.Add(TagDataEncodeType.UDC)
        End If
        If (chkEanUpc.Checked) Then
            encodeTypeSet.Add(TagDataEncodeType.EAN_UPC)
        End If
        If (chkEanUpcEas.Checked) Then
            encodeTypeSet.Add(TagDataEncodeType.EAN_UPC_EAS)
        End If
        If (chkRawData.Checked) Then
            encodeTypeSet.Add(TagDataEncodeType.RAW_DATA)
        End If
        result = _ts100.SetFilter(False, encodeTypeSet)
        If result Then
            MsgBox("Set Filter Successful.")
        Else
            MsgBox("Set Filter Failed.")
        End If
    End Sub

    Private Sub btnGetFilter_Click(sender As Object, e As EventArgs) Handles btnGetFilter.Click
        Dim encoeFilterSet As HashSet(Of TagDataEncodeType)
        chkUdc.Checked = False
        chkEanUpc.Checked = False
        chkEanUpcEas.Checked = False
        chkRawData.Checked = False
        encoeFilterSet = _ts100.GetFilter(False)
        For Each decodedType As TagDataEncodeType In encoeFilterSet
            Select Case decodedType
                Case TagDataEncodeType.UDC
                    chkUdc.Checked = True
                Case TagDataEncodeType.EAN_UPC
                    chkEanUpc.Checked = True
                Case TagDataEncodeType.EAN_UPC_EAS
                    chkEanUpcEas.Checked = True
                Case TagDataEncodeType.RAW_DATA
                    chkRawData.Checked = True
            End Select
        Next decodedType
    End Sub

    Private Sub InitializeUI()

        tabControl.SelectedTab = tpPerformance
        btnGetRfPower.PerformClick()
        btnGetRfSensitivity.PerformClick()
        btnGetRxDecode.PerformClick()
        btnGetLinkFrequency.PerformClick()
        btnGetTagPresentRepeatInterval.PerformClick()
        btnGetRemoveThreshold.PerformClick()
        btnGetInvnetoryRoundInterval.PerformClick()
        btnGetFrequency.PerformClick()

        tabControl.SelectedTab = tpDeviceSettings
        btnGetMemoryBankSelection.PerformClick()
        btnGetDelimiter.PerformClick()
        btnGetOutputInterface.PerformClick()
        btnGetFilter.PerformClick()
        btnGetTriggerType.PerformClick()
        btnGetCommandTriggerState.PerformClick()
        btnGetScanMode.PerformClick()
        btnGetQValue.PerformClick()
        btnGetSessionTarget.PerformClick()
        btnGetEventType.PerformClick()
        btnGetActiveMode.PerformClick()

        tabControl.SelectedTab = tpControl
        btnGetBuzzerOperationMode.PerformClick()

        'If (_ts100.GetIOState) Then
        '    updateInputState()
        'Else
        '    lblInputState.Text = "N/A"
        'End If        

        cbxInventory.SelectedIndex = 0
        cbxBuzzerAction.SelectedIndex = 0
        cbxWriteMemoryBank.SelectedIndex = 0
        cbxReadMemoryBank.SelectedIndex = 0
        cbxLockBank.SelectedIndex = 0
        cbxLockAction.SelectedIndex = 0

        tabControl.SelectedTab = tpBLE
        lblBLEROMVersion.Text = _ts100.GetBleRomVersion
        tbBLEDeviceName.Text = _ts100.GetBleDeviceName

        tabControl.SelectedTab = tpPerformance
    End Sub

    Private Sub btnSetRfPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetRfPower.Click
        Dim power As Integer
        Dim result As Boolean
        power = tbRfPower.Value
        result = _ts100.SetRfPower(False, power)
        If result Then
            MsgBox("Set RF Power Successful.")
        Else
            MsgBox("Set RF Power Failed.")
        End If
    End Sub

    Private Sub btnGetRfPower_Click(sender As Object, e As EventArgs) Handles btnGetRfPower.Click
        Dim power As Integer
        power = _ts100.GetRfPower(False)
        tbRfPower.Value = power
    End Sub

    Private Sub tbRfPower_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRfPower.ValueChanged
        lblRfPower.Text = tbRfPower.Value & " dBm"
    End Sub

    Private Sub btnSetFrequency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetFrequency.Click
        Dim frequencySet As HashSet(Of Double) = New HashSet(Of Double)
        For Each oControl In gbFrequency.Controls
            For Each oCheckBox In oControl.Controls
                If TypeOf oCheckBox Is CheckBox Then
                    With (CType(oCheckBox, CheckBox))
                        If (.Checked = True) Then
                            frequencySet.Add(CType(.Text, Double))
                        End If
                    End With
                End If
            Next oCheckBox
        Next oControl
        If frequencySet.Count > 0 Then
            If (_ts100.SetFrequency(False, frequencySet)) Then
                MsgBox("Set Frequency Successful.")
            End If
        Else
            MsgBox("Please check the frequency you want to set.")
        End If
    End Sub

    Private Sub btnGetFrequency_Click(sender As Object, e As EventArgs) Handles btnGetFrequency.Click
        Dim objectName As String
        Dim foundControls() As Control
        Dim frequencyCheckBox As CheckBox
        Dim checkBoxText As String
        Dim frequencySet As HashSet(Of Double) = New HashSet(Of Double)
        For Each oControl In gbFrequency.Controls
            For Each oCheckBox In oControl.Controls
                If TypeOf oCheckBox Is CheckBox Then
                    CType(oCheckBox, CheckBox).Checked = False
                End If
            Next oCheckBox
        Next oControl
        frequencySet = _ts100.GetFrequency(False)
        For Each frequency In frequencySet
            Try
                checkBoxText = frequency
                checkBoxText = checkBoxText.Replace(".", "_")
                If checkBoxText.Contains("_") = False Then
                    checkBoxText = checkBoxText & "_0"
                End If
                objectName = "cb" & checkBoxText
                foundControls = gbFrequency.Controls.Find(objectName, True)
                If (foundControls.Length > 0) Then
                    For J = 0 To (foundControls.Length - 1)
                        If TypeOf foundControls(J) Is CheckBox Then
                            frequencyCheckBox = CType(foundControls(J), CheckBox)
                            frequencyCheckBox.Checked = True
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next frequency
    End Sub

    Private Sub btnSetBuzzerOperationMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetBuzzerOperationMode.Click
        Dim buzzerOperationMode As BuzzerOperationMode
        Dim result As Boolean
        Select Case cbxBuzzerOperationMode.SelectedIndex
            Case 0
                buzzerOperationMode = BuzzerOperationMode.OFF
            Case 1
                buzzerOperationMode = BuzzerOperationMode.ONCE
            Case 2
                buzzerOperationMode = BuzzerOperationMode.REPEAT
        End Select
        result = _ts100.SetBuzzerOperationMode(False, buzzerOperationMode)
        If result Then
            MsgBox("Set Buzzer Operation Mode Successful.")
        Else
            MsgBox("Set Buzzer Operation Mode Failed.")
        End If
    End Sub

    Private Sub btnGetBuzzerOperationMode_Click(sender As Object, e As EventArgs) Handles btnGetBuzzerOperationMode.Click
        Dim buzzerOperationMode As BuzzerOperationMode
        buzzerOperationMode = _ts100.GetBuzzerOperationMode(False)
        ComboBoxItem.SelectItemByValue(cbxBuzzerOperationMode, buzzerOperationMode)
    End Sub

    Private Sub tbRfSensitivity_ValueChanged(sender As Object, e As EventArgs) Handles tbRfSensitivity.ValueChanged
        lblRfSensitivity.Text = "Level " & tbRfSensitivity.Value
    End Sub

    Private Sub btnSetRfSensitivity_Click(sender As Object, e As EventArgs) Handles btnSetRfSensitivity.Click
        Dim rfSensitivityValue As RfSensitivityLevel = RfSensitivityLevel.LEVEL_7
        Dim result As Boolean = False
        Select Case tbRfSensitivity.Value
            Case 1
                rfSensitivityValue = RfSensitivityLevel.LEVEL_1_LOWEST
            Case 2
                rfSensitivityValue = RfSensitivityLevel.LEVEL_2
            Case 3
                rfSensitivityValue = RfSensitivityLevel.LEVEL_3
            Case 4
                rfSensitivityValue = RfSensitivityLevel.LEVEL_4
            Case 5
                rfSensitivityValue = RfSensitivityLevel.LEVEL_5
            Case 6
                rfSensitivityValue = RfSensitivityLevel.LEVEL_6
            Case 7
                rfSensitivityValue = RfSensitivityLevel.LEVEL_7
            Case 8
                rfSensitivityValue = RfSensitivityLevel.LEVEL_8
            Case 9
                rfSensitivityValue = RfSensitivityLevel.LEVEL_9
            Case 10
                rfSensitivityValue = RfSensitivityLevel.LEVEL_10
            Case 11
                rfSensitivityValue = RfSensitivityLevel.LEVEL_11
            Case 12
                rfSensitivityValue = RfSensitivityLevel.LEVEL_12
            Case 13
                rfSensitivityValue = RfSensitivityLevel.LEVEL_13
            Case 14
                rfSensitivityValue = RfSensitivityLevel.LEVEL_14_HIGHEST
        End Select
        result = _ts100.SetRfSensitivity(False, rfSensitivityValue)
        If result Then
            MsgBox("Set RF Sensitivity Successful.")
        Else
            MsgBox("Set RF Sensitivity Failed.")
        End If
    End Sub

    Private Sub btnGetRfSensitivity_Click(sender As Object, e As EventArgs) Handles btnGetRfSensitivity.Click
        Dim sensitivity As Integer
        sensitivity = _ts100.GetRfSensitivity(False)
        If sensitivity <> 0 Then
            Select Case sensitivity
                Case RfSensitivityLevel.LEVEL_1_LOWEST
                    sensitivity = 1
                Case RfSensitivityLevel.LEVEL_2
                    sensitivity = 2
                Case RfSensitivityLevel.LEVEL_3
                    sensitivity = 3
                Case RfSensitivityLevel.LEVEL_4
                    sensitivity = 4
                Case RfSensitivityLevel.LEVEL_5
                    sensitivity = 5
                Case RfSensitivityLevel.LEVEL_6
                    sensitivity = 6
                Case RfSensitivityLevel.LEVEL_7
                    sensitivity = 7
                Case RfSensitivityLevel.LEVEL_8
                    sensitivity = 8
                Case RfSensitivityLevel.LEVEL_9
                    sensitivity = 9
                Case RfSensitivityLevel.LEVEL_10
                    sensitivity = 10
                Case RfSensitivityLevel.LEVEL_11
                    sensitivity = 11
                Case RfSensitivityLevel.LEVEL_12
                    sensitivity = 12
                Case RfSensitivityLevel.LEVEL_13
                    sensitivity = 13
                Case RfSensitivityLevel.LEVEL_14_HIGHEST
                    sensitivity = 14
            End Select
            tbRfSensitivity.Value = sensitivity
        End If
    End Sub

    Private Sub btnSetRxDecode_Click(sender As Object, e As EventArgs) Handles btnSetRxDecode.Click
        Dim rxDecodeValue As RxDecodeType = RxDecodeType.Miller_4
        Dim result As Boolean = False
        Select Case cbxRxDecode.SelectedIndex
            Case 0
                rxDecodeValue = RxDecodeType.FM0
            Case 1
                rxDecodeValue = RxDecodeType.Miller_2
            Case 2
                rxDecodeValue = RxDecodeType.Miller_4
            Case 3
                rxDecodeValue = RxDecodeType.Miller_8
        End Select
        result = _ts100.SetRxDecode(False, rxDecodeValue)
        If result Then
            MsgBox("Set RX Decode Successful.")
        Else
            MsgBox("Set RX Decode Failed.")
        End If
    End Sub

    Private Sub btnGetRxDecode_Click(sender As Object, e As EventArgs) Handles btnGetRxDecode.Click
        Dim rxDecodeValue As RxDecodeType = RxDecodeType.Miller_4
        rxDecodeValue = _ts100.GetRxDecode(False)
        cbxRxDecode.SelectedIndex = rxDecodeValue
    End Sub

    Private Sub btnSetLinkFrequency_Click(sender As Object, e As EventArgs) Handles btnSetLinkFrequency.Click
        Dim linkFrequencyValue As LinkFrequencyType = LinkFrequencyType.LF_256kHz
        Dim result As Boolean = False
        Select Case cbxLinkFrequency.SelectedIndex
            Case 0
                linkFrequencyValue = LinkFrequencyType.LF_40kHz
            Case 1
                linkFrequencyValue = LinkFrequencyType.LF_80kHz
            Case 2
                linkFrequencyValue = LinkFrequencyType.LF_160kHz
            Case 3
                linkFrequencyValue = LinkFrequencyType.LF_213_3kHz
            Case 4
                linkFrequencyValue = LinkFrequencyType.LF_256kHz
            Case 5
                linkFrequencyValue = LinkFrequencyType.LF_320kHz
            Case 6
                linkFrequencyValue = LinkFrequencyType.LF_640kHz
        End Select
        result = _ts100.SetLinkFrequency(False, linkFrequencyValue)
        If result Then
            MsgBox("Set Link Frequency Successful.")
        Else
            MsgBox("Set Link Frequency Failed.")
        End If
    End Sub

    Private Sub btnGetLinkFrequency_Click(sender As Object, e As EventArgs) Handles btnGetLinkFrequency.Click
        Dim linkFrequencyValue As LinkFrequencyType = LinkFrequencyType.LF_256kHz
        linkFrequencyValue = _ts100.GetLinkFrequency(False)
        Select Case linkFrequencyValue
            Case LinkFrequencyType.LF_40kHz
                cbxLinkFrequency.SelectedIndex = 0
            Case LinkFrequencyType.LF_80kHz
                cbxLinkFrequency.SelectedIndex = 1
            Case LinkFrequencyType.LF_160kHz
                cbxLinkFrequency.SelectedIndex = 2
            Case LinkFrequencyType.LF_213_3kHz
                cbxLinkFrequency.SelectedIndex = 3
            Case LinkFrequencyType.LF_256kHz
                cbxLinkFrequency.SelectedIndex = 4
            Case LinkFrequencyType.LF_320kHz
                cbxLinkFrequency.SelectedIndex = 5
            Case LinkFrequencyType.LF_640kHz
                cbxLinkFrequency.SelectedIndex = 6
        End Select
    End Sub

    Private Sub btnSetTriggerType_Click(sender As Object, e As EventArgs) Handles btnSetTriggerType.Click
        'Dim result As Boolean
        'Dim triggerTypes As New HashSet(Of TriggerType)
        'If chkCommand.Checked Then
        '    triggerTypes.Add(TriggerType.Command)
        'End If
        'If chkSensor.Checked Then
        '    triggerTypes.Add(TriggerType.Sensor)
        'End If
        'If chkDigitalInput.Checked Then
        '    triggerTypes.Add(TriggerType.DigitalInput)
        'End If
        'result = _ts100.SetTriggerType(False, triggerTypes)
        'If result Then
        '    MsgBox("Set TriggerType Successful.")
        'Else
        '    MsgBox("Set TriggerType Failed.")
        'End If
    End Sub

    Private Sub btnGetTriggerType_Click(sender As Object, e As EventArgs) Handles btnGetTriggerType.Click
        'Dim triggerTypes As New HashSet(Of TriggerType)
        'triggerTypes = _ts100.GetTriggerType(False)
        'chkCommand.Checked = False
        'chkSensor.Checked = False
        'chkDigitalInput.Checked = False
        'For Each type As TriggerType In triggerTypes
        '    If type = TriggerType.Command Then
        '        chkCommand.Checked = True
        '    ElseIf type = TriggerType.Sensor Then
        '        chkSensor.Checked = True
        '    ElseIf type = TriggerType.DigitalInput Then
        '        chkDigitalInput.Checked = True
        '    End If
        'Next type
    End Sub

    Private Sub _uhf_OnErrorOccurred(errorCode As ErrorCode, errorMessage As String) Handles _ts100.OnErrorOccurred
        Debug.Print("errorCode: " & errorCode & vbTab & "errorMessage: " & errorMessage)
    End Sub
    Private Sub cbxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSession.SelectedIndexChanged
        Dim session As Session
        Dim index As Integer
        index = cbxTarget.SelectedIndex
        session = ComboBoxItem.GetCurrentItemValue(cbxSession)
        With cbxTarget.Items
            .Clear()
            If session = Session.SL Then
                .AddRange(m_oSessionSLItems)
            Else
                .AddRange(m_oSessionS0To3Items)
            End If
        End With
        cbxTarget.SelectedIndex = index
    End Sub

    Private m_oSessionSLItems() As ComboBoxItem =
        {
            New ComboBoxItem(True, Target.deSL, "~SL"),
            New ComboBoxItem(Target.SL, "SL"),
            New ComboBoxItem(Target.SL_deSL, "SL <-> ~SL")
        }

    Private m_oSessionS0To3Items() As ComboBoxItem =
        {
            New ComboBoxItem(True, Target.A, "A"),
            New ComboBoxItem(Target.B, "B"),
            New ComboBoxItem(Target.A_B, "A <-> B")
        }

    Private Sub btnSetQValue_Click(sender As Object, e As EventArgs) Handles btnSetQValue.Click
        Dim result As Boolean
        Dim qValue As Integer
        qValue = ComboBoxItem.GetCurrentItemValue(cbxQValue)
        result = _ts100.SetQValue(False, qValue)
        If result Then
            MsgBox("Set Q Value Successful.")
        Else
            MsgBox("Set Q Value Failed.")
        End If
    End Sub

    Private Sub btnGetQValue_Click(sender As Object, e As EventArgs) Handles btnGetQValue.Click
        Dim qValue As Integer
        qValue = _ts100.GetQValue(False)
        ComboBoxItem.SelectItemByValue(cbxQValue, qValue)
    End Sub

    Private Sub btnSetSessionTarget_Click(sender As Object, e As EventArgs) Handles btnSetSessionTarget.Click
        Dim result As Boolean
        Dim target As Target
        Dim session As Session
        session = ComboBoxItem.GetCurrentItemValue(cbxSession)
        target = ComboBoxItem.GetCurrentItemValue(cbxTarget)
        result = _ts100.SetSessionAndTarget(False, session, target)
        If result Then
            MsgBox("Set Session and Target Successful.")
        Else
            MsgBox("Set Session and Target Failed.")
        End If
    End Sub

    Private Sub btnGetSessionTarget_Click(sender As Object, e As EventArgs) Handles btnGetSessionTarget.Click
        Dim session As Session
        Dim target As Target
        _ts100.GetSessionAndTarget(False, session, target)
        ComboBoxItem.SelectItemByValue(cbxSession, session)
        ComboBoxItem.SelectItemByValue(cbxTarget, target)
    End Sub

    Private Sub _host_OnPortStateChanged(sender As Object, portName As String, portState As Host.PortState) Handles _host.OnPortStateChanged
        Dim iIndex As Integer = -1
        iIndex = cbxPort.FindStringExact(portName)
        Select Case portState
            Case Host.PortState.PlugIn
                Dim bIsNetPort As Boolean
                bIsNetPort = False
                If portName.StartsWith("TCP:") Then
                    bIsNetPort = True
                End If
                If (iIndex = -1) Then       '-1就是還沒在comboBox內
                    iIndex = cbxPort.Items.Add(portName)
                    If cbxPort.SelectedIndex = (-1) Then
                        cbxPort.SelectedIndex = iIndex
                    Else
                        If (_ts100 IsNot Nothing) AndAlso (_ts100.IsConnected = False) Then
                            cbxPort.SelectedIndex = iIndex
                        End If
                    End If
                End If
            Case Host.PortState.Removed, Host.PortState.RemovedAndClosed
                If iIndex <> -1 Then    '該port是存在combobox中的
                    cbxPort.Items.RemoveAt(iIndex)
                    If iIndex < cbxPort.Items.Count Then
                        cbxPort.SelectedIndex = iIndex      '將combobox選擇項目選為拔除掉的下一項
                    Else
                        cbxPort.SelectedIndex = (cbxPort.Items.Count - 1)       '如果移除的combobox是最後一項則選為新的最後一項
                    End If
                End If

                If portState = Host.PortState.RemovedAndClosed Then
                    DisconnectDevice()
                End If
        End Select
    End Sub

    Private Sub BtnSetOutputInterface_Click(sender As Object, e As EventArgs) Handles btnSetOutputInterface.Click
        Dim result As Boolean
        Dim outputInterfaceSet As HashSet(Of OutputInterface) = New HashSet(Of OutputInterface)
        Dim keyboardSimulation As KeyboardSimulation

        keyboardSimulation = ComboBoxItem.GetCurrentItemValue(cbxKeyboardSimulation)

        If chkBLE.Checked Then
            outputInterfaceSet.Add(OutputInterface.BLE)
        End If
        If chkHIDVCom.Checked Then
            outputInterfaceSet.Add(OutputInterface.HIDnVCOM)
        End If
        If chkTCPClient.Checked Then
            outputInterfaceSet.Add(OutputInterface.TCP_Client)
        End If
        If chkTCPServer.Checked Then
            outputInterfaceSet.Add(OutputInterface.TCP_Server)
        End If

        result = _ts100.SetOutputInterface(False, keyboardSimulation, outputInterfaceSet)
        If result Then
            MsgBox("Set Output Interface Successful.")
        Else
            MsgBox("Set Output Interface Failed.")
        End If
    End Sub

    Private Sub btnGetOutputInterface_Click(sender As Object, e As EventArgs) Handles btnGetOutputInterface.Click
        Dim keyboard As KeyboardSimulation
        Dim outputInterfaceHashSet As HashSet(Of OutputInterface)
        chkBLE.Checked = False
        chkHIDVCom.Checked = False
        chkTCPClient.Checked = False
        chkTCPServer.Checked = False
        outputInterfaceHashSet = New HashSet(Of OutputInterface)
        _ts100.GetOutputInterface(False, keyboard, outputInterfaceHashSet)
        ComboBoxItem.SelectItemByValue(cbxKeyboardSimulation, keyboard)
        For Each outputInterface As OutputInterface In outputInterfaceHashSet
            Select Case outputInterface
                Case OutputInterface.BLE
                    chkBLE.Checked = True
                Case OutputInterface.HIDnVCOM
                    chkHIDVCom.Checked = True
                Case OutputInterface.TCP_Client
                    chkTCPClient.Checked = True
                Case OutputInterface.TCP_Server
                    chkTCPServer.Checked = True
            End Select
        Next outputInterface
    End Sub

    Private Sub BtnSetEventType_Click(sender As Object, e As EventArgs) Handles btnSetEventType.Click
        Dim eventType As EventType
        Dim result As Boolean
        eventType = ComboBoxItem.GetCurrentItemValue(cbxEventType)
        result = _ts100.SetEventType(False, eventType)
        If result Then
            MsgBox("Set Event Type Successful.")
        Else
            MsgBox("Set Event Type Failed.")
        End If
    End Sub

    Private Sub btnGetEventType_Click(sender As Object, e As EventArgs) Handles btnGetEventType.Click
        Dim eventType As EventType
        eventType = _ts100.GetEventType(False)
        ComboBoxItem.SelectItemByValue(cbxEventType, eventType)
    End Sub

    Private Sub BtnSetPresentedThreshold_Click(sender As Object, e As EventArgs) Handles btnSetTagPresentRepeatInterval.Click
        Dim param As Integer
        Dim result As Boolean
        param = nudTagPresentRepeatInterval.Value
        result = _ts100.SetTagPresentedRepeatInterval(False, param)
        If result Then
            MsgBox("Set Tag Presente Repeat Interval Successful.")
        Else
            MsgBox("Set Tag Presente Repeat Interval Failed.")
        End If
    End Sub

    Private Sub btnGetTagPresentRepeatInterval_Click(sender As Object, e As EventArgs) Handles btnGetTagPresentRepeatInterval.Click
        Dim tagPresentedRepeatInterval As Integer
        tagPresentedRepeatInterval = _ts100.GetTagPresentedRepeatInterval(False)
        nudTagPresentRepeatInterval.Value = tagPresentedRepeatInterval
    End Sub

    Private Sub BtnSetRemoveThreshold_Click(sender As Object, e As EventArgs) Handles btnSetRemoveThreshold.Click
        Dim param As Integer
        Dim result As Boolean
        param = nudTagRemoveThreshold.Value
        result = _ts100.SetTagRemovedThreshold(False, param)
        If result Then
            MsgBox("Set Tag Remove Threshold Successful.")
        Else
            MsgBox("Set Tag Remove Threshold Failed.")
        End If
    End Sub

    Private Sub btnGetRemoveThreshold_Click(sender As Object, e As EventArgs) Handles btnGetRemoveThreshold.Click
        Dim tagRemoveThreshold As Integer
        tagRemoveThreshold = _ts100.GetTagRemovedThreshold(False)
        nudTagRemoveThreshold.Value = tagRemoveThreshold
    End Sub

    Private Sub btnStartInventoryEx_Click(sender As Object, e As EventArgs) Handles btnStartInventoryEx.Click
        Dim result As Boolean
        Dim tagDataEncodeTypeSet As HashSet(Of TagDataEncodeType)
        ClearTagListView()
        tagDataEncodeTypeSet = New HashSet(Of TagDataEncodeType)
        If (chkInventoryExEANUPC.Checked) Then
            tagDataEncodeTypeSet.Add(TagDataEncodeType.EAN_UPC)
        End If
        If (chkInventoryExEANUPCEAS.Checked) Then
            tagDataEncodeTypeSet.Add(TagDataEncodeType.EAN_UPC_EAS)
        End If
        If (chkInventoryExUDC.Checked) Then
            tagDataEncodeTypeSet.Add(TagDataEncodeType.UDC)
        End If
        If (chkInventoryExRAWDATA.Checked) Then
            tagDataEncodeTypeSet.Add(TagDataEncodeType.RAW_DATA)
        End If
        result = _ts100.StartInventoryEx(tagDataEncodeTypeSet)
        If result Then
            m_bIsInventoryProcessing = True
            btnStartInventory.Enabled = False
            btnStopInventory.Enabled = True
            btnStartInventoryEx.Enabled = False
            btnStopInventoryEx.Enabled = True
        End If
    End Sub

    Private Sub btnSetInvnetoryRoundInterval_Click(sender As Object, e As EventArgs) Handles btnSetInvnetoryRoundInterval.Click
        Dim param As Integer
        Dim result As Boolean
        param = nudInventoryRoundInterval.Value
        result = _ts100.SetInventoryRoundInterval(False, param)
        If result Then
            MsgBox("Set Inventory Round Interval Successful.")
        Else
            MsgBox("Set Inventory Round Interval Failed.")
        End If
    End Sub

    Private Sub btnGetInvnetoryRoundInterval_Click(sender As Object, e As EventArgs) Handles btnGetInvnetoryRoundInterval.Click
        Dim inventoryRoundInterval As Integer
        inventoryRoundInterval = _ts100.GetInventoryRoundInterval(False)
        nudInventoryRoundInterval.Value = inventoryRoundInterval
    End Sub

    Private Sub btnLockTag_Click(sender As Object, e As EventArgs) Handles btnLockTag.Click
        Dim result As Boolean
        Dim lockInfos As New Dictionary(Of MemoryBank, LockAction)
        Dim bank As MemoryBank
        Dim action As LockAction
        Dim password As String
        password = Trim(tbLockAccessPassword.Text)
        bank = ComboBoxItem.GetCurrentItemValue(cbxLockBank)
        action = ComboBoxItem.GetCurrentItemValue(cbxLockAction)
        lockInfos.Add(bank, action)
        If password.Length > 0 Then
            result = _ts100.LockTag(password, lockInfos)
        Else
            result = _ts100.LockTag(lockInfos)
        End If
        If result Then
            MsgBox("Lock Tag Successful.")
        Else
            MsgBox("Lock Tag Failed.")
        End If
    End Sub
    Private Sub btnKillTag_Click(sender As Object, e As EventArgs) Handles btnKillTag.Click
        Dim result As Boolean
        Dim accessPassword As String
        Dim killPassword As String
        accessPassword = Trim(tbKillAccessPassword.Text)
        killPassword = Trim(tbKillPassword.Text)
        If accessPassword.Length > 0 Then
            result = _ts100.KillTag(accessPassword, killPassword)
        Else
            result = _ts100.KillTag(accessPassword)
        End If
        If result Then
            MsgBox("Kill Tag Successful.")
        Else
            MsgBox("Kill Tag Failed.")
        End If
    End Sub

    Private Sub btnSetActiveMode_Click(sender As Object, e As EventArgs) Handles btnSetActiveMode.Click
        Dim activeMode As ActiveMode
        Dim result As Boolean
        activeMode = ComboBoxItem.GetCurrentItemValue(cbxActiveMode)
        result = _ts100.SetInventoryActiveMode(False, activeMode)
        If result Then
            MsgBox("Set Inventory Active Mode Successful.")
        Else
            MsgBox("Set Inventory Active Mode Failed.")
        End If
    End Sub

    Private Sub btnGetActiveMode_Click(sender As Object, e As EventArgs) Handles btnGetActiveMode.Click
        Dim inventoryActiveMode As ActiveMode
        inventoryActiveMode = _ts100.GetInventoryActiveMode(False)
        ComboBoxItem.SelectItemByValue(cbxActiveMode, inventoryActiveMode)
    End Sub

    Private Sub btnSetCommandTriggerState_Click(sender As Object, e As EventArgs) Handles btnSetCommandTriggerState.Click
        'Dim result As Boolean
        'Dim param As Integer
        'param = ComboBoxItem.GetCurrentItemValue(cbxCommandTriggerState)
        'result = _ts100.SetCommandTriggerState(param)
        'If result Then
        '    MsgBox("Set Command Trigger State Successful.")
        'Else
        '    MsgBox("Set Command Trigger State  Failed.")
        'End If
    End Sub

    Private Sub btnGetCommandTriggerState_Click(sender As Object, e As EventArgs) Handles btnGetCommandTriggerState.Click
        'Dim state As State
        'state = _ts100.GetCommandTriggerState()
        'ComboBoxItem.SelectItemByValue(cbxCommandTriggerState, state)
    End Sub

    Private Sub btnSetScanMode_Click(sender As Object, e As EventArgs) Handles btnSetScanMode.Click
        'Dim result As Boolean
        'Dim scanMode As TS800.ScanMode
        'scanMode = ComboBoxItem.GetCurrentItemValue(cbxScanMode)
        'result = _ts100.SetScanMode(False, scanMode)
        'If result Then
        '    MsgBox("Set Scan Mode Successful.")
        'Else
        '    MsgBox("Set Scan Mode Failed.")
        'End If
    End Sub

    Private Sub btnGetScanMode_Click(sender As Object, e As EventArgs) Handles btnGetScanMode.Click
        'Dim scanMode As TS800.ScanMode
        'scanMode = _ts100.GetScanMode(False)
        'ComboBoxItem.SelectItemByValue(cbxScanMode, scanMode)
    End Sub

    Private Sub btnSetBLEName_Click(sender As Object, e As EventArgs) Handles btnSetBLEName.Click
        Dim name As String
        Dim result As Boolean
        name = tbBLEDeviceName.Text
        result = _ts100.SetBleDeviceName(name)
        If result Then
            MsgBox("Set BLE Device Name Successful.")
        Else
            MsgBox("Set BLE Device Name Failed.")
        End If
    End Sub

    Private Sub btnGetBLEName_Click(sender As Object, e As EventArgs) Handles btnGetBLEName.Click
        Dim name As String
        name = _ts100.GetBleDeviceName
        If name IsNot Nothing Then
            tbBLEDeviceName.Text = name
        Else
            MsgBox("Get BLE Device Name Failed.")
        End If
    End Sub

    Private Sub frmTS100Sample_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If m_bIsInventoryProcessing Then
            e.Handled = True
        End If
    End Sub

End Class