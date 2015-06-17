Imports ADODB
Imports System.Data.OleDb
Public Class frm_MasterAttendanceStaffRegistrasiItemListing
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim search As String

    Sub datagrid()
        Dim Sql As String
        rs = New ADODB.Recordset
        Sql = "SELECT [Employee_Code],[Employee_Name],[Workgroup_Code],[Division],[Department],[Section],[Subsection] FROM  [AN_SUMATRA].[dbo].[TM_AttendanceListing] order by [No]"

        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(Sql, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With
        Me.dgv_ItemListing.DataSource = RecordSetToDataTable(rs)
        dgv_ItemListing.Columns(0).Width = 100
        dgv_ItemListing.Columns(1).Width = 100
        dgv_ItemListing.Columns(2).Width = 150
        dgv_ItemListing.RowTemplate.Height = 17
        dgv_ItemListing.RowsDefaultCellStyle.BackColor = Color.Lavender
        dgv_ItemListing.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Private Sub frm_MasterAttendanceStaffClassItemListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_caridata.Focus()
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            Call datagrid()
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

    Private Sub txt_caridata_TextChanged(sender As Object, e As EventArgs) Handles txt_caridata.TextChanged
        Try
            rs = New ADODB.Recordset
            search = "SELECT [Employee_Code],[Employee_Name],[Workgroup_Code],[Division],[Department],[Section],[Subsection] FROM  [AN_SUMATRA].[dbo].[TM_AttendanceListing] where [Employee_Code] like '%" & txt_caridata.Text & "%' order by [Employee_Code]"
            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(search, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_ItemListing.DataSource = RecordSetToDataTable(rs)
            Call datagrid()
            If rs.BOF Then
                dgv_ItemListing.DataSource = rs
                dgv_ItemListing.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            rs = New ADODB.Recordset
            search = "SELECT [Employee_Code],[Employee_Name],[Workgroup_Code],[Division],[Department],[Section],[Subsection] FROM  [AN_SUMATRA].[dbo].[TM_AttendanceListing] where [Employee_Code] like '%" & txt_caridata.Text & "%' order by [Employee_Code]"
            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(search, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_ItemListing.DataSource = RecordSetToDataTable(rs)
            Call datagrid()
            If rs.BOF Then
                dgv_ItemListing.DataSource = rs
                dgv_ItemListing.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgv_ItemListing_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ItemListing.CellContentDoubleClick
        If dgv_ItemListing.Rows.Count > 0 Then
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_code.Text = dgv_ItemListing("Employee_Code", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_nama.Text = dgv_ItemListing("Employee_Name", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_workgroup.Text = dgv_ItemListing("Workgroup_Code", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_Division.Text = dgv_ItemListing("Division", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_department.Text = dgv_ItemListing("Department", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_section.Text = dgv_ItemListing("Section", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_subsection.Text = dgv_ItemListing("Subsection", e.RowIndex).Value.ToString()

        End If
        Me.Close()
    End Sub
End Class