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
        dgv_ItemListing.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgv_ItemListing.Columns(1).Width = 150
        dgv_ItemListing.Columns(2).Width = 100
        dgv_ItemListing.Columns(3).Width = 100
        dgv_ItemListing.Columns(4).Width = 100
        dgv_ItemListing.Columns(5).Width = 100
        dgv_ItemListing.Columns(6).Width = 100
        dgv_ItemListing.RowTemplate.Height = 17
        dgv_ItemListing.RowsDefaultCellStyle.BackColor = Color.Lavender
        dgv_ItemListing.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub frm_MasterAttendanceStaffRegistrasiItemListing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        cn.Close()
    End Sub
    Private Sub frm_MasterAttendanceStaffClassItemListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If chk_Maximize.Checked = True Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
            dgv_ItemListing.Focus()
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            dgv_ItemListing.SelectionMode = DataGridViewSelectionMode.FullRowSelect
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
            search = "SELECT [Employee_Code],[Employee_Name],[Workgroup_Code],[Division],[Department],[Section],[Subsection] FROM  [AN_SUMATRA].[dbo].[TM_AttendanceListing] where [Employee_Code] like '%" & txt_caridata.Text & "%' order by [No]"

            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(search, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_ItemListing.DataSource = RecordSetToDataTable(rs)
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
            If rs.BOF Then
                dgv_ItemListing.DataSource = rs
                dgv_ItemListing.Refresh()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btn_Choose_Click(sender As Object, e As EventArgs) Handles btn_Choose.Click
        Dim i As Integer
        i = Me.dgv_ItemListing.CurrentRow.Index
        With dgv_ItemListing.Rows.Item(i)
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_code.Text = .Cells(0).Value
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_nama.Text = .Cells(1).Value
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_workgroup.Text = .Cells(2).Value
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_Division.Text = .Cells(3).Value
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_department.Text = .Cells(4).Value
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_section.Text = .Cells(5).Value
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_subsection.Text = .Cells(6).Value
        End With
        rs = cn.Execute("SELECT [code],[description] FROM  [AN_SUMATRA].[dbo].[TM_tb_staffclass] ORDER BY [code] ASC")
        If (rs.EOF = False) And (rs.BOF = False) Then
            frm_MasterAttendanceStaffRegistrasiAddNew.cbo_staff.Text = rs(0).Value & " | " & rs(1).Value.ToString
        End If
        Me.Close()
    End Sub

    Private Sub dgv_ItemListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ItemListing.CellDoubleClick
        If dgv_ItemListing.Rows.Count > 0 Then
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_code.Text = dgv_ItemListing("Employee_Code", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_nama.Text = dgv_ItemListing("Employee_Name", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_workgroup.Text = dgv_ItemListing("Workgroup_Code", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_Division.Text = dgv_ItemListing("Division", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_department.Text = dgv_ItemListing("Department", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_section.Text = dgv_ItemListing("Section", e.RowIndex).Value.ToString()
            frm_MasterAttendanceStaffRegistrasiAddNew.txt_subsection.Text = dgv_ItemListing("Subsection", e.RowIndex).Value.ToString()
            rs = cn.Execute("SELECT [code],[description] FROM  [AN_SUMATRA].[dbo].[TM_tb_staffclass] ORDER BY [code] ASC")
            If (rs.EOF = False) And (rs.BOF = False) Then
                frm_MasterAttendanceStaffRegistrasiAddNew.cbo_staff.Text = rs(0).Value & " | " & rs(1).Value.ToString
            End If
        End If
        Me.Close()
    End Sub

    Private Sub frm_MasterAttendanceStaffRegistrasiItemListing_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Height > 300 Then
            pnl1.Height = Me.Height - (pnl1.Top * 2) - 40
            btn_Choose.Top = pnl1.Height - pnl1.Top - btn_Choose.Height - 10
            chk_Maximize.Top = pnl1.Height - pnl1.Top - chk_Maximize.Height - 10
            dgv_ItemListing.Top = 78
            dgv_ItemListing.Height = Me.Height - 180

        End If
        If Me.Width > 420 Then
            pnl1.Width = Me.Width - (pnl1.Left * 2) - 15
            grp_Searchbox.Width = pnl1.Width - (grp_Searchbox.Left * 2) - 5
            btn_Choose.Left = Me.Width - btn_Choose.Width - 30
            dgv_ItemListing.Width = Me.Width - 40

        End If
    End Sub
    Private Sub dgv_ItemListing_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_ItemListing.KeyDown
        Dim i As Integer
        Select Case e.KeyCode
            Case Keys.Enter
                i = Me.dgv_ItemListing.CurrentRow.Index
                With dgv_ItemListing.Rows.Item(i)
                    frm_MasterAttendanceStaffRegistrasiAddNew.txt_code.Text = .Cells(0).Value
                    frm_MasterAttendanceStaffRegistrasiAddNew.txt_nama.Text = .Cells(1).Value
                    frm_MasterAttendanceStaffRegistrasiAddNew.txt_workgroup.Text = .Cells(2).Value
                    frm_MasterAttendanceStaffRegistrasiAddNew.txt_Division.Text = .Cells(3).Value
                    frm_MasterAttendanceStaffRegistrasiAddNew.txt_department.Text = .Cells(4).Value
                    frm_MasterAttendanceStaffRegistrasiAddNew.txt_section.Text = .Cells(5).Value
                    frm_MasterAttendanceStaffRegistrasiAddNew.txt_subsection.Text = .Cells(6).Value
                End With
                rs = cn.Execute("SELECT [code],[description] FROM  [AN_SUMATRA].[dbo].[TM_tb_staffclass] ORDER BY [code] ASC")
                If (rs.EOF = False) And (rs.BOF = False) Then
                    frm_MasterAttendanceStaffRegistrasiAddNew.cbo_staff.Text = rs(0).Value & " | " & rs(1).Value.ToString
                End If
                Me.Close()
        End Select
    End Sub
End Class