Imports ADODB

Public Class frm_ChangeDetail
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_ChangeDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbo_username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_username.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT [id] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & cbo_username.Text.ToString & "' ORDER BY [id] ASC")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        
    End Sub
End Class