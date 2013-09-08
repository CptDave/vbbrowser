Public Class Form1

    Dim homePageString As System.String
    Dim openFullScreenString As System.String

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
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub ButtonSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSettings.Click
        settings.Show()
    End Sub

    Private Sub formResize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Size.Width > 860 Or Me.Size.Height > 521 Then
            TextBox1.Width = Me.Size.Width - 370

            Dim refreshLoc = New System.Drawing.Point(Me.Size.Width - 184, ButtonRefresh.Location.Y)
            ButtonRefresh.Location = refreshLoc

            Dim settingLoc = New System.Drawing.Point(Me.Size.Width - 103, ButtonSettings.Location.Y)
            ButtonSettings.Location = settingLoc

            Dim wbHeight = New System.Drawing.Size(WebBrowser1.Size.Width, Me.Size.Height - 79)
            WebBrowser1.Size = wbHeight
        End If
    End Sub

    Private Sub mainLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(My.Resources.HomePage)
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub
End Class
