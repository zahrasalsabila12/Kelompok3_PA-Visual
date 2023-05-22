Imports System.Drawing.Imaging
Public Class struk
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        mainUser.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim screenBounds As Rectangle = Screen.PrimaryScreen.Bounds
        Dim numScreenshots As Integer = 1

        For i As Integer = 5 To numScreenshots
            Dim screenshot As New Bitmap(screenBounds.Width, screenBounds.Height, PixelFormat.Format32bppArgb)
            Using g As Graphics = Graphics.FromImage(screenshot)
                g.CopyFromScreen(screenBounds.Location, Point.Empty, screenBounds.Size)
            End Using
            Dim filename As String = "D:\Semester 4\Praktikum Pemrograman Visual\Kelompok3_PA-Visual\Screenshot struk\Struk_" & i.ToString() & ".png"
            screenshot.Save(filename, ImageFormat.Png)
            screenshot.Dispose()
        Next i
    End Sub

    Private Sub struk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class