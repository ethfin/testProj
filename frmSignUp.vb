Imports MySql.Data.MySqlClient
Imports BC = BCrypt.Net.BCrypt

Public Class frmSignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Validate the input fields
        If ValidateInputFields() Then
            ' If validation is successful, proceed with the sign-up process
            ' (e.g., save the data to the database)
            InsertUserData()
        End If
    End Sub

    ' Function to validate input fields
    Private Function ValidateInputFields() As Boolean
        ' Check if any of the fields are empty
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtReenterPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtAnswerQ1.Text) OrElse
           String.IsNullOrWhiteSpace(txtAnswerQ2.Text) OrElse
           String.IsNullOrWhiteSpace(cmbSecurityQ1.Text) OrElse
           String.IsNullOrWhiteSpace(cmbSecurityQ2.Text) Then
            lblIncorrect.Text = ("Please fill in all fields.")
            lblIncorrect.Show()
            Return False
        End If

        ' Check if the passwords match
        If Not txtPassword.Text.Equals(txtReenterPassword.Text) Then
            lblIncorrect.Text = ("Passwords do not match.")
            lblIncorrect.Show()
            Return False
        End If

        ' Add more validation as needed (e.g., email format, password strength)

        ' If all validations pass
        Return True
    End Function

    Private Sub InsertUserData()
        ' Use the Common class to get the database connection
        Dim conn As MySqlConnection = Common.getDBConnectionX()

        Try
            ' Define the SQL INSERT statement
            ' Replace 'userTable' and column names with your actual table name and columns
            Dim sql As String = "INSERT INTO dbaccounts (username, password, email, firstName, lastName, securityQuestion1, securityQuestion2, securityAnswer1, securityAnswer2) VALUES (@username, @password, @email, @firstName, @lastName, @securityQuestion1, @securityQuestion2, @securityAnswer1, @securityAnswer2)"

            ' Create a new MySqlCommand using the SQL statement and connection
            Using cmd As New MySqlCommand(sql, conn)
                ' Add parameters to the command to prevent SQL injection
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                ' Hash the password using BCrypt before inserting it into the database
                Dim hashedPassword As String = BC.HashPassword(txtPassword.Text)
                cmd.Parameters.AddWithValue("@password", hashedPassword) ' Now using hashed password
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@securityQuestion1", cmbSecurityQ1.Text)
                cmd.Parameters.AddWithValue("@securityQuestion2", cmbSecurityQ2.Text)
                cmd.Parameters.AddWithValue("@securityAnswer1", txtAnswerQ1.Text)
                cmd.Parameters.AddWithValue("@securityAnswer2", txtAnswerQ2.Text)

                ' Open the connection
                conn.Open()

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Inform the user of success
                lblIncorrect.Text = "Sign-up successful!"
                lblIncorrect.Show()
            End Using
        Catch ex As Exception
            ' Handle any errors that occur
            lblIncorrect.Text = "Error: " & ex.Message
            lblIncorrect.Show()
        Finally
            ' Ensure the connection is closed
            If conn IsNot Nothing Then
                conn.Close()
            End If
            Me.Hide()
            frmLogin.Show()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class