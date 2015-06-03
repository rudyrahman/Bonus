Imports ADODB
Public Class frm_MasterSectionAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        cn.Close()
    End Sub

    Private Sub frm_MasterSectionAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_DevisionCode.Text = ""
        txt_DevisionDescription.Text = ""
        cbo_DepartmentCode.Text = ""
        txt_DepartmentDescription.Text = ""
        txt_SectionCode.Text = ""
        txt_SectionDescription.Text = ""
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = cn.Execute("SELECT [code] FROM  [AN_SUMATRA].[dbo].[TM_tb_devision] ORDER BY [code] ")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                cbo_DevisionCode.Items.Clear()
                While Not rs.EOF
                    cbo_DevisionCode.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
            End If
            rs = cn.Execute("SELECT [department_code] FROM  [AN_SUMATRA].[dbo].[TM_tb_department] ORDER BY [department_code] ")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                cbo_DepartmentCode.Items.Clear()
                While Not rs.EOF
                    cbo_DepartmentCode.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
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

    Private Sub cbo_DepartmentCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_DepartmentCode.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT TOP 1 [department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_department] WHERE [department_code]='" & cbo_DepartmentCode.Text & "' ORDER BY [department_code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_DepartmentDescription.Text = rs(0).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Try
            If cbo_DevisionCode.Text = "" Or txt_DevisionDescription.Text = "" Or cbo_DepartmentCode.Text = "" Or txt_DepartmentDescription.Text = "" Or txt_SectionCode.Text = "" Or txt_SectionDescription.Text = "" Then
                MsgBox(udv_msg_LoginBlank, vbInformation)
            Else
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_section] ([devision_code],[devision_description],[department_code],[department_description],[section_code],[section_description],[create_by],[create_time],[system_id],[inactive]) VALUES "
                sqlInsert = sqlInsert & " ('" & cbo_DevisionCode.Text.ToString & "'" & _
                     ",'" & txt_DevisionDescription.Text & "'" & _
                     ",'" & cbo_DepartmentCode.Text & "'" & _
                    ",'" & txt_DepartmentDescription.Text & "'" & _
                    ",'" & txt_SectionCode.Text & "'" & _
                    ",'" & txt_SectionDescription.Text & "'" & _
                    ",'" & CurrentAccountName & "'" & _
                    "," & "GETDATE()" & " " & "" & _
                    ",'" & CurrentAccountId & "'" & _
                    ",'')"
                cn.Execute(sqlInsert)
                cbo_DevisionCode.Items.Clear()
                txt_DevisionDescription.Text = ""
                cbo_DepartmentCode.Items.Clear()
                txt_DepartmentDescription.Text = ""
                txt_SectionCode.Text = ""
                txt_SectionDescription.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class