Imports ADODB
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frm_MasterEmployeesSchedule
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Sub datagrid()
        Dim sql As String
        rs = New ADODB.Recordset
        sql = "SELECT * FROM  [AN_SUMATRA].[dbo].[TM_MonthPeriode] order by [No]"

        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(sql, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With
        Me.dgv_MasterEmployeesSchedule.DataSource = RecordSetToDataTable(rs)
        dgv_MasterEmployeesSchedule.Refresh()
        dgv_MasterEmployeesSchedule.Columns(0).Width = 40
        dgv_MasterEmployeesSchedule.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgv_MasterEmployeesSchedule.Columns(1).Width = 70
        dgv_MasterEmployeesSchedule.Columns(2).Width = 130
        dgv_MasterEmployeesSchedule.Columns(3).Width = 100
        dgv_MasterEmployeesSchedule.Columns(4).Width = 100
        dgv_MasterEmployeesSchedule.Columns(5).Width = 250
        dgv_MasterEmployeesSchedule.Columns(6).Width = 150
        dgv_MasterEmployeesSchedule.Columns(7).Width = 80
        dgv_MasterEmployeesSchedule.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
    End Sub
    Public Function RecordSetToDataTable( _
             ByVal objRS As ADODB.Recordset) As DataTable

        Dim objDA As New OleDbDataAdapter()
        Dim objDT As New DataTable()
        objDA.Fill(objDT, objRS)
        Return objDT

    End Function
    Private Sub frm_MasterEmployeesSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        Call datagrid()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_TambahBaru_Click(sender As Object, e As EventArgs) Handles btn_TambahBaru.Click
        frm_MasterEmployeesScheduleAddNew.ShowDialog()
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

            For i = 0 To dgv_MasterEmployeesSchedule.RowCount - 2
                For j = 0 To dgv_MasterEmployeesSchedule.ColumnCount - 1
                    For k As Integer = 1 To dgv_MasterEmployeesSchedule.Columns.Count
                        xlWorkSheet.Cells(1, k) = dgv_MasterEmployeesSchedule.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dgv_MasterEmployeesSchedule(j, i).Value.ToString()
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
        dgv_MasterEmployeesSchedule.Refresh()
        txt_CariData.Text = ""
    End Sub

    Private Sub txt_CariData_TextChanged(sender As Object, e As EventArgs) Handles txt_CariData.TextChanged
        Dim sqlsearch As String
        rs = New ADODB.Recordset
        sqlsearch = "select * from [AN_SUMATRA].[dbo].[TM_MonthPeriode] where [Description] like '%" & txt_CariData.Text & "%' order by [No]"

        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(sqlsearch, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With
        Me.dgv_MasterEmployeesSchedule.DataSource = RecordSetToDataTable(rs)
        If rs.BOF Then
            dgv_MasterEmployeesSchedule.DataSource = rs
            dgv_MasterEmployeesSchedule.Refresh()
        End If
    End Sub
End Class