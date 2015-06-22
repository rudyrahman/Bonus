Imports ADODB
Public Class frm_MasterSubSectionAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        cn.Close()

    End Sub

    Private Sub frm_MasterSubSectionAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_DevisionCode.Text = ""
        txt_DevisionDescription.Text = ""
        cbo_DepartmentCode.Text = ""
        txt_DepartmentDescription.Text = ""
        cbo_SectionCode.Text = ""
        txt_SectionDescription.Text = ""
        txt_SubSectionCode.Text = ""
        txt_SubSectionDescription.Text = ""
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = cn.Execute("SELECT [division_code] FROM  [AN_SUMATRA].[dbo].[TM_tb_devision] ORDER BY [division_code] ")
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
            rs = cn.Execute("SELECT [section_code] FROM  [AN_SUMATRA].[dbo].[TM_tb_section] ORDER BY [section_code] ")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                cbo_SectionCode.Items.Clear()
                While Not rs.EOF
                    cbo_SectionCode.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbo_DevisionCode_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_DevisionCode.MouseClick
        cbo_DepartmentCode.Items.Clear()
        txt_DepartmentDescription.Text = ""
        cbo_SectionCode.Items.Clear()
        txt_SectionDescription.Text = ""
    End Sub

    Private Sub cbo_DevisionCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_DevisionCode.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT TOP 1 [division_description] FROM [AN_SUMATRA].[dbo].[TM_tb_devision] WHERE [division_code]='" & cbo_DevisionCode.Text & "' ORDER BY [division_code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                cbo_DepartmentCode.Items.Clear()
                txt_DepartmentDescription.Text = ""
                cbo_SectionCode.Items.Clear()
                txt_SectionDescription.Text = ""
                txt_DevisionDescription.Text = rs(0).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Try
            If cbo_DevisionCode.Text = "" Or txt_DevisionDescription.Text = "" Or cbo_DepartmentCode.Text = "" Or txt_DepartmentDescription.Text = "" Or cbo_SectionCode.Text = "" Or txt_SectionDescription.Text = "" Or txt_SubSectionCode.Text = "" Or txt_SubSectionDescription.Text = "" Then
                MsgBox(udv_msg_LoginBlank, vbInformation)
            Else
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_subsection] ([division_code],[division_description],[department_code],[department_description],[section_code],[section_description],[subsection_code],[subsection_description],[create_by],[create_time],[system_id],[inactive]) VALUES "
                sqlInsert = sqlInsert & " ('" & cbo_DevisionCode.Text.ToString & "'" & _
                     ",'" & txt_DevisionDescription.Text & "'" & _
                     ",'" & cbo_DepartmentCode.Text & "'" & _
                    ",'" & txt_DepartmentDescription.Text & "'" & _
                    ",'" & cbo_SectionCode.Text & "'" & _
                    ",'" & txt_SectionDescription.Text & "'" & _
                    ",'" & txt_SubSectionCode.Text & "'" & _
                    ",'" & txt_SubSectionDescription.Text & "'" & _
                    ",'" & CurrentAccountName & "'" & _
                    "," & "GETDATE()" & " " & "" & _
                    ",'" & CurrentAccountId & "'" & _
                    ",'N')"
                cn.Execute(sqlInsert)

                cbo_DevisionCode.Items.Clear()
                txt_DevisionDescription.Text = ""
                cbo_DepartmentCode.Items.Clear()
                txt_DepartmentDescription.Text = ""
                cbo_SectionCode.Items.Clear()
                txt_SectionDescription.Text = ""
                txt_SubSectionCode.Text = ""
                txt_SubSectionDescription.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbo_DepartmentCode_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_DepartmentCode.MouseClick
        rs = cn.Execute("SELECT [department_code] FROM [AN_SUMATRA].[dbo].[TM_tb_department] where [department_code] like '%" & Microsoft.VisualBasic.Strings.Left(cbo_DevisionCode.Text, 3) & "%' ORDER BY [department_code] ASC")
        If rs.EOF = False Then
            cbo_DepartmentCode.Items.Clear()
            While Not rs.EOF
                cbo_DepartmentCode.Items.Add(rs(0).Value.ToString)
                cbo_SectionCode.Items.Clear()
                txt_SectionDescription.Text = ""
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub cbo_DepartmentCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_DepartmentCode.SelectedIndexChanged
        Try
            cbo_SectionCode.Items.Clear()
            txt_SectionDescription.Text = ""
            txt_DepartmentDescription.Text = ""
            rs = cn.Execute("SELECT TOP 1 [department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_department] WHERE [department_code]='" & cbo_DepartmentCode.Text & "' ORDER BY [department_code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_DepartmentDescription.Text = rs(0).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbo_SectionCode_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_SectionCode.MouseClick
        rs = cn.Execute("SELECT [section_code] FROM [AN_SUMATRA].[dbo].[TM_tb_section] where [section_code] like '%" & Microsoft.VisualBasic.Strings.Left(cbo_DepartmentCode.Text, 8) & "%' ORDER BY [section_code] ASC")
        If rs.EOF = False Then
            cbo_SectionCode.Items.Clear()
            While Not rs.EOF
                cbo_SectionCode.Items.Add(rs(0).Value.ToString)
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub cbo_SectionCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_SectionCode.SelectedIndexChanged
        Try
            rs = cn.Execute("SELECT TOP 1 [section_description] FROM [AN_SUMATRA].[dbo].[TM_tb_section] WHERE [section_code]='" & cbo_SectionCode.Text & "' ORDER BY [section_code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_SectionDescription.Text = rs(0).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class