Imports ADODB
Imports System.Data.OleDb
Public Class frm_MasterEStatusArragementAddNew
    Dim hari() As String

    Private Sub frm_MasterEStatusArragementAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Close()
            cn.Close()
            dgv_StatusArragementAddNew.Rows.Clear()
            Column1.Items.Clear()
            Column2.Items.Clear()
            Column3.Items.Clear()
            Column4.Items.Clear()
            Column5.Items.Clear()
            Column6.Items.Clear()
            Column7.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
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

                'Column1 = rs(10).Value
                Column1.Items.Add(rs(10).Value.ToString)
                Column2.Items.Add(rs(11).Value.ToString)
                Column3.Items.Add(rs(12).Value.ToString)
                Column4.Items.Add(rs(13).Value.ToString)
                Column5.Items.Add(rs(14).Value.ToString)
                Column6.Items.Add(rs(15).Value.ToString)
                Column7.Items.Add(rs(16).Value.ToString)

            ElseIf Asc(e.KeyChar) = 13 Then
                frm_ItemListing.ShowDialog()
            ElseIf Asc(e.KeyChar) = 13 Then
                MsgBox("data salah")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Function RecordSetToDataTable( _
          ByVal objRS As ADODB.Recordset) As DataTable

        Dim objDA As New OleDbDataAdapter()
        Dim objDT As New DataTable()
        objDA.Fill(objDT, objRS)
        Return objDT

    End Function
    Private Sub txt_code_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged

    End Sub

    Private Sub cbo_Workgroup_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_Workgroup.MouseClick
        cbo_Workgroup.Text = ""
        cbo_division.Text = ""
        cbo_Department.Text = ""
        cbo_Section.Text = ""
        cbo_Subsection.Text = ""
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
            If rdo_DefaultTimeTable.Checked = True Then
                dgv_StatusArragementAddNew.Rows.Clear()
                Column1.Items.Clear()
                Column2.Items.Clear()
                Column3.Items.Clear()
                Column4.Items.Clear()
                Column5.Items.Clear()
                Column6.Items.Clear()
                Column7.Items.Clear()
                Column1.Items.Add("senin")
                Column2.Items.Add("selasa")
                Column3.Items.Add("rabu")
                Column4.Items.Add("kamis")
                Column5.Items.Add("jum'at")
                Column6.Items.Add("sabtu")
                Column7.Items.Add("minggu")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub dgv_StatusArragementAddNew_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_StatusArragementAddNew.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(dgv_StatusArragementAddNew.Item(0, 0).Value.ToString)
    End Sub

    Private Sub dgv_StatusArragementAddNew_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_StatusArragementAddNew.CellMouseClick
        hari = New String((7) - 1) {}
        hari(0) = "senin"
        hari(1) = "selasa"
        hari(2) = "rabu"
        hari(3) = "kamis"
        hari(4) = "jum'at"
        hari(5) = "sabtu"
        hari(6) = "minggu"
        Column1.Items.Clear()
        Column2.Items.Clear()
        Column3.Items.Clear()
        Column4.Items.Clear()
        Column5.Items.Clear()
        Column6.Items.Clear()
        Column7.Items.Clear()
        For i As Integer = 0 To hari.Length - 1
            Column1.Items.Add(hari(i).ToString)
            Column2.Items.Add(hari(i).ToString)
            Column3.Items.Add(hari(i).ToString)
            Column4.Items.Add(hari(i).ToString)
            Column5.Items.Add(hari(i).ToString)
            Column6.Items.Add(hari(i).ToString)
            Column7.Items.Add(hari(i).ToString)
        Next
    End Sub
End Class