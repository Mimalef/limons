
'PaintMe 0.2.7
'Graphics painting program like MSPaint or maybe better!
'2012/12/20 - 2012/12/29
'Mim. Alef.

Public Class Painter

#Region "Declare"

    Dim Graphic As Graphics
    Dim PenColor As Pen = Pens.White
    Dim BrushColor As Brush = Brushes.Turquoise
    Dim Drawing As Boolean = False
    Dim Tool As String
    Dim MouseX As Single
    Dim MouseY As Single
    Dim PreMouseX As Single
    Dim PreMouseY As Single
    Dim BMP As Bitmap
    Dim MainFont As Font

#End Region

#Region "Handles"

    Private Sub Painter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        PenColor = New Pen(Color.Turquoise, 12)
        MainFont = New Font(WordBox.Font.Name, CSng(SizeBox.Text))

        NewCanvas()

    End Sub

    Private Sub Painter_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Canvas.Width = Me.Width - 59
        Canvas.Height = Me.Height - 85

        NewCanvas()

    End Sub

    Private Sub SelectTool(ByVal Sender As System.Windows.Forms.ToolStripButton, ByVal EventArgs As System.EventArgs) Handles PencilButton.Click, LineButton.Click, EraserButton.Click, BrushButton.Click, EllipseButton.Click, RectangleButton.Click, TextButton.Click

        DisableTool()
        Tool = Sender.Text
        Sender.Enabled = False

        Select Case Sender.Text
            Case "Ellipse", "Rectangle"
                ColorButton.Visible = True
                FilledBox.Visible = True
                SizeBox.Visible = True

            Case "Line", "Brush"
                ColorButton.Visible = True
                SizeBox.Visible = True

            Case "Pencil"
                ColorButton.Visible = True

            Case "Eraser"
                SizeBox.Visible = True

            Case "Text"
                ColorButton.Visible = True
                WordBox.Visible = True
                SizeBox.Visible = True
                FormatButton.Visible = True

        End Select

    End Sub

    Private Sub Canvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Canvas.MouseDown

        Drawing = True

        MouseX = e.X
        MouseY = e.Y

    End Sub

    Private Sub Canvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Canvas.MouseMove

        If Drawing = True Then
            Select Case Tool
                Case "Pencil"
                    Line(New Pen(PenColor.Color, 1), e.X, e.Y, PreMouseX, PreMouseY)
                Case "Eraser"
                    Ellipse(New SolidBrush(Color.White), e.X, e.Y, e.X + CSng(SizeBox.Text), e.Y + CSng(SizeBox.Text))
                Case "Brush"
                    Ellipse(BrushColor, e.X, e.Y, e.X + CSng(SizeBox.Text), e.Y + CSng(SizeBox.Text))

            End Select
        End If

        PreMouseX = e.X
        PreMouseY = e.Y

    End Sub

    Private Sub Canvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Canvas.MouseUp

        If Drawing = True Then

            Select Case Tool

                Case "Line"
                    Line(PenColor, MouseX, MouseY, e.X, e.Y)

                Case "Rectangle"
                    If FilledBox.Text = "Filled" Then
                        Rectangle(BrushColor, MouseX, MouseY, e.X, e.Y)
                    ElseIf FilledBox.Text = "Empty" Then
                        Rectangle(PenColor, MouseX, MouseY, e.X, e.Y)
                    End If

                Case "Ellipse"
                    If FilledBox.Text = "Filled" Then
                        Ellipse(BrushColor, MouseX, MouseY, e.X, e.Y)
                    ElseIf FilledBox.Text = "Empty" Then
                        Ellipse(PenColor, MouseX, MouseY, e.X, e.Y)
                    End If

                Case "Text"
                    Written(WordBox.Text, MainFont, BrushColor, e.X, e.Y)

            End Select
        End If

        Drawing = False

    End Sub

    Private Sub ColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorButton.Click, ColorLabel.Click

        If ColorBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            PenColor = New Drawing.Pen(ColorBox.Color, CSng(SizeBox.Text))
            BrushColor = New SolidBrush(ColorBox.Color)
            ColorLabel.BackColor = ColorBox.Color
        End If

    End Sub

    Private Sub FormatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatButton.Click

        FontDialog.Font = MainFont

        If FontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            MainFont = FontDialog.Font
        End If

    End Sub

    Private Sub SizeBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SizeBox.TextChanged

        PenColor = New Pen(PenColor.Color, CSng(SizeBox.Text))
        MainFont = New Font(WordBox.Font.Name, CSng(SizeBox.Text))

    End Sub

    Private Sub Painter_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Main.Visible = True

    End Sub

#End Region

#Region "SubPrograms"

    Private Sub DisableTool()

        FilledBox.Visible = False
        ColorButton.Visible = False
        SizeBox.Visible = False
        WordBox.Visible = False
        FormatButton.Visible = False

        PencilButton.Enabled = True
        EraserButton.Enabled = True
        BrushButton.Enabled = True
        LineButton.Enabled = True
        EllipseButton.Enabled = True
        RectangleButton.Enabled = True
        TextButton.Enabled = True

    End Sub

    Private Sub NewCanvas()

        BMP = New Bitmap(Canvas.Width, Canvas.Height)
        Graphic = Graphics.FromImage(BMP)
        Graphic.Clear(Canvas.BackColor)
        Canvas.Image = BMP

    End Sub

#End Region

#Region "Tools"

    Public Sub Line(ByVal Pen As Drawing.Pen, ByVal X1 As Single, ByVal y1 As Single, ByVal X2 As Single, ByVal y2 As Single)

        Graphic.DrawLine(Pen, X1, y1, X2, y2)
        Canvas.Image = BMP

    End Sub

    Public Sub Ellipse(ByVal Pen As Pen, ByVal X As Single, ByVal Y As Single, ByVal W As Single, ByVal H As Single)

        W = W - X
        H = H - Y

        Graphic.DrawEllipse(PenColor, X, Y, W, H)
        Canvas.Image = BMP

    End Sub

    Public Sub Ellipse(ByVal Pen As Brush, ByVal X As Single, ByVal Y As Single, ByVal W As Single, ByVal H As Single)

        W = W - X
        H = H - Y

        Graphic.FillEllipse(Pen, X, Y, W, H)
        Canvas.Image = BMP
    End Sub

    Public Sub Rectangle(ByVal Pen As Pen, ByVal X As Single, ByVal Y As Single, ByVal W As Single, ByVal H As Single)

        W = W - X
        H = H - Y

        Graphic.DrawRectangle(PenColor, X, Y, W, H)
        Canvas.Image = BMP
    End Sub

    Public Sub Rectangle(ByVal Pen As Brush, ByVal X As Single, ByVal Y As Single, ByVal W As Single, ByVal H As Single)

        W = W - X
        H = H - Y

        Graphic.FillRectangle(Pen, X, Y, W, H)
        Canvas.Image = BMP
    End Sub

    Public Sub Written(ByVal Text As String, ByVal Font As Font, ByVal brush As Brush, ByVal X As Single, ByVal Y As Single)

        Graphic.DrawString(Text, Font, brush, X, Y)
        Canvas.Image = BMP

    End Sub

#End Region

#Region "Right Click"

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        NewCanvas()

    End Sub

    Private Sub OpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenButton.Click

        If OpenDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            BMP = New Bitmap(OpenDialog.FileName)
            Graphic = Graphics.FromImage(BMP)
            Canvas.Image = BMP
        End If

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If SaveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Canvas.Image.Save(SaveDialog.FileName)
        End If

    End Sub

    Private Sub PrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage

        e.Graphics.DrawImage(Canvas.Image, e.MarginBounds.Location)

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        If PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument.PrinterSettings = PrintDialog.PrinterSettings
            PrintDocument.Print()
        End If

    End Sub

    Private Sub PrintPreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewButton.Click

        PrintPreviewDialog.Document = PrintDocument
        PrintPreviewDialog.ShowDialog()

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click

        Close()

    End Sub

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click

        MsgBox("Paintme" & vbNewLine & "Version 0.2.7" & vbNewLine & "Copyright 2012 by Mojtaba Ahmadi" & vbNewLine & "and With thank to Ali Arabi" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & "This product is under the term of The GNU General Public License (GPL).", MsgBoxStyle.OkOnly, "Paintme About")

    End Sub

#End Region

End Class