﻿Imports ADODB
Public Class frm_UserManagement
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub frm_UserManagement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frm_UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbo_Username.Items.Clear()
            txt_Name.Text = ""
            txt_Id.Text = ""
            txt_Username.Text = ""
            cbo_Username.Focus()
            CheckedListBox1.Visible = False
            chk_SystemControl.Visible = False
            chk_file.Visible = False
            chk_Menu.Visible = False
            btn_Save.Visible = False
            btn_clear.Visible = False
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

    Private Sub cek_File_CheckedChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub cbo_Username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Username.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT TOP 1 [realname] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & cbo_Username.Text & "' ORDER BY [username] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_Name.Text = rs(0).Value.ToString
                chk_Menu.Visible = True
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
                chk_Menu.SetItemChecked(0, rs(1).Value)
                chk_Menu.SetItemChecked(1, rs(2).Value)
                chk_Menu.SetItemChecked(2, rs(3).Value)
                chk_Menu.SetItemChecked(3, rs(12).Value)
                chk_Menu.SetItemChecked(4, rs(13).Value)
                chk_Menu.SetItemChecked(5, rs(14).Value)
                chk_Menu.SetItemChecked(6, rs(15).Value)
                chk_Menu.SetItemChecked(7, rs(16).Value)
                chk_Menu.SetItemChecked(8, rs(17).Value)
                chk_Menu.SetItemChecked(9, rs(18).Value)
                chk_Menu.SetItemChecked(10, rs(19).Value)
                chk_file.SetItemChecked(0, rs(4).Value)
                chk_file.SetItemChecked(1, rs(5).Value)
                chk_file.SetItemChecked(2, rs(6).Value)
                chk_SystemControl.SetItemChecked(0, rs(7).Value)
                chk_SystemControl.SetItemChecked(1, rs(8).Value)
                chk_SystemControl.SetItemChecked(2, rs(9).Value)
                chk_SystemControl.SetItemChecked(3, rs(10).Value)
                chk_SystemControl.SetItemChecked(4, rs(11).Value)

            End If

            rs = cn.Execute("Select * From [AN_SUMATRA].[dbo].[TM_tb_Access] where [level] = '" & cbo_Username.Text & "'")
            If Not rs.EOF = Nothing Then
                chk_Menu.SetItemChecked(0, False)
                chk_Menu.SetItemChecked(1, False)
                chk_Menu.SetItemChecked(2, False)
                chk_Menu.SetItemChecked(3, False)
                chk_Menu.SetItemChecked(4, False)
                chk_Menu.SetItemChecked(5, False)
                chk_Menu.SetItemChecked(6, False)
                chk_Menu.SetItemChecked(7, False)
                chk_Menu.SetItemChecked(8, False)
                chk_Menu.SetItemChecked(9, False)
                chk_Menu.SetItemChecked(10, False)
                chk_file.SetItemChecked(0, False)
                chk_file.SetItemChecked(1, False)
                chk_file.SetItemChecked(2, False)
                chk_SystemControl.SetItemChecked(0, False)
                chk_SystemControl.SetItemChecked(1, False)
                chk_SystemControl.SetItemChecked(2, False)
                chk_SystemControl.SetItemChecked(3, False)
                chk_SystemControl.SetItemChecked(4, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cek_SystemControl_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Try
            chk_Menu.SetItemChecked(0, False)
            chk_Menu.SetItemChecked(1, False)
            chk_Menu.SetItemChecked(2, False)
            chk_Menu.SetItemChecked(3, False)
            chk_Menu.SetItemChecked(4, False)
            chk_Menu.SetItemChecked(5, False)
            chk_Menu.SetItemChecked(6, False)
            chk_Menu.SetItemChecked(7, False)
            chk_Menu.SetItemChecked(8, False)
            chk_Menu.SetItemChecked(9, False)
            chk_Menu.SetItemChecked(10, False)
            chk_file.SetItemChecked(0, False)
            chk_file.SetItemChecked(1, False)
            chk_file.SetItemChecked(2, False)
            chk_SystemControl.SetItemChecked(0, False)
            chk_SystemControl.SetItemChecked(1, False)
            chk_SystemControl.SetItemChecked(2, False)
            chk_SystemControl.SetItemChecked(3, False)
            chk_SystemControl.SetItemChecked(4, False)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            If (rs.EOF = True) And (rs.BOF = True) Then
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_Access] ([level],[file],[system_control],[office_modules],[log_application],[log_out],[exit],[change_my_password],[add_new_user],[change_user_details],[remove_user],[user_management],[processing_floor_module],[data_processing],[data_revision],[system_ query],[user_query],[reporting],[sap_b1_interface],[pisi_soft_interface],[createdby]) VALUES "
                sqlInsert = sqlInsert & " ('" & cbo_Username.Text.ToString & "'" & _
                    ",'" & CInt(chk_Menu.GetItemChecked(0)) * -1 & "'" & _
                    ",'" & CInt(chk_Menu.GetItemChecked(1)) * -1 & "'" & _
                ",'" & CInt(chk_Menu.GetItemChecked(2)) * -1 & "'" & _
               ",'" & CInt(chk_file.GetItemChecked(0)) * -1 & "'" & _
                ",'" & CInt(chk_file.GetItemChecked(1)) * -1 & "'" & _
               ",'" & CInt(chk_file.GetItemChecked(2)) * -1 & "'" & _
                ",'" & CInt(chk_SystemControl.GetItemChecked(0)) * -1 & "'" & _
                ",'" & CInt(chk_SystemControl.GetItemChecked(1)) * -1 & "'" & _
               ",'" & CInt(chk_SystemControl.GetItemChecked(2)) * -1 & "'" & _
               ",'" & CInt(chk_SystemControl.GetItemChecked(3)) * -1 & "'" & _
               ",'" & CInt(chk_SystemControl.GetItemChecked(4)) * -1 & "'" & _
               ",'" & CInt(chk_Menu.GetItemChecked(3)) * -1 & "'" & _
               ",'" & CInt(chk_Menu.GetItemChecked(4)) * -1 & "'" & _
               ",'" & CInt(chk_Menu.GetItemChecked(5)) * -1 & "'" & _
               ",'" & CInt(chk_Menu.GetItemChecked(6)) * -1 & "'" & _
               ",'" & CInt(chk_Menu.GetItemChecked(7)) * -1 & "'" & _
               ",'" & CInt(chk_Menu.GetItemChecked(8)) * -1 & "'" & _
               ",'" & CInt(chk_Menu.GetItemChecked(9)) * -1 & "'" & _
               ",'" & CInt(chk_Menu.GetItemChecked(10)) * -1 & "'" & _
            ",'" & CurrentAccountName & "')"
                cn.Execute(sqlInsert)

            Else
                Dim sqlUpdate As String = "Update [AN_SUMATRA].[dbo].[TM_tb_Access] set [file]='" & CInt(chk_Menu.GetItemChecked(0)) * -1 & "'," _
                & "[system_control] = '" & CInt(chk_Menu.GetItemChecked(1)) * -1 & "'," _
                & "[office_modules] = '" & CInt(chk_Menu.GetItemChecked(2)) * -1 & "'," _
                & "[processing_floor_module] = '" & CInt(chk_Menu.GetItemChecked(3)) * -1 & "'," _
                & "[data_processing] = '" & CInt(chk_Menu.GetItemChecked(4)) * -1 & "'," _
                & "[data_revision] = '" & CInt(chk_Menu.GetItemChecked(5)) * -1 & "'," _
                & "[system_ query] = '" & CInt(chk_Menu.GetItemChecked(6)) * -1 & "'," _
                & "[user_query] = '" & CInt(chk_Menu.GetItemChecked(7)) * -1 & "'," _
                & "[reporting] = '" & CInt(chk_Menu.GetItemChecked(8)) * -1 & "'," _
                & "[sap_b1_interface] = '" & CInt(chk_Menu.GetItemChecked(9)) * -1 & "'," _
                & "[pisi_soft_interface] = '" & CInt(chk_Menu.GetItemChecked(10)) * -1 & "'," _
                & "[log_application]='" & CInt(chk_file.GetItemChecked(0)) * -1 & "'," _
                & "[log_out]='" & CInt(chk_file.GetItemChecked(1)) * -1 & "'," _
                & "[exit]='" & CInt(chk_file.GetItemChecked(2)) * -1 & "'," _
                & "[change_my_password]='" & CInt(chk_SystemControl.GetItemChecked(0)) * -1 & "'," _
                & "[add_new_user]='" & CInt(chk_SystemControl.GetItemChecked(1)) * -1 & "'," _
                & "[change_user_details]='" & CInt(chk_SystemControl.GetItemChecked(2)) * -1 & "'," _
                & "[remove_user]='" & CInt(chk_SystemControl.GetItemChecked(3)) * -1 & "'," _
                & "[user_management]='" & CInt(chk_SystemControl.GetItemChecked(4)) * -1 & "' where [createdby]='" & CurrentAccountName & "' AND [level]= '" & cbo_Username.Text & "'"

                cn.Execute(sqlUpdate)

                End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub chk_Menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chk_Menu.SelectedIndexChanged
        Try
            If chk_Menu.GetSelected(0) = True Then
                chk_file.Visible = True
                chk_SystemControl.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(1) = True Then
                chk_SystemControl.Visible = True
                chk_file.Visible = False
                chk_SystemControl.Location = New Point(171, 202)
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(2) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(3) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(4) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(5) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(6) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(7) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(8) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(9) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If
            If chk_Menu.GetSelected(10) = True Then
                chk_SystemControl.Visible = False
                chk_file.Visible = False
                CheckedListBox1.Visible = False
            End If

            If chk_Menu.GetItemChecked(0) = False Then
                chk_file.SetItemChecked(0, False)
                chk_file.SetItemChecked(1, False)
                chk_file.SetItemChecked(2, False)
            End If
            If chk_Menu.GetItemChecked(0) = True Then
                chk_file.SetItemChecked(0, True)
                chk_file.SetItemChecked(1, True)
                chk_file.SetItemChecked(2, True)
            End If

            If chk_Menu.GetItemChecked(1) = False Then
                chk_SystemControl.SetItemChecked(0, False)
                chk_SystemControl.SetItemChecked(1, False)
                chk_SystemControl.SetItemChecked(2, False)
                chk_SystemControl.SetItemChecked(3, False)
                chk_SystemControl.SetItemChecked(4, False)
            End If
            If chk_Menu.GetItemChecked(1) = True Then
                chk_SystemControl.SetItemChecked(0, True)
                chk_SystemControl.SetItemChecked(1, True)
                chk_SystemControl.SetItemChecked(2, True)
                chk_SystemControl.SetItemChecked(3, True)
                chk_SystemControl.SetItemChecked(4, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub chk_SystemControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chk_SystemControl.SelectedIndexChanged
        Try
            If chk_SystemControl.GetSelected(0) = True Then
                CheckedListBox1.Visible = True
                CheckedListBox1.Location = New Point(305, 202)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub chk_file_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chk_file.SelectedIndexChanged
        Try
            If chk_file.GetSelected(0) = True Then
                CheckedListBox1.Visible = True
                CheckedListBox1.Location = New Point(297, 202)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

End Class