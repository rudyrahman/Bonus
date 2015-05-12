<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangeDetail
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
        Me.txt_Time = New System.Windows.Forms.TextBox()
        Me.txt_inactived = New System.Windows.Forms.TextBox()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_realname = New System.Windows.Forms.TextBox()
        Me.txt_lastpass = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cbo_username = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txt_Time
        '
        Me.txt_Time.Location = New System.Drawing.Point(124, 243)
        Me.txt_Time.Name = "txt_Time"
        Me.txt_Time.Size = New System.Drawing.Size(243, 20)
        Me.txt_Time.TabIndex = 37
        '
        'txt_inactived
        '
        Me.txt_inactived.Location = New System.Drawing.Point(124, 217)
        Me.txt_inactived.Name = "txt_inactived"
        Me.txt_inactived.Size = New System.Drawing.Size(106, 20)
        Me.txt_inactived.TabIndex = 35
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(124, 190)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(265, 20)
        Me.txt_code.TabIndex = 33
        '
        'txt_realname
        '
        Me.txt_realname.Location = New System.Drawing.Point(124, 166)
        Me.txt_realname.Name = "txt_realname"
        Me.txt_realname.Size = New System.Drawing.Size(265, 20)
        Me.txt_realname.TabIndex = 32
        '
        'txt_lastpass
        '
        Me.txt_lastpass.Location = New System.Drawing.Point(124, 138)
        Me.txt_lastpass.Name = "txt_lastpass"
        Me.txt_lastpass.Size = New System.Drawing.Size(265, 20)
        Me.txt_lastpass.TabIndex = 31
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(124, 113)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(265, 20)
        Me.txt_pass.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Create Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Inactived"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Employee Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Real Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Last Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Username"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(18, 289)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 38
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(124, 289)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 39
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cbo_username
        '
        Me.cbo_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_username.FormattingEnabled = True
        Me.cbo_username.Location = New System.Drawing.Point(124, 84)
        Me.cbo_username.Name = "cbo_username"
        Me.cbo_username.Size = New System.Drawing.Size(265, 21)
        Me.cbo_username.TabIndex = 40
        '
        'frm_ChangeDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 335)
        Me.Controls.Add(Me.cbo_username)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_Time)
        Me.Controls.Add(Me.txt_inactived)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.txt_realname)
        Me.Controls.Add(Me.txt_lastpass)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_ChangeDetail"
        Me.Text = "frm_ChangeDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Time As System.Windows.Forms.TextBox
    Friend WithEvents txt_inactived As System.Windows.Forms.TextBox
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_realname As System.Windows.Forms.TextBox
    Friend WithEvents txt_lastpass As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cbo_username As System.Windows.Forms.ComboBox
End Class
