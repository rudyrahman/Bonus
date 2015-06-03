<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addyear
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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.DTP_To = New System.Windows.Forms.DateTimePicker()
        Me.DTP_From = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.DTP_To)
        Me.pnl1.Controls.Add(Me.DTP_From)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.txt_desc)
        Me.pnl1.Controls.Add(Me.txt_code)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Controls.Add(Me.Label1)
        Me.pnl1.Location = New System.Drawing.Point(5, 2)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(583, 182)
        Me.pnl1.TabIndex = 1
        '
        'DTP_To
        '
        Me.DTP_To.Location = New System.Drawing.Point(103, 121)
        Me.DTP_To.Name = "DTP_To"
        Me.DTP_To.Size = New System.Drawing.Size(200, 20)
        Me.DTP_To.TabIndex = 9
        '
        'DTP_From
        '
        Me.DTP_From.Location = New System.Drawing.Point(103, 95)
        Me.DTP_From.Name = "DTP_From"
        Me.DTP_From.Size = New System.Drawing.Size(200, 20)
        Me.DTP_From.TabIndex = 8
        Me.DTP_From.Value = New Date(2015, 5, 27, 9, 20, 9, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Date From:"
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(103, 37)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(443, 20)
        Me.txt_desc.TabIndex = 5
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(103, 11)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(190, 20)
        Me.txt_code.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Code:"
        '
        'pnl2
        '
        Me.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl2.Controls.Add(Me.btn_addnew)
        Me.pnl2.Controls.Add(Me.btn_cancel)
        Me.pnl2.Location = New System.Drawing.Point(5, 190)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(583, 55)
        Me.pnl2.TabIndex = 2
        '
        'btn_addnew
        '
        Me.btn_addnew.Location = New System.Drawing.Point(360, 20)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(105, 23)
        Me.btn_addnew.TabIndex = 1
        Me.btn_addnew.Text = "Add New"
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(471, 20)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(102, 23)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'frm_addyear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 251)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_addyear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New"
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents DTP_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents btn_addnew As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
End Class
