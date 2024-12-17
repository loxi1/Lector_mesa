Public Class frmMain
    Private WithEvents _MainForm As System.Windows.Forms.Form

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        _MainForm = New frmLector()
        _MainForm.Show()
        With Me
            .Size = New Size(0, 0)
            .Hide()
        End With
    End Sub

    Private Sub _MainForm_Closed(sender As Object, e As EventArgs) Handles _MainForm.Closed
        Me.Dispose()
    End Sub
End Class