﻿Imports ADODB
Imports System.Data
Imports System.Data.OleDb
Public Class frm_MasterWorkgrouptoShiftReferenceAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_MasterWorkgrouptoShiftReferenceAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        rs = cn.Execute("SELECT distinct [Workgroup] FROM [AN_SUMATRA].[dbo].[TM_Shift1] ORDER BY [Workgroup] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            While Not rs.EOF
                cbo_workgroup.Items.Add(rs(0).Value.ToString)
                rs.MoveNext()

            End While
        End If
    End Sub

    Private Sub cbo_workgroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_workgroup.SelectedIndexChanged
        Dim sql As String
        rs = New ADODB.Recordset
        sql = "SELECT [No],[Shift_Code],[Shif_Desc],[Check] FROM [AN_SUMATRA].[dbo].[TM_Shift1] where [Workgroup] like '%" & cbo_workgroup.Text & "%' order BY [Workgroup] ASC"
        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(sql, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With

        If (rs.EOF = False) And (rs.BOF = False) Then
            Me.DGV.DataSource = RecordSetToDataTable(rs)
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
        If MessageBox.Show("Apakah Anda yakin akan menyimpan data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            For i As Integer = 0 To DGV.Rows.Count - 2
                For Each row As DataGridViewRow In DGV.Rows
                    If row.Cells("Check").Selected = True Then
                        Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_ShiftReference]([Workgorup_Code],[Shift_Code],[Create_By],[Create_Time],[System_Id]) values "
                        sqlInsert = sqlInsert & " ('" & cbo_workgroup.Text.ToString & "','" & DGV.Rows(i).Cells(0).Value & "','" & CurrentAccountName & "'," & "GETDATE()" & " " & ",'" & CurrentAccountId & "')"
                        cn.Execute(sqlInsert)
                        Me.Close()
                    End If
                Next
            Next
            'cn.Close()

        End If
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        cn.Close()
    End Sub
End Class