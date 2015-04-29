<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Test01
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Button1 = New System.Windows.Forms.Button()
        Me.pnl_01 = New System.Windows.Forms.Panel()
        Me.pnl_01.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Button1
        '
        Me.btn_Button1.Location = New System.Drawing.Point(8, 519)
        Me.btn_Button1.Name = "btn_Button1"
        Me.btn_Button1.Size = New System.Drawing.Size(131, 27)
        Me.btn_Button1.TabIndex = 0
        Me.btn_Button1.Text = "Button1"
        Me.btn_Button1.UseVisualStyleBackColor = True
        '
        'pnl_01
        '
        Me.pnl_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_01.Controls.Add(Me.btn_Button1)
        Me.pnl_01.Location = New System.Drawing.Point(3, 2)
        Me.pnl_01.Name = "pnl_01"
        Me.pnl_01.Size = New System.Drawing.Size(778, 555)
        Me.pnl_01.TabIndex = 1
        '
        'frm_Test01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.pnl_01)
        Me.Name = "frm_Test01"
        Me.Text = "frm_Test01"
        Me.pnl_01.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Button1 As System.Windows.Forms.Button
    Friend WithEvents pnl_01 As System.Windows.Forms.Panel

End Class
