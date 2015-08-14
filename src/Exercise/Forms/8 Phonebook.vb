
'Numbook 0.1.4
'Simple program to manage phone numbers.
'2012/12/29 - 2013/01/01
'Mim. Alef.

Imports System.Data.SqlClient


Public Class Phonebook


#Region "Insert in SQL"
    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        ClearTextBox()
    End Sub

    Private Sub InsertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertButton.Click
        NumbookDataSet.Phonebook.AddPhonebookRow(NameTextBox.Text, FamilyTextBox.Text, EmailTextBox.Text, TeleTextBox.Text)
        PhonebookTableAdapter.Update(NumbookDataSet.Phonebook)
        ClearTextBox()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        NumbookBindingSource.RemoveCurrent()
        PhonebookTableAdapter.Update(NumbookDataSet.Phonebook)
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        NumbookBindingSource.EndEdit()
        PhonebookTableAdapter.Update(NumbookDataSet.Phonebook)
        MsgBox("Updating Success", MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub ClearTextBox()
        NameTextBox.Text = ""
        FamilyTextBox.Text = ""
        EmailTextBox.Text = ""
        TeleTextBox.Text = ""
    End Sub
#End Region

#Region "Save as File"
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If RichTextSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveRichTextBox.SaveFile(RichTextSaveFileDialog.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub SaveTab_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveTab.Enter
        SaveRichTextBox.Clear()
        SaveRichTextBox.Text = "You have " & CStr(NumbookDataSet.Phonebook.Count) & " contact(s) in this list."
        SaveRichTextBox.Text += vbNewLine
        SaveRichTextBox.Text += "-------------------------------------------------------------------------------------------------------------------------------------------"
        SaveRichTextBox.Text += vbNewLine
        For I = 0 To NumbookDataSet.Phonebook.Count - 1
            SaveRichTextBox.Text += CStr(NumbookDataSet.Phonebook.Item(I).code)
            SaveRichTextBox.Text += vbTab
            SaveRichTextBox.Text += NumbookDataSet.Phonebook.Item(I).firstName
            SaveRichTextBox.Text += "     |     "
            SaveRichTextBox.Text += NumbookDataSet.Phonebook.Item(I).lastName
            SaveRichTextBox.Text += "     |     "
            SaveRichTextBox.Text += NumbookDataSet.Phonebook.Item(I).email
            SaveRichTextBox.Text += "     |     "
            SaveRichTextBox.Text += NumbookDataSet.Phonebook.Item(I).tel
            SaveRichTextBox.Text += vbNewLine
            SaveRichTextBox.Text += "-------------------------------------------------------------------------------------------------------------------------------------------"
            SaveRichTextBox.Text += vbNewLine
        Next
    End Sub
#End Region

#Region "Other Stuff"
    Private Sub Phonebook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NumbookDataSet.Phonebook' table. You can move, or remove it, as needed.
        Me.PhonebookTableAdapter.Fill(Me.NumbookDataSet.Phonebook)
    End Sub

    Private Sub Phonebook_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Visible = True
    End Sub
#End Region

End Class