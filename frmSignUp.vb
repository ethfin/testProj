Imports MySql.Data.MySqlClient

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
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtReenterPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtAnswerQ1.Text) OrElse
           String.IsNullOrWhiteSpace(txtAnswerQ2.Text) OrElse
           String.IsNullOrWhiteSpace(cmbSecurityQ1.Text) OrElse
           String.IsNullOrWhiteSpace(cmbSecurityQ2.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return False
        End If

        ' Check if the passwords match
        If Not txtPassword.Text.Equals(txtReenterPassword.Text) Then
            MessageBox.Show("Passwords do not match.")
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
            Dim sql As String = "INSERT INTO accounts (username, password, email, firstName, lastName, securityQuestion1, securityQuestion2, securityAnswer1, securityAnswer2) VALUES (@username, @password, @email, @firstName, @lastName, @securityQuestion1, @securityQuestion2, @securityAnswer1, @securityAnswer2)"

            ' Create a new MySqlCommand using the SQL statement and connection
            Using command As New MySqlCommand(sql, conn)
                ' Add parameters to the command to prevent SQL injection
                command.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                command.Parameters.AddWithValue("@lastName", txtLastName.Text)
                command.Parameters.AddWithValue("@email", txtEmail.Text)
                command.Parameters.AddWithValue("@password", txtPassword.Text) ' Consider hashing the password
                command.Parameters.AddWithValue("@username", txtUsername.Text)
                command.Parameters.AddWithValue("@securityQuestion1", cmbSecurityQ1.Text)
                command.Parameters.AddWithValue("@securityQuestion2", cmbSecurityQ2.Text)
                command.Parameters.AddWithValue("@securityAnswer1", txtAnswerQ1.Text)
                command.Parameters.AddWithValue("@securityAnswer2", txtAnswerQ2.Text)

                ' Open the connection
                conn.Open()

                ' Execute the command
                command.ExecuteNonQuery()

                ' Inform the user of success
                MessageBox.Show("Sign-up successful!")
            End Using
        Catch ex As Exception
            ' Handle any errors that occur
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If conn IsNot Nothing Then
                conn.Close()
            End If
            Me.Hide()
            frmLogin.Show()
        End Try
    End Sub
End Class