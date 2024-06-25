Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
            Dim sql As String = "INSERT INTO dbaccounts (username, password, email, firstName, lastName, securityQuestion1, securityQuestion2, securityAnswer1, securityAnswer2) VALUES (@username, @password, @email, @firstName, @lastName, @securityQuestion1, @securityQuestion2, @securityAnswer1, @securityAnswer2)"

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
            Me.Close()
            frmLogin.Show()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub cmbSecurityQ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecurityQ1.SelectedIndexChanged
        ' Store the previously selected item from cmbSecurityQ2
        Static prevSelectedIndex2 As Integer = -1
        If cmbSecurityQ2.SelectedIndex <> -1 AndAlso prevSelectedIndex2 <> -1 Then
            ' Add the previously selected item back to cmbSecurityQ2
            cmbSecurityQ2.Items.Insert(prevSelectedIndex2, cmbSecurityQ2.Tag)
        End If
        ' Remove the currently selected item of cmbSecurityQ1 from cmbSecurityQ2
        If cmbSecurityQ2.Items.Contains(cmbSecurityQ1.SelectedItem) Then
            prevSelectedIndex2 = cmbSecurityQ2.Items.IndexOf(cmbSecurityQ1.SelectedItem)
            cmbSecurityQ2.Tag = cmbSecurityQ1.SelectedItem ' Store the removed item
            cmbSecurityQ2.Items.Remove(cmbSecurityQ1.SelectedItem)
        End If
    End Sub

    Private Sub cmbSecurityQ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecurityQ2.SelectedIndexChanged
        ' Store the previously selected item from cmbSecurityQ1
        Static prevSelectedIndex1 As Integer = -1
        If cmbSecurityQ1.SelectedIndex <> -1 AndAlso prevSelectedIndex1 <> -1 Then
            ' Add the previously selected item back to cmbSecurityQ1
            cmbSecurityQ1.Items.Insert(prevSelectedIndex1, cmbSecurityQ1.Tag)
        End If
        ' Remove the currently selected item of cmbSecurityQ2 from cmbSecurityQ1
        If cmbSecurityQ1.Items.Contains(cmbSecurityQ2.SelectedItem) Then
            prevSelectedIndex1 = cmbSecurityQ1.Items.IndexOf(cmbSecurityQ2.SelectedItem)
            cmbSecurityQ1.Tag = cmbSecurityQ2.SelectedItem ' Store the removed item
            cmbSecurityQ1.Items.Remove(cmbSecurityQ2.SelectedItem)
        End If
    End Sub

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class