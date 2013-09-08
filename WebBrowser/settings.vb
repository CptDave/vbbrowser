Public Class settings

    Private Sub ButtonSaveAndExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveAndExit.Click
        Form1.WebBrowser1.Url = New Uri(TextBoxHomePage.Text)
        Close()
    End Sub
End Class