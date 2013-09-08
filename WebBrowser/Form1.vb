Public Class Form1

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ButtonForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonForward.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ButtonEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnter.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ButtonSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSettings.Click
        settings.Show()
    End Sub

    Private Sub formResize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Size.Width > 860 Then
            TextBox1.Width = Me.Size.Width - 370

            Dim refreshLoc = New System.Drawing.Point(Me.Size.Width - 184, ButtonRefresh.Location.Y)
            ButtonRefresh.Location = refreshLoc

            Dim settingLoc = New System.Drawing.Point(Me.Size.Width - 103, ButtonSettings.Location.Y)
            ButtonSettings.Location = settingLoc
        End If
    End Sub
End Class
