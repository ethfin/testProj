Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2HtmlLabel1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUser.Text
        Dim password As String = txtPass.Text

        Dim conn As MySqlConnection = Common.getDBConnectionX()

        Try
            ' Open the connection
            conn.Open()

            ' SQL query to check if the user exists with the given username and password
            Dim query As String = "SELECT COUNT(*) FROM accounts WHERE username = @username AND password = @password"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

            ' Use parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            ' Execute the query and get the result
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Check if the user exists
            If result > 0 Then
                MessageBox.Show("Login successful!")
                ' Proceed to the next form or main application window
                frmMain.Show()

                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            ' Handle any errors that occur
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection whether or not an error occurred
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        frmSignUp.Show()
    End Sub
End Class
