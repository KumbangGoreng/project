Imports System.Data
Imports System.Data.SqlClient

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-CAP1RF4L\SQLEXPRESS;Initial Catalog=vbProject;Integrated Security=True"
        Dim query As String = "SELECT * FROM [Users] WHERE username = @username AND [password] = @password"

        Using con As SqlConnection = New SqlConnection(connectionString)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text)
                cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text)
                con.Open()
                Dim dt As DataTable = New DataTable()
                Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                    sda.Fill(dt)
                End Using

                If (dt.Rows.Count > 0) Then
                    MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Using
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
