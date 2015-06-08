Imports ADODB
Imports System.Data.OleDb
Public Class frm_MasterEStatusArragementAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Dim dgv As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        cn.Close()
    End Sub

    Private Sub txt_code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_code.KeyPress
        Try

            rs = cn.Execute("SELECT [employee_name],[workgroup_code],[division_code],[department_code],[section_code],[sub_sectioncode],[day_of_week_#1],[day_of_week_#2],[day_of_week_#3],[day_of_week_#4],[day_of_week_#5],[day_of_week_#6],[day_of_week_#7] FROM [AN_SUMATRA].[dbo].[TM_tb_statusarragement] WHERE [employee_code]='" & txt_code.Text & "' ORDER BY [employee_code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                txt_Name.Text = rs(0).Value.ToString
                cbo_Workgroup.Text = rs(1).Value.ToString
                cbo_division.Text = rs(2).Value.ToString
                cbo_Department.Text = rs(3).Value.ToString
                cbo_Section.Text = rs(4).Value.ToString
                cbo_Subsection.Text = rs(5).Value.ToString
        
                Me.dgv_StatusArragement.DataSource = RecordSetToDataTable(rs)
                dgv_StatusArragement.DataSource = rs(6).Value.ToString
                dgv_StatusArragement.DataSource = rs(7).Value.ToString
                dgv_StatusArragement.DataSource = rs(8).Value.ToString
                dgv_StatusArragement.DataSource = rs(9).Value.ToString
                dgv_StatusArragement.DataSource = rs(10).Value.ToString
                dgv_StatusArragement.DataSource = rs(11).Value.ToString
                dgv_StatusArragement.DataSource = rs(12).Value.ToString



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

    Private Sub frm_MasterEStatusArragementAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_code.Text = ""
            txt_Name.Text = ""
            cbo_Workgroup.Text = ""
            cbo_division.Text = ""
            cbo_Department.Text = ""
            cbo_Section.Text = ""
            cbo_Subsection.Text = ""
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
       
    End Sub
End Class