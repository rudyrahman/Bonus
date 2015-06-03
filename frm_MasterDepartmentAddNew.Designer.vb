<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MasterDepartmentAddNew
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_AddNew = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_DepartmentDescription = New System.Windows.Forms.TextBox()
        Me.cbo_DevisionCode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_DevisionDescription = New System.Windows.Forms.TextBox()
        Me.txt_DepartmentCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 207)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_AddNew)
        Me.Panel2.Location = New System.Drawing.Point(9, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(567, 35)
        Me.Panel2.TabIndex = 7
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(458, 3)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(103, 27)
        Me.btn_Cancel.TabIndex = 6
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_AddNew
        '
        Me.btn_AddNew.Location = New System.Drawing.Point(349, 3)
        Me.btn_AddNew.Name = "btn_AddNew"
        Me.btn_AddNew.Size = New System.Drawing.Size(103, 27)
        Me.btn_AddNew.TabIndex = 5
        Me.btn_AddNew.Text = "Add New"
        Me.btn_AddNew.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_DepartmentDescription)
        Me.Panel3.Controls.Add(Me.cbo_DevisionCode)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txt_DevisionDescription)
        Me.Panel3.Controls.Add(Me.txt_DepartmentCode)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(9, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(567, 131)
        Me.Panel3.TabIndex = 6
        '
        'txt_DepartmentDescription
        '
        Me.txt_DepartmentDescription.Location = New System.Drawing.Point(133, 94)
        Me.txt_DepartmentDescription.MaxLength = 100
        Me.txt_DepartmentDescription.Name = "txt_DepartmentDescription"
        Me.txt_DepartmentDescription.Size = New System.Drawing.Size(428, 20)
        Me.txt_DepartmentDescription.TabIndex = 4
        '
        'cbo_DevisionCode
        '
        Me.cbo_DevisionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_DevisionCode.FormattingEnabled = True
        Me.cbo_DevisionCode.Location = New System.Drawing.Point(133, 11)
        Me.cbo_DevisionCode.Name = "cbo_DevisionCode"
        Me.cbo_DevisionCode.Size = New System.Drawing.Size(126, 21)
        Me.cbo_DevisionCode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Departmen Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Departmen Code"
        '
        'txt_DevisionDescription
        '
        Me.txt_DevisionDescription.BackColor = System.Drawing.Color.White
        Me.txt_DevisionDescription.Location = New System.Drawing.Point(133, 40)
        Me.txt_DevisionDescription.MaxLength = 100
        Me.txt_DevisionDescription.Name = "txt_DevisionDescription"
        Me.txt_DevisionDescription.ReadOnly = True
        Me.txt_DevisionDescription.Size = New System.Drawing.Size(428, 20)
        Me.txt_DevisionDescription.TabIndex = 2
        Me.txt_DevisionDescription.TabStop = False
        '
        'txt_DepartmentCode
        '
        Me.txt_DepartmentCode.Location = New System.Drawing.Point(133, 67)
        Me.txt_DepartmentCode.MaxLength = 20
        Me.txt_DepartmentCode.Name = "txt_DepartmentCode"
        Me.txt_DepartmentCode.Size = New System.Drawing.Size(126, 20)
        Me.txt_DepartmentCode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Devision Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Devision Code :"
        '
        'frm_MasterDepartmentAddNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 211)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_MasterDepartmentAddNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_MasterDepartmentAddNew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_AddNew As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_DepartmentDescription As System.Windows.Forms.TextBox
    Friend WithEvents cbo_DevisionCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_DevisionDescription As System.Windows.Forms.TextBox
    Friend WithEvents txt_DepartmentCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
