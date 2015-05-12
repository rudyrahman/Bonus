<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangePassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_ulangipass = New System.Windows.Forms.TextBox()
        Me.txt_passbaru = New System.Windows.Forms.TextBox()
        Me.txt_passlama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 47)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GANTI PASSWORD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(101, 144)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 33
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(10, 144)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 32
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_ulangipass
        '
        Me.txt_ulangipass.Location = New System.Drawing.Point(117, 103)
        Me.txt_ulangipass.MaxLength = 50
        Me.txt_ulangipass.Name = "txt_ulangipass"
        Me.txt_ulangipass.Size = New System.Drawing.Size(146, 20)
        Me.txt_ulangipass.TabIndex = 31
        '
        'txt_passbaru
        '
        Me.txt_passbaru.Location = New System.Drawing.Point(117, 79)
        Me.txt_passbaru.MaxLength = 50
        Me.txt_passbaru.Name = "txt_passbaru"
        Me.txt_passbaru.Size = New System.Drawing.Size(146, 20)
        Me.txt_passbaru.TabIndex = 30
        '
        'txt_passlama
        '
        Me.txt_passlama.Location = New System.Drawing.Point(117, 54)
        Me.txt_passlama.MaxLength = 50
        Me.txt_passlama.Name = "txt_passlama"
        Me.txt_passlama.Size = New System.Drawing.Size(146, 20)
        Me.txt_passlama.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Ulangi Password Baru"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Password Baru"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-1, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Password Lama"
        '
        'frm_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 180)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_ulangipass)
        Me.Controls.Add(Me.txt_passbaru)
        Me.Controls.Add(Me.txt_passlama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ChangePassword"
        Me.Text = "Change Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_ulangipass As System.Windows.Forms.TextBox
    Friend WithEvents txt_passbaru As System.Windows.Forms.TextBox
    Friend WithEvents txt_passlama As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
