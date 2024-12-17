Imports System.Net

Public Class WiFiSettings
    Public ReadOnly SSID As String
    Public ReadOnly Password As String
    Public ReadOnly DHCPEnabled As Boolean
    Public ReadOnly IP As IPAddress
    Public ReadOnly SubnetMask As IPAddress
    Public ReadOnly Gateway As IPAddress

    Public Sub New(ByVal szSSID As String, ByVal szPassword As String, ByVal bIsDHCPEnabled As Boolean, ByVal oIP As IPAddress, ByVal oSubnetMask As IPAddress, ByVal oGateway As IPAddress)
        SSID = szSSID
        Password = szPassword
        DHCPEnabled = bIsDHCPEnabled
        IP = oIP
        SubnetMask = oSubnetMask
        Gateway = oGateway
    End Sub

    Public Sub New(ByVal szSSID As String, ByVal szPassword As String)
        MyClass.New(szSSID, szPassword, True, Nothing, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal szSSID As String, ByVal szPassword As String, ByVal oIP As IPAddress, ByVal oSubnetMask As IPAddress, ByVal oGateway As IPAddress)
        MyClass.New(szSSID, szPassword, False, oIP, oSubnetMask, oGateway)
    End Sub
End Class
