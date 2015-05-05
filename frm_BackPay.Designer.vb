<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BackPay
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnl_01 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dgv_BackPay = New System.Windows.Forms.DataGridView()
        Me.btn_import = New System.Windows.Forms.Button()
        Me.txt_DocumentName = New System.Windows.Forms.TextBox()
        Me.cbo_year = New System.Windows.Forms.ComboBox()
        Me.cbo_month = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pnl_01.SuspendLayout()
        CType(Me.dgv_BackPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pnl_01
        '
        Me.pnl_01.Controls.Add(Me.btn_cancel)
        Me.pnl_01.Controls.Add(Me.btn_save)
        Me.pnl_01.Controls.Add(Me.dgv_BackPay)
        Me.pnl_01.Controls.Add(Me.btn_import)
        Me.pnl_01.Controls.Add(Me.txt_DocumentName)
        Me.pnl_01.Controls.Add(Me.cbo_year)
        Me.pnl_01.Controls.Add(Me.cbo_month)
        Me.pnl_01.Controls.Add(Me.Label3)
        Me.pnl_01.Controls.Add(Me.Label2)
        Me.pnl_01.Controls.Add(Me.Label1)
        Me.pnl_01.Controls.Add(Me.ShapeContainer1)
        Me.pnl_01.Location = New System.Drawing.Point(1, 1)
        Me.pnl_01.Name = "pnl_01"
        Me.pnl_01.Size = New System.Drawing.Size(781, 562)
        Me.pnl_01.TabIndex = 0
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.Location = New System.Drawing.Point(201, 499)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(98, 27)
        Me.btn_cancel.TabIndex = 52
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Green
        Me.btn_save.Location = New System.Drawing.Point(24, 499)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(154, 27)
        Me.btn_save.TabIndex = 51
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'dgv_BackPay
        '
        Me.dgv_BackPay.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_BackPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_BackPay.Location = New System.Drawing.Point(24, 120)
        Me.dgv_BackPay.Name = "dgv_BackPay"
        Me.dgv_BackPay.Size = New System.Drawing.Size(695, 293)
        Me.dgv_BackPay.TabIndex = 50
        '
        'btn_import
        '
        Me.btn_import.Location = New System.Drawing.Point(544, 88)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(175, 26)
        Me.btn_import.TabIndex = 49
        Me.btn_import.Text = "Import from Excel"
        Me.btn_import.UseVisualStyleBackColor = True
        '
        'txt_DocumentName
        '
        Me.txt_DocumentName.Location = New System.Drawing.Point(110, 55)
        Me.txt_DocumentName.MaxLength = 100
        Me.txt_DocumentName.Name = "txt_DocumentName"
        Me.txt_DocumentName.Size = New System.Drawing.Size(479, 20)
        Me.txt_DocumentName.TabIndex = 48
        '
        'cbo_year
        '
        Me.cbo_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_year.FormattingEnabled = True
        Me.cbo_year.Location = New System.Drawing.Point(110, 28)
        Me.cbo_year.Name = "cbo_year"
        Me.cbo_year.Size = New System.Drawing.Size(149, 21)
        Me.cbo_year.TabIndex = 47
        '
        'cbo_month
        '
        Me.cbo_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_month.FormattingEnabled = True
        Me.cbo_month.Location = New System.Drawing.Point(110, 1)
        Me.cbo_month.Name = "cbo_month"
        Me.cbo_month.Size = New System.Drawing.Size(149, 21)
        Me.cbo_month.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Document Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Year :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Month :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(781, 562)
        Me.ShapeContainer1.TabIndex = 53
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 776
        Me.LineShape1.Y1 = 484
        Me.LineShape1.Y2 = 483
        '
        'frm_BackPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.pnl_01)
        Me.Name = "frm_BackPay"
        Me.Text = "frm_BackPay"
        Me.pnl_01.ResumeLayout(False)
        Me.pnl_01.PerformLayout()
        CType(Me.dgv_BackPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnl_01 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents dgv_BackPay As System.Windows.Forms.DataGridView
    Friend WithEvents btn_import As System.Windows.Forms.Button
    Friend WithEvents txt_DocumentName As System.Windows.Forms.TextBox
    Friend WithEvents cbo_year As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_month As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
