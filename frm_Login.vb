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
                MsgBox("Silahkan isi Username dan Password", vbInformation, "Login")
            Else
                rs = cn.Execute("SELECT [id] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & txt_username.Text & "'")
                CurrentAccountId = rs(0).Value
                CurrentAccountName = txt_username.Text
                rs = cn.Execute("SELECT [priority] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & txt_username.Text & "'")
                CurrentAccountPriority = rs(0).Value

                rs = New ADODB.Recordset
                rs.Open("SELECT [id], [priority] FROM [AN_SUMATRA].[dbo].[SY_tb_appsaccounts] WHERE [username]='" & txt_username.Text & "' and [password]='" & txt_password.Text & "'", cn, CursorTypeEnum.adOpenKeyset)
                If Not rs.EOF Then
                    MsgBox("Selamat Anda Berhasil Login", vbInformation, "Pemberitahuan")
                    Me.Close()
                    cn.Close()
                Else
                    MsgBox("Maaf User atau password salah", vbExclamation, "Pemberitahuan")
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