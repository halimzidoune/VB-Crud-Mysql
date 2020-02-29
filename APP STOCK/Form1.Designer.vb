<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonClearAll = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonIDMaker = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonClearSelected = New System.Windows.Forms.Button()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EdittToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox1.Controls.Add(Me.ButtonClearAll)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonIDMaker)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxAmount)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrice)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 212)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input and Update Data"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Image"
        '
        'ButtonClearAll
        '
        Me.ButtonClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearAll.ForeColor = System.Drawing.Color.Black
        Me.ButtonClearAll.Location = New System.Drawing.Point(407, 145)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearAll.TabIndex = 10
        Me.ButtonClearAll.Text = "Clear All"
        Me.ButtonClearAll.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.ForeColor = System.Drawing.Color.Black
        Me.ButtonSave.Location = New System.Drawing.Point(9, 145)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 9
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonIDMaker
        '
        Me.ButtonIDMaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIDMaker.ForeColor = System.Drawing.Color.Black
        Me.ButtonIDMaker.Location = New System.Drawing.Point(407, 43)
        Me.ButtonIDMaker.Name = "ButtonIDMaker"
        Me.ButtonIDMaker.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIDMaker.TabIndex = 8
        Me.ButtonIDMaker.Text = "ID Maker"
        Me.ButtonIDMaker.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAmount.Location = New System.Drawing.Point(53, 97)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(429, 20)
        Me.TextBoxAmount.TabIndex = 3
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrice.Location = New System.Drawing.Point(53, 71)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(429, 20)
        Me.TextBoxPrice.TabIndex = 2
        '
        'TextBoxID
        '
        Me.TextBoxID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxID.Location = New System.Drawing.Point(53, 45)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(348, 20)
        Me.TextBoxID.TabIndex = 1
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.Location = New System.Drawing.Point(53, 19)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(429, 20)
        Me.TextBoxName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.ButtonClearSelected)
        Me.GroupBox2.Controls.Add(Me.CheckBoxByID)
        Me.GroupBox2.Controls.Add(Me.CheckBoxByName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox2.Controls.Add(Me.ButtonDelete)
        Me.GroupBox2.Controls.Add(Me.ButtonEdit)
        Me.GroupBox2.Controls.Add(Me.PictureBoxImagePreview)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(10, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 279)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(9, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(473, 202)
        Me.DataGridView1.TabIndex = 22
        '
        'ButtonClearSelected
        '
        Me.ButtonClearSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearSelected.ForeColor = System.Drawing.Color.Black
        Me.ButtonClearSelected.Location = New System.Drawing.Point(579, 239)
        Me.ButtonClearSelected.Name = "ButtonClearSelected"
        Me.ButtonClearSelected.Size = New System.Drawing.Size(174, 23)
        Me.ButtonClearSelected.TabIndex = 21
        Me.ButtonClearSelected.Text = "Clear Selected and Preview"
        Me.ButtonClearSelected.UseVisualStyleBackColor = True
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Location = New System.Drawing.Point(366, 47)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxByID.TabIndex = 20
        Me.CheckBoxByID.Text = "Search by ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Checked = True
        Me.CheckBoxByName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByName.Location = New System.Drawing.Point(255, 47)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(105, 17)
        Me.CheckBoxByName.TabIndex = 19
        Me.CheckBoxByName.Text = "Search by Name"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Search here"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Location = New System.Drawing.Point(323, 21)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(431, 20)
        Me.TextBoxSearch.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(511, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Preview"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Black
        Me.ButtonRefresh.Location = New System.Drawing.Point(171, 19)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 15
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.ForeColor = System.Drawing.Color.Black
        Me.ButtonDelete.Location = New System.Drawing.Point(90, 19)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.ForeColor = System.Drawing.Color.Black
        Me.ButtonEdit.Location = New System.Drawing.Point(9, 19)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 13
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.EdittToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 92)
        '
        'EdittToolStripMenuItem
        '
        Me.EdittToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.iconfinder_document_pencil_49370
        Me.EdittToolStripMenuItem.Name = "EdittToolStripMenuItem"
        Me.EdittToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EdittToolStripMenuItem.Text = "Editt"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(579, 56)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagePreview.TabIndex = 12
        Me.PictureBoxImagePreview.TabStop = False
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImageInput.Image = Global.WindowsApplication1.My.Resources.Resources.cover
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(579, 19)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 11
        Me.PictureBoxImageInput.TabStop = False
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(786, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxImageInput As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonClearAll As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonIDMaker As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAmount As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents PictureBoxImagePreview As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonClearSelected As System.Windows.Forms.Button
    Friend WithEvents CheckBoxByID As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxByName As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdittToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
