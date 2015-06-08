Imports ADODB

Public Class frm_MasterEmployeesScheduleAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Sub hitung()
        Dim kerja As Integer
        Dim istirahat As Integer
        Dim total As Integer
        kerja = DateDiff(DateInterval.Minute, dmn_StartTime.SelectedItem, dmn_FinishTime.SelectedItem)
        txt.Text = kerja & Space(1) & "Min"
        istirahat = DateDiff(DateInterval.Minute, dmn_BreakoutTime.SelectedItem, dmn_BreakinTime.SelectedItem)
        txt1.Text = istirahat & Space(1) & "Min"
        total = Val(kerja + istirahat)
        txt2.Text = total & Space(1) & "Min"
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
    Private Sub frm_MasterEmployeesScheduleAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        cbo_departemen.Enabled = False
        cbo_section.Enabled = False
        cbo_subsection.Enabled = False
        'cbo_day.Enabled = False
        cbo_shift.Enabled = False
        dmn_StartTime.Enabled = False
        dmn_BreakinTime.Enabled = False
        dmn_BreakoutTime.Enabled = False
        dmn_FinishTime.Enabled = False
        hitung()
       
        rs = cn.Execute("SELECT distinct [devision_code], [devision_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] ORDER BY [devision_code] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            While Not rs.EOF
                cbo_devision.Items.Add(rs(0).Value.ToString & Space(2) & "|" & Space(2) & rs(1).Value.ToString)
                rs.MoveNext()
            End While
            'cbo_devision.Refresh()
        End If

        rs = cn.Execute("SELECT distinct [department_code], [department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] ORDER BY [department_code] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            While Not rs.EOF
                cbo_departemen.Items.Add(rs(0).Value.ToString)
                rs.MoveNext()
            End While
            'cbo_devision.Refresh()
        End If

        rs = cn.Execute("SELECT [id], [day_name] FROM [AN_SUMATRA].[dbo].[TM_DayName]  ORDER BY [id] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            While Not rs.EOF
                cbo_day.Items.Add(rs(0).Value.ToString & Space(2) & "|" & Space(2) & rs(1).Value.ToString)
                rs.MoveNext()
            End While
            'cbo_devision.Refresh()
        End If

        lst_schedule.Columns.Add("Description", 130, HorizontalAlignment.Left)
        lst_schedule.Columns.Add("Data Inputed", 150, HorizontalAlignment.Left)
        lst_schedule.Items.Add("Work Time", "Description")
        lst_schedule.Items.Add("Break Time", "Description")
        lst_schedule.Items.Add("Work Time Total", "Description")
        lst_schedule.GridLines = True
        lst_schedule.View = View.Details
        lst_schedule.FullRowSelect = True


        
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
            dmn_StartTime.SelectedItem = ("10 : 00")
            dmn_BreakinTime.SelectedItem = ("13 : 00")
            dmn_BreakoutTime.SelectedItem = ("12 : 00")
            dmn_FinishTime.SelectedItem = ("16 : 00")
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
        cbo_section.Enabled = True
        If Not IsNothing(cbo_departemen.SelectedValue) Then
            Dim idevision As Integer = cbo_devision.SelectedValue
            'menyiapkan id dari combobox kabupaten
            Dim iddepartment As Integer = cbo_departemen.SelectedValue
            rs = cn.Execute("SELECT distinct [department_code], [department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] WHERE [devision_code]='" & idevision & "' and [department_code]='" & iddepartment & "' ORDER BY [department_code] ASC")
        End If

    End Sub

    Private Sub cbo_departemen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_departemen.SelectedIndexChanged

    End Sub

    Private Sub cbo_devision_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_devision.SelectedValueChanged
        cbo_departemen.Enabled = True

        If Not IsNothing(cbo_devision.SelectedValue) Then
            Dim id As Integer = cbo_devision.SelectedValue
            rs = cn.Execute("SELECT distinct [devision_code], [devision_description], [department_code], [department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] WHERE [devision_code]='" & id & "' ORDER BY [devision_code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then

                'cbo_departemen.Text = rs(2).Value.ToString
                'txt_dateto.Text = rs(3).Value.ToString
            Else
                'txt_dateto.Text = ""
                'txt_datefrom.Text = ""
            End If
        End If
    End Sub

    Private Sub cbo_departemen_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_departemen.SelectedValueChanged
        cbo_section.Enabled = True
        If Not IsNothing(cbo_departemen.SelectedValue) Then
            Dim idevision As Integer = cbo_devision.SelectedValue
            'menyiapkan id dari combobox kabupaten
            Dim iddepartment As Integer = cbo_departemen.SelectedValue
            rs = cn.Execute("SELECT distinct [department_code], [department_description] FROM [AN_SUMATRA].[dbo].[TM_tb_subsection] WHERE [devision_code]='" & idevision & "' and [department_code]='" & iddepartment & "' ORDER BY [department_code] ASC")
        End If

    End Sub

    Private Sub cbo_day_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_day.SelectedIndexChanged
        cbo_shift.Enabled = True
        rs = cn.Execute("SELECT [id], [day_name] FROM [AN_SUMATRA].[dbo].[TM_DayName] WHERE [day_name]='" & cbo_day.Text.ToString & "' ORDER BY [id] ASC")

    End Sub

    Private Sub dmn_StartTime_SelectedItemChanged(sender As Object, e As EventArgs) Handles dmn_StartTime.SelectedItemChanged
        ' dmn_StartTime.SelectedIndex = 0
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
        dmn_StartTime.Items.Add("00 : 00")
        hitung()
    End Sub

    Private Sub dmn_FinishTime_SelectedItemChanged(sender As Object, e As EventArgs) Handles dmn_FinishTime.SelectedItemChanged
        ' dmn_FinishTime.SelectedIndex = 0
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
        dmn_FinishTime.Items.Add("00 : 00")
        hitung()
    End Sub

    Private Sub dmn_BreakoutTime_SelectedItemChanged(sender As Object, e As EventArgs) Handles dmn_BreakoutTime.SelectedItemChanged
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
        dmn_BreakoutTime.Items.Add("00 : 00")
        hitung()
    End Sub

    Private Sub dmn_BreakinTime_SelectedItemChanged(sender As Object, e As EventArgs) Handles dmn_BreakinTime.SelectedItemChanged
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
        dmn_BreakinTime.Items.Add("00 : 00")
        hitung()
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click



    End Sub
End Class