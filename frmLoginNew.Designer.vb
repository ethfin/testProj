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
        Me.lblError = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lnklblReset = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlBackground = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblSignInNotice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.panelLogin.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelLogin
        '
        Me.panelLogin.BackColor = System.Drawing.Color.White
        Me.panelLogin.Controls.Add(Me.lblError)
        Me.panelLogin.Controls.Add(Me.btnLogin)
        Me.panelLogin.Controls.Add(Me.lnklblReset)
        Me.panelLogin.Controls.Add(Me.txtPassword)
        Me.panelLogin.Controls.Add(Me.txtUsername)
        Me.panelLogin.Controls.Add(Me.Label1)
        Me.panelLogin.Controls.Add(Me.lblWelcome1)
        Me.panelLogin.Controls.Add(Me.Guna2PictureBox1)
        Me.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLogin.Location = New System.Drawing.Point(0, 0)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(550, 491)
        Me.panelLogin.TabIndex = 1
        '
        'lblError
        '
        Me.lblError.AutoSize = False
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(86, 363)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(366, 26)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "Error"
        Me.lblError.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 2
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.Black
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IndicateFocus = True
        Me.btnLogin.Location = New System.Drawing.Point(177, 395)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(180, 45)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        '
        'lnklblReset
        '
        Me.lnklblReset.AutoSize = True
        Me.lnklblReset.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnklblReset.LinkColor = System.Drawing.Color.Red
        Me.lnklblReset.Location = New System.Drawing.Point(369, 336)
        Me.lnklblReset.Name = "lnklblReset"
        Me.lnklblReset.Size = New System.Drawing.Size(83, 13)
        Me.lnklblReset.TabIndex = 2
        Me.lnklblReset.TabStop = True
        Me.lnklblReset.Text = "Reset account?"
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.Gray
        Me.txtPassword.BorderRadius = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(86, 292)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(366, 41)
        Me.txtPassword.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.Gray
        Me.txtUsername.BorderRadius = 2
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(86, 252)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(366, 41)
        Me.txtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "welcome!"
        '
        'lblWelcome1
        '
        Me.lblWelcome1.AutoSize = True
        Me.lblWelcome1.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome1.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome1.Location = New System.Drawing.Point(78, 131)
        Me.lblWelcome1.Name = "lblWelcome1"
        Me.lblWelcome1.Size = New System.Drawing.Size(130, 49)
        Me.lblWelcome1.TabIndex = 0
        Me.lblWelcome1.Text = "Hello,"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(61, 38)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(167, 73)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btnSignUp
        '
        Me.btnSignUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BorderRadius = 2
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
        Me.btnSignUp.Location = New System.Drawing.Point(102, 277)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(180, 45)
        Me.btnSignUp.TabIndex = 4
        Me.btnSignUp.Text = "Sign up"
        Me.btnSignUp.UseTransparentBackground = True
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
        Me.btnClose.Location = New System.Drawing.Point(895, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "X"
        Me.btnClose.UseTransparentBackground = True
        '
        'pnlBackground
        '
        Me.pnlBackground.BackgroundImage = CType(resources.GetObject("pnlBackground.BackgroundImage"), System.Drawing.Image)
        Me.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBackground.Controls.Add(Me.lblSignInNotice)
        Me.pnlBackground.Controls.Add(Me.btnSignUp)
        Me.pnlBackground.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBackground.Location = New System.Drawing.Point(550, 0)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(375, 491)
        Me.pnlBackground.TabIndex = 6
        '
        'lblSignInNotice
        '
        Me.lblSignInNotice.AutoSize = False
        Me.lblSignInNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblSignInNotice.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignInNotice.ForeColor = System.Drawing.Color.White
        Me.lblSignInNotice.IsSelectionEnabled = False
        Me.lblSignInNotice.Location = New System.Drawing.Point(0, 180)
        Me.lblSignInNotice.Name = "lblSignInNotice"
        Me.lblSignInNotice.Size = New System.Drawing.Size(375, 77)
        Me.lblSignInNotice.TabIndex = 26
        Me.lblSignInNotice.Text = "Haven't made an account?"
        Me.lblSignInNotice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLoginNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 491)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.pnlBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoginNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoginNew"
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackground.ResumeLayout(False)
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
    Friend WithEvents lblError As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlBackground As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSignInNotice As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
