<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UserManagement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.cek_File = New System.Windows.Forms.CheckBox()
        Me.cek_SystemControl = New System.Windows.Forms.CheckBox()
        Me.cek_OfficeModules = New System.Windows.Forms.CheckBox()
        Me.cbo_Username = New System.Windows.Forms.ComboBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cek_Exit = New System.Windows.Forms.CheckBox()
        Me.cek_LogOut = New System.Windows.Forms.CheckBox()
        Me.cek_LogApplication = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cek_UserManagement = New System.Windows.Forms.CheckBox()
        Me.cek_RemoveUser = New System.Windows.Forms.CheckBox()
        Me.cek_ChangeUserDetails = New System.Windows.Forms.CheckBox()
        Me.cek_AddNewUser = New System.Windows.Forms.CheckBox()
        Me.cek_ChangeMyPassword = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_Locked = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username"
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(105, 46)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(100, 20)
        Me.txt_Name.TabIndex = 5
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(105, 80)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(100, 20)
        Me.txt_Id.TabIndex = 6
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(105, 114)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(100, 20)
        Me.txt_Username.TabIndex = 7
        '
        'cek_File
        '
        Me.cek_File.AutoSize = True
        Me.cek_File.Location = New System.Drawing.Point(21, 18)
        Me.cek_File.Name = "cek_File"
        Me.cek_File.Size = New System.Drawing.Size(42, 17)
        Me.cek_File.TabIndex = 8
        Me.cek_File.Text = "File"
        Me.cek_File.UseVisualStyleBackColor = True
        '
        'cek_SystemControl
        '
        Me.cek_SystemControl.AutoSize = True
        Me.cek_SystemControl.Location = New System.Drawing.Point(21, 42)
        Me.cek_SystemControl.Name = "cek_SystemControl"
        Me.cek_SystemControl.Size = New System.Drawing.Size(96, 17)
        Me.cek_SystemControl.TabIndex = 9
        Me.cek_SystemControl.Text = "System Control"
        Me.cek_SystemControl.UseVisualStyleBackColor = True
        '
        'cek_OfficeModules
        '
        Me.cek_OfficeModules.AutoSize = True
        Me.cek_OfficeModules.Location = New System.Drawing.Point(21, 66)
        Me.cek_OfficeModules.Name = "cek_OfficeModules"
        Me.cek_OfficeModules.Size = New System.Drawing.Size(97, 17)
        Me.cek_OfficeModules.TabIndex = 10
        Me.cek_OfficeModules.Text = "Office Modules"
        Me.cek_OfficeModules.UseVisualStyleBackColor = True
        '
        'cbo_Username
        '
        Me.cbo_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Username.FormattingEnabled = True
        Me.cbo_Username.Location = New System.Drawing.Point(105, 13)
        Me.cbo_Username.Name = "cbo_Username"
        Me.cbo_Username.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Username.TabIndex = 22
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(25, 336)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(55, 23)
        Me.btn_Save.TabIndex = 23
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cek_Exit)
        Me.GroupBox1.Controls.Add(Me.cek_LogOut)
        Me.GroupBox1.Controls.Add(Me.cek_LogApplication)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 100)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'cek_Exit
        '
        Me.cek_Exit.AutoSize = True
        Me.cek_Exit.Location = New System.Drawing.Point(2, 66)
        Me.cek_Exit.Name = "cek_Exit"
        Me.cek_Exit.Size = New System.Drawing.Size(43, 17)
        Me.cek_Exit.TabIndex = 19
        Me.cek_Exit.Text = "Exit"
        Me.cek_Exit.UseVisualStyleBackColor = True
        '
        'cek_LogOut
        '
        Me.cek_LogOut.AutoSize = True
        Me.cek_LogOut.Location = New System.Drawing.Point(2, 42)
        Me.cek_LogOut.Name = "cek_LogOut"
        Me.cek_LogOut.Size = New System.Drawing.Size(64, 17)
        Me.cek_LogOut.TabIndex = 18
        Me.cek_LogOut.Text = "Log Out"
        Me.cek_LogOut.UseVisualStyleBackColor = True
        '
        'cek_LogApplication
        '
        Me.cek_LogApplication.AutoSize = True
        Me.cek_LogApplication.Location = New System.Drawing.Point(2, 18)
        Me.cek_LogApplication.Name = "cek_LogApplication"
        Me.cek_LogApplication.Size = New System.Drawing.Size(99, 17)
        Me.cek_LogApplication.TabIndex = 17
        Me.cek_LogApplication.Text = "Log Application"
        Me.cek_LogApplication.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cek_UserManagement)
        Me.GroupBox2.Controls.Add(Me.cek_RemoveUser)
        Me.GroupBox2.Controls.Add(Me.cek_ChangeUserDetails)
        Me.GroupBox2.Controls.Add(Me.cek_AddNewUser)
        Me.GroupBox2.Controls.Add(Me.cek_ChangeMyPassword)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(141, 139)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'cek_UserManagement
        '
        Me.cek_UserManagement.AutoSize = True
        Me.cek_UserManagement.Location = New System.Drawing.Point(6, 114)
        Me.cek_UserManagement.Name = "cek_UserManagement"
        Me.cek_UserManagement.Size = New System.Drawing.Size(113, 17)
        Me.cek_UserManagement.TabIndex = 25
        Me.cek_UserManagement.Text = "User Management"
        Me.cek_UserManagement.UseVisualStyleBackColor = True
        '
        'cek_RemoveUser
        '
        Me.cek_RemoveUser.AutoSize = True
        Me.cek_RemoveUser.Location = New System.Drawing.Point(6, 91)
        Me.cek_RemoveUser.Name = "cek_RemoveUser"
        Me.cek_RemoveUser.Size = New System.Drawing.Size(91, 17)
        Me.cek_RemoveUser.TabIndex = 24
        Me.cek_RemoveUser.Text = "Remove User"
        Me.cek_RemoveUser.UseVisualStyleBackColor = True
        '
        'cek_ChangeUserDetails
        '
        Me.cek_ChangeUserDetails.AutoSize = True
        Me.cek_ChangeUserDetails.Location = New System.Drawing.Point(6, 68)
        Me.cek_ChangeUserDetails.Name = "cek_ChangeUserDetails"
        Me.cek_ChangeUserDetails.Size = New System.Drawing.Size(123, 17)
        Me.cek_ChangeUserDetails.TabIndex = 23
        Me.cek_ChangeUserDetails.Text = "Change User Details"
        Me.cek_ChangeUserDetails.UseVisualStyleBackColor = True
        '
        'cek_AddNewUser
        '
        Me.cek_AddNewUser.AutoSize = True
        Me.cek_AddNewUser.Location = New System.Drawing.Point(6, 44)
        Me.cek_AddNewUser.Name = "cek_AddNewUser"
        Me.cek_AddNewUser.Size = New System.Drawing.Size(95, 17)
        Me.cek_AddNewUser.TabIndex = 22
        Me.cek_AddNewUser.Text = "Add New User"
        Me.cek_AddNewUser.UseVisualStyleBackColor = True
        '
        'cek_ChangeMyPassword
        '
        Me.cek_ChangeMyPassword.AutoSize = True
        Me.cek_ChangeMyPassword.Location = New System.Drawing.Point(6, 20)
        Me.cek_ChangeMyPassword.Name = "cek_ChangeMyPassword"
        Me.cek_ChangeMyPassword.Size = New System.Drawing.Size(129, 17)
        Me.cek_ChangeMyPassword.TabIndex = 21
        Me.cek_ChangeMyPassword.Text = "Change My Password"
        Me.cek_ChangeMyPassword.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cek_OfficeModules)
        Me.GroupBox3.Controls.Add(Me.cek_File)
        Me.GroupBox3.Controls.Add(Me.cek_SystemControl)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 108)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'lbl_Locked
        '
        Me.lbl_Locked.AutoSize = True
        Me.lbl_Locked.Location = New System.Drawing.Point(205, 48)
        Me.lbl_Locked.Name = "lbl_Locked"
        Me.lbl_Locked.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Locked.TabIndex = 27
        Me.lbl_Locked.Text = "Locked"
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(86, 336)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(55, 23)
        Me.btn_clear.TabIndex = 28
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frm_UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 371)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.lbl_Locked)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.cbo_Username)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_UserManagement"
        Me.Text = "frm_UserManagement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents cek_File As System.Windows.Forms.CheckBox
    Friend WithEvents cek_SystemControl As System.Windows.Forms.CheckBox
    Friend WithEvents cek_OfficeModules As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_Username As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cek_Exit As System.Windows.Forms.CheckBox
    Friend WithEvents cek_LogOut As System.Windows.Forms.CheckBox
    Friend WithEvents cek_LogApplication As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cek_UserManagement As System.Windows.Forms.CheckBox
    Friend WithEvents cek_RemoveUser As System.Windows.Forms.CheckBox
    Friend WithEvents cek_ChangeUserDetails As System.Windows.Forms.CheckBox
    Friend WithEvents cek_AddNewUser As System.Windows.Forms.CheckBox
    Friend WithEvents cek_ChangeMyPassword As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Locked As System.Windows.Forms.Label
    Friend WithEvents btn_clear As System.Windows.Forms.Button
End Class
