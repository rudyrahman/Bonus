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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UserManagement))
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
        Me.grp_2 = New System.Windows.Forms.GroupBox()
        Me.cek_Exit = New System.Windows.Forms.CheckBox()
        Me.cek_LogOut = New System.Windows.Forms.CheckBox()
        Me.cek_LogApplication = New System.Windows.Forms.CheckBox()
        Me.grp_3 = New System.Windows.Forms.GroupBox()
        Me.cek_UserManagement = New System.Windows.Forms.CheckBox()
        Me.cek_RemoveUser = New System.Windows.Forms.CheckBox()
        Me.cek_ChangeUserDetails = New System.Windows.Forms.CheckBox()
        Me.cek_AddNewUser = New System.Windows.Forms.CheckBox()
        Me.cek_ChangeMyPassword = New System.Windows.Forms.CheckBox()
        Me.grp_1 = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Pic_Lock = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_userm = New System.Windows.Forms.Label()
        Me.grp_2.SuspendLayout()
        Me.grp_3.SuspendLayout()
        Me.grp_1.SuspendLayout()
        CType(Me.Pic_Lock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username :"
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(275, 85)
        Me.txt_Name.MaxLength = 200
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(261, 20)
        Me.txt_Name.TabIndex = 5
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(275, 111)
        Me.txt_Id.MaxLength = 11
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(80, 20)
        Me.txt_Id.TabIndex = 6
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(275, 137)
        Me.txt_Username.MaxLength = 50
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(166, 20)
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
        Me.cbo_Username.Location = New System.Drawing.Point(275, 56)
        Me.cbo_Username.Name = "cbo_Username"
        Me.cbo_Username.Size = New System.Drawing.Size(193, 21)
        Me.cbo_Username.TabIndex = 22
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(17, 3)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(55, 23)
        Me.btn_Save.TabIndex = 23
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'grp_2
        '
        Me.grp_2.Controls.Add(Me.cek_Exit)
        Me.grp_2.Controls.Add(Me.cek_LogOut)
        Me.grp_2.Controls.Add(Me.cek_LogApplication)
        Me.grp_2.Location = New System.Drawing.Point(139, 212)
        Me.grp_2.Name = "grp_2"
        Me.grp_2.Size = New System.Drawing.Size(103, 100)
        Me.grp_2.TabIndex = 24
        Me.grp_2.TabStop = False
        Me.grp_2.Text = "File"
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
        'grp_3
        '
        Me.grp_3.Controls.Add(Me.cek_UserManagement)
        Me.grp_3.Controls.Add(Me.cek_RemoveUser)
        Me.grp_3.Controls.Add(Me.cek_ChangeUserDetails)
        Me.grp_3.Controls.Add(Me.cek_AddNewUser)
        Me.grp_3.Controls.Add(Me.cek_ChangeMyPassword)
        Me.grp_3.Location = New System.Drawing.Point(246, 210)
        Me.grp_3.Name = "grp_3"
        Me.grp_3.Size = New System.Drawing.Size(141, 139)
        Me.grp_3.TabIndex = 25
        Me.grp_3.TabStop = False
        Me.grp_3.Tag = ""
        Me.grp_3.Text = "System Control"
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
        'grp_1
        '
        Me.grp_1.Controls.Add(Me.cek_OfficeModules)
        Me.grp_1.Controls.Add(Me.cek_File)
        Me.grp_1.Controls.Add(Me.cek_SystemControl)
        Me.grp_1.Location = New System.Drawing.Point(11, 212)
        Me.grp_1.Name = "grp_1"
        Me.grp_1.Size = New System.Drawing.Size(124, 108)
        Me.grp_1.TabIndex = 26
        Me.grp_1.TabStop = False
        Me.grp_1.Text = "Select Access"
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(78, 3)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(55, 23)
        Me.btn_clear.TabIndex = 28
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Pic_Lock
        '
        Me.Pic_Lock.BackColor = System.Drawing.SystemColors.Control
        Me.Pic_Lock.BackgroundImage = CType(resources.GetObject("Pic_Lock.BackgroundImage"), System.Drawing.Image)
        Me.Pic_Lock.Location = New System.Drawing.Point(546, 84)
        Me.Pic_Lock.Name = "Pic_Lock"
        Me.Pic_Lock.Size = New System.Drawing.Size(24, 20)
        Me.Pic_Lock.TabIndex = 29
        Me.Pic_Lock.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 101)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 27)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_clear)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Location = New System.Drawing.Point(0, 392)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(591, 30)
        Me.Panel2.TabIndex = 32
        '
        'lbl_userm
        '
        Me.lbl_userm.AutoSize = True
        Me.lbl_userm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_userm.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_userm.Location = New System.Drawing.Point(387, 234)
        Me.lbl_userm.Name = "lbl_userm"
        Me.lbl_userm.Size = New System.Drawing.Size(304, 41)
        Me.lbl_userm.TabIndex = 33
        Me.lbl_userm.Text = "User Management"
        '
        'frm_UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 422)
        Me.Controls.Add(Me.lbl_userm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pic_Lock)
        Me.Controls.Add(Me.grp_1)
        Me.Controls.Add(Me.grp_3)
        Me.Controls.Add(Me.grp_2)
        Me.Controls.Add(Me.cbo_Username)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_UserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_UserManagement"
        Me.grp_2.ResumeLayout(False)
        Me.grp_2.PerformLayout()
        Me.grp_3.ResumeLayout(False)
        Me.grp_3.PerformLayout()
        Me.grp_1.ResumeLayout(False)
        Me.grp_1.PerformLayout()
        CType(Me.Pic_Lock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
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
    Friend WithEvents grp_2 As System.Windows.Forms.GroupBox
    Friend WithEvents cek_Exit As System.Windows.Forms.CheckBox
    Friend WithEvents cek_LogOut As System.Windows.Forms.CheckBox
    Friend WithEvents cek_LogApplication As System.Windows.Forms.CheckBox
    Friend WithEvents grp_3 As System.Windows.Forms.GroupBox
    Friend WithEvents cek_UserManagement As System.Windows.Forms.CheckBox
    Friend WithEvents cek_RemoveUser As System.Windows.Forms.CheckBox
    Friend WithEvents cek_ChangeUserDetails As System.Windows.Forms.CheckBox
    Friend WithEvents cek_AddNewUser As System.Windows.Forms.CheckBox
    Friend WithEvents cek_ChangeMyPassword As System.Windows.Forms.CheckBox
    Friend WithEvents grp_1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents Pic_Lock As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_userm As System.Windows.Forms.Label
End Class
