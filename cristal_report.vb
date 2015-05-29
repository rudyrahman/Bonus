Imports ADODB
Public Class cristal_report
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub cristal_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
 
    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

            Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strAlamatReport As String = "C:\Users\Win7\Source\Repos\Bonus\CrystalReport1.rpt"
            objReport.Load(strAlamatReport)
            CrystalReportViewer1.ReportSource = objReport
            objReport.SetDatabaseLogon("itdevelopment", "itdevelopment2015")
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class