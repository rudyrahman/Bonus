<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frm_SystemLock
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Unlock = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_Exit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_Unlock)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_Password)
        Me.GroupBox1.Controls.Add(Me.txt_Username)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 201)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 43)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Exit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_Exit.Location = New System.Drawing.Point(168, 162)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(70, 26)
        Me.btn_Exit.TabIndex = 7
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(90, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(6, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Current User is :"
        '
        'btn_Unlock
        '
        Me.btn_Unlock.BackColor = System.Drawing.Color.Transparent
        Me.btn_Unlock.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_Unlock.Location = New System.Drawing.Point(93, 162)
        Me.btn_Unlock.Name = "btn_Unlock"
        Me.btn_Unlock.Size = New System.Drawing.Size(70, 26)
        Me.btn_Unlock.TabIndex = 6
        Me.btn_Unlock.Text = "Unlock"
        Me.btn_Unlock.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(209, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 20)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<>"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_Password.Location = New System.Drawing.Point(93, 113)
        Me.txt_Password.MaxLength = 50
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.Size = New System.Drawing.Size(110, 20)
        Me.txt_Password.TabIndex = 12
        '
        'txt_Username
        '
        Me.txt_Username.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_Username.Location = New System.Drawing.Point(93, 87)
        Me.txt_Username.MaxLength = 50
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(110, 20)
        Me.txt_Username.TabIndex = 10
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.PasswordLabel.Location = New System.Drawing.Point(6, 109)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(68, 23)
        Me.PasswordLabel.TabIndex = 11
        Me.PasswordLabel.Text = "&Password :"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.UsernameLabel.Location = New System.Drawing.Point(6, 83)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(68, 23)
        Me.UsernameLabel.TabIndex = 9
        Me.UsernameLabel.Text = "&User name :"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(93, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "CAN UNLOCK THIS SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ONLY CURRENT USER OR USER WITH HIGH LEVEL PRIORITY"
        '
        'frm_SystemLock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(347, 228)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SystemLock"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SYSTEM LOCK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_Unlock As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
