Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            .ColumnCount = 3
            .Columns(0).Name = "kolom 1"
            .Columns(1).Name = "kolom 2"
            .Columns(2).Name = "kolom 3"

            DataGridView1.Rows.Add()
            DataGridView1.Rows(0).HeaderCell.Value = "row header"
            DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        End With
        'DataGridView1.Columns(0).HeaderCell.Value = "kolom 1"
    End Sub
End Class