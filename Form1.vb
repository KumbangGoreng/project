Public Class Form1
    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        With Form2
            .TopLevel = False
            Panel8.Controls.Add(Form2)
            .BringToFront()
            .Show()
        End With
        BtnPanel1.Show()
        btnPanel2.Hide()
        btnPanel3.Hide()



    End Sub

    Private Sub ProfileBtn_Click(sender As Object, e As EventArgs) Handles ProfileBtn.Click
        With Form3
            .TopLevel = False
            Panel8.Controls.Add(Form3)
            .BringToFront()
            .Show()
        End With

        BtnPanel1.Hide()
        btnPanel3.Hide()
        btnPanel2.Hide()
    End Sub

    Private Sub ItemsBtn_Click(sender As Object, e As EventArgs) Handles ItemsBtn.Click
        With Form4
            .TopLevel = False
            Panel8.Controls.Add(Form4)
            .BringToFront()
            .Show()
        End With
        btnPanel3.Hide()
        BtnPanel1.Hide()
        btnPanel2.Show()

    End Sub

    Private Sub SupplierBtn_Click(sender As Object, e As EventArgs) Handles SupplierBtn.Click
        With Form5
            .TopLevel = False
            Panel8.Controls.Add(Form5)
            .BringToFront()
            .Show()
        End With
        btnPanel3.Show()
        BtnPanel1.Hide()
        btnPanel2.Hide()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Close()

    End Sub
End Class
