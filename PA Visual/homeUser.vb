Public Class homeUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Visible = False
        mainUser.ShowDialog()
    End Sub
End Class