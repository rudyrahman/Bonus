﻿Imports ADODB

Public Class frm_login
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MinimizeBox = False
            Me.MaximizeBox = False
            txt_password.PasswordChar = "*"
            cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
            cn.Open()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        txt_password.PasswordChar = ""
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        txt_password.PasswordChar = "*"
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If txt_username.Text = "" Or txt_password.Text = "" Then
                MsgBox("Silahkan isi Username dan Password", vbInformation, "Login")
            Else
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & txt_username.Text & "' and [password]='" & txt_password.Text & "'", cn, CursorTypeEnum.adOpenKeyset)
                If Not rs.EOF Then
                    MsgBox("Selamat Anda Berhasil Login", vbInformation, "Pemberitahuan")
                    Me.Close()
                    cn.Close()
                Else
                    MsgBox("Maaf User atau password salah", vbInformation, "Pemberitahuan")
                    txt_username.Text = ""
                    txt_password.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class