Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            .ColumnCount = 4
            .Columns(1).Name = "#1"
            .Columns(2).Name = "#2"
            .Columns(3).Name = "#3"

            DataGridView1.Columns(0).HeaderCell.Value = "Jadwal"

            DataGridView1.Rows.Add()
            DataGridView1.Rows(0).HeaderCell.Value = "Day"
            DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        End With

    End Sub
End Class