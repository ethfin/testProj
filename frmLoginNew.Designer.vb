<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginNew))
        Me.panelLogin = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblIncorrect = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lnklblReset = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.panelLogin2 = New System.Windows.Forms.Panel()
        Me.lblSignUp = New System.Windows.Forms.LinkLabel()
        Me.lblCopyright = New System.Windows.Forms.LinkLabel()
        Me.panelLogin.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogin2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelLogin
        '
        Me.panelLogin.BackColor = System.Drawing.Color.White
        Me.panelLogin.Controls.Add(Me.lblCopyright)
        Me.panelLogin.Controls.Add(Me.panelLogin2)
        Me.panelLogin.Controls.Add(Me.lblIncorrect)
        Me.panelLogin.Controls.Add(Me.btnLogin)
        Me.panelLogin.Controls.Add(Me.lnklblReset)
        Me.panelLogin.Controls.Add(Me.txtPassword)
        Me.panelLogin.Controls.Add(Me.txtUsername)
        Me.panelLogin.Controls.Add(Me.Label1)
        Me.panelLogin.Controls.Add(Me.lblWelcome1)
        Me.panelLogin.Controls.Add(Me.Guna2PictureBox1)
        Me.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLogin.Location = New System.Drawing.Point(0, 0)
        Me.panelLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(1233, 604)
        Me.panelLogin.TabIndex = 1
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = False
        Me.lblIncorrect.BackColor = System.Drawing.Color.Transparent
        Me.lblIncorrect.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.ForeColor = System.Drawing.Color.Red
        Me.lblIncorrect.Location = New System.Drawing.Point(94, 457)
        Me.lblIncorrect.Margin = New System.Windows.Forms.Padding(4)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(488, 32)
        Me.lblIncorrect.TabIndex = 5
        Me.lblIncorrect.Text = "Error"
        Me.lblIncorrect.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblIncorrect.Visible = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BorderThickness = 2
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.Color.White
        Me.btnSignUp.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btnSignUp.ForeColor = System.Drawing.Color.Black
        Me.btnSignUp.HoverState.FillColor = System.Drawing.Color.Black
        Me.btnSignUp.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.IndicateFocus = True
        Me.btnSignUp.Location = New System.Drawing.Point(181, 517)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(240, 55)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "Sign up"
        '
        'btnLogin
        '
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.Black
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IndicateFocus = True
        Me.btnLogin.Location = New System.Drawing.Point(218, 502)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(240, 55)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        '
        'lnklblReset
        '
        Me.lnklblReset.AutoSize = True
        Me.lnklblReset.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnklblReset.LinkColor = System.Drawing.Color.Gray
        Me.lnklblReset.Location = New System.Drawing.Point(81, 414)
        Me.lnklblReset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnklblReset.Name = "lnklblReset"
        Me.lnklblReset.Size = New System.Drawing.Size(100, 16)
        Me.lnklblReset.TabIndex = 2
        Me.lnklblReset.TabStop = True
        Me.lnklblReset.Text = "Reset account?"
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.Gray
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(84, 369)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(488, 45)
        Me.txtPassword.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.Gray
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(84, 316)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(488, 45)
        Me.txtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 252)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Level Up Your Game!"
        '
        'lblWelcome1
        '
        Me.lblWelcome1.AutoSize = True
        Me.lblWelcome1.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome1.Location = New System.Drawing.Point(211, 171)
        Me.lblWelcome1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome1.Name = "lblWelcome1"
        Me.lblWelcome1.Size = New System.Drawing.Size(255, 40)
        Me.lblWelcome1.TabIndex = 0
        Me.lblWelcome1.Text = "Account Login"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(218, 42)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(223, 90)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnClose.IndicateFocus = True
        Me.btnClose.Location = New System.Drawing.Point(1193, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 37)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "X"
        Me.btnClose.UseTransparentBackground = True
        '
        'panelLogin2
        '
        Me.panelLogin2.BackgroundImage = CType(resources.GetObject("panelLogin2.BackgroundImage"), System.Drawing.Image)
        Me.panelLogin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelLogin2.Controls.Add(Me.lblSignUp)
        Me.panelLogin2.Controls.Add(Me.btnSignUp)
        Me.panelLogin2.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelLogin2.Location = New System.Drawing.Point(655, 0)
        Me.panelLogin2.Name = "panelLogin2"
        Me.panelLogin2.Size = New System.Drawing.Size(578, 604)
        Me.panelLogin2.TabIndex = 7
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lblSignUp.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblSignUp.LinkColor = System.Drawing.Color.GhostWhite
        Me.lblSignUp.Location = New System.Drawing.Point(146, 576)
        Me.lblSignUp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(311, 19)
        Me.lblSignUp.TabIndex = 8
        Me.lblSignUp.TabStop = True
        Me.lblSignUp.Text = "Don't have an account? Signup now!"
        Me.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblCopyright.LinkColor = System.Drawing.Color.Black
        Me.lblCopyright.Location = New System.Drawing.Point(173, 574)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(331, 21)
        Me.lblCopyright.TabIndex = 9
        Me.lblCopyright.TabStop = True
        Me.lblCopyright.Text = "© 2024 ChronoPulse. All rights reserved."
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLoginNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 604)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.panelLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLoginNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoginNew"
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogin2.ResumeLayout(False)
        Me.panelLogin2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcome1 As Label
    Friend WithEvents lnklblReset As LinkLabel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblIncorrect As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents panelLogin2 As Panel
    Friend WithEvents lblSignUp As LinkLabel
    Friend WithEvents lblCopyright As LinkLabel
End Class
