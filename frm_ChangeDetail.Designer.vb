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
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_realname = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cbo_id = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_inactived = New System.Windows.Forms.ComboBox()
        Me.txt_inactived = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(124, 149)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(265, 20)
        Me.txt_code.TabIndex = 33
        '
        'txt_realname
        '
        Me.txt_realname.Location = New System.Drawing.Point(124, 127)
        Me.txt_realname.Name = "txt_realname"
        Me.txt_realname.Size = New System.Drawing.Size(265, 20)
        Me.txt_realname.TabIndex = 32
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(124, 105)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(265, 20)
        Me.txt_pass.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Inactived"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Employee Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Real Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Username"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 219)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 38
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(103, 219)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 39
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cbo_id
        '
        Me.cbo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_id.FormattingEnabled = True
        Me.cbo_id.Location = New System.Drawing.Point(124, 59)
        Me.cbo_id.Name = "cbo_id"
        Me.cbo_id.Size = New System.Drawing.Size(265, 21)
        Me.cbo_id.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Id"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(124, 83)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(265, 20)
        Me.txt_username.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 47)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(145, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "CHANGE USER DETAIL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbo_inactived
        '
        Me.cbo_inactived.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_inactived.FormattingEnabled = True
        Me.cbo_inactived.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbo_inactived.Location = New System.Drawing.Point(124, 170)
        Me.cbo_inactived.Name = "cbo_inactived"
        Me.cbo_inactived.Size = New System.Drawing.Size(121, 21)
        Me.cbo_inactived.TabIndex = 44
        '
        'txt_inactived
        '
        Me.txt_inactived.Location = New System.Drawing.Point(251, 171)
        Me.txt_inactived.Name = "txt_inactived"
        Me.txt_inactived.Size = New System.Drawing.Size(39, 20)
        Me.txt_inactived.TabIndex = 45
        '
        'frm_ChangeDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(448, 251)
        Me.Controls.Add(Me.txt_inactived)
        Me.Controls.Add(Me.cbo_inactived)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbo_id)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.txt_realname)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ChangeDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Detail User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_realname As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cbo_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_inactived As System.Windows.Forms.ComboBox
    Friend WithEvents txt_inactived As System.Windows.Forms.TextBox
End Class
