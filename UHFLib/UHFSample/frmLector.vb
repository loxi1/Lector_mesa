Imports System.IO
Imports com.gigatms
Imports com.gigatms.Parameters

Public Class frmLector
    Private Const TIME_OUT As Integer = 3
    Private Const RETRY_TIMES As Integer = 3

    Private WithEvents _host As Host
    Private WithEvents _ts800 As TS800 = Nothing

    Private _settingsList As New List(Of String)
    Private _title As String = My.Application.Info.Title
    Private _tagList As List(Of String)
    Private _FrequencyItems As List(Of CheckBox)
    Dim enterPressed As Boolean = False ' Bandera para evitar ejecuciones múltiples
    Dim m_BDPrenda As New BDPrenda()

    Private Sub frmInitial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "TS800 Sample" & " V" &
                    My.Application.Info.Version.Major & "." &
                    My.Application.Info.Version.Minor & "R" &
                    My.Application.Info.Version.Revision

        _host = New Host()
        _ts800 = New TS800(TIME_OUT, RETRY_TIMES)
        lblSdkVersion.Text = "SDK Version: " & _ts800.SdkVersion
        RefreshPortList(GetSetting(_title, "Comm", "LastCommPort", "Auto"))
        _tagList = New List(Of String)

        tpPerformance.Visible = False

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
        'Don't display this setting because TS800 does not support this function 

        With cbxInventory.Items
            .Clear()
            .Add(New ComboBoxItem(True, TagPresentedType.PC_EPC, "EPC"))
            .Add(New ComboBoxItem(TagPresentedType.PC_EPC_TID, "EPC + TID"))
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

        iCount = oPortList.Count
        For I = 0 To (iCount - 1)
            With _ts800
                If .IsConnected Then
                    .Disconnect()
                End If
                .DeviceAddress = 0  '0 = no specify device ID
                oPort = oPortList(I)
                szPort = oPort.ToString()
                bResult = False
                If .Connect(szPort, szBaudrate) Then
                    Dim szFirmware As String
                    _ts800.StopInventory()
                    szFirmware = _ts800.GetFirmwareVersion
                    lblRomVersion.Text = "ROM Version: " & szFirmware
                    Try
                        cbxPort.SelectedItem = oPort
                    Catch ex As Exception
                        Debug.Print("Set CommPort Error: " & ex.ToString())
                    End Try
                    bResult = True
                    Exit For
                ElseIf .IsOpenPortError Then
                    Exit For
                End If
                If bResult Then
                    Exit For
                ElseIf .IsConnected Then
                    MsgBox("Connect Failed! (" & szPort & ")")
                    .Disconnect()
                Else
                    MsgBox("Open Port Failed! (" & szPort & ")")
                End If
            End With
        Next I

        If bResult = True Then
            cbxPort.Enabled = False
            cbxBaudrate.Enabled = False
            TabControl.Enabled = True
            btnWifiSetting.Enabled = True
            btnConnect.Text = "Desconectar"
            MessageBox.Show("Conexión exitosa al reader.", "Resultado de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        _host.NetDeviceSearcherEnabled = True
        Me.Cursor = cursor
    End Sub

    Private Sub DisconnectDevice()
        With _ts800
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
            Case "Conectar"
                ConnectDevice()
            Case "Desconectar"
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
            oWiFiSettings.ShowWiFiSettings(_ts800)
        End Using
    End Sub

    Private Sub changeDisconnectionStatus()
        cbxBaudrate.Enabled = True
        cbxPort.Enabled = True
        btnWifiSetting.Enabled = False
        TabControl.Enabled = False
        btnConnect.Text = "Conectar"
        lblRomVersion.Text = "ROM Versión: "
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
        result = _ts800.StartInventory(tagPresetnedType)
        If result Then
            m_bIsInventoryProcessing = True
            btnStartInventory.Enabled = False
            btnStopInventory.Enabled = True
        End If
    End Sub

    Private Sub btnStopInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopInventory.Click
        Dim result As Boolean
        result = _ts800.StopInventory()
        If result Then
            m_bIsInventoryProcessing = False
            btnStartInventory.Enabled = True
            btnStopInventory.Enabled = False
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

    Private Sub _ts80O_OnTagPresented(ByVal sender As Object, ByVal tagInformation As TagInformationFormat) Handles _ts800.OnTagPresented
        Dim oRow As DataGridViewRow
        Dim iRowIndex As Integer
        Dim szPCEPC As String = tagInformation.PcEpcHex
        Dim szTID As String = tagInformation.TidHex

        iRowIndex = _tagList.IndexOf(szPCEPC)
        If iRowIndex <> -1 Then
            oRow = dgvTagList.Rows(iRowIndex)
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

    'Private Sub _ts800_OnTagPresentedEx(sender As Object, tagDecodeInformation As DecodedTagData) Handles _ts800.OnTagPresentedEx
    '    Dim oRow As DataGridViewRow
    '    Dim iRowIndex As Integer
    '    Dim szPCEPC As String
    '    Dim szTID As String

    '    For Each oData In tagDecodeInformation.Data
    '        Select Case oData.OutputDataType
    '            Case oData.DataType.TagData_PC_EPC, oData.DataType.TagData_EPC
    '                szPCEPC = oData.ToString
    '        End Select
    '    Next oData
    '    szTID = tagDecodeInformation.TID.ToHexString

    '    iRowIndex = _tagList.IndexOf(szPCEPC)
    '    If iRowIndex <> -1 Then
    '        oRow = dgvTagList.Rows(iRowIndex)
    '        oRow.Cells(2).Value = oRow.Cells(2).Value + 1
    '    Else
    '        _tagList.Add(szPCEPC)
    '        iRowIndex = dgvTagList.Rows.Add()
    '        oRow = dgvTagList.Rows(iRowIndex)
    '        oRow.Cells(0).Value = szPCEPC
    '        oRow.Cells(1).Value = szTID
    '        oRow.Cells(2).Value = 1
    '        CountTags()
    '    End If
    'End Sub

    Private Sub btnGetIO_State_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim resultMessage As String = ""
        Dim state As String = ""
        Dim stateOutputPin0 As IOState
        Dim stateOutputPin1 As IOState
        Dim stateOutputPin2 As IOState
        If (_ts800.GetIOState) Then
            stateOutputPin0 = _ts800.OutputPin0State
            stateOutputPin1 = _ts800.OutputPin1State
            stateOutputPin2 = _ts800.OutputPin2State
            If stateOutputPin0 = IOState.High Then
                state = "High"
            Else
                state = "Low"
            End If
            resultMessage = "Output Pin 0 is " & state

            If stateOutputPin1 = IOState.High Then
                state = "High"
            Else
                state = "Low"
            End If
            resultMessage = resultMessage & vbCrLf & "Output Pin 1 is " & state

            If stateOutputPin2 = IOState.High Then
                state = "High"
            Else
                state = "Low"
            End If
            resultMessage = resultMessage & vbCrLf & "Output Pin 2 is " & state
            MsgBox(resultMessage)
        Else
            MsgBox("Get Light State Failed.")
        End If
    End Sub

    Private Sub updateInputState()
        Dim state As IOState
        state = _ts800.InputPin0State
    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bResult As Byte() = Nothing
        Dim szPassword As String
        Dim memoryBank As MemoryBank
        Dim iNudStart As Integer
        Dim iNudLength As Integer

        bResult = _ts800.ReadTag(szPassword, memoryBank, iNudStart, iNudLength)

        If bResult IsNot Nothing Then
            Dim szReadData As String = ""
            For I = 0 To (bResult.Length - 1)
                szReadData = szReadData & bResult(I).ToString("X02") & ""
            Next I
        Else
            MsgBox("Read Specified Memory Bank Failed.")
        End If
    End Sub

    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim writeDataByte As Byte()
        Dim szPassword As String
        Dim iNudStart As Integer
        Dim memoryBank As MemoryBank
        Dim bResult As Boolean = False
        Dim szData As String

        writeDataByte = HexStringToByteArray(szData)
        bResult = _ts800.WriteTag(UHF.DEFAULT_PASSWORD, memoryBank, iNudStart, writeDataByte)
        If bResult Then
            MsgBox("Write Successful.")
        Else
            MsgBox("Write Failed.")
        End If
    End Sub

    Private Sub btnWriteEPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub cbWriteMemoryBank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBuzzerControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSetDelimiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim delimiterValue As New HashSet(Of PostDataDelimiter)
        'Dim result As Boolean
        'If chkDelimiterCR.Checked Then
        '    delimiterValue.Add(PostDataDelimiter.Carriage)
        'End If
        'If chkDelimiterLine.Checked Then
        '    delimiterValue.Add(PostDataDelimiter.Line)
        'End If
        'If chkDelimiterTab.Checked Then
        '    delimiterValue.Add(PostDataDelimiter.TAB)
        'End If
        'result = _ts800.SetPostDataDelimiter(False, delimiterValue)
        'If result Then
        '    MsgBox("Set Post Data Delimiter Successful.")
        'Else
        '    MsgBox("Set Post Data Delimiter Failed.")
        'End If
    End Sub

    Private Sub btnGetDelimiter_Click(sender As Object, e As EventArgs)
        'Dim postDelimiterSet As HashSet(Of PostDataDelimiter)
        'postDelimiterSet = _ts800.GetPostDataDelimiter(False)
        'chkDelimiterCR.Checked = False
        'chkDelimiterLine.Checked = False
        'chkDelimiterTab.Checked = False
        'For Each delimiter As PostDataDelimiter In postDelimiterSet
        '    Select Case delimiter
        '        Case PostDataDelimiter.Carriage
        '            chkDelimiterCR.Checked = True
        '        Case PostDataDelimiter.Line
        '            chkDelimiterLine.Checked = True
        '        Case PostDataDelimiter.TAB
        '            chkDelimiterTab.Checked = True
        '    End Select
        'Next delimiter
    End Sub

    Private Sub btnSetFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim encodeTypeSet As HashSet(Of TagDataEncodeType)
        'Dim result As Boolean
        'encodeTypeSet = New HashSet(Of TagDataEncodeType)
        'If (chkUdc.Checked) Then
        '    encodeTypeSet.Add(TagDataEncodeType.UDC)
        'End If
        'If (chkEanUpc.Checked) Then
        '    encodeTypeSet.Add(TagDataEncodeType.EAN_UPC)
        'End If
        'If (chkEanUpcEas.Checked) Then
        '    encodeTypeSet.Add(TagDataEncodeType.EAN_UPC_EAS)
        'End If
        'If (chkRawData.Checked) Then
        '    encodeTypeSet.Add(TagDataEncodeType.RAW_DATA)
        'End If
        'result = _ts100.SetFilter(False, encodeTypeSet)
        'If result Then
        '    MsgBox("Set Filter Successful.")
        'Else
        '    MsgBox("Set Filter Failed.")
        'End If
    End Sub

    Private Sub btnGetFilter_Click(sender As Object, e As EventArgs)
        'Dim encoeFilterSet As HashSet(Of TagDataEncodeType)
        'chkUdc.Checked = False
        'chkEanUpc.Checked = False
        'chkEanUpcEas.Checked = False
        'chkRawData.Checked = False
        'encoeFilterSet = _ts800.GetFilter(False)
        'For Each decodedType As TagDataEncodeType In encoeFilterSet
        '    Select Case decodedType
        '        Case TagDataEncodeType.UDC
        '            chkUdc.Checked = True
        '        Case TagDataEncodeType.EAN_UPC
        '            chkEanUpc.Checked = True
        '        Case TagDataEncodeType.EAN_UPC_EAS
        '            chkEanUpcEas.Checked = True
        '        Case TagDataEncodeType.RAW_DATA
        '            chkRawData.Checked = True
        '    End Select
        'Next decodedType
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

        If (_ts800.GetIOState) Then
            updateInputState()
        End If

        cbxInventory.SelectedIndex = 0


        tabControl.SelectedTab = tpInventory

    End Sub

    Private Sub btnSetRfPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetRfPower.Click
        Dim power As Integer
        Dim result As Boolean = False
        power = tbRfPower.Value
        result = _ts800.SetRfPower(False, power)
        If result Then
            MsgBox("Set RF Power Successful.")
        Else
            MsgBox("Set RF Power Failed.")
        End If
    End Sub

    Private Sub btnGetRfPower_Click(sender As Object, e As EventArgs) Handles btnGetRfPower.Click
        Dim power As Integer
        power = _ts800.GetRfPower(False)
        tbRfPower.Value = power
    End Sub

    Private Sub tbRfPower_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRfPower.ValueChanged
        lblRfPower.Text = tbRfPower.Value & " dBm"
    End Sub

    Private Sub btnSetFrequency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetFrequency.Click
        Dim frequencySet As HashSet(Of Double) = New HashSet(Of Double)
        For Each oControl In gbFrequency.Controls
        Next oControl
        If frequencySet.Count > 0 Then
            If (_ts800.SetFrequency(False, frequencySet)) Then
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
        frequencySet = _ts800.GetFrequency(False)
    End Sub

    Private Sub btnSetBuzzerOperationMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim buzzerOperationMode As BuzzerOperationMode
        Dim result As Boolean
        result = _ts800.SetBuzzerOperationMode(False, buzzerOperationMode)
        If result Then
            MsgBox("Set Buzzer Operation Mode Successful.")
        Else
            MsgBox("Set Buzzer Operation Mode Failed.")
        End If
    End Sub

    Private Sub btnGetBuzzerOperationMode_Click(sender As Object, e As EventArgs)
        Dim buzzerOperationMode As BuzzerOperationMode
        buzzerOperationMode = _ts800.GetBuzzerOperationMode(False)
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
        result = _ts800.SetRfSensitivity(False, rfSensitivityValue)
        If result Then
            MsgBox("Set RF Sensitivity Successful.")
        Else
            MsgBox("Set RF Sensitivity Failed.")
        End If
    End Sub

    Private Sub btnGetRfSensitivity_Click(sender As Object, e As EventArgs) Handles btnGetRfSensitivity.Click
        Dim sensitivity As Integer
        sensitivity = _ts800.GetRfSensitivity(False)
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
        result = _ts800.SetRxDecode(False, rxDecodeValue)
        If result Then
            MsgBox("Set RX Decode Successful.")
        Else
            MsgBox("Set RX Decode Failed.")
        End If
    End Sub

    Private Sub btnGetRxDecode_Click(sender As Object, e As EventArgs) Handles btnGetRxDecode.Click
        Dim rxDecodeValue As RxDecodeType = RxDecodeType.Miller_4
        rxDecodeValue = _ts800.GetRxDecode(False)
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
        result = _ts800.SetLinkFrequency(False, linkFrequencyValue)
        If result Then
            MsgBox("Set Link Frequency Successful.")
        Else
            MsgBox("Set Link Frequency Failed.")
        End If
    End Sub

    Private Sub btnGetLinkFrequency_Click(sender As Object, e As EventArgs) Handles btnGetLinkFrequency.Click
        Dim linkFrequencyValue As LinkFrequencyType = LinkFrequencyType.LF_256kHz
        linkFrequencyValue = _ts800.GetLinkFrequency(False)
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

    Private Sub btnSetTriggerType_Click(sender As Object, e As EventArgs)
        Dim result As Boolean
        Dim triggerTypes As New HashSet(Of TriggerType)

        result = _ts800.SetTriggerType(False, triggerTypes)
        If result Then
            MsgBox("Set TriggerType Successful.")
        Else
            MsgBox("Set TriggerType Failed.")
        End If
    End Sub

    Private Sub btnGetTriggerType_Click(sender As Object, e As EventArgs)
        Dim triggerTypes As New HashSet(Of TriggerType)
        triggerTypes = _ts800.GetTriggerType(False)

    End Sub

    Private Sub _uhf_OnErrorOccurred(errorCode As ErrorCode, errorMessage As String) Handles _ts800.OnErrorOccurred
        Debug.Print("errorCode: " & errorCode & vbTab & "errorMessage: " & errorMessage)
    End Sub
    Private Sub cbxSession_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim session As Session
        Dim index As Integer

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

    Private Sub btnSetQValue_Click(sender As Object, e As EventArgs)
        Dim result As Boolean = False
        Dim qValue As Integer
    End Sub


    Private Sub btnGetQValue_Click(sender As Object, e As EventArgs)
        Dim qValue As Integer
        qValue = _ts800.GetQValue(False)
    End Sub

    Private Sub btnSetSessionTarget_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGetSessionTarget_Click(sender As Object, e As EventArgs)
        Dim session As Session
        Dim target As Target
        _ts800.GetSessionAndTarget(False, session, target)
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
                        If (_ts800 IsNot Nothing) AndAlso (_ts800.IsConnected = False) Then
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

    Private Sub BtnSetEventType_Click(sender As Object, e As EventArgs)
        'Dim eventType As EventType
        'Dim result As Boolean
        'eventType = ComboBoxItem.GetCurrentItemValue(cbxEventType)
        'result = _ts800.SetEventType(False, eventType)
        'If result Then
        '    MsgBox("Set Event Type Successful.")
        'Else
        '    MsgBox("Set Event Type Failed.")
        'End If
    End Sub

    Private Sub btnGetEventType_Click(sender As Object, e As EventArgs)
        'Dim eventType As EventType
        'eventType = _ts800.GetEventType(False)
        'ComboBoxItem.SelectItemByValue(cbxEventType, eventType)
    End Sub

    Private Sub btnGetTagPresentRepeatInterval_Click(sender As Object, e As EventArgs) Handles btnGetTagPresentRepeatInterval.Click
        Dim tagPresentedRepeatInterval As Integer
        tagPresentedRepeatInterval = _ts800.GetTagPresentedRepeatInterval(False)
        nudTagPresentRepeatInterval.Value = tagPresentedRepeatInterval
    End Sub

    Private Sub btnGetRemoveThreshold_Click(sender As Object, e As EventArgs) Handles btnGetRemoveThreshold.Click
        Dim tagRemoveThreshold As Integer
        tagRemoveThreshold = _ts800.GetTagRemovedThreshold(False)
        nudTagRemoveThreshold.Value = tagRemoveThreshold
    End Sub

    Private Sub BtnSetMemoryBankSelection_Click(sender As Object, e As EventArgs)
        'Dim memoryBankSet As New HashSet(Of MemoryBankSelection)
        'Dim result As Boolean
        'If chkBankPC.Checked Then
        '    memoryBankSet.Add(MemoryBankSelection.PC)
        'End If
        'If chkBankEPC.Checked Then
        '    memoryBankSet.Add(MemoryBankSelection.EPC)
        'End If
        'If chkBankTID.Checked Then
        '    memoryBankSet.Add(MemoryBankSelection.TID)
        'End If
        'If chkBankUser.Checked Then
        '    memoryBankSet.Add(MemoryBankSelection.USER)
        'End If
        'If chkBankEPCASCII.Checked Then
        '    memoryBankSet.Add(MemoryBankSelection.EPC_ASCII)
        'End If
        'result = _ts100.SetMemoryBankSelection(False, memoryBankSet)
        'If result Then
        '    MsgBox("Set Memory Bank Selection Successful.")
        'Else
        '    MsgBox("Set Memory Bank Selection Failed.")
        'End If
    End Sub

    Private Sub btnGetMemoryBankSelection_Click(sender As Object, e As EventArgs)
        'Dim memoryBankSet As HashSet(Of MemoryBankSelection)
        'memoryBankSet = _ts100.GetMemoryBankSelection(False)
        'chkBankPC.Checked = False
        'chkBankEPC.Checked = False
        'chkBankTID.Checked = False
        'chkBankUser.Checked = False
        'chkBankEPCASCII.Checked = False
        'For Each memoryBank As MemoryBankSelection In memoryBankSet
        '    Select Case memoryBank
        '        Case MemoryBankSelection.PC
        '            chkBankPC.Checked = True
        '        Case MemoryBankSelection.EPC
        '            chkBankEPC.Checked = True
        '        Case MemoryBankSelection.TID
        '            chkBankTID.Checked = True
        '        Case MemoryBankSelection.USER
        '            chkBankUser.Checked = True
        '        Case MemoryBankSelection.EPC_ASCII
        '            chkBankEPCASCII.Checked = True
        '    End Select
        'Next memoryBank
    End Sub

    Private Sub btnGetInvnetoryRoundInterval_Click(sender As Object, e As EventArgs) Handles btnGetInvnetoryRoundInterval.Click
        Dim inventoryRoundInterval As Integer
        inventoryRoundInterval = _ts800.GetInventoryRoundInterval(False)
        nudInventoryRoundInterval.Value = inventoryRoundInterval
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        Dim selectedTab As TabPage = tabControl.SelectedTab
        If selectedTab.Name = "tpInventory" Then
            CodBarras.Focus()
        End If
    End Sub
    Private Sub LeerCodigoRFID()
        ' Implementa aquí la funcionalidad del lector RFID
        Debug.Print("Se ejecuta LeerCodigoRFID")
        btnStartInventory.PerformClick()
        btnStopInventory.PerformClick()
        ' Recorrer todas las filas del DataGridView y mostrar valores
        ' Mostrar los valores de _tagList en la ventana de depuración
        Dim primerCodigoRFID As String = ""
        If _tagList.Count > 0 Then
            primerCodigoRFID = ProcesarCodigoRFID(_tagList(0))
        End If

        Dim codigoBarras As String = CodBarras.Text
        Debug.Print($"Codigo de barras {codigoBarras} RFID --> {primerCodigoRFID}")
        CodBarras.Text = "" ' Limpiar el campo
        CodBarras.Focus()   ' Mantener el foco en el control
    End Sub

    Private Sub CodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles CodBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            Debug.Print("Se ejecuta el enter (KeyDown)")
            LeerCodigoRFID()         ' Llama a la función directamente
            e.SuppressKeyPress = True ' Evita el evento KeyPress
            e.Handled = True          ' Detiene el comportamiento predeterminado
        End If
    End Sub

    Private Sub CodBarras_KeyUp(sender As Object, e As KeyEventArgs) Handles CodBarras.KeyUp
        ' No es necesario ejecutar nada en KeyUp
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
        End If
    End Sub
    Private Function ProcesarCodigoRFID(codigo As String) As String
        ' Verifica si el código comienza con "3000" y lo elimina
        If codigo.StartsWith("3000") Then
            codigo = codigo.Substring(4) ' Elimina los primeros 4 caracteres (3000)
        End If

        ' Verifica si el código tiene exactamente 24 caracteres
        If codigo.Length = 24 Then
            Return codigo ' Devuelve el código corregido
        Else
            Debug.Print("El código RFID no es válido: " & codigo)
            Return String.Empty ' Devuelve cadena vacía si no es válido
        End If
    End Function

End Class
