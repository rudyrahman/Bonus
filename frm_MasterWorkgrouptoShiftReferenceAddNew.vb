Imports ADODB
Imports System.Data
Imports System.Data.OleDb
Public Class frm_MasterWorkgrouptoShiftReferenceAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_MasterWorkgrouptoShiftReferenceAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()

        rs = cn.Execute("SELECT distinct [Workgroup] FROM [AN_SUMATRA].[dbo].[TM_Shift] ORDER BY [Workgroup] ASC")
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
        sql = "SELECT [No],[Shift_Code],[Shift_Desc] FROM [AN_SUMATRA].[dbo].[TM_Shift] ORDER BY [Workgroup] ASC"

        With rs
            .CursorLocation = CursorLocationEnum.adUseClient
            .Open(sql, cn, CursorTypeEnum.adOpenKeyset, _
                  LockTypeEnum.adLockReadOnly)
            .ActiveConnection = Nothing
        End With

        If (rs.EOF = False) And (rs.BOF = False) Then
            Me.DGV.DataSource = RecordSetToDataTable(rs)
            'txt_username.Text = rs(1).Value.ToString
            cbo_workgroup.Refresh()
        Else
            'txt_username.Text = ""
        End If
    End Sub
    Public Function RecordSetToDataTable( _
             ByVal objRS As ADODB.Recordset) As DataTable

        Dim objDA As New OleDbDataAdapter()
        Dim objDT As New DataTable()
        objDA.Fill(objDT, objRS)
        Return objDT

    End Function
End Class