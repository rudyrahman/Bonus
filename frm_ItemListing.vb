Public Class frm_ItemListing

    Private Sub frm_ItemListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_ItemListing_Resize(Me, Nothing)
    End Sub

    Private Sub frm_ItemListing_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Height > 300 Then
            pnl_Form.Height = Me.Height - (pnl_Form.Top * 2) - 40
            btn_Choose.Top = pnl_Form.Height - pnl_Form.Top - btn_Choose.Height - 10
            chk_Maximize.Top = pnl_Form.Height - pnl_Form.Top - chk_Maximize.Height - 10
            dgv_ItemListing.Top = 78
            dgv_ItemListing.Height = Me.Height - 180

        End If
        If Me.Width > 570 Then
            pnl_Form.Width = Me.Width - (pnl_Form.Left * 2) - 15
            grb_Search.Width = pnl_Form.Width - (grb_Search.Left * 2) - 5
            btn_Choose.Left = Me.Width - btn_Choose.Width - 30
            dgv_ItemListing.Width = Me.Width - 40

        End If
    End Sub
End Class