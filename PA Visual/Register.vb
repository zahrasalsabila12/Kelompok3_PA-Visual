Public Class Register
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Visible = False
        Form1.ShowDialog()
    End Sub
End Class