﻿Imports ADODB
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frm_MasterAttendanceStaffRegistrasi
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Sub datagrid()
        Dim sql As String
        rs = New ADODB.Recordset
        sql = "SELECT * FROM  [AN_SUMATRA].[dbo].[TM_AttendanceStaffClass] ORDER BY [No]"

        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(sql, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With
        Me.dgv_StaffClass.DataSource = RecordSetToDataTable(rs)
        dgv_StaffClass.Refresh()
        dgv_StaffClass.Columns(0).Width = 40
        dgv_StaffClass.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgv_StaffClass.Columns(1).Width = 70
        dgv_StaffClass.Columns(2).Width = 130
        dgv_StaffClass.Columns(3).Width = 70
        dgv_StaffClass.Columns(4).Width = 130
        dgv_StaffClass.Columns(5).Width = 150
        dgv_StaffClass.Columns(6).Width = 130
        dgv_StaffClass.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgv_StaffClass.Columns(7).Width = 70
        dgv_StaffClass.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgv_StaffClass.RowsDefaultCellStyle.BackColor = Color.Lavender
        dgv_StaffClass.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Function RecordSetToDataTable( _
             ByVal objRS As ADODB.Recordset) As DataTable

        Dim objDA As New OleDbDataAdapter()
        Dim objDT As New DataTable()
        objDA.Fill(objDT, objRS)
        Return objDT

    End Function
    Private Sub frm_MasterAttendanceStaffClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        Call datagrid()
        txt_CariData.Focus()
    End Sub

    Private Sub btn_ExportToExcel_Click(sender As Object, e As EventArgs) Handles btn_ExportToExcel.Click
        Try
            Dim xlAPP As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlAPP = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlAPP.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            For i = 0 To dgv_StaffClass.RowCount - 2
                For j = 0 To dgv_StaffClass.ColumnCount - 1
                    For k As Integer = 1 To dgv_StaffClass.Columns.Count
                        xlWorkSheet.Cells(1, k) = dgv_StaffClass.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dgv_StaffClass(j, i).Value.ToString()
                    Next
                Next
            Next

            xlAPP.Visible = True
            xlWorkSheet.UsedRange.EntireRow.AutoFit()
            xlWorkSheet.UsedRange.EntireColumn.AutoFit()

            releaseObject(xlAPP)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch es As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btn_RefreshData_Click(sender As Object, e As EventArgs) Handles btn_RefreshData.Click
        Call datagrid()
        dgv_StaffClass.Refresh()
        txt_CariData.Text = ""
        txt_CariData.Focus()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub frm_MasterAttendanceStaffClass_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Height > 500 Then
            pnl_Form.Height = Me.Height - (pnl_Form.Top * 2) - 40
            btn_ExportToExcel.Top = pnl_Form.Height - pnl_Form.Top - btn_ExportToExcel.Height - 10
            btn_RefreshData.Top = pnl_Form.Height - pnl_Form.Top - btn_RefreshData.Height - 10
            btn_TambahBaru.Top = pnl_Form.Height - pnl_Form.Top - btn_TambahBaru.Height - 10
            btn_Close.Top = pnl_Form.Height - pnl_Form.Top - btn_Close.Height - 10
            dgv_StaffClass.Top = 66
            dgv_StaffClass.Height = Me.Height - 180

        End If
        If Me.Width > 400 Then
            pnl_Form.Width = Me.Width - (pnl_Form.Left * 2) - 15
            btn_Close.Left = Me.Width - btn_Close.Width - 30
            btn_TambahBaru.Left = Me.Width - btn_TambahBaru.Width - 138
            btn_RefreshData.Left = Me.Width - btn_RefreshData.Width - 246
            btn_ExportToExcel.Left = Me.Width - btn_ExportToExcel.Width - 354
            dgv_StaffClass.Width = Me.Width - 40

        End If
    End Sub

    Private Sub btn_TambahBaru_Click(sender As Object, e As EventArgs) Handles btn_TambahBaru.Click
        frm_MasterAttendanceStaffRegistrasiAddNew.Show()
    End Sub

    Private Sub txt_CariData_TextChanged(sender As Object, e As EventArgs) Handles txt_CariData.TextChanged
        Dim sqlsearch As String
        rs = New ADODB.Recordset
        sqlsearch = "SELECT * FROM  [AN_SUMATRA].[dbo].[TM_AttendanceStaffClass] where [Staff_Name] like '%" & txt_CariData.Text & "%' order by [No]"

        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(sqlsearch, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With
        Me.dgv_StaffClass.DataSource = RecordSetToDataTable(rs)
        If rs.BOF Then
            dgv_StaffClass.DataSource = rs
            dgv_StaffClass.Refresh()
        End If
    End Sub
End Class