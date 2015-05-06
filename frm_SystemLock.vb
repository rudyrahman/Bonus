Imports ADODB
Public Class frm_SystemLock
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim table As DataTable
    Private Sub btn_Unlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Unlock.Click
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

            If txt_Username.Text = "" Or txt_Password.Text = "" Then
                MsgBox("Data is Empty")
            End If
            Exit Sub
            table = cn.ExecuteQuery("Select * From [SY_tb_appsaccounts] Where [username] = '" & txt_Username.Text & "' and [password] ='" & txt_Password.Text & "'")
            If table.Rows.Count = 0 Then
                MessageBox.Show("Unlock Succes..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_Username.Focus()

            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        cn.Close()
    End Sub

    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        txt_Password.PasswordChar = ""
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        txt_Password.PasswordChar = "*"
    End Sub

    Private Sub frm_SystemLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub
End Class
