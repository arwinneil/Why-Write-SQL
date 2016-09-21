<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Act_Create_Table = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Drop = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Update = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sequence = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelAction = New System.Windows.Forms.Panel()
        Me.ActionGroup = New System.Windows.Forms.GroupBox()
        Me.CreatePanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.FieldConsBox = New System.Windows.Forms.CheckBox()
        Me.ConsType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConsList = New System.Windows.Forms.TextBox()
        Me.ConsPositn = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OnDeleteAction = New System.Windows.Forms.ComboBox()
        Me.OnUpdateAction = New System.Windows.Forms.ComboBox()
        Me.OnDeleteBox = New System.Windows.Forms.CheckBox()
        Me.OnUpdateBox = New System.Windows.Forms.CheckBox()
        Me.ReferenceBox = New System.Windows.Forms.CheckBox()
        Me.ReferenceText = New System.Windows.Forms.TextBox()
        Me.CompleteTable = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.NewTablePanel = New System.Windows.Forms.Panel()
        Me.UpdatePanel = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Scale = New System.Windows.Forms.NumericUpDown()
        Me.Precision = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelAction.SuspendLayout()
        Me.ActionGroup.SuspendLayout()
        Me.CreatePanel.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Scale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Precision, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Act_Drop.Size = New System.Drawing.Size(105, 36)
        Me.Act_Drop.TabIndex = 3
        Me.Act_Drop.Text = "Delete Table"
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
        Me.Sequence.HorizontalScrollbar = True
        Me.Sequence.ItemHeight = 15
        Me.Sequence.Location = New System.Drawing.Point(3, 16)
        Me.Sequence.Name = "Sequence"
        Me.Sequence.ScrollAlwaysVisible = True
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
        Me.TableLayoutPanel1.Controls.Add(Me.PanelAction, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
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
        'PanelAction
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.PanelAction, 2)
        Me.PanelAction.Controls.Add(Me.ActionGroup)
        Me.PanelAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAction.Location = New System.Drawing.Point(3, 158)
        Me.PanelAction.Name = "PanelAction"
        Me.TableLayoutPanel1.SetRowSpan(Me.PanelAction, 4)
        Me.PanelAction.Size = New System.Drawing.Size(458, 616)
        Me.PanelAction.TabIndex = 0
        '
        'ActionGroup
        '
        Me.ActionGroup.Controls.Add(Me.CreatePanel)
        Me.ActionGroup.Controls.Add(Me.NewTablePanel)
        Me.ActionGroup.Controls.Add(Me.UpdatePanel)
        Me.ActionGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionGroup.Location = New System.Drawing.Point(0, 0)
        Me.ActionGroup.Name = "ActionGroup"
        Me.ActionGroup.Size = New System.Drawing.Size(458, 616)
        Me.ActionGroup.TabIndex = 6
        Me.ActionGroup.TabStop = False
        Me.ActionGroup.Text = "Action"
        Me.ActionGroup.Visible = False
        '
        'CreatePanel
        '
        Me.CreatePanel.Controls.Add(Me.Precision)
        Me.CreatePanel.Controls.Add(Me.Scale)
        Me.CreatePanel.Controls.Add(Me.Label8)
        Me.CreatePanel.Controls.Add(Me.GroupBox9)
        Me.CreatePanel.Controls.Add(Me.GroupBox3)
        Me.CreatePanel.Controls.Add(Me.CompleteTable)
        Me.CreatePanel.Controls.Add(Me.Label7)
        Me.CreatePanel.Controls.Add(Me.AddField)
        Me.CreatePanel.Controls.Add(Me.FieldSize)
        Me.CreatePanel.Controls.Add(Me.Label4)
        Me.CreatePanel.Controls.Add(Me.PrimCheck)
        Me.CreatePanel.Controls.Add(Me.Label3)
        Me.CreatePanel.Controls.Add(Me.FieldType)
        Me.CreatePanel.Controls.Add(Me.FieldField)
        Me.CreatePanel.Controls.Add(Me.Label2)
        Me.CreatePanel.Controls.Add(Me.NewTableCreate)
        Me.CreatePanel.Controls.Add(Me.Label1)
        Me.CreatePanel.Controls.Add(Me.NewTableField)
        Me.CreatePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreatePanel.Location = New System.Drawing.Point(3, 16)
        Me.CreatePanel.Name = "CreatePanel"
        Me.CreatePanel.Size = New System.Drawing.Size(452, 597)
        Me.CreatePanel.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(297, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "(Presision , Scale)"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.FieldConsBox)
        Me.GroupBox9.Controls.Add(Me.ConsType)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.ConsList)
        Me.GroupBox9.Controls.Add(Me.ConsPositn)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 360)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(436, 162)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Constraints"
        '
        'FieldConsBox
        '
        Me.FieldConsBox.AutoSize = True
        Me.FieldConsBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldConsBox.Location = New System.Drawing.Point(5, 33)
        Me.FieldConsBox.Name = "FieldConsBox"
        Me.FieldConsBox.Size = New System.Drawing.Size(73, 17)
        Me.FieldConsBox.TabIndex = 48
        Me.FieldConsBox.Text = "Constraint"
        Me.FieldConsBox.UseVisualStyleBackColor = True
        '
        'ConsType
        '
        Me.ConsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConsType.Enabled = False
        Me.ConsType.FormattingEnabled = True
        Me.ConsType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConsType.Items.AddRange(New Object() {"Like", "Predefied", "Numeric/Logical/Other"})
        Me.ConsType.Location = New System.Drawing.Point(94, 31)
        Me.ConsType.Name = "ConsType"
        Me.ConsType.Size = New System.Drawing.Size(156, 21)
        Me.ConsType.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(91, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Constraint Type"
        '
        'ConsList
        '
        Me.ConsList.Enabled = False
        Me.ConsList.Location = New System.Drawing.Point(5, 72)
        Me.ConsList.Multiline = True
        Me.ConsList.Name = "ConsList"
        Me.ConsList.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ConsList.Size = New System.Drawing.Size(419, 75)
        Me.ConsList.TabIndex = 53
        Me.ConsList.WordWrap = False
        '
        'ConsPositn
        '
        Me.ConsPositn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConsPositn.Enabled = False
        Me.ConsPositn.FormattingEnabled = True
        Me.ConsPositn.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConsPositn.Items.AddRange(New Object() {"Before Any", "After Any", "Between Any", "Other/Specific"})
        Me.ConsPositn.Location = New System.Drawing.Point(268, 31)
        Me.ConsPositn.Name = "ConsPositn"
        Me.ConsPositn.Size = New System.Drawing.Size(156, 21)
        Me.ConsPositn.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(265, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Constraint Position"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OnDeleteAction)
        Me.GroupBox3.Controls.Add(Me.OnUpdateAction)
        Me.GroupBox3.Controls.Add(Me.OnDeleteBox)
        Me.GroupBox3.Controls.Add(Me.OnUpdateBox)
        Me.GroupBox3.Controls.Add(Me.ReferenceBox)
        Me.GroupBox3.Controls.Add(Me.ReferenceText)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 222)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 132)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Referential"
        '
        'OnDeleteAction
        '
        Me.OnDeleteAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OnDeleteAction.Enabled = False
        Me.OnDeleteAction.FormattingEnabled = True
        Me.OnDeleteAction.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.OnDeleteAction.Items.AddRange(New Object() {"CASCADE", "SET NULL", "SET DEFAULT", "NO ACTION"})
        Me.OnDeleteAction.Location = New System.Drawing.Point(93, 95)
        Me.OnDeleteAction.Name = "OnDeleteAction"
        Me.OnDeleteAction.Size = New System.Drawing.Size(129, 21)
        Me.OnDeleteAction.TabIndex = 61
        '
        'OnUpdateAction
        '
        Me.OnUpdateAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OnUpdateAction.Enabled = False
        Me.OnUpdateAction.FormattingEnabled = True
        Me.OnUpdateAction.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.OnUpdateAction.Items.AddRange(New Object() {"CASCADE", "SET NULL", "SET DEFAULT", "NO ACTION"})
        Me.OnUpdateAction.Location = New System.Drawing.Point(93, 59)
        Me.OnUpdateAction.Name = "OnUpdateAction"
        Me.OnUpdateAction.Size = New System.Drawing.Size(129, 21)
        Me.OnUpdateAction.TabIndex = 60
        '
        'OnDeleteBox
        '
        Me.OnDeleteBox.AutoSize = True
        Me.OnDeleteBox.Enabled = False
        Me.OnDeleteBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OnDeleteBox.Location = New System.Drawing.Point(6, 95)
        Me.OnDeleteBox.Name = "OnDeleteBox"
        Me.OnDeleteBox.Size = New System.Drawing.Size(74, 17)
        Me.OnDeleteBox.TabIndex = 59
        Me.OnDeleteBox.Text = "On Delete"
        Me.OnDeleteBox.UseVisualStyleBackColor = True
        '
        'OnUpdateBox
        '
        Me.OnUpdateBox.AutoSize = True
        Me.OnUpdateBox.Enabled = False
        Me.OnUpdateBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OnUpdateBox.Location = New System.Drawing.Point(6, 63)
        Me.OnUpdateBox.Name = "OnUpdateBox"
        Me.OnUpdateBox.Size = New System.Drawing.Size(78, 17)
        Me.OnUpdateBox.TabIndex = 57
        Me.OnUpdateBox.Text = "On Update"
        Me.OnUpdateBox.UseVisualStyleBackColor = True
        '
        'ReferenceBox
        '
        Me.ReferenceBox.AutoSize = True
        Me.ReferenceBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ReferenceBox.Location = New System.Drawing.Point(6, 28)
        Me.ReferenceBox.Name = "ReferenceBox"
        Me.ReferenceBox.Size = New System.Drawing.Size(81, 17)
        Me.ReferenceBox.TabIndex = 54
        Me.ReferenceBox.Text = "References"
        Me.ReferenceBox.UseVisualStyleBackColor = True
        '
        'ReferenceText
        '
        Me.ReferenceText.Enabled = False
        Me.ReferenceText.Location = New System.Drawing.Point(93, 25)
        Me.ReferenceText.Name = "ReferenceText"
        Me.ReferenceText.Size = New System.Drawing.Size(212, 20)
        Me.ReferenceText.TabIndex = 55
        '
        'CompleteTable
        '
        Me.CompleteTable.AutoSize = True
        Me.CompleteTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CompleteTable.Depth = 0
        Me.CompleteTable.Location = New System.Drawing.Point(7, 555)
        Me.CompleteTable.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CompleteTable.MouseState = MaterialSkin.MouseState.HOVER
        Me.CompleteTable.Name = "CompleteTable"
        Me.CompleteTable.Primary = False
        Me.CompleteTable.Size = New System.Drawing.Size(166, 36)
        Me.CompleteTable.TabIndex = 57
        Me.CompleteTable.Text = "Complete Statement"
        Me.CompleteTable.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(5, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Add Fields"
        '
        'AddField
        '
        Me.AddField.AutoSize = True
        Me.AddField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddField.Depth = 0
        Me.AddField.Location = New System.Drawing.Point(8, 516)
        Me.AddField.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddField.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddField.Name = "AddField"
        Me.AddField.Primary = False
        Me.AddField.Size = New System.Drawing.Size(78, 36)
        Me.AddField.TabIndex = 47
        Me.AddField.Text = "Add Field"
        Me.AddField.UseVisualStyleBackColor = True
        '
        'FieldSize
        '
        Me.FieldSize.Enabled = False
        Me.FieldSize.Location = New System.Drawing.Point(173, 190)
        Me.FieldSize.Name = "FieldSize"
        Me.FieldSize.Size = New System.Drawing.Size(85, 20)
        Me.FieldSize.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(170, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Size"
        '
        'PrimCheck
        '
        Me.PrimCheck.AutoSize = True
        Me.PrimCheck.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PrimCheck.Location = New System.Drawing.Point(11, 131)
        Me.PrimCheck.Name = "PrimCheck"
        Me.PrimCheck.Size = New System.Drawing.Size(81, 17)
        Me.PrimCheck.TabIndex = 44
        Me.PrimCheck.Text = "Primary Key"
        Me.PrimCheck.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(4, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Type"
        '
        'FieldType
        '
        Me.FieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldType.FormattingEnabled = True
        Me.FieldType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldType.Items.AddRange(New Object() {"CHAR", "VARCHAR", "BIT", "INTEGER", "SMALLINT", "DECIMAL", "NUMERIC", "REAL", "FLOAT", "DATE", "TIME"})
        Me.FieldType.Location = New System.Drawing.Point(7, 190)
        Me.FieldType.Name = "FieldType"
        Me.FieldType.Size = New System.Drawing.Size(129, 21)
        Me.FieldType.TabIndex = 42
        '
        'FieldField
        '
        Me.FieldField.Depth = 0
        Me.FieldField.Hint = ""
        Me.FieldField.Location = New System.Drawing.Point(7, 93)
        Me.FieldField.MouseState = MaterialSkin.MouseState.HOVER
        Me.FieldField.Name = "FieldField"
        Me.FieldField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FieldField.SelectedText = ""
        Me.FieldField.SelectionLength = 0
        Me.FieldField.SelectionStart = 0
        Me.FieldField.Size = New System.Drawing.Size(435, 23)
        Me.FieldField.TabIndex = 41
        Me.FieldField.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(155, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Enter Field Name"
        '
        'NewTableCreate
        '
        Me.NewTableCreate.AutoSize = True
        Me.NewTableCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NewTableCreate.Depth = 0
        Me.NewTableCreate.Location = New System.Drawing.Point(386, 14)
        Me.NewTableCreate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.NewTableCreate.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableCreate.Name = "NewTableCreate"
        Me.NewTableCreate.Primary = False
        Me.NewTableCreate.Size = New System.Drawing.Size(62, 36)
        Me.NewTableCreate.TabIndex = 39
        Me.NewTableCreate.Text = "Create"
        Me.NewTableCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(155, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Enter Table Name"
        '
        'NewTableField
        '
        Me.NewTableField.Depth = 0
        Me.NewTableField.Hint = ""
        Me.NewTableField.Location = New System.Drawing.Point(7, 27)
        Me.NewTableField.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableField.Name = "NewTableField"
        Me.NewTableField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewTableField.SelectedText = ""
        Me.NewTableField.SelectionLength = 0
        Me.NewTableField.SelectionStart = 0
        Me.NewTableField.Size = New System.Drawing.Size(370, 23)
        Me.NewTableField.TabIndex = 37
        Me.NewTableField.UseSystemPasswordChar = False
        '
        'NewTablePanel
        '
        Me.NewTablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewTablePanel.Location = New System.Drawing.Point(3, 16)
        Me.NewTablePanel.Name = "NewTablePanel"
        Me.NewTablePanel.Size = New System.Drawing.Size(452, 597)
        Me.NewTablePanel.TabIndex = 58
        '
        'UpdatePanel
        '
        Me.UpdatePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdatePanel.Location = New System.Drawing.Point(3, 16)
        Me.UpdatePanel.Name = "UpdatePanel"
        Me.UpdatePanel.Size = New System.Drawing.Size(452, 597)
        Me.UpdatePanel.TabIndex = 58
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
        'Scale
        '
        Me.Scale.Location = New System.Drawing.Point(347, 190)
        Me.Scale.Name = "Scale"
        Me.Scale.Size = New System.Drawing.Size(41, 20)
        Me.Scale.TabIndex = 62
        '
        'Precision
        '
        Me.Precision.Location = New System.Drawing.Point(300, 190)
        Me.Precision.Name = "Precision"
        Me.Precision.Size = New System.Drawing.Size(41, 20)
        Me.Precision.TabIndex = 63
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1164, 773)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Home"
        Me.Text = "SQL Data Definiton Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelAction.ResumeLayout(False)
        Me.ActionGroup.ResumeLayout(False)
        Me.CreatePanel.ResumeLayout(False)
        Me.CreatePanel.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Scale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Precision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Act_Create_Table As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Drop As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Update As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Sequence As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelAction As Panel
    Friend WithEvents ActionGroup As GroupBox
    Friend WithEvents CreatePanel As Panel
    Friend WithEvents CompleteTable As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label7 As Label
    Friend WithEvents ReferenceText As TextBox
    Friend WithEvents ReferenceBox As CheckBox
    Friend WithEvents ConsList As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ConsPositn As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ConsType As ComboBox
    Friend WithEvents FieldConsBox As CheckBox
    Friend WithEvents AddField As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FieldSize As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents PrimCheck As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FieldType As ComboBox
    Friend WithEvents FieldField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As Label
    Friend WithEvents NewTableCreate As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents NewTableField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents NewTablePanel As Panel
    Friend WithEvents UpdatePanel As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OnDeleteBox As CheckBox
    Friend WithEvents OnUpdateBox As CheckBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents OnDeleteAction As ComboBox
    Friend WithEvents OnUpdateAction As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Precision As NumericUpDown
    Friend WithEvents Scale As NumericUpDown
End Class
