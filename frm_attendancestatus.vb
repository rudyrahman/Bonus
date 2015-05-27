Imports ADODB
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frm_attendancestatus
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_attendancestatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click

    End Sub

    Private Sub frm_attendancestatus_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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