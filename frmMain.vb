Imports Org.BouncyCastle.Crypto
Imports System.Web.UI.WebControls

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        frmLoginNew.Show()
        Me.Hide()
    End Sub
End Class