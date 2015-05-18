Imports ADODB

Public Class frm_NewUser
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_username.Focus()
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_username.Text = "" Or txt_pass.Text = "" Or txt_realname.Text = "" Or txt_code.Text = "" Then
                MsgBox("Data belum lengkap !", MsgBoxStyle.Information)

            Else
                If MessageBox.Show("Apakah Anda yakin akan menyimpan data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[SY_tb_appsaccounts]([username],[password],[lastpasswordchange],[realname],[employeecode],[priority],[createby],[createtime]) values "
                    sqlInsert = sqlInsert & " ('" & txt_username.Text & "','" & txt_pass.Text & "'," & "GETDATE()" & " " & ",'" & txt_realname.Text & "','" & txt_code.Text & "', '" & Math.Round(Val(CurrentAccountPriority + 1), 0) & "','" & CurrentAccountName & "', " & "GETDATE()" & " " & ")"
                    cn.Execute(sqlInsert)
                    txt_username.Text = ""
                    txt_pass.Text = ""
                    txt_realname.Text = ""
                    txt_code.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class