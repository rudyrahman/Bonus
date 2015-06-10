<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MasterWorkgrouptoShiftReferenceAddNew
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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_workgroup = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.DGV)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Controls.Add(Me.cbo_workgroup)
        Me.pnl1.Controls.Add(Me.Label1)
        Me.pnl1.Controls.Add(Me.ShapeContainer1)
        Me.pnl1.Location = New System.Drawing.Point(4, 4)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(692, 304)
        Me.pnl1.TabIndex = 7
        '
        'DGV
        '
        Me.DGV.AllowUserToOrderColumns = True
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(5, 74)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(680, 220)
        Me.DGV.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Shift List"
        '
        'cbo_workgroup
        '
        Me.cbo_workgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_workgroup.FormattingEnabled = True
        Me.cbo_workgroup.Location = New System.Drawing.Point(76, 11)
        Me.cbo_workgroup.Name = "cbo_workgroup"
        Me.cbo_workgroup.Size = New System.Drawing.Size(237, 21)
        Me.cbo_workgroup.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Workgroup:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(690, 302)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 6
        Me.LineShape1.X2 = 684
        Me.LineShape1.Y1 = 46
        Me.LineShape1.Y2 = 46
        '
        'pnl2
        '
        Me.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl2.Controls.Add(Me.btn_cancel)
        Me.pnl2.Controls.Add(Me.btn_add)
        Me.pnl2.Location = New System.Drawing.Point(4, 314)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(692, 47)
        Me.pnl2.TabIndex = 8
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(592, 16)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(92, 23)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(479, 16)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(107, 23)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Add New"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Shift Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Shift Desc"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'frm_MasterWorkgrouptoShiftReferenceAddNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 366)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_MasterWorkgrouptoShiftReferenceAddNew"
        Me.Text = "Add New"
        Me.TopMost = True
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_workgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
