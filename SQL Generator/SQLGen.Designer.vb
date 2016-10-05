<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits MaterialSkin.Controls.MaterialForm


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
        Me.Home_Main_Layout = New System.Windows.Forms.TableLayoutPanel()
        Me.ContainerPane = New System.Windows.Forms.Panel()
        Me.ActionGroup = New System.Windows.Forms.GroupBox()
        Me.AlterTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Alter_Table_Name = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.RenameGroup = New System.Windows.Forms.GroupBox()
        Me.Rename = New MaterialSkin.Controls.MaterialFlatButton()
        Me.NewTableName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DropGroup = New System.Windows.Forms.GroupBox()
        Me.Alter_Drop_Table = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DropColumn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterButtonsTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.AlterModify = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterRename = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterDrop = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterAdd = New MaterialSkin.Controls.MaterialFlatButton()
        Me.DropTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DropButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.DatabaseTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DatabaseName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Create_Database = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Select_Database = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Drop_Database = New MaterialSkin.Controls.MaterialFlatButton()
        Me.InsertTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.DataItemsGroup = New System.Windows.Forms.GroupBox()
        Me.DataItems = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Specify_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Columns = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InsertTable = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Insert_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CreateActionLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CompleteTable_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Add_Foreign_Key_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Add_Field_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Add_Primary_Key_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreateButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.NewTableField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FieldDetails = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.FieldGroup = New System.Windows.Forms.GroupBox()
        Me.Formula = New System.Windows.Forms.CheckBox()
        Me.DefaultValue = New System.Windows.Forms.TextBox()
        Me.Default_Value_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Precision = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FieldSize = New System.Windows.Forms.NumericUpDown()
        Me.Scale_ = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FieldType = New System.Windows.Forms.ComboBox()
        Me.FieldField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrimaryGroup = New System.Windows.Forms.GroupBox()
        Me.PrimaryKeys = New System.Windows.Forms.TextBox()
        Me.ForeignKeyGroup = New System.Windows.Forms.GroupBox()
        Me.ForeignKeys = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ConstraintGroup = New System.Windows.Forms.GroupBox()
        Me.ForCheck = New System.Windows.Forms.CheckBox()
        Me.Unique = New System.Windows.Forms.CheckBox()
        Me.NotNull = New System.Windows.Forms.CheckBox()
        Me.PrimCheck = New System.Windows.Forms.CheckBox()
        Me.ReferenceGroup = New System.Windows.Forms.GroupBox()
        Me.OnDeleteAction = New System.Windows.Forms.ComboBox()
        Me.OnUpdateAction = New System.Windows.Forms.ComboBox()
        Me.OnDeleteBox = New System.Windows.Forms.CheckBox()
        Me.OnUpdateBox = New System.Windows.Forms.CheckBox()
        Me.ReferenceBox = New System.Windows.Forms.CheckBox()
        Me.ReferenceText = New System.Windows.Forms.TextBox()
        Me.CreateField = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CheckGroup = New System.Windows.Forms.GroupBox()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.Check_Type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Check_String = New System.Windows.Forms.TextBox()
        Me.Check_Position = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OperationsPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Select_Query = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Alter_Table = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Create_Table = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Insert = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Drop_Table = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Database_Operations = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox1.SuspendLayout()
        Me.Home_Main_Layout.SuspendLayout()
        Me.ContainerPane.SuspendLayout()
        Me.ActionGroup.SuspendLayout()
        Me.AlterTableLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.RenameGroup.SuspendLayout()
        Me.DropGroup.SuspendLayout()
        Me.AlterButtonsTableLayout.SuspendLayout()
        Me.DropTableLayout.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.DatabaseTableLayout.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.InsertTableLayout.SuspendLayout()
        Me.DataItemsGroup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.CreateActionLayout.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FieldDetails.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.FieldGroup.SuspendLayout()
        CType(Me.Precision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scale_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrimaryGroup.SuspendLayout()
        Me.ForeignKeyGroup.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ConstraintGroup.SuspendLayout()
        Me.ReferenceGroup.SuspendLayout()
        Me.CheckGroup.SuspendLayout()
        Me.OperationsPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.Home_Main_Layout.SetColumnSpan(Me.GroupBox1, 6)
        Me.GroupBox1.Controls.Add(Me.Sequence)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(467, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.Home_Main_Layout.SetRowSpan(Me.GroupBox1, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(694, 706)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Script"
        '
        'Sequence
        '
        Me.Sequence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sequence.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sequence.FormattingEnabled = True
        Me.Sequence.HorizontalScrollbar = True
        Me.Sequence.Location = New System.Drawing.Point(3, 16)
        Me.Sequence.Name = "Sequence"
        Me.Sequence.ScrollAlwaysVisible = True
        Me.Sequence.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Sequence.Size = New System.Drawing.Size(688, 687)
        Me.Sequence.TabIndex = 0
        '
        'Home_Main_Layout
        '
        Me.Home_Main_Layout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Home_Main_Layout.AutoSize = True
        Me.Home_Main_Layout.ColumnCount = 10
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.Home_Main_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.Controls.Add(Me.ContainerPane, 0, 1)
        Me.Home_Main_Layout.Controls.Add(Me.GroupBox1, 1, 0)
        Me.Home_Main_Layout.Controls.Add(Me.OperationsPanel, 0, 0)
        Me.Home_Main_Layout.Location = New System.Drawing.Point(0, 65)
        Me.Home_Main_Layout.Name = "Home_Main_Layout"
        Me.Home_Main_Layout.RowCount = 10
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67416!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.269663!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_Main_Layout.Size = New System.Drawing.Size(1164, 712)
        Me.Home_Main_Layout.TabIndex = 1
        '
        'ContainerPane
        '
        Me.Home_Main_Layout.SetColumnSpan(Me.ContainerPane, 4)
        Me.ContainerPane.Controls.Add(Me.ActionGroup)
        Me.ContainerPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerPane.Location = New System.Drawing.Point(3, 79)
        Me.ContainerPane.Name = "ContainerPane"
        Me.Home_Main_Layout.SetRowSpan(Me.ContainerPane, 9)
        Me.ContainerPane.Size = New System.Drawing.Size(458, 630)
        Me.ContainerPane.TabIndex = 0
        '
        'ActionGroup
        '
        Me.ActionGroup.Controls.Add(Me.AlterTableLayoutPanel)
        Me.ActionGroup.Controls.Add(Me.DropTableLayout)
        Me.ActionGroup.Controls.Add(Me.DatabaseTableLayout)
        Me.ActionGroup.Controls.Add(Me.InsertTableLayout)
        Me.ActionGroup.Controls.Add(Me.CreateActionLayout)
        Me.ActionGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionGroup.Location = New System.Drawing.Point(0, 0)
        Me.ActionGroup.Name = "ActionGroup"
        Me.ActionGroup.Size = New System.Drawing.Size(458, 630)
        Me.ActionGroup.TabIndex = 6
        Me.ActionGroup.TabStop = False
        Me.ActionGroup.Text = "Action"
        Me.ActionGroup.Visible = False
        '
        'AlterTableLayoutPanel
        '
        Me.AlterTableLayoutPanel.ColumnCount = 1
        Me.AlterTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AlterTableLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.AlterTableLayoutPanel.Controls.Add(Me.Panel12, 0, 2)
        Me.AlterTableLayoutPanel.Controls.Add(Me.AlterButtonsTableLayout, 0, 1)
        Me.AlterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterTableLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.AlterTableLayoutPanel.Name = "AlterTableLayoutPanel"
        Me.AlterTableLayoutPanel.RowCount = 11
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.AlterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.AlterTableLayoutPanel.Size = New System.Drawing.Size(452, 611)
        Me.AlterTableLayoutPanel.TabIndex = 48
        Me.AlterTableLayoutPanel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Alter_Table_Name)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 49)
        Me.Panel1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(177, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Enter Table Name"
        '
        'Alter_Table_Name
        '
        Me.Alter_Table_Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Alter_Table_Name.Depth = 0
        Me.Alter_Table_Name.Hint = ""
        Me.Alter_Table_Name.Location = New System.Drawing.Point(9, 19)
        Me.Alter_Table_Name.MouseState = MaterialSkin.MouseState.HOVER
        Me.Alter_Table_Name.Name = "Alter_Table_Name"
        Me.Alter_Table_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Alter_Table_Name.SelectedText = ""
        Me.Alter_Table_Name.SelectionLength = 0
        Me.Alter_Table_Name.SelectionStart = 0
        Me.Alter_Table_Name.Size = New System.Drawing.Size(420, 23)
        Me.Alter_Table_Name.TabIndex = 37
        Me.Alter_Table_Name.UseSystemPasswordChar = False
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.RenameGroup)
        Me.Panel12.Controls.Add(Me.DropGroup)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(3, 113)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(446, 49)
        Me.Panel12.TabIndex = 5
        '
        'RenameGroup
        '
        Me.RenameGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RenameGroup.Controls.Add(Me.Rename)
        Me.RenameGroup.Controls.Add(Me.NewTableName)
        Me.RenameGroup.Location = New System.Drawing.Point(0, 2)
        Me.RenameGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.RenameGroup.Name = "RenameGroup"
        Me.RenameGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.RenameGroup.Size = New System.Drawing.Size(446, 45)
        Me.RenameGroup.TabIndex = 4
        Me.RenameGroup.TabStop = False
        Me.RenameGroup.Text = "Rename Table"
        Me.RenameGroup.Visible = False
        '
        'Rename
        '
        Me.Rename.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Rename.AutoSize = True
        Me.Rename.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Rename.BackColor = System.Drawing.Color.White
        Me.Rename.Depth = 0
        Me.Rename.ForeColor = System.Drawing.Color.Transparent
        Me.Rename.Location = New System.Drawing.Point(388, 7)
        Me.Rename.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Rename.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rename.Name = "Rename"
        Me.Rename.Primary = False
        Me.Rename.Size = New System.Drawing.Size(48, 36)
        Me.Rename.TabIndex = 39
        Me.Rename.Text = "Done"
        Me.Rename.UseVisualStyleBackColor = False
        '
        'NewTableName
        '
        Me.NewTableName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewTableName.Depth = 0
        Me.NewTableName.Hint = ""
        Me.NewTableName.Location = New System.Drawing.Point(19, 16)
        Me.NewTableName.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableName.Name = "NewTableName"
        Me.NewTableName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewTableName.SelectedText = ""
        Me.NewTableName.SelectionLength = 0
        Me.NewTableName.SelectionStart = 0
        Me.NewTableName.Size = New System.Drawing.Size(360, 23)
        Me.NewTableName.TabIndex = 38
        Me.NewTableName.UseSystemPasswordChar = False
        '
        'DropGroup
        '
        Me.DropGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropGroup.Controls.Add(Me.Alter_Drop_Table)
        Me.DropGroup.Controls.Add(Me.DropColumn)
        Me.DropGroup.Location = New System.Drawing.Point(0, 2)
        Me.DropGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.DropGroup.Name = "DropGroup"
        Me.DropGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.DropGroup.Size = New System.Drawing.Size(446, 45)
        Me.DropGroup.TabIndex = 3
        Me.DropGroup.TabStop = False
        Me.DropGroup.Text = "Drop Column"
        Me.DropGroup.Visible = False
        '
        'Alter_Drop_Table
        '
        Me.Alter_Drop_Table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Alter_Drop_Table.Depth = 0
        Me.Alter_Drop_Table.Hint = ""
        Me.Alter_Drop_Table.Location = New System.Drawing.Point(21, 16)
        Me.Alter_Drop_Table.MouseState = MaterialSkin.MouseState.HOVER
        Me.Alter_Drop_Table.Name = "Alter_Drop_Table"
        Me.Alter_Drop_Table.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Alter_Drop_Table.SelectedText = ""
        Me.Alter_Drop_Table.SelectionLength = 0
        Me.Alter_Drop_Table.SelectionStart = 0
        Me.Alter_Drop_Table.Size = New System.Drawing.Size(360, 23)
        Me.Alter_Drop_Table.TabIndex = 38
        Me.Alter_Drop_Table.UseSystemPasswordChar = False
        '
        'DropColumn
        '
        Me.DropColumn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DropColumn.AutoSize = True
        Me.DropColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DropColumn.BackColor = System.Drawing.Color.White
        Me.DropColumn.Depth = 0
        Me.DropColumn.Location = New System.Drawing.Point(390, 7)
        Me.DropColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.DropColumn.MouseState = MaterialSkin.MouseState.HOVER
        Me.DropColumn.Name = "DropColumn"
        Me.DropColumn.Primary = False
        Me.DropColumn.Size = New System.Drawing.Size(48, 36)
        Me.DropColumn.TabIndex = 39
        Me.DropColumn.Text = "Done"
        Me.DropColumn.UseVisualStyleBackColor = False
        '
        'AlterButtonsTableLayout
        '
        Me.AlterButtonsTableLayout.ColumnCount = 4
        Me.AlterButtonsTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AlterButtonsTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AlterButtonsTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AlterButtonsTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AlterButtonsTableLayout.Controls.Add(Me.AlterModify, 3, 0)
        Me.AlterButtonsTableLayout.Controls.Add(Me.AlterRename, 0, 0)
        Me.AlterButtonsTableLayout.Controls.Add(Me.AlterDrop, 2, 0)
        Me.AlterButtonsTableLayout.Controls.Add(Me.AlterAdd, 1, 0)
        Me.AlterButtonsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterButtonsTableLayout.Location = New System.Drawing.Point(3, 58)
        Me.AlterButtonsTableLayout.Name = "AlterButtonsTableLayout"
        Me.AlterButtonsTableLayout.RowCount = 1
        Me.AlterButtonsTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AlterButtonsTableLayout.Size = New System.Drawing.Size(446, 49)
        Me.AlterButtonsTableLayout.TabIndex = 6
        '
        'AlterModify
        '
        Me.AlterModify.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterModify.AutoSize = True
        Me.AlterModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterModify.Depth = 0
        Me.AlterModify.Location = New System.Drawing.Point(337, 6)
        Me.AlterModify.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterModify.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterModify.Name = "AlterModify"
        Me.AlterModify.Primary = False
        Me.AlterModify.Size = New System.Drawing.Size(105, 37)
        Me.AlterModify.TabIndex = 10
        Me.AlterModify.Text = "Modify Field"
        Me.AlterModify.UseVisualStyleBackColor = True
        '
        'AlterRename
        '
        Me.AlterRename.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterRename.AutoSize = True
        Me.AlterRename.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterRename.Depth = 0
        Me.AlterRename.Location = New System.Drawing.Point(4, 6)
        Me.AlterRename.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterRename.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterRename.Name = "AlterRename"
        Me.AlterRename.Primary = False
        Me.AlterRename.Size = New System.Drawing.Size(103, 37)
        Me.AlterRename.TabIndex = 7
        Me.AlterRename.Text = "Rename Table"
        Me.AlterRename.UseVisualStyleBackColor = True
        '
        'AlterDrop
        '
        Me.AlterDrop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterDrop.AutoSize = True
        Me.AlterDrop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterDrop.Depth = 0
        Me.AlterDrop.Location = New System.Drawing.Point(226, 6)
        Me.AlterDrop.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterDrop.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterDrop.Name = "AlterDrop"
        Me.AlterDrop.Primary = False
        Me.AlterDrop.Size = New System.Drawing.Size(103, 37)
        Me.AlterDrop.TabIndex = 9
        Me.AlterDrop.Text = "Drop Field"
        Me.AlterDrop.UseVisualStyleBackColor = True
        '
        'AlterAdd
        '
        Me.AlterAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterAdd.AutoSize = True
        Me.AlterAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterAdd.Depth = 0
        Me.AlterAdd.Location = New System.Drawing.Point(115, 6)
        Me.AlterAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterAdd.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterAdd.Name = "AlterAdd"
        Me.AlterAdd.Primary = False
        Me.AlterAdd.Size = New System.Drawing.Size(103, 37)
        Me.AlterAdd.TabIndex = 8
        Me.AlterAdd.Text = "Add Field"
        Me.AlterAdd.UseVisualStyleBackColor = True
        '
        'DropTableLayout
        '
        Me.DropTableLayout.ColumnCount = 1
        Me.DropTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DropTableLayout.Controls.Add(Me.Panel5, 0, 0)
        Me.DropTableLayout.Controls.Add(Me.Panel8, 0, 1)
        Me.DropTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropTableLayout.Location = New System.Drawing.Point(3, 16)
        Me.DropTableLayout.Name = "DropTableLayout"
        Me.DropTableLayout.RowCount = 12
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DropTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DropTableLayout.Size = New System.Drawing.Size(452, 611)
        Me.DropTableLayout.TabIndex = 47
        Me.DropTableLayout.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.TableName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(446, 44)
        Me.Panel5.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(177, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Enter Table Name"
        '
        'TableName
        '
        Me.TableName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableName.Depth = 0
        Me.TableName.Hint = ""
        Me.TableName.Location = New System.Drawing.Point(10, 21)
        Me.TableName.MouseState = MaterialSkin.MouseState.HOVER
        Me.TableName.Name = "TableName"
        Me.TableName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TableName.SelectedText = ""
        Me.TableName.SelectionLength = 0
        Me.TableName.SelectionStart = 0
        Me.TableName.Size = New System.Drawing.Size(420, 23)
        Me.TableName.TabIndex = 37
        Me.TableName.UseSystemPasswordChar = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.DropButton)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 53)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(446, 44)
        Me.Panel8.TabIndex = 44
        '
        'DropButton
        '
        Me.DropButton.AutoSize = True
        Me.DropButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DropButton.BackColor = System.Drawing.Color.White
        Me.DropButton.Depth = 0
        Me.DropButton.Location = New System.Drawing.Point(10, 6)
        Me.DropButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DropButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Primary = False
        Me.DropButton.Size = New System.Drawing.Size(48, 36)
        Me.DropButton.TabIndex = 2
        Me.DropButton.Text = "Done"
        Me.DropButton.UseVisualStyleBackColor = False
        '
        'DatabaseTableLayout
        '
        Me.DatabaseTableLayout.ColumnCount = 1
        Me.DatabaseTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatabaseTableLayout.Controls.Add(Me.Panel9, 0, 0)
        Me.DatabaseTableLayout.Controls.Add(Me.Panel10, 0, 1)
        Me.DatabaseTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatabaseTableLayout.Location = New System.Drawing.Point(3, 16)
        Me.DatabaseTableLayout.Name = "DatabaseTableLayout"
        Me.DatabaseTableLayout.RowCount = 12
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatabaseTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatabaseTableLayout.Size = New System.Drawing.Size(452, 611)
        Me.DatabaseTableLayout.TabIndex = 46
        Me.DatabaseTableLayout.Visible = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.DatabaseName)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(446, 44)
        Me.Panel9.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(167, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Enter Database Name"
        '
        'DatabaseName
        '
        Me.DatabaseName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatabaseName.Depth = 0
        Me.DatabaseName.Hint = ""
        Me.DatabaseName.Location = New System.Drawing.Point(10, 21)
        Me.DatabaseName.MouseState = MaterialSkin.MouseState.HOVER
        Me.DatabaseName.Name = "DatabaseName"
        Me.DatabaseName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DatabaseName.SelectedText = ""
        Me.DatabaseName.SelectionLength = 0
        Me.DatabaseName.SelectionStart = 0
        Me.DatabaseName.Size = New System.Drawing.Size(420, 23)
        Me.DatabaseName.TabIndex = 37
        Me.DatabaseName.UseSystemPasswordChar = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Create_Database)
        Me.Panel10.Controls.Add(Me.Select_Database)
        Me.Panel10.Controls.Add(Me.Drop_Database)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 53)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(446, 44)
        Me.Panel10.TabIndex = 44
        '
        'Create_Database
        '
        Me.Create_Database.AutoSize = True
        Me.Create_Database.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Create_Database.BackColor = System.Drawing.Color.White
        Me.Create_Database.Depth = 0
        Me.Create_Database.Location = New System.Drawing.Point(7, 8)
        Me.Create_Database.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Create_Database.MouseState = MaterialSkin.MouseState.HOVER
        Me.Create_Database.Name = "Create_Database"
        Me.Create_Database.Primary = False
        Me.Create_Database.Size = New System.Drawing.Size(135, 36)
        Me.Create_Database.TabIndex = 3
        Me.Create_Database.Text = "Create Database"
        Me.Create_Database.UseVisualStyleBackColor = False
        '
        'Select_Database
        '
        Me.Select_Database.AutoSize = True
        Me.Select_Database.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Select_Database.BackColor = System.Drawing.Color.White
        Me.Select_Database.Depth = 0
        Me.Select_Database.Location = New System.Drawing.Point(281, 8)
        Me.Select_Database.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Select_Database.MouseState = MaterialSkin.MouseState.HOVER
        Me.Select_Database.Name = "Select_Database"
        Me.Select_Database.Primary = False
        Me.Select_Database.Size = New System.Drawing.Size(133, 36)
        Me.Select_Database.TabIndex = 1
        Me.Select_Database.Text = "Select Database"
        Me.Select_Database.UseVisualStyleBackColor = False
        '
        'Drop_Database
        '
        Me.Drop_Database.AutoSize = True
        Me.Drop_Database.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Drop_Database.BackColor = System.Drawing.Color.White
        Me.Drop_Database.Depth = 0
        Me.Drop_Database.Location = New System.Drawing.Point(152, 8)
        Me.Drop_Database.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Drop_Database.MouseState = MaterialSkin.MouseState.HOVER
        Me.Drop_Database.Name = "Drop_Database"
        Me.Drop_Database.Primary = False
        Me.Drop_Database.Size = New System.Drawing.Size(121, 36)
        Me.Drop_Database.TabIndex = 2
        Me.Drop_Database.Text = "Drop Database"
        Me.Drop_Database.UseVisualStyleBackColor = False
        '
        'InsertTableLayout
        '
        Me.InsertTableLayout.ColumnCount = 1
        Me.InsertTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InsertTableLayout.Controls.Add(Me.DataItemsGroup, 0, 6)
        Me.InsertTableLayout.Controls.Add(Me.GroupBox2, 0, 1)
        Me.InsertTableLayout.Controls.Add(Me.Panel6, 0, 0)
        Me.InsertTableLayout.Controls.Add(Me.Panel7, 0, 10)
        Me.InsertTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InsertTableLayout.Location = New System.Drawing.Point(3, 16)
        Me.InsertTableLayout.Name = "InsertTableLayout"
        Me.InsertTableLayout.RowCount = 12
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.298701!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.25974!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InsertTableLayout.Size = New System.Drawing.Size(452, 611)
        Me.InsertTableLayout.TabIndex = 44
        Me.InsertTableLayout.Visible = False
        '
        'DataItemsGroup
        '
        Me.DataItemsGroup.Controls.Add(Me.DataItems)
        Me.DataItemsGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataItemsGroup.Location = New System.Drawing.Point(3, 303)
        Me.DataItemsGroup.Name = "DataItemsGroup"
        Me.InsertTableLayout.SetRowSpan(Me.DataItemsGroup, 4)
        Me.DataItemsGroup.Size = New System.Drawing.Size(446, 194)
        Me.DataItemsGroup.TabIndex = 43
        Me.DataItemsGroup.TabStop = False
        Me.DataItemsGroup.Text = "Data Items"
        '
        'DataItems
        '
        Me.DataItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataItems.Location = New System.Drawing.Point(10, 19)
        Me.DataItems.Multiline = True
        Me.DataItems.Name = "DataItems"
        Me.DataItems.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DataItems.Size = New System.Drawing.Size(427, 169)
        Me.DataItems.TabIndex = 54
        Me.DataItems.WordWrap = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Specify_CheckBox)
        Me.GroupBox2.Controls.Add(Me.Columns)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.InsertTableLayout.SetRowSpan(Me.GroupBox2, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(446, 244)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Specify Columns"
        '
        'Specify_CheckBox
        '
        Me.Specify_CheckBox.AutoSize = True
        Me.Specify_CheckBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Specify_CheckBox.Location = New System.Drawing.Point(10, 27)
        Me.Specify_CheckBox.Name = "Specify_CheckBox"
        Me.Specify_CheckBox.Size = New System.Drawing.Size(157, 17)
        Me.Specify_CheckBox.TabIndex = 55
        Me.Specify_CheckBox.Text = "Insert Into Specific Columns"
        Me.Specify_CheckBox.UseVisualStyleBackColor = True
        '
        'Columns
        '
        Me.Columns.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Columns.Enabled = False
        Me.Columns.Location = New System.Drawing.Point(9, 56)
        Me.Columns.Multiline = True
        Me.Columns.Name = "Columns"
        Me.Columns.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Columns.Size = New System.Drawing.Size(427, 188)
        Me.Columns.TabIndex = 54
        Me.Columns.WordWrap = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.InsertTable)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(446, 44)
        Me.Panel6.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(177, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Enter Table Name"
        '
        'InsertTable
        '
        Me.InsertTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InsertTable.Depth = 0
        Me.InsertTable.Hint = ""
        Me.InsertTable.Location = New System.Drawing.Point(10, 21)
        Me.InsertTable.MouseState = MaterialSkin.MouseState.HOVER
        Me.InsertTable.Name = "InsertTable"
        Me.InsertTable.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InsertTable.SelectedText = ""
        Me.InsertTable.SelectionLength = 0
        Me.InsertTable.SelectionStart = 0
        Me.InsertTable.Size = New System.Drawing.Size(420, 23)
        Me.InsertTable.TabIndex = 37
        Me.InsertTable.UseSystemPasswordChar = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Insert_Button)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 503)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(446, 44)
        Me.Panel7.TabIndex = 44
        '
        'Insert_Button
        '
        Me.Insert_Button.AutoSize = True
        Me.Insert_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Insert_Button.Depth = 0
        Me.Insert_Button.Location = New System.Drawing.Point(9, 2)
        Me.Insert_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Insert_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Primary = False
        Me.Insert_Button.Size = New System.Drawing.Size(48, 36)
        Me.Insert_Button.TabIndex = 39
        Me.Insert_Button.Text = "Done"
        Me.Insert_Button.UseVisualStyleBackColor = True
        '
        'CreateActionLayout
        '
        Me.CreateActionLayout.ColumnCount = 1
        Me.CreateActionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CreateActionLayout.Controls.Add(Me.Panel4, 0, 1)
        Me.CreateActionLayout.Controls.Add(Me.Panel2, 0, 0)
        Me.CreateActionLayout.Controls.Add(Me.FieldDetails, 0, 2)
        Me.CreateActionLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateActionLayout.Location = New System.Drawing.Point(3, 16)
        Me.CreateActionLayout.Name = "CreateActionLayout"
        Me.CreateActionLayout.RowCount = 11
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreateActionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CreateActionLayout.Size = New System.Drawing.Size(452, 611)
        Me.CreateActionLayout.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CompleteTable_Button)
        Me.Panel4.Controls.Add(Me.Add_Foreign_Key_Button)
        Me.Panel4.Controls.Add(Me.Add_Field_Button)
        Me.Panel4.Controls.Add(Me.Add_Primary_Key_Button)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 58)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(446, 49)
        Me.Panel4.TabIndex = 11
        '
        'CompleteTable_Button
        '
        Me.CompleteTable_Button.AutoSize = True
        Me.CompleteTable_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CompleteTable_Button.Depth = 0
        Me.CompleteTable_Button.Enabled = False
        Me.CompleteTable_Button.Location = New System.Drawing.Point(355, 7)
        Me.CompleteTable_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CompleteTable_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.CompleteTable_Button.Name = "CompleteTable_Button"
        Me.CompleteTable_Button.Primary = False
        Me.CompleteTable_Button.Size = New System.Drawing.Size(82, 36)
        Me.CompleteTable_Button.TabIndex = 68
        Me.CompleteTable_Button.Text = "complete"
        Me.CompleteTable_Button.UseVisualStyleBackColor = True
        '
        'Add_Foreign_Key_Button
        '
        Me.Add_Foreign_Key_Button.AutoSize = True
        Me.Add_Foreign_Key_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Add_Foreign_Key_Button.Depth = 0
        Me.Add_Foreign_Key_Button.Enabled = False
        Me.Add_Foreign_Key_Button.Location = New System.Drawing.Point(220, 8)
        Me.Add_Foreign_Key_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Add_Foreign_Key_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Add_Foreign_Key_Button.Name = "Add_Foreign_Key_Button"
        Me.Add_Foreign_Key_Button.Primary = False
        Me.Add_Foreign_Key_Button.Size = New System.Drawing.Size(127, 36)
        Me.Add_Foreign_Key_Button.TabIndex = 67
        Me.Add_Foreign_Key_Button.Text = "Add Foreign Key"
        Me.Add_Foreign_Key_Button.UseVisualStyleBackColor = True
        '
        'Add_Field_Button
        '
        Me.Add_Field_Button.AutoSize = True
        Me.Add_Field_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Add_Field_Button.Depth = 0
        Me.Add_Field_Button.Enabled = False
        Me.Add_Field_Button.Location = New System.Drawing.Point(10, 8)
        Me.Add_Field_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Add_Field_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Add_Field_Button.Name = "Add_Field_Button"
        Me.Add_Field_Button.Primary = False
        Me.Add_Field_Button.Size = New System.Drawing.Size(78, 36)
        Me.Add_Field_Button.TabIndex = 66
        Me.Add_Field_Button.Text = "Add Field"
        Me.Add_Field_Button.UseVisualStyleBackColor = True
        '
        'Add_Primary_Key_Button
        '
        Me.Add_Primary_Key_Button.AutoSize = True
        Me.Add_Primary_Key_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Add_Primary_Key_Button.Depth = 0
        Me.Add_Primary_Key_Button.Enabled = False
        Me.Add_Primary_Key_Button.Location = New System.Drawing.Point(94, 8)
        Me.Add_Primary_Key_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Add_Primary_Key_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Add_Primary_Key_Button.Name = "Add_Primary_Key_Button"
        Me.Add_Primary_Key_Button.Primary = False
        Me.Add_Primary_Key_Button.Size = New System.Drawing.Size(121, 36)
        Me.Add_Primary_Key_Button.TabIndex = 65
        Me.Add_Primary_Key_Button.Text = "Add Primay Key"
        Me.Add_Primary_Key_Button.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CreateButton)
        Me.Panel2.Controls.Add(Me.NewTableField)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 49)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(161, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Enter Table Name"
        '
        'CreateButton
        '
        Me.CreateButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CreateButton.AutoSize = True
        Me.CreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateButton.Depth = 0
        Me.CreateButton.Location = New System.Drawing.Point(375, 8)
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
        Me.NewTableField.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewTableField.Depth = 0
        Me.NewTableField.Hint = ""
        Me.NewTableField.Location = New System.Drawing.Point(10, 19)
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
        'FieldDetails
        '
        Me.FieldDetails.Controls.Add(Me.Panel11)
        Me.FieldDetails.Controls.Add(Me.Panel3)
        Me.FieldDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldDetails.Location = New System.Drawing.Point(3, 113)
        Me.FieldDetails.Name = "FieldDetails"
        Me.CreateActionLayout.SetRowSpan(Me.FieldDetails, 9)
        Me.FieldDetails.Size = New System.Drawing.Size(446, 495)
        Me.FieldDetails.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.FieldGroup)
        Me.Panel11.Controls.Add(Me.PrimaryGroup)
        Me.Panel11.Controls.Add(Me.ForeignKeyGroup)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(446, 160)
        Me.Panel11.TabIndex = 13
        '
        'FieldGroup
        '
        Me.FieldGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldGroup.Controls.Add(Me.Formula)
        Me.FieldGroup.Controls.Add(Me.DefaultValue)
        Me.FieldGroup.Controls.Add(Me.Default_Value_Checkbox)
        Me.FieldGroup.Controls.Add(Me.Precision)
        Me.FieldGroup.Controls.Add(Me.Label4)
        Me.FieldGroup.Controls.Add(Me.FieldSize)
        Me.FieldGroup.Controls.Add(Me.Scale_)
        Me.FieldGroup.Controls.Add(Me.Label3)
        Me.FieldGroup.Controls.Add(Me.Label8)
        Me.FieldGroup.Controls.Add(Me.FieldType)
        Me.FieldGroup.Controls.Add(Me.FieldField)
        Me.FieldGroup.Controls.Add(Me.Label2)
        Me.FieldGroup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldGroup.Location = New System.Drawing.Point(0, 0)
        Me.FieldGroup.Name = "FieldGroup"
        Me.FieldGroup.Size = New System.Drawing.Size(446, 160)
        Me.FieldGroup.TabIndex = 7
        Me.FieldGroup.TabStop = False
        Me.FieldGroup.Text = "Add Field"
        '
        'Formula
        '
        Me.Formula.AccessibleDescription = "Formula"
        Me.Formula.AutoSize = True
        Me.Formula.Location = New System.Drawing.Point(109, 109)
        Me.Formula.Name = "Formula"
        Me.Formula.Size = New System.Drawing.Size(68, 30)
        Me.Formula.TabIndex = 66
        Me.Formula.Text = "Formula/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount"
        Me.Formula.UseVisualStyleBackColor = True
        '
        'DefaultValue
        '
        Me.DefaultValue.Enabled = False
        Me.DefaultValue.Location = New System.Drawing.Point(189, 114)
        Me.DefaultValue.Name = "DefaultValue"
        Me.DefaultValue.Size = New System.Drawing.Size(241, 20)
        Me.DefaultValue.TabIndex = 65
        '
        'Default_Value_Checkbox
        '
        Me.Default_Value_Checkbox.AutoSize = True
        Me.Default_Value_Checkbox.Location = New System.Drawing.Point(13, 116)
        Me.Default_Value_Checkbox.Name = "Default_Value_Checkbox"
        Me.Default_Value_Checkbox.Size = New System.Drawing.Size(90, 17)
        Me.Default_Value_Checkbox.TabIndex = 64
        Me.Default_Value_Checkbox.Text = "Default Value"
        Me.Default_Value_Checkbox.UseVisualStyleBackColor = True
        '
        'Precision
        '
        Me.Precision.Location = New System.Drawing.Point(338, 74)
        Me.Precision.Name = "Precision"
        Me.Precision.Size = New System.Drawing.Size(41, 20)
        Me.Precision.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(187, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Size"
        '
        'FieldSize
        '
        Me.FieldSize.Enabled = False
        Me.FieldSize.Location = New System.Drawing.Point(185, 74)
        Me.FieldSize.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.FieldSize.Name = "FieldSize"
        Me.FieldSize.Size = New System.Drawing.Size(85, 20)
        Me.FieldSize.TabIndex = 46
        '
        'Scale_
        '
        Me.Scale_.Location = New System.Drawing.Point(385, 74)
        Me.Scale_.Name = "Scale_"
        Me.Scale_.Size = New System.Drawing.Size(41, 20)
        Me.Scale_.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(7, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(335, 55)
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
        Me.FieldType.Location = New System.Drawing.Point(9, 74)
        Me.FieldType.Name = "FieldType"
        Me.FieldType.Size = New System.Drawing.Size(127, 21)
        Me.FieldType.TabIndex = 42
        '
        'FieldField
        '
        Me.FieldField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldField.Depth = 0
        Me.FieldField.Hint = ""
        Me.FieldField.Location = New System.Drawing.Point(9, 23)
        Me.FieldField.MouseState = MaterialSkin.MouseState.HOVER
        Me.FieldField.Name = "FieldField"
        Me.FieldField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FieldField.SelectedText = ""
        Me.FieldField.SelectionLength = 0
        Me.FieldField.SelectionStart = 0
        Me.FieldField.Size = New System.Drawing.Size(429, 23)
        Me.FieldField.TabIndex = 41
        Me.FieldField.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(166, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Enter Field Name"
        '
        'PrimaryGroup
        '
        Me.PrimaryGroup.Controls.Add(Me.PrimaryKeys)
        Me.PrimaryGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrimaryGroup.Location = New System.Drawing.Point(0, 0)
        Me.PrimaryGroup.Name = "PrimaryGroup"
        Me.PrimaryGroup.Size = New System.Drawing.Size(446, 160)
        Me.PrimaryGroup.TabIndex = 9
        Me.PrimaryGroup.TabStop = False
        Me.PrimaryGroup.Text = "Add Primary Key"
        '
        'PrimaryKeys
        '
        Me.PrimaryKeys.Location = New System.Drawing.Point(6, 20)
        Me.PrimaryKeys.Multiline = True
        Me.PrimaryKeys.Name = "PrimaryKeys"
        Me.PrimaryKeys.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PrimaryKeys.Size = New System.Drawing.Size(434, 124)
        Me.PrimaryKeys.TabIndex = 54
        Me.PrimaryKeys.WordWrap = False
        '
        'ForeignKeyGroup
        '
        Me.ForeignKeyGroup.Controls.Add(Me.ForeignKeys)
        Me.ForeignKeyGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeignKeyGroup.Location = New System.Drawing.Point(0, 0)
        Me.ForeignKeyGroup.Name = "ForeignKeyGroup"
        Me.ForeignKeyGroup.Size = New System.Drawing.Size(446, 160)
        Me.ForeignKeyGroup.TabIndex = 8
        Me.ForeignKeyGroup.TabStop = False
        Me.ForeignKeyGroup.Text = "Add Foreign Key"
        '
        'ForeignKeys
        '
        Me.ForeignKeys.Location = New System.Drawing.Point(6, 20)
        Me.ForeignKeys.Multiline = True
        Me.ForeignKeys.Name = "ForeignKeys"
        Me.ForeignKeys.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ForeignKeys.Size = New System.Drawing.Size(434, 134)
        Me.ForeignKeys.TabIndex = 54
        Me.ForeignKeys.WordWrap = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Controls.Add(Me.CreateField)
        Me.Panel3.Controls.Add(Me.CheckGroup)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 160)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(446, 335)
        Me.Panel3.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ConstraintGroup, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ReferenceGroup, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(449, 110)
        Me.TableLayoutPanel1.TabIndex = 73
        '
        'ConstraintGroup
        '
        Me.ConstraintGroup.Controls.Add(Me.ForCheck)
        Me.ConstraintGroup.Controls.Add(Me.Unique)
        Me.ConstraintGroup.Controls.Add(Me.NotNull)
        Me.ConstraintGroup.Controls.Add(Me.PrimCheck)
        Me.ConstraintGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConstraintGroup.Location = New System.Drawing.Point(314, 0)
        Me.ConstraintGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.ConstraintGroup.Name = "ConstraintGroup"
        Me.ConstraintGroup.Size = New System.Drawing.Size(135, 110)
        Me.ConstraintGroup.TabIndex = 66
        Me.ConstraintGroup.TabStop = False
        Me.ConstraintGroup.Text = "Constraints"
        '
        'ForCheck
        '
        Me.ForCheck.AutoSize = True
        Me.ForCheck.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ForCheck.Location = New System.Drawing.Point(3, 42)
        Me.ForCheck.Name = "ForCheck"
        Me.ForCheck.Size = New System.Drawing.Size(98, 17)
        Me.ForCheck.TabIndex = 58
        Me.ForCheck.Text = "FOREIGN KEY"
        Me.ForCheck.UseVisualStyleBackColor = True
        '
        'Unique
        '
        Me.Unique.AutoSize = True
        Me.Unique.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Unique.Location = New System.Drawing.Point(3, 90)
        Me.Unique.Name = "Unique"
        Me.Unique.Size = New System.Drawing.Size(68, 17)
        Me.Unique.TabIndex = 57
        Me.Unique.Text = "UNIQUE"
        Me.Unique.UseVisualStyleBackColor = True
        '
        'NotNull
        '
        Me.NotNull.AutoSize = True
        Me.NotNull.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NotNull.Location = New System.Drawing.Point(3, 67)
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
        Me.PrimCheck.Location = New System.Drawing.Point(3, 19)
        Me.PrimCheck.Name = "PrimCheck"
        Me.PrimCheck.Size = New System.Drawing.Size(99, 17)
        Me.PrimCheck.TabIndex = 44
        Me.PrimCheck.Text = "PRIMARY KEY"
        Me.PrimCheck.UseVisualStyleBackColor = True
        '
        'ReferenceGroup
        '
        Me.ReferenceGroup.Controls.Add(Me.OnDeleteAction)
        Me.ReferenceGroup.Controls.Add(Me.OnUpdateAction)
        Me.ReferenceGroup.Controls.Add(Me.OnDeleteBox)
        Me.ReferenceGroup.Controls.Add(Me.OnUpdateBox)
        Me.ReferenceGroup.Controls.Add(Me.ReferenceBox)
        Me.ReferenceGroup.Controls.Add(Me.ReferenceText)
        Me.ReferenceGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReferenceGroup.Enabled = False
        Me.ReferenceGroup.Location = New System.Drawing.Point(0, 0)
        Me.ReferenceGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.ReferenceGroup.Name = "ReferenceGroup"
        Me.ReferenceGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.ReferenceGroup.Size = New System.Drawing.Size(314, 110)
        Me.ReferenceGroup.TabIndex = 65
        Me.ReferenceGroup.TabStop = False
        Me.ReferenceGroup.Text = "Referential"
        '
        'OnDeleteAction
        '
        Me.OnDeleteAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OnDeleteAction.Enabled = False
        Me.OnDeleteAction.FormattingEnabled = True
        Me.OnDeleteAction.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.OnDeleteAction.Items.AddRange(New Object() {"CASCADE", "SET NULL", "SET DEFAULT", "NO ACTION"})
        Me.OnDeleteAction.Location = New System.Drawing.Point(87, 82)
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
        Me.OnUpdateAction.Location = New System.Drawing.Point(87, 47)
        Me.OnUpdateAction.Name = "OnUpdateAction"
        Me.OnUpdateAction.Size = New System.Drawing.Size(124, 21)
        Me.OnUpdateAction.TabIndex = 60
        '
        'OnDeleteBox
        '
        Me.OnDeleteBox.AutoSize = True
        Me.OnDeleteBox.Enabled = False
        Me.OnDeleteBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OnDeleteBox.Location = New System.Drawing.Point(4, 81)
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
        Me.OnUpdateBox.Location = New System.Drawing.Point(4, 48)
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
        Me.ReferenceBox.Location = New System.Drawing.Point(3, 16)
        Me.ReferenceBox.Name = "ReferenceBox"
        Me.ReferenceBox.Size = New System.Drawing.Size(81, 17)
        Me.ReferenceBox.TabIndex = 54
        Me.ReferenceBox.Text = "References"
        Me.ReferenceBox.UseVisualStyleBackColor = True
        '
        'ReferenceText
        '
        Me.ReferenceText.Enabled = False
        Me.ReferenceText.Location = New System.Drawing.Point(87, 16)
        Me.ReferenceText.Name = "ReferenceText"
        Me.ReferenceText.Size = New System.Drawing.Size(153, 20)
        Me.ReferenceText.TabIndex = 55
        '
        'CreateField
        '
        Me.CreateField.AutoSize = True
        Me.CreateField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateField.Depth = 0
        Me.CreateField.Location = New System.Drawing.Point(9, 293)
        Me.CreateField.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CreateField.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateField.Name = "CreateField"
        Me.CreateField.Primary = False
        Me.CreateField.Size = New System.Drawing.Size(48, 36)
        Me.CreateField.TabIndex = 72
        Me.CreateField.Text = "Done"
        Me.CreateField.UseVisualStyleBackColor = True
        '
        'CheckGroup
        '
        Me.CheckGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckGroup.Controls.Add(Me.CheckBox)
        Me.CheckGroup.Controls.Add(Me.Check_Type)
        Me.CheckGroup.Controls.Add(Me.Label5)
        Me.CheckGroup.Controls.Add(Me.Check_String)
        Me.CheckGroup.Controls.Add(Me.Check_Position)
        Me.CheckGroup.Controls.Add(Me.Label6)
        Me.CheckGroup.Location = New System.Drawing.Point(0, 113)
        Me.CheckGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckGroup.Name = "CheckGroup"
        Me.CheckGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.CheckGroup.Size = New System.Drawing.Size(446, 167)
        Me.CheckGroup.TabIndex = 2
        Me.CheckGroup.TabStop = False
        Me.CheckGroup.Text = "Check Constraint"
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckBox.Location = New System.Drawing.Point(3, 29)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox.TabIndex = 56
        Me.CheckBox.Text = "Check"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'Check_Type
        '
        Me.Check_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Check_Type.Enabled = False
        Me.Check_Type.FormattingEnabled = True
        Me.Check_Type.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Check_Type.Items.AddRange(New Object() {"LIKE", "IN", "Numeric/Logical Expresion/Other"})
        Me.Check_Type.Location = New System.Drawing.Point(86, 32)
        Me.Check_Type.Name = "Check_Type"
        Me.Check_Type.Size = New System.Drawing.Size(156, 21)
        Me.Check_Type.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(80, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Check Type"
        '
        'Check_String
        '
        Me.Check_String.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Check_String.Enabled = False
        Me.Check_String.Location = New System.Drawing.Point(3, 59)
        Me.Check_String.Multiline = True
        Me.Check_String.Name = "Check_String"
        Me.Check_String.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Check_String.Size = New System.Drawing.Size(437, 99)
        Me.Check_String.TabIndex = 53
        Me.Check_String.WordWrap = False
        '
        'Check_Position
        '
        Me.Check_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Check_Position.Enabled = False
        Me.Check_Position.FormattingEnabled = True
        Me.Check_Position.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Check_Position.Items.AddRange(New Object() {"Before any string", "After any string", "Between any string", "Other/Specific"})
        Me.Check_Position.Location = New System.Drawing.Point(258, 32)
        Me.Check_Position.Name = "Check_Position"
        Me.Check_Position.Size = New System.Drawing.Size(156, 21)
        Me.Check_Position.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(252, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "String Position"
        '
        'OperationsPanel
        '
        Me.Home_Main_Layout.SetColumnSpan(Me.OperationsPanel, 4)
        Me.OperationsPanel.Controls.Add(Me.PictureBox1)
        Me.OperationsPanel.Controls.Add(Me.Select_Query)
        Me.OperationsPanel.Controls.Add(Me.Alter_Table)
        Me.OperationsPanel.Controls.Add(Me.Create_Table)
        Me.OperationsPanel.Controls.Add(Me.Insert)
        Me.OperationsPanel.Controls.Add(Me.Drop_Table)
        Me.OperationsPanel.Controls.Add(Me.Database_Operations)
        Me.OperationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OperationsPanel.Location = New System.Drawing.Point(0, 0)
        Me.OperationsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.OperationsPanel.Name = "OperationsPanel"
        Me.OperationsPanel.Size = New System.Drawing.Size(464, 76)
        Me.OperationsPanel.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Select_Query
        '
        Me.Select_Query.Depth = 0
        Me.Select_Query.Location = New System.Drawing.Point(254, 5)
        Me.Select_Query.MouseState = MaterialSkin.MouseState.HOVER
        Me.Select_Query.Name = "Select_Query"
        Me.Select_Query.Primary = True
        Me.Select_Query.Size = New System.Drawing.Size(111, 31)
        Me.Select_Query.TabIndex = 13
        Me.Select_Query.Text = "Select Query"
        Me.Select_Query.UseVisualStyleBackColor = True
        '
        'Alter_Table
        '
        Me.Alter_Table.Depth = 0
        Me.Alter_Table.Location = New System.Drawing.Point(347, 42)
        Me.Alter_Table.MouseState = MaterialSkin.MouseState.HOVER
        Me.Alter_Table.Name = "Alter_Table"
        Me.Alter_Table.Primary = True
        Me.Alter_Table.Size = New System.Drawing.Size(111, 31)
        Me.Alter_Table.TabIndex = 12
        Me.Alter_Table.Text = "Alter Table"
        Me.Alter_Table.UseVisualStyleBackColor = True
        '
        'Create_Table
        '
        Me.Create_Table.Depth = 0
        Me.Create_Table.Location = New System.Drawing.Point(86, 42)
        Me.Create_Table.MouseState = MaterialSkin.MouseState.HOVER
        Me.Create_Table.Name = "Create_Table"
        Me.Create_Table.Primary = True
        Me.Create_Table.Size = New System.Drawing.Size(112, 31)
        Me.Create_Table.TabIndex = 11
        Me.Create_Table.Text = "Create Table"
        Me.Create_Table.UseVisualStyleBackColor = True
        '
        'Insert
        '
        Me.Insert.Depth = 0
        Me.Insert.Location = New System.Drawing.Point(204, 42)
        Me.Insert.MouseState = MaterialSkin.MouseState.HOVER
        Me.Insert.Name = "Insert"
        Me.Insert.Primary = True
        Me.Insert.Size = New System.Drawing.Size(75, 31)
        Me.Insert.TabIndex = 10
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Drop_Table
        '
        Me.Drop_Table.Depth = 0
        Me.Drop_Table.Location = New System.Drawing.Point(284, 42)
        Me.Drop_Table.MouseState = MaterialSkin.MouseState.HOVER
        Me.Drop_Table.Name = "Drop_Table"
        Me.Drop_Table.Primary = True
        Me.Drop_Table.Size = New System.Drawing.Size(57, 31)
        Me.Drop_Table.TabIndex = 9
        Me.Drop_Table.Text = "Drop"
        Me.Drop_Table.UseVisualStyleBackColor = True
        '
        'Database_Operations
        '
        Me.Database_Operations.Depth = 0
        Me.Database_Operations.Location = New System.Drawing.Point(86, 5)
        Me.Database_Operations.MouseState = MaterialSkin.MouseState.HOVER
        Me.Database_Operations.Name = "Database_Operations"
        Me.Database_Operations.Primary = True
        Me.Database_Operations.Size = New System.Drawing.Size(162, 31)
        Me.Database_Operations.TabIndex = 8
        Me.Database_Operations.Text = "Database Operations"
        Me.Database_Operations.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1164, 765)
        Me.Controls.Add(Me.Home_Main_Layout)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Home"
        Me.Text = "SQL Script Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.Home_Main_Layout.ResumeLayout(False)
        Me.ContainerPane.ResumeLayout(False)
        Me.ActionGroup.ResumeLayout(False)
        Me.AlterTableLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.RenameGroup.ResumeLayout(False)
        Me.RenameGroup.PerformLayout()
        Me.DropGroup.ResumeLayout(False)
        Me.DropGroup.PerformLayout()
        Me.AlterButtonsTableLayout.ResumeLayout(False)
        Me.AlterButtonsTableLayout.PerformLayout()
        Me.DropTableLayout.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.DatabaseTableLayout.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.InsertTableLayout.ResumeLayout(False)
        Me.DataItemsGroup.ResumeLayout(False)
        Me.DataItemsGroup.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.CreateActionLayout.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FieldDetails.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.FieldGroup.ResumeLayout(False)
        Me.FieldGroup.PerformLayout()
        CType(Me.Precision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scale_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrimaryGroup.ResumeLayout(False)
        Me.PrimaryGroup.PerformLayout()
        Me.ForeignKeyGroup.ResumeLayout(False)
        Me.ForeignKeyGroup.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ConstraintGroup.ResumeLayout(False)
        Me.ConstraintGroup.PerformLayout()
        Me.ReferenceGroup.ResumeLayout(False)
        Me.ReferenceGroup.PerformLayout()
        Me.CheckGroup.ResumeLayout(False)
        Me.CheckGroup.PerformLayout()
        Me.OperationsPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Home_Main_Layout As TableLayoutPanel
    Friend WithEvents ContainerPane As Panel
    Friend WithEvents ActionGroup As GroupBox
    Friend WithEvents InsertTableLayout As TableLayoutPanel
    Friend WithEvents DataItemsGroup As GroupBox
    Friend WithEvents DataItems As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Specify_CheckBox As CheckBox
    Friend WithEvents Columns As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents InsertTable As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Insert_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Select_Database As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Drop_Database As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Create_Database As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DatabaseTableLayout As TableLayoutPanel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents DatabaseName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Panel10 As Panel
    Friend WithEvents OperationsPanel As Panel
    Friend WithEvents DropTableLayout As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TableName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DropButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Sequence As ListBox
    Friend WithEvents CreateActionLayout As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Add_Foreign_Key_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Add_Field_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Add_Primary_Key_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents NewTableField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FieldDetails As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents FieldGroup As GroupBox
    Friend WithEvents Formula As CheckBox
    Friend WithEvents DefaultValue As TextBox
    Friend WithEvents Default_Value_Checkbox As CheckBox
    Friend WithEvents Precision As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents FieldSize As NumericUpDown
    Friend WithEvents Scale_ As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FieldType As ComboBox
    Friend WithEvents FieldField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As Label
    Friend WithEvents PrimaryGroup As GroupBox
    Friend WithEvents PrimaryKeys As TextBox
    Friend WithEvents ForeignKeyGroup As GroupBox
    Friend WithEvents ForeignKeys As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckGroup As GroupBox
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents Check_Type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Check_String As TextBox
    Friend WithEvents Check_Position As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Database_Operations As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Drop_Table As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Create_Table As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Insert As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Alter_Table As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Select_Query As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents CompleteTable_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents CreateField As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ConstraintGroup As GroupBox
    Friend WithEvents ForCheck As CheckBox
    Friend WithEvents Unique As CheckBox
    Friend WithEvents NotNull As CheckBox
    Friend WithEvents PrimCheck As CheckBox
    Friend WithEvents ReferenceGroup As GroupBox
    Friend WithEvents OnDeleteAction As ComboBox
    Friend WithEvents OnUpdateAction As ComboBox
    Friend WithEvents OnDeleteBox As CheckBox
    Friend WithEvents OnUpdateBox As CheckBox
    Friend WithEvents ReferenceBox As CheckBox
    Friend WithEvents ReferenceText As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents RenameGroup As GroupBox
    Friend WithEvents Rename As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents NewTableName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DropGroup As GroupBox
    Friend WithEvents Alter_Drop_Table As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DropColumn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Alter_Table_Name As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents AlterButtonsTableLayout As TableLayoutPanel
    Friend WithEvents AlterModify As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterRename As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterDrop As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterAdd As MaterialSkin.Controls.MaterialFlatButton
End Class
