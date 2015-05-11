Imports System.Windows.Forms

Public Class ANapps

    Private Sub ANapps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True
        frm_login.ShowDialog()
    End Sub

    Private Sub mnu_ChangeMyPassword_Click(sender As Object, e As EventArgs) Handles mnu_ChangeMyPassword.Click
        frm_ChangePassword.Show()
    End Sub

    Private Sub mnu_AddNewUser_Click(sender As Object, e As EventArgs) Handles mnu_AddNewUser.Click
        frm_NewUser.Show()
    End Sub
End Class
