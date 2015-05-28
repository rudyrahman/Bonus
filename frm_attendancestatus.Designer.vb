<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_attendancestatus
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
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.pnl3 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_tambahbaru = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.txt_cari)
        Me.pnl1.Controls.Add(Me.Label1)
        Me.pnl1.Location = New System.Drawing.Point(1, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(692, 47)
        Me.pnl1.TabIndex = 6
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(85, 14)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(246, 20)
        Me.txt_cari.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Data:"
        '
        'pnl2
        '
        Me.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl2.Controls.Add(Me.DGV)
        Me.pnl2.Location = New System.Drawing.Point(2, 53)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(691, 294)
        Me.pnl2.TabIndex = 9
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(683, 286)
        Me.DGV.TabIndex = 0
        '
        'pnl3
        '
        Me.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl3.Controls.Add(Me.btn_close)
        Me.pnl3.Controls.Add(Me.btn_export)
        Me.pnl3.Controls.Add(Me.btn_tambahbaru)
        Me.pnl3.Controls.Add(Me.btn_refresh)
        Me.pnl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl3.Location = New System.Drawing.Point(0, 353)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(694, 47)
        Me.pnl3.TabIndex = 10
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(598, 17)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(84, 23)
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(304, 17)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(91, 23)
        Me.btn_export.TabIndex = 3
        Me.btn_export.Text = "Export to Excel"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'btn_tambahbaru
        '
        Me.btn_tambahbaru.Location = New System.Drawing.Point(500, 17)
        Me.btn_tambahbaru.Name = "btn_tambahbaru"
        Me.btn_tambahbaru.Size = New System.Drawing.Size(92, 23)
        Me.btn_tambahbaru.TabIndex = 1
        Me.btn_tambahbaru.Text = "Tambah Baru"
        Me.btn_tambahbaru.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(401, 17)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(93, 23)
        Me.btn_refresh.TabIndex = 2
        Me.btn_refresh.Text = "Refresh Data"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'frm_attendancestatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 400)
        Me.Controls.Add(Me.pnl3)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frm_attendancestatus"
        Me.Text = "Master Attandance Status"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents pnl3 As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_tambahbaru As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
End Class
