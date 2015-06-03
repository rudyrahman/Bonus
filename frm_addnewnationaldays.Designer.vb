<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addnewnationaldays
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
        Me.txt_yearcode = New System.Windows.Forms.TextBox()
        Me.btn_validate = New System.Windows.Forms.Button()
        Me.txt_validation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_dateto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_datefrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_yearpriode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.pnl3 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.txt_yearcode)
        Me.pnl1.Controls.Add(Me.btn_validate)
        Me.pnl1.Controls.Add(Me.txt_validation)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.txt_dateto)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.txt_datefrom)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Controls.Add(Me.cbo_yearpriode)
        Me.pnl1.Controls.Add(Me.Label1)
        Me.pnl1.Location = New System.Drawing.Point(2, 2)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(891, 77)
        Me.pnl1.TabIndex = 0
        '
        'txt_yearcode
        '
        Me.txt_yearcode.Location = New System.Drawing.Point(786, 6)
        Me.txt_yearcode.Name = "txt_yearcode"
        Me.txt_yearcode.Size = New System.Drawing.Size(58, 20)
        Me.txt_yearcode.TabIndex = 9
        Me.txt_yearcode.Visible = False
        '
        'btn_validate
        '
        Me.btn_validate.Location = New System.Drawing.Point(786, 41)
        Me.btn_validate.Name = "btn_validate"
        Me.btn_validate.Size = New System.Drawing.Size(75, 23)
        Me.btn_validate.TabIndex = 8
        Me.btn_validate.Text = "Validate"
        Me.btn_validate.UseVisualStyleBackColor = True
        '
        'txt_validation
        '
        Me.txt_validation.Location = New System.Drawing.Point(86, 43)
        Me.txt_validation.Name = "txt_validation"
        Me.txt_validation.Size = New System.Drawing.Size(694, 20)
        Me.txt_validation.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Validation By:"
        '
        'txt_dateto
        '
        Me.txt_dateto.Location = New System.Drawing.Point(605, 6)
        Me.txt_dateto.Name = "txt_dateto"
        Me.txt_dateto.Size = New System.Drawing.Size(175, 20)
        Me.txt_dateto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date To:"
        '
        'txt_datefrom
        '
        Me.txt_datefrom.Location = New System.Drawing.Point(367, 7)
        Me.txt_datefrom.Name = "txt_datefrom"
        Me.txt_datefrom.Size = New System.Drawing.Size(175, 20)
        Me.txt_datefrom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date From:"
        '
        'cbo_yearpriode
        '
        Me.cbo_yearpriode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_yearpriode.FormattingEnabled = True
        Me.cbo_yearpriode.Location = New System.Drawing.Point(80, 6)
        Me.cbo_yearpriode.Name = "cbo_yearpriode"
        Me.cbo_yearpriode.Size = New System.Drawing.Size(204, 21)
        Me.cbo_yearpriode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Year Priode:"
        '
        'pnl2
        '
        Me.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl2.Controls.Add(Me.DGV)
        Me.pnl2.Location = New System.Drawing.Point(2, 85)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(891, 469)
        Me.pnl2.TabIndex = 1
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(9, 9)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(874, 448)
        Me.DGV.TabIndex = 0
        '
        'pnl3
        '
        Me.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl3.Controls.Add(Me.btn_close)
        Me.pnl3.Controls.Add(Me.btn_save)
        Me.pnl3.Controls.Add(Me.btn_export)
        Me.pnl3.Location = New System.Drawing.Point(2, 560)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(891, 44)
        Me.pnl3.TabIndex = 2
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(779, 8)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(91, 23)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(661, 8)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(110, 23)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "Save Data"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(284, 8)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(117, 23)
        Me.btn_export.TabIndex = 0
        Me.btn_export.Text = "Export To Excel"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Event Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frm_addnewnationaldays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 607)
        Me.Controls.Add(Me.pnl3)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_addnewnationaldays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New"
        Me.pnl1.ResumeLayout(false)
        Me.pnl1.PerformLayout
        Me.pnl2.ResumeLayout(false)
        CType(Me.DGV,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnl3.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents btn_validate As System.Windows.Forms.Button
    Friend WithEvents txt_validation As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_dateto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_datefrom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_yearpriode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents pnl3 As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_yearcode As System.Windows.Forms.TextBox
End Class
