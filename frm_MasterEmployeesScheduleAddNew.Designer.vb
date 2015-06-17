<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MasterEmployeesScheduleAddNew
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.lst_schedule = New System.Windows.Forms.ListView()
        Me.dmn_FinishTime = New System.Windows.Forms.DomainUpDown()
        Me.dmn_BreakinTime = New System.Windows.Forms.DomainUpDown()
        Me.dmn_BreakoutTime = New System.Windows.Forms.DomainUpDown()
        Me.dmn_StartTime = New System.Windows.Forms.DomainUpDown()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_AddNew = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_shift = New System.Windows.Forms.ComboBox()
        Me.cbo_day = New System.Windows.Forms.ComboBox()
        Me.cbo_subsection = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbo_section = New System.Windows.Forms.ComboBox()
        Me.cbo_departemen = New System.Windows.Forms.ComboBox()
        Me.cbo_devision = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt2)
        Me.Panel1.Controls.Add(Me.txt1)
        Me.Panel1.Controls.Add(Me.txt)
        Me.Panel1.Controls.Add(Me.lst_schedule)
        Me.Panel1.Controls.Add(Me.dmn_FinishTime)
        Me.Panel1.Controls.Add(Me.dmn_BreakinTime)
        Me.Panel1.Controls.Add(Me.dmn_BreakoutTime)
        Me.Panel1.Controls.Add(Me.dmn_StartTime)
        Me.Panel1.Controls.Add(Me.btn_Cancel)
        Me.Panel1.Controls.Add(Me.btn_AddNew)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbo_shift)
        Me.Panel1.Controls.Add(Me.cbo_day)
        Me.Panel1.Controls.Add(Me.cbo_subsection)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.cbo_section)
        Me.Panel1.Controls.Add(Me.cbo_departemen)
        Me.Panel1.Controls.Add(Me.cbo_devision)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 358)
        Me.Panel1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(149, 246)
        Me.txt2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(150, 20)
        Me.txt2.TabIndex = 28
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(149, 227)
        Me.txt1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(150, 20)
        Me.txt1.TabIndex = 27
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(149, 208)
        Me.txt.Margin = New System.Windows.Forms.Padding(1)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(150, 20)
        Me.txt.TabIndex = 26
        '
        'lst_schedule
        '
        Me.lst_schedule.FullRowSelect = True
        Me.lst_schedule.GridLines = True
        Me.lst_schedule.Location = New System.Drawing.Point(16, 186)
        Me.lst_schedule.Name = "lst_schedule"
        Me.lst_schedule.Size = New System.Drawing.Size(285, 89)
        Me.lst_schedule.TabIndex = 25
        Me.lst_schedule.UseCompatibleStateImageBehavior = False
        '
        'dmn_FinishTime
        '
        Me.dmn_FinishTime.Location = New System.Drawing.Point(671, 123)
        Me.dmn_FinishTime.Name = "dmn_FinishTime"
        Me.dmn_FinishTime.ReadOnly = True
        Me.dmn_FinishTime.Size = New System.Drawing.Size(70, 20)
        Me.dmn_FinishTime.TabIndex = 23
        Me.dmn_FinishTime.Text = "00 : 00"
        '
        'dmn_BreakinTime
        '
        Me.dmn_BreakinTime.Location = New System.Drawing.Point(497, 123)
        Me.dmn_BreakinTime.Name = "dmn_BreakinTime"
        Me.dmn_BreakinTime.ReadOnly = True
        Me.dmn_BreakinTime.Size = New System.Drawing.Size(70, 20)
        Me.dmn_BreakinTime.TabIndex = 22
        Me.dmn_BreakinTime.Text = "00 : 00"
        '
        'dmn_BreakoutTime
        '
        Me.dmn_BreakoutTime.Location = New System.Drawing.Point(294, 123)
        Me.dmn_BreakoutTime.Name = "dmn_BreakoutTime"
        Me.dmn_BreakoutTime.ReadOnly = True
        Me.dmn_BreakoutTime.Size = New System.Drawing.Size(70, 20)
        Me.dmn_BreakoutTime.TabIndex = 21
        Me.dmn_BreakoutTime.Text = "00 : 00"
        '
        'dmn_StartTime
        '
        Me.dmn_StartTime.Location = New System.Drawing.Point(89, 123)
        Me.dmn_StartTime.Name = "dmn_StartTime"
        Me.dmn_StartTime.ReadOnly = True
        Me.dmn_StartTime.Size = New System.Drawing.Size(70, 20)
        Me.dmn_StartTime.TabIndex = 20
        Me.dmn_StartTime.Text = "00 : 00"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(659, 320)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(103, 27)
        Me.btn_Cancel.TabIndex = 18
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_AddNew
        '
        Me.btn_AddNew.Location = New System.Drawing.Point(550, 320)
        Me.btn_AddNew.Name = "btn_AddNew"
        Me.btn_AddNew.Size = New System.Drawing.Size(103, 27)
        Me.btn_AddNew.TabIndex = 17
        Me.btn_AddNew.Text = "Add New"
        Me.btn_AddNew.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(605, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Finish Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(422, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Breakin Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(212, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Breakout Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Start Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Shift :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Day Name :"
        '
        'cbo_shift
        '
        Me.cbo_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_shift.FormattingEnabled = True
        Me.cbo_shift.Location = New System.Drawing.Point(385, 77)
        Me.cbo_shift.Name = "cbo_shift"
        Me.cbo_shift.Size = New System.Drawing.Size(82, 21)
        Me.cbo_shift.TabIndex = 9
        '
        'cbo_day
        '
        Me.cbo_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_day.FormattingEnabled = True
        Me.cbo_day.Location = New System.Drawing.Point(76, 77)
        Me.cbo_day.Name = "cbo_day"
        Me.cbo_day.Size = New System.Drawing.Size(241, 21)
        Me.cbo_day.TabIndex = 8
        '
        'cbo_subsection
        '
        Me.cbo_subsection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_subsection.FormattingEnabled = True
        Me.cbo_subsection.Location = New System.Drawing.Point(90, 42)
        Me.cbo_subsection.Name = "cbo_subsection"
        Me.cbo_subsection.Size = New System.Drawing.Size(672, 21)
        Me.cbo_subsection.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sub Section :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(528, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Section :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Department :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(54, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Devision :"
        '
        'cbo_section
        '
        Me.cbo_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_section.FormattingEnabled = True
        Me.cbo_section.Location = New System.Drawing.Point(577, 9)
        Me.cbo_section.Name = "cbo_section"
        Me.cbo_section.Size = New System.Drawing.Size(185, 21)
        Me.cbo_section.TabIndex = 2
        '
        'cbo_departemen
        '
        Me.cbo_departemen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_departemen.FormattingEnabled = True
        Me.cbo_departemen.Location = New System.Drawing.Point(338, 9)
        Me.cbo_departemen.Name = "cbo_departemen"
        Me.cbo_departemen.Size = New System.Drawing.Size(185, 21)
        Me.cbo_departemen.TabIndex = 1
        '
        'cbo_devision
        '
        Me.cbo_devision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_devision.FormattingEnabled = True
        Me.cbo_devision.Location = New System.Drawing.Point(73, 9)
        Me.cbo_devision.Name = "cbo_devision"
        Me.cbo_devision.Size = New System.Drawing.Size(185, 21)
        Me.cbo_devision.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(778, 356)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 778
        Me.LineShape1.Y1 = 309
        Me.LineShape1.Y2 = 309
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data Inputed"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frm_MasterEmployeesScheduleAddNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_MasterEmployeesScheduleAddNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Employees Schedule Add New"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_AddNew As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_shift As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_day As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_subsection As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_section As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_departemen As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_devision As System.Windows.Forms.ComboBox
    Friend WithEvents dmn_FinishTime As System.Windows.Forms.DomainUpDown
    Friend WithEvents dmn_BreakinTime As System.Windows.Forms.DomainUpDown
    Friend WithEvents dmn_BreakoutTime As System.Windows.Forms.DomainUpDown
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lst_schedule As System.Windows.Forms.ListView
    Friend WithEvents dmn_StartTime As System.Windows.Forms.DomainUpDown
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
End Class
