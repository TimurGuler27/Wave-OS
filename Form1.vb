
Public Class Welcome

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Label1.Visible = False
        Login.Show()
        Me.Hide()
    End Sub

End Class

