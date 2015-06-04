﻿Imports ADODB
Imports vbexcel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Public Class frm_MasterWorkgroup
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim strs As String
    Dim search As String

    Dim rsExcel As ADODB.Recordset
    Dim strExcel As String


    Private Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Private Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"

    Private Sub frm_MasterWorkgroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_MasterWorkgroup_Resize(Me, Nothing)
        txt_CariData.Focus()
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = New ADODB.Recordset
            strs = "SELECT * FROM  [AN_SUMATRA].[dbo].[TM_tb_workgroup] order by [id]"

            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(strs, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_MasterWorkgroup.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub tampilgrid()
        dgv_MasterWorkgroup.Columns(0).Width = 40
        dgv_MasterWorkgroup.Columns(1).Width = 100
        dgv_MasterWorkgroup.Columns(2).Width = 150
        dgv_MasterWorkgroup.Columns(3).Width = 100
        dgv_MasterWorkgroup.Columns(4).Width = 100
        dgv_MasterWorkgroup.Columns(5).Width = 60
        dgv_MasterWorkgroup.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_MasterWorkgroup.RowTemplate.Height = 17
        dgv_MasterWorkgroup.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_MasterWorkgroup.RowsDefaultCellStyle.BackColor = Color.Lavender
        dgv_MasterWorkgroup.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub frm_MasterWorkgroup_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Height > 300 Then
            pnl_Form.Height = Me.Height - (pnl_Form.Top * 2) - 40
            btn_ExportToExcel.Top = pnl_Form.Height - pnl_Form.Top - btn_ExportToExcel.Height - 10
            btn_RefreshData.Top = pnl_Form.Height - pnl_Form.Top - btn_RefreshData.Height - 10
            btn_TambahBaru.Top = pnl_Form.Height - pnl_Form.Top - btn_TambahBaru.Height - 10
            btn_Close.Top = pnl_Form.Height - pnl_Form.Top - btn_Close.Height - 10

            dgv_MasterWorkgroup.Top = 66
            dgv_MasterWorkgroup.Height = Me.Height - 180

        End If
        If Me.Width > 570 Then
            pnl_Form.Width = Me.Width - (pnl_Form.Left * 2) - 15
            btn_Close.Left = Me.Width - btn_Close.Width - 30
            btn_TambahBaru.Left = Me.Width - btn_TambahBaru.Width - 138
            btn_RefreshData.Left = Me.Width - btn_RefreshData.Width - 246
            btn_ExportToExcel.Left = Me.Width - btn_ExportToExcel.Width - 354
            dgv_MasterWorkgroup.Width = Me.Width - 40

        End If
    End Sub

    Private Sub btn_TambahBaru_Click_1(sender As Object, e As EventArgs) Handles btn_TambahBaru.Click
        frm_MasterWorkgroupAddNew.ShowDialog()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_RefreshData_Click(sender As Object, e As EventArgs) Handles btn_RefreshData.Click
        Try
            rs = New ADODB.Recordset
            strs = "SELECT * FROM  [AN_SUMATRA].[dbo].[TM_tb_workgroup] order by [id]"

            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(strs, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_MasterWorkgroup.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()

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
            For j = 0 To dgv_MasterWorkgroup.Columns.Count - 1

                excelworksheet.Cells(1, j + 1) = dgv_MasterWorkgroup.Columns(j).HeaderText
                For i = 1 To dgv_MasterWorkgroup.Rows.Count - 1
                    '
                    excelworksheet.Cells(i + 1, j + 1) = "'" & dgv_MasterWorkgroup(j, i - 1).Value.ToString
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
            search = "select * from [AN_SUMATRA].[dbo].[TM_tb_workgroup] where [workgroup_description] like '%" & txt_CariData.Text & "%' order by [id]"
            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(search, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_MasterWorkgroup.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()
            If rs.BOF Then
                dgv_MasterWorkgroup.DataSource = rs
                dgv_MasterWorkgroup.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
End Class