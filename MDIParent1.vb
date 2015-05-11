Imports System.Windows.Forms

Public Class ANapps

    Private Sub ANapps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True
        frm_login.ShowDialog()
    End Sub
End Class
