<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLGENHOME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLGENHOME))
        Me.Act_Create_Table = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Drop = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Update = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sequence = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NewTableCreate = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ReferenceText = New System.Windows.Forms.TextBox()
        Me.ReferenceBox = New System.Windows.Forms.CheckBox()
        Me.CascadeBox = New System.Windows.Forms.CheckBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewTableField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Act_Create_Table
        '
        Me.Act_Create_Table.AutoSize = True
        Me.Act_Create_Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Create_Table.BackColor = System.Drawing.Color.White
        Me.Act_Create_Table.Depth = 0
        Me.Act_Create_Table.Location = New System.Drawing.Point(7, 22)
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
        Me.GroupBox1.Controls.Add(Me.Sequence)
        Me.GroupBox1.Location = New System.Drawing.Point(523, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 627)
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
        Me.Sequence.Size = New System.Drawing.Size(494, 608)
        Me.Sequence.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Act_Create_Table)
        Me.GroupBox2.Controls.Add(Me.Act_Update)
        Me.GroupBox2.Controls.Add(Me.Act_Drop)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 727)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NewTableCreate)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.NewTableField)
        Me.GroupBox3.Controls.Add(Me.MaterialRaisedButton1)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 654)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "New Table"
        '
        'NewTableCreate
        '
        Me.NewTableCreate.AutoSize = True
        Me.NewTableCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NewTableCreate.Depth = 0
        Me.NewTableCreate.Location = New System.Drawing.Point(392, 29)
        Me.NewTableCreate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.NewTableCreate.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableCreate.Name = "NewTableCreate"
        Me.NewTableCreate.Primary = False
        Me.NewTableCreate.Size = New System.Drawing.Size(62, 36)
        Me.NewTableCreate.TabIndex = 4
        Me.NewTableCreate.Text = "Create"
        Me.NewTableCreate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ReferenceText)
        Me.GroupBox4.Controls.Add(Me.ReferenceBox)
        Me.GroupBox4.Controls.Add(Me.CascadeBox)
        Me.GroupBox4.Controls.Add(Me.ConsBox)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ConsPositn)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.ConsType)
        Me.GroupBox4.Controls.Add(Me.FieldConsStat)
        Me.GroupBox4.Controls.Add(Me.AddField)
        Me.GroupBox4.Controls.Add(Me.FieldSize)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.PrimCheck)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.FieldType)
        Me.GroupBox4.Controls.Add(Me.FieldField)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 71)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(462, 528)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fields"
        '
        'ReferenceText
        '
        Me.ReferenceText.Location = New System.Drawing.Point(106, 237)
        Me.ReferenceText.Name = "ReferenceText"
        Me.ReferenceText.Size = New System.Drawing.Size(330, 20)
        Me.ReferenceText.TabIndex = 17
        '
        'ReferenceBox
        '
        Me.ReferenceBox.AutoSize = True
        Me.ReferenceBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ReferenceBox.Location = New System.Drawing.Point(6, 239)
        Me.ReferenceBox.Name = "ReferenceBox"
        Me.ReferenceBox.Size = New System.Drawing.Size(81, 17)
        Me.ReferenceBox.TabIndex = 16
        Me.ReferenceBox.Text = "References"
        Me.ReferenceBox.UseVisualStyleBackColor = True
        '
        'CascadeBox
        '
        Me.CascadeBox.AutoSize = True
        Me.CascadeBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.CascadeBox.Location = New System.Drawing.Point(6, 198)
        Me.CascadeBox.Name = "CascadeBox"
        Me.CascadeBox.Size = New System.Drawing.Size(123, 17)
        Me.CascadeBox.TabIndex = 15
        Me.CascadeBox.Text = "On Update Cascade"
        Me.CascadeBox.UseVisualStyleBackColor = True
        '
        'ConsBox
        '
        Me.ConsBox.Location = New System.Drawing.Point(6, 323)
        Me.ConsBox.Multiline = True
        Me.ConsBox.Name = "ConsBox"
        Me.ConsBox.Size = New System.Drawing.Size(439, 163)
        Me.ConsBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.Location = New System.Drawing.Point(277, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Constraint Position"
        '
        'ConsPositn
        '
        Me.ConsPositn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConsPositn.FormattingEnabled = True
        Me.ConsPositn.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConsPositn.Items.AddRange(New Object() {"Before Any", "After Any", "Between Any", "Other/Specific"})
        Me.ConsPositn.Location = New System.Drawing.Point(280, 288)
        Me.ConsPositn.Name = "ConsPositn"
        Me.ConsPositn.Size = New System.Drawing.Size(156, 21)
        Me.ConsPositn.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Location = New System.Drawing.Point(103, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Constraint Type"
        '
        'ConsType
        '
        Me.ConsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConsType.FormattingEnabled = True
        Me.ConsType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConsType.Items.AddRange(New Object() {"Like", "Predefied"})
        Me.ConsType.Location = New System.Drawing.Point(106, 288)
        Me.ConsType.Name = "ConsType"
        Me.ConsType.Size = New System.Drawing.Size(156, 21)
        Me.ConsType.TabIndex = 10
        '
        'FieldConsStat
        '
        Me.FieldConsStat.AutoSize = True
        Me.FieldConsStat.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.FieldConsStat.Location = New System.Drawing.Point(6, 290)
        Me.FieldConsStat.Name = "FieldConsStat"
        Me.FieldConsStat.Size = New System.Drawing.Size(73, 17)
        Me.FieldConsStat.TabIndex = 9
        Me.FieldConsStat.Text = "Constraint"
        Me.FieldConsStat.UseVisualStyleBackColor = True
        '
        'AddField
        '
        Me.AddField.AutoSize = True
        Me.AddField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddField.Depth = 0
        Me.AddField.Location = New System.Drawing.Point(6, 485)
        Me.AddField.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddField.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddField.Name = "AddField"
        Me.AddField.Primary = False
        Me.AddField.Size = New System.Drawing.Size(78, 36)
        Me.AddField.TabIndex = 8
        Me.AddField.Text = "Add Field"
        Me.AddField.UseVisualStyleBackColor = True
        '
        'FieldSize
        '
        Me.FieldSize.Location = New System.Drawing.Point(205, 109)
        Me.FieldSize.Name = "FieldSize"
        Me.FieldSize.Size = New System.Drawing.Size(144, 20)
        Me.FieldSize.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Location = New System.Drawing.Point(202, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Size"
        '
        'PrimCheck
        '
        Me.PrimCheck.AutoSize = True
        Me.PrimCheck.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.PrimCheck.Location = New System.Drawing.Point(6, 153)
        Me.PrimCheck.Name = "PrimCheck"
        Me.PrimCheck.Size = New System.Drawing.Size(81, 17)
        Me.PrimCheck.TabIndex = 5
        Me.PrimCheck.Text = "Primary Key"
        Me.PrimCheck.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type"
        '
        'FieldType
        '
        Me.FieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldType.FormattingEnabled = True
        Me.FieldType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldType.Items.AddRange(New Object() {"Text", "Character", "Integer", "Small Integer", "Bit"})
        Me.FieldType.Location = New System.Drawing.Point(9, 108)
        Me.FieldType.Name = "FieldType"
        Me.FieldType.Size = New System.Drawing.Size(156, 21)
        Me.FieldType.TabIndex = 3
        '
        'FieldField
        '
        Me.FieldField.Depth = 0
        Me.FieldField.Hint = ""
        Me.FieldField.Location = New System.Drawing.Point(6, 41)
        Me.FieldField.MouseState = MaterialSkin.MouseState.HOVER
        Me.FieldField.Name = "FieldField"
        Me.FieldField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FieldField.SelectedText = ""
        Me.FieldField.SelectionLength = 0
        Me.FieldField.SelectionStart = 0
        Me.FieldField.Size = New System.Drawing.Size(422, 23)
        Me.FieldField.TabIndex = 1
        Me.FieldField.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter Field Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Table Name"
        '
        'NewTableField
        '
        Me.NewTableField.Depth = 0
        Me.NewTableField.Hint = ""
        Me.NewTableField.Location = New System.Drawing.Point(6, 42)
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
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(164, 605)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(128, 43)
        Me.MaterialRaisedButton1.TabIndex = 0
        Me.MaterialRaisedButton1.Text = "Done"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'SQLGENHOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1035, 751)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "SQLGENHOME"
        Me.Text = "SQL Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Act_Create_Table As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Drop As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Update As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Sequence As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NewTableField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrimCheck As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FieldType As ComboBox
    Friend WithEvents FieldField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FieldSize As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ConsType As ComboBox
    Friend WithEvents FieldConsStat As CheckBox
    Friend WithEvents AddField As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents ConsPositn As ComboBox
    Friend WithEvents ConsBox As TextBox
    Friend WithEvents NewTableCreate As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents CascadeBox As CheckBox
    Friend WithEvents ReferenceText As TextBox
    Friend WithEvents ReferenceBox As CheckBox
End Class
