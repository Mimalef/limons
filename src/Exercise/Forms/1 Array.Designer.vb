<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Array
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Array))
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnCount = New System.Windows.Forms.Button
        Me.List = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Add"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(95, 12)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(75, 23)
        Me.btnCount.TabIndex = 1
        Me.btnCount.Text = "Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'List
        '
        Me.List.BackColor = System.Drawing.Color.White
        Me.List.Location = New System.Drawing.Point(12, 41)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(158, 213)
        Me.List.TabIndex = 2
        Me.List.UseCompatibleStateImageBehavior = False
        '
        'Array
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(182, 266)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Array"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creeparray"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents List As System.Windows.Forms.ListView
End Class
