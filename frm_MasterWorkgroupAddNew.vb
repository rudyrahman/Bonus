Imports ADODB
Public Class frm_MasterWorkgroupAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        cn.Close()

    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Try
            If txt_WorkgroupCode.Text = "" Or txt_WorkgroupDescription.Text = "" Then
                MsgBox(udv_msg_LoginBlank, vbInformation)
            Else
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_workgroup] ([workgroup_code],[workgroup_description],[create_by],[create_time],[system_id]) VALUES "
                sqlInsert = sqlInsert & " ('" & txt_WorkgroupCode.Text.ToString & "','" & txt_WorkgroupDescription.Text & "','" & CurrentAccountName & "'," & "GETDATE()" & " " & ",'" & CurrentAccountId & "')"
                cn.Execute(sqlInsert)
                txt_WorkgroupCode.Text = ""
                txt_WorkgroupDescription.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub frm_MasterWorkgroupAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_WorkgroupCode.Text = ""
        txt_WorkgroupDescription.Text = ""
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class