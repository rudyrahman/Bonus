<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MasterDepartment
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
        Me.pnl_Form = New System.Windows.Forms.Panel()
        Me.txt_CariData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_MasterDepartment = New System.Windows.Forms.DataGridView()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_ExportToExcel = New System.Windows.Forms.Button()
        Me.btn_RefreshData = New System.Windows.Forms.Button()
        Me.btn_TambahBaru = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_Form.SuspendLayout()
        CType(Me.dgv_MasterDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_Form
        '
        Me.pnl_Form.BackColor = System.Drawing.Color.Lavender
        Me.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Form.Controls.Add(Me.txt_CariData)
        Me.pnl_Form.Controls.Add(Me.Label1)
        Me.pnl_Form.Controls.Add(Me.dgv_MasterDepartment)
        Me.pnl_Form.Controls.Add(Me.btn_Close)
        Me.pnl_Form.Controls.Add(Me.btn_ExportToExcel)
        Me.pnl_Form.Controls.Add(Me.btn_RefreshData)
        Me.pnl_Form.Controls.Add(Me.btn_TambahBaru)
        Me.pnl_Form.Location = New System.Drawing.Point(2, 3)
        Me.pnl_Form.Name = "pnl_Form"
        Me.pnl_Form.Size = New System.Drawing.Size(780, 457)
        Me.pnl_Form.TabIndex = 4
        '
        'txt_CariData
        '
        Me.txt_CariData.Location = New System.Drawing.Point(76, 20)
        Me.txt_CariData.MaxLength = 100
        Me.txt_CariData.Name = "txt_CariData"
        Me.txt_CariData.Size = New System.Drawing.Size(374, 20)
        Me.txt_CariData.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Cari Data :"
        '
        'dgv_MasterDepartment
        '
        Me.dgv_MasterDepartment.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_MasterDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_MasterDepartment.Location = New System.Drawing.Point(9, 66)
        Me.dgv_MasterDepartment.Name = "dgv_MasterDepartment"
        Me.dgv_MasterDepartment.Size = New System.Drawing.Size(760, 325)
        Me.dgv_MasterDepartment.TabIndex = 21
        Me.dgv_MasterDepartment.TabStop = False
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(666, 419)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(103, 27)
        Me.btn_Close.TabIndex = 5
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_ExportToExcel
        '
        Me.btn_ExportToExcel.Location = New System.Drawing.Point(339, 419)
        Me.btn_ExportToExcel.Name = "btn_ExportToExcel"
        Me.btn_ExportToExcel.Size = New System.Drawing.Size(103, 27)
        Me.btn_ExportToExcel.TabIndex = 2
        Me.btn_ExportToExcel.Text = "Export To Excel"
        Me.btn_ExportToExcel.UseVisualStyleBackColor = True
        '
        'btn_RefreshData
        '
        Me.btn_RefreshData.Location = New System.Drawing.Point(448, 419)
        Me.btn_RefreshData.Name = "btn_RefreshData"
        Me.btn_RefreshData.Size = New System.Drawing.Size(103, 27)
        Me.btn_RefreshData.TabIndex = 3
        Me.btn_RefreshData.Text = "Refresh Data"
        Me.btn_RefreshData.UseVisualStyleBackColor = True
        '
        'btn_TambahBaru
        '
        Me.btn_TambahBaru.Location = New System.Drawing.Point(557, 419)
        Me.btn_TambahBaru.Name = "btn_TambahBaru"
        Me.btn_TambahBaru.Size = New System.Drawing.Size(103, 27)
        Me.btn_TambahBaru.TabIndex = 4
        Me.btn_TambahBaru.Text = "Tambah Baru"
        Me.btn_TambahBaru.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'frm_MasterDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.pnl_Form)
        Me.Name = "frm_MasterDepartment"
        Me.Text = "frm_MasterDepartment"
        Me.pnl_Form.ResumeLayout(False)
        Me.pnl_Form.PerformLayout()
        CType(Me.dgv_MasterDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_Form As System.Windows.Forms.Panel
    Friend WithEvents txt_CariData As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_MasterDepartment As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_ExportToExcel As System.Windows.Forms.Button
    Friend WithEvents btn_RefreshData As System.Windows.Forms.Button
    Friend WithEvents btn_TambahBaru As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
