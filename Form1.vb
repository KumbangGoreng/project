Public Class Form1
    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        With Form2
            .TopLevel = False
            Panel8.Controls.Add(Form2)
            .BringToFront()
            .Show()
        End With

    End Sub
End Class
