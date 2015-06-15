Imports ADODB
Imports System.Data.OleDb

Public Class frm_MasterEStatusArragementAddNew
    Dim hari As String() = {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"}
    Dim h1, h2, h3, h4, h5, h6, h7 As String

    Private Sub frm_MasterEStatusArragementAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dgv_StatusArragementAddNew.Enabled = False
            rdo_CustomTimeTable.Enabled = False
            rdo_DefaultTimeTable.Enabled = False
            dgv_StatusArragementAddNew.Columns.Clear()
          
            For i As Integer = 0 To 6
                Dim cmb As New DataGridViewComboBoxColumn()
                cmb.HeaderText = "#" & (i + 1).ToString
                cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                dgv_StatusArragementAddNew.Columns.Add(cmb)
            Next

            txt_code.Text = ""
            txt_Name.Text = ""
            cbo_Workgroup.Text = ""
            cbo_division.Text = ""
            cbo_Department.Text = ""
            cbo_Section.Text = ""
            cbo_Subsection.Text = ""

            connect()
            Try
                rs = cn.Execute("SELECT [workgroup_code] FROM [AN_SUMATRA].[dbo].[TM_tb_workgroup] ORDER BY [workgroup_code] ASC")
                If rs.EOF = False Then
                    cbo_Workgroup.Items.Clear()
                    While Not rs.EOF
                        cbo_Workgroup.Items.Add(rs(0).Value)
                        rs.MoveNext()
                    End While
                End If

                rs = cn.Execute("SELECT [division_code],[division_description] FROM [AN_SUMATRA].[dbo].[TM_tb_devision] ORDER BY [division_code] ASC")
                If rs.EOF = False Then
                    cbo_division.Items.Clear()
                    While Not rs.EOF
                        cbo_division.Items.Add(rs(0).Value & " | " & rs(1).Value.ToString)
                        rs.MoveNext()
                    End While
                End If

                rs = cn.Execute("SELECT [department_code],[department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_department] ORDER BY [department_code] ASC")
                If rs.EOF = False Then
                    cbo_Department.Items.Clear()
                    While Not rs.EOF
                        cbo_Department.Items.Add(rs(0).Value & " | " & rs(1).Value.ToString)
                        rs.MoveNext()
                    End While
                End If

                rs = cn.Execute("SELECT [department_code],[department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_department] ORDER BY [department_code] ASC")
                If rs.EOF = False Then
                    cbo_Department.Items.Clear()
                    While Not rs.EOF
                        cbo_Department.Items.Add(rs(0).Value & " | " & rs(1).Value.ToString)
                        rs.MoveNext()
                    End While
                End If

                rs = cn.Execute("SELECT [section_code],[section_description] FROM [AN_SUMATRA].[dbo].[TM_tb_section] ORDER BY [section_code] ASC")
                If rs.EOF = False Then
                    cbo_Section.Items.Clear()
                    While Not rs.EOF
                        cbo_Section.Items.Add(rs(0).Value & " | " & rs(1).Value.ToString)
                        rs.MoveNext()
                    End While
                End If

                rs = cn.Execute("SELECT [subsection_code],[subsection_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] ORDER BY [subsection_code] ASC")
                If rs.EOF = False Then
                    cbo_Subsection.Items.Clear()
                    While Not rs.EOF
                        cbo_Subsection.Items.Add(rs(0).Value & " | " & rs(1).Value.ToString)
                        rs.MoveNext()
                    End While
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Function DayExistRow(ByVal row As Integer, _
            ByVal DayName As String) As Boolean
        Try
            For x As Integer = 0 To dgv_StatusArragementAddNew.Columns.Count - 1
                If IsNothing(dgv_StatusArragementAddNew.Rows(row).Cells(x).Value) = False And _
                  x <> dgv_StatusArragementAddNew.CurrentCell.ColumnIndex Then
                    If dgv_StatusArragementAddNew.Rows(row).Cells(x).Value = DayName Then Return True
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Sub SetListCombo(ByVal row As Integer, ByVal col As Integer)
        Dim cmb As New DataGridViewComboBoxCell
        cmb = dgv_StatusArragementAddNew.Rows(row).Cells("cmb" & (col + 1).ToString)
        cmb.Items.Clear()
        cmb.Items.Add("")
        For i As Integer = 0 To 6
            If DayExistRow(row, hari(i)) = False Then
                cmb.Items.Add(hari(i))
            End If
        Next
    End Sub

    Private Sub dgv_StatusArragementAddNew_CellBeginEdit(sender As Object, _
      e As DataGridViewCellCancelEventArgs) _
      Handles dgv_StatusArragementAddNew.CellBeginEdit

        SetListCombo(e.RowIndex, e.ColumnIndex)

    End Sub


    Private Sub txt_code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_code.KeyPress
        Try
          
            rs = cn.Execute("SELECT [employee_name],[workgroup_code],[division_code],[division_description],[department_code],[department_description],[section_code],[section_description],[sub_sectioncode],[sub_sectioncode_description],[day_of_week_#1],[day_of_week_#2],[day_of_week_#3],[day_of_week_#4],[day_of_week_#5],[day_of_week_#6],[day_of_week_#7] FROM [AN_SUMATRA].[dbo].[TM_tb_statusarragement] WHERE [employee_code]='" & txt_code.Text & "' ORDER BY [employee_code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_Name.Text = rs(0).Value.ToString
                cbo_Workgroup.Text = rs(1).Value.ToString
                cbo_division.Text = rs(2).Value & " | " & rs(3).Value.ToString
                cbo_Department.Text = rs(4).Value & " | " & rs(5).Value.ToString
                cbo_Section.Text = rs(6).Value & " | " & rs(7).Value.ToString
                cbo_Subsection.Text = rs(8).Value & " | " & rs(9).Value.ToString
                rdo_CustomTimeTable.Checked = True
                dgv_StatusArragementAddNew.Enabled = True
                rdo_CustomTimeTable.Enabled = True
                rdo_DefaultTimeTable.Enabled = True
                rdo_DefaultTimeTable.Checked = False

                'Column1 = rs(10).Value
                'Column1.DataGridView.Columns.Contains(rs(10).Value.ToString)
                'Column1.Items.Add(rs(10).Value.ToString)
                'Column2.Items.Add(rs(11).Value.ToString)
                'Column3.Items.Add(rs(12).Value.ToString)
                'Column4.Items.Add(rs(13).Value.ToString)
                'Column5.Items.Add(rs(14).Value.ToString)
                'Column6.Items.Add(rs(15).Value.ToString)
                'Column7.Items.Add(rs(16).Value.ToString)

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

    Private Sub cbo_Workgroup_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_Workgroup.MouseClick
        Try
            cbo_Workgroup.Text = ""
            cbo_division.Text = ""
            cbo_Department.Text = ""
            cbo_Section.Text = ""
            cbo_Subsection.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbo_Workgroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Workgroup.SelectedIndexChanged

    End Sub

    Private Sub cbo_division_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_division.MouseClick
        cbo_division.Text = ""
        cbo_Department.Text = ""
        cbo_Section.Text = ""
        cbo_Subsection.Text = ""
    End Sub

    Private Sub cbo_division_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_division.SelectedIndexChanged

    End Sub

    Private Sub cbo_Department_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_Department.MouseClick
        cbo_Department.Text = ""
        cbo_Section.Text = ""
        cbo_Subsection.Text = ""
    End Sub

    Private Sub cbo_Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Department.SelectedIndexChanged

    End Sub

    Private Sub cbo_Section_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_Section.MouseClick
        cbo_Section.Text = ""
        cbo_Subsection.Text = ""
    End Sub

    Private Sub cbo_Section_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Section.SelectedIndexChanged

    End Sub

    Private Sub rdo_DefaultTimeTable_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_DefaultTimeTable.CheckedChanged
        Try
            dgv_StatusArragementAddNew.Enabled = False
            dgv_StatusArragementAddNew.Enabled = False
            With dgv_StatusArragementAddNew
                .ColumnCount = 7
                .Columns(0).Name = "#1"
                .Columns(1).Name = "#2"
                .Columns(2).Name = "#3"
                .Columns(3).Name = "#4"
                .Columns(4).Name = "#5"
                .Columns(5).Name = "#6"
                .Columns(6).Name = "#7"
            End With
            With dgv_StatusArragementAddNew
                Dim row As String() = New String() {"senin", "selasa", "rabu", "kamis", "jumat", "sabtu", "minggu"}
                .Rows.Add(row)
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub dgv_StatusArragementAddNew_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_StatusArragementAddNew.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            'MsgBox(dgv_StatusArragementAddNew.Item(0, 0).Value.ToString)
            If hari.Contains("senin") Then
                MsgBox("true")
            Else
                MsgBox("false")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgv_StatusArragementAddNew_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_StatusArragementAddNew.CellMouseClick
        Try
           
            'For i As Integer = 0 To hari.Length - 1
            'Column1.Items.Add(hari(i).ToString)
            'Column2.Items.Add(hari(i).ToString)
            'Column3.Items.Add(hari(i).ToString)
            'Column4.Items.Add(hari(i).ToString)
            'Column5.Items.Add(hari(i).ToString)
            'Column6.Items.Add(hari(i).ToString)
            'Column7.Items.Add(hari(i).ToString)
            'Next

            'Dim c As String
            'For a As Integer = 0 To hari.Length - 1
            'For b As Integer = 0 To hari.Length - 1
            'If hari(a) = dgv_StatusArragementAddNew.Item(0, 0).Value.ToString Then
            'If c <> hari(a) Then
            'c = hari(a)
            'End If
            'End If
            'Next
            'Next
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            Me.Close()
            cn.Close()
            dgv_StatusArragementAddNew.Rows.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click

        Try

            h1 = Me.dgv_StatusArragementAddNew.Rows(1).Cells(0).Value.ToString()
            h2 = Me.dgv_StatusArragementAddNew.Rows(1).Cells(1).Value.ToString()
            h3 = Me.dgv_StatusArragementAddNew.Rows(1).Cells(2).Value.ToString()
            h4 = Me.dgv_StatusArragementAddNew.Rows(1).Cells(3).Value.ToString()
            h5 = Me.dgv_StatusArragementAddNew.Rows(1).Cells(4).Value.ToString()
            h6 = Me.dgv_StatusArragementAddNew.Rows(1).Cells(5).Value.ToString()
            h7 = Me.dgv_StatusArragementAddNew.Rows(1).Cells(6).Value.ToString()

            Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_statusarragement] ([division_code],[division_description],[department_code],[department_description],[section_code],[section_description],[sub_sectioncode],[sub_sectioncode_description],[workgroup_code],[employee_code],[employee_name],[day_of_week_#1],[day_of_week_#2],[day_of_week_#3],[day_of_week_#4],[day_of_week_#5],[day_of_week_#6],[day_of_week_#7],[create_by],[create_time],[system_id]) VALUES "
            sqlInsert = sqlInsert & " ('" & txt_code.Text.ToString & "'" & _
            ",'" & txt_Name.Text & "'" & _
            ",'" & cbo_Workgroup.Text & "'" & _
            ",'" & cbo_division.Text & "'" & _
            ",'" & cbo_Department.Text & "'" & _
            ",'" & cbo_Section.Text & "'" & _
            ",'" & cbo_Subsection.Text & "'" & _
            ",'" & h1 & "'" & _
            ",'" & h2 & "'" & _
            ",'" & h3 & "'" & _
            ",'" & h4 & "'" & _
            ",'" & h5 & "'" & _
            ",'" & h6 & "'" & _
            ",'" & h7 & "')"

            cn.Execute(sqlInsert)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub rdo_CustomTimeTable_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_CustomTimeTable.CheckedChanged
        dgv_StatusArragementAddNew.Enabled = True
        dgv_StatusArragementAddNew.Columns.Clear()
        For i As Integer = 0 To 6
            Dim cmb As New DataGridViewComboBoxColumn()
            cmb.HeaderText = "#" & (i + 1).ToString
            cmb.Name = "cmb" & (i + 1).ToString
            cmb.MaxDropDownItems = 7
            cmb.Items.Add("")
            cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            For x As Integer = 0 To 6
                cmb.Items.Add(hari(x))
            Next
            dgv_StatusArragementAddNew.Columns.Add(cmb)
        Next
    End Sub
End Class