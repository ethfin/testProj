Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUser.Text
        Dim password As String = txtPass.Text

        ' Validate input
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            lblIncorrect.Text = "Username and password cannot be empty."
            lblIncorrect.Show()
            Exit Sub
        End If

        Dim conn As MySqlConnection = Common.getDBConnectionX()

        Try
            ' Open the connection
            conn.Open()

            ' SQL query to get the hashed password from the database for the given username
            Dim query As String = "SELECT password FROM dbaccounts WHERE username = @username"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)

            ' Use parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@username", username)

            ' Execute the query and get the result
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if a row was returned
            If reader.Read() Then
                ' Retrieve the hashed password from the database
                Dim hashedPassword As String = reader("password").ToString()

                ' Verify the entered password against the hashed password
                Dim isValidPassword As Boolean = BCrypt.Net.BCrypt.Verify(password, hashedPassword)

                ' Check if the password is correct
                If isValidPassword Then
                    MessageBox.Show("Login successful!")
                    ' Proceed to the next form or main application window
                    frmMain.Show()
                    Me.Hide()
                Else
                    lblIncorrect.Text = "Invalid username or password."
                    lblIncorrect.Show()
                End If
            Else
                lblIncorrect.Text = "Invalid username or password."
                lblIncorrect.Show()
            End If

            reader.Close()

        Catch ex As Exception
            ' Handle any errors that occur
            lblIncorrect.Text = "Error: " & ex.Message
            lblIncorrect.Show()
        Finally
            ' Close the connection whether or not an error occurred
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        frmSignUp.Show()
    End Sub
End Class
