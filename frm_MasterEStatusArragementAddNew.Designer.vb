<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MasterEStatusArragementAddNew
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.cbo_Workgroup = New System.Windows.Forms.ComboBox()
        Me.cbo_division = New System.Windows.Forms.ComboBox()
        Me.cbo_Department = New System.Windows.Forms.ComboBox()
        Me.cbo_Section = New System.Windows.Forms.ComboBox()
        Me.cbo_Subsection = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdo_DefaultTimeTable = New System.Windows.Forms.RadioButton()
        Me.rdo_CustomTimeTable = New System.Windows.Forms.RadioButton()
        Me.btn_AddNew = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv_StatusArragement = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_StatusArragement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Workgroup :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Division :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Department :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Section :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sub Section :"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(76, 6)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(322, 20)
        Me.txt_code.TabIndex = 7
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(76, 32)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(607, 20)
        Me.txt_Name.TabIndex = 8
        '
        'cbo_Workgroup
        '
        Me.cbo_Workgroup.FormattingEnabled = True
        Me.cbo_Workgroup.Location = New System.Drawing.Point(76, 58)
        Me.cbo_Workgroup.Name = "cbo_Workgroup"
        Me.cbo_Workgroup.Size = New System.Drawing.Size(289, 21)
        Me.cbo_Workgroup.TabIndex = 9
        '
        'cbo_division
        '
        Me.cbo_division.FormattingEnabled = True
        Me.cbo_division.Location = New System.Drawing.Point(76, 85)
        Me.cbo_division.Name = "cbo_division"
        Me.cbo_division.Size = New System.Drawing.Size(373, 21)
        Me.cbo_division.TabIndex = 10
        '
        'cbo_Department
        '
        Me.cbo_Department.FormattingEnabled = True
        Me.cbo_Department.Location = New System.Drawing.Point(76, 112)
        Me.cbo_Department.Name = "cbo_Department"
        Me.cbo_Department.Size = New System.Drawing.Size(528, 21)
        Me.cbo_Department.TabIndex = 11
        '
        'cbo_Section
        '
        Me.cbo_Section.FormattingEnabled = True
        Me.cbo_Section.Location = New System.Drawing.Point(76, 139)
        Me.cbo_Section.Name = "cbo_Section"
        Me.cbo_Section.Size = New System.Drawing.Size(684, 21)
        Me.cbo_Section.TabIndex = 12
        '
        'cbo_Subsection
        '
        Me.cbo_Subsection.FormattingEnabled = True
        Me.cbo_Subsection.Location = New System.Drawing.Point(76, 166)
        Me.cbo_Subsection.Name = "cbo_Subsection"
        Me.cbo_Subsection.Size = New System.Drawing.Size(607, 21)
        Me.cbo_Subsection.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Employee Worktime Table"
        '
        'rdo_DefaultTimeTable
        '
        Me.rdo_DefaultTimeTable.AutoSize = True
        Me.rdo_DefaultTimeTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_DefaultTimeTable.Location = New System.Drawing.Point(8, 220)
        Me.rdo_DefaultTimeTable.Name = "rdo_DefaultTimeTable"
        Me.rdo_DefaultTimeTable.Size = New System.Drawing.Size(133, 17)
        Me.rdo_DefaultTimeTable.TabIndex = 15
        Me.rdo_DefaultTimeTable.TabStop = True
        Me.rdo_DefaultTimeTable.Text = "Default Time Table"
        Me.rdo_DefaultTimeTable.UseVisualStyleBackColor = True
        '
        'rdo_CustomTimeTable
        '
        Me.rdo_CustomTimeTable.AutoSize = True
        Me.rdo_CustomTimeTable.Location = New System.Drawing.Point(201, 220)
        Me.rdo_CustomTimeTable.Name = "rdo_CustomTimeTable"
        Me.rdo_CustomTimeTable.Size = New System.Drawing.Size(116, 17)
        Me.rdo_CustomTimeTable.TabIndex = 16
        Me.rdo_CustomTimeTable.TabStop = True
        Me.rdo_CustomTimeTable.Text = "Custom Time Table"
        Me.rdo_CustomTimeTable.UseVisualStyleBackColor = True
        '
        'btn_AddNew
        '
        Me.btn_AddNew.Location = New System.Drawing.Point(639, 350)
        Me.btn_AddNew.Name = "btn_AddNew"
        Me.btn_AddNew.Size = New System.Drawing.Size(103, 27)
        Me.btn_AddNew.TabIndex = 18
        Me.btn_AddNew.Text = "Add New"
        Me.btn_AddNew.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(748, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 27)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgv_StatusArragement
        '
        Me.dgv_StatusArragement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_StatusArragement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgv_StatusArragement.Location = New System.Drawing.Point(8, 252)
        Me.dgv_StatusArragement.Name = "dgv_StatusArragement"
        Me.dgv_StatusArragement.Size = New System.Drawing.Size(843, 83)
        Me.dgv_StatusArragement.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "#Day of Week"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column2
        '
        Me.Column2.HeaderText = "#1"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "#2"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "#3"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "#4"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "#5"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "#6"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "#7"
        Me.Column8.Name = "Column8"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "#Day of Week"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "#1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "#2"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "#3"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "#4"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "#5"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "#6"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "#7"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'frm_MasterEStatusArragementAddNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 389)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_AddNew)
        Me.Controls.Add(Me.dgv_StatusArragement)
        Me.Controls.Add(Me.rdo_CustomTimeTable)
        Me.Controls.Add(Me.rdo_DefaultTimeTable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbo_Subsection)
        Me.Controls.Add(Me.cbo_Section)
        Me.Controls.Add(Me.cbo_Department)
        Me.Controls.Add(Me.cbo_division)
        Me.Controls.Add(Me.cbo_Workgroup)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_MasterEStatusArragementAddNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_MasterEStatusArragement"
        CType(Me.dgv_StatusArragement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Workgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_division As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Department As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Section As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Subsection As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rdo_DefaultTimeTable As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_CustomTimeTable As System.Windows.Forms.RadioButton
    Friend WithEvents dgv_StatusArragement As System.Windows.Forms.DataGridView
    Friend WithEvents btn_AddNew As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
