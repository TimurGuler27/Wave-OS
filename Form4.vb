Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logInfo As System.IO.DirectoryInfo
        If My.Computer.FileSystem.DirectoryExists("C:\backup\logs") Then
            logInfo = My.Computer.FileSystem.GetDirectoryInfo _
            ("C:\backup\logs")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Launcher.Click
        Filesystem.show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AppList.show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form8.Show()
    End Sub
End Class