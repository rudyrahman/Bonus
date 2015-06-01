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
        Me.chk_SystemControl = New System.Windows.Forms.CheckedListBox()
        Me.chk_file = New System.Windows.Forms.CheckedListBox()
        Me.chk_Menu = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username :"
        '
        'txt_Name
        '
        Me.txt_Name.BackColor = System.Drawing.Color.White
        Me.txt_Name.Location = New System.Drawing.Point(277, 98)
        Me.txt_Name.MaxLength = 200
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.ReadOnly = True
        Me.txt_Name.Size = New System.Drawing.Size(261, 20)
        Me.txt_Name.TabIndex = 5
        '
        'txt_Id
        '
        Me.txt_Id.BackColor = System.Drawing.Color.White
        Me.txt_Id.Location = New System.Drawing.Point(277, 123)
        Me.txt_Id.MaxLength = 11
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.ReadOnly = True
        Me.txt_Id.Size = New System.Drawing.Size(80, 20)
        Me.txt_Id.TabIndex = 6
        '
        'txt_Username
        '
        Me.txt_Username.BackColor = System.Drawing.Color.White
        Me.txt_Username.Location = New System.Drawing.Point(277, 149)
        Me.txt_Username.MaxLength = 50
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.ReadOnly = True
        Me.txt_Username.Size = New System.Drawing.Size(166, 20)
        Me.txt_Username.TabIndex = 7
        '
        'cbo_Username
        '
        Me.cbo_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Username.FormattingEnabled = True
        Me.cbo_Username.Location = New System.Drawing.Point(277, 71)
        Me.cbo_Username.Name = "cbo_Username"
        Me.cbo_Username.Size = New System.Drawing.Size(193, 21)
        Me.cbo_Username.TabIndex = 22
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(22, 381)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(123, 23)
        Me.btn_Save.TabIndex = 23
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(151, 381)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(120, 23)
        Me.btn_clear.TabIndex = 28
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'chk_SystemControl
        '
        Me.chk_SystemControl.FormattingEnabled = True
        Me.chk_SystemControl.Items.AddRange(New Object() {"Change My Password", "Add New User", "Change User Details", "Remove User", "User Management"})
        Me.chk_SystemControl.Location = New System.Drawing.Point(297, 202)
        Me.chk_SystemControl.Name = "chk_SystemControl"
        Me.chk_SystemControl.Size = New System.Drawing.Size(128, 94)
        Me.chk_SystemControl.TabIndex = 36
        '
        'chk_file
        '
        Me.chk_file.FormattingEnabled = True
        Me.chk_file.Items.AddRange(New Object() {"Log Application", "Log Out", "Exit"})
        Me.chk_file.Location = New System.Drawing.Point(171, 202)
        Me.chk_file.Name = "chk_file"
        Me.chk_file.Size = New System.Drawing.Size(120, 94)
        Me.chk_file.TabIndex = 35
        '
        'chk_Menu
        '
        Me.chk_Menu.FormattingEnabled = True
        Me.chk_Menu.Items.AddRange(New Object() {"File", "System Control", "Office Modules", "Processing Floor Module", "Data Processing", "Data Revision", "System Query", "User Query", "Reporting", "SAP B1 Interface", "PISI Soft Interface"})
        Me.chk_Menu.Location = New System.Drawing.Point(22, 202)
        Me.chk_Menu.Name = "chk_Menu"
        Me.chk_Menu.Size = New System.Drawing.Size(143, 169)
        Me.chk_Menu.TabIndex = 34
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(431, 202)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 108)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 47)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(197, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "USER MANAGEMENT"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.chk_SystemControl)
        Me.Controls.Add(Me.chk_file)
        Me.Controls.Add(Me.chk_Menu)
        Me.Controls.Add(Me.PictureBox1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents chk_SystemControl As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_file As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_Menu As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
