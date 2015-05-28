Imports ADODB
Public Class frm_MasterDevisionAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        cn.Close()

    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Try
            Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_devision] ([code],[description]) VALUES "
            sqlInsert = sqlInsert & " ('" & txt_Code.Text.ToString & "'" & _
                ",'" & txt_Description.Text & "')"
            cn.Execute(sqlInsert)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub frm_MasterDevisionAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Code.Text = ""
        txt_Description.Text = ""
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class