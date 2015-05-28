Imports ADODB
Public Class frm_MasterDepartmentAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        cn.Close()
    End Sub

    Private Sub frm_MasterDepartmentAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_DevisionCode.Text = ""
        txt_DevisionDescription.Text = ""
        txt_DepartmentCode.Text = ""
        txt_DepartmentDescription.Text = ""
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = cn.Execute("SELECT [code] FROM  [AN_SUMATRA].[dbo].[TM_tb_devision] ORDER BY [code] ")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                While Not rs.EOF
                    cbo_DevisionCode.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        cbo_DevisionCode.Focus()
    End Sub

    Private Sub cbo_DevisionCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_DevisionCode.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT TOP 1 [description] FROM [AN_SUMATRA].[dbo].[TM_tb_devision] WHERE [code]='" & cbo_DevisionCode.Text & "' ORDER BY [code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_DevisionDescription.Text = rs(0).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Try
            Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_department] ([devision_code],[devision_description],[department_code],[department_description]) VALUES "
            sqlInsert = sqlInsert & " ('" & cbo_DevisionCode.Text.ToString & "'" & _
                 ",'" & txt_DevisionDescription.Text & "'" & _
                 ",'" & txt_DepartmentCode.Text & "'" & _
                ",'" & txt_DepartmentDescription.Text & "')"
            cn.Execute(sqlInsert)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class