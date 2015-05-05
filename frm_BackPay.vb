Imports ADODB
Imports System.Data.OleDb
Imports System.IO
Imports System.Data
Imports vbexcel = Microsoft.Office.Interop.Excel
Public Class frm_BackPay
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset


    Dim code, description, workingday As String


    Private Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Private Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Private Sub frm_BackPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ukuran form
        Me.Size = New Size(800, 600)
        Me.MinimumSize = New Size(600, 400)
        'akhir kode

        'koneksi
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        'akhir koneksi

        'bulan
        rs = cn.Execute("SELECT [month] FROM [AN_SUMATRA].[dbo].[TM_tb_month] ORDER BY [id] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            While Not rs.EOF
                cbo_month.Items.Add(rs(0).Value.ToString)
                rs.MoveNext()
            End While
        End If
        'akhir bulan

        'tahun
        rs = cn.Execute("SELECT [year] FROM [AN_SUMATRA].[dbo].[TM_tb_year] ORDER BY [id] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            While Not rs.EOF
                cbo_year.Items.Add(rs(0).Value.ToString)
                rs.MoveNext()
            End While
        End If
        'akhir tahun
    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()

    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim filePath As String = OpenFileDialog1.FileName
        Dim extension As String = Path.GetExtension(filePath)
        Dim conStr As String, sheetName As String

        conStr = String.Empty
        Select Case extension

            Case ".xls"
                'Excel 97-03
                conStr = String.Format(Excel03ConString, filePath, 0)
                Exit Select

            Case ".xlsx"
                'Excel 07
                conStr = String.Format(Excel07ConString, filePath, 0)
                Exit Select
        End Select

        'Get the name of the First Sheet.
        Using con As New OleDbConnection(conStr)
            Using cmd As New OleDbCommand()
                cmd.Connection = con
                con.Open()
                Dim dtExcelSchema As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                sheetName = dtExcelSchema.Rows(0)("TABLE_NAME").ToString()
                con.Close()
            End Using
        End Using

        'Read Data from the First Sheet.
        Using con As New OleDbConnection(conStr)
            Using cmd As New OleDbCommand()
                Using oda As New OleDbDataAdapter()
                    Dim dt As New DataTable()
                    cmd.CommandText = (Convert.ToString("SELECT * From [") & sheetName) + "]"
                    cmd.Connection = con
                    con.Open()
                    oda.SelectCommand = cmd
                    oda.Fill(dt)
                    con.Close()

                    'Populate DataGridView.
                    dgv_BackPay.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

   

    Private Sub frm_BackPay_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Height > 500 Then
            pnl_01.Height = Me.Height - (pnl_01.Top * 2) - 40
            btn_save.Top = pnl_01.Height - pnl_01.Top - btn_save.Height - 10
            btn_cancel.Top = pnl_01.Height - pnl_01.Top - btn_cancel.Height - 10
            btn_import.Left = Me.Width - btn_import.Width - 75
            dgv_BackPay.Top = 125
            dgv_BackPay.Height = Me.Height - 250
            dgv_BackPay.Width = Me.Width - 100
            LineShape1.Y1 = pnl_01.Height - pnl_01.Top - LineShape1.X1 - 45
            LineShape1.Y2 = pnl_01.Height - pnl_01.Top - LineShape1.X1 - 45

        End If

        If Me.Width > 400 Then
            pnl_01.Width = Me.Width - (pnl_01.Left * 2) - 15

        End If
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs)
        For i As Integer = 0 To Me.dgv_BackPay.Rows.Count - 2
            code = Me.dgv_BackPay.Rows(i).Cells(0).Value.ToString()
            description = Me.dgv_BackPay.Rows(i).Cells(1).Value.ToString()
            workingday = Me.dgv_BackPay.Rows(i).Cells(2).Value.ToString()

            Dim sqlInsert As String = "INSERT INTO [TM_tb_Backpay] ([month],[year],[document_name],[code],[description],[workingday]) VALUES "
            sqlInsert = sqlInsert & "('" & cbo_month.Text.ToString & "'" & _
              ",'" & cbo_year.Text & "'" & _
             ",'" & txt_DocumentName.Text & "'" & _
             ",'" & code & "'" & _
             ",'" & description & "'" & _
             ",'" & workingday & "')"
            cn.Execute(sqlInsert)
        Next
        cn.Close()
        cn.Open()
    End Sub
End Class