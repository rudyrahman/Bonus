Imports ADODB

Public Class frm_Remove
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_Remove_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = cn.Execute("SELECT [id], [username], [createby] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [priority] > '" & CurrentAccountPriority & "' and [createby] = '" & CurrentAccountName & "' ORDER BY [id] ASC")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                While Not rs.EOF
                    cbo_id.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
                cbo_id.Refresh()
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
                cbo_id.Refresh()
            Else
                txt_username.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim sqlDelete As String = "delete from [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] where username='" & txt_username.Text & "'"
                cn.Execute(sqlDelete)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class