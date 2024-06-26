Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient


Public Class frmLoginNew

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Define the Windows message constant for system commands
        Const WM_SYSCOMMAND As Integer = &H112
        ' Define the command value for maximizing the window
        Const SC_MAXIMIZE As Integer = &HF030

        ' Check if the message is a system command
        If m.Msg = WM_SYSCOMMAND Then
            ' Check if the command is to maximize the window
            If m.WParam.ToInt32() = SC_MAXIMIZE Then
                ' Prevent the default behavior by not calling the base method
                Return
            End If
        End If

        ' Call the base class method for default processing of other messages
        MyBase.WndProc(m)
    End Sub


    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    ' The MouseDown event for the panel to initiate the form dragging.
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLogin.MouseDown, pnlBackground.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub frmLoginNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Confirm before closing the application.
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Closes the entire application.
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim conn As MySqlConnection = Common.getDBConnectionX()

        Try
            ' Open the connection
            conn.Open()

            ' SQL query to check if the user exists with the given username and password
            Dim query As String = "SELECT COUNT(*) FROM dbaccounts WHERE username = @username AND password = @password"
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
                Me.Close()
                frmMain.WindowState = FormWindowState.Normal
                frmMain.ShowInTaskbar = True
                frmMain.Show()
            Else
                lblError.Text = "Invalid username or password."
                lblError.Show()
            End If

        Catch ex As Exception
            ' Handle any errors that occur
            lblError.Text = "Error: " & ex.Message
            lblError.Show()
        Finally
            ' Close the connection whether or not an error occurred
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        frmSignUpNew.Show()
    End Sub

    Private Sub lblError_Click(sender As Object, e As EventArgs) Handles lblError.Click

    End Sub

    Private Sub panelLogin_Paint(sender As Object, e As PaintEventArgs) Handles panelLogin.Paint

    End Sub
End Class