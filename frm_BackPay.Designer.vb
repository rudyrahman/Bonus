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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgv_BackPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.Location = New System.Drawing.Point(204, 476)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(98, 27)
        Me.btn_cancel.TabIndex = 42
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Green
        Me.btn_save.Location = New System.Drawing.Point(25, 476)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(154, 27)
        Me.btn_save.TabIndex = 41
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'dgv_BackPay
        '
        Me.dgv_BackPay.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_BackPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_BackPay.Location = New System.Drawing.Point(25, 127)
        Me.dgv_BackPay.Name = "dgv_BackPay"
        Me.dgv_BackPay.Size = New System.Drawing.Size(695, 293)
        Me.dgv_BackPay.TabIndex = 40
        '
        'btn_import
        '
        Me.btn_import.Location = New System.Drawing.Point(559, 95)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(161, 26)
        Me.btn_import.TabIndex = 39
        Me.btn_import.Text = "Import from Excel"
        Me.btn_import.UseVisualStyleBackColor = True
        '
        'txt_DocumentName
        '
        Me.txt_DocumentName.Location = New System.Drawing.Point(111, 62)
        Me.txt_DocumentName.MaxLength = 100
        Me.txt_DocumentName.Name = "txt_DocumentName"
        Me.txt_DocumentName.Size = New System.Drawing.Size(376, 20)
        Me.txt_DocumentName.TabIndex = 38
        '
        'cbo_year
        '
        Me.cbo_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_year.FormattingEnabled = True
        Me.cbo_year.Location = New System.Drawing.Point(111, 35)
        Me.cbo_year.Name = "cbo_year"
        Me.cbo_year.Size = New System.Drawing.Size(149, 21)
        Me.cbo_year.TabIndex = 37
        '
        'cbo_month
        '
        Me.cbo_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_month.FormattingEnabled = True
        Me.cbo_month.Location = New System.Drawing.Point(111, 8)
        Me.cbo_month.Name = "cbo_month"
        Me.cbo_month.Size = New System.Drawing.Size(149, 21)
        Me.cbo_month.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Document Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Year :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Month :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_BackPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.dgv_BackPay)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.txt_DocumentName)
        Me.Controls.Add(Me.cbo_year)
        Me.Controls.Add(Me.cbo_month)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_BackPay"
        Me.Text = "frm_BackPay"
        CType(Me.dgv_BackPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
