<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ANapps
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ANapps))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnu_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_LockApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_spFile_001 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_System = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ChangeMyPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_spSystem_001 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_AddNewUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ChangeUserDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_RemoveUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_spSystem_002 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_UserManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_OfficeModule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ProcessingFloorModule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_DataProcessing = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_DataRevision = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_SystemQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_UserQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Reporting = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_SapB1Interface = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_PisiSoftInterface = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_LockSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_File, Me.mnu_System, Me.mnu_OfficeModule, Me.mnu_ProcessingFloorModule, Me.mnu_DataProcessing, Me.mnu_DataRevision, Me.mnu_SystemQuery, Me.mnu_UserQuery, Me.mnu_Reporting, Me.mnu_SapB1Interface, Me.mnu_PisiSoftInterface})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1050, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnu_File
        '
        Me.mnu_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_LockApplication, Me.mnu_Logout, Me.mnu_spFile_001, Me.mnu_Exit})
        Me.mnu_File.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnu_File.Name = "mnu_File"
        Me.mnu_File.Size = New System.Drawing.Size(37, 20)
        Me.mnu_File.Text = "&File"
        '
        'mnu_LockApplication
        '
        Me.mnu_LockApplication.Name = "mnu_LockApplication"
        Me.mnu_LockApplication.Size = New System.Drawing.Size(163, 22)
        Me.mnu_LockApplication.Text = "Lock Application"
        '
        'mnu_Logout
        '
        Me.mnu_Logout.Name = "mnu_Logout"
        Me.mnu_Logout.Size = New System.Drawing.Size(163, 22)
        Me.mnu_Logout.Text = "Log Out"
        '
        'mnu_spFile_001
        '
        Me.mnu_spFile_001.Name = "mnu_spFile_001"
        Me.mnu_spFile_001.Size = New System.Drawing.Size(160, 6)
        '
        'mnu_Exit
        '
        Me.mnu_Exit.Name = "mnu_Exit"
        Me.mnu_Exit.Size = New System.Drawing.Size(163, 22)
        Me.mnu_Exit.Text = "Exit"
        '
        'mnu_System
        '
        Me.mnu_System.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ChangeMyPassword, Me.mnu_spSystem_001, Me.mnu_AddNewUser, Me.mnu_ChangeUserDetails, Me.mnu_RemoveUser, Me.mnu_spSystem_002, Me.mnu_UserManagement})
        Me.mnu_System.Name = "mnu_System"
        Me.mnu_System.Size = New System.Drawing.Size(100, 20)
        Me.mnu_System.Text = "System Control"
        '
        'mnu_ChangeMyPassword
        '
        Me.mnu_ChangeMyPassword.Name = "mnu_ChangeMyPassword"
        Me.mnu_ChangeMyPassword.Size = New System.Drawing.Size(188, 22)
        Me.mnu_ChangeMyPassword.Text = "Change My Password"
        '
        'mnu_spSystem_001
        '
        Me.mnu_spSystem_001.Name = "mnu_spSystem_001"
        Me.mnu_spSystem_001.Size = New System.Drawing.Size(185, 6)
        '
        'mnu_AddNewUser
        '
        Me.mnu_AddNewUser.Name = "mnu_AddNewUser"
        Me.mnu_AddNewUser.Size = New System.Drawing.Size(188, 22)
        Me.mnu_AddNewUser.Text = "Add New User"
        '
        'mnu_ChangeUserDetails
        '
        Me.mnu_ChangeUserDetails.Name = "mnu_ChangeUserDetails"
        Me.mnu_ChangeUserDetails.Size = New System.Drawing.Size(188, 22)
        Me.mnu_ChangeUserDetails.Text = "Change User Details"
        '
        'mnu_RemoveUser
        '
        Me.mnu_RemoveUser.Name = "mnu_RemoveUser"
        Me.mnu_RemoveUser.Size = New System.Drawing.Size(188, 22)
        Me.mnu_RemoveUser.Text = "Remove User"
        '
        'mnu_spSystem_002
        '
        Me.mnu_spSystem_002.Name = "mnu_spSystem_002"
        Me.mnu_spSystem_002.Size = New System.Drawing.Size(185, 6)
        '
        'mnu_UserManagement
        '
        Me.mnu_UserManagement.Name = "mnu_UserManagement"
        Me.mnu_UserManagement.Size = New System.Drawing.Size(188, 22)
        Me.mnu_UserManagement.Text = "User Management"
        '
        'mnu_OfficeModule
        '
        Me.mnu_OfficeModule.Name = "mnu_OfficeModule"
        Me.mnu_OfficeModule.Size = New System.Drawing.Size(100, 20)
        Me.mnu_OfficeModule.Text = "Office Modules"
        '
        'mnu_ProcessingFloorModule
        '
        Me.mnu_ProcessingFloorModule.Name = "mnu_ProcessingFloorModule"
        Me.mnu_ProcessingFloorModule.Size = New System.Drawing.Size(150, 20)
        Me.mnu_ProcessingFloorModule.Text = "Processing Floor Module"
        '
        'mnu_DataProcessing
        '
        Me.mnu_DataProcessing.Name = "mnu_DataProcessing"
        Me.mnu_DataProcessing.Size = New System.Drawing.Size(103, 20)
        Me.mnu_DataProcessing.Text = "Data Processing"
        '
        'mnu_DataRevision
        '
        Me.mnu_DataRevision.Name = "mnu_DataRevision"
        Me.mnu_DataRevision.Size = New System.Drawing.Size(90, 20)
        Me.mnu_DataRevision.Text = "Data Revision"
        '
        'mnu_SystemQuery
        '
        Me.mnu_SystemQuery.Name = "mnu_SystemQuery"
        Me.mnu_SystemQuery.Size = New System.Drawing.Size(92, 20)
        Me.mnu_SystemQuery.Text = "System Query"
        '
        'mnu_UserQuery
        '
        Me.mnu_UserQuery.Name = "mnu_UserQuery"
        Me.mnu_UserQuery.Size = New System.Drawing.Size(77, 20)
        Me.mnu_UserQuery.Text = "User Query"
        '
        'mnu_Reporting
        '
        Me.mnu_Reporting.Name = "mnu_Reporting"
        Me.mnu_Reporting.Size = New System.Drawing.Size(71, 20)
        Me.mnu_Reporting.Text = "Reporting"
        '
        'mnu_SapB1Interface
        '
        Me.mnu_SapB1Interface.Name = "mnu_SapB1Interface"
        Me.mnu_SapB1Interface.Size = New System.Drawing.Size(105, 20)
        Me.mnu_SapB1Interface.Text = "SAP B1 Interface"
        '
        'mnu_PisiSoftInterface
        '
        Me.mnu_PisiSoftInterface.Name = "mnu_PisiSoftInterface"
        Me.mnu_PisiSoftInterface.Size = New System.Drawing.Size(111, 20)
        Me.mnu_PisiSoftInterface.Text = "PISI Soft Interface"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.status})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1050, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UndoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(161, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(161, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'mnu_LockSystem
        '
        Me.mnu_LockSystem.Name = "mnu_LockSystem"
        Me.mnu_LockSystem.Size = New System.Drawing.Size(183, 22)
        Me.mnu_LockSystem.Text = "Lock System"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(121, 17)
        Me.status.Text = "ToolStripStatusLabel1"
        '
        'ANapps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "ANapps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PTAN System Application"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mnu_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_spFile_001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_System As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_LockSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_LockApplication As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_ChangeMyPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_spSystem_001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_AddNewUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_ChangeUserDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_RemoveUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_spSystem_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_UserManagement As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_OfficeModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_ProcessingFloorModule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_DataProcessing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_DataRevision As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_SystemQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_UserQuery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Reporting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_SapB1Interface As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_PisiSoftInterface As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents status As System.Windows.Forms.ToolStripStatusLabel

End Class
