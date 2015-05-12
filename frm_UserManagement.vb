﻿Imports ADODB

Public Class frm_UserManagement
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Sub clearcheckbox()
        cek_File.Checked = False
        cek_SystemControl.Checked = False
        cek_OfficeModules.Checked = False
        cek_LogApplication.Checked = False
        cek_LogOut.Checked = False
        cek_Exit.Checked = False
        cek_ChangeMyPassword.Checked = False
        cek_AddNewUser.Checked = False
        cek_ChangeUserDetails.Checked = False
        cek_RemoveUser.Checked = False
        cek_UserManagement.Checked = False

    End Sub
    Private Sub frm_UserManagement_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub frm_UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbo_Username.Focus()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        lbl_Locked.Visible = False
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

            rs = cn.Execute("SELECT [username] FROM  [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] where [priority] < '" & CurrentAccountPriority & "' ")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                While Not rs.EOF
                    cbo_Username.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
            End If

            Me.Show()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub cek_File_CheckedChanged(sender As Object, e As EventArgs) Handles cek_File.CheckedChanged

        If cek_File.Checked Then
            GroupBox1.Show()
            GroupBox2.Visible = False
        End If
        If cek_File.Checked = False Then
            GroupBox1.Visible = False
        End If
  
    End Sub

    Private Sub cbo_Username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Username.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT TOP 1 [username] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & cbo_Username.Text & "' ORDER BY [username] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_Name.Text = rs(0).Value.ToString
                txt_Name.Enabled = False
                lbl_Locked.Visible = True
            End If
            rs = cn.Execute("SELECT TOP 1 [id] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & cbo_Username.Text & "' ORDER BY [username] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then

                txt_Id.Text = rs(0).Value.ToString
            End If
            rs = cn.Execute("SELECT TOP 1 [username] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & cbo_Username.Text & "' ORDER BY [username] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then

                txt_Username.Text = rs(0).Value.ToString
            End If


            rs = cn.Execute("Select * From [AN_SUMATRA].[dbo].[TM_tb_Access] where [level] = '" & cbo_Username.Text & "'")
            If Not rs.EOF Then
                cek_File.Checked = rs(1).Value
                cek_SystemControl.Checked = rs(2).Value
                cek_OfficeModules.Checked = rs(3).Value
                cek_LogApplication.Checked = rs(4).Value
                cek_LogOut.Checked = rs(5).Value
                cek_Exit.Checked = rs(6).Value
                cek_ChangeMyPassword.Checked = rs(7).Value
                cek_AddNewUser.Checked = rs(8).Value
                cek_ChangeUserDetails.Checked = rs(9).Value
                cek_RemoveUser.Checked = rs(10).Value
                cek_UserManagement.Checked = rs(11).Value
            End If


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cek_SystemControl_CheckedChanged(sender As Object, e As EventArgs) Handles cek_SystemControl.CheckedChanged
        If cek_SystemControl.Checked Then
            GroupBox2.Show()
            GroupBox1.Visible = False
            GroupBox2.Location = New Point(140, 203)
        End If
        If cek_SystemControl.Checked = False Then
            GroupBox2.Visible = False
        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call clearcheckbox()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        Try
            Dim sqlUpdate As String = "Update [AN_SUMATRA].[dbo].[TM_tb_Access] set [file]='" & CInt(cek_File.Checked) * -1 & "'," _
            & "[system_control] = '" & CInt(cek_SystemControl.Checked) * -1 & "'," _
            & "[office_modules] = '" & CInt(cek_OfficeModules.Checked) * -1 & "'," _
            & "[log_application]='" & CInt(cek_LogApplication.Checked) * -1 & "'," _
            & "[log_out]='" & CInt(cek_LogOut.Checked) * -1 & "'," _
            & "[exit]='" & CInt(cek_Exit.Checked) * -1 & "'," _
            & "[change_my_password]='" & CInt(cek_ChangeMyPassword.Checked) * -1 & "'," _
            & "[add_new_user]='" & CInt(cek_AddNewUser.Checked) * -1 & "'," _
            & "[change_user_details]='" & CInt(cek_ChangeUserDetails.Checked) * -1 & "'," _
            & "[remove_user]='" & CInt(cek_RemoveUser.Checked) * -1 & "'," _
            & "[user_management]='" & CInt(cek_UserManagement.Checked) * -1 & "' where [level]='" & cbo_Username.Text & "'"

            cn.Execute(sqlUpdate)
            MsgBox("Access is Change")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
End Class