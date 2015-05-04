<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Deduction
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
        Me.cbo_Month = New System.Windows.Forms.ComboBox()
        Me.cbo_year = New System.Windows.Forms.ComboBox()
        Me.dgv_Deduction = New System.Windows.Forms.DataGridView()
        Me.btn_ImportFromExcel = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_DocumentName = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.dgv_Deduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Month :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Document Name :"
        '
        'cbo_Month
        '
        Me.cbo_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Month.FormattingEnabled = True
        Me.cbo_Month.Location = New System.Drawing.Point(109, 9)
        Me.cbo_Month.Name = "cbo_Month"
        Me.cbo_Month.Size = New System.Drawing.Size(215, 21)
        Me.cbo_Month.TabIndex = 3
        '
        'cbo_year
        '
        Me.cbo_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_year.FormattingEnabled = True
        Me.cbo_year.Location = New System.Drawing.Point(109, 34)
        Me.cbo_year.Name = "cbo_year"
        Me.cbo_year.Size = New System.Drawing.Size(121, 21)
        Me.cbo_year.TabIndex = 4
        '
        'dgv_Deduction
        '
        Me.dgv_Deduction.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_Deduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Deduction.Location = New System.Drawing.Point(12, 114)
        Me.dgv_Deduction.Name = "dgv_Deduction"
        Me.dgv_Deduction.Size = New System.Drawing.Size(881, 367)
        Me.dgv_Deduction.TabIndex = 6
        '
        'btn_ImportFromExcel
        '
        Me.btn_ImportFromExcel.Location = New System.Drawing.Point(667, 85)
        Me.btn_ImportFromExcel.Name = "btn_ImportFromExcel"
        Me.btn_ImportFromExcel.Size = New System.Drawing.Size(226, 23)
        Me.btn_ImportFromExcel.TabIndex = 7
        Me.btn_ImportFromExcel.Text = "Import From Excel"
        Me.btn_ImportFromExcel.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_Save.Location = New System.Drawing.Point(15, 514)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(165, 36)
        Me.btn_Save.TabIndex = 8
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Red
        Me.btn_Cancel.Location = New System.Drawing.Point(186, 514)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(120, 36)
        Me.btn_Cancel.TabIndex = 9
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        '
        'txt_DocumentName
        '
        Me.txt_DocumentName.Location = New System.Drawing.Point(109, 58)
        Me.txt_DocumentName.MaxLength = 100
        Me.txt_DocumentName.Name = "txt_DocumentName"
        Me.txt_DocumentName.Size = New System.Drawing.Size(547, 20)
        Me.txt_DocumentName.TabIndex = 10
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(905, 562)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 902
        Me.LineShape1.Y1 = 510
        Me.LineShape1.Y2 = 509
        '
        'frm_Deduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(905, 562)
        Me.Controls.Add(Me.txt_DocumentName)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_ImportFromExcel)
        Me.Controls.Add(Me.dgv_Deduction)
        Me.Controls.Add(Me.cbo_year)
        Me.Controls.Add(Me.cbo_Month)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frm_Deduction"
        Me.Text = "Import Data Deduction"
        CType(Me.dgv_Deduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_Month As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_year As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_Deduction As System.Windows.Forms.DataGridView
    Friend WithEvents btn_ImportFromExcel As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_DocumentName As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
