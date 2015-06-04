Imports ADODB
Public Class frm_MasterEStatusArragementAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txt_code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_code.KeyPress
        Try
            rs = cn.Execute("SELECT TOP 1 [realname] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & txt_code.Text & "' ORDER BY [username] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_Name.Text = rs(0).Value.ToString
            ElseIf Asc(e.KeyChar) = 13 Then
                frm_ItemListing.ShowDialog()
            ElseIf Asc(e.KeyChar) = 13 Then
                MsgBox("data salah")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
       
    End Sub


    Private Sub txt_code_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged

    End Sub

    Private Sub frm_MasterEStatusArragementAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
       
    End Sub
End Class