Imports ADODB
Imports System.Data.OleDb
Imports System.IO
Imports System.Data
Imports vbexcel = Microsoft.Office.Interop.Excel
Public Class frm_Deduction
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Public code, description As String
    Public value As Integer
    Public cmd = CreateObject("ADODB.Command")

    Private Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Private Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"

    Private Sub frm_Deduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_Deduction_Resize(Me, Nothing)

        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = cn.Execute("SELECT [month] FROM [AN_SUMATRA].[dbo].[TM_tb_month] ORDER BY [id] ASC")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                While Not rs.EOF
                    cbo_Month.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
            End If

            rs = cn.Execute("SELECT [year] FROM [AN_SUMATRA].[dbo].[TM_tb_year] ORDER BY [id] ASC")
            If ((rs.EOF = False) And (rs.BOF = False)) = True Then
                While Not rs.EOF
                    cbo_year.Items.Add(rs(0).Value.ToString)
                    rs.MoveNext()
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        cn.Close()
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
                    dgv_Deduction.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs)
        Try
            If cbo_Month.Text = "" Then
                MsgBox("Month is empty", vbCritical, "Failed")
                cbo_Month.Focus()
            ElseIf cbo_year.Text = "" Then
                MsgBox("year is empty", vbCritical, "Failed")
                cbo_year.Focus()
            ElseIf txt_DocumentName.Text = "" Then
                MsgBox("Document Name is empty", vbCritical, "Failed")
                txt_DocumentName.Focus()
                Exit Sub
            End If
            For i As Integer = 0 To Me.dgv_Deduction.Rows.Count - 2
                code = Me.dgv_Deduction.Rows(i).Cells(0).Value.ToString()
                description = Me.dgv_Deduction.Rows(i).Cells(1).Value.ToString()
                value = Me.dgv_Deduction.Rows(i).Cells(2).Value.ToString()

                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_Deduction] ([month],[year],[document_name],[code],[description],[value]) VALUES "
                sqlInsert = sqlInsert & " ('" & cbo_Month.Text.ToString & "'" & _
                    ",'" & cbo_year.Text & "'" & _
                    ",'" & txt_DocumentName.Text & "'" & _
                    ",'" & code & "'" & _
                    ",'" & description & "'" & _
                    ",'" & value & "')"
                cn.Execute(sqlInsert)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        cn.Close()
    End Sub

    Private Sub frm_Deduction_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState < FormWindowState.Minimized Then
            dgv_Deduction.Top = 120
            dgv_Deduction.Height = Me.Height - 240
            dgv_Deduction.Width = Me.Width - 40
            btn_ImportFromExcel.Left = Me.Width - btn_ImportFromExcel.Width - 30
            LineShape1.Y1 = 506
            LineShape1.Y2 = 506
        Else
            dgv_Deduction.Top = 120
            dgv_Deduction.Height = Me.Height - 240
            dgv_Deduction.Width = Me.Width - 40
            btn_ImportFromExcel.Left = Me.Width - btn_ImportFromExcel.Width - 30
            LineShape1.X2 = Me.Width
            LineShape1.Y1 = 650
            LineShape1.Y2 = 650

        End If
        If Me.Height > 500 Then
            pnl_Deduction.Height = Me.Height - (pnl_Deduction.Top * 2) - 40
          
            btn_Save.Top = pnl_Deduction.Height - pnl_Deduction.Top - btn_Save.Height - 10
            btn_Cancel.Top = pnl_Deduction.Height - pnl_Deduction.Top - btn_Cancel.Height - 10

        End If
        If Me.Width > 400 Then
            pnl_Deduction.Width = Me.Width - (pnl_Deduction.Left * 2) - 15
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_ImportFromExcel_Click_1(sender As Object, e As EventArgs) Handles btn_ImportFromExcel.Click
        OpenFileDialog1.ShowDialog()
    End Sub

End Class