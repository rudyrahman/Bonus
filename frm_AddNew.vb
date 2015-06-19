Imports ADODB
Public Class frm_AddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_AddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_code.Focus()
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txt_code.Focus()
        Me.Close()
        cn.Close()
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        Try
            If txt_code.Text = "" Or txt_desc.Text = "" Then
                MsgBox("Data belum lengkap !", MsgBoxStyle.Information)
                txt_code.Focus()

            Else
                If MessageBox.Show("Apakah Anda yakin akan menyimpan data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_MonthPeriode]([Code],[Description],[Periode_From],[Periode_To],[Create_By],[Create_Time],[System_Id]) values "
                    sqlInsert = sqlInsert & " ('" & txt_code.Text & "','" & txt_desc.Text & "','" & DTP_From.Value & "','" & DTP_To.Value & "','" & CurrentAccountName & "'," & "GETDATE()" & " " & ",'" & CurrentAccountId & "')"
                    cn.Execute(sqlInsert)
                    txt_code.Text = ""
                    txt_desc.Text = ""

                End If
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class