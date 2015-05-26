<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MonthPeriode
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_tambahbaru = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cari)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(67, 13)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(246, 20)
        Me.txt_cari.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Data:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_export)
        Me.GroupBox2.Controls.Add(Me.btn_refresh)
        Me.GroupBox2.Controls.Add(Me.btn_tambahbaru)
        Me.GroupBox2.Controls.Add(Me.btn_close)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 51)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(302, 22)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(91, 23)
        Me.btn_export.TabIndex = 3
        Me.btn_export.Text = "Export to Excel"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(402, 22)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(93, 23)
        Me.btn_refresh.TabIndex = 2
        Me.btn_refresh.Text = "Refresh Data"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_tambahbaru
        '
        Me.btn_tambahbaru.Location = New System.Drawing.Point(501, 22)
        Me.btn_tambahbaru.Name = "btn_tambahbaru"
        Me.btn_tambahbaru.Size = New System.Drawing.Size(92, 23)
        Me.btn_tambahbaru.TabIndex = 1
        Me.btn_tambahbaru.Text = "Tambah Baru"
        Me.btn_tambahbaru.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(599, 22)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(84, 23)
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox3.Controls.Add(Me.DGV)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(692, 294)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(10, 19)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(672, 257)
        Me.DGV.TabIndex = 0
        '
        'frm_MonthPeriode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 404)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_MonthPeriode"
        Me.Text = "frm_MonthPeriode"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_tambahbaru As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
