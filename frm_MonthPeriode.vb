Imports ADODB
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frm_MonthPeriode
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
  

    Private Sub frm_MonthPeriode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()

        rs.Open("select * from TM_tb_month", cn)

        DGV.DataSource = rs.DataSource
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
            xlWorkSheet = xlWorkBook.Sheet("sheet1")

            For i = 0 To DGV.RowCount - 2
                For j = 0 To DGV.ColumnCount - 1
                    For k As Integer = 1 To DGV.Columns.Count
                        xlWorkSheet.Cells(1, k) = DGV.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DGV(j, i).Value.ToString()
                    Next
                Next
            Next
            xlWorkSheet.SaveAs("D:\Book1.xlsx")
            xlWorkBook.Close()
            xlAPP.Quit()

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
        rs.Open("select [month] from [TM_tb_month] where [month] like '%" & txt_cari.Text & "%'", cn)
        If Not rs.EOF Then
            DGV.DataSource = "select [month] from [TM_tb_month] where [month] like '%" & txt_cari.Text & "%'"
            DGV.Refresh()

        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        DGV.Refresh()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class