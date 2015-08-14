<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Phonebook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Phonebook))
        Me.SaveTab = New System.Windows.Forms.TabPage
        Me.SaveTool = New System.Windows.Forms.ToolStrip
        Me.SaveButton = New System.Windows.Forms.ToolStripButton
        Me.SaveRichTextBox = New System.Windows.Forms.RichTextBox
        Me.ListTab = New System.Windows.Forms.TabPage
        Me.VeiwGrid = New System.Windows.Forms.DataGridView
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumbookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumbookDataSet = New Exercise.NumbookDataSet
        Me.InsertTab = New System.Windows.Forms.TabPage
        Me.UpdateButton = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.InsertButton = New System.Windows.Forms.Button
        Me.NewButton = New System.Windows.Forms.Button
        Me.FieldGroupBox = New System.Windows.Forms.GroupBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.NameLabel = New System.Windows.Forms.Label
        Me.FamilyLabel = New System.Windows.Forms.Label
        Me.FamilyTextBox = New System.Windows.Forms.TextBox
        Me.EmailLabel = New System.Windows.Forms.Label
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.TeleLabel = New System.Windows.Forms.Label
        Me.TeleTextBox = New System.Windows.Forms.TextBox
        Me.NumbookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.HomeTab = New System.Windows.Forms.TabPage
        Me.EnjoyLabel = New System.Windows.Forms.Label
        Me.CopyrightLabel = New System.Windows.Forms.Label
        Me.TabDock = New System.Windows.Forms.TabControl
        Me.LicensesTab = New System.Windows.Forms.TabPage
        Me.LicensesTextBox = New System.Windows.Forms.TextBox
        Me.TabsImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.PhonebookTableAdapter = New Exercise.NumbookDataSetTableAdapters.PhonebookTableAdapter
        Me.RichTextSaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.SaveTab.SuspendLayout()
        Me.SaveTool.SuspendLayout()
        Me.ListTab.SuspendLayout()
        CType(Me.VeiwGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumbookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumbookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InsertTab.SuspendLayout()
        Me.FieldGroupBox.SuspendLayout()
        CType(Me.NumbookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NumbookBindingNavigator.SuspendLayout()
        Me.HomeTab.SuspendLayout()
        Me.TabDock.SuspendLayout()
        Me.LicensesTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveTab
        '
        Me.SaveTab.BackColor = System.Drawing.Color.Turquoise
        Me.SaveTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SaveTab.Controls.Add(Me.SaveTool)
        Me.SaveTab.Controls.Add(Me.SaveRichTextBox)
        Me.SaveTab.ImageIndex = 3
        Me.SaveTab.Location = New System.Drawing.Point(4, 54)
        Me.SaveTab.Name = "SaveTab"
        Me.SaveTab.Size = New System.Drawing.Size(523, 268)
        Me.SaveTab.TabIndex = 4
        Me.SaveTab.Text = "Save"
        Me.SaveTab.UseVisualStyleBackColor = True
        '
        'SaveTool
        '
        Me.SaveTool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SaveTool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SaveTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveButton})
        Me.SaveTool.Location = New System.Drawing.Point(0, 239)
        Me.SaveTool.Name = "SaveTool"
        Me.SaveTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SaveTool.Size = New System.Drawing.Size(519, 25)
        Me.SaveTool.TabIndex = 2
        Me.SaveTool.Text = "SaveTool"
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(35, 22)
        Me.SaveButton.Text = "Save"
        '
        'SaveRichTextBox
        '
        Me.SaveRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.SaveRichTextBox.Name = "SaveRichTextBox"
        Me.SaveRichTextBox.Size = New System.Drawing.Size(519, 239)
        Me.SaveRichTextBox.TabIndex = 1
        Me.SaveRichTextBox.Text = ""
        '
        'ListTab
        '
        Me.ListTab.BackColor = System.Drawing.Color.Turquoise
        Me.ListTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ListTab.Controls.Add(Me.VeiwGrid)
        Me.ListTab.ImageIndex = 2
        Me.ListTab.Location = New System.Drawing.Point(4, 54)
        Me.ListTab.Name = "ListTab"
        Me.ListTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ListTab.Size = New System.Drawing.Size(523, 268)
        Me.ListTab.TabIndex = 3
        Me.ListTab.Text = "List"
        Me.ListTab.UseVisualStyleBackColor = True
        '
        'VeiwGrid
        '
        Me.VeiwGrid.AllowUserToAddRows = False
        Me.VeiwGrid.AllowUserToDeleteRows = False
        Me.VeiwGrid.AutoGenerateColumns = False
        Me.VeiwGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VeiwGrid.BackgroundColor = System.Drawing.Color.Turquoise
        Me.VeiwGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VeiwGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VeiwGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn})
        Me.VeiwGrid.DataSource = Me.NumbookBindingSource
        Me.VeiwGrid.Location = New System.Drawing.Point(3, 3)
        Me.VeiwGrid.Name = "VeiwGrid"
        Me.VeiwGrid.ReadOnly = True
        Me.VeiwGrid.Size = New System.Drawing.Size(513, 287)
        Me.VeiwGrid.TabIndex = 0
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
        Me.CodeDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Family"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumbookBindingSource
        '
        Me.NumbookBindingSource.DataMember = "Phonebook"
        Me.NumbookBindingSource.DataSource = Me.NumbookDataSet
        '
        'NumbookDataSet
        '
        Me.NumbookDataSet.DataSetName = "NumbookDataSet"
        Me.NumbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InsertTab
        '
        Me.InsertTab.BackColor = System.Drawing.Color.Turquoise
        Me.InsertTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InsertTab.Controls.Add(Me.UpdateButton)
        Me.InsertTab.Controls.Add(Me.DeleteButton)
        Me.InsertTab.Controls.Add(Me.InsertButton)
        Me.InsertTab.Controls.Add(Me.NewButton)
        Me.InsertTab.Controls.Add(Me.FieldGroupBox)
        Me.InsertTab.Controls.Add(Me.NumbookBindingNavigator)
        Me.InsertTab.ImageIndex = 1
        Me.InsertTab.Location = New System.Drawing.Point(4, 54)
        Me.InsertTab.Name = "InsertTab"
        Me.InsertTab.Padding = New System.Windows.Forms.Padding(3)
        Me.InsertTab.Size = New System.Drawing.Size(523, 268)
        Me.InsertTab.TabIndex = 1
        Me.InsertTab.Text = "Insert"
        Me.InsertTab.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Location = New System.Drawing.Point(423, 135)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 28)
        Me.UpdateButton.TabIndex = 13
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Location = New System.Drawing.Point(423, 101)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 28)
        Me.DeleteButton.TabIndex = 8
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'InsertButton
        '
        Me.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InsertButton.Location = New System.Drawing.Point(21, 135)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(75, 28)
        Me.InsertButton.TabIndex = 9
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton.Location = New System.Drawing.Point(21, 101)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(75, 28)
        Me.NewButton.TabIndex = 10
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'FieldGroupBox
        '
        Me.FieldGroupBox.Controls.Add(Me.NameTextBox)
        Me.FieldGroupBox.Controls.Add(Me.NameLabel)
        Me.FieldGroupBox.Controls.Add(Me.FamilyLabel)
        Me.FieldGroupBox.Controls.Add(Me.FamilyTextBox)
        Me.FieldGroupBox.Controls.Add(Me.EmailLabel)
        Me.FieldGroupBox.Controls.Add(Me.EmailTextBox)
        Me.FieldGroupBox.Controls.Add(Me.TeleLabel)
        Me.FieldGroupBox.Controls.Add(Me.TeleTextBox)
        Me.FieldGroupBox.Location = New System.Drawing.Point(121, 28)
        Me.FieldGroupBox.Name = "FieldGroupBox"
        Me.FieldGroupBox.Size = New System.Drawing.Size(276, 183)
        Me.FieldGroupBox.TabIndex = 12
        Me.FieldGroupBox.TabStop = False
        Me.FieldGroupBox.Text = "Fields:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NumbookBindingSource, "firstName", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(88, 26)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(182, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(6, 29)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(79, 16)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "First Name: "
        '
        'FamilyLabel
        '
        Me.FamilyLabel.AutoSize = True
        Me.FamilyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FamilyLabel.Location = New System.Drawing.Point(6, 70)
        Me.FamilyLabel.Name = "FamilyLabel"
        Me.FamilyLabel.Size = New System.Drawing.Size(79, 16)
        Me.FamilyLabel.TabIndex = 5
        Me.FamilyLabel.Text = "Last Name: "
        '
        'FamilyTextBox
        '
        Me.FamilyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NumbookBindingSource, "lastName", True))
        Me.FamilyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FamilyTextBox.Location = New System.Drawing.Point(88, 67)
        Me.FamilyTextBox.Name = "FamilyTextBox"
        Me.FamilyTextBox.Size = New System.Drawing.Size(182, 22)
        Me.FamilyTextBox.TabIndex = 1
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(6, 111)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(48, 16)
        Me.EmailLabel.TabIndex = 7
        Me.EmailLabel.Text = "Email: "
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NumbookBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(88, 108)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(182, 22)
        Me.EmailTextBox.TabIndex = 2
        '
        'TeleLabel
        '
        Me.TeleLabel.AutoSize = True
        Me.TeleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TeleLabel.Location = New System.Drawing.Point(6, 152)
        Me.TeleLabel.Name = "TeleLabel"
        Me.TeleLabel.Size = New System.Drawing.Size(80, 16)
        Me.TeleLabel.TabIndex = 6
        Me.TeleLabel.Text = "Telephone: "
        '
        'TeleTextBox
        '
        Me.TeleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NumbookBindingSource, "tel", True))
        Me.TeleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TeleTextBox.Location = New System.Drawing.Point(88, 149)
        Me.TeleTextBox.Name = "TeleTextBox"
        Me.TeleTextBox.Size = New System.Drawing.Size(182, 22)
        Me.TeleTextBox.TabIndex = 3
        '
        'NumbookBindingNavigator
        '
        Me.NumbookBindingNavigator.AddNewItem = Nothing
        Me.NumbookBindingNavigator.BindingSource = Me.NumbookBindingSource
        Me.NumbookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NumbookBindingNavigator.DeleteItem = Nothing
        Me.NumbookBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NumbookBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.NumbookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.NumbookBindingNavigator.Location = New System.Drawing.Point(3, 236)
        Me.NumbookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NumbookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NumbookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NumbookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NumbookBindingNavigator.Name = "NumbookBindingNavigator"
        Me.NumbookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NumbookBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.NumbookBindingNavigator.Size = New System.Drawing.Size(513, 25)
        Me.NumbookBindingNavigator.TabIndex = 11
        Me.NumbookBindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'HomeTab
        '
        Me.HomeTab.BackColor = System.Drawing.Color.Turquoise
        Me.HomeTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HomeTab.Controls.Add(Me.EnjoyLabel)
        Me.HomeTab.Controls.Add(Me.CopyrightLabel)
        Me.HomeTab.ImageIndex = 0
        Me.HomeTab.Location = New System.Drawing.Point(4, 54)
        Me.HomeTab.Name = "HomeTab"
        Me.HomeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.HomeTab.Size = New System.Drawing.Size(523, 268)
        Me.HomeTab.TabIndex = 0
        Me.HomeTab.Text = "Home"
        Me.HomeTab.UseVisualStyleBackColor = True
        '
        'EnjoyLabel
        '
        Me.EnjoyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.EnjoyLabel.Location = New System.Drawing.Point(42, 61)
        Me.EnjoyLabel.Name = "EnjoyLabel"
        Me.EnjoyLabel.Size = New System.Drawing.Size(435, 116)
        Me.EnjoyLabel.TabIndex = 3
        Me.EnjoyLabel.Text = """Most good programmers do programming not because they expect to get paid or get " & _
            "adulation by the public, but because it is fun to program.""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Linus Torvalds"
        Me.EnjoyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.AutoSize = True
        Me.CopyrightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CopyrightLabel.Location = New System.Drawing.Point(138, 234)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(242, 13)
        Me.CopyrightLabel.TabIndex = 1
        Me.CopyrightLabel.Text = "Numbook  Copyright (C) 2012  by Mojtaba Ahmadi"
        '
        'TabDock
        '
        Me.TabDock.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabDock.Controls.Add(Me.HomeTab)
        Me.TabDock.Controls.Add(Me.InsertTab)
        Me.TabDock.Controls.Add(Me.ListTab)
        Me.TabDock.Controls.Add(Me.SaveTab)
        Me.TabDock.Controls.Add(Me.LicensesTab)
        Me.TabDock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDock.ImageList = Me.TabsImageList
        Me.TabDock.ItemSize = New System.Drawing.Size(96, 50)
        Me.TabDock.Location = New System.Drawing.Point(0, 0)
        Me.TabDock.Name = "TabDock"
        Me.TabDock.SelectedIndex = 0
        Me.TabDock.Size = New System.Drawing.Size(531, 326)
        Me.TabDock.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabDock.TabIndex = 0
        '
        'LicensesTab
        '
        Me.LicensesTab.BackColor = System.Drawing.Color.Turquoise
        Me.LicensesTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LicensesTab.Controls.Add(Me.LicensesTextBox)
        Me.LicensesTab.ImageIndex = 4
        Me.LicensesTab.Location = New System.Drawing.Point(4, 54)
        Me.LicensesTab.Name = "LicensesTab"
        Me.LicensesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LicensesTab.Size = New System.Drawing.Size(523, 268)
        Me.LicensesTab.TabIndex = 5
        Me.LicensesTab.Text = "Licen"
        Me.LicensesTab.UseVisualStyleBackColor = True
        '
        'LicensesTextBox
        '
        Me.LicensesTextBox.BackColor = System.Drawing.Color.Turquoise
        Me.LicensesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LicensesTextBox.Location = New System.Drawing.Point(6, 6)
        Me.LicensesTextBox.Multiline = True
        Me.LicensesTextBox.Name = "LicensesTextBox"
        Me.LicensesTextBox.ReadOnly = True
        Me.LicensesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LicensesTextBox.Size = New System.Drawing.Size(507, 252)
        Me.LicensesTextBox.TabIndex = 0
        Me.LicensesTextBox.Text = resources.GetString("LicensesTextBox.Text")
        Me.LicensesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabsImageList
        '
        Me.TabsImageList.ImageStream = CType(resources.GetObject("TabsImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TabsImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TabsImageList.Images.SetKeyName(0, "address_book.png")
        Me.TabsImageList.Images.SetKeyName(1, "add.png")
        Me.TabsImageList.Images.SetKeyName(2, "list2.png")
        Me.TabsImageList.Images.SetKeyName(3, "diskette.png")
        Me.TabsImageList.Images.SetKeyName(4, "round.png")
        '
        'PhonebookTableAdapter
        '
        Me.PhonebookTableAdapter.ClearBeforeFill = True
        '
        'Phonebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(531, 326)
        Me.Controls.Add(Me.TabDock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Phonebook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numbook"
        Me.SaveTab.ResumeLayout(False)
        Me.SaveTab.PerformLayout()
        Me.SaveTool.ResumeLayout(False)
        Me.SaveTool.PerformLayout()
        Me.ListTab.ResumeLayout(False)
        CType(Me.VeiwGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumbookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumbookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InsertTab.ResumeLayout(False)
        Me.InsertTab.PerformLayout()
        Me.FieldGroupBox.ResumeLayout(False)
        Me.FieldGroupBox.PerformLayout()
        CType(Me.NumbookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NumbookBindingNavigator.ResumeLayout(False)
        Me.NumbookBindingNavigator.PerformLayout()
        Me.HomeTab.ResumeLayout(False)
        Me.HomeTab.PerformLayout()
        Me.TabDock.ResumeLayout(False)
        Me.LicensesTab.ResumeLayout(False)
        Me.LicensesTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveTab As System.Windows.Forms.TabPage
    Friend WithEvents ListTab As System.Windows.Forms.TabPage
    Friend WithEvents VeiwGrid As System.Windows.Forms.DataGridView
    Friend WithEvents InsertTab As System.Windows.Forms.TabPage
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents InsertButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents TeleLabel As System.Windows.Forms.Label
    Friend WithEvents FamilyLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FamilyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomeTab As System.Windows.Forms.TabPage
    Friend WithEvents CopyrightLabel As System.Windows.Forms.Label
    Friend WithEvents TabDock As System.Windows.Forms.TabControl
    Friend WithEvents LicensesTab As System.Windows.Forms.TabPage
    Friend WithEvents NumbookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NumbookDataSet As Exercise.NumbookDataSet
    Friend WithEvents PhonebookTableAdapter As Exercise.NumbookDataSetTableAdapters.PhonebookTableAdapter
    Friend WithEvents NumbookBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabsImageList As System.Windows.Forms.ImageList
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FieldGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LicensesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnjoyLabel As System.Windows.Forms.Label
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents SaveRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SaveTool As System.Windows.Forms.ToolStrip
    Friend WithEvents SaveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RichTextSaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class
