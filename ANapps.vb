Imports System.Windows.Forms
Imports ADODB
Public Class ANapps
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub ANapps_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        status.Text = CurrentAccountName
    End Sub

    Private Sub ANapps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                mnu_ProcessingFloorModule.Visible = rs(12).Value
                mnu_DataProcessing.Visible = rs(13).Value
                mnu_DataRevision.Visible = rs(14).Value
                mnu_SystemQuery.Visible = rs(15).Value
                mnu_UserQuery.Visible = rs(16).Value
                mnu_Reporting.Visible = rs(17).Value
                mnu_SapB1Interface.Visible = rs(18).Value
                mnu_PisiSoftInterface.Visible = rs(19).Value

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub mnu_UserManagement_Click(sender As Object, e As EventArgs) Handles mnu_UserManagement.Click
        frm_UserManagement.ShowDialog()
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
        frm_SystemLock.ShowDialog()
    End Sub

    Private Sub mnu_Exit_Click(sender As Object, e As EventArgs) Handles mnu_Exit.Click
        End
    End Sub

    Private Sub MasterDevisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDevisionToolStripMenuItem.Click
        frm_MasterDevision.MdiParent = Me
        frm_MasterDevision.Show()
        frm_MasterDevision.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasterDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDepartmentToolStripMenuItem.Click
        frm_MasterDepartment.MdiParent = Me
        frm_MasterDepartment.Show()
        frm_MasterDepartment.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasterSectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterSectionToolStripMenuItem.Click
        frm_MasterSection.MdiParent = Me
        frm_MasterSection.Show()
        frm_MasterSection.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasterSubSectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterSubSectionToolStripMenuItem.Click
        frm_MasterSubSection.MdiParent = Me
        frm_MasterSubSection.Show()
        frm_MasterSubSection.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasterWorkgroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterWorkgroupToolStripMenuItem.Click
        frm_MasterWorkgroup.MdiParent = Me
        frm_MasterWorkgroup.Show()
        frm_MasterWorkgroup.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasterShiftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterShiftToolStripMenuItem.Click
        frm_MasterShift.MdiParent = Me
        frm_MasterShift.Show()
        frm_MasterShift.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasterEmployeesStatusArragementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterEmployeesStatusArragementToolStripMenuItem.Click
        frm_MasterEDataRegistration.MdiParent = Me
        frm_MasterEDataRegistration.Show()
        frm_MasterEDataRegistration.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasterEmployeesStatusArragementToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MasterEmployeesStatusArragementToolStripMenuItem1.Click
        frm_MasterEStatusArragement.MdiParent = Me
        frm_MasterEStatusArragement.Show()
        frm_MasterEStatusArragement.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasterAttendanceStaffClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterAttendanceStaffClassToolStripMenuItem.Click
 
    End Sub
End Class
