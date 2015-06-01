Public Class Frm_MasterEDataFromPayrolAddNew

    Private Sub btn_LookupFile_Click(sender As Object, e As EventArgs) Handles btn_LookupFile.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        btn_ProcessData.Enabled = False
    End Sub
End Class