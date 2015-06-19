Imports ADODB
Imports System.Data.OleDb
Public Class frm_ItemListing
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim itemlisting As String
    Dim search As String

    Private Sub frm_ItemListing_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            If (dgv_ItemListing.Rows.Count > 0) Then
                dgv_ItemListing.Rows(0).Selected = True
            End If
            rs = New ADODB.Recordset
            itemlisting = "SELECT [Code],[Name],[Tag] FROM  [AN_SUMATRA].[dbo].[TM_tb_itemlisting] order by [id]"

            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(itemlisting, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_ItemListing.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()
            dgv_ItemListing.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frm_ItemListing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub frm_ItemListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgv_ItemListing.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            If Me.WindowState = FormWindowState.Maximized = True And chk_Maximize.Checked = False Then
                Me.WindowState = FormWindowState.Normal
            End If
            If chk_Maximize.Checked = True Then
                Me.WindowState = FormWindowState.Maximized
            End If

            frm_ItemListing_Resize(Me, Nothing)
            txt_CariData.Focus()
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = New ADODB.Recordset
            itemlisting = "SELECT [Code],[Name],[Tag] FROM  [AN_SUMATRA].[dbo].[TM_tb_itemlisting] order by [code]"

            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(itemlisting, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_ItemListing.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()
            dgv_ItemListing.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub tampilgrid()
        dgv_ItemListing.Columns(0).Width = 100
        dgv_ItemListing.Columns(1).Width = 100
        dgv_ItemListing.Columns(2).Width = 150
        dgv_ItemListing.RowTemplate.Height = 17
        dgv_ItemListing.RowsDefaultCellStyle.BackColor = Color.Lavender
        dgv_ItemListing.AlternatingRowsDefaultCellStyle.BackColor = Color.White
      
        'dgv_ItemListing.Rows(dgv_ItemListing.Rows.Count - 1).Selected = True
    End Sub
    Public Function RecordSetToDataTable( _
           ByVal objRS As ADODB.Recordset) As DataTable

        Dim objDA As New OleDbDataAdapter()
        Dim objDT As New DataTable()
        objDA.Fill(objDT, objRS)
        Return objDT

    End Function

    Private Sub frm_ItemListing_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        
        If Me.Height > 300 Then
            pnl_Form.Height = Me.Height - (pnl_Form.Top * 2) - 40
            btn_Choose.Top = pnl_Form.Height - pnl_Form.Top - btn_Choose.Height - 10
            chk_Maximize.Top = pnl_Form.Height - pnl_Form.Top - chk_Maximize.Height - 10
            dgv_ItemListing.Top = 78
            dgv_ItemListing.Height = Me.Height - 180

        End If
        If Me.Width > 420 Then
            pnl_Form.Width = Me.Width - (pnl_Form.Left * 2) - 15
            grb_Search.Width = pnl_Form.Width - (grb_Search.Left * 2) - 5
            btn_Choose.Left = Me.Width - btn_Choose.Width - 30
            dgv_ItemListing.Width = Me.Width - 40

        End If
    End Sub

    Private Sub txt_CariData_TextChanged(sender As Object, e As EventArgs) Handles txt_CariData.TextChanged
        Try
            rs = New ADODB.Recordset
            search = "SELECT [Code],[Name],[Tag] FROM  [AN_SUMATRA].[dbo].[TM_tb_itemlisting] where [Code] like '%" & txt_CariData.Text & "%' order by [id]"
            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(search, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_ItemListing.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()
            If rs.BOF Then
                dgv_ItemListing.DataSource = rs
                dgv_ItemListing.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Try
            rs = New ADODB.Recordset
            search = "SELECT [Code],[Name],[Tag] FROM  [AN_SUMATRA].[dbo].[TM_tb_itemlisting] where [Code] like '%" & txt_CariData.Text & "%' order by [id]"
            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(search, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.dgv_ItemListing.DataSource = RecordSetToDataTable(rs)
            Call tampilgrid()
            If rs.BOF Then
                dgv_ItemListing.DataSource = rs
                dgv_ItemListing.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgv_ItemListing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ItemListing.CellContentClick

    End Sub

    Private Sub dgv_ItemListing_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ItemListing.CellContentDoubleClick
        If (dgv_ItemListing.Rows.Count > 0) Then
            frm_MasterEStatusArragementAddNew.txt_code.Text = dgv_ItemListing("code", e.RowIndex).Value.ToString()
            frm_MasterEStatusArragementAddNew.txt_Name.Text = dgv_ItemListing("name", e.RowIndex).Value.ToString()
        End If
        Me.Close()
    End Sub

    Private Sub dgv_ItemListing_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_ItemListing.KeyDown
        Dim i As Integer
        Select Case e.KeyCode
            Case Keys.Enter
                i = Me.dgv_ItemListing.CurrentRow.Index
                With dgv_ItemListing.Rows.Item(i)
                    frm_MasterEStatusArragementAddNew.txt_code.Text = .Cells(0).Value
                    frm_MasterEStatusArragementAddNew.txt_Name.Text = .Cells(1).Value
                End With
                Me.Close()
        End Select
    End Sub

    Private Sub dgv_ItemListing_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_ItemListing.SelectionChanged
        'frm_MasterEStatusArragementAddNew.txt_code.Text = dgv_ItemListing.Rows(0).item("code").

    End Sub

    Private Sub btn_Choose_Click(sender As Object, e As EventArgs) Handles btn_Choose.Click
        Dim i As Integer
        i = Me.dgv_ItemListing.CurrentRow.Index
        With dgv_ItemListing.Rows.Item(i)
            frm_MasterEStatusArragementAddNew.txt_code.Text = .Cells(0).Value
            frm_MasterEStatusArragementAddNew.txt_Name.Text = .Cells(1).Value
        End With
        Me.Close()
    End Sub

    Private Sub pnl_Form_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Form.Paint
        'dgv_ItemListing.Rows(0).Selected = True
    End Sub

    Private Sub chk_Maximize_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Maximize.CheckedChanged

    End Sub
End Class