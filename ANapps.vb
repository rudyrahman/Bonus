Imports System.Windows.Forms
Imports ADODB
Public Class ANapps
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub ANapps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnu_ProcessingFloorModule.Visible = False
        mnu_DataProcessing.Visible = False
        mnu_DataRevision.Visible = False
        mnu_SystemQuery.Visible = False
        mnu_UserQuery.Visible = False
        mnu_Reporting.Visible = False
        mnu_SapB1Interface.Visible = False
        mnu_PisiSoftInterface.Visible = False
        Me.Visible = True
        frm_login.ShowDialog()
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        Try
            rs = cn.Execute("Select * From [AN_SUMATRA].[dbo].[TM_tb_Access] where [level] = '" & CurrentAccountName & "'")
            If Not rs.EOF Then
                mnu_File.Visible = rs(1).Value
                mnu_System.Visible = rs(2).Value
                mnu_OfficeModule.Visible = rs(3).Value
                mnu_LockApplication.Visible = rs(4).Value
                mnu_Logout.Visible = rs(5).Value
                mnu_Exit.Visible = rs(6).Value
                mnu_ChangeMyPassword.Visible = rs(7).Value
                mnu_AddNewUser.Visible = rs(8).Value
                mnu_ChangeUserDetails.Visible = rs(9).Value
                mnu_RemoveUser.Visible = rs(10).Value
                mnu_UserManagement.Visible = rs(11).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub mnu_UserManagement_Click(sender As Object, e As EventArgs) Handles mnu_UserManagement.Click
        frm_UserManagement.Show()
    End Sub

    Private Sub mnu_AddNewUser_Click(sender As Object, e As EventArgs) Handles mnu_AddNewUser.Click
        frm_NewUser.Show()
    End Sub

    Private Sub mnu_ChangeMyPassword_Click(sender As Object, e As EventArgs) Handles mnu_ChangeMyPassword.Click
        frm_ChangePassword.Show()
    End Sub

    Private Sub mnu_ChangeUserDetails_Click(sender As Object, e As EventArgs) Handles mnu_ChangeUserDetails.Click
        frm_ChangeDetail.Show()
    End Sub

    Private Sub mnu_RemoveUser_Click(sender As Object, e As EventArgs) Handles mnu_RemoveUser.Click
        frm_Remove.Show()
    End Sub

    Private Sub mnu_LockApplication_Click(sender As Object, e As EventArgs) Handles mnu_LockApplication.Click
        frm_SystemLock.Show()
    End Sub

End Class
