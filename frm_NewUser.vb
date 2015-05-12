Imports ADODB

Public Class frm_NewUser
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Focus()
        Try

            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_username.Text = "" Or txt_pass.Text = "" Or txt_realname.Text = "" Or txt_code.Text = "" Or txt_inactived.Text = "" Then
            MsgBox("Data belum lengkap !", MsgBoxStyle.Information)

        Else
            Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[SY_tb_appsaccounts]([username],[password],[lastpasswordchange],[realname],[employeecode],[priority],[inactived],[createby],[createtime]) values "
            sqlInsert = sqlInsert & " ('" & txt_username.Text & "','" & txt_pass.Text & "'," & "GETDATE()" & " " & ",'" & txt_realname.Text & "','" & txt_code.Text & "', '" & Math.Round(Val(CurrentAccountPriority + 1), 0) & "', '" & txt_inactived.Text & "','" & CurrentAccountName & "', " & "GETDATE()" & " " & ")"
            cn.Execute(sqlInsert)
            MsgBox("Data sudah tersimpan !", MsgBoxStyle.Information)
            txt_code.Text = ""
            txt_inactived.Text = ""

            txt_pass.Text = ""
            txt_realname.Text = ""
            txt_username.Text = ""
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class