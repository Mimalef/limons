<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Explorer
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Explorer))
        Me.Toolbar = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LargeIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SmallIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TreeView = New System.Windows.Forms.TreeView
        Me.ListView = New System.Windows.Forms.ListView
        Me.RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RightClickView = New System.Windows.Forms.ToolStripMenuItem
        Me.RightClickViewLargeIcon = New System.Windows.Forms.ToolStripMenuItem
        Me.RightClickViewDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.RightClickViewSmallIcon = New System.Windows.Forms.ToolStripMenuItem
        Me.RightClickViewList = New System.Windows.Forms.ToolStripMenuItem
        Me.RightClickViewTile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.RightClickNew = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.RightClickCut = New System.Windows.Forms.ToolStripMenuItem
        Me.RightClickCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.RightClickPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.Large = New System.Windows.Forms.ImageList(Me.components)
        Me.Small = New System.Windows.Forms.ImageList(Me.components)
        Me.AddressBar = New System.Windows.Forms.Label
        Me.TreeViewImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Toolbar.SuspendLayout()
        Me.RightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(632, 24)
        Me.Toolbar.TabIndex = 0
        Me.Toolbar.Text = "Toolbar"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CloseToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PaseToolStripMenuItem, Me.ToolStripMenuItem1, Me.SearchToolStripMenuItem, Me.FindFileToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PaseToolStripMenuItem
        '
        Me.PaseToolStripMenuItem.Image = CType(resources.GetObject("PaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PaseToolStripMenuItem.Name = "PaseToolStripMenuItem"
        Me.PaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PaseToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PaseToolStripMenuItem.Text = "&Paste"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 6)
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SearchToolStripMenuItem.Text = "Find &Folder"
        '
        'FindFileToolStripMenuItem
        '
        Me.FindFileToolStripMenuItem.Name = "FindFileToolStripMenuItem"
        Me.FindFileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.FindFileToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FindFileToolStripMenuItem.Text = "Find Fil&e"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeIconToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.SmallIconToolStripMenuItem, Me.ListToolStripMenuItem, Me.TileToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'LargeIconToolStripMenuItem
        '
        Me.LargeIconToolStripMenuItem.Checked = True
        Me.LargeIconToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LargeIconToolStripMenuItem.Name = "LargeIconToolStripMenuItem"
        Me.LargeIconToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.LargeIconToolStripMenuItem.Text = "&Large Icon"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.DetailsToolStripMenuItem.Text = "&Details"
        '
        'SmallIconToolStripMenuItem
        '
        Me.SmallIconToolStripMenuItem.Name = "SmallIconToolStripMenuItem"
        Me.SmallIconToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SmallIconToolStripMenuItem.Text = "&Small Icon"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ListToolStripMenuItem.Text = "Li&st"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.TileToolStripMenuItem.Text = "&Tile"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'TreeView
        '
        Me.TreeView.BackColor = System.Drawing.Color.Turquoise
        Me.TreeView.ImageIndex = 1
        Me.TreeView.ImageList = Me.TreeViewImageList
        Me.TreeView.Location = New System.Drawing.Point(0, 24)
        Me.TreeView.Name = "TreeView"
        Me.TreeView.SelectedImageIndex = 0
        Me.TreeView.Size = New System.Drawing.Size(160, 423)
        Me.TreeView.TabIndex = 1
        '
        'ListView
        '
        Me.ListView.ContextMenuStrip = Me.RightClick
        Me.ListView.LargeImageList = Me.Large
        Me.ListView.Location = New System.Drawing.Point(160, 43)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(472, 404)
        Me.ListView.SmallImageList = Me.Small
        Me.ListView.TabIndex = 2
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'RightClick
        '
        Me.RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RightClickView, Me.ToolStripMenuItem2, Me.RightClickNew, Me.ToolStripMenuItem3, Me.RightClickCut, Me.RightClickCopy, Me.RightClickPaste})
        Me.RightClick.Name = "RightClick"
        Me.RightClick.Size = New System.Drawing.Size(102, 126)
        Me.RightClick.Text = "Right Click"
        '
        'RightClickView
        '
        Me.RightClickView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RightClickViewLargeIcon, Me.RightClickViewDetails, Me.RightClickViewSmallIcon, Me.RightClickViewList, Me.RightClickViewTile})
        Me.RightClickView.Name = "RightClickView"
        Me.RightClickView.Size = New System.Drawing.Size(101, 22)
        Me.RightClickView.Text = "View"
        '
        'RightClickViewLargeIcon
        '
        Me.RightClickViewLargeIcon.Checked = True
        Me.RightClickViewLargeIcon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RightClickViewLargeIcon.Name = "RightClickViewLargeIcon"
        Me.RightClickViewLargeIcon.Size = New System.Drawing.Size(122, 22)
        Me.RightClickViewLargeIcon.Text = "LargeIcon"
        '
        'RightClickViewDetails
        '
        Me.RightClickViewDetails.Name = "RightClickViewDetails"
        Me.RightClickViewDetails.Size = New System.Drawing.Size(122, 22)
        Me.RightClickViewDetails.Text = "Details"
        '
        'RightClickViewSmallIcon
        '
        Me.RightClickViewSmallIcon.Name = "RightClickViewSmallIcon"
        Me.RightClickViewSmallIcon.Size = New System.Drawing.Size(122, 22)
        Me.RightClickViewSmallIcon.Text = "SmallIcon"
        '
        'RightClickViewList
        '
        Me.RightClickViewList.Name = "RightClickViewList"
        Me.RightClickViewList.Size = New System.Drawing.Size(122, 22)
        Me.RightClickViewList.Text = "List"
        '
        'RightClickViewTile
        '
        Me.RightClickViewTile.Name = "RightClickViewTile"
        Me.RightClickViewTile.Size = New System.Drawing.Size(122, 22)
        Me.RightClickViewTile.Text = "Tile"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(98, 6)
        '
        'RightClickNew
        '
        Me.RightClickNew.Image = CType(resources.GetObject("RightClickNew.Image"), System.Drawing.Image)
        Me.RightClickNew.Name = "RightClickNew"
        Me.RightClickNew.Size = New System.Drawing.Size(101, 22)
        Me.RightClickNew.Text = "New"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(98, 6)
        '
        'RightClickCut
        '
        Me.RightClickCut.Image = CType(resources.GetObject("RightClickCut.Image"), System.Drawing.Image)
        Me.RightClickCut.Name = "RightClickCut"
        Me.RightClickCut.Size = New System.Drawing.Size(101, 22)
        Me.RightClickCut.Text = "Cut"
        '
        'RightClickCopy
        '
        Me.RightClickCopy.Image = CType(resources.GetObject("RightClickCopy.Image"), System.Drawing.Image)
        Me.RightClickCopy.Name = "RightClickCopy"
        Me.RightClickCopy.Size = New System.Drawing.Size(101, 22)
        Me.RightClickCopy.Text = "Copy"
        '
        'RightClickPaste
        '
        Me.RightClickPaste.Image = CType(resources.GetObject("RightClickPaste.Image"), System.Drawing.Image)
        Me.RightClickPaste.Name = "RightClickPaste"
        Me.RightClickPaste.Size = New System.Drawing.Size(101, 22)
        Me.RightClickPaste.Text = "Paste"
        '
        'Large
        '
        Me.Large.ImageStream = CType(resources.GetObject("Large.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Large.TransparentColor = System.Drawing.Color.Transparent
        Me.Large.Images.SetKeyName(0, "folder.png")
        Me.Large.Images.SetKeyName(1, "document.png")
        '
        'Small
        '
        Me.Small.ImageStream = CType(resources.GetObject("Small.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Small.TransparentColor = System.Drawing.Color.Transparent
        Me.Small.Images.SetKeyName(0, "folder16.png")
        Me.Small.Images.SetKeyName(1, "document16.png")
        '
        'AddressBar
        '
        Me.AddressBar.BackColor = System.Drawing.Color.White
        Me.AddressBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AddressBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AddressBar.Location = New System.Drawing.Point(160, 24)
        Me.AddressBar.Name = "AddressBar"
        Me.AddressBar.Size = New System.Drawing.Size(472, 19)
        Me.AddressBar.TabIndex = 3
        Me.AddressBar.Text = "AddressBar"
        '
        'TreeViewImageList
        '
        Me.TreeViewImageList.ImageStream = CType(resources.GetObject("TreeViewImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TreeViewImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TreeViewImageList.Images.SetKeyName(0, "folder16G.png")
        Me.TreeViewImageList.Images.SetKeyName(1, "folder16.png")
        '
        'Explorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(632, 446)
        Me.ContextMenuStrip = Me.RightClick
        Me.Controls.Add(Me.AddressBar)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.TreeView)
        Me.Controls.Add(Me.Toolbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Toolbar
        Me.MinimumSize = New System.Drawing.Size(320, 240)
        Me.Name = "Explorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diger"
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.RightClick.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Toolbar As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView As System.Windows.Forms.TreeView
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents RightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RightClickCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Small As System.Windows.Forms.ImageList
    Friend WithEvents Large As System.Windows.Forms.ImageList
    Friend WithEvents LargeIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RightClickPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RightClickView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickViewLargeIcon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickViewDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickViewSmallIcon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickViewList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClickViewTile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddressBar As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeViewImageList As System.Windows.Forms.ImageList
End Class
