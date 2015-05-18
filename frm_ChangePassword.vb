Imports ADODB

Public Class frm_ChangePassword
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txt_passlama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_passlama.KeyPress
        Try
            If e.KeyChar = Chr(13) Then

                rs = cn.Execute("SELECT [id], [username] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & CurrentAccountName & "' and [password]='" & txt_passlama.Text & "'", CursorTypeEnum.adOpenKeyset)
                If Not rs.EOF Then
                    txt_passlama.Enabled = False

                    txt_passbaru.Focus()
                Else
                    MsgBox("Password lama salah", MsgBoxStyle.Exclamation)
                    txt_passlama.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txt_passbaru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_passbaru.KeyPress
        Try
            txt_passbaru.MaxLength = 50
            If e.KeyChar = Chr(13) Then
                If Len(txt_passbaru.Text) < 5 Then
                    MsgBox("Pasword minimal 5 karakter", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If txt_passbaru.Text = "" Then
                    MsgBox("Pasword baru wajib diisi ", MsgBoxStyle.Exclamation)
                    txt_passbaru.Focus()
                Else
                    txt_ulangipass.Enabled = True
                    txt_ulangipass.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txt_ulangipass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ulangipass.KeyPress
        Try
            txt_passbaru.MaxLength = 50
            If e.KeyChar = Chr(13) Then
                If txt_ulangipass.Text <> txt_passbaru.Text Then
                    MsgBox("Password konfirmasi salah, password tidak sama", MsgBoxStyle.Exclamation)
                    txt_ulangipass.Focus()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If MessageBox.Show("Yakin password lama <" & txt_passlama.Text & "> akan diganti dengan <" & txt_passbaru.Text & ">..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim sqlUpdate As String = "Update [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] set [password]='" & txt_passbaru.Text & "' WHERE [id]='" & CurrentAccountId & "' and [username]='" & CurrentAccountName & "'"
                cn.Execute(sqlUpdate)
                txt_passlama.Clear()
                txt_passbaru.Clear()
                txt_ulangipass.Clear()
                Me.Close()
                cn.Close()
            Else
                txt_passbaru.Clear()
                txt_passlama.Clear()
                txt_ulangipass.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class