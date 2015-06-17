﻿Imports ADODB
Public Class frm_MasterAttendanceStaffRegistrasiAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_MasterAttendanceStaffClassAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        txt_code.Focus()
    End Sub

    Private Sub txt_code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_code.KeyPress
        If txt_code.Text = "" And Asc(e.KeyChar) = 13 = True Then
            frm_MasterAttendanceStaffRegistrasiItemListing.ShowDialog()
            Exit Sub
        End If
        rs = cn.Execute("SELECT [Employee_Code],[Employee_Name],[Workgroup_Code],[Division],[Department],[Section],[Subsection] FROM  [AN_SUMATRA].[dbo].[TM_AttendanceListing] WHERE [Employee_Code]='" & txt_code.Text & "' ORDER BY [Employee_Code] ASC")
        If (rs.EOF = False) And (rs.BOF = False) Then
            txt_nama.Text = rs(1).Value.ToString
            txt_workgroup.Text = rs(2).Value.ToString
            txt_Division.Text = rs(3).Value.ToString
            txt_department.Text = rs(4).Value.ToString
            txt_section.Text = rs(5).Value.ToString
            txt_subsection.Text = rs(6).Value.ToString
        ElseIf Asc(e.KeyChar) = 13 Then
            MsgBox("Kode Karyawan Tidak Ditemukan")
        End If
    End Sub

    Private Sub txt_code_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged
        txt_nama.Text = ""
        txt_workgroup.Text = ""
        txt_Division.Text = ""
        txt_department.Text = ""
        txt_section.Text = ""
        txt_subsection.Text = ""
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class