
'Texman 0.3.6
'2012/12/01 - 2012/12/25
'A word processor like MS Notepad
'Mim. Alef.

Imports System.IO

Public Class Wordpad

#Region "Declare"

    Dim Pach As String = ""
    Dim H As Integer = 82
    Dim LineCounter As Integer = 0

#End Region

#Region "File"

    'New
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        RichText.Clear()
        Pach = ""
    End Sub

    'Open
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Pach = OpenDialog.FileName
            RichText.LoadFile(Pach, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    'Save
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If Pach = "" AndAlso SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Pach = SaveDialog.FileName
            RichText.SaveFile(Pach, RichTextBoxStreamType.PlainText)
        Else
            RichText.SaveFile(Pach, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    'Save as
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Pach = SaveDialog.FileName
            RichText.SaveFile(Pach, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    'PrintDocument
    Private Sub PrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage

        e.Graphics.DrawRectangle(Pens.Chocolate, e.MarginBounds)

        Dim MarginLeft As Integer = 0
        Dim MarginTop As Integer = 0
        Dim LineNumber As Integer = 0
        Dim PageSize As Integer = 0

        While LineCounter < RichText.Lines.Count - 1

            PageSize = LineNumber * RichText.Font.Height + RichText.Font.Height + e.MarginBounds.Top
            MarginTop = e.MarginBounds.Top + RichText.Font.Height * LineNumber
            MarginLeft = e.MarginBounds.Left
            If (PageSize > e.MarginBounds.Bottom) Then
                Exit While
            End If

            e.Graphics.DrawString(RichText.Lines(LineCounter), RichText.Font, Brushes.Black, MarginLeft, MarginTop)

            LineCounter += 1
            LineNumber += 1

        End While

        If (LineCounter < RichText.Lines.Count - 1) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If

    End Sub

    'Print
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click, ToolStripButtonPrint.Click
        PrintDialog.Document = PrintDocument
        If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument.PrinterSettings = PrintDialog.PrinterSettings
            PrintDocument.Print()
        End If
    End Sub

    'Print Preview
    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click, ToolStripButtonPreview.Click
        PreviewDialog.Document = PrintDocument
        PreviewDialog.ShowDialog()
    End Sub

    'Exit
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "Edit"

    'Undo
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichText.Undo()
    End Sub

    'Redo
    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichText.Redo()
    End Sub

    'Cut
    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.SetText(RichText.SelectedText)
        RichText.SelectedText = ""
    End Sub

    'Copy
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(RichText.SelectedText)
    End Sub

    'Paste
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichText.SelectedText = Clipboard.GetText
    End Sub

    'Delete
    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        RichText.SelectedText = ""
    End Sub

    'Find
    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click

        Dim Search As String
        Dim Where As String

        Search = InputBox("Find what: ", "Find")

        Where = InStr(RichText.Text, Search)

        If Where Then
            RichText.Focus()
            RichText.SelectionStart = Where - 1
            RichText.SelectionLength = Len(Search)
        Else
            MsgBox("Can't find " + "'" + Search + "'", MsgBoxStyle.Information, "Not Find")
        End If

    End Sub

    'Replace
    Private Sub ReplceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplceToolStripMenuItem.Click

        Dim Search As String
        Dim Where As String
        Dim Replace As String

        Search = InputBox("Find what: ", "Find")

        Replace = InputBox("Replace to: ", "Replace")

        Where = InStr(RichText.Text, Search)

        If Where Then
            RichText.Focus()
            RichText.SelectionStart = Where - 1
            RichText.SelectionLength = Len(Search)
            RichText.SelectedText = Replace
        Else
            MsgBox("Can't find " + "'" + Search + "'", MsgBoxStyle.Information, "Not Find")
        End If

    End Sub

#End Region

#Region "Veiw"

    'veiw toolbar
    Private Sub ToolbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolbarToolStripMenuItem.Click
        If Toolbar.Visible = True Then
            Toolbar.Visible = False
            ToolbarToolStripMenuItem.Checked = False
            'fit texbox size
            RichText.Top -= 22
            H -= 22
            RichText.Height = Me.Height - H
        Else
            Toolbar.Visible = True
            ToolbarToolStripMenuItem.Checked = True
            'fit texbox size
            RichText.Top += 22
            H += 22
            RichText.Height = Me.Height - H
        End If

    End Sub

    'veiw format bar
    Private Sub FormatBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatBarToolStripMenuItem.Click
        If FormatBar.Visible = True Then
            FormatBar.Visible = False
            FormatBarToolStripMenuItem.Checked = False
            'fit texbox size
            RichText.Top -= 22
            H -= 22
            RichText.Height = Me.Height - H
        Else
            FormatBar.Visible = True
            FormatBarToolStripMenuItem.Checked = True
            'fit texbox size
            RichText.Top += 22
            H += 22
            RichText.Height = Me.Height - H
        End If
    End Sub

#End Region

#Region "Format"

    'Word Wrap
    Private Sub WordWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordWrapToolStripMenuItem.Click
        If RichText.WordWrap = True Then
            RichText.WordWrap = False
            WordWrapToolStripMenuItem.Checked = False
        Else
            RichText.WordWrap = True
            WordWrapToolStripMenuItem.Checked = True
        End If
    End Sub

    'Font
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog.Font = RichText.Font
        If FontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichText.SelectionFont = FontDialog.Font
        End If
    End Sub

#End Region

#Region "Help"

    'About
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Texman" & vbNewLine & "Version 0.3.1" & vbNewLine & "Copyright 2012 by Mojtaba Ahmadi" & vbNewLine & "and With thank to Ali Arabi" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & "This product is under the term of The GNU General Public License (GPL).", MsgBoxStyle.OkOnly, "Texman About")
    End Sub

#End Region

#Region "Toolbar"

    'New File
    Private Sub ToolStripButtonNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonNew.Click
        RichText.Clear()
        Pach = ""
    End Sub

    'Open File
    Private Sub ToolStripButtonOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonOpen.Click
        If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Pach = OpenDialog.FileName
            RichText.LoadFile(Pach, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    'Save File
    Private Sub ToolStripButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonSave.Click
        If Pach = "" AndAlso SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Pach = SaveDialog.FileName
            RichText.SaveFile(Pach, RichTextBoxStreamType.PlainText)
        Else
            RichText.SaveFile(Pach, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    'Cut Button
    Private Sub ToolStripButtonCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonCut.Click
        Clipboard.SetText(RichText.SelectedText)
        RichText.SelectedText = ""
    End Sub

    'Copy Button
    Private Sub ToolStripButtonCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonCopy.Click
        Clipboard.SetText(RichText.SelectedText)
    End Sub

    'Paste Button
    Private Sub ToolStripButtonPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonPaste.Click
        RichText.SelectedText = Clipboard.GetText
    End Sub

    'Delete Button
    Private Sub ToolStripButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonDelete.Click
        RichText.SelectedText = ""
    End Sub

    'Undo Button
    Private Sub ToolStripButtonUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonUndo.Click
        RichText.Undo()
    End Sub

    'Redo Button
    Private Sub ToolStripButtonRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonRedo.Click
        RichText.Redo()
    End Sub

#End Region

#Region "Format Bar"

    Private Sub ToolStripComboBoxFontName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBoxFontName.TextChanged

        Dim ExistingFont As Font = RichText.SelectionFont

        For Each f As FontFamily In FontFamily.Families
            If ToolStripComboBoxFontName.Text = f.Name Then
                RichText.SelectionFont = New Font(f, ExistingFont.Size, ExistingFont.Style)
            End If
        Next

    End Sub

    Private Sub ToolStripComboBoxFontSize_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBoxFontSize.TextChanged

        Dim ExistingFont As Font = RichText.SelectionFont

        If ToolStripComboBoxFontSize.Text <> "" Then
            RichText.SelectionFont = New Font(ExistingFont.FontFamily, CInt(ToolStripComboBoxFontSize.Text), ExistingFont.Style)
        End If

    End Sub

    Private Sub ToolStripButtonBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonBold.Click
        Dim ExistingFont As Font = RichText.SelectionFont
        'Dim NewFontStyle As System.Drawing.FontStyle

        RichText.SelectionFont = New Font(ExistingFont, FontStyle.Bold)

    End Sub

    Private Sub ToolStripButtonItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonItalic.Click
        Dim ExistingFont As Font = RichText.SelectionFont
        'Dim NewFontStyle As System.Drawing.FontStyle

        RichText.SelectionFont = New Font(ExistingFont, FontStyle.Italic)

    End Sub

    Private Sub ToolStipButtonUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStipButtonUnderline.Click

        Dim ExistingFont As Font = RichText.SelectionFont
        'Dim NewFontStyle As System.Drawing.FontStyle

        RichText.SelectionFont = New Font(ExistingFont, FontStyle.Underline)

    End Sub

    Private Sub ToolStripButtonFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonFontColor.Click

        If ColorsDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichText.SelectionColor = ColorsDialog.Color
        End If

    End Sub

    Private Sub ToolStripButtonAlignLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAlignLeft.Click
        RichText.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButtonAlignCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAlignCenter.Click
        RichText.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButtonAlignRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAlignRight.Click
        RichText.SelectionAlignment = HorizontalAlignment.Right
    End Sub

#End Region

#Region "Right Click"

    'Cut
    Private Sub CutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem1.Click
        Clipboard.SetText(RichText.SelectedText)
        RichText.SelectedText = ""
    End Sub

    'Copy
    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click
        Clipboard.SetText(RichText.SelectedText)
    End Sub

    'Paste
    Private Sub PasteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem1.Click
        RichText.SelectedText = Clipboard.GetText
    End Sub

    'Delete
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        RichText.SelectedText = ""
    End Sub

#End Region

#Region "Other"

    'check clipboard for enable paste or not
    'first value for format bar
    Private Sub Wordpad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Clipboard.GetText = "" Then
            PasteToolStripMenuItem.Enabled = False
            PasteToolStripMenuItem1.Enabled = False
            ToolStripButtonPaste.Enabled = False
        Else
            PasteToolStripMenuItem.Enabled = True
            PasteToolStripMenuItem1.Enabled = True
            ToolStripButtonPaste.Enabled = True
        End If

        'Tool Strip Combo Box
        For Each f As FontFamily In FontFamily.Families
            ToolStripComboBoxFontName.Items.Add(f.Name)
        Next
        ToolStripComboBoxFontName.Text = RichText.Font.Name
        ToolStripComboBoxFontSize.Text = RichText.Font.Size

    End Sub

    'Fit textbox to form zize
    Private Sub Wordpad_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        RichText.Height = Me.Height - H
        RichText.Width = Me.Width - 8

    End Sub

    'back to main menu
    Private Sub Wordpad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Main.Visible = True

    End Sub

    'enable cut, copy, past, delete
    Private Sub txtShow_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichText.TextChanged

        Dim StripMenuItems() As ToolStripMenuItem = {CutToolStripMenuItem, CutToolStripMenuItem1, CopyToolStripMenuItem, CopyToolStripMenuItem1, PasteToolStripMenuItem, PasteToolStripMenuItem1, DeleteToolStripMenuItem, DeleteToolStripMenuItem1}
        Dim StripButtons() As ToolStripButton = {ToolStripButtonCut, ToolStripButtonCopy, ToolStripButtonPaste, ToolStripButtonDelete}

        If RichText.Text = "" Then
            For Each Item As ToolStripMenuItem In StripMenuItems
                Item.Enabled = False
            Next
            For Each Item As ToolStripButton In StripButtons
                Item.Enabled = False
            Next
        Else
            For Each Item As ToolStripMenuItem In StripMenuItems
                Item.Enabled = True
            Next
            For Each Item As ToolStripButton In StripButtons
                Item.Enabled = True
            Next
        End If

        If Clipboard.GetText = "" Then
            PasteToolStripMenuItem.Enabled = False
            PasteToolStripMenuItem1.Enabled = False
            ToolStripButtonPaste.Enabled = False
        Else
            PasteToolStripMenuItem.Enabled = True
            PasteToolStripMenuItem1.Enabled = True
            ToolStripButtonPaste.Enabled = True
        End If

    End Sub

#End Region

End Class