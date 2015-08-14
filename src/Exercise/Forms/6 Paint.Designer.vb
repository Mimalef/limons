<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Painter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Painter))
        Me.Canvas = New System.Windows.Forms.PictureBox
        Me.RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewButton = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenButton = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveButton = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintButton = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewButton = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitButton = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutButton = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolBox = New System.Windows.Forms.ToolStrip
        Me.ColorLabel = New System.Windows.Forms.ToolStripLabel
        Me.PencilButton = New System.Windows.Forms.ToolStripButton
        Me.EraserButton = New System.Windows.Forms.ToolStripButton
        Me.BrushButton = New System.Windows.Forms.ToolStripButton
        Me.LineButton = New System.Windows.Forms.ToolStripButton
        Me.EllipseButton = New System.Windows.Forms.ToolStripButton
        Me.RectangleButton = New System.Windows.Forms.ToolStripButton
        Me.TextButton = New System.Windows.Forms.ToolStripButton
        Me.ToolOption = New System.Windows.Forms.ToolStrip
        Me.ColorButton = New System.Windows.Forms.ToolStripButton
        Me.FormatButton = New System.Windows.Forms.ToolStripButton
        Me.FilledBox = New System.Windows.Forms.ToolStripComboBox
        Me.WordBox = New System.Windows.Forms.ToolStripTextBox
        Me.SizeBox = New System.Windows.Forms.ToolStripComboBox
        Me.ColorBox = New System.Windows.Forms.ColorDialog
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.FontDialog = New System.Windows.Forms.FontDialog
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RightClick.SuspendLayout()
        Me.ToolBox.SuspendLayout()
        Me.ToolOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'Canvas
        '
        Me.Canvas.BackColor = System.Drawing.Color.White
        Me.Canvas.ContextMenuStrip = Me.RightClick
        Me.Canvas.Location = New System.Drawing.Point(50, 50)
        Me.Canvas.Name = "Canvas"
        Me.Canvas.Size = New System.Drawing.Size(542, 396)
        Me.Canvas.TabIndex = 1
        Me.Canvas.TabStop = False
        '
        'RightClick
        '
        Me.RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.OpenButton, Me.SaveButton, Me.ToolStripMenuItem1, Me.PrintButton, Me.PrintPreviewButton, Me.ToolStripMenuItem2, Me.ExitButton, Me.AboutButton})
        Me.RightClick.Name = "RightClick"
        Me.RightClick.Size = New System.Drawing.Size(141, 170)
        '
        'NewButton
        '
        Me.NewButton.Image = CType(resources.GetObject("NewButton.Image"), System.Drawing.Image)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewButton.Size = New System.Drawing.Size(140, 22)
        Me.NewButton.Text = "&New"
        '
        'OpenButton
        '
        Me.OpenButton.Image = CType(resources.GetObject("OpenButton.Image"), System.Drawing.Image)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenButton.Size = New System.Drawing.Size(140, 22)
        Me.OpenButton.Text = "&Open"
        '
        'SaveButton
        '
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveButton.Size = New System.Drawing.Size(140, 22)
        Me.SaveButton.Text = "&Save"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 6)
        '
        'PrintButton
        '
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintButton.Size = New System.Drawing.Size(140, 22)
        Me.PrintButton.Text = "&Print"
        '
        'PrintPreviewButton
        '
        Me.PrintPreviewButton.Image = CType(resources.GetObject("PrintPreviewButton.Image"), System.Drawing.Image)
        Me.PrintPreviewButton.Name = "PrintPreviewButton"
        Me.PrintPreviewButton.Size = New System.Drawing.Size(140, 22)
        Me.PrintPreviewButton.Text = "Print Pre&view"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(137, 6)
        '
        'ExitButton
        '
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitButton.Size = New System.Drawing.Size(140, 22)
        Me.ExitButton.Text = "&Exit"
        '
        'AboutButton
        '
        Me.AboutButton.Image = CType(resources.GetObject("AboutButton.Image"), System.Drawing.Image)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutButton.Size = New System.Drawing.Size(140, 22)
        Me.AboutButton.Text = "&About"
        '
        'ToolBox
        '
        Me.ToolBox.AutoSize = False
        Me.ToolBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolBox.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolBox.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.ToolBox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorLabel, Me.PencilButton, Me.EraserButton, Me.BrushButton, Me.LineButton, Me.EllipseButton, Me.RectangleButton, Me.TextButton})
        Me.ToolBox.Location = New System.Drawing.Point(0, 0)
        Me.ToolBox.Name = "ToolBox"
        Me.ToolBox.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolBox.Size = New System.Drawing.Size(50, 446)
        Me.ToolBox.TabIndex = 2
        Me.ToolBox.Text = "ToolStrip1"
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = False
        Me.ColorLabel.BackColor = System.Drawing.Color.Turquoise
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(45, 45)
        '
        'PencilButton
        '
        Me.PencilButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PencilButton.Image = CType(resources.GetObject("PencilButton.Image"), System.Drawing.Image)
        Me.PencilButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PencilButton.Name = "PencilButton"
        Me.PencilButton.Size = New System.Drawing.Size(48, 49)
        Me.PencilButton.Text = "Pencil"
        '
        'EraserButton
        '
        Me.EraserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EraserButton.Image = CType(resources.GetObject("EraserButton.Image"), System.Drawing.Image)
        Me.EraserButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EraserButton.Name = "EraserButton"
        Me.EraserButton.Size = New System.Drawing.Size(48, 49)
        Me.EraserButton.Text = "Eraser"
        '
        'BrushButton
        '
        Me.BrushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrushButton.Image = CType(resources.GetObject("BrushButton.Image"), System.Drawing.Image)
        Me.BrushButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrushButton.Name = "BrushButton"
        Me.BrushButton.Size = New System.Drawing.Size(48, 49)
        Me.BrushButton.Text = "Brush"
        '
        'LineButton
        '
        Me.LineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LineButton.Image = CType(resources.GetObject("LineButton.Image"), System.Drawing.Image)
        Me.LineButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LineButton.Name = "LineButton"
        Me.LineButton.Size = New System.Drawing.Size(48, 49)
        Me.LineButton.Text = "Line"
        '
        'EllipseButton
        '
        Me.EllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EllipseButton.Image = CType(resources.GetObject("EllipseButton.Image"), System.Drawing.Image)
        Me.EllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EllipseButton.Name = "EllipseButton"
        Me.EllipseButton.Size = New System.Drawing.Size(48, 49)
        Me.EllipseButton.Text = "Ellipse"
        '
        'RectangleButton
        '
        Me.RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RectangleButton.Image = CType(resources.GetObject("RectangleButton.Image"), System.Drawing.Image)
        Me.RectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RectangleButton.Name = "RectangleButton"
        Me.RectangleButton.Size = New System.Drawing.Size(48, 49)
        Me.RectangleButton.Text = "Rectangle"
        '
        'TextButton
        '
        Me.TextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TextButton.Image = CType(resources.GetObject("TextButton.Image"), System.Drawing.Image)
        Me.TextButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TextButton.Name = "TextButton"
        Me.TextButton.Size = New System.Drawing.Size(48, 49)
        Me.TextButton.Text = "Text"
        '
        'ToolOption
        '
        Me.ToolOption.AutoSize = False
        Me.ToolOption.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolOption.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.ToolOption.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorButton, Me.FormatButton, Me.FilledBox, Me.WordBox, Me.SizeBox})
        Me.ToolOption.Location = New System.Drawing.Point(50, 0)
        Me.ToolOption.Name = "ToolOption"
        Me.ToolOption.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolOption.Size = New System.Drawing.Size(542, 50)
        Me.ToolOption.TabIndex = 4
        Me.ToolOption.Text = "ToolStrip2"
        '
        'ColorButton
        '
        Me.ColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColorButton.Image = CType(resources.GetObject("ColorButton.Image"), System.Drawing.Image)
        Me.ColorButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(49, 47)
        Me.ColorButton.Text = "Color"
        Me.ColorButton.Visible = False
        '
        'FormatButton
        '
        Me.FormatButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FormatButton.Image = CType(resources.GetObject("FormatButton.Image"), System.Drawing.Image)
        Me.FormatButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FormatButton.Name = "FormatButton"
        Me.FormatButton.Size = New System.Drawing.Size(49, 47)
        Me.FormatButton.Text = "Format"
        Me.FormatButton.Visible = False
        '
        'FilledBox
        '
        Me.FilledBox.Items.AddRange(New Object() {"Filled", "Empty"})
        Me.FilledBox.Name = "FilledBox"
        Me.FilledBox.Size = New System.Drawing.Size(75, 50)
        Me.FilledBox.Text = "Empty"
        Me.FilledBox.Visible = False
        '
        'WordBox
        '
        Me.WordBox.Name = "WordBox"
        Me.WordBox.Size = New System.Drawing.Size(150, 50)
        Me.WordBox.Text = "Write something here"
        Me.WordBox.Visible = False
        '
        'SizeBox
        '
        Me.SizeBox.Items.AddRange(New Object() {"8", "10", "12", "14", "16", "18", "20", "24", "28", "32", "36", "40", "50", "60", "70"})
        Me.SizeBox.Name = "SizeBox"
        Me.SizeBox.Size = New System.Drawing.Size(75, 50)
        Me.SizeBox.Text = "28"
        Me.SizeBox.Visible = False
        '
        'OpenDialog
        '
        Me.OpenDialog.Filter = "JPG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif"
        '
        'SaveDialog
        '
        Me.SaveDialog.Filter = "Bitmap (*.bmp) |*.bmp"
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDocument
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'Painter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(592, 446)
        Me.Controls.Add(Me.ToolOption)
        Me.Controls.Add(Me.ToolBox)
        Me.Controls.Add(Me.Canvas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Painter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Painter"
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RightClick.ResumeLayout(False)
        Me.ToolBox.ResumeLayout(False)
        Me.ToolBox.PerformLayout()
        Me.ToolOption.ResumeLayout(False)
        Me.ToolOption.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Canvas As System.Windows.Forms.PictureBox
    Friend WithEvents ToolBox As System.Windows.Forms.ToolStrip
    Friend WithEvents PencilButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EraserButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrushButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LineButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EllipseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RectangleButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolOption As System.Windows.Forms.ToolStrip
    Friend WithEvents ColorButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColorBox As System.Windows.Forms.ColorDialog
    Friend WithEvents RightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilledBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SizeBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ColorLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents FormatButton As System.Windows.Forms.ToolStripButton
End Class
