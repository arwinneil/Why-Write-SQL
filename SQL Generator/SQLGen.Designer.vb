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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sequence = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Container = New System.Windows.Forms.Panel()
        Me.ActionGroup = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CompleteTable = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AddField = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.ConsType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConsList = New System.Windows.Forms.TextBox()
        Me.ConsPositn = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.NotNull = New System.Windows.Forms.CheckBox()
        Me.PrimCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OnDeleteAction = New System.Windows.Forms.ComboBox()
        Me.OnUpdateAction = New System.Windows.Forms.ComboBox()
        Me.OnDeleteBox = New System.Windows.Forms.CheckBox()
        Me.OnUpdateBox = New System.Windows.Forms.CheckBox()
        Me.ReferenceBox = New System.Windows.Forms.CheckBox()
        Me.ReferenceText = New System.Windows.Forms.TextBox()
        Me.PrimaryKeyGroup = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FieldGroup = New System.Windows.Forms.GroupBox()
        Me.Precision = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FieldSize = New System.Windows.Forms.NumericUpDown()
        Me.Scale = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FieldType = New System.Windows.Forms.ComboBox()
        Me.FieldField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ForeignKeyGroup = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreateButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.NewTableField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.OperationsPanel = New System.Windows.Forms.Panel()
        Me.Act_Create_Table = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Update = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Drop = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Container.SuspendLayout()
        Me.ActionGroup.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PrimaryKeyGroup.SuspendLayout()
        Me.FieldGroup.SuspendLayout()
        CType(Me.Precision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ForeignKeyGroup.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.OperationsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 6)
        Me.GroupBox1.Controls.Add(Me.Sequence)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(467, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox1, 10)
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
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Container, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OperationsPanel, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1164, 777)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Container
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Container, 4)
        Me.Container.Controls.Add(Me.ActionGroup)
        Me.Container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Container.Location = New System.Drawing.Point(3, 80)
        Me.Container.Name = "Container"
        Me.TableLayoutPanel1.SetRowSpan(Me.Container, 9)
        Me.Container.Size = New System.Drawing.Size(458, 694)
        Me.Container.TabIndex = 0
        '
        'ActionGroup
        '
        Me.ActionGroup.Controls.Add(Me.TableLayoutPanel2)
        Me.ActionGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionGroup.Location = New System.Drawing.Point(0, 0)
        Me.ActionGroup.Name = "ActionGroup"
        Me.ActionGroup.Size = New System.Drawing.Size(458, 694)
        Me.ActionGroup.TabIndex = 6
        Me.ActionGroup.TabStop = False
        Me.ActionGroup.Text = "Action"
        Me.ActionGroup.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.PrimaryKeyGroup, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.FieldGroup, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ForeignKeyGroup, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 12
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(452, 675)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CompleteTable)
        Me.Panel1.Controls.Add(Me.AddField)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton1)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 395)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel2.SetRowSpan(Me.Panel1, 5)
        Me.Panel1.Size = New System.Drawing.Size(446, 277)
        Me.Panel1.TabIndex = 9
        '
        'CompleteTable
        '
        Me.CompleteTable.AutoSize = True
        Me.CompleteTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CompleteTable.Depth = 0
        Me.CompleteTable.Location = New System.Drawing.Point(164, 235)
        Me.CompleteTable.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CompleteTable.MouseState = MaterialSkin.MouseState.HOVER
        Me.CompleteTable.Name = "CompleteTable"
        Me.CompleteTable.Primary = False
        Me.CompleteTable.Size = New System.Drawing.Size(166, 36)
        Me.CompleteTable.TabIndex = 67
        Me.CompleteTable.Text = "Complete Statement"
        Me.CompleteTable.UseVisualStyleBackColor = True
        '
        'AddField
        '
        Me.AddField.AutoSize = True
        Me.AddField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddField.Depth = 0
        Me.AddField.Location = New System.Drawing.Point(8, 235)
        Me.AddField.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AddField.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddField.Name = "AddField"
        Me.AddField.Primary = False
        Me.AddField.Size = New System.Drawing.Size(78, 36)
        Me.AddField.TabIndex = 66
        Me.AddField.Text = "Add Field"
        Me.AddField.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(94, 235)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(67, 36)
        Me.MaterialFlatButton1.TabIndex = 65
        Me.MaterialFlatButton1.Text = "Add Key"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.ConsType)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.ConsList)
        Me.GroupBox9.Controls.Add(Me.ConsPositn)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Location = New System.Drawing.Point(3, 95)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(442, 133)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Check"
        '
        'ConsType
        '
        Me.ConsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConsType.Enabled = False
        Me.ConsType.FormattingEnabled = True
        Me.ConsType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ConsType.Items.AddRange(New Object() {"Like", "Predefied", "Numeric/Logical/Other"})
        Me.ConsType.Location = New System.Drawing.Point(38, 32)
        Me.ConsType.Name = "ConsType"
        Me.ConsType.Size = New System.Drawing.Size(156, 21)
        Me.ConsType.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(36, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Check Type"
        '
        'ConsList
        '
        Me.ConsList.Enabled = False
        Me.ConsList.Location = New System.Drawing.Point(6, 58)
        Me.ConsList.Multiline = True
        Me.ConsList.Name = "ConsList"
        Me.ConsList.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ConsList.Size = New System.Drawing.Size(419, 67)
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
        Me.ConsPositn.Location = New System.Drawing.Point(212, 32)
        Me.ConsPositn.Name = "ConsPositn"
        Me.ConsPositn.Size = New System.Drawing.Size(156, 21)
        Me.ConsPositn.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(209, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "String Position"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.NotNull)
        Me.GroupBox2.Controls.Add(Me.PrimCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(108, 90)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Constraints"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckBox2.Location = New System.Drawing.Point(6, 65)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox2.TabIndex = 57
        Me.CheckBox2.Text = "UNIQUE"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'NotNull
        '
        Me.NotNull.AutoSize = True
        Me.NotNull.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NotNull.Location = New System.Drawing.Point(6, 42)
        Me.NotNull.Name = "NotNull"
        Me.NotNull.Size = New System.Drawing.Size(80, 17)
        Me.NotNull.TabIndex = 54
        Me.NotNull.Text = "NOT NULL"
        Me.NotNull.UseVisualStyleBackColor = True
        '
        'PrimCheck
        '
        Me.PrimCheck.AutoSize = True
        Me.PrimCheck.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PrimCheck.Location = New System.Drawing.Point(6, 19)
        Me.PrimCheck.Name = "PrimCheck"
        Me.PrimCheck.Size = New System.Drawing.Size(99, 17)
        Me.PrimCheck.TabIndex = 44
        Me.PrimCheck.Text = "PRIMARY KEY"
        Me.PrimCheck.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OnDeleteAction)
        Me.GroupBox3.Controls.Add(Me.OnUpdateAction)
        Me.GroupBox3.Controls.Add(Me.OnDeleteBox)
        Me.GroupBox3.Controls.Add(Me.OnUpdateBox)
        Me.GroupBox3.Controls.Add(Me.ReferenceBox)
        Me.GroupBox3.Controls.Add(Me.ReferenceText)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 90)
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
        Me.OnDeleteAction.Location = New System.Drawing.Point(88, 65)
        Me.OnDeleteAction.Name = "OnDeleteAction"
        Me.OnDeleteAction.Size = New System.Drawing.Size(124, 21)
        Me.OnDeleteAction.TabIndex = 61
        '
        'OnUpdateAction
        '
        Me.OnUpdateAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OnUpdateAction.Enabled = False
        Me.OnUpdateAction.FormattingEnabled = True
        Me.OnUpdateAction.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.OnUpdateAction.Items.AddRange(New Object() {"CASCADE", "SET NULL", "SET DEFAULT", "NO ACTION"})
        Me.OnUpdateAction.Location = New System.Drawing.Point(88, 40)
        Me.OnUpdateAction.Name = "OnUpdateAction"
        Me.OnUpdateAction.Size = New System.Drawing.Size(124, 21)
        Me.OnUpdateAction.TabIndex = 60
        '
        'OnDeleteBox
        '
        Me.OnDeleteBox.AutoSize = True
        Me.OnDeleteBox.Enabled = False
        Me.OnDeleteBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OnDeleteBox.Location = New System.Drawing.Point(5, 69)
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
        Me.OnUpdateBox.Location = New System.Drawing.Point(6, 44)
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
        Me.ReferenceBox.Location = New System.Drawing.Point(6, 19)
        Me.ReferenceBox.Name = "ReferenceBox"
        Me.ReferenceBox.Size = New System.Drawing.Size(81, 17)
        Me.ReferenceBox.TabIndex = 54
        Me.ReferenceBox.Text = "References"
        Me.ReferenceBox.UseVisualStyleBackColor = True
        '
        'ReferenceText
        '
        Me.ReferenceText.Enabled = False
        Me.ReferenceText.Location = New System.Drawing.Point(88, 16)
        Me.ReferenceText.Name = "ReferenceText"
        Me.ReferenceText.Size = New System.Drawing.Size(153, 20)
        Me.ReferenceText.TabIndex = 55
        '
        'PrimaryKeyGroup
        '
        Me.PrimaryKeyGroup.Controls.Add(Me.TextBox1)
        Me.PrimaryKeyGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrimaryKeyGroup.Enabled = False
        Me.PrimaryKeyGroup.Location = New System.Drawing.Point(3, 171)
        Me.PrimaryKeyGroup.Name = "PrimaryKeyGroup"
        Me.TableLayoutPanel2.SetRowSpan(Me.PrimaryKeyGroup, 2)
        Me.PrimaryKeyGroup.Size = New System.Drawing.Size(446, 106)
        Me.PrimaryKeyGroup.TabIndex = 7
        Me.PrimaryKeyGroup.TabStop = False
        Me.PrimaryKeyGroup.Text = "Add Primary Key"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(8, 20)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(432, 80)
        Me.TextBox1.TabIndex = 54
        Me.TextBox1.WordWrap = False
        '
        'FieldGroup
        '
        Me.FieldGroup.Controls.Add(Me.Precision)
        Me.FieldGroup.Controls.Add(Me.Label4)
        Me.FieldGroup.Controls.Add(Me.FieldSize)
        Me.FieldGroup.Controls.Add(Me.Scale)
        Me.FieldGroup.Controls.Add(Me.Label3)
        Me.FieldGroup.Controls.Add(Me.Label8)
        Me.FieldGroup.Controls.Add(Me.FieldType)
        Me.FieldGroup.Controls.Add(Me.FieldField)
        Me.FieldGroup.Controls.Add(Me.Label2)
        Me.FieldGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldGroup.Enabled = False
        Me.FieldGroup.Location = New System.Drawing.Point(3, 59)
        Me.FieldGroup.Name = "FieldGroup"
        Me.TableLayoutPanel2.SetRowSpan(Me.FieldGroup, 2)
        Me.FieldGroup.Size = New System.Drawing.Size(446, 106)
        Me.FieldGroup.TabIndex = 6
        Me.FieldGroup.TabStop = False
        Me.FieldGroup.Text = "Add Field"
        '
        'Precision
        '
        Me.Precision.Location = New System.Drawing.Point(297, 81)
        Me.Precision.Name = "Precision"
        Me.Precision.Size = New System.Drawing.Size(41, 20)
        Me.Precision.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(188, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Size"
        '
        'FieldSize
        '
        Me.FieldSize.Enabled = False
        Me.FieldSize.Location = New System.Drawing.Point(170, 81)
        Me.FieldSize.Name = "FieldSize"
        Me.FieldSize.Size = New System.Drawing.Size(85, 20)
        Me.FieldSize.TabIndex = 46
        '
        'Scale
        '
        Me.Scale.Location = New System.Drawing.Point(344, 81)
        Me.Scale.Name = "Scale"
        Me.Scale.Size = New System.Drawing.Size(41, 20)
        Me.Scale.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(50, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(294, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "(Presision , Scale)"
        '
        'FieldType
        '
        Me.FieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldType.FormattingEnabled = True
        Me.FieldType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldType.Items.AddRange(New Object() {"CHAR", "VARCHAR", "BIT", "INTEGER", "SMALLINT", "DECIMAL", "NUMERIC", "REAL", "FLOAT", "DATE", "TIME"})
        Me.FieldType.Location = New System.Drawing.Point(6, 79)
        Me.FieldType.Name = "FieldType"
        Me.FieldType.Size = New System.Drawing.Size(129, 21)
        Me.FieldType.TabIndex = 42
        '
        'FieldField
        '
        Me.FieldField.Depth = 0
        Me.FieldField.Hint = ""
        Me.FieldField.Location = New System.Drawing.Point(8, 29)
        Me.FieldField.MouseState = MaterialSkin.MouseState.HOVER
        Me.FieldField.Name = "FieldField"
        Me.FieldField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FieldField.SelectedText = ""
        Me.FieldField.SelectionLength = 0
        Me.FieldField.SelectionStart = 0
        Me.FieldField.Size = New System.Drawing.Size(432, 23)
        Me.FieldField.TabIndex = 41
        Me.FieldField.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(166, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Enter Field Name"
        '
        'ForeignKeyGroup
        '
        Me.ForeignKeyGroup.Controls.Add(Me.TextBox2)
        Me.ForeignKeyGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeignKeyGroup.Enabled = False
        Me.ForeignKeyGroup.Location = New System.Drawing.Point(3, 283)
        Me.ForeignKeyGroup.Name = "ForeignKeyGroup"
        Me.TableLayoutPanel2.SetRowSpan(Me.ForeignKeyGroup, 2)
        Me.ForeignKeyGroup.Size = New System.Drawing.Size(446, 106)
        Me.ForeignKeyGroup.TabIndex = 3
        Me.ForeignKeyGroup.TabStop = False
        Me.ForeignKeyGroup.Text = "Add Foreign Key"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(6, 20)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(434, 80)
        Me.TextBox2.TabIndex = 54
        Me.TextBox2.WordWrap = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CreateButton)
        Me.Panel2.Controls.Add(Me.NewTableField)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 50)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(161, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Enter Table Name"
        '
        'CreateButton
        '
        Me.CreateButton.AutoSize = True
        Me.CreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateButton.Depth = 0
        Me.CreateButton.Location = New System.Drawing.Point(378, 8)
        Me.CreateButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CreateButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Primary = False
        Me.CreateButton.Size = New System.Drawing.Size(62, 36)
        Me.CreateButton.TabIndex = 39
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'NewTableField
        '
        Me.NewTableField.Depth = 0
        Me.NewTableField.Hint = ""
        Me.NewTableField.Location = New System.Drawing.Point(17, 17)
        Me.NewTableField.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableField.Name = "NewTableField"
        Me.NewTableField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewTableField.SelectedText = ""
        Me.NewTableField.SelectionLength = 0
        Me.NewTableField.SelectionStart = 0
        Me.NewTableField.Size = New System.Drawing.Size(354, 23)
        Me.NewTableField.TabIndex = 37
        Me.NewTableField.UseSystemPasswordChar = False
        '
        'OperationsPanel
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.OperationsPanel, 4)
        Me.OperationsPanel.Controls.Add(Me.Act_Create_Table)
        Me.OperationsPanel.Controls.Add(Me.Act_Update)
        Me.OperationsPanel.Controls.Add(Me.Act_Drop)
        Me.OperationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OperationsPanel.Location = New System.Drawing.Point(3, 3)
        Me.OperationsPanel.Name = "OperationsPanel"
        Me.OperationsPanel.Size = New System.Drawing.Size(458, 71)
        Me.OperationsPanel.TabIndex = 6
        '
        'Act_Create_Table
        '
        Me.Act_Create_Table.AutoSize = True
        Me.Act_Create_Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Create_Table.BackColor = System.Drawing.Color.White
        Me.Act_Create_Table.Depth = 0
        Me.Act_Create_Table.Location = New System.Drawing.Point(3, 0)
        Me.Act_Create_Table.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Create_Table.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Create_Table.Name = "Act_Create_Table"
        Me.Act_Create_Table.Primary = False
        Me.Act_Create_Table.Size = New System.Drawing.Size(107, 36)
        Me.Act_Create_Table.TabIndex = 0
        Me.Act_Create_Table.Text = "Create Table"
        Me.Act_Create_Table.UseVisualStyleBackColor = False
        '
        'Act_Update
        '
        Me.Act_Update.AutoSize = True
        Me.Act_Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Update.BackColor = System.Drawing.Color.White
        Me.Act_Update.Depth = 0
        Me.Act_Update.Location = New System.Drawing.Point(118, 0)
        Me.Act_Update.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Update.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Update.Name = "Act_Update"
        Me.Act_Update.Primary = False
        Me.Act_Update.Size = New System.Drawing.Size(109, 36)
        Me.Act_Update.TabIndex = 4
        Me.Act_Update.Text = "Update Table"
        Me.Act_Update.UseVisualStyleBackColor = False
        '
        'Act_Drop
        '
        Me.Act_Drop.AutoSize = True
        Me.Act_Drop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Drop.BackColor = System.Drawing.Color.White
        Me.Act_Drop.Depth = 0
        Me.Act_Drop.Location = New System.Drawing.Point(235, 0)
        Me.Act_Drop.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Drop.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Drop.Name = "Act_Drop"
        Me.Act_Drop.Primary = False
        Me.Act_Drop.Size = New System.Drawing.Size(105, 36)
        Me.Act_Drop.TabIndex = 3
        Me.Act_Drop.Text = "Delete Table"
        Me.Act_Drop.UseVisualStyleBackColor = False
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
        Me.Container.ResumeLayout(False)
        Me.ActionGroup.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PrimaryKeyGroup.ResumeLayout(False)
        Me.PrimaryKeyGroup.PerformLayout()
        Me.FieldGroup.ResumeLayout(False)
        Me.FieldGroup.PerformLayout()
        CType(Me.Precision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ForeignKeyGroup.ResumeLayout(False)
        Me.ForeignKeyGroup.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.OperationsPanel.ResumeLayout(False)
        Me.OperationsPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Sequence As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Container As Panel
    Friend WithEvents ActionGroup As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents ConsType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ConsList As TextBox
    Friend WithEvents ConsPositn As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents NotNull As CheckBox
    Friend WithEvents PrimCheck As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OnDeleteAction As ComboBox
    Friend WithEvents OnUpdateAction As ComboBox
    Friend WithEvents OnDeleteBox As CheckBox
    Friend WithEvents OnUpdateBox As CheckBox
    Friend WithEvents ReferenceBox As CheckBox
    Friend WithEvents ReferenceText As TextBox
    Friend WithEvents PrimaryKeyGroup As GroupBox
    Friend WithEvents FieldGroup As GroupBox
    Friend WithEvents Precision As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents FieldSize As NumericUpDown
    Friend WithEvents Scale As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FieldType As ComboBox
    Friend WithEvents FieldField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As Label
    Friend WithEvents ForeignKeyGroup As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents NewTableField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents OperationsPanel As Panel
    Friend WithEvents Act_Create_Table As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Update As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Drop As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents CompleteTable As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AddField As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
