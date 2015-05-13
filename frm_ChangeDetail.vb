﻿Imports ADODB

Public Class frm_ChangeDetail
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_ChangeDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbo_id.Focus()
            txt_username.Enabled = False
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = cn.Execute("SELECT [id], [username] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [priority] < '" & CurrentAccountPriority & "' ORDER BY [id] ASC")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                While Not rs.EOF
                    cbo_id.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If MessageBox.Show("Yakin data akan diganti ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim sqlUpdate As String = "Update [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] set [password]='" & txt_pass.Text & "', [lastpasswordchange]='" & txt_lastpass.Text & "', [realname]='" & txt_realname.Text & "',[employeecode]='" & txt_code.Text & "', [inactived]='" & txt_inactived.Text & "' WHERE [id]='" & cbo_id.Text & "' and [username]='" & txt_username.Text & "'"
                cn.Execute(sqlUpdate)
                MsgBox("Data sudah tersimpan !", MsgBoxStyle.Information)
                txt_code.Clear()
                txt_inactived.Clear()
                txt_lastpass.Clear()
                txt_pass.Clear()
                txt_realname.Clear()
                txt_username.Clear()
            Else
                txt_code.Clear()
                txt_inactived.Clear()
                txt_lastpass.Clear()
                txt_pass.Clear()
                txt_realname.Clear()
                txt_username.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbo_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_id.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT [id], [username] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [id]='" & cbo_id.Text.ToString & "' ORDER BY [id] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_username.Text = rs(1).Value.ToString
            Else
                txt_username.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class