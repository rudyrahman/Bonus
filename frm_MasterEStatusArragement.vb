﻿Imports ADODB
Imports vbexcel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Public Class frm_MasterEStatusArragement
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim strs As String
    Dim search As String

    Dim rsExcel As ADODB.Recordset
    Dim strExcel As String
    Private Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Private Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"

    Private Sub frm_MasterEStatusArragement_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If (dgv_MasterEStatusArragement.Rows.Count > 0) Then
            dgv_MasterEStatusArragement.Rows(0).Selected = True
        End If
    End Sub
    Private Sub frm_MasterEStatusArragement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_MasterEStatusArragement_Resize(Me, Nothing)
        txt_CariData.Focus()
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = New ADODB.Recordset
            strs = "SELECT * FROM  [AN_SUMATRA].[dbo].[TM_tb_statusarragement] order by [id]"

            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(strs, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_MasterEStatusArragement.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Sub tampilgrid()
        dgv_MasterEStatusArragement.Columns(0).Width = 40
        dgv_MasterEStatusArragement.Columns(1).Width = 100
        dgv_MasterEStatusArragement.Columns(2).Width = 150
        dgv_MasterEStatusArragement.Columns(3).Width = 100
        dgv_MasterEStatusArragement.Columns(4).Width = 150
        dgv_MasterEStatusArragement.Columns(5).Width = 100
        dgv_MasterEStatusArragement.Columns(6).Width = 100
        dgv_MasterEStatusArragement.Columns(7).Width = 100
        dgv_MasterEStatusArragement.Columns(8).Width = 150
        dgv_MasterEStatusArragement.Columns(9).Width = 100
        dgv_MasterEStatusArragement.Columns(10).Width = 100
        dgv_MasterEStatusArragement.Columns(11).Width = 150
        dgv_MasterEStatusArragement.Columns(12).Width = 100
        dgv_MasterEStatusArragement.Columns(13).Width = 100
        dgv_MasterEStatusArragement.Columns(14).Width = 100
        dgv_MasterEStatusArragement.Columns(15).Width = 100
        dgv_MasterEStatusArragement.Columns(16).Width = 100
        dgv_MasterEStatusArragement.Columns(17).Width = 100
        dgv_MasterEStatusArragement.Columns(18).Width = 150
        dgv_MasterEStatusArragement.Columns(19).Width = 150
        dgv_MasterEStatusArragement.Columns(20).Width = 150
        dgv_MasterEStatusArragement.Columns(21).Width = 70

        dgv_MasterEStatusArragement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_MasterEStatusArragement.RowTemplate.Height = 17
        dgv_MasterEStatusArragement.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_MasterEStatusArragement.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_MasterEStatusArragement.RowsDefaultCellStyle.BackColor = Color.Lavender
        dgv_MasterEStatusArragement.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        Call AutoNumberRowsForGridView()
        If (dgv_MasterEStatusArragement.Rows.Count > 0) Then
            dgv_MasterEStatusArragement.Rows(0).Selected = True
        End If
        'dgv_MasterEStatusArragement.ColumnHeadersVisible = true
    End Sub
    Private Sub AutoNumberRowsForGridView()
        If dgv_MasterEStatusArragement IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (dgv_MasterEStatusArragement.Rows.Count - 2))
                dgv_MasterEStatusArragement.Item(0, count).Value = String.Format((count + 1).ToString(), "0")
                count += 1
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
    Private Sub frm_MasterEStatusArragement_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Height > 300 Then
            pnl_Form.Height = Me.Height - (pnl_Form.Top * 2) - 40
            btn_ExportToExcel.Top = pnl_Form.Height - pnl_Form.Top - btn_ExportToExcel.Height - 10
            btn_RefreshData.Top = pnl_Form.Height - pnl_Form.Top - btn_RefreshData.Height - 10
            btn_TambahBaru.Top = pnl_Form.Height - pnl_Form.Top - btn_TambahBaru.Height - 10
            btn_Close.Top = pnl_Form.Height - pnl_Form.Top - btn_Close.Height - 10

            dgv_MasterEStatusArragement.Top = 66
            dgv_MasterEStatusArragement.Height = Me.Height - 180

        End If
        If Me.Width > 570 Then
            pnl_Form.Width = Me.Width - (pnl_Form.Left * 2) - 15
            btn_Close.Left = Me.Width - btn_Close.Width - 30
            btn_TambahBaru.Left = Me.Width - btn_TambahBaru.Width - 138
            btn_RefreshData.Left = Me.Width - btn_RefreshData.Width - 246
            btn_ExportToExcel.Left = Me.Width - btn_ExportToExcel.Width - 354
            dgv_MasterEStatusArragement.Width = Me.Width - 40

        End If

    End Sub
    Private Sub btn_TambahBaru_Click_1(sender As Object, e As EventArgs) Handles btn_TambahBaru.Click
        Try
            frm_MasterEStatusArragementAddNew.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
        cn.Close()
    End Sub

    Private Sub btn_RefreshData_Click(sender As Object, e As EventArgs) Handles btn_RefreshData.Click
        Try
            rs = New ADODB.Recordset
            strs = "SELECT * FROM  [AN_SUMATRA].[dbo].[TM_tb_statusarragement] order by [id]"

            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(strs, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_MasterEStatusArragement.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_ExportToExcel_Click(sender As Object, e As EventArgs) Handles btn_ExportToExcel.Click
        Try
            Dim excelapp As vbexcel.Application
            Dim excelworkbook As vbexcel.Workbook
            Dim excelworksheet As vbexcel.Worksheet
            Dim msvalue As Object = System.Reflection.Missing.Value

            excelapp = New vbexcel.Application
            excelworkbook = excelapp.Workbooks.Add(msvalue)
            excelworksheet = excelworkbook.Sheets("sheet1")

            'Perulangan untuk memindahkan data dari datagridview ke worksheet excel
            For j = 0 To dgv_MasterEStatusArragement.Columns.Count - 1

                excelworksheet.Cells(1, j + 1) = dgv_MasterEStatusArragement.Columns(j).HeaderText
                For i = 1 To dgv_MasterEStatusArragement.Rows.Count - 1
                    '
                    excelworksheet.Cells(i + 1, j + 1) = "'" & dgv_MasterEStatusArragement(j, i - 1).Value.ToString
                Next

            Next

            ' Mengatur ukuran baris dan column
            excelworksheet.UsedRange.EntireRow.AutoFit()
            excelworksheet.UsedRange.EntireColumn.AutoFit()

            ' Mengatur border table
            excelworksheet.UsedRange.Borders.LineStyle = vbexcel.XlLineStyle.xlContinuous
            excelworksheet.UsedRange.Borders.Color = Color.Black
            excelworksheet.UsedRange.Borders.Weight = vbexcel.XlBorderWeight.xlThin
            excelapp.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub txt_CariData_TextChanged(sender As Object, e As EventArgs) Handles txt_CariData.TextChanged
        Try
            rs = New ADODB.Recordset
            search = "select * from [AN_SUMATRA].[dbo].[TM_tb_statusarragement] where [division_description] like '%" & txt_CariData.Text & "%' order by [id]"
            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(search, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_MasterEStatusArragement.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()
            If rs.BOF Then
                dgv_MasterEStatusArragement.DataSource = rs
                dgv_MasterEStatusArragement.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

End Class