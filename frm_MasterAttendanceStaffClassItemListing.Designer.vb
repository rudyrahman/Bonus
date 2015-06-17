<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MasterAttendanceStaffClassItemListing
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
        Me.chk_Maximize = New System.Windows.Forms.CheckBox()
        Me.btn_Choose = New System.Windows.Forms.Button()
        Me.dgv_ItemListing = New System.Windows.Forms.DataGridView()
        Me.grb_Search = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pnl_Form.SuspendLayout()
        CType(Me.dgv_ItemListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_Form
        '
        Me.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_Form.Controls.Add(Me.chk_Maximize)
        Me.pnl_Form.Controls.Add(Me.btn_Choose)
        Me.pnl_Form.Controls.Add(Me.dgv_ItemListing)
        Me.pnl_Form.Controls.Add(Me.grb_Search)
        Me.pnl_Form.Location = New System.Drawing.Point(2, 3)
        Me.pnl_Form.Name = "pnl_Form"
        Me.pnl_Form.Size = New System.Drawing.Size(704, 366)
        Me.pnl_Form.TabIndex = 1
        '
        'chk_Maximize
        '
        Me.chk_Maximize.AutoSize = True
        Me.chk_Maximize.Location = New System.Drawing.Point(10, 334)
        Me.chk_Maximize.Name = "chk_Maximize"
        Me.chk_Maximize.Size = New System.Drawing.Size(146, 17)
        Me.chk_Maximize.TabIndex = 7
        Me.chk_Maximize.Text = "Always maximize this form"
        Me.chk_Maximize.UseVisualStyleBackColor = True
        '
        'btn_Choose
        '
        Me.btn_Choose.Location = New System.Drawing.Point(617, 330)
        Me.btn_Choose.Name = "btn_Choose"
        Me.btn_Choose.Size = New System.Drawing.Size(75, 23)
        Me.btn_Choose.TabIndex = 6
        Me.btn_Choose.Text = "Choose"
        Me.btn_Choose.UseVisualStyleBackColor = True
        '
        'dgv_ItemListing
        '
        Me.dgv_ItemListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ItemListing.Location = New System.Drawing.Point(10, 78)
        Me.dgv_ItemListing.Name = "dgv_ItemListing"
        Me.dgv_ItemListing.Size = New System.Drawing.Size(682, 230)
        Me.dgv_ItemListing.TabIndex = 5
        '
        'grb_Search
        '
        Me.grb_Search.Controls.Add(Me.Button1)
        Me.grb_Search.Controls.Add(Me.TextBox1)
        Me.grb_Search.Location = New System.Drawing.Point(10, 10)
        Me.grb_Search.Name = "grb_Search"
        Me.grb_Search.Size = New System.Drawing.Size(682, 47)
        Me.grb_Search.TabIndex = 4
        Me.grb_Search.TabStop = False
        Me.grb_Search.Text = "Search Box"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 20)
        Me.TextBox1.TabIndex = 0
        '
        'frm_MasterAttendanceStaffClassItemListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 374)
        Me.Controls.Add(Me.pnl_Form)
        Me.Name = "frm_MasterAttendanceStaffClassItemListing"
        Me.Text = "Item Listing"
        Me.pnl_Form.ResumeLayout(False)
        Me.pnl_Form.PerformLayout()
        CType(Me.dgv_ItemListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Search.ResumeLayout(False)
        Me.grb_Search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_Form As System.Windows.Forms.Panel
    Friend WithEvents chk_Maximize As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Choose As System.Windows.Forms.Button
    Friend WithEvents dgv_ItemListing As System.Windows.Forms.DataGridView
    Friend WithEvents grb_Search As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
