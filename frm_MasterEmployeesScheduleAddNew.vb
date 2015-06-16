Imports ADODB
Imports System.Data
Imports System.Data.OleDb


Public Class frm_MasterEmployeesScheduleAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim strs As String
    Sub hitung()
        Dim kerja As Integer
        Dim istirahat As Integer
        Dim total As Integer
        kerja = DateDiff("n", dmn_StartTime.SelectedItem, dmn_FinishTime.SelectedItem)
        txt.Text = kerja & Space(1) & "Min"
        istirahat = DateDiff("n", dmn_BreakoutTime.SelectedItem, dmn_BreakinTime.SelectedItem)
        txt1.Text = istirahat & Space(1) & "Min"
        total = Val(kerja + istirahat)
        txt2.Text = total & Space(1) & "Min"
    End Sub
    Sub division()
        rs = cn.Execute("SELECT distinct [division_code], [division_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection]")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            While Not rs.EOF
                cbo_devision.Items.Add(rs(0).Value.ToString & Space(2) & "|" & Space(2) & rs(1).Value.ToString)
                cbo_devision.ValueMember = rs(0).Value.ToString
                ' cbo_devision.SelectedValue = rs(0).Value.ToString
                'cbo_devision.DisplayMember = rs(1).Value.ToString
                rs.MoveNext()
            End While
        End If
      
        'rs = New ADODB.Recordset

    End Sub
    Sub department(KodeDivision As String)
        rs = cn.Execute("SELECT distinct [department_code], [department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] where [division_code] = '" & KodeDivision & "'")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            cbo_departemen.Items.Clear()
            While Not rs.EOF
                cbo_departemen.Items.Add(rs(0).Value.ToString & Space(2) & "|" & Space(2) & rs(1).Value.ToString)
                cbo_departemen.ValueMember = rs(0).Value.ToString
                rs.MoveNext()
            End While
        End If
    End Sub
    Sub section(KodeDepartment As String)
        rs = cn.Execute("SELECT distinct [section_code], [section_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] where [department_code] = '" & KodeDepartment & "'")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            cbo_section.Items.Clear()
            While Not rs.EOF
                cbo_section.Items.Add(rs(0).Value.ToString & Space(2) & "|" & Space(2) & rs(1).Value.ToString)
                cbo_section.ValueMember = rs(0).Value.ToString
                rs.MoveNext()
            End While
        End If
    End Sub
    Sub subsection(KodeSection As String)
        rs = cn.Execute("SELECT distinct [subsection_code], [subsection_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] where [section_code] = '" & KodeSection & "'")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            cbo_subsection.Items.Clear()
            While Not rs.EOF
                cbo_subsection.Items.Add(rs(0).Value.ToString & Space(2) & "|" & Space(2) & rs(1).Value.ToString)
                cbo_subsection.ValueMember = rs(0).Value.ToString
                rs.MoveNext()
            End While
        End If
    End Sub
    Public Function RecordSetToDataTable( _
            ByVal objRS As ADODB.Recordset) As DataTable

        Dim objDA As New OleDbDataAdapter()
        Dim objDT As New DataTable()
        objDA.Fill(objDT, objRS)
        Return objDT

    End Function
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        cn.Close()
        Me.Close()
    End Sub
    Private Sub frm_MasterEmployeesScheduleAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        lst_schedule.Columns.Add("Description", 130, HorizontalAlignment.Left)
        lst_schedule.Columns.Add("Data Inputed", 150, HorizontalAlignment.Left)
        lst_schedule.Items.Add("Work Time", "Description")
        lst_schedule.Items.Add("Break Time", "Description")
        lst_schedule.Items.Add("Work Time Total", "Description")
        lst_schedule.GridLines = True
        lst_schedule.View = View.Details
        lst_schedule.FullRowSelect = True
        cbo_departemen.Enabled = False
        cbo_section.Enabled = False
        cbo_subsection.Enabled = False
        cbo_day.Enabled = False
        cbo_shift.Enabled = False
        dmn_StartTime.Enabled = False
        dmn_BreakinTime.Enabled = False
        dmn_BreakoutTime.Enabled = False
        dmn_FinishTime.Enabled = False
        hitung()

        rs = cn.Execute("SELECT [id], [day_name] FROM [AN_SUMATRA].[dbo].[TM_DayName]  ORDER BY [id] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            cbo_day.Items.Clear()
            While Not rs.EOF
                cbo_day.Items.Add(rs(0).Value.ToString & Space(2) & "|" & Space(2) & rs(1).Value.ToString)
                rs.MoveNext()
            End While
        End If
        division()

    End Sub
    Private Sub cbo_shift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_shift.SelectedIndexChanged
        If cbo_shift.Text = 1 Then
            dmn_StartTime.Enabled = True
            dmn_BreakinTime.Enabled = True
            dmn_BreakoutTime.Enabled = True
            dmn_FinishTime.Enabled = True
            dmn_StartTime.SelectedIndex = 0
            dmn_FinishTime.SelectedIndex = 0
            dmn_BreakoutTime.SelectedIndex = 0
            dmn_BreakinTime.SelectedIndex = 0
            dmn_StartTime.SelectedItem = ("08 : 00")
            dmn_BreakinTime.SelectedItem = ("13 : 00")
            dmn_BreakoutTime.SelectedItem = ("12 : 00")
            dmn_FinishTime.SelectedItem = ("16 : 00")
            hitung()
        ElseIf cbo_shift.Text = 2 Then
            dmn_StartTime.Enabled = True
            dmn_BreakinTime.Enabled = True
            dmn_BreakoutTime.Enabled = True
            dmn_FinishTime.Enabled = True
            dmn_StartTime.SelectedIndex = 0
            dmn_FinishTime.SelectedIndex = 0
            dmn_BreakoutTime.SelectedIndex = 0
            dmn_BreakinTime.SelectedIndex = 0
            dmn_FinishTime.SelectedItem = ("07 : 00")
            dmn_StartTime.SelectedItem = ("23 : 00")
            dmn_BreakinTime.SelectedItem = ("03 : 00")
            dmn_BreakoutTime.SelectedItem = ("02 : 00")
            hitung()
        Else
            dmn_StartTime.Enabled = True
            dmn_BreakinTime.Enabled = True
            dmn_BreakoutTime.Enabled = True
            dmn_FinishTime.Enabled = True
            dmn_StartTime.SelectedIndex = 0
            dmn_FinishTime.SelectedIndex = 0
            dmn_BreakoutTime.SelectedIndex = 0
            dmn_BreakinTime.SelectedIndex = 0
            dmn_StartTime.SelectedItem = ("11 : 00")
            dmn_BreakinTime.SelectedItem = ("13 : 00")
            dmn_BreakoutTime.SelectedItem = ("12 : 00")
            dmn_FinishTime.SelectedItem = ("16 : 00")
            hitung()

        End If
    End Sub

    Private Sub cbo_devision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_devision.SelectedIndexChanged
        cbo_departemen.Enabled = True
    End Sub

    Private Sub cbo_departemen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_departemen.SelectedIndexChanged
        cbo_section.Enabled = True
    End Sub
    Private Sub cbo_day_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_day.SelectedIndexChanged
        cbo_shift.Enabled = True
        rs = cn.Execute("SELECT [id], [day_name] FROM [AN_SUMATRA].[dbo].[TM_DayName] WHERE [day_name]='" & cbo_day.Text.ToString & "' ORDER BY [id] ASC")
    End Sub

    Private Sub dmn_StartTime_SelectedItemChanged(sender As Object, e As EventArgs) Handles dmn_StartTime.SelectedItemChanged
        dmn_StartTime.Items.Add("00 : 00")
        dmn_StartTime.Items.Add("01 : 00")
        dmn_StartTime.Items.Add("02 : 00")
        dmn_StartTime.Items.Add("03 : 00")
        dmn_StartTime.Items.Add("05 : 00")
        dmn_StartTime.Items.Add("06 : 00")
        dmn_StartTime.Items.Add("07 : 00")
        dmn_StartTime.Items.Add("08 : 00")
        dmn_StartTime.Items.Add("09 : 00")
        dmn_StartTime.Items.Add("10 : 00")
        dmn_StartTime.Items.Add("11 : 00")
        dmn_StartTime.Items.Add("12 : 00")
        dmn_StartTime.Items.Add("13 : 00")
        dmn_StartTime.Items.Add("14 : 00")
        dmn_StartTime.Items.Add("15 : 00")
        dmn_StartTime.Items.Add("16 : 00")
        dmn_StartTime.Items.Add("17 : 00")
        dmn_StartTime.Items.Add("18 : 00")
        dmn_StartTime.Items.Add("19 : 00")
        dmn_StartTime.Items.Add("20 : 00")
        dmn_StartTime.Items.Add("21 : 00")
        dmn_StartTime.Items.Add("22 : 00")
        dmn_StartTime.Items.Add("22 : 00")
        dmn_StartTime.Items.Add("23 : 00")

        hitung()
    End Sub

    Private Sub dmn_FinishTime_SelectedItemChanged(sender As Object, e As EventArgs) Handles dmn_FinishTime.SelectedItemChanged
        dmn_FinishTime.Items.Add("00 : 00")
        dmn_FinishTime.Items.Add("01 : 00")
        dmn_FinishTime.Items.Add("02 : 00")
        dmn_FinishTime.Items.Add("03 : 00")
        dmn_FinishTime.Items.Add("05 : 00")
        dmn_FinishTime.Items.Add("06 : 00")
        dmn_FinishTime.Items.Add("07 : 00")
        dmn_FinishTime.Items.Add("08 : 00")
        dmn_FinishTime.Items.Add("09 : 00")
        dmn_FinishTime.Items.Add("10 : 00")
        dmn_FinishTime.Items.Add("11 : 00")
        dmn_FinishTime.Items.Add("12 : 00")
        dmn_FinishTime.Items.Add("13 : 00")
        dmn_FinishTime.Items.Add("14 : 00")
        dmn_FinishTime.Items.Add("15 : 00")
        dmn_FinishTime.Items.Add("16 : 00")
        dmn_FinishTime.Items.Add("17 : 00")
        dmn_FinishTime.Items.Add("18 : 00")
        dmn_FinishTime.Items.Add("19 : 00")
        dmn_FinishTime.Items.Add("20 : 00")
        dmn_FinishTime.Items.Add("21 : 00")
        dmn_FinishTime.Items.Add("22 : 00")
        dmn_FinishTime.Items.Add("22 : 00")
        dmn_FinishTime.Items.Add("23 : 00")

        hitung()
    End Sub

    Private Sub dmn_BreakoutTime_SelectedItemChanged(sender As Object, e As EventArgs) Handles dmn_BreakoutTime.SelectedItemChanged
        dmn_BreakoutTime.Items.Add("00 : 00")
        dmn_BreakoutTime.Items.Add("01 : 00")
        dmn_BreakoutTime.Items.Add("02 : 00")
        dmn_BreakoutTime.Items.Add("03 : 00")
        dmn_BreakoutTime.Items.Add("05 : 00")
        dmn_BreakoutTime.Items.Add("06 : 00")
        dmn_BreakoutTime.Items.Add("07 : 00")
        dmn_BreakoutTime.Items.Add("08 : 00")
        dmn_BreakoutTime.Items.Add("09 : 00")
        dmn_BreakoutTime.Items.Add("10 : 00")
        dmn_BreakoutTime.Items.Add("11 : 00")
        dmn_BreakoutTime.Items.Add("12 : 00")
        dmn_BreakoutTime.Items.Add("13 : 00")
        dmn_BreakoutTime.Items.Add("14 : 00")
        dmn_BreakoutTime.Items.Add("15 : 00")
        dmn_BreakoutTime.Items.Add("16 : 00")
        dmn_BreakoutTime.Items.Add("17 : 00")
        dmn_BreakoutTime.Items.Add("18 : 00")
        dmn_BreakoutTime.Items.Add("19 : 00")
        dmn_BreakoutTime.Items.Add("20 : 00")
        dmn_BreakoutTime.Items.Add("21 : 00")
        dmn_BreakoutTime.Items.Add("22 : 00")
        dmn_BreakoutTime.Items.Add("22 : 00")
        dmn_BreakoutTime.Items.Add("23 : 00")

        hitung()
    End Sub

    Private Sub dmn_BreakinTime_SelectedItemChanged(sender As Object, e As EventArgs) Handles dmn_BreakinTime.SelectedItemChanged
        dmn_BreakinTime.Items.Add("00 : 00")
        dmn_BreakinTime.Items.Add("01 : 00")
        dmn_BreakinTime.Items.Add("02 : 00")
        dmn_BreakinTime.Items.Add("03 : 00")
        dmn_BreakinTime.Items.Add("05 : 00")
        dmn_BreakinTime.Items.Add("06 : 00")
        dmn_BreakinTime.Items.Add("07 : 00")
        dmn_BreakinTime.Items.Add("08 : 00")
        dmn_BreakinTime.Items.Add("09 : 00")
        dmn_BreakinTime.Items.Add("10 : 00")
        dmn_BreakinTime.Items.Add("11 : 00")
        dmn_BreakinTime.Items.Add("12 : 00")
        dmn_BreakinTime.Items.Add("13 : 00")
        dmn_BreakinTime.Items.Add("14 : 00")
        dmn_BreakinTime.Items.Add("15 : 00")
        dmn_BreakinTime.Items.Add("16 : 00")
        dmn_BreakinTime.Items.Add("17 : 00")
        dmn_BreakinTime.Items.Add("18 : 00")
        dmn_BreakinTime.Items.Add("19 : 00")
        dmn_BreakinTime.Items.Add("20 : 00")
        dmn_BreakinTime.Items.Add("21 : 00")
        dmn_BreakinTime.Items.Add("22 : 00")
        dmn_BreakinTime.Items.Add("22 : 00")
        dmn_BreakinTime.Items.Add("23 : 00")

        hitung()
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Try
            If MessageBox.Show("Apakah Anda yakin akan menyimpan data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_EmployeesSchedule] ([Division_Code],[Division_Description],[Department_Code],[Department_Description],[Section_Code],[Section_Description],[Sub_Section_Code],[Sub_Section_Description],[Day_Name_Code],[Day_Name_Description],[Shift],[Start],[Finish],[Break_Out],[Break_In],[Create_By],[Craete_Time],[System_id]) VALUES "
                sqlInsert = sqlInsert & " ('" & Microsoft.VisualBasic.Strings.Left(cbo_devision.Text, 3) & "'" & _
                     ",'" & Microsoft.VisualBasic.Strings.Mid(cbo_devision.Text, 9, 20) & "'" & _
                     ",'" & Microsoft.VisualBasic.Strings.Left(cbo_departemen.Text, 7) & "'" & _
                      ",'" & Microsoft.VisualBasic.Strings.Mid(cbo_departemen.Text, 9, 25) & "'" & _
                      ",'" & Microsoft.VisualBasic.Strings.Left(cbo_section.Text, 9) & "'" & _
                      ",'" & Microsoft.VisualBasic.Strings.Mid(cbo_section.Text, 9, 25) & "'" & _
                      ",'" & Microsoft.VisualBasic.Strings.Left(cbo_subsection.Text, 11) & "'" & _
                      ",'" & Microsoft.VisualBasic.Strings.Mid(cbo_subsection.Text, 9, 25) & "'" & _
                      ",'" & Microsoft.VisualBasic.Strings.Left(cbo_day.Text, 1) & "'" & _
                      ",'" & Microsoft.VisualBasic.Strings.Mid(cbo_day.Text, 7, 10) & "'" & _
                       ",'" & cbo_shift.Text.ToString & "'" & _
                      ",'" & dmn_StartTime.Text.ToString & "'" & _
                       ",'" & dmn_FinishTime.Text.ToString & "'" & _
                     ",'" & dmn_BreakoutTime.Text.ToString & "'" & _
                     ",'" & dmn_BreakinTime.Text.ToString & "'" & _
                     ",'" & CurrentAccountName & "'" & _
                     "," & "GETDATE()" & " " & "" & _
                    ",'" & CurrentAccountId & "')"
                cn.Execute(sqlInsert)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbo_section_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_section.SelectedIndexChanged
        cbo_subsection.Enabled = True
    End Sub

    Private Sub cbo_subsection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_subsection.SelectedIndexChanged
        cbo_day.Enabled = True
    End Sub

    Private Sub cbo_devision_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_devision.SelectedValueChanged
        department(cbo_devision.ValueMember.ToString)
    End Sub

    Private Sub cbo_departemen_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_departemen.SelectedValueChanged
        section(cbo_departemen.ValueMember.ToString)
    End Sub

    Private Sub cbo_section_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_section.SelectedValueChanged
        subsection(cbo_section.ValueMember.ToString)
    End Sub
End Class