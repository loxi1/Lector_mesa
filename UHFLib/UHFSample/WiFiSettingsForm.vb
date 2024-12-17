Imports System.Net
Imports com.gigatms

Public Class WiFiSettingsForm
    Private WithEvents _ts100 As TS100
    Private WithEvents _ts800 As TS800
    Private m_oWiFiSettings As WiFiSettings
    Private m_bIsOK As Boolean

    Public Function ShowWiFiSettings(ByVal ts800 As TS800) As Boolean
        m_bIsOK = False
        _ts800 = ts800
        m_oWiFiSettings = Nothing
        If _ts800 IsNot Nothing Then
            Me.ShowDialog()
        End If
        Return m_bIsOK
    End Function

    Public Function ShowWiFiSettings(ByVal ts100 As TS100) As Boolean
        m_bIsOK = False
        _ts100 = ts100
        m_oWiFiSettings = Nothing
        If _ts100 IsNot Nothing Then
            Me.ShowDialog()
        End If
        Return m_bIsOK
    End Function

    Private m_szTitle As String
    Private Sub frmWiFiSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim szValue As String
        Dim iValue As Integer
        m_szTitle = My.Application.Info.Title
        cboSSID.Text = GetSetting(m_szTitle, "WiFi", "SSID", "")
        txtPassword.Text = GetSetting(m_szTitle, "WiFi", "Password", "")
        szValue = GetSetting(m_szTitle, "WiFi", "DHCPEnabled", "1")
        iValue = 0
        Select Case szValue
            Case "Y", "T", "YES"
                iValue = 1
            Case Else
                If IsNumeric(szValue) Then
                    If False = Integer.TryParse(szValue, iValue) Then
                        iValue = 0
                    End If
                End If
        End Select
        chkDHCPEnabled.Checked = CBool(iValue <> 0)
        txtIP.Text = GetSetting(m_szTitle, "WiFi", "IP", "192.168.1.2")
        txtSubnetMask.Text = GetSetting(m_szTitle, "WiFi", "SubnetMask", "255.255.255.0")
        txtGateway.Text = GetSetting(m_szTitle, "WiFi", "Gateway", "192.168.1.1")
        Select Case True
            Case _ts100 IsNot Nothing
                txtMacAddress.Text = _ts100.GetWiFiMacAddress
            Case _ts800 IsNot Nothing
                txtMacAddress.Text = _ts800.GetWiFiMacAddress
            Case Else
                txtMacAddress.Text = "Not Available"
        End Select
        With btnRefreshAPList
            .Visible = False
            If (_ts100 IsNot Nothing) OrElse (_ts800 IsNot Nothing) Then
                .Visible = True
            End If
            .Enabled = .Visible
        End With
    End Sub

    Private Sub txtIPFormat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIP.KeyPress, txtSubnetMask.KeyPress, txtGateway.KeyPress
        Dim cData As Char
        cData = e.KeyChar
        If Char.IsControl(cData) = False Then
            If False = Char.IsNumber(cData) Then
                If cData <> "."c Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        m_bIsOK = False
        Me.Close()
        Me.Dispose()
    End Sub

    Private m_iWaitTicks As Integer
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim bIsIPFromDHCP As Boolean
        Dim oSubnetMask As IPAddress
        Dim oGateway As IPAddress
        Dim szPassword As String
        Dim szSSID As String
        Dim oIP As IPAddress
        Dim szMsg As String
        Dim bResult As Boolean
        btnOK.Enabled = False
        btnCancel.Enabled = False
        Try
            szSSID = cboSSID.Text
            szPassword = txtPassword.Text
            bIsIPFromDHCP = chkDHCPEnabled.Checked
            oIP = IPAddress.Parse(txtIP.Text)
            oGateway = IPAddress.Parse(txtGateway.Text)
            oSubnetMask = IPAddress.Parse(txtSubnetMask.Text)
            If (_ts100 Is Nothing) AndAlso (_ts800 Is Nothing) Then
                m_oWiFiSettings = New WiFiSettings(szSSID, szPassword, bIsIPFromDHCP, oIP, oSubnetMask, oGateway)
                SaveSetting(m_szTitle, "WiFi", "SSID", cboSSID.Text)
                SaveSetting(m_szTitle, "WiFi", "Password", txtPassword.Text)
                SaveSetting(m_szTitle, "WiFi", "DHCPEnabled", IIf(chkDHCPEnabled.Checked, "1", "0"))
                SaveSetting(m_szTitle, "WiFi", "IP", txtIP.Text)
                SaveSetting(m_szTitle, "WiFi", "SubnetMask", txtSubnetMask.Text)
                SaveSetting(m_szTitle, "WiFi", "Gateway", txtGateway.Text)
                bResult = True
            Else
                m_iWaitTicks = Environment.TickCount
                m_szWaitMsg = "Please wait for connect to AP ... "
                TimerWaitMsg.Enabled = True
                If bIsIPFromDHCP Then
                    If _ts100 IsNot Nothing Then
                        bResult = _ts100.SetWiFiSettings(szSSID, szPassword)
                    ElseIf _ts800 IsNot Nothing Then
                        bResult = _ts800.SetWiFiSettings(szSSID, szPassword)
                    End If
                Else
                    If _ts100 IsNot Nothing Then
                        bResult = _ts100.SetWiFiSettings(szSSID, szPassword, oIP, oGateway, oSubnetMask)
                    ElseIf _ts800 IsNot Nothing Then
                        bResult = _ts800.SetWiFiSettings(szSSID, szPassword, oIP, oGateway, oSubnetMask)
                    End If
                End If

                TimerWaitMsg.Enabled = False
                If bResult Then
                    SaveSetting(m_szTitle, "WiFi", "SSID", cboSSID.Text)
                    SaveSetting(m_szTitle, "WiFi", "Password", txtPassword.Text)
                    SaveSetting(m_szTitle, "WiFi", "DHCPEnabled", IIf(chkDHCPEnabled.Checked, "1", "0"))
                    SaveSetting(m_szTitle, "WiFi", "IP", txtIP.Text)
                    SaveSetting(m_szTitle, "WiFi", "SubnetMask", txtSubnetMask.Text)
                    SaveSetting(m_szTitle, "WiFi", "Gateway", txtGateway.Text)
                    szMsg = "Set WiFi Settings OK"
                    With labMsg
                        .ForeColor = Color.Blue
                        .Text = szMsg
                    End With
                    MsgBox(szMsg, MsgBoxStyle.Information)
                Else
                    szMsg = "Fail to set WiFi Settings"
                    With labMsg
                        .ForeColor = Color.Red
                        .Text = szMsg
                    End With
                    MsgBox(szMsg, MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            bResult = False
            szMsg = "Fail to update settings: " & ex.ToString()
            With labMsg
                .ForeColor = Color.Red
                .Text = szMsg
            End With
            MsgBox(szMsg, MsgBoxStyle.Critical)
        End Try
        TimerWaitMsg.Enabled = False
        btnCancel.Enabled = True
        btnOK.Enabled = True
        If bResult Then
            m_bIsOK = True
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private m_szWaitMsg As String
    Private Sub TimerWaitMsg_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerWaitMsg.Tick
        Dim iTicks As Integer
        Dim szMsg As String
        iTicks = (Environment.TickCount - m_iWaitTicks)
        szMsg = m_szWaitMsg & Format((iTicks / 1000), "0.0") & " second"
        With labMsg
            .ForeColor = Color.Black
            .Text = szMsg
        End With
    End Sub

    Private Sub btnRefreshAPList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshAPList.Click
        Dim iCount As Integer
        Dim bResult As Integer
        Dim szAPList As List(Of String) = New List(Of String)
        m_iWaitTicks = Environment.TickCount
        m_szWaitMsg = "Please wait for list SSIDs ... "
        TimerWaitMsg.Enabled = True

        Select Case True
            Case _ts100 IsNot Nothing
                szAPList = _ts100.GetWiFiApList
            Case _ts800 IsNot Nothing
                szAPList = _ts800.GetWiFiApList
            Case Else
                szAPList = Nothing
        End Select
        If (szAPList IsNot Nothing) Then
            cboSSID.Items.Clear()
            iCount = szAPList.Count
            For I = 0 To (iCount - 1)
                cboSSID.Items.Add(szAPList.Item(I))
            Next I
            bResult = True
        End If

        TimerWaitMsg.Enabled = False
        With labMsg
            If bResult Then
                .ForeColor = Color.Blue
                .Text = "List SSIDs OK"
            Else
                .ForeColor = Color.Red
                .Text = "Fail to list SSIDs"
            End If
        End With
    End Sub

    Private Sub chkDHCPEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDHCPEnabled.CheckedChanged
        Dim bIsEnabled As Boolean
        If chkDHCPEnabled.Checked Then
            bIsEnabled = False
        Else
            bIsEnabled = True
            txtIP.Text = ""
            txtSubnetMask.Text = ""
            txtGateway.Text = ""
        End If
        txtIP.Enabled = bIsEnabled
        txtSubnetMask.Enabled = bIsEnabled
        txtGateway.Enabled = bIsEnabled
    End Sub
End Class