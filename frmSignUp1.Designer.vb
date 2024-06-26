<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtReenterPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPasswordNotice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPasswordNotice2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPasswordNotice1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.BorderRadius = 4
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(44, 96)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(256, 36)
        Me.txtUsername.TabIndex = 26
        '
        'txtReenterPassword
        '
        Me.txtReenterPassword.BorderRadius = 4
        Me.txtReenterPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReenterPassword.DefaultText = ""
        Me.txtReenterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReenterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReenterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReenterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReenterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReenterPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtReenterPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReenterPassword.Location = New System.Drawing.Point(44, 226)
        Me.txtReenterPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtReenterPassword.Name = "txtReenterPassword"
        Me.txtReenterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReenterPassword.PlaceholderText = "Re-enter Password"
        Me.txtReenterPassword.SelectedText = ""
        Me.txtReenterPassword.Size = New System.Drawing.Size(256, 36)
        Me.txtReenterPassword.TabIndex = 25
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 4
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(44, 184)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(256, 36)
        Me.txtPassword.TabIndex = 24
        '
        'txtEmail
        '
        Me.txtEmail.BorderRadius = 4
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(44, 140)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(256, 36)
        Me.txtEmail.TabIndex = 23
        '
        'btnSignUp
        '
        Me.btnSignUp.BorderRadius = 10
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSignUp.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(64, 292)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(180, 45)
        Me.btnSignUp.TabIndex = 27
        Me.btnSignUp.Text = "Next"
        '
        'lblPasswordNotice
        '
        Me.lblPasswordNotice.AutoSize = False
        Me.lblPasswordNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordNotice.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPasswordNotice.Location = New System.Drawing.Point(306, 210)
        Me.lblPasswordNotice.Name = "lblPasswordNotice"
        Me.lblPasswordNotice.Size = New System.Drawing.Size(193, 29)
        Me.lblPasswordNotice.TabIndex = 28
        Me.lblPasswordNotice.Text = "Password Must have 3 of the following :"
        '
        'lblPasswordNotice2
        '
        Me.lblPasswordNotice2.AutoSize = False
        Me.lblPasswordNotice2.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordNotice2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPasswordNotice2.Location = New System.Drawing.Point(306, 226)
        Me.lblPasswordNotice2.Name = "lblPasswordNotice2"
        Me.lblPasswordNotice2.Size = New System.Drawing.Size(108, 39)
        Me.lblPasswordNotice2.TabIndex = 29
        Me.lblPasswordNotice2.Text = "Capital Characters Small Letters Numbers"
        '
        'lblPasswordNotice1
        '
        Me.lblPasswordNotice1.AutoSize = False
        Me.lblPasswordNotice1.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordNotice1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPasswordNotice1.Location = New System.Drawing.Point(306, 190)
        Me.lblPasswordNotice1.Name = "lblPasswordNotice1"
        Me.lblPasswordNotice1.Size = New System.Drawing.Size(142, 14)
        Me.lblPasswordNotice1.TabIndex = 30
        Me.lblPasswordNotice1.Text = "Must have 12- 30 Characters"
        '
        'frmSignUp1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 450)
        Me.Controls.Add(Me.lblPasswordNotice1)
        Me.Controls.Add(Me.lblPasswordNotice2)
        Me.Controls.Add(Me.lblPasswordNotice)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtReenterPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Name = "frmSignUp1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtReenterPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPasswordNotice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPasswordNotice2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPasswordNotice1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
