Imports ADODB
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frm_MonthPeriode
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
        Me.DGV.DataSource = RecordSetToDataTable(rs)
        DGV.Refresh()
        DGV.Columns(0).Width = 40
        DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        DGV.Columns(1).Width = 70
        DGV.Columns(2).Width = 130
        DGV.Columns(3).Width = 100
        DGV.Columns(4).Width = 100
        DGV.Columns(5).Width = 250
        DGV.Columns(6).Width = 150
        DGV.Columns(7).Width = 80
        DGV.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
    End Sub
    Public Function RecordSetToDataTable( _
              ByVal objRS As ADODB.Recordset) As DataTable

        Dim objDA As New OleDbDataAdapter()
        Dim objDT As New DataTable()
        objDA.Fill(objDT, objRS)
        Return objDT

    End Function

    Private Sub frm_MonthPeriode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        Call datagrid()
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
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

            For i = 0 To DGV.RowCount - 2
                For j = 0 To DGV.ColumnCount - 1
                    For k As Integer = 1 To DGV.Columns.Count
                        xlWorkSheet.Cells(1, k) = DGV.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DGV(j, i).Value.ToString()
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

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        Dim sqlsearch As String
        rs = New ADODB.Recordset
        sqlsearch = "select * from [AN_SUMATRA].[dbo].[TM_MonthPeriode] where [Description] like '%" & txt_cari.Text & "%' order by [No]"

        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(sqlsearch, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With
        Me.DGV.DataSource = RecordSetToDataTable(rs)
        If rs.BOF Then
            DGV.DataSource = rs
            DGV.Refresh()
        End If

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Call datagrid()
        DGV.Refresh()
        txt_cari.Text = ""
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_tambahbaru_Click(sender As Object, e As EventArgs) Handles btn_tambahbaru.Click
        frm_AddNew.ShowDialog()
    End Sub

    Private Sub frm_MonthPeriode_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Height > 500 Then
            pnl1.Height = Me.Height - (pnl1.Top * 2) - 695
            pnl2.Height = Me.Height - (pnl2.Top * 2) - 50
            DGV.Top = 10
            DGV.Height = Me.Height - 170
            DGV.Width = Me.Width - 30
            btn_close.Left = Me.Width - btn_close.Width - 50
            btn_tambahbaru.Left = Me.Width - btn_tambahbaru.Width - 130
            btn_refresh.Left = Me.Width - btn_refresh.Width - 230
            btn_export.Left = Me.Width - btn_export.Width - 330
        End If

        If Me.Width > 400 Then
            pnl1.Width = Me.Width - (pnl1.Left * 2) - 15
            pnl2.Width = Me.Width - (pnl2.Left * 2) - 15
            pnl2.Height = Me.Height - (pnl2.Top * 2) - 50
            DGV.Top = 10
            DGV.Height = Me.Height - 170
            DGV.Width = Me.Width - 30
            btn_close.Left = Me.Width - btn_close.Width - 40
            btn_tambahbaru.Left = Me.Width - btn_tambahbaru.Width - 130
            btn_refresh.Left = Me.Width - btn_refresh.Width - 230
            btn_export.Left = Me.Width - btn_export.Width - 330
        End If
    End Sub
End Class