Imports ADODB
Imports System.Data
Imports System.Data.OleDb
Public Class frm_MasterWorkgrouptoShiftReferenceAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_MasterWorkgrouptoShiftReferenceAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        rs = cn.Execute("SELECT distinct [Workgroup] FROM [AN_SUMATRA].[dbo].[TM_Shift1] ORDER BY [Workgroup] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            cbo_workgroup.Items.Clear()
            While Not rs.EOF
                cbo_workgroup.Items.Add(rs(0).Value.ToString)
                rs.MoveNext()

            End While
        End If
        cbo_workgroup.Refresh()
    End Sub

    Private Sub cbo_workgroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_workgroup.SelectedIndexChanged
        Dim sql As String
        rs = New ADODB.Recordset
        sql = "SELECT distinct [No],[Shift_Code],[Shif_Desc],[Check] FROM [AN_SUMATRA].[dbo].[TM_Shift1] where [Workgroup] like '%" & cbo_workgroup.Text & "%' order BY [No] ASC"
        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(sql, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With
        cn.Execute(sql)
       ' rs = cn.Execute("SELECT distinct [No],[Shift_Code],[Shif_Desc],[Check] FROM [AN_SUMATRA].[dbo].[TM_Shift1] where [Workgroup] like '%" & cbo_workgroup.Text & "%' order BY [No] ASC")
        If (rs.EOF = False) And (rs.BOF = False) Then
            Me.DGV.DataSource = RecordSetToDataTable(rs)
            DGV.RowsDefaultCellStyle.BackColor = Color.Lavender
            DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            cbo_workgroup.Refresh()
        End If
    End Sub
    Public Function RecordSetToDataTable( _
             ByVal objRS As ADODB.Recordset) As DataTable

        Dim objDA As New OleDbDataAdapter()
        Dim objDT As New DataTable()
        objDA.Fill(objDT, objRS)
        Return objDT

    End Function

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If MessageBox.Show("Apakah Anda yakin akan menyimpan data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                For Each row As DataGridViewRow In DGV.Rows
                    If CType(row.Cells("Check"), DataGridViewCheckBoxCell).Value = True Then
                        Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_ShiftReference]([Workgorup_Code],[Shift_Code],[Create_By],[Create_Time],[System_Id]) values "
                        sqlInsert = sqlInsert & " ('" & cbo_workgroup.Text.ToString & "','" & row.Cells(0).Value & "','" & CurrentAccountName & "'," & "GETDATE()" & " " & ",'" & CurrentAccountId & "')"
                        cn.Execute(sqlInsert)
                        Me.Close()
                    End If
                Next
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        cn.Close()
    End Sub
End Class