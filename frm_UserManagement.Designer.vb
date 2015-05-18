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
        Me.cbo_Username = New System.Windows.Forms.ComboBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Pic_Lock = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_userm = New System.Windows.Forms.Label()
        Me.chk_SystemControl = New System.Windows.Forms.CheckedListBox()
        Me.chk_file = New System.Windows.Forms.CheckedListBox()
        Me.chk_Menu = New System.Windows.Forms.CheckedListBox()
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
        'chk_SystemControl
        '
        Me.chk_SystemControl.FormattingEnabled = True
        Me.chk_SystemControl.Items.AddRange(New Object() {"Change My Password", "Add New User", "Change User Details", "Remove User", "User Management"})
        Me.chk_SystemControl.Location = New System.Drawing.Point(280, 234)
        Me.chk_SystemControl.Name = "chk_SystemControl"
        Me.chk_SystemControl.Size = New System.Drawing.Size(128, 94)
        Me.chk_SystemControl.TabIndex = 36
        '
        'chk_file
        '
        Me.chk_file.FormattingEnabled = True
        Me.chk_file.Items.AddRange(New Object() {"Log Application", "Log Out", "Exit"})
        Me.chk_file.Location = New System.Drawing.Point(154, 234)
        Me.chk_file.Name = "chk_file"
        Me.chk_file.Size = New System.Drawing.Size(120, 94)
        Me.chk_file.TabIndex = 35
        '
        'chk_Menu
        '
        Me.chk_Menu.FormattingEnabled = True
        Me.chk_Menu.Items.AddRange(New Object() {"File", "System Control", "Office Modules"})
        Me.chk_Menu.Location = New System.Drawing.Point(25, 234)
        Me.chk_Menu.Name = "chk_Menu"
        Me.chk_Menu.Size = New System.Drawing.Size(123, 94)
        Me.chk_Menu.TabIndex = 34
        '
        'frm_UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 422)
        Me.Controls.Add(Me.chk_SystemControl)
        Me.Controls.Add(Me.chk_file)
        Me.Controls.Add(Me.chk_Menu)
        Me.Controls.Add(Me.lbl_userm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pic_Lock)
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
    Friend WithEvents cbo_Username As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents Pic_Lock As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_userm As System.Windows.Forms.Label
    Friend WithEvents chk_SystemControl As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_file As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_Menu As System.Windows.Forms.CheckedListBox
End Class
