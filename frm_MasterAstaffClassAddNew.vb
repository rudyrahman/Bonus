Imports ADODB
Imports System.Data
Imports System.Data.OleDb
Public Class frm_MasterAstaffClassAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Sub autonomor()
        Try
            rs = cn.Execute("Select [Code] from [AN_SUMATRA].[dbo].[TM_tb_staffclass] where Code in (select max(Code) from [AN_SUMATRA].[dbo].[TM_tb_staffclass]) order by id desc")
            Dim Urutan As String
            Dim Hitung As Long
            With rs
                If .EOF Then
                    Urutan = "SC0" + "001"
                    txt_code.Text = Urutan
                Else
                    Hitung = Val(Microsoft.VisualBasic.Strings.Right(rs(0).Value.ToString, 3)) + 1
                    Urutan = "SC0" + Microsoft.VisualBasic.Strings.Right("000" & Hitung, 3)
                End If
                txt_code.Text = Urutan

            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub frm_MasterAstaffClassAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        txt_Code.Enabled = False
        Call autonomor()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class