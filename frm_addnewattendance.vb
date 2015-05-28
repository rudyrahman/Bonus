Imports ADODB
Public Class frm_addnewattendance
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_addnewattendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        Call AutoNumber()
        txt_code.Enabled = False
    End Sub
    Sub AutoNumber()
        rs = cn.Execute("Select * from [AN_SUMATRA].[dbo].[TM_Number] where code in (select max(code) from [AN_SUMATRA].[dbo].[TM_Number]) order by code desc")
        Dim Urut As String
        Dim Hitung As Long
        If (rs.EOF = False) And (rs.BOF = False) Then
            Urut = "00"
            Hitung = Val(Microsoft.VisualBasic.Strings.Right(rs(0).Value.ToString, 2)) + 1
            Urut = Format(Hitung, "00")
            txt_code.Text = Urut
        End If
    End Sub
    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        If txt_desc.Text = "" Then
            MsgBox("Input the description !", MsgBoxStyle.Information)
        Else
            If MessageBox.Show("Apakah Anda yakin akan menyimpan data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_Number]([code],[description]) values "
                sqlInsert = sqlInsert & " ('" & txt_code.Text & "','" & txt_desc.Text & "')"
                cn.Execute(sqlInsert)
                txt_code.Text = ""
                txt_desc.Text = ""
                cn.Close()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()

    End Sub
End Class