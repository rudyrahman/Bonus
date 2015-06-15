Imports ADODB
Imports System.Data
Imports System.Data.OleDb

Public Class frm_MasterWorkgroupRelationAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Sub autonomor()
        Try
            rs = cn.Execute("Select [Code] from [AN_SUMATRA].[dbo].[TM_WorkgroupRelation] where Code in (select max(Code) from [AN_SUMATRA].[dbo].[TM_WorkgroupRelation]) order by No desc")
            Dim Urutan As String
            Dim Hitung As Long
            With rs
                If .EOF Then
                    Urutan = "WGR" + "001"
                    txt_code.Text = Urutan
                Else
                    Hitung = Val(Microsoft.VisualBasic.Strings.Right(rs(0).Value.ToString, 3)) + 1
                    Urutan = "WGR" + Microsoft.VisualBasic.Strings.Right("000" & Hitung, 3)
                End If
                txt_code.Text = Urutan

            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub datagrid()
        Try
            Dim sql As String
            rs = New ADODB.Recordset
            sql = "SELECT * FROM  [AN_SUMATRA].[dbo].[TM_WorkgroupRelationAddNew] order by [No]"

            With rs
                .CursorLocation = CursorLocationEnum.adUseClient
                .Open(sql, cn, CursorTypeEnum.adOpenKeyset, _
                      LockTypeEnum.adLockReadOnly)
                .ActiveConnection = Nothing
            End With
            Me.DGV_Workgroup.DataSource = RecordSetToDataTable(rs)
            DGV_Workgroup.Refresh()
            DGV_Workgroup.Columns(0).Width = 40
            DGV_Workgroup.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            DGV_Workgroup.Columns(1).Width = 100
            DGV_Workgroup.Columns(2).Width = 130
            DGV_Workgroup.Columns(3).Width = 50
            DGV_Workgroup.RowsDefaultCellStyle.BackColor = Color.Lavender
            DGV_Workgroup.AlternatingRowsDefaultCellStyle.BackColor = Color.White
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
    Private Sub frm_MasterWorkgroupRelationAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        txt_code.Enabled = False
        Call autonomor()
        txt_desc.Focus()
        Call datagrid()
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        cn.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If txt_desc.Text = "" Then
                MsgBox("The Description is Empty !", MsgBoxStyle.Information)
            Else
                If MessageBox.Show("Apakah Anda yakin akan menyimpan data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    For Each row As DataGridViewRow In DGV_Workgroup.Rows
                        If CType(row.Cells("Check"), DataGridViewCheckBoxCell).Value = True Then
                            Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_WorkgroupRelation]([Code],[Description],[Workgroup_Code],[Create_By],[Create_Time],[System_Id]) values "
                            sqlInsert = sqlInsert & " ('" & txt_code.Text & "','" & txt_desc.Text & "','" & row.Cells(1).Value & "','" & CurrentAccountName & "'," & "GETDATE()" & " " & ",'" & CurrentAccountId & "')"
                            cn.Execute(sqlInsert)
                            Me.Close()
                            ' cn.Close()
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class