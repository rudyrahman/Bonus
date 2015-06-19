<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MasterAttendanceStaffRegistrasiItemListing
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
        Me.chk_Maximize = New System.Windows.Forms.CheckBox()
        Me.btn_Choose = New System.Windows.Forms.Button()
        Me.dgv_ItemListing = New System.Windows.Forms.DataGridView()
        Me.grp_Searchbox = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_caridata = New System.Windows.Forms.TextBox()
        Me.pnl1.SuspendLayout()
        CType(Me.dgv_ItemListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Searchbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.chk_Maximize)
        Me.pnl1.Controls.Add(Me.btn_Choose)
        Me.pnl1.Controls.Add(Me.dgv_ItemListing)
        Me.pnl1.Controls.Add(Me.grp_Searchbox)
        Me.pnl1.Location = New System.Drawing.Point(2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(704, 366)
        Me.pnl1.TabIndex = 1
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
        Me.dgv_ItemListing.AllowUserToAddRows = False
        Me.dgv_ItemListing.AllowUserToDeleteRows = False
        Me.dgv_ItemListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ItemListing.Location = New System.Drawing.Point(10, 78)
        Me.dgv_ItemListing.Name = "dgv_ItemListing"
        Me.dgv_ItemListing.ReadOnly = True
        Me.dgv_ItemListing.Size = New System.Drawing.Size(682, 230)
        Me.dgv_ItemListing.TabIndex = 5
        '
        'grp_Searchbox
        '
        Me.grp_Searchbox.Controls.Add(Me.btn_search)
        Me.grp_Searchbox.Controls.Add(Me.txt_caridata)
        Me.grp_Searchbox.Location = New System.Drawing.Point(10, 10)
        Me.grp_Searchbox.Name = "grp_Searchbox"
        Me.grp_Searchbox.Size = New System.Drawing.Size(682, 47)
        Me.grp_Searchbox.TabIndex = 4
        Me.grp_Searchbox.TabStop = False
        Me.grp_Searchbox.Text = "Search Box"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(294, 18)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 1
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txt_caridata
        '
        Me.txt_caridata.Location = New System.Drawing.Point(7, 18)
        Me.txt_caridata.Name = "txt_caridata"
        Me.txt_caridata.Size = New System.Drawing.Size(280, 20)
        Me.txt_caridata.TabIndex = 0
        '
        'frm_MasterAttendanceStaffRegistrasiItemListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 374)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frm_MasterAttendanceStaffRegistrasiItemListing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item Listing"
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.dgv_ItemListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Searchbox.ResumeLayout(False)
        Me.grp_Searchbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents chk_Maximize As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Choose As System.Windows.Forms.Button
    Friend WithEvents dgv_ItemListing As System.Windows.Forms.DataGridView
    Friend WithEvents grp_Searchbox As System.Windows.Forms.GroupBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txt_caridata As System.Windows.Forms.TextBox
End Class
