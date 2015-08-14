<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wordpad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wordpad))
        Me.Menubar = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReplceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormatBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RichText = New System.Windows.Forms.RichTextBox
        Me.RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog = New System.Windows.Forms.FontDialog
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.PreviewDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.Toolbar = New System.Windows.Forms.ToolStrip
        Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonOpen = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonPreview = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonCut = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonPaste = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonDelete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonUndo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonRedo = New System.Windows.Forms.ToolStripButton
        Me.FormatBar = New System.Windows.Forms.ToolStrip
        Me.ToolStripComboBoxFontName = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripComboBoxFontSize = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonBold = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonItalic = New System.Windows.Forms.ToolStripButton
        Me.ToolStipButtonUnderline = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonFontColor = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonAlignLeft = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonAlignCenter = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonAlignRight = New System.Windows.Forms.ToolStripButton
        Me.ColorsDialog = New System.Windows.Forms.ColorDialog
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument
        Me.Menubar.SuspendLayout()
        Me.RightClick.SuspendLayout()
        Me.Toolbar.SuspendLayout()
        Me.FormatBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menubar
        '
        Me.Menubar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.Menubar.Location = New System.Drawing.Point(0, 0)
        Me.Menubar.Name = "Menubar"
        Me.Menubar.Size = New System.Drawing.Size(632, 24)
        Me.Menubar.TabIndex = 0
        Me.Menubar.Text = "Menubar"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.ToolStripMenuItem3, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "&Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(149, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripMenuItem2, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.ToolStripMenuItem4, Me.FindToolStripMenuItem, Me.ReplceToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UndoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(148, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Enabled = False
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Enabled = False
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Enabled = False
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Enabled = False
        Me.DeleteToolStripMenuItem1.Image = CType(resources.GetObject("DeleteToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.DeleteToolStripMenuItem1.Text = "&Delete"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(148, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FindToolStripMenuItem.Text = "&Find"
        '
        'ReplceToolStripMenuItem
        '
        Me.ReplceToolStripMenuItem.Name = "ReplceToolStripMenuItem"
        Me.ReplceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ReplceToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ReplceToolStripMenuItem.Text = "R&eplace"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolbarToolStripMenuItem, Me.FormatBarToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ToolbarToolStripMenuItem
        '
        Me.ToolbarToolStripMenuItem.Checked = True
        Me.ToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolbarToolStripMenuItem.Name = "ToolbarToolStripMenuItem"
        Me.ToolbarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ToolbarToolStripMenuItem.Text = "&Toolbar"
        '
        'FormatBarToolStripMenuItem
        '
        Me.FormatBarToolStripMenuItem.Name = "FormatBarToolStripMenuItem"
        Me.FormatBarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.FormatBarToolStripMenuItem.Text = "&Format Bar"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordWrapToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FormatToolStripMenuItem.Text = "F&ormat"
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.Checked = True
        Me.WordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.WordWrapToolStripMenuItem.Text = "&Word Wrap"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
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
        'RichText
        '
        Me.RichText.ContextMenuStrip = Me.RightClick
        Me.RichText.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RichText.Location = New System.Drawing.Point(0, 49)
        Me.RichText.Name = "RichText"
        Me.RichText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichText.Size = New System.Drawing.Size(632, 398)
        Me.RichText.TabIndex = 1
        Me.RichText.Text = ""
        '
        'RightClick
        '
        Me.RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem1, Me.CopyToolStripMenuItem1, Me.PasteToolStripMenuItem1, Me.DeleteToolStripMenuItem})
        Me.RightClick.Name = "RightClick"
        Me.RightClick.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.RightClick.Size = New System.Drawing.Size(106, 92)
        '
        'CutToolStripMenuItem1
        '
        Me.CutToolStripMenuItem1.Enabled = False
        Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.CutToolStripMenuItem1.Text = "Cut"
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Enabled = False
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Enabled = False
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.PasteToolStripMenuItem1.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Enabled = False
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'OpenDialog
        '
        Me.OpenDialog.Filter = "Text Document(*.txt)|*.txt|All Files|*.*"
        '
        'SaveDialog
        '
        Me.SaveDialog.Filter = "Text Document(*.txt)|*.txt|All Files|*.*"
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PreviewDialog
        '
        Me.PreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreviewDialog.Enabled = True
        Me.PreviewDialog.Icon = CType(resources.GetObject("PreviewDialog.Icon"), System.Drawing.Icon)
        Me.PreviewDialog.Name = "PrintPreview"
        Me.PreviewDialog.Visible = False
        '
        'Toolbar
        '
        Me.Toolbar.AutoSize = False
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNew, Me.ToolStripButtonOpen, Me.ToolStripButtonSave, Me.ToolStripSeparator1, Me.ToolStripButtonPrint, Me.ToolStripButtonPreview, Me.ToolStripSeparator2, Me.ToolStripButtonCut, Me.ToolStripButtonCopy, Me.ToolStripButtonPaste, Me.ToolStripButtonDelete, Me.ToolStripSeparator3, Me.ToolStripButtonUndo, Me.ToolStripButtonRedo})
        Me.Toolbar.Location = New System.Drawing.Point(0, 24)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(632, 25)
        Me.Toolbar.TabIndex = 2
        Me.Toolbar.Text = "Toolbar"
        '
        'ToolStripButtonNew
        '
        Me.ToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNew.Image = CType(resources.GetObject("ToolStripButtonNew.Image"), System.Drawing.Image)
        Me.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNew.Name = "ToolStripButtonNew"
        Me.ToolStripButtonNew.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonNew.Text = "New"
        '
        'ToolStripButtonOpen
        '
        Me.ToolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonOpen.Image = CType(resources.GetObject("ToolStripButtonOpen.Image"), System.Drawing.Image)
        Me.ToolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonOpen.Name = "ToolStripButtonOpen"
        Me.ToolStripButtonOpen.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonOpen.Text = "Open"
        '
        'ToolStripButtonSave
        '
        Me.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSave.Image = CType(resources.GetObject("ToolStripButtonSave.Image"), System.Drawing.Image)
        Me.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSave.Name = "ToolStripButtonSave"
        Me.ToolStripButtonSave.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonSave.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonPrint
        '
        Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPrint.Image = CType(resources.GetObject("ToolStripButtonPrint.Image"), System.Drawing.Image)
        Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
        Me.ToolStripButtonPrint.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPrint.Text = "Print"
        '
        'ToolStripButtonPreview
        '
        Me.ToolStripButtonPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPreview.Image = CType(resources.GetObject("ToolStripButtonPreview.Image"), System.Drawing.Image)
        Me.ToolStripButtonPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPreview.Name = "ToolStripButtonPreview"
        Me.ToolStripButtonPreview.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPreview.Text = "Print Preview"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonCut
        '
        Me.ToolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCut.Enabled = False
        Me.ToolStripButtonCut.Image = CType(resources.GetObject("ToolStripButtonCut.Image"), System.Drawing.Image)
        Me.ToolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCut.Name = "ToolStripButtonCut"
        Me.ToolStripButtonCut.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonCut.Text = "Cut"
        '
        'ToolStripButtonCopy
        '
        Me.ToolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCopy.Enabled = False
        Me.ToolStripButtonCopy.Image = CType(resources.GetObject("ToolStripButtonCopy.Image"), System.Drawing.Image)
        Me.ToolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
        Me.ToolStripButtonCopy.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonCopy.Text = "Copy"
        '
        'ToolStripButtonPaste
        '
        Me.ToolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPaste.Enabled = False
        Me.ToolStripButtonPaste.Image = CType(resources.GetObject("ToolStripButtonPaste.Image"), System.Drawing.Image)
        Me.ToolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPaste.Name = "ToolStripButtonPaste"
        Me.ToolStripButtonPaste.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPaste.Text = "Paste"
        '
        'ToolStripButtonDelete
        '
        Me.ToolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDelete.Enabled = False
        Me.ToolStripButtonDelete.Image = CType(resources.GetObject("ToolStripButtonDelete.Image"), System.Drawing.Image)
        Me.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDelete.Name = "ToolStripButtonDelete"
        Me.ToolStripButtonDelete.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonDelete.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonUndo
        '
        Me.ToolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonUndo.Image = CType(resources.GetObject("ToolStripButtonUndo.Image"), System.Drawing.Image)
        Me.ToolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonUndo.Name = "ToolStripButtonUndo"
        Me.ToolStripButtonUndo.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonUndo.Text = "Undo"
        '
        'ToolStripButtonRedo
        '
        Me.ToolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRedo.Image = CType(resources.GetObject("ToolStripButtonRedo.Image"), System.Drawing.Image)
        Me.ToolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRedo.Name = "ToolStripButtonRedo"
        Me.ToolStripButtonRedo.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRedo.Text = "Redo"
        '
        'FormatBar
        '
        Me.FormatBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FormatBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBoxFontName, Me.ToolStripComboBoxFontSize, Me.ToolStripSeparator4, Me.ToolStripButtonBold, Me.ToolStripButtonItalic, Me.ToolStipButtonUnderline, Me.ToolStripButtonFontColor, Me.ToolStripSeparator5, Me.ToolStripButtonAlignLeft, Me.ToolStripButtonAlignCenter, Me.ToolStripButtonAlignRight})
        Me.FormatBar.Location = New System.Drawing.Point(0, 49)
        Me.FormatBar.Name = "FormatBar"
        Me.FormatBar.Size = New System.Drawing.Size(632, 25)
        Me.FormatBar.TabIndex = 3
        Me.FormatBar.Text = "Format Bar"
        Me.FormatBar.Visible = False
        '
        'ToolStripComboBoxFontName
        '
        Me.ToolStripComboBoxFontName.Name = "ToolStripComboBoxFontName"
        Me.ToolStripComboBoxFontName.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripComboBoxFontSize
        '
        Me.ToolStripComboBoxFontSize.Items.AddRange(New Object() {"8", "9", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
        Me.ToolStripComboBoxFontSize.Name = "ToolStripComboBoxFontSize"
        Me.ToolStripComboBoxFontSize.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonBold
        '
        Me.ToolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonBold.Image = CType(resources.GetObject("ToolStripButtonBold.Image"), System.Drawing.Image)
        Me.ToolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBold.Name = "ToolStripButtonBold"
        Me.ToolStripButtonBold.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonBold.Text = "Bold"
        '
        'ToolStripButtonItalic
        '
        Me.ToolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonItalic.Image = CType(resources.GetObject("ToolStripButtonItalic.Image"), System.Drawing.Image)
        Me.ToolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonItalic.Name = "ToolStripButtonItalic"
        Me.ToolStripButtonItalic.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonItalic.Text = "Italic"
        '
        'ToolStipButtonUnderline
        '
        Me.ToolStipButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStipButtonUnderline.Image = CType(resources.GetObject("ToolStipButtonUnderline.Image"), System.Drawing.Image)
        Me.ToolStipButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStipButtonUnderline.Name = "ToolStipButtonUnderline"
        Me.ToolStipButtonUnderline.Size = New System.Drawing.Size(23, 22)
        Me.ToolStipButtonUnderline.Text = "Underline"
        '
        'ToolStripButtonFontColor
        '
        Me.ToolStripButtonFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFontColor.Image = CType(resources.GetObject("ToolStripButtonFontColor.Image"), System.Drawing.Image)
        Me.ToolStripButtonFontColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFontColor.Name = "ToolStripButtonFontColor"
        Me.ToolStripButtonFontColor.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonFontColor.Text = "Font Color"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonAlignLeft
        '
        Me.ToolStripButtonAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAlignLeft.Image = CType(resources.GetObject("ToolStripButtonAlignLeft.Image"), System.Drawing.Image)
        Me.ToolStripButtonAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAlignLeft.Name = "ToolStripButtonAlignLeft"
        Me.ToolStripButtonAlignLeft.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonAlignLeft.Text = "Align Left"
        '
        'ToolStripButtonAlignCenter
        '
        Me.ToolStripButtonAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAlignCenter.Image = CType(resources.GetObject("ToolStripButtonAlignCenter.Image"), System.Drawing.Image)
        Me.ToolStripButtonAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAlignCenter.Name = "ToolStripButtonAlignCenter"
        Me.ToolStripButtonAlignCenter.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonAlignCenter.Text = "Align Center"
        '
        'ToolStripButtonAlignRight
        '
        Me.ToolStripButtonAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAlignRight.Image = CType(resources.GetObject("ToolStripButtonAlignRight.Image"), System.Drawing.Image)
        Me.ToolStripButtonAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAlignRight.Name = "ToolStripButtonAlignRight"
        Me.ToolStripButtonAlignRight.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonAlignRight.Text = "Align Right"
        '
        'PrintDocument
        '
        '
        'Wordpad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 446)
        Me.Controls.Add(Me.FormatBar)
        Me.Controls.Add(Me.Toolbar)
        Me.Controls.Add(Me.RichText)
        Me.Controls.Add(Me.Menubar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menubar
        Me.Name = "Wordpad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Texman"
        Me.Menubar.ResumeLayout(False)
        Me.Menubar.PerformLayout()
        Me.RightClick.ResumeLayout(False)
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.FormatBar.ResumeLayout(False)
        Me.FormatBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menubar As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichText As System.Windows.Forms.RichTextBox
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents WordWrapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents FormatBar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripComboBoxFontName As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripComboBoxFontSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStipButtonUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonAlignLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAlignCenter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAlignRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButtonDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonFontColor As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColorsDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
End Class
