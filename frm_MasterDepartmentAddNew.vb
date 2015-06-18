﻿Imports ADODB
Public Class frm_MasterDepartmentAddNew
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    'Dim d As New ADODB.Recordset
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
        cn.Close()
    End Sub

    Private Sub frm_MasterDepartmentAddNew_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
    Private Sub frm_MasterDepartmentAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbo_DevisionCode.Text = ""
            txt_DevisionDescription.Text = ""
            txt_DepartmentCode.Text = ""
            txt_DepartmentDescription.Text = ""

            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()
            rs = cn.Execute("SELECT [division_code] FROM  [AN_SUMATRA].[dbo].[TM_tb_devision] ORDER BY [division_code] ")
            If rs.EOF = False Then
                cbo_DevisionCode.Items.Clear()
                While Not rs.EOF
                    cbo_DevisionCode.Items.Add(rs(0).Value)
                    rs.MoveNext()
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        cbo_DevisionCode.Focus()
    End Sub

    Private Sub cbo_DevisionCode_MouseClick(sender As Object, e As MouseEventArgs) Handles cbo_DevisionCode.MouseClick

    End Sub

    Private Sub cbo_DevisionCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_DevisionCode.SelectedIndexChanged
        Try
            'Dim Urutan As String
            'Dim Hitung As Long

            rs = cn.Execute("SELECT [division_code],[division_description] FROM [AN_SUMATRA].[dbo].[TM_tb_devision] WHERE [division_code]='" & cbo_DevisionCode.Text & "' ORDER BY [division_code] ASC")
            If rs.EOF = False Then
                txt_DevisionDescription.Text = rs(1).Value.ToString
                'Urutan = rs(0).Value.ToString + " 01"
                'txt_DepartmentCode.Text = Urutan

                'd = cn.Execute("Select [department_code] from [AN_SUMATRA].[dbo].[TM_tb_department] order by id desc")


                'If cbo_DevisionCode.Text = "DWH" Then
                'Hitung = Val(Microsoft.VisualBasic.Strings.Right(d(0).Value.ToString, 3)) + 1
                'Urutan = rs(0).Value.ToString + Microsoft.VisualBasic.Strings.Right(" 0" & Hitung, 3)
                'End If
                'txt_DepartmentCode.Text = Urutan

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_AddNew_Click(sender As Object, e As EventArgs) Handles btn_AddNew.Click
        Try
            If cbo_DevisionCode.Text = "" Or txt_DevisionDescription.Text = "" Or txt_DepartmentCode.Text = "" Or txt_DepartmentDescription.Text = "" Then
                MsgBox(udv_msg_LoginBlank, vbInformation)
            Else
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_tb_department] ([division_code],[division_description],[department_code],[department_description],[create_by],[create_time],[system_id],[inactive]) VALUES "
                sqlInsert = sqlInsert & " ('" & cbo_DevisionCode.Text.ToString & "'" & _
                     ",'" & txt_DevisionDescription.Text & "'" & _
                     ",'" & txt_DepartmentCode.Text & "'" & _
                      ",'" & txt_DepartmentDescription.Text & "'" & _
                     ",'" & CurrentAccountName & "'" & _
                     "," & "GETDATE()" & " " & "" & _
                    ",'" & CurrentAccountId & "'" & _
                    ",'N')"
                cn.Execute(sqlInsert)
                cbo_DevisionCode.Items.Clear()
                txt_DevisionDescription.Text = ""
                txt_DepartmentCode.Text = ""
                txt_DepartmentDescription.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

 
End Class