
'Diger 0.4.7
'Simple file explorer like MS Windows Explorer
'2012/12/17
'Mim. Alef.


'fist of all "Add Reference -> COM -> Microsoft Scripting Runtime"

Imports Scripting

Public Class Explorer

    Dim FSO As New FileSystemObject
    Dim PH As String

    'add drives and their sub folder to TreeView
    Private Sub Explorer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            For Each SystemDrive As Drive In FSO.Drives

                Dim TopDirectory As Folder = FSO.GetFolder(SystemDrive.Path)
                Dim SubNode As TreeNode = TreeView.Nodes.Add(SystemDrive.Path)

                For Each SubDirectory As Folder In TopDirectory.SubFolders

                    SubNode.Nodes.Add(SubDirectory.Name)

                Next

            Next

        Catch

        End Try

    End Sub

    'add files and folder to ListView
    Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect

        AddressBar.Text = e.Node.FullPath

        ListView.Items.Clear()

        Try

            Dim TopDirectory As Folder = FSO.GetFolder(e.Node.FullPath)

            For Each SubDirectory As Folder In TopDirectory.SubFolders

                ListView.Items.Add(SubDirectory.Name, 0)

            Next

            For Each SubFile As File In TopDirectory.Files

                ListView.Items.Add(SubFile.Name, 1)

            Next

        Catch

        End Try

    End Sub

    'add sub folder and their sub folder to TreeView
    Private Sub TreeView_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView.BeforeExpand

        e.Node.Nodes.Clear()

        Try

            Dim FirstDirectory As Folder = FSO.GetFolder(e.Node.FullPath)

            For Each TopDirectory As Folder In FirstDirectory.SubFolders

                Dim SubNode As TreeNode = e.Node.Nodes.Add(TopDirectory.Name)

                For Each SubDirectory As Folder In TopDirectory.SubFolders

                    SubNode.Nodes.Add(SubDirectory.Name)

                Next

            Next

        Catch

        End Try

    End Sub

    'open folder with click on it
    Private Sub ListView_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListView.ItemSelectionChanged

        Dim FullPath As String = AddressBar.Text + "\" + e.Item.Text

        Try

            If FSO.FolderExists(FullPath) Then

                ListView.Items.Clear()

                Dim TopDirectory As Folder = FSO.GetFolder(FullPath)

                For Each SubDirectory As Folder In TopDirectory.SubFolders

                    ListView.Items.Add(SubDirectory.Name, 0)

                Next

                For Each SubFile As File In TopDirectory.Files

                    ListView.Items.Add(SubFile.Name, 1)

                Next

                AddressBar.Text = FullPath

            End If

        Catch

        End Try

    End Sub

    'fit objects size to the form size
    Private Sub Explorer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        TreeView.Height = Me.Height - 58
        ListView.Height = Me.Height - 58
        ListView.Width = Me.Width - 168
        AddressBar.Width = Me.Width - 168

    End Sub

#Region "Toolbar"

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Close()

    End Sub

    Private Sub Explorer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Main.Visible = True

    End Sub

    Private Sub LargeIconToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconToolStripMenuItem.Click, RightClickViewLargeIcon.Click

        ListView.View = View.LargeIcon
        LargeIconToolStripMenuItem.Checked = True
        DetailsToolStripMenuItem.Checked = False
        SmallIconToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = False

    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click, RightClickViewDetails.Click

        ListView.View = View.Details
        LargeIconToolStripMenuItem.Checked = False
        DetailsToolStripMenuItem.Checked = True
        SmallIconToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = False

    End Sub

    Private Sub SmallIconToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallIconToolStripMenuItem.Click, RightClickViewSmallIcon.Click
        ListView.View = View.SmallIcon
        LargeIconToolStripMenuItem.Checked = False
        DetailsToolStripMenuItem.Checked = False
        SmallIconToolStripMenuItem.Checked = True
        ListToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = False
    End Sub

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click, RightClickViewList.Click
        ListView.View = View.List
        LargeIconToolStripMenuItem.Checked = False
        DetailsToolStripMenuItem.Checked = False
        SmallIconToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = True
        TileToolStripMenuItem.Checked = False
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileToolStripMenuItem.Click, RightClickViewTile.Click
        ListView.View = View.Tile
        LargeIconToolStripMenuItem.Checked = False
        DetailsToolStripMenuItem.Checked = False
        SmallIconToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = True
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Diger" & vbNewLine & "Version 0.2.3" & vbNewLine & "Copyright 2012 by Mojtaba Ahmadi" & vbNewLine & "and With thank to Ali Arabi" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & "This product is under the term of The GNU General Public License (GPL).", MsgBoxStyle.OkOnly, "Diger About")
    End Sub

#End Region

    Private Sub RightClickNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightClickNew.Click

        Try

            FSO.CreateFolder(AddressBar.Text + InputBox("Please insert folder name", "Create Folder", "New Folder"))

        Catch

        End Try

    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click

        Dim S As String = InputBox("Find what: ", "Find")


        Try

            For Each SystemDrive As Drive In FSO.Drives

                Dim TopDirectory As Folder = FSO.GetFolder(SystemDrive.Path)

                'Dim SubDirectory As Folder = TopDirectory.SubFolders

                For Each SubDirectory As Folder In TopDirectory.SubFolders

                    If SubDirectory.Name = S Then
                        MsgBox(SubDirectory.Name)
                    End If

                Next

            Next

        Catch

        End Try

    End Sub

End Class