Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports com.gigatms
Imports com.gigatms.Parameters
Imports System.Collections.Concurrent
Imports System.Threading.Tasks

Public Class frmLector
    Private Const TIME_OUT As Integer = 3
    Private Const RETRY_TIMES As Integer = 3

    Private WithEvents _host As Host
    Private WithEvents _ts800 As TS800 = Nothing

    Private _settingsList As New List(Of String)
    Private _title As String = My.Application.Info.Title
    Private _tagList As List(Of String)
    Private _FrequencyItems As List(Of CheckBox)
    Private mEmpresa As String = "COFACO"
    Private mCodTrabajador As String
    Private mUsuTrabajador As String
    Dim enterPressed As Boolean = False ' Bandera para evitar ejecuciones múltiples
    Dim m_BDPrenda As New BDPrenda()
    Dim m_BDPrendaScm As New BDPrendaScm()
    Dim m_DBConsultarPrenda As New DBConsultarPrenda()
    Private _tieneRFID As Boolean = False

    ' Cola concurrente para almacenar los valores de CodBarras
    Private CodBarrasQueue As New ConcurrentQueue(Of String)()
    Private IsProcessingQueue As Boolean = False

    Public Sub New(codTrabajador As String, datoUsuario As String)
        ' Llamar al InitializeComponent para inicializar los componentes del formulario
        InitializeComponent()

        ' Asignar valores a propiedades privadas
        mCodTrabajador = codTrabajador
        mUsuTrabajador = datoUsuario

        ' Configurar el título del formulario con los datos recibidos
        Me.Text = $"Vincular - Usuario: {mUsuTrabajador} - Trabajador: {mCodTrabajador}"
    End Sub

    Private Sub frmInitial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DeshabilitarControles(tpInventory, False) ' Desactivar "tpInventory"
        'tabControl.TabPages.Remove(tpPapper)
        Me.Text = "TS800 Sample" & " V" &
                    My.Application.Info.Version.Major & "." &
                    My.Application.Info.Version.Minor & "R" &
                    My.Application.Info.Version.Revision
        ' Configurar el TabControl para dibujar las pestañas con fuente personalizada
        Me.tabControl.DrawMode = TabDrawMode.OwnerDrawFixed
        AddHandler Me.tabControl.DrawItem, AddressOf TabControl_DrawItem

        ' Ajustar automáticamente el tamaño de las pestañas según el texto
        Me.tabControl.SizeMode = TabSizeMode.Fixed
        AdjustTabWidth()

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

        With cbxScanMode.Items
            .Clear()
            .Add(New ComboBoxItem(True, TS800.ScanMode.AlwaysScan, "Escanear siempre"))
            .Add(New ComboBoxItem(TS800.ScanMode.Trigger_A_LevelControl, "Activar un control de nivel"))
        End With

        With cbxActiveMode.Items
            .Clear()
            .Add(New ComboBoxItem(True, ActiveMode.READ, "Read"))
            .Add(New ComboBoxItem(False, ActiveMode.COMMAND, "Command"))
        End With

        'CodBarras.Text = ""
        tabControl.Enabled = False
        _FrequencyItems = New List(Of CheckBox)
        _host.NetDeviceSearcherEnabled = True

        ' Concatenar los datos al título de la ventana
        Me.Text = $"Vincular - Usuario: {mUsuTrabajador} - Trabajador: {mCodTrabajador}"

        ConfigurarEstiloDataGridView(DataGridView1)
        ConfigurarEstiloDataGridView(DataGridView2)
        ConfigurarEstiloDataGridView(DataGridView3)
    End Sub

    Private Sub AdjustTabWidth()
        ' Ajustar el ancho de cada pestaña basado en el texto
        Using g As Graphics = Me.tabControl.CreateGraphics()
            Dim font As New Font("Microsoft Sans Serif", 15.0F, FontStyle.Regular)
            Dim maxTabWidth As Integer = 0

            For i As Integer = 0 To Me.tabControl.TabPages.Count - 1
                ' Medir el ancho del texto de la pestaña
                Dim tabTextSize As SizeF = g.MeasureString(Me.tabControl.TabPages(i).Text, font)
                maxTabWidth = Math.Max(maxTabWidth, CInt(tabTextSize.Width) + 20) ' Margen adicional
            Next

            ' Ajustar el ancho de las pestañas
            Me.tabControl.ItemSize = New Size(maxTabWidth, Me.tabControl.ItemSize.Height)
        End Using
    End Sub
    Private Sub TabControl_DrawItem(sender As Object, e As DrawItemEventArgs)
        Dim g As Graphics = e.Graphics
        Dim tabPage As TabPage = Me.tabControl.TabPages(e.Index)
        Dim tabBounds As Rectangle = Me.tabControl.GetTabRect(e.Index)

        ' Fuente personalizada para las pestañas
        Dim tabFont As New Font("Microsoft Sans Serif", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        ' Determinar el color del texto
        Dim textColor As Color = SystemColors.ControlText


        ' Verificar si la pestaña está seleccionada
        If e.Index = tabControl.SelectedIndex Then
            ' Pestaña seleccionada: Fondo destacado
            g.FillRectangle(Brushes.MediumSeaGreen, tabBounds)
            ' Dibujar una sublínea en la parte inferior
            g.DrawLine(Pens.White, tabBounds.Left, tabBounds.Bottom - 2, tabBounds.Right, tabBounds.Bottom - 2)
            'Dibujar el texto con color blanco
            textColor = Color.White
        Else
            ' Pestaña no seleccionada: Fondo estándar
            g.FillRectangle(Brushes.White, tabBounds)
        End If

        ' Dibujar el texto de la pestaña con alineación centrada
        TextRenderer.DrawText(g, tabPage.Text, tabFont, tabBounds, textColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
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
                        Console.WriteLine("Set CommPort Error: " & ex.ToString())
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
            tabControl.Enabled = True
            btnWifiSetting.Enabled = True
            btnConnect.Text = "Desconectar"
            ObtenerInvActivo()
            SaveInvActivo()
            AlertaOk("Conexion", Color.FromArgb(16, 175, 76), 30, "Exitosa al reader.")
        End If
        _host.NetDeviceSearcherEnabled = True
        Me.Cursor = cursor
    End Sub

    Private Sub DisconnectDevice()
        Console.WriteLine($"este es el elmento _ts800 <-->{_ts800}")
        With _ts800
            Console.WriteLine($"Estaddo IsConnected<-->{ .IsConnected}")
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
        Console.WriteLine($"Nombre text {btnConnect.Text}")
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
                Console.WriteLine("RefreshPortList: " & ex.ToString())
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
        tabControl.Enabled = False
        btnConnect.Text = "Conectar"
        lblRomVersion.Text = "ROM Versión: "
    End Sub

    Private m_bIsInventoryProcessing As Boolean
    Private Sub btnStartInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StartInventory()
        Console.WriteLine($"Codigo RFID-->{ObtenerPCEPC()}")
    End Sub

    Private Sub StartInventory()
        Dim result As Boolean
        Dim tagPresentedType As TagPresentedType = ComboBoxItem.GetCurrentItemValue(cbxInventory)
        ClearTagListView()
        Select Case tagPresentedType
            Case TagPresentedType.PC_EPC
                dgvTagList.Columns.Item(1).Visible = False
            Case TagPresentedType.PC_EPC_TID
                dgvTagList.Columns.Item(1).Visible = True
        End Select
        result = _ts800.StartInventory(tagPresentedType)
        If result Then
            m_bIsInventoryProcessing = True
            'btnStartInventory.Enabled = False
            'btnStopInventory.Enabled = True
        End If
    End Sub

    Private Sub btnStopInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StopInventory()
    End Sub

    Private Sub StopInventory()
        Dim result As Boolean = _ts800.StopInventory()
        If result Then
            m_bIsInventoryProcessing = False
            'btnStartInventory.Enabled = True
            'btnStopInventory.Enabled = False
        End If
    End Sub

    Private Sub ClearTagListView()
        dgvTagList.Rows.Clear()
        _tagList.Clear()
        'CountTags()
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
            'CountTags()
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

        ' Configurar la pestaña de inventario
        tabControl.SelectedTab = tpInventory
    End Sub

    Private Sub btnSetRfPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnGetRfPower_Click(sender As Object, e As EventArgs)
        Dim power As Integer
        power = _ts800.GetRfPower(False)
        tbRfPower.Value = power
    End Sub

    Private Sub tbRfPower_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblRfPower.Text = tbRfPower.Value & " dBm"
    End Sub

    Private Sub btnSetFrequency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frequencySet As HashSet(Of Double) = New HashSet(Of Double)
        If frequencySet.Count > 0 Then
            If (_ts800.SetFrequency(False, frequencySet)) Then
                MsgBox("Set Frequency Successful.")
            End If
        Else
            MsgBox("Please check the frequency you want to set.")
        End If
    End Sub

    Private Sub btnGetFrequency_Click(sender As Object, e As EventArgs)
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

    Private Sub tbRfSensitivity_ValueChanged(sender As Object, e As EventArgs)
        lblRfSensitivity.Text = "Level " & tbRfSensitivity.Value
    End Sub

    Private Sub btnSetRfSensitivity_Click(sender As Object, e As EventArgs)
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

    Private Sub btnGetRfSensitivity_Click(sender As Object, e As EventArgs)
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

    Private Sub btnSetRxDecode_Click(sender As Object, e As EventArgs)
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

    Private Sub btnGetRxDecode_Click(sender As Object, e As EventArgs)
        Dim rxDecodeValue As RxDecodeType = RxDecodeType.Miller_4
        rxDecodeValue = _ts800.GetRxDecode(False)
        cbxRxDecode.SelectedIndex = rxDecodeValue
    End Sub

    Private Sub btnSetLinkFrequency_Click(sender As Object, e As EventArgs)
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

    Private Sub btnGetLinkFrequency_Click(sender As Object, e As EventArgs)
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

    Private Sub _uhf_OnErrorOccurred(errorCode As ErrorCode, errorMessage As String) Handles _ts800.OnErrorOccurred
        Console.WriteLine("errorCode: " & errorCode & vbTab & "errorMessage: " & errorMessage)
    End Sub
    Private Sub cbxSession_SelectedIndexChanged(sender As Object, e As EventArgs)

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
                If (iIndex = -1) Then       '-1 significa que aún no está en -comboBox-
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
                If iIndex <> -1 Then    'El puerto existe en -combobox-
                    cbxPort.Items.RemoveAt(iIndex)
                    If iIndex < cbxPort.Items.Count Then
                        cbxPort.SelectedIndex = iIndex      'Seleccione el elemento -combobox-selected como el siguiente elemento para desconectar
                    Else
                        cbxPort.SelectedIndex = (cbxPort.Items.Count - 1)       'Si el -combobox- eliminado es el último elemento, seleccione el nuevo último elemento
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

    Private Sub btnGetTagPresentRepeatInterval_Click(sender As Object, e As EventArgs)
        Dim tagPresentedRepeatInterval As Integer
        tagPresentedRepeatInterval = _ts800.GetTagPresentedRepeatInterval(False)
        nudTagPresentRepeatInterval.Value = tagPresentedRepeatInterval
    End Sub

    Private Sub btnGetRemoveThreshold_Click(sender As Object, e As EventArgs)
        Dim tagRemoveThreshold As Integer
        tagRemoveThreshold = _ts800.GetTagRemovedThreshold(False)
        nudTagRemoveThreshold.Value = tagRemoveThreshold
    End Sub

    Private Sub btnGetInvnetoryRoundInterval_Click(sender As Object, e As EventArgs)
        Dim inventoryRoundInterval As Integer
        inventoryRoundInterval = _ts800.GetInventoryRoundInterval(False)
        nudInventoryRoundInterval.Value = inventoryRoundInterval
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        Dim selectedTab As TabPage = tabControl.SelectedTab
        'Validar de que exita contenido mCodTrabajador
        If String.IsNullOrEmpty(mCodTrabajador) Then
            AlertaError("Debe ingresar un trabajador antes de Vincular.", Color.FromArgb(238, 26, 36))
            'MessageBox.Show("Debe ingresar un trabajador antes de acceder a Inventario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Redirigir al usuario a otra pestaña (por ejemplo, tpPerformance)
            tabControl.SelectedTab = tpPerformance
            Exit Sub
        End If
        ' Configuración específica para tpInventory
        Me.tabControl.Dock = DockStyle.None

        ' Ajustar tamaño y posición del TabControl
        Me.tabControl.Height = Me.ClientSize.Height - pnlConnect.Height
        Me.tabControl.Width = Me.ClientSize.Width
        Me.tabControl.Location = New Point(0, 0)

        ' Configuración de pnlConnect en la parte inferior
        pnlConnect.Dock = DockStyle.None
        pnlConnect.Location = New Point(0, Me.ClientSize.Height - pnlConnect.Height)

        Try
            Me.BeginInvoke(Sub() InitializeInventoryTab())
        Catch ex As Exception
            Console.WriteLine($"Error al cambiar de pestaña: {ex.Message}")
        End Try

        If selectedTab.Name = "tpInventory" Then
            TabInventario()
        ElseIf selectedTab.Name = "tpSearch" Then
            TbBuscarPrenda()
        ElseIf selectedTab.Name = "tpPapper" Then
            TbHojaMarcacion()
        End If
    End Sub
    Private Sub AdjustDataGridView(dgv As DataGridView)
        ' Desactivar ajuste automático antes de realizar cambios
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        Try
            ' Realizar ajustes aquí (ejemplo: ajustar ancho de columnas)
            For Each column As DataGridViewColumn In dgv.Columns
                column.Width = 100 ' Ajusta el ancho según tus necesidades
            Next
        Catch ex As Exception
            Console.WriteLine($"Error ajustando DataGridView: {ex.Message}")
        Finally
            ' Reactivar ajuste automático
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End Try
    End Sub
    Private Sub InitializeInventoryTab()
        ' Configurar controles dentro de tpInventory
        Try
            CodBarras.Focus()
            AdjustDataGridView(dgvTagList)
        Catch ex As Exception
            Console.WriteLine($"Error inicializando pestaña de inventario: {ex.Message}")
        End Try
    End Sub
    Private Sub TbHojaMarcacion()
        TextBoxOP.Focus()
        For Each control As Control In TablaContenedorHM.Controls
            Dim fontSize As Single = Math.Max(8, Me.ClientSize.Width / 50)
            Dim fontSize1 As Single = Math.Max(10, Me.ClientSize.Width / 100)
            Dim fontSize2 As Single = Math.Max(10, Me.ClientSize.Width / 150)

            If TypeOf control Is TableLayoutPanel Then
                ResizeTableLPCIHM(TryCast(control, TableLayoutPanel), fontSize, fontSize1, fontSize2)
            End If
        Next
    End Sub
    Private Sub TbBuscarPrenda()
        BuscarCodBarras.Focus()
        For Each control As Control In tablaBuscarPrenda.Controls
            Dim fontSize As Single = Math.Max(8, Me.ClientSize.Width / 50)
            Dim fontSize1 As Single = Math.Max(10, Me.ClientSize.Width / 100)

            If control.Name = "DataGridView2" Then
                Dim dgv As DataGridView = TryCast(control, DataGridView)
                If dgv IsNot Nothing Then
                    ' Ajustar la fuente del DataGridView
                    dgv.Font = New Font(dgv.Font.FontFamily, fontSize1)
                    dgv.RowTemplate.Height = TextRenderer.MeasureText("Test", dgv.Font).Height + 5 ' Margen adicional
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    dgv.ColumnHeadersDefaultCellStyle.Font = New Font(dgv.ColumnHeadersDefaultCellStyle.Font.FontFamily, fontSize1)
                End If
            ElseIf control.Name = "MsnBusquedaPrenda" Then
                ' Ajustar el tamaño de la fuente del control CodBarras
                control.Font = New Font(control.Font.FontFamily, fontSize1)
                ' Ajustar el ancho para que ocupe el 100% del ancho del contenedor
                If control.Parent IsNot Nothing Then
                    control.Width = control.Parent.ClientSize.Width
                    control.Top = (control.Parent.ClientSize.Height - control.Height) \ 2
                End If
            ElseIf TypeOf control Is TableLayoutPanel Then
                ResizeTableLayoutPanelControls(TryCast(control, TableLayoutPanel), fontSize, fontSize1)
            End If
        Next
    End Sub
    Private Sub TabInventario()
        CodBarras.Focus()
        ' Redimensionar elementos dentro de TableLayoutPanel2
        For Each control As Control In TableLayoutPanel2.Controls

            Dim fontSize As Single = Math.Max(8, Me.ClientSize.Width / 50)
            Dim fontSize1 As Single = Math.Max(10, Me.ClientSize.Width / 120)

            If control.Name = "DataGridView1" Then
                Dim dgv As DataGridView = TryCast(control, DataGridView)
                If dgv IsNot Nothing Then
                    ' Ajustar la fuente del DataGridView
                    dgv.Font = New Font(dgv.Font.FontFamily, fontSize1)
                    dgv.RowTemplate.Height = TextRenderer.MeasureText("Test", dgv.Font).Height + 5 ' Margen adicional
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    dgv.ColumnHeadersDefaultCellStyle.Font = New Font(dgv.ColumnHeadersDefaultCellStyle.Font.FontFamily, fontSize1)
                End If
            ElseIf TypeOf control Is TableLayoutPanel Then
                ' Redimensionar controles dentro de TableLayoutPanel anidados
                ResizeTableLayoutPanelControls(TryCast(control, TableLayoutPanel), fontSize, fontSize1)
            End If
        Next
    End Sub
    Private Sub ResizeTableLPCIHM(panel As TableLayoutPanel, fontSize As Single, fontSize1 As Single, fontSize2 As Single)
        For Each control As Control In panel.Controls
            If TypeOf control Is Button Then
                Dim btn As Button = TryCast(control, Button)
                If btn IsNot Nothing And (control.Name = "BtnBuscarHM" Or control.Name = "BtnLimpiarHM") Then
                    ' Ajustar el tamaño de la fuente del botón
                    btn.Font = New Font(btn.Font.FontFamily, fontSize1)

                    ' Ajustar el ancho del botón al 100% de su celda en el TableLayoutPanel
                    Dim columnIndex As Integer = panel.GetColumn(control)
                    If columnIndex >= 0 Then
                        Dim cellWidth As Integer = panel.GetColumnWidths()(columnIndex)
                        btn.Width = cellWidth
                    End If
                    ' Ajustar la altura del botón según el tamaño del texto más 10 unidades de padding
                    Dim textSize As Size = TextRenderer.MeasureText(btn.Text, btn.Font)
                    btn.Height = textSize.Height + 20 ' 10 unidades de padding arriba y abajo
                    control.Top = (control.Parent.ClientSize.Height - control.Height) \ 2

                    ' (Opcional) Asegurar que el botón esté centrado en su celda
                    btn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
                End If
            ElseIf Not String.IsNullOrEmpty(control.Name) Then
                Console.WriteLine($"Nombre-->{control.Name}")
                ' Ajustar la fuente de otros controles si es necesario
                If control.Name = "TextBoxOP" Or control.Name = "TextBoxHM" Then
                    ' Ajustar el tamaño de la fuente del control CodBarras
                    control.Font = New Font(control.Font.FontFamily, fontSize)
                    ' Ajustar el ancho para que ocupe el 100% del ancho del contenedor
                    If control.Parent IsNot Nothing Then
                        control.Width = control.Parent.ClientSize.Width
                        control.Top = (control.Parent.ClientSize.Height - control.Height) \ 2
                    End If
                ElseIf control.Name.StartsWith("text_", StringComparison.OrdinalIgnoreCase) Then
                    control.Font = New Font(control.Font.FontFamily, fontSize2)
                ElseIf control.Name.StartsWith("lbl_", StringComparison.OrdinalIgnoreCase) Then
                    control.Font = New Font(control.Font.FontFamily, fontSize2, FontStyle.Bold)
                Else
                    control.Font = New Font(control.Font.FontFamily, fontSize1)
                End If
            End If
        Next
    End Sub
    Private Sub ResizeTableLayoutPanelControls(panel As TableLayoutPanel, fontSize As Single, fontSize1 As Single)
        For Each control As Control In panel.Controls
            If TypeOf control Is Button Then
                Dim btn As Button = TryCast(control, Button)
                If btn IsNot Nothing And (control.Name = "btnClear" Or control.Name = "btnLimpiarRFID") Then
                    ' Ajustar el tamaño de la fuente del botón
                    btn.Font = New Font(btn.Font.FontFamily, fontSize1)

                    ' Ajustar el ancho del botón al 100% de su celda en el TableLayoutPanel
                    Dim columnIndex As Integer = panel.GetColumn(control)
                    If columnIndex >= 0 Then
                        Dim cellWidth As Integer = panel.GetColumnWidths()(columnIndex)
                        btn.Width = cellWidth
                    End If
                    ' Ajustar la altura del botón según el tamaño del texto más 10 unidades de padding
                    Dim textSize As Size = TextRenderer.MeasureText(btn.Text, btn.Font)
                    btn.Height = textSize.Height + 20 ' 10 unidades de padding arriba y abajo
                    control.Top = (control.Parent.ClientSize.Height - control.Height) \ 2

                    ' (Opcional) Asegurar que el botón esté centrado en su celda
                    btn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
                End If
            ElseIf TypeOf control Is TableLayoutPanel Then
                ' Llamada recursiva para manejar anidamientos
                ResizeTableLayoutPanelControls(TryCast(control, TableLayoutPanel), fontSize, fontSize1)
            ElseIf TypeOf control Is DataGridView Then
                If (control.Name = "dgvTagList") Then
                    Console.WriteLine($"<--Nombre-->{control.Name}")
                    Dim dgv As DataGridView = TryCast(control, DataGridView)
                    If dgv IsNot Nothing Then
                        ' Ajustar la fuente del DataGridView
                        'dgv.Font = New Font(dgv.Font.FontFamily, fontSize)
                        'dgv.RowTemplate.Height = TextRenderer.MeasureText("Test", dgv.Font).Height + 5 ' Margen adicional
                        'dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        'dgv.ColumnHeadersDefaultCellStyle.Font = New Font(dgv.ColumnHeadersDefaultCellStyle.Font.FontFamily, fontSize1)
                    End If
                End If
            ElseIf Not String.IsNullOrEmpty(control.Name) Then
                Console.WriteLine($"Nombre-->{control.Name}")
                ' Ajustar la fuente de otros controles si es necesario
                If control.Name = "CodBarras" Or control.Name = "BuscarCodBarras" Then
                    ' Ajustar el tamaño de la fuente del control CodBarras
                    control.Font = New Font(control.Font.FontFamily, fontSize)
                    ' Ajustar el ancho para que ocupe el 100% del ancho del contenedor
                    If control.Parent IsNot Nothing Then
                        control.Width = control.Parent.ClientSize.Width
                        control.Top = (control.Parent.ClientSize.Height - control.Height) \ 2
                    End If
                ElseIf control.Name = "Label34" Or control.Name = "Label5" Then
                    control.Font = New Font(control.Font.FontFamily, fontSize)
                Else
                    control.Font = New Font(control.Font.FontFamily, fontSize1)
                End If
            End If
        Next
    End Sub
    'Private Sub LeerCodigoRFID()
    '    Console.WriteLine("Se ejecuta LeerCodigoRFID")
    '    btnStartInventory.PerformClick()
    '    btnStopInventory.PerformClick()
    '    Dim mCodBarra As String = CodBarras.Text.Trim()
    '    Dim sCodigoRFID As String = ObtenerPCEPC()

    '    CodBarras.Clear()
    '    CodBarras.Focus()
    '    Console.WriteLine($"mCodBarra->{mCodBarra} sCodigoRFID->{sCodigoRFID}")

    '    If String.IsNullOrWhiteSpace(sCodigoRFID) Then
    '        MsnVincular.Text = "Por favor, lea un código RFID válido."
    '        Exit Sub
    '    End If
    '    sCodigoRFID = "E90069150000700A8R40718C"
    '    If String.IsNullOrWhiteSpace(mCodBarra) Then
    '        MsnVincular.Text = "Por favor, lea un código de barras."
    '        Exit Sub
    '    End If

    '    Console.WriteLine($"Código de Barras: {mCodBarra}, Código RFID: {sCodigoRFID}")

    '    ' Validar si el RFID ya existe en la base de datos
    '    Dim dictionary As New Dictionary(Of String, Object) From {{"id_rfid", sCodigoRFID}}
    '    Dim dataRta = m_BDPrendaScm.GetData(dictionary)
    '    Console.WriteLine($"Sigue 1")
    '    If dataRta.Rows.Count > 0 Then
    '        Dim lsDatos = BuildDataString(dataRta.Rows(0))
    '        MsnVincular.Text = $"RFID ya registrado en: {lsDatos}. Verifique."
    '        Exit Sub
    '    End If
    '    Console.WriteLine($"Sigue 2")

    '    ' Manejar conexión explícita para Sybase
    '    Using connectionAse = m_BDPrenda.GetConnection()
    '        Console.WriteLine($"Estado de la conexión antes de SetRfid: {connectionAse?.State}")

    '        ' Enviar datos a Sybase
    '        Dim lsResult = m_BDPrenda.SetRfid(connectionAse, mCodBarra, mEmpresa, mCodTrabajador, sCodigoRFID)
    '        Console.WriteLine($"Resultado de SetRfid: {lsResult.Item1}, Mensaje: {lsResult.Item2}")
    '        Console.WriteLine($"Datos devueltos por SetRfid: Filas={lsResult.Item3.Rows.Count}")

    '        MsnVincular.Text = lsResult.Item2
    '        Console.WriteLine($"Sigue 3")
    '        If lsResult.Item1 <> 0 Then
    '            Console.WriteLine($"Error al registrar RFID en Sybase: {lsResult.Item2}")
    '            MsnVincular.Text = $"Error al registrar RFID en Sybase: {lsResult.Item2}"
    '            Exit Sub
    '        End If

    '        ' Insertar datos en MySQL
    '        dataRta = lsResult.Item3
    '        If dataRta.Rows.Count > 0 Then
    '            Dim row As DataRow = dataRta.Rows(0)
    '            Dim subCorteValue As Object = If(dataRta.Columns.Contains("sub_corte"), row("sub_corte"), DBNull.Value)
    '            Dim insertData As New Dictionary(Of String, Object) From {
    '            {"id_rfid", sCodigoRFID},
    '            {"id_barras", row("etiqueta")},
    '            {"op", row("op")},
    '            {"corte", row("corte")},
    '            {"subcorte", subCorteValue},
    '            {"cod_talla", row("cod_talla")},
    '            {"id_talla", row("id_talla")},
    '            {"talla", row("talla")},
    '            {"cod_combinacion", row("cod_comb")},
    '            {"color", row("color")},
    '            {"cod_trabajador", row("fotocheck")}
    '        }

    '            Dim llReturn = m_BDPrendaScm.Insert(insertData)
    '            Console.WriteLine($"Sigue 4")
    '            If llReturn = -1 Then
    '                MsnVincular.Text = $"Error al registrar en MySQL: {m_BDPrendaScm.GetError()}"
    '                Exit Sub
    '            End If

    '            Dim lsDatos = BuildDataString(row)
    '            Console.WriteLine($"Sigue 5")
    '            MsnVincular.Text = $"Se registró correctamente: {lsDatos}"
    '        Else
    '            Console.WriteLine("No se devolvieron datos de Retrieve.")
    '            MsnVincular.Text = "Error al procesar datos. Verifique con el administrador."
    '        End If
    '        Console.WriteLine($"Estado de la conexión después de SetRfid: {connectionAse?.State}")
    '    End Using
    'End Sub


    ' Método que devuelve el valor de szPCEPC
    Private Function ObtenerPCEPC() As String
        If dgvTagList.Rows.Count > 0 AndAlso Not dgvTagList.Rows(0).IsNewRow Then
            Dim value As String = dgvTagList.Rows(0).Cells(0).Value?.ToString()

            If Not String.IsNullOrEmpty(value) AndAlso value.Length > 24 Then
                ' Retorna los últimos 24 caracteres si el valor tiene más de 24
                Return value.Substring(value.Length - 24)
            End If

            Return value ' Retorna el valor completo si tiene 24 o menos caracteres
        End If
        Return String.Empty
    End Function

    Private Function PrimerValorRFID() As String
        If _tagList IsNot Nothing AndAlso _tagList.Count > 0 AndAlso _tagList(0) IsNot Nothing Then
            Dim value As String = _tagList(0).ToString()

            If Not String.IsNullOrEmpty(value) AndAlso value.Length > 24 Then
                ' Retorna los últimos 24 caracteres si el valor tiene más de 24
                Return value.Substring(value.Length - 24)
            End If

            ' Retorna el valor completo si tiene 24 o menos caracteres
            Return value
        End If

        ' Retorna una cadena vacía si la lista está vacía o el primer elemento es nulo
        Return String.Empty
    End Function

    Private Sub CodBarras_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If enterPressed Then Exit Sub ' Prevenir múltiples ejecuciones
            enterPressed = True
            Try
                If CodBarras Is Nothing Then Throw New Exception("CodBarras no está inicializado.")
                If dgvTagList Is Nothing Then Throw New Exception("dgvTagList no está inicializado.")
                LeerCodigoRFID()
            Catch ex As Exception
                Console.WriteLine($"Error en CodBarras_KeyDown: {ex.Message}")
                MsnVincular.Text = "Error: " & ex.Message
            Finally
                enterPressed = False
            End Try
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub

    Private Function BuildDataString(row As DataRow) As String
        Dim lsDatosList As New List(Of String) From {
            $"OP: {row("op")}",
            $"Corte: {row("corte")}",
            $"SubCorte: {row("sub_corte")}",
            $"Talla: {row("talla")}",
            $"Color: {row("color")}"
        }
        Return String.Join(" ", lsDatosList.Where(Function(s) Not String.IsNullOrWhiteSpace(s)))
    End Function

    Private Sub LeerCodigoRFID()
        dgvTagList.Rows.Clear()
        Dim mCodBarra As String = CodBarras.Text.Trim()
        Dim sCodigoRFID As String = ""

        Dim M_S_N As String = ""

        If String.IsNullOrWhiteSpace(mCodBarra) Then
            MostrarAlerta("Por favor, lea un código de barras.")
            CodBarras_Desbloqueado()
            CodBarras_ClearFoco()
            Exit Sub
        End If

        StartInventory()
        Thread.Sleep(500)
        StopInventory()

        CodBarras_Bloqueado()
        Dim cantLeidas As Integer = CantidadFilasLeidas()
        Console.WriteLine($"cantLeidas->{cantLeidas}")
        If (cantLeidas = 1) Then
            sCodigoRFID = ObtenerPCEPC()
            Console.WriteLine($"RFID->{sCodigoRFID}")
            ' Validar si el RFID ya existe en la base de datos
            Try
                Dim dictionary As New Dictionary(Of String, Object) From {{"id_rfid", sCodigoRFID}}
                Dim dataRta = m_BDPrendaScm.GetData(dictionary)

                'Console.WriteLine($"Filas devueltas por GetData: {dataRta.Rows.Count}")
                If dataRta.Rows.Count > 0 Then
                    lsDatos = BuildDataString(dataRta.Rows(0))
                    MostrarAlerta($"RFID ya registrado en: {lsDatos}. Verifique.")
                    CodBarras_Desbloqueado()
                    CodBarras_ClearFoco()
                    Exit Sub
                End If
            Catch ex As Exception
                'Console.WriteLine($"Error al validar RFID: {ex.Message}")
                CodBarras_Desbloqueado()
                CodBarras_ClearFoco()
                MostrarAlerta("Error al validar RFID. Verifique con el administrador.")
                Exit Sub
            End Try
        End If

        'Prueba
        'sCodigoRFID = GenerarCadenaAleatoria(24)

        'Console.WriteLine($"Código de Barras: {mCodBarra}, Código RFID: {sCodigoRFID}")

        'Se intertan los valores al procedimento almacenado USP_SAL_EMB_CON_RFID
        'El procediento valida y muestra msn con codigo de error lugo se actualiza la taba ordenacabadostallasmov y inserta en tmp_etiq_timbradas
        Dim lsResult = m_BDPrenda.SaveRFID(mCodBarra, mEmpresa, mCodTrabajador, sCodigoRFID)
        MsnVincular.Text = lsResult.Item2
        If lsResult.Item1 <> 0 Then
            'Console.WriteLine($"Error al registrar en Sybase: {lsResult.Item2}")
            CodBarras_Desbloqueado()
            CodBarras_ClearFoco()
            Exit Sub
        End If

        Try
            Dim dataTimbrado = m_BDPrenda.GetTimbradasByWorkerAndEtiqueta(mCodTrabajador, mCodBarra)
            If dataTimbrado.Rows.Count = 0 Then
                M_S_N = "No se registraron datos en la tabla timbrada. Verifique con el administrador."
                CodBarras_Desbloqueado()
                CodBarras_ClearFoco()
                MostrarAlerta(M_S_N)
                Exit Sub
            End If

            Dim row As DataRow = dataTimbrado.Rows(0)
            Dim insertData As New Dictionary(Of String, Object) From {
                {"id_rfid", sCodigoRFID},
                {"id_barras", row("etiqueta")},
                {"op", row("op")},
                {"corte", row("corte")},
                {"subcorte", row("sub_corte")},
                {"cod_talla", row("cod_talla")},
                {"id_talla", row("id_talla")},
                {"talla", row("talla")},
                {"cod_combinacion", row("cod_comb")},
                {"color", row("color")},
                {"cod_trabajador", row("fotocheck")}
            }

            Dim llReturn = m_BDPrendaScm.Insert(insertData)
            If llReturn <> 1 Then
                M_S_N = Msn(llReturn)
                MostrarAlerta(M_S_N)
            Else
                MsnVincular.Text = "Prenda registrada exitosamente."
                ' Eliminar el elemento "id_barras" del diccionario insertData
                insertData("fecha") = DateTime.Now
                If insertData.ContainsKey("id_barras") Then
                    insertData.Remove("id_barras")
                    insertData.Remove("id_rfid")
                    insertData.Remove("cod_talla")
                    insertData.Remove("cod_combinacion")
                    insertData.Remove("color")
                    insertData.Remove("cod_trabajador")
                End If
                LlenarDataGridView(DataGridView1, insertData)
                CantidadFilas()
                Alerta("Registrado Ok", Color.FromArgb(16, 175, 76), 1, 5)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error en el flujo de registro: {ex.Message}")
            MsnVincular.Text = "Error inesperado al registrar la prenda. Consulte con el administrador."
        End Try
        CodBarras_Desbloqueado()
        CodBarras_ClearFoco()
    End Sub
    Private Sub SafeUpdateLabel(control As Label, text As String)
        If control.InvokeRequired Then
            ' Si no estamos en el subproceso principal, usar Invoke para ejecutar en el hilo adecuado
            control.Invoke(New Action(Of Label, String)(AddressOf SafeUpdateLabel), control, text)
        Else
            ' Si ya estamos en el subproceso principal, actualizar directamente
            control.Text = text
        End If
    End Sub

    Private Sub SafeUpdateTextBox(control As TextBox, text As String)
        If control.InvokeRequired Then
            ' Si no estamos en el subproceso principal, usar Invoke para ejecutar en el hilo adecuado
            control.Invoke(New Action(Of TextBox, String)(AddressOf SafeUpdateTextBox), control, text)
        Else
            ' Si ya estamos en el subproceso principal, actualizar directamente
            control.Text = text
        End If
    End Sub

    Private Sub SaveCodigoRFID(cadena As String)
        Dim partes() As String = cadena.Split("~"c) ' Divide la cadena por el símbolo ~
        Dim mCodBarra As String = partes(0)
        Dim sCodigoRFID As String = partes(1)

        Console.WriteLine($"Elemento que va guardar {mCodBarra} -- {sCodigoRFID}")
        Dim M_S_N As String = ""

        Dim cantLeidas As Integer = CantidadFilasLeidas()
        Console.WriteLine($"cantLeidas->{cantLeidas}")
        If (sCodigoRFID <> "") Then
            Try
                Dim dictionary As New Dictionary(Of String, Object) From {{"id_rfid", sCodigoRFID}}
                Dim dataRta = m_BDPrendaScm.GetData(dictionary)

                'Console.WriteLine($"Filas devueltas por GetData: {dataRta.Rows.Count}")
                If dataRta.Rows.Count > 0 Then
                    lsDatos = BuildDataString(dataRta.Rows(0))
                    MostrarAlerta($"RFID ya registrado en: {lsDatos}. Verifique.")
                    Exit Sub
                End If
            Catch ex As Exception
                'Console.WriteLine($"Error al validar RFID: {ex.Message}")
                MostrarAlerta("Error al validar RFID. Verifique con el administrador.")
                Exit Sub
            End Try
        End If

        'Prueba
        'sCodigoRFID = GenerarCadenaAleatoria(24)

        'Console.WriteLine($"Código de Barras: {mCodBarra}, Código RFID: {sCodigoRFID}")

        'Se intertan los valores al procedimento almacenado USP_SAL_EMB_CON_RFID
        'El procediento valida y muestra msn con codigo de error lugo se actualiza la taba ordenacabadostallasmov y inserta en tmp_etiq_timbradas
        Dim lsResult = m_BDPrenda.SaveRFID(mCodBarra, mEmpresa, mCodTrabajador, sCodigoRFID)
        ' Actualizar el control 'MsnVincular' de forma segura
        SafeUpdateLabel(MsnVincular, lsResult.Item2)
        If lsResult.Item1 <> 0 Then
            SafeUpdateTextBox(CodBarras, "")
            MostrarAlerta($"Error al registrar en Sybase: {lsResult.Item2}")
            Exit Sub
        End If

        Try
            Dim dataTimbrado = m_BDPrenda.GetTimbradasByWorkerAndEtiqueta(mCodTrabajador, mCodBarra)
            If dataTimbrado.Rows.Count = 0 Then
                M_S_N = "No se registraron datos en la tabla timbrada. Verifique con el administrador."
                MostrarAlerta(M_S_N)
                Exit Sub
            End If

            Dim row As DataRow = dataTimbrado.Rows(0)
            Dim insertData As New Dictionary(Of String, Object) From {
                {"id_rfid", sCodigoRFID},
                {"id_barras", row("etiqueta")},
                {"op", row("op")},
                {"corte", row("corte")},
                {"subcorte", row("sub_corte")},
                {"cod_talla", row("cod_talla")},
                {"id_talla", row("id_talla")},
                {"talla", row("talla")},
                {"cod_combinacion", row("cod_comb")},
                {"color", row("color")},
                {"cod_trabajador", row("fotocheck")}
            }

            Dim llReturn = m_BDPrendaScm.Insert(insertData)
            If llReturn <> 1 Then
                M_S_N = Msn(llReturn)
                MostrarAlerta(M_S_N)
            Else
                SafeUpdateLabel(MsnVincular, "Prenda registrada exitosamente.")
                ' Eliminar el elemento "id_barras" del diccionario insertData
                insertData("fecha") = DateTime.Now
                If insertData.ContainsKey("id_barras") Then
                    insertData.Remove("id_barras")
                    insertData.Remove("id_rfid")
                    insertData.Remove("cod_talla")
                    insertData.Remove("cod_combinacion")
                    insertData.Remove("color")
                    insertData.Remove("cod_trabajador")
                End If
                LlenarDataGridView(DataGridView1, insertData)
                CantidadFilas()
                SafeUpdateTextBox(CodBarras, "")
                Alerta("Registrado Ok", Color.FromArgb(16, 175, 76), 1, 15)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error en el flujo de registro: {ex.Message}")
            SafeUpdateLabel(MsnVincular, "Error inesperado al registrar la prenda. Consulte con el administrador.")
        End Try
    End Sub
    Private Sub MostrarAlerta(mensaje As String)
        SafeUpdateLabel(MsnVincular, mensaje)
        AlertaError(mensaje, Color.FromArgb(238, 26, 36))
    End Sub
    Private Sub AlertaError(mensaje As String, color As Color)
        Using alerta As New FormAlertaError("Error", mensaje, color)
            alerta.ShowDialog()
        End Using
    End Sub
    Private Sub Alerta(mensaje As String, color_ As Color, tipo As Integer, Optional tiempo As Integer = 10)
        Using alerta As New FormAlerta(mensaje, color_, tipo, tiempo)
            alerta.ShowDialog()
        End Using
    End Sub
    Private Sub AlertaOk(titulo As String, color_ As Color, tiempo As Integer, descripcion As String)
        Using alerta As New FormAlertaOk(titulo, color_, tiempo, descripcion)
            alerta.ShowDialog()
        End Using
    End Sub
    Private Function ObtenerPrimerRFID() As String
        ' Asegúrate de que el DataGridView tenga al menos una fila antes de intentar acceder al valor
        Dim codigo As String = ""
        If DataGridView1.Rows.Count > 0 Then
            ' Accede al valor de la primera fila en la columna "clnEPC"
            Dim firstValue As Object = DataGridView1.Rows(0).Cells(0).Value

            ' Comprueba si el valor no es nulo
            If firstValue IsNot Nothing Then
                codigo = firstValue.ToString()
            End If
        End If
        Return codigo
    End Function
    Private Function GenerarCadenaAleatoria(longitud As Integer) As String
        Dim caracteresPermitidos As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim resultado As New Text.StringBuilder()
        Dim random As New Random()

        For i As Integer = 1 To longitud
            Dim indice As Integer = random.Next(0, caracteresPermitidos.Length)
            resultado.Append(caracteresPermitidos(indice))
        Next

        Return resultado.ToString()
    End Function
    Private Sub LlenarDataGridView(dataGridView As DataGridView, data As Dictionary(Of String, Object))
        If data Is Nothing OrElse data.Count = 0 Then
            MostrarAlerta("No hay datos para llenar el DataGridView.")
            Return
        End If

        Try
            ' Verifica si la llamada está en un subproceso diferente
            If dataGridView.InvokeRequired Then
                dataGridView.Invoke(New Action(Of DataGridView, Dictionary(Of String, Object))(AddressOf LlenarDataGridView), dataGridView, data)
            Else
                Dim rowIndex As Integer = dataGridView.Rows.Add()

                For Each key As String In data.Keys
                    If dataGridView.Columns.Contains(key) Then
                        dataGridView.Rows(rowIndex).Cells(key).Value = data(key)
                    End If
                Next
            End If
        Catch ex As Exception
            Console.WriteLine($"Error al llenar el DataGridView: {ex.Message}")
            MostrarAlerta("Error inesperado al llenar los datos. Consulte con el administrador.")
        End Try
    End Sub



    Private Sub CantidadFilas()
        Dim totalRegistros As Integer = If(DataGridView1.AllowUserToAddRows, DataGridView1.Rows.Count - 1, DataGridView1.Rows.Count)
        Console.WriteLine($"totalRegistros-->{totalRegistros}")
        SafeUpdateLabel(lblTotalCount, CType(totalRegistros, String))
    End Sub

    Private Function CantidadFilasLeidas() As Integer
        Dim totalRegistrosLeidos As Integer = -1
        SafeUpdateControl(dgvTagList, Sub(dgv)
                                          totalRegistrosLeidos = If(dgv.AllowUserToAddRows, dgv.Rows.Count - 1, dgv.Rows.Count)
                                      End Sub)
        Console.WriteLine($"totalRegistros leídos: {totalRegistrosLeidos}")
        Return totalRegistrosLeidos
    End Function

    Private Function Msn(llReturn As Long) As String
        Dim message As String

        Select Case llReturn
            Case 1
                ' Inserción exitosa (1 fila insertada)
                message = "El registro fue insertado correctamente."

            Case 0
                ' No se insertaron filas (por ejemplo, datos duplicados o restricciones violadas)
                message = "No se pudo insertar el registro. Es posible que los datos no sean válidos o que ya existan registros con valores duplicados."

            Case -1
                ' Error general en la ejecución (por ejemplo, un error con la base de datos)
                message = "Error al ejecutar la consulta. Por favor, revisa los detalles del error en el log."

            Case 2
                ' Violación de clave primaria (un valor duplicado en una columna de clave primaria)
                message = "No se pudo insertar el registro debido a una violación de clave primaria (registro duplicado)."

            Case 3
                ' Error de conexión (no se pudo conectar con la base de datos)
                message = "Error al conectar con la base de datos. Asegúrate de que el servidor esté disponible."

            Case Else
                ' Si el valor de llReturn no coincide con ninguno de los casos anteriores
                message = $"Error desconocido (Código: {llReturn}). Por favor, contacta con el soporte técnico."
        End Select

        Return message
    End Function

    Private Sub CodBarras_TextChanged(sender As Object, e As EventArgs) Handles CodBarras.TextChanged
        ' Obtener el código RFID
        Try
            Dim cantLeidas As Integer = CantidadFilasLeidas()
            If cantLeidas > 1 Then
                MostrarAlerta("Verificar existen 2 RFID")
                Exit Sub
            End If

            Dim rfidCode As String = ObtenerPCEPC()

            If CodBarras.Text.Length = 20 Or CodBarras.Text.Length = 21 Then
                Dim barcode As String = CodBarras.Text.Trim() + "~" + rfidCode
                CodBarrasQueue.Enqueue(barcode) ' Encolar el valor
                StartProcessingQueue() ' Iniciar el procesamiento si no está activo
                dgvTagList.Rows.Clear()
            End If

        Catch ex As Exception
            MostrarAlerta($"Error al procesar código de barras: {ex.Message}")
        End Try
    End Sub

    Private Sub StartProcessingQueue()
        If IsProcessingQueue Then Return
        IsProcessingQueue = True

        Task.Run(Sub()
                     While Not CodBarrasQueue.IsEmpty
                         Dim barcode As String = Nothing ' Inicialización explícita
                         If Not CodBarrasQueue.TryDequeue(barcode) Then
                             Continue While
                         End If

                         ' Llama a SaveCodigoRFID de forma segura
                         SafeUpdateControl(Me, Sub(form)
                                                   form.SaveCodigoRFID(barcode)
                                               End Sub)
                     End While
                     IsProcessingQueue = False
                 End Sub)
    End Sub




    ' Método para procesar un código de barras
    Private Sub ProcessBarcode(barcode As String)
        Try
            ' Aquí colocas la lógica que procesará cada código de barras.
            ' Por ejemplo, llamar a LeerCodigoRFID con el código.
            Console.WriteLine($"Procesando: {barcode}")
            ' Simula el procesamiento
            Thread.Sleep(100) ' Simulación de tarea
        Catch ex As Exception
            Console.WriteLine($"Error procesando el código {barcode}: {ex.Message}")
        End Try
    End Sub


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvTagList.Rows.Clear()
        DataGridView1.Rows.Clear()
        _tagList.Clear()
        CountTags()
        MsnVincular.Text = ""
        CodBarras.Focus()
    End Sub

    Private Sub CodBarras_Bloqueado()
        CodBarras.Enabled = False
    End Sub
    Private Sub CodBarras_Desbloqueado()
        CodBarras.Enabled = True
    End Sub

    Private Sub CodBarras_ClearFoco()
        CodBarras.Clear()
        CodBarras.Focus()
    End Sub

    ' Deshabilitar todos los controles dentro de un TabPage
    Private Sub DeshabilitarControles(tabPage As TabPage, habilitar As Boolean)
        For Each control As Control In tabPage.Controls
            control.Enabled = habilitar
        Next
    End Sub

    Private Sub BtnStartInventoryEx_Click(sender As Object, e As EventArgs) Handles btnStartInventoryEx.Click
        StartInventory()
    End Sub

    Private Sub BtnStopInventoryEx_Click(sender As Object, e As EventArgs) Handles btnStopInventoryEx.Click
        StopInventory()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLimpiarRFID.Click
        ClearTagListView()
    End Sub
    Private Sub BuscarPrenda()
        Dim CodBarras As String = BuscarCodBarras.Text
        Dim op As String
        Dim corte As String
        Dim subcorte As String
        Dim talla As String
        Dim idtalla As String
        Dim ultimoValor As Object = Nothing
        MsnBusquedaPrenda.Text = ""
        BuscarCodBarras.Text = ""
        op = CodBarras.Substring(0, 10)
        corte = CodBarras.Substring(10, 4)
        talla = CodBarras.Substring(14, 2)
        idtalla = CodBarras.Substring(16)
        subcorte = m_DBConsultarPrenda.ObtenerSubCorte(op, corte, talla, idtalla)
        Thread.Sleep(500)

        Dim l_return = m_DBConsultarPrenda.GetHistorialPrenda(op, corte, subcorte, talla, idtalla)

        If l_return.Rows.Count > 0 Then
            Dim ultimaFila = l_return.Rows(l_return.Rows.Count - 1)
            If Not IsDBNull(ultimaFila("AREA")) Then
                ultimoValor = ultimaFila("AREA")
                MsnBusquedaPrenda.Text = $"La Prenda Timbrada Se Encuentra Actualmente En: {ultimoValor}"
            End If
        End If

        ' Cargar los datos en el DataGridView
        With DataGridView2
            .AutoGenerateColumns = True ' Generar columnas automáticamente
            .DataSource = l_return      ' Establecer el origen de datos

            ' Ajustar los encabezados a letra capital
            For Each column As DataGridViewColumn In .Columns
                column.HeaderText = StrConv(column.HeaderText, VbStrConv.ProperCase)
            Next

            ' Configurar estilo de encabezado
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 15, FontStyle.Bold) ' Fuente Arial, tamaño 10, negrita
        End With
    End Sub
    Private Sub BuscarCodBarras_TextChanged(sender As Object, e As EventArgs) Handles BuscarCodBarras.TextChanged
        If BuscarCodBarras.TextLength = 20 Or BuscarCodBarras.TextLength = 21 Then
            BuscarPrenda()
        End If
    End Sub

    Private Sub TableCabecera_Paint(sender As Object, e As PaintEventArgs) Handles tableCabecera.Paint
        ' Obtener las dimensiones del TableLayoutPanel
        Dim panel As TableLayoutPanel = CType(sender, TableLayoutPanel)
        Dim rect As Rectangle = panel.ClientRectangle

        ' Ajustar el tamaño del rectángulo para evitar el borde interno
        rect.Width -= 1
        rect.Height -= 1

        ' Dibujar el borde con el color y grosor deseado
        Using pen As New Pen(Color.Black, 2) ' Cambia el color y grosor según sea necesario
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub TextBoxOP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxOP.TextChanged
        If TextBoxOP.TextLength = 5 Then
            ' Preparar el diccionario de parámetros
            Dim pOp As String = "10000" & TextBoxOP.Text
            Dim tipo As String = "norpd"
            Dim whereParameters As New Dictionary(Of String, Object) From {{tipo, pOp}}
            Dim valor As String = m_DBConsultarPrenda.ValidarOP(whereParameters, tipo)
            Console.WriteLine($"El valor es-->{valor}")

            If String.IsNullOrWhiteSpace(valor) Then
                TextBoxOP.Text = ""
                TextBoxOP.Focus()
                AlertaError($"Verificar la OP: {pOp} .", Color.FromArgb(238, 26, 36))
            Else
                TextBoxOP.Text = valor
                TextBoxOP.Enabled = False
                TextBoxHM.Enabled = True
                TextBoxHM.Text = ""
                TextBoxHM.Focus()
            End If
        End If
    End Sub

    Private Sub TextBoxOP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxOP.KeyPress
        ' Permitir números, punto decimal y teclas de control
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Asegurarse de que solo haya un punto decimal
        If e.KeyChar = "." AndAlso TextBoxOP.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxHM_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxHM.KeyDown
        ' Verificar si se presionó la tecla Enter o Tab
        If e.KeyCode = Keys.Enter Then
            Console.WriteLine($"Evento-->KeyDown Tab")
            e.SuppressKeyPress = True ' Evitar el sonido "ding" del sistema
            ' Acción a realizar cuando se presiona valida HM
            ValidarHM()
        End If
        Dim controlConFoco As Control = Me.ActiveControl
        Console.WriteLine($" KeyDown --> c {controlConFoco.Name}")
    End Sub

    Private Sub TextBoxHM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHM.KeyPress
        ' Permitir números, punto decimal y teclas de control
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Asegurarse de que solo haya un punto decimal
        If e.KeyChar = "." AndAlso TextBoxHM.Text.Contains(".") Then
            e.Handled = True
        End If

        ' Limitar a 3 caracteres
        If TextBoxHM.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Manejar el carácter Tab si AcceptsTab es True
        If e.KeyChar = Chr(Keys.Tab) Then
            e.Handled = True ' Opcional: Evitar la inserción si no deseas un carácter Tab
        End If
    End Sub

    Private Sub TextBoxHM_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBoxHM.PreviewKeyDown
        ' Capturar la tecla Tab en PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            ' Acción para la tecla Tab valida HM
            ValidarHM()
            e.IsInputKey = True ' Marca la tecla Tab como una entrada válida para personalizar el comportamiento
        End If
    End Sub

    Private Sub ValidarHM()
        Dim tipo As String = "nhjmr"
        Dim pOp As String = TextBoxOP.Text
        Dim pHm As String = TextBoxHM.Text

        If pHm.Length = 0 Then
            Return
        End If

        Dim whereParameters As New Dictionary(Of String, Object) From {{"norpd", pOp}, {tipo, pHm.PadLeft(3, "0"c)}}
        Dim valor As String = m_DBConsultarPrenda.ValidarOP(whereParameters, tipo)

        If String.IsNullOrWhiteSpace(valor) Then
            TextBoxHM.Text = ""
            TextBoxHM.Focus()
            AlertaError($"Verificar la Hoja Marcación: {pHm} .", Color.FromArgb(238, 26, 36))
        Else
            TextBoxHM.Text = valor
            TextBoxHM.Enabled = False
            BtnBuscarHM.Focus()
        End If
    End Sub

    Private Sub BuscarCabeceraHM()
        Dim pOp As String = TextBoxOP.Text
        Dim pHm As String = TextBoxHM.Text

        Dim whereParameters As New Dictionary(Of String, Object) From {{"norpd", pOp}, {"nhjmr", pHm}}
        Dim l_return As DataTable = m_DBConsultarPrenda.BuscarHMCabecera(whereParameters)

        ' Validar si el DataTable tiene datos
        If l_return Is Nothing OrElse l_return.Rows.Count = 0 Then
            ' Si no hay datos, mostrar una alerta y salir del método
            AlertaError($"No se encontraron registros para la OP: {pOp} {pHm}", Color.FromArgb(238, 26, 36))
            Return
        End If

        CargarValoresEnLabels(l_return)
    End Sub

    Private Sub BtnLimpiarHM_Click(sender As Object, e As EventArgs) Handles BtnLimpiarHM.Click
        TextBoxOP.Text = ""
        TextBoxOP.Enabled = True
        TextBoxOP.Focus()
        TextBoxHM.Text = ""
        TextBoxHM.Enabled = False

        For Each control As Control In tableCabecera.Controls
            If control.Name.StartsWith("text_") Then
                ' Aquí colocarás el código que deseas ejecutar si el nombre comienza con "text_"
                ' Por ejemplo, para cambiar el texto de un label:
                If TypeOf control Is Label Then
                    DirectCast(control, Label).Text = ""
                End If
            End If
        Next
        DataGridView3.DataSource = Nothing
        DataGridView3.Rows.Clear()
        DataGridView3.Columns.Clear()
    End Sub

    Private Sub BtnBuscarHM_Click(sender As Object, e As EventArgs) Handles BtnBuscarHM.Click
        BuscarCabeceraHM()
        BuscarHMDetalle()
    End Sub

    Public Sub BuscarHMDetalle()
        Dim pOp As String = TextBoxOP.Text
        Dim pHm As String = TextBoxHM.Text

        Dim whereParameters As New Dictionary(Of String, Object) From {{"norpd", pOp}, {"nhjmr", pHm}}
        Dim l_return = m_DBConsultarPrenda.BuscarHMDetalle(whereParameters)

        If l_return.Item1 = 0 Then
            Return
        End If

        ' Mostrar los datos en el DataGridView3
        MostrarEnDataGridView3(l_return.Item2, l_return.Item3)
    End Sub

    Private Sub CargarValoresEnLabels(dataTable As DataTable)
        ' Obtener la primera fila del DataTable
        Dim dataRow As DataRow = dataTable.Rows(0)

        ' Iterar por cada columna del DataTable
        For Each column As DataColumn In dataTable.Columns
            Dim columnName As String = column.ColumnName
            Dim controlName As String = "text_" & columnName ' Construir el nombre del LabelBox dinámicamente

            ' Buscar el control en el formulario por su nombre
            Dim labelControl As Control = Me.Controls.Find(controlName, True).FirstOrDefault()

            ' Si se encuentra el control y es un Label, asignar el valor
            If labelControl IsNot Nothing AndAlso TypeOf labelControl Is Label Then
                CType(labelControl, Label).Text = dataRow(columnName).ToString()
            End If
        Next
    End Sub

    Private Sub MostrarEnDataGridView3(totalTalla As List(Of Dictionary(Of String, Object)), detalleTalla As Dictionary(Of String, List(Of Dictionary(Of String, Object))))
        ' Limpiar cualquier configuración previa
        DataGridView3.DataSource = Nothing
        DataGridView3.Rows.Clear()
        DataGridView3.Columns.Clear()

        ' Configurar las columnas del DataGridView
        DataGridView3.Columns.Add("Color", "Color")
        DataGridView3.Columns.Add("Descripcion", "Descripción")
        DataGridView3.Columns.Add("Talla", "Talla")
        DataGridView3.Columns.Add("Cantidad", "Cantidad")
        DataGridView3.Columns.Add("Total", "Total")

        ' Iterar sobre los datos y agregar filas al DataGridView
        For Each total In totalTalla
            Dim cclrcl As String = total("cclrcl").ToString()
            Dim tclrcl As String = total("tclrcl").ToString()
            Dim totalCantidad As Integer = Convert.ToInt32(total("total"))

            ' Agregar fila del resumen (Color y Total)
            Dim resumenRowIndex As Integer = DataGridView3.Rows.Add()
            DataGridView3.Rows(resumenRowIndex).Cells("Color").Value = cclrcl
            DataGridView3.Rows(resumenRowIndex).Cells("Descripcion").Value = tclrcl
            DataGridView3.Rows(resumenRowIndex).Cells("Total").Value = totalCantidad.ToString("N0") ' Formato numérico

            ' Aplicar estilos para resaltar la fila de resumen
            With DataGridView3.Rows(resumenRowIndex)
                .DefaultCellStyle.BackColor = Color.LightGray
                .DefaultCellStyle.Font = New Font(DataGridView3.Font, FontStyle.Bold)

                ' Resaltar totales altos
                If totalCantidad > 500 Then
                    .DefaultCellStyle.ForeColor = Color.DarkGreen
                End If
            End With

            ' Agregar filas de detalle (Talla y Cantidad)
            If detalleTalla.ContainsKey(cclrcl) Then
                For Each detalle In detalleTalla(cclrcl)
                    Dim talla As String = detalle("talla").ToString()
                    Dim cantidad As Integer = Convert.ToInt32(detalle("cantidad"))

                    Dim detalleRowIndex As Integer = DataGridView3.Rows.Add()
                    DataGridView3.Rows(detalleRowIndex).Cells("Talla").Value = talla
                    DataGridView3.Rows(detalleRowIndex).Cells("Cantidad").Value = cantidad.ToString("N0") ' Formato numérico

                    ' Dejar las celdas de Color y Total en blanco para que visualmente parezca un detalle
                    DataGridView3.Rows(detalleRowIndex).Cells("Color").Value = ""
                    DataGridView3.Rows(detalleRowIndex).Cells("Descripcion").Value = ""
                    DataGridView3.Rows(detalleRowIndex).Cells("Total").Value = ""

                    ' Alternar color para las filas de detalle
                    If detalleRowIndex Mod 2 = 0 Then
                        DataGridView3.Rows(detalleRowIndex).DefaultCellStyle.BackColor = Color.White
                    Else
                        DataGridView3.Rows(detalleRowIndex).DefaultCellStyle.BackColor = Color.LightBlue
                    End If
                Next
            End If
        Next
    End Sub
    Private Function SaveInvActivo() As Boolean
        Dim activeMode As ActiveMode
        Console.WriteLine($"Imprimier valor {ComboBoxItem.GetCurrentItemValue(cbxActiveMode)} {activeMode}")

        ' Convertir explícitamente el valor devuelto al tipo ActiveMode
        activeMode = CType(ComboBoxItem.GetCurrentItemValue(cbxActiveMode), ActiveMode)
        Return _ts800.SetInventoryActiveMode(False, activeMode)
    End Function
    Private Sub BtnSetScanMode_Click(sender As Object, e As EventArgs)
        Dim result As Boolean
        Dim scanMode As TS800.ScanMode
        scanMode = ComboBoxItem.GetCurrentItemValue(cbxScanMode)
        result = _ts800.SetScanMode(False, scanMode)
        If result Then
            AlertaOk("Establecer el modo escaneo", Color.FromArgb(16, 175, 76), 30, "Exitoso.")
        Else
            MostrarAlerta("Error al configurar el modo de escaneo.")
        End If
    End Sub

    Private Sub BtnGetScanMode_Click(sender As Object, e As EventArgs)
        Dim scanMode As TS800.ScanMode
        scanMode = _ts800.GetScanMode(False)
        ComboBoxItem.SelectItemByValue(cbxScanMode, scanMode)
    End Sub

    Private Sub BtnSetActiveMode_Click(sender As Object, e As EventArgs)
        Dim result As Boolean = SaveInvActivo()

        If result Then
            AlertaOk("Establecer el modo activo", Color.FromArgb(16, 175, 76), 30, "Inventario correctamente.")
        Else
            MostrarAlerta("Error al establecer el modo activo de inventario.")
        End If
    End Sub
    Private Sub ObtenerInvActivo()
        Dim inventoryActiveMode As ActiveMode
        inventoryActiveMode = _ts800.GetInventoryActiveMode(False)
        ComboBoxItem.SelectItemByValue(cbxActiveMode, inventoryActiveMode)
    End Sub

    Private Sub BtnGetActiveMode_Click(sender As Object, e As EventArgs)
        ObtenerInvActivo()
    End Sub

    'Private Sub BtnSetTriggerType_Click(sender As Object, e As EventArgs)
    '    Dim result As Boolean
    '    Dim triggerTypes As New HashSet(Of TriggerType)
    '    If chkCommand.Checked Then
    '        triggerTypes.Add(TriggerType.Command)
    '    End If
    '    If chkSensor.Checked Then
    '        triggerTypes.Add(TriggerType.Sensor)
    '    End If
    '    If chkDigitalInput.Checked Then
    '        triggerTypes.Add(TriggerType.DigitalInput)
    '    End If
    '    result = _ts800.SetTriggerType(False, triggerTypes)
    '    If result Then
    '        MsgBox("Set TriggerType Successful.")
    '    Else
    '        MsgBox("Set TriggerType Failed.")
    '    End If
    'End Sub

    'Private Sub BtnGetTriggerType_Click(sender As Object, e As EventArgs)
    '    Dim triggerTypes As New HashSet(Of TriggerType)
    '    triggerTypes = _ts800.GetTriggerType(False)
    '    chkCommand.Checked = False
    '    chkSensor.Checked = False
    '    chkDigitalInput.Checked = False
    '    For Each type As TriggerType In triggerTypes
    '        If type = TriggerType.Command Then
    '            chkCommand.Checked = True
    '        ElseIf type = TriggerType.Sensor Then
    '            chkSensor.Checked = True
    '        ElseIf type = TriggerType.DigitalInput Then
    '            chkDigitalInput.Checked = True
    '        End If
    '    Next type
    'End Sub
    Private Sub SafeUpdateControl(Of T As Control)(control As T, updateAction As Action(Of T))
        If control.InvokeRequired Then
            control.Invoke(New Action(Of T, Action(Of T))(AddressOf SafeUpdateControl), control, updateAction)
        Else
            updateAction(control)
        End If
    End Sub

    Private Sub ActualizarDataGridView1(fila As Object())
        SafeUpdateControl(DataGridView1, Sub(dgv)
                                             dgv.Rows.Add(fila)
                                         End Sub)
    End Sub

    Private Sub ConfigurarEstiloDataGridView(dataGridView As DataGridView)
        With dataGridView
            ' Fondo general y bordes
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.Fixed3D

            ' Estilo de las celdas por defecto
            .DefaultCellStyle.Font = New Font("Arial", 10.0!)
            .DefaultCellStyle.Padding = New Padding(5)
            .DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            ' Encabezados de columna
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12.0!, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised

            ' Habilitar estilos personalizados
            .EnableHeadersVisualStyles = False

            ' Alineación y tamaño de columnas
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            ' Estilo de filas
            .RowTemplate.Height = 30
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
            .GridColor = Color.Gray

            ' Propiedades adicionales
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub
End Class
