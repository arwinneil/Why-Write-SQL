<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SQLGENHOME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLGENHOME))
        Me.Act_Create_Table = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Drop = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Update = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sequence = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NewTablePane = New System.Windows.Forms.GroupBox()
        Me.CompleteTable = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ReferenceText = New System.Windows.Forms.TextBox()
        Me.ReferenceBox = New System.Windows.Forms.CheckBox()
        Me.ConsBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ConsPositn = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConsType = New System.Windows.Forms.ComboBox()
        Me.FieldConsStat = New System.Windows.Forms.CheckBox()
        Me.AddField = New MaterialSkin.Controls.MaterialFlatButton()
        Me.FieldSize = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrimCheck = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FieldType = New System.Windows.Forms.ComboBox()
        Me.FieldField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewTableCreate = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewTableField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.NewTablePane.SuspendLayout()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Act_Create_Table
        '
        Me.Act_Create_Table.AutoSize = True
        Me.Act_Create_Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Create_Table.BackColor = System.Drawing.Color.White
        Me.Act_Create_Table.Depth = 0
        Me.Act_Create_Table.Location = New System.Drawing.Point(9, 22)
        Me.Act_Create_Table.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Create_Table.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Create_Table.Name = "Act_Create_Table"
        Me.Act_Create_Table.Primary = False
        Me.Act_Create_Table.Size = New System.Drawing.Size(107, 36)
        Me.Act_Create_Table.TabIndex = 0
        Me.Act_Create_Table.Text = "Create Table"
        Me.Act_Create_Table.UseVisualStyleBackColor = False
        '
        'Act_Drop
        '
        Me.Act_Drop.AutoSize = True
        Me.Act_Drop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Drop.BackColor = System.Drawing.Color.White
        Me.Act_Drop.Depth = 0
        Me.Act_Drop.Location = New System.Drawing.Point(239, 22)
        Me.Act_Drop.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Drop.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Drop.Name = "Act_Drop"
        Me.Act_Drop.Primary = False
        Me.Act_Drop.Size = New System.Drawing.Size(92, 36)
        Me.Act_Drop.TabIndex = 3
        Me.Act_Drop.Text = "Drop Table"
        Me.Act_Drop.UseVisualStyleBackColor = False
        '
        'Act_Update
        '
        Me.Act_Update.AutoSize = True
        Me.Act_Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Update.BackColor = System.Drawing.Color.White
        Me.Act_Update.Depth = 0
        Me.Act_Update.Location = New System.Drawing.Point(122, 22)
        Me.Act_Update.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Update.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Update.Name = "Act_Update"
        Me.Act_Update.Primary = False
        Me.Act_Update.Size = New System.Drawing.Size(109, 36)
        Me.Act_Update.TabIndex = 4
        Me.Act_Update.Text = "Update Table"
        Me.Act_Update.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 3)
        Me.GroupBox1.Controls.Add(Me.Sequence)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(467, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox1, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(694, 771)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Command Sequence"
        '
        'Sequence
        '
        Me.Sequence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sequence.FormattingEnabled = True
        Me.Sequence.ItemHeight = 15
        Me.Sequence.Location = New System.Drawing.Point(3, 16)
        Me.Sequence.Name = "Sequence"
        Me.Sequence.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Sequence.Size = New System.Drawing.Size(688, 752)
        Me.Sequence.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NewTablePane, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1164, 777)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Controls.Add(Me.Act_Create_Table)
        Me.GroupBox2.Controls.Add(Me.Act_Update)
        Me.GroupBox2.Controls.Add(Me.Act_Drop)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 149)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'NewTablePane
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.NewTablePane, 2)
        Me.NewTablePane.Controls.Add(Me.CompleteTable)
        Me.NewTablePane.Controls.Add(Me.Label7)
        Me.NewTablePane.Controls.Add(Me.ReferenceText)
        Me.NewTablePane.Controls.Add(Me.ReferenceBox)
        Me.NewTablePane.Controls.Add(Me.ConsBox)
        Me.NewTablePane.Controls.Add(Me.Label6)
        Me.NewTablePane.Controls.Add(Me.ConsPositn)
        Me.NewTablePane.Controls.Add(Me.Label5)
        Me.NewTablePane.Controls.Add(Me.ConsType)
        Me.NewTablePane.Controls.Add(Me.FieldConsStat)
        Me.NewTablePane.Controls.Add(Me.AddField)
        Me.NewTablePane.Controls.Add(Me.FieldSize)
        Me.NewTablePane.Controls.Add(Me.Label4)
        Me.NewTablePane.Controls.Add(Me.PrimCheck)
        Me.NewTablePane.Controls.Add(Me.Label3)
        Me.NewTablePane.Controls.Add(Me.FieldType)
        Me.NewTablePane.Controls.Add(Me.FieldField)
        Me.NewTablePane.Controls.Add(Me.Label2)
        Me.NewTablePane.Controls.Add(Me.NewTableCreate)
        Me.NewTablePane.Controls.Add(Me.Label1)
        Me.NewTablePane.Controls.Add(Me.NewTableField)
        Me.NewTablePane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewTablePane.Location = New System.Drawing.Point(3, 158)
        Me.NewTablePane.Name = "NewTablePane"
        Me.TableLayoutPanel1.SetRowSpan(Me.NewTablePane, 4)
        Me.NewTablePane.Size = New System.Drawing.Size(458, 616)
        Me.NewTablePane.TabIndex = 5
        Me.NewTablePane.TabStop = False
        Me.NewTablePane.Text = "New Table"
        Me.NewTablePane.Visible = False
        '
        'CompleteTable
        '
        Me.CompleteTable.AutoSize = True
        Me.CompleteTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CompleteTable.Depth = 0
        Me.CompleteTable.Location = New System.Drawing.Point(10, 564)
        Me.CompleteTable.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CompleteTable.MouseState = MaterialSkin.MouseState.HOVER
        Me.CompleteTable.Name = "CompleteTable"
        Me.CompleteTable.Primary = False
        Me.CompleteTable.Size = New System.Drawing.Size(166, 36)
        Me.CompleteTable.TabIndex = 36
        Me.CompleteTable.Text = "Complete Statement"
        Me.CompleteTable.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(7, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Add Fields"
        '
        'ReferenceText
        '
        Me.ReferenceText.Location = New System.Drawing.Point(105, 315)
        Me.ReferenceText.Name = "ReferenceText"
        Me.ReferenceText.Size = New System.Drawing.Size(330, 20)
        Me.ReferenceText.TabIndex = 34
        '
        'ReferenceBox
        '
        Me.ReferenceBox.AutoSize = True
        Me.ReferenceBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ReferenceBox.Location = New System.Drawing.Point(6, 317)
        Me.ReferenceBox.Name = "ReferenceBox"
        Me.ReferenceBox.Size = New System.Drawing.Size(81, 17)
        Me.ReferenceBox.TabIndex = 33
        Me.ReferenceBox.Text = "References"
        Me.ReferenceBox.UseVisualStyleBackColor = True
        '
        'ConsBox
        '
        Me.ConsBox.Location = New System.Drawing.Point(6, 420)
        Me.ConsBox.Multiline = True
        Me.ConsBox.Name = "ConsBox"
        Me.ConsBox.Size = New System.Drawing.Size(439, 92)
        Me.ConsBox.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.Location = New System.Drawing.Point(276, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Constraint Position"
        '
        'ConsPositn
        '
        Me.ConsPositn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConsPositn.FormattingEnabled = True
        Me.ConsPositn.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConsPositn.Items.AddRange(New Object() {"Before Any", "After Any", "Between Any", "Other/Specific"})
        Me.ConsPositn.Location = New System.Drawing.Point(279, 384)
        Me.ConsPositn.Name = "ConsPositn"
        Me.ConsPositn.Size = New System.Drawing.Size(156, 21)
        Me.ConsPositn.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Location = New System.Drawing.Point(102, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Constraint Type"
        '
        'ConsType
        '
        Me.ConsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConsType.FormattingEnabled = True
        Me.ConsType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConsType.Items.AddRange(New Object() {"Like", "Predefied", "Numeric/Logical/Other"})
        Me.ConsType.Location = New System.Drawing.Point(105, 384)
        Me.ConsType.Name = "ConsType"
        Me.ConsType.Size = New System.Drawing.Size(156, 21)
        Me.ConsType.TabIndex = 27
        '
        'FieldConsStat
        '
        Me.FieldConsStat.AutoSize = True
        Me.FieldConsStat.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.FieldConsStat.Location = New System.Drawing.Point(6, 385)
        Me.FieldConsStat.Name = "FieldConsStat"
        Me.FieldConsStat.Size = New System.Drawing.Size(73, 17)
        Me.FieldConsStat.TabIndex = 26
        Me.FieldConsStat.Text = "Constraint"
        Me.FieldConsStat.UseVisualStyleBackColor = True
        '
        'AddField
        '
        Me.AddField.AutoSize = True
        Me.AddField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddField.Depth = 0
        Me.AddField.Location = New System.Drawing.Point(10, 521)
        Me.AddField.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddField.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddField.Name = "AddField"
        Me.AddField.Primary = False
        Me.AddField.Size = New System.Drawing.Size(78, 36)
        Me.AddField.TabIndex = 25
        Me.AddField.Text = "Add Field"
        Me.AddField.UseVisualStyleBackColor = True
        '
        'FieldSize
        '
        Me.FieldSize.Location = New System.Drawing.Point(204, 205)
        Me.FieldSize.Name = "FieldSize"
        Me.FieldSize.Size = New System.Drawing.Size(144, 20)
        Me.FieldSize.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Location = New System.Drawing.Point(201, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Size"
        '
        'PrimCheck
        '
        Me.PrimCheck.AutoSize = True
        Me.PrimCheck.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.PrimCheck.Location = New System.Drawing.Point(6, 257)
        Me.PrimCheck.Name = "PrimCheck"
        Me.PrimCheck.Size = New System.Drawing.Size(81, 17)
        Me.PrimCheck.TabIndex = 22
        Me.PrimCheck.Text = "Primary Key"
        Me.PrimCheck.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Location = New System.Drawing.Point(5, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Type"
        '
        'FieldType
        '
        Me.FieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldType.FormattingEnabled = True
        Me.FieldType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldType.Items.AddRange(New Object() {"Text", "Character", "Integer", "Small Integer", "Bit"})
        Me.FieldType.Location = New System.Drawing.Point(8, 204)
        Me.FieldType.Name = "FieldType"
        Me.FieldType.Size = New System.Drawing.Size(156, 21)
        Me.FieldType.TabIndex = 20
        '
        'FieldField
        '
        Me.FieldField.Depth = 0
        Me.FieldField.Hint = ""
        Me.FieldField.Location = New System.Drawing.Point(5, 136)
        Me.FieldField.MouseState = MaterialSkin.MouseState.HOVER
        Me.FieldField.Name = "FieldField"
        Me.FieldField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FieldField.SelectedText = ""
        Me.FieldField.SelectionLength = 0
        Me.FieldField.SelectionStart = 0
        Me.FieldField.Size = New System.Drawing.Size(422, 23)
        Me.FieldField.TabIndex = 19
        Me.FieldField.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(6, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Enter Field Name"
        '
        'NewTableCreate
        '
        Me.NewTableCreate.AutoSize = True
        Me.NewTableCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NewTableCreate.Depth = 0
        Me.NewTableCreate.Location = New System.Drawing.Point(389, 29)
        Me.NewTableCreate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.NewTableCreate.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableCreate.Name = "NewTableCreate"
        Me.NewTableCreate.Primary = False
        Me.NewTableCreate.Size = New System.Drawing.Size(62, 36)
        Me.NewTableCreate.TabIndex = 4
        Me.NewTableCreate.Text = "Create"
        Me.NewTableCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Table Name"
        '
        'NewTableField
        '
        Me.NewTableField.Depth = 0
        Me.NewTableField.Hint = ""
        Me.NewTableField.Location = New System.Drawing.Point(5, 42)
        Me.NewTableField.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableField.Name = "NewTableField"
        Me.NewTableField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewTableField.SelectedText = ""
        Me.NewTableField.SelectionLength = 0
        Me.NewTableField.SelectionStart = 0
        Me.NewTableField.Size = New System.Drawing.Size(370, 23)
        Me.NewTableField.TabIndex = 1
        Me.NewTableField.UseSystemPasswordChar = False
        '
        'SQLGENHOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1164, 773)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "SQLGENHOME"
        Me.Text = "SQL Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.NewTablePane.ResumeLayout(False)
        Me.NewTablePane.PerformLayout()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Act_Create_Table As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Drop As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Update As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Sequence As ListBox
    Friend WithEvents NewTablePane As GroupBox
    Friend WithEvents NewTableField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As Label
    Friend WithEvents NewTableCreate As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ReferenceText As TextBox
    Friend WithEvents ReferenceBox As CheckBox
    Friend WithEvents ConsBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ConsPositn As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ConsType As ComboBox
    Friend WithEvents FieldConsStat As CheckBox
    Friend WithEvents AddField As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FieldSize As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents PrimCheck As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FieldType As ComboBox
    Friend WithEvents FieldField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CompleteTable As MaterialSkin.Controls.MaterialFlatButton
End Class
