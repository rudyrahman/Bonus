Imports ADODB
Public Class frm_login
    Dim cn As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MinimumSize = New Size(431, 324)
            Me.MaximumSize = New Size(431, 324)
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
                MsgBox(udv_msg_LoginBlank, vbInformation)
            Else
                rs = cn.Execute("SELECT [id], [priority] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & txt_username.Text & "' and [password]='" & txt_password.Text & "'", CursorTypeEnum.adOpenKeyset)
                If Not rs.EOF Then
                    rs = cn.Execute("SELECT [id],[username],[priority] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & txt_username.Text & "'")
                    CurrentAccountId = rs(0).Value
                    CurrentAccountName = rs(1).Value
                    CurrentAccountPriority = rs(2).Value

                    Me.Close()
                    cn.Close()
                Else
                    MsgBox(udv_msg_LoginNotAccepted, vbExclamation)
                    txt_username.Text = ""
                    txt_password.Text = ""
                    txt_username.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub txt_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_username.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_password.Focus()
        End If
    End Sub

    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_login.Focus()
        End If
    End Sub
End Class