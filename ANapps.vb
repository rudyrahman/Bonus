Imports System.Windows.Forms

Public Class ANapps

    Private Sub ANapps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True
        frm_login.ShowDialog()
    End Sub

    Private Sub mnu_UserManagement_Click(sender As Object, e As EventArgs) Handles mnu_UserManagement.Click
        'frm_UserManagement.Show()
    End Sub

    Private Sub mnu_AddNewUser_Click(sender As Object, e As EventArgs) Handles mnu_AddNewUser.Click

    End Sub
End Class
