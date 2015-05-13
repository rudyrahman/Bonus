Imports ADODB
Public Class frm_UserManagement
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_Username.Focus()
        grp_2.Visible = False
        grp_3.Visible = False
        Pic_Lock.Visible = False
        grp_1.Visible = False
        lbl_userm.Location = New Point(154, 234)
        btn_Save.Visible = False
        btn_clear.Visible = False
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

            rs = cn.Execute("SELECT [username] FROM  [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] where [priority] > '" & CurrentAccountPriority & "' ")
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


    End Sub

    Private Sub cbo_Username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Username.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT TOP 1 [realname] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & cbo_Username.Text & "' ORDER BY [username] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_Name.Text = rs(0).Value.ToString
                txt_Name.Enabled = False
                Pic_Lock.Visible = True
                grp_1.Visible = True
                lbl_userm.Visible = False
                btn_Save.Visible = True
                btn_clear.Visible = True
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

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
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

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            If (rs.EOF = True) And (rs.BOF = True) Then
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_Access] ([level],[file],[system_control],[office_modules],[log_application],[log_out],[exit],[change_my_password],[add_new_user],[change_user_details],[remove_user],[user_management],[createdby]) VALUES "
                sqlInsert = sqlInsert & " ('" & cbo_Username.Text.ToString & "'" & _
                    ",'" & CInt(cek_File.Checked) * -1 & "'" & _
                    ",'" & CInt(cek_SystemControl.Checked) * -1 & "'" & _
                ",'" & CInt(cek_OfficeModules.Checked) * -1 & "'" & _
               ",'" & CInt(cek_LogApplication.Checked) * -1 & "'" & _
                ",'" & CInt(cek_LogOut.Checked) * -1 & "'" & _
               ",'" & CInt(cek_Exit.Checked) * -1 & "'" & _
                ",'" & CInt(cek_ChangeMyPassword.Checked) * -1 & "'" & _
                ",'" & CInt(cek_AddNewUser.Checked) * -1 & "'" & _
               ",'" & CInt(cek_ChangeUserDetails.Checked) * -1 & "'" & _
               ",'" & CInt(cek_RemoveUser.Checked) * -1 & "'" & _
               ",'" & CInt(cek_UserManagement.Checked) * -1 & "'" & _
            ",'" & CurrentAccountName & "')"
                cn.Execute(sqlInsert)
                MsgBox("Save Success")

            Else
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
                & "[user_management]='" & CInt(cek_UserManagement.Checked) * -1 & "' where [createdby]='" & CurrentAccountName & "' AND [level]= '" & cbo_Username.Text & "'"

                cn.Execute(sqlUpdate)
                MsgBox("Access is Change")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub cek_SystemControl_MouseClick(sender As Object, e As MouseEventArgs) Handles cek_SystemControl.MouseClick
        If cek_SystemControl.Checked Then
            grp_3.Show()
            grp_2.Visible = False
            grp_3.Location = New Point(139, 212)
        End If
        If cek_SystemControl.Checked = False Then
            grp_3.Visible = False
        End If
    End Sub

    Private Sub cek_File_MouseClick(sender As Object, e As MouseEventArgs) Handles cek_File.MouseClick

        If cek_File.Checked Then
            grp_2.Show()
            grp_3.Visible = False
        End If
        If cek_File.Checked = False Then
            grp_2.Visible = False
        End If
    End Sub

End Class