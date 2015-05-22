Public Class frm_Test01

    Private Sub frm_Test01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_Test01_Resize(Me, Nothing)
    End Sub

    Private Sub frm_Test01_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Height > 500 Then
            pnl_01.Height = Me.Height - (pnl_01.Top * 2) - 40
            btn_Button1.Top = pnl_01.Height - pnl_01.Top - btn_Button1.Height - 10

        End If

        If Me.Width > 400 Then
            pnl_01.Width = Me.Width - (pnl_01.Left * 2) - 15

        End If
    End Sub

    Private Sub btn_Button1_Click(sender As Object, e As EventArgs) Handles btn_Button1.Click

    End Sub
End Class
