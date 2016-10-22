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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Home_Main_Layout = New System.Windows.Forms.TableLayoutPanel()
        Me.TabContainerPanel = New System.Windows.Forms.Panel()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.HomePage = New System.Windows.Forms.TabPage()
        Me.Home_MngScriptGrp = New System.Windows.Forms.Panel()
        Me.Home_MngScriptLlb = New System.Windows.Forms.Label()
        Me.Home_MngScriptTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Home_ScriptNewBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptBrkBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptUndoBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptIncTxtBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptDecTxtBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptExprtBtn = New System.Windows.Forms.PictureBox()
        Me.Home_InfoTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Home_InfoBtn = New System.Windows.Forms.PictureBox()
        Me.DatabasePage = New System.Windows.Forms.TabPage()
        Me.DatabaseTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Database_NameGrp = New System.Windows.Forms.Panel()
        Me.Database_NameLbl = New System.Windows.Forms.Label()
        Me.Database_NameFld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Database_ButtonTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Database_SelectBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Database_CreateBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Database_DeleteBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CreateTablePage = New System.Windows.Forms.TabPage()
        Me.CreateActionLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.CreateTable_NameGrp = New System.Windows.Forms.Panel()
        Me.CreateTable_NameLbl = New System.Windows.Forms.Label()
        Me.CreateTable_CreateBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CreateTable_NameFld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FieldDetails = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.FieldGroup = New System.Windows.Forms.Panel()
        Me.FieldDetails_ColumnLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_FormulaChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_ColumnTYpeCmbo = New System.Windows.Forms.ComboBox()
        Me.FieldDetails_DefFld = New System.Windows.Forms.TextBox()
        Me.FieldDetails_ColumnNameLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_DefValChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_ColumnNameFld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FieldDetails_Precision = New System.Windows.Forms.NumericUpDown()
        Me.FieldDetails_PreScleLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_SizeLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_TypeLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_Size = New System.Windows.Forms.NumericUpDown()
        Me.FieldDetails_Scale = New System.Windows.Forms.NumericUpDown()
        Me.FieldDetails_ForeignKeyGrp = New System.Windows.Forms.Panel()
        Me.FieldDetails_ForeignKeyLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_ForeignKeyFld = New System.Windows.Forms.TextBox()
        Me.FieldDetails_PrimyGrp = New System.Windows.Forms.Panel()
        Me.FieldDetails_PrimLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_PrimFld = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FieldDetails_CheckGrp = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.FieldDetails_CheckChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_CheckTypeLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_CheckTypeCmbo = New System.Windows.Forms.ComboBox()
        Me.FieldDetails_StringPstnLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_CheckPstnCmbo = New System.Windows.Forms.ComboBox()
        Me.FieldDetails_CheckFld = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FieldDetails_ReferenceGrp = New System.Windows.Forms.Panel()
        Me.FieldDetails_ReferentialLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_OnDeleteCmbo = New System.Windows.Forms.ComboBox()
        Me.FieldDetails_ReferenceChkBx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_OnUpdateCmbo = New System.Windows.Forms.ComboBox()
        Me.FieldDetails_ReferenceFld = New System.Windows.Forms.TextBox()
        Me.FieldDetails_OnDeleteChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_OnUpdateChkBx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_ConstraintGrp = New System.Windows.Forms.Panel()
        Me.FieldDetails_ConstraintsLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_ForeignChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_NotNullChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_UniqueChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_PrimChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_CreateFieldBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CreateTable_BtbTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.CreateTable_AddPrimKeyBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CreateTable_CompleteTableBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CreateTable_AddForeignKeyBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CreateTable_AddColumnBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterTablePage = New System.Windows.Forms.TabPage()
        Me.AlterTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Alter_Table_Name = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.RenameGroup = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Rename = New MaterialSkin.Controls.MaterialFlatButton()
        Me.NewTableName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DropGroup = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Alter_Drop_Table = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DropColumn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterButtonsTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.AlterModify = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterRename = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterDrop = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterAdd = New MaterialSkin.Controls.MaterialFlatButton()
        Me.InsertPage = New System.Windows.Forms.TabPage()
        Me.InsertTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InsertTable = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Insert_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Specify_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Columns = New System.Windows.Forms.TextBox()
        Me.DataItemsGroup = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataItems = New System.Windows.Forms.TextBox()
        Me.DeleteTablePage = New System.Windows.Forms.TabPage()
        Me.DropTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DropButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ScriptGrp = New System.Windows.Forms.GroupBox()
        Me.Sequence = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Home_Main_Layout.SuspendLayout()
        Me.TabContainerPanel.SuspendLayout()
        Me.MaterialTabControl1.SuspendLayout()
        Me.HomePage.SuspendLayout()
        Me.Home_MngScriptGrp.SuspendLayout()
        Me.Home_MngScriptTableLayout.SuspendLayout()
        CType(Me.Home_ScriptNewBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptBrkBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptUndoBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptIncTxtBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptDecTxtBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptExprtBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Home_InfoTableLayout.SuspendLayout()
        CType(Me.Home_InfoBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatabasePage.SuspendLayout()
        Me.DatabaseTableLayout.SuspendLayout()
        Me.Database_NameGrp.SuspendLayout()
        Me.Database_ButtonTableLayout.SuspendLayout()
        Me.CreateTablePage.SuspendLayout()
        Me.CreateActionLayout.SuspendLayout()
        Me.CreateTable_NameGrp.SuspendLayout()
        Me.FieldDetails.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.FieldGroup.SuspendLayout()
        CType(Me.FieldDetails_Precision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldDetails_Size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldDetails_Scale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FieldDetails_ForeignKeyGrp.SuspendLayout()
        Me.FieldDetails_PrimyGrp.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FieldDetails_CheckGrp.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FieldDetails_ReferenceGrp.SuspendLayout()
        Me.FieldDetails_ConstraintGrp.SuspendLayout()
        Me.CreateTable_BtbTableLayout.SuspendLayout()
        Me.AlterTablePage.SuspendLayout()
        Me.AlterTableLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.RenameGroup.SuspendLayout()
        Me.DropGroup.SuspendLayout()
        Me.AlterButtonsTableLayout.SuspendLayout()
        Me.InsertPage.SuspendLayout()
        Me.InsertTableLayout.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.DataItemsGroup.SuspendLayout()
        Me.DeleteTablePage.SuspendLayout()
        Me.DropTableLayout.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.ScriptGrp.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Home_Main_Layout.Controls.Add(Me.TabContainerPanel, 0, 0)
        Me.Home_Main_Layout.Controls.Add(Me.TableLayoutPanel4, 4, 0)
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
        'TabContainerPanel
        '
        Me.Home_Main_Layout.SetColumnSpan(Me.TabContainerPanel, 4)
        Me.TabContainerPanel.Controls.Add(Me.MaterialTabControl1)
        Me.TabContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabContainerPanel.Location = New System.Drawing.Point(0, 0)
        Me.TabContainerPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TabContainerPanel.Name = "TabContainerPanel"
        Me.Home_Main_Layout.SetRowSpan(Me.TabContainerPanel, 10)
        Me.TabContainerPanel.Size = New System.Drawing.Size(464, 712)
        Me.TabContainerPanel.TabIndex = 0
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.HomePage)
        Me.MaterialTabControl1.Controls.Add(Me.DatabasePage)
        Me.MaterialTabControl1.Controls.Add(Me.CreateTablePage)
        Me.MaterialTabControl1.Controls.Add(Me.AlterTablePage)
        Me.MaterialTabControl1.Controls.Add(Me.InsertPage)
        Me.MaterialTabControl1.Controls.Add(Me.DeleteTablePage)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(464, 712)
        Me.MaterialTabControl1.TabIndex = 2
        '
        'HomePage
        '
        Me.HomePage.BackgroundImage = CType(resources.GetObject("HomePage.BackgroundImage"), System.Drawing.Image)
        Me.HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HomePage.Controls.Add(Me.Home_MngScriptGrp)
        Me.HomePage.Controls.Add(Me.Home_InfoTableLayout)
        Me.HomePage.Location = New System.Drawing.Point(4, 22)
        Me.HomePage.Margin = New System.Windows.Forms.Padding(0)
        Me.HomePage.Name = "HomePage"
        Me.HomePage.Padding = New System.Windows.Forms.Padding(3)
        Me.HomePage.Size = New System.Drawing.Size(456, 686)
        Me.HomePage.TabIndex = 0
        Me.HomePage.Text = "Home"
        Me.HomePage.UseVisualStyleBackColor = True
        '
        'Home_MngScriptGrp
        '
        Me.Home_MngScriptGrp.Controls.Add(Me.Home_MngScriptLlb)
        Me.Home_MngScriptGrp.Controls.Add(Me.Home_MngScriptTableLayout)
        Me.Home_MngScriptGrp.Dock = System.Windows.Forms.DockStyle.Top
        Me.Home_MngScriptGrp.Location = New System.Drawing.Point(3, 3)
        Me.Home_MngScriptGrp.Name = "Home_MngScriptGrp"
        Me.Home_MngScriptGrp.Size = New System.Drawing.Size(450, 154)
        Me.Home_MngScriptGrp.TabIndex = 4
        '
        'Home_MngScriptLlb
        '
        Me.Home_MngScriptLlb.AutoSize = True
        Me.Home_MngScriptLlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home_MngScriptLlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Home_MngScriptLlb.Location = New System.Drawing.Point(3, 0)
        Me.Home_MngScriptLlb.Name = "Home_MngScriptLlb"
        Me.Home_MngScriptLlb.Size = New System.Drawing.Size(100, 15)
        Me.Home_MngScriptLlb.TabIndex = 3
        Me.Home_MngScriptLlb.Text = "Manage Script"
        '
        'Home_MngScriptTableLayout
        '
        Me.Home_MngScriptTableLayout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Home_MngScriptTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Home_MngScriptTableLayout.ColumnCount = 5
        Me.Home_MngScriptTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_MngScriptTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_MngScriptTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_MngScriptTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_MngScriptTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_MngScriptTableLayout.Controls.Add(Me.Home_ScriptNewBtn, 0, 1)
        Me.Home_MngScriptTableLayout.Controls.Add(Me.Home_ScriptBrkBtn, 3, 0)
        Me.Home_MngScriptTableLayout.Controls.Add(Me.Home_ScriptUndoBtn, 0, 0)
        Me.Home_MngScriptTableLayout.Controls.Add(Me.Home_ScriptIncTxtBtn, 1, 0)
        Me.Home_MngScriptTableLayout.Controls.Add(Me.Home_ScriptDecTxtBtn, 2, 0)
        Me.Home_MngScriptTableLayout.Controls.Add(Me.Home_ScriptExprtBtn, 4, 0)
        Me.Home_MngScriptTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Home_MngScriptTableLayout.Location = New System.Drawing.Point(0, 19)
        Me.Home_MngScriptTableLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.Home_MngScriptTableLayout.Name = "Home_MngScriptTableLayout"
        Me.Home_MngScriptTableLayout.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Home_MngScriptTableLayout.RowCount = 2
        Me.Home_MngScriptTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.Home_MngScriptTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Home_MngScriptTableLayout.Size = New System.Drawing.Size(450, 135)
        Me.Home_MngScriptTableLayout.TabIndex = 0
        '
        'Home_ScriptNewBtn
        '
        Me.Home_ScriptNewBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_ScriptNewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_ScriptNewBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_ScriptNewBtn.Image = CType(resources.GetObject("Home_ScriptNewBtn.Image"), System.Drawing.Image)
        Me.Home_ScriptNewBtn.Location = New System.Drawing.Point(3, 64)
        Me.Home_ScriptNewBtn.Name = "Home_ScriptNewBtn"
        Me.Home_ScriptNewBtn.Size = New System.Drawing.Size(84, 58)
        Me.Home_ScriptNewBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_ScriptNewBtn.TabIndex = 16
        Me.Home_ScriptNewBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_ScriptNewBtn, "New")
        '
        'Home_ScriptBrkBtn
        '
        Me.Home_ScriptBrkBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_ScriptBrkBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_ScriptBrkBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_ScriptBrkBtn.Image = CType(resources.GetObject("Home_ScriptBrkBtn.Image"), System.Drawing.Image)
        Me.Home_ScriptBrkBtn.Location = New System.Drawing.Point(273, 3)
        Me.Home_ScriptBrkBtn.Name = "Home_ScriptBrkBtn"
        Me.Home_ScriptBrkBtn.Size = New System.Drawing.Size(84, 55)
        Me.Home_ScriptBrkBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_ScriptBrkBtn.TabIndex = 15
        Me.Home_ScriptBrkBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_ScriptBrkBtn, "Break")
        '
        'Home_ScriptUndoBtn
        '
        Me.Home_ScriptUndoBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_ScriptUndoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_ScriptUndoBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_ScriptUndoBtn.Image = CType(resources.GetObject("Home_ScriptUndoBtn.Image"), System.Drawing.Image)
        Me.Home_ScriptUndoBtn.Location = New System.Drawing.Point(3, 3)
        Me.Home_ScriptUndoBtn.Name = "Home_ScriptUndoBtn"
        Me.Home_ScriptUndoBtn.Size = New System.Drawing.Size(84, 55)
        Me.Home_ScriptUndoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_ScriptUndoBtn.TabIndex = 14
        Me.Home_ScriptUndoBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_ScriptUndoBtn, "Undo last line")
        '
        'Home_ScriptIncTxtBtn
        '
        Me.Home_ScriptIncTxtBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_ScriptIncTxtBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_ScriptIncTxtBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_ScriptIncTxtBtn.Image = CType(resources.GetObject("Home_ScriptIncTxtBtn.Image"), System.Drawing.Image)
        Me.Home_ScriptIncTxtBtn.Location = New System.Drawing.Point(93, 3)
        Me.Home_ScriptIncTxtBtn.Name = "Home_ScriptIncTxtBtn"
        Me.Home_ScriptIncTxtBtn.Size = New System.Drawing.Size(84, 55)
        Me.Home_ScriptIncTxtBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_ScriptIncTxtBtn.TabIndex = 13
        Me.Home_ScriptIncTxtBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_ScriptIncTxtBtn, "Increaese Text Size")
        '
        'Home_ScriptDecTxtBtn
        '
        Me.Home_ScriptDecTxtBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_ScriptDecTxtBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_ScriptDecTxtBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_ScriptDecTxtBtn.Image = CType(resources.GetObject("Home_ScriptDecTxtBtn.Image"), System.Drawing.Image)
        Me.Home_ScriptDecTxtBtn.Location = New System.Drawing.Point(183, 3)
        Me.Home_ScriptDecTxtBtn.Name = "Home_ScriptDecTxtBtn"
        Me.Home_ScriptDecTxtBtn.Size = New System.Drawing.Size(84, 55)
        Me.Home_ScriptDecTxtBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_ScriptDecTxtBtn.TabIndex = 12
        Me.Home_ScriptDecTxtBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_ScriptDecTxtBtn, "Decrease Text Size")
        '
        'Home_ScriptExprtBtn
        '
        Me.Home_ScriptExprtBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_ScriptExprtBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_ScriptExprtBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_ScriptExprtBtn.Image = CType(resources.GetObject("Home_ScriptExprtBtn.Image"), System.Drawing.Image)
        Me.Home_ScriptExprtBtn.Location = New System.Drawing.Point(363, 3)
        Me.Home_ScriptExprtBtn.Name = "Home_ScriptExprtBtn"
        Me.Home_ScriptExprtBtn.Padding = New System.Windows.Forms.Padding(10)
        Me.Home_ScriptExprtBtn.Size = New System.Drawing.Size(84, 55)
        Me.Home_ScriptExprtBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_ScriptExprtBtn.TabIndex = 11
        Me.Home_ScriptExprtBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_ScriptExprtBtn, "Export Script")
        '
        'Home_InfoTableLayout
        '
        Me.Home_InfoTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Home_InfoTableLayout.ColumnCount = 5
        Me.Home_InfoTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_InfoTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_InfoTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_InfoTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_InfoTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Home_InfoTableLayout.Controls.Add(Me.Home_InfoBtn, 4, 0)
        Me.Home_InfoTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Home_InfoTableLayout.Location = New System.Drawing.Point(3, 609)
        Me.Home_InfoTableLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.Home_InfoTableLayout.Name = "Home_InfoTableLayout"
        Me.Home_InfoTableLayout.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Home_InfoTableLayout.RowCount = 1
        Me.Home_InfoTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.Home_InfoTableLayout.Size = New System.Drawing.Size(450, 74)
        Me.Home_InfoTableLayout.TabIndex = 2
        '
        'Home_InfoBtn
        '
        Me.Home_InfoBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_InfoBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_InfoBtn.Image = CType(resources.GetObject("Home_InfoBtn.Image"), System.Drawing.Image)
        Me.Home_InfoBtn.Location = New System.Drawing.Point(363, 3)
        Me.Home_InfoBtn.Name = "Home_InfoBtn"
        Me.Home_InfoBtn.Padding = New System.Windows.Forms.Padding(10)
        Me.Home_InfoBtn.Size = New System.Drawing.Size(84, 58)
        Me.Home_InfoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_InfoBtn.TabIndex = 11
        Me.Home_InfoBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_InfoBtn, "About")
        '
        'DatabasePage
        '
        Me.DatabasePage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DatabasePage.Controls.Add(Me.DatabaseTableLayout)
        Me.DatabasePage.Location = New System.Drawing.Point(4, 22)
        Me.DatabasePage.Name = "DatabasePage"
        Me.DatabasePage.Padding = New System.Windows.Forms.Padding(3)
        Me.DatabasePage.Size = New System.Drawing.Size(456, 686)
        Me.DatabasePage.TabIndex = 1
        Me.DatabasePage.Text = "Database"
        '
        'DatabaseTableLayout
        '
        Me.DatabaseTableLayout.ColumnCount = 1
        Me.DatabaseTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatabaseTableLayout.Controls.Add(Me.Database_NameGrp, 0, 0)
        Me.DatabaseTableLayout.Controls.Add(Me.Database_ButtonTableLayout, 0, 1)
        Me.DatabaseTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatabaseTableLayout.Location = New System.Drawing.Point(3, 3)
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
        Me.DatabaseTableLayout.Size = New System.Drawing.Size(450, 680)
        Me.DatabaseTableLayout.TabIndex = 46
        '
        'Database_NameGrp
        '
        Me.Database_NameGrp.Controls.Add(Me.Database_NameLbl)
        Me.Database_NameGrp.Controls.Add(Me.Database_NameFld)
        Me.Database_NameGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Database_NameGrp.Location = New System.Drawing.Point(3, 3)
        Me.Database_NameGrp.Name = "Database_NameGrp"
        Me.Database_NameGrp.Size = New System.Drawing.Size(444, 50)
        Me.Database_NameGrp.TabIndex = 0
        '
        'Database_NameLbl
        '
        Me.Database_NameLbl.AutoSize = True
        Me.Database_NameLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Database_NameLbl.Location = New System.Drawing.Point(167, 5)
        Me.Database_NameLbl.Name = "Database_NameLbl"
        Me.Database_NameLbl.Size = New System.Drawing.Size(112, 13)
        Me.Database_NameLbl.TabIndex = 41
        Me.Database_NameLbl.Text = "Enter Database Name"
        '
        'Database_NameFld
        '
        Me.Database_NameFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Database_NameFld.Depth = 0
        Me.Database_NameFld.Hint = ""
        Me.Database_NameFld.Location = New System.Drawing.Point(10, 21)
        Me.Database_NameFld.MouseState = MaterialSkin.MouseState.HOVER
        Me.Database_NameFld.Name = "Database_NameFld"
        Me.Database_NameFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Database_NameFld.SelectedText = ""
        Me.Database_NameFld.SelectionLength = 0
        Me.Database_NameFld.SelectionStart = 0
        Me.Database_NameFld.Size = New System.Drawing.Size(418, 23)
        Me.Database_NameFld.TabIndex = 37
        Me.Database_NameFld.UseSystemPasswordChar = False
        '
        'Database_ButtonTableLayout
        '
        Me.Database_ButtonTableLayout.ColumnCount = 3
        Me.Database_ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.Database_ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.Database_ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.Database_ButtonTableLayout.Controls.Add(Me.Database_SelectBtn, 2, 0)
        Me.Database_ButtonTableLayout.Controls.Add(Me.Database_CreateBtn, 0, 0)
        Me.Database_ButtonTableLayout.Controls.Add(Me.Database_DeleteBtn, 1, 0)
        Me.Database_ButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Database_ButtonTableLayout.Location = New System.Drawing.Point(3, 59)
        Me.Database_ButtonTableLayout.Name = "Database_ButtonTableLayout"
        Me.Database_ButtonTableLayout.RowCount = 1
        Me.Database_ButtonTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Database_ButtonTableLayout.Size = New System.Drawing.Size(444, 50)
        Me.Database_ButtonTableLayout.TabIndex = 1
        '
        'Database_SelectBtn
        '
        Me.Database_SelectBtn.AutoSize = True
        Me.Database_SelectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Database_SelectBtn.BackColor = System.Drawing.Color.White
        Me.Database_SelectBtn.Depth = 0
        Me.Database_SelectBtn.Location = New System.Drawing.Point(300, 6)
        Me.Database_SelectBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Database_SelectBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Database_SelectBtn.Name = "Database_SelectBtn"
        Me.Database_SelectBtn.Primary = False
        Me.Database_SelectBtn.Size = New System.Drawing.Size(133, 36)
        Me.Database_SelectBtn.TabIndex = 1
        Me.Database_SelectBtn.Text = "Select Database"
        Me.Database_SelectBtn.UseVisualStyleBackColor = False
        '
        'Database_CreateBtn
        '
        Me.Database_CreateBtn.AutoSize = True
        Me.Database_CreateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Database_CreateBtn.BackColor = System.Drawing.Color.White
        Me.Database_CreateBtn.Depth = 0
        Me.Database_CreateBtn.Location = New System.Drawing.Point(4, 6)
        Me.Database_CreateBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Database_CreateBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Database_CreateBtn.Name = "Database_CreateBtn"
        Me.Database_CreateBtn.Primary = False
        Me.Database_CreateBtn.Size = New System.Drawing.Size(135, 36)
        Me.Database_CreateBtn.TabIndex = 3
        Me.Database_CreateBtn.Text = "Create Database"
        Me.Database_CreateBtn.UseVisualStyleBackColor = False
        '
        'Database_DeleteBtn
        '
        Me.Database_DeleteBtn.AutoSize = True
        Me.Database_DeleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Database_DeleteBtn.BackColor = System.Drawing.Color.White
        Me.Database_DeleteBtn.Depth = 0
        Me.Database_DeleteBtn.Location = New System.Drawing.Point(152, 6)
        Me.Database_DeleteBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Database_DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Database_DeleteBtn.Name = "Database_DeleteBtn"
        Me.Database_DeleteBtn.Primary = False
        Me.Database_DeleteBtn.Size = New System.Drawing.Size(133, 36)
        Me.Database_DeleteBtn.TabIndex = 2
        Me.Database_DeleteBtn.Text = "Delete Database"
        Me.Database_DeleteBtn.UseVisualStyleBackColor = False
        '
        'CreateTablePage
        '
        Me.CreateTablePage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CreateTablePage.Controls.Add(Me.CreateActionLayout)
        Me.CreateTablePage.Location = New System.Drawing.Point(4, 22)
        Me.CreateTablePage.Name = "CreateTablePage"
        Me.CreateTablePage.Padding = New System.Windows.Forms.Padding(3)
        Me.CreateTablePage.Size = New System.Drawing.Size(456, 686)
        Me.CreateTablePage.TabIndex = 2
        Me.CreateTablePage.Text = "Create Table"
        '
        'CreateActionLayout
        '
        Me.CreateActionLayout.ColumnCount = 1
        Me.CreateActionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CreateActionLayout.Controls.Add(Me.CreateTable_NameGrp, 0, 0)
        Me.CreateActionLayout.Controls.Add(Me.FieldDetails, 0, 2)
        Me.CreateActionLayout.Controls.Add(Me.CreateTable_BtbTableLayout, 0, 1)
        Me.CreateActionLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateActionLayout.Location = New System.Drawing.Point(3, 3)
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
        Me.CreateActionLayout.Size = New System.Drawing.Size(450, 680)
        Me.CreateActionLayout.TabIndex = 0
        '
        'CreateTable_NameGrp
        '
        Me.CreateTable_NameGrp.Controls.Add(Me.CreateTable_NameLbl)
        Me.CreateTable_NameGrp.Controls.Add(Me.CreateTable_CreateBtn)
        Me.CreateTable_NameGrp.Controls.Add(Me.CreateTable_NameFld)
        Me.CreateTable_NameGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateTable_NameGrp.Location = New System.Drawing.Point(3, 3)
        Me.CreateTable_NameGrp.Name = "CreateTable_NameGrp"
        Me.CreateTable_NameGrp.Size = New System.Drawing.Size(444, 55)
        Me.CreateTable_NameGrp.TabIndex = 5
        '
        'CreateTable_NameLbl
        '
        Me.CreateTable_NameLbl.AutoSize = True
        Me.CreateTable_NameLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CreateTable_NameLbl.Location = New System.Drawing.Point(176, 5)
        Me.CreateTable_NameLbl.Name = "CreateTable_NameLbl"
        Me.CreateTable_NameLbl.Size = New System.Drawing.Size(93, 13)
        Me.CreateTable_NameLbl.TabIndex = 41
        Me.CreateTable_NameLbl.Text = "Enter Table Name"
        '
        'CreateTable_CreateBtn
        '
        Me.CreateTable_CreateBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CreateTable_CreateBtn.AutoSize = True
        Me.CreateTable_CreateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateTable_CreateBtn.Depth = 0
        Me.CreateTable_CreateBtn.Location = New System.Drawing.Point(373, 9)
        Me.CreateTable_CreateBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CreateTable_CreateBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateTable_CreateBtn.Name = "CreateTable_CreateBtn"
        Me.CreateTable_CreateBtn.Primary = False
        Me.CreateTable_CreateBtn.Size = New System.Drawing.Size(62, 36)
        Me.CreateTable_CreateBtn.TabIndex = 39
        Me.CreateTable_CreateBtn.Text = "Create"
        Me.CreateTable_CreateBtn.UseVisualStyleBackColor = True
        '
        'CreateTable_NameFld
        '
        Me.CreateTable_NameFld.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateTable_NameFld.Depth = 0
        Me.CreateTable_NameFld.Hint = ""
        Me.CreateTable_NameFld.Location = New System.Drawing.Point(12, 22)
        Me.CreateTable_NameFld.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateTable_NameFld.Name = "CreateTable_NameFld"
        Me.CreateTable_NameFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CreateTable_NameFld.SelectedText = ""
        Me.CreateTable_NameFld.SelectionLength = 0
        Me.CreateTable_NameFld.SelectionStart = 0
        Me.CreateTable_NameFld.Size = New System.Drawing.Size(346, 23)
        Me.CreateTable_NameFld.TabIndex = 37
        Me.CreateTable_NameFld.UseSystemPasswordChar = False
        '
        'FieldDetails
        '
        Me.FieldDetails.Controls.Add(Me.Panel11)
        Me.FieldDetails.Controls.Add(Me.Panel3)
        Me.FieldDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldDetails.Location = New System.Drawing.Point(3, 125)
        Me.FieldDetails.Name = "FieldDetails"
        Me.CreateActionLayout.SetRowSpan(Me.FieldDetails, 9)
        Me.FieldDetails.Size = New System.Drawing.Size(444, 552)
        Me.FieldDetails.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.FieldGroup)
        Me.Panel11.Controls.Add(Me.FieldDetails_ForeignKeyGrp)
        Me.Panel11.Controls.Add(Me.FieldDetails_PrimyGrp)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(444, 160)
        Me.Panel11.TabIndex = 13
        '
        'FieldGroup
        '
        Me.FieldGroup.Controls.Add(Me.FieldDetails_ColumnLbl)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_FormulaChkbx)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_ColumnTYpeCmbo)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_DefFld)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_ColumnNameLbl)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_DefValChkbx)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_ColumnNameFld)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_Precision)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_PreScleLbl)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_SizeLbl)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_TypeLbl)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_Size)
        Me.FieldGroup.Controls.Add(Me.FieldDetails_Scale)
        Me.FieldGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldGroup.Location = New System.Drawing.Point(0, 0)
        Me.FieldGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.FieldGroup.Name = "FieldGroup"
        Me.FieldGroup.Size = New System.Drawing.Size(444, 160)
        Me.FieldGroup.TabIndex = 8
        '
        'FieldDetails_ColumnLbl
        '
        Me.FieldDetails_ColumnLbl.AutoSize = True
        Me.FieldDetails_ColumnLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldDetails_ColumnLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FieldDetails_ColumnLbl.Location = New System.Drawing.Point(6, 5)
        Me.FieldDetails_ColumnLbl.Name = "FieldDetails_ColumnLbl"
        Me.FieldDetails_ColumnLbl.Size = New System.Drawing.Size(84, 15)
        Me.FieldDetails_ColumnLbl.TabIndex = 67
        Me.FieldDetails_ColumnLbl.Text = "Add Column"
        '
        'FieldDetails_FormulaChkbx
        '
        Me.FieldDetails_FormulaChkbx.AccessibleDescription = "Formula"
        Me.FieldDetails_FormulaChkbx.AutoSize = True
        Me.FieldDetails_FormulaChkbx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FieldDetails_FormulaChkbx.Location = New System.Drawing.Point(111, 128)
        Me.FieldDetails_FormulaChkbx.Name = "FieldDetails_FormulaChkbx"
        Me.FieldDetails_FormulaChkbx.Size = New System.Drawing.Size(63, 17)
        Me.FieldDetails_FormulaChkbx.TabIndex = 66
        Me.FieldDetails_FormulaChkbx.Text = "Formula"
        Me.FieldDetails_FormulaChkbx.UseVisualStyleBackColor = True
        '
        'FieldDetails_ColumnTYpeCmbo
        '
        Me.FieldDetails_ColumnTYpeCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldDetails_ColumnTYpeCmbo.FormattingEnabled = True
        Me.FieldDetails_ColumnTYpeCmbo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldDetails_ColumnTYpeCmbo.Items.AddRange(New Object() {"CHAR", "VARCHAR", "BIT", "INTEGER", "SMALLINT", "DECIMAL", "NUMERIC", "REAL", "FLOAT", "DATE", "TIME"})
        Me.FieldDetails_ColumnTYpeCmbo.Location = New System.Drawing.Point(11, 85)
        Me.FieldDetails_ColumnTYpeCmbo.Name = "FieldDetails_ColumnTYpeCmbo"
        Me.FieldDetails_ColumnTYpeCmbo.Size = New System.Drawing.Size(127, 21)
        Me.FieldDetails_ColumnTYpeCmbo.TabIndex = 42
        '
        'FieldDetails_DefFld
        '
        Me.FieldDetails_DefFld.Enabled = False
        Me.FieldDetails_DefFld.Location = New System.Drawing.Point(187, 125)
        Me.FieldDetails_DefFld.Name = "FieldDetails_DefFld"
        Me.FieldDetails_DefFld.Size = New System.Drawing.Size(241, 20)
        Me.FieldDetails_DefFld.TabIndex = 65
        '
        'FieldDetails_ColumnNameLbl
        '
        Me.FieldDetails_ColumnNameLbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldDetails_ColumnNameLbl.AutoSize = True
        Me.FieldDetails_ColumnNameLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_ColumnNameLbl.Location = New System.Drawing.Point(161, 18)
        Me.FieldDetails_ColumnNameLbl.Name = "FieldDetails_ColumnNameLbl"
        Me.FieldDetails_ColumnNameLbl.Size = New System.Drawing.Size(101, 13)
        Me.FieldDetails_ColumnNameLbl.TabIndex = 40
        Me.FieldDetails_ColumnNameLbl.Text = "Enter Column Name"
        '
        'FieldDetails_DefValChkbx
        '
        Me.FieldDetails_DefValChkbx.AutoSize = True
        Me.FieldDetails_DefValChkbx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FieldDetails_DefValChkbx.Location = New System.Drawing.Point(15, 127)
        Me.FieldDetails_DefValChkbx.Name = "FieldDetails_DefValChkbx"
        Me.FieldDetails_DefValChkbx.Size = New System.Drawing.Size(90, 17)
        Me.FieldDetails_DefValChkbx.TabIndex = 64
        Me.FieldDetails_DefValChkbx.Text = "Default Value"
        Me.FieldDetails_DefValChkbx.UseVisualStyleBackColor = True
        '
        'FieldDetails_ColumnNameFld
        '
        Me.FieldDetails_ColumnNameFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldDetails_ColumnNameFld.Depth = 0
        Me.FieldDetails_ColumnNameFld.Hint = ""
        Me.FieldDetails_ColumnNameFld.Location = New System.Drawing.Point(11, 34)
        Me.FieldDetails_ColumnNameFld.MouseState = MaterialSkin.MouseState.HOVER
        Me.FieldDetails_ColumnNameFld.Name = "FieldDetails_ColumnNameFld"
        Me.FieldDetails_ColumnNameFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FieldDetails_ColumnNameFld.SelectedText = ""
        Me.FieldDetails_ColumnNameFld.SelectionLength = 0
        Me.FieldDetails_ColumnNameFld.SelectionStart = 0
        Me.FieldDetails_ColumnNameFld.Size = New System.Drawing.Size(424, 23)
        Me.FieldDetails_ColumnNameFld.TabIndex = 41
        Me.FieldDetails_ColumnNameFld.UseSystemPasswordChar = False
        '
        'FieldDetails_Precision
        '
        Me.FieldDetails_Precision.Location = New System.Drawing.Point(340, 85)
        Me.FieldDetails_Precision.Name = "FieldDetails_Precision"
        Me.FieldDetails_Precision.Size = New System.Drawing.Size(41, 20)
        Me.FieldDetails_Precision.TabIndex = 63
        '
        'FieldDetails_PreScleLbl
        '
        Me.FieldDetails_PreScleLbl.AutoSize = True
        Me.FieldDetails_PreScleLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_PreScleLbl.Location = New System.Drawing.Point(337, 66)
        Me.FieldDetails_PreScleLbl.Name = "FieldDetails_PreScleLbl"
        Me.FieldDetails_PreScleLbl.Size = New System.Drawing.Size(91, 13)
        Me.FieldDetails_PreScleLbl.TabIndex = 60
        Me.FieldDetails_PreScleLbl.Text = "(Presision , Scale)"
        '
        'FieldDetails_SizeLbl
        '
        Me.FieldDetails_SizeLbl.AutoSize = True
        Me.FieldDetails_SizeLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_SizeLbl.Location = New System.Drawing.Point(189, 69)
        Me.FieldDetails_SizeLbl.Name = "FieldDetails_SizeLbl"
        Me.FieldDetails_SizeLbl.Size = New System.Drawing.Size(27, 13)
        Me.FieldDetails_SizeLbl.TabIndex = 45
        Me.FieldDetails_SizeLbl.Text = "Size"
        '
        'FieldDetails_TypeLbl
        '
        Me.FieldDetails_TypeLbl.AutoSize = True
        Me.FieldDetails_TypeLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_TypeLbl.Location = New System.Drawing.Point(9, 69)
        Me.FieldDetails_TypeLbl.Name = "FieldDetails_TypeLbl"
        Me.FieldDetails_TypeLbl.Size = New System.Drawing.Size(31, 13)
        Me.FieldDetails_TypeLbl.TabIndex = 43
        Me.FieldDetails_TypeLbl.Text = "Type"
        '
        'FieldDetails_Size
        '
        Me.FieldDetails_Size.Enabled = False
        Me.FieldDetails_Size.Location = New System.Drawing.Point(187, 85)
        Me.FieldDetails_Size.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.FieldDetails_Size.Name = "FieldDetails_Size"
        Me.FieldDetails_Size.Size = New System.Drawing.Size(85, 20)
        Me.FieldDetails_Size.TabIndex = 46
        '
        'FieldDetails_Scale
        '
        Me.FieldDetails_Scale.Location = New System.Drawing.Point(387, 85)
        Me.FieldDetails_Scale.Name = "FieldDetails_Scale"
        Me.FieldDetails_Scale.Size = New System.Drawing.Size(41, 20)
        Me.FieldDetails_Scale.TabIndex = 62
        '
        'FieldDetails_ForeignKeyGrp
        '
        Me.FieldDetails_ForeignKeyGrp.Controls.Add(Me.FieldDetails_ForeignKeyLbl)
        Me.FieldDetails_ForeignKeyGrp.Controls.Add(Me.FieldDetails_ForeignKeyFld)
        Me.FieldDetails_ForeignKeyGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldDetails_ForeignKeyGrp.Location = New System.Drawing.Point(0, 0)
        Me.FieldDetails_ForeignKeyGrp.Name = "FieldDetails_ForeignKeyGrp"
        Me.FieldDetails_ForeignKeyGrp.Size = New System.Drawing.Size(444, 160)
        Me.FieldDetails_ForeignKeyGrp.TabIndex = 0
        Me.FieldDetails_ForeignKeyGrp.Visible = False
        '
        'FieldDetails_ForeignKeyLbl
        '
        Me.FieldDetails_ForeignKeyLbl.AutoSize = True
        Me.FieldDetails_ForeignKeyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldDetails_ForeignKeyLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FieldDetails_ForeignKeyLbl.Location = New System.Drawing.Point(7, 0)
        Me.FieldDetails_ForeignKeyLbl.Name = "FieldDetails_ForeignKeyLbl"
        Me.FieldDetails_ForeignKeyLbl.Size = New System.Drawing.Size(111, 15)
        Me.FieldDetails_ForeignKeyLbl.TabIndex = 68
        Me.FieldDetails_ForeignKeyLbl.Text = "Add Foreign Key"
        '
        'FieldDetails_ForeignKeyFld
        '
        Me.FieldDetails_ForeignKeyFld.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldDetails_ForeignKeyFld.Location = New System.Drawing.Point(4, 23)
        Me.FieldDetails_ForeignKeyFld.Multiline = True
        Me.FieldDetails_ForeignKeyFld.Name = "FieldDetails_ForeignKeyFld"
        Me.FieldDetails_ForeignKeyFld.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.FieldDetails_ForeignKeyFld.Size = New System.Drawing.Size(434, 134)
        Me.FieldDetails_ForeignKeyFld.TabIndex = 54
        Me.FieldDetails_ForeignKeyFld.WordWrap = False
        '
        'FieldDetails_PrimyGrp
        '
        Me.FieldDetails_PrimyGrp.Controls.Add(Me.FieldDetails_PrimLbl)
        Me.FieldDetails_PrimyGrp.Controls.Add(Me.FieldDetails_PrimFld)
        Me.FieldDetails_PrimyGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldDetails_PrimyGrp.Location = New System.Drawing.Point(0, 0)
        Me.FieldDetails_PrimyGrp.Name = "FieldDetails_PrimyGrp"
        Me.FieldDetails_PrimyGrp.Size = New System.Drawing.Size(444, 160)
        Me.FieldDetails_PrimyGrp.TabIndex = 0
        Me.FieldDetails_PrimyGrp.Visible = False
        '
        'FieldDetails_PrimLbl
        '
        Me.FieldDetails_PrimLbl.AutoSize = True
        Me.FieldDetails_PrimLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldDetails_PrimLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FieldDetails_PrimLbl.Location = New System.Drawing.Point(7, 0)
        Me.FieldDetails_PrimLbl.Name = "FieldDetails_PrimLbl"
        Me.FieldDetails_PrimLbl.Size = New System.Drawing.Size(111, 15)
        Me.FieldDetails_PrimLbl.TabIndex = 69
        Me.FieldDetails_PrimLbl.Text = "Add Primary Key"
        '
        'FieldDetails_PrimFld
        '
        Me.FieldDetails_PrimFld.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldDetails_PrimFld.Location = New System.Drawing.Point(4, 23)
        Me.FieldDetails_PrimFld.Multiline = True
        Me.FieldDetails_PrimFld.Name = "FieldDetails_PrimFld"
        Me.FieldDetails_PrimFld.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.FieldDetails_PrimFld.Size = New System.Drawing.Size(434, 134)
        Me.FieldDetails_PrimFld.TabIndex = 54
        Me.FieldDetails_PrimFld.WordWrap = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.FieldDetails_CheckGrp)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Controls.Add(Me.FieldDetails_CreateFieldBtn)
        Me.Panel3.Location = New System.Drawing.Point(0, 163)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(444, 335)
        Me.Panel3.TabIndex = 12
        '
        'FieldDetails_CheckGrp
        '
        Me.FieldDetails_CheckGrp.Controls.Add(Me.Label22)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckChkbx)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckTypeLbl)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckTypeCmbo)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_StringPstnLbl)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckPstnCmbo)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckFld)
        Me.FieldDetails_CheckGrp.Location = New System.Drawing.Point(0, 110)
        Me.FieldDetails_CheckGrp.Name = "FieldDetails_CheckGrp"
        Me.FieldDetails_CheckGrp.Size = New System.Drawing.Size(441, 174)
        Me.FieldDetails_CheckGrp.TabIndex = 74
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(6, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 15)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "Check"
        '
        'FieldDetails_CheckChkbx
        '
        Me.FieldDetails_CheckChkbx.AutoSize = True
        Me.FieldDetails_CheckChkbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_CheckChkbx.Location = New System.Drawing.Point(5, 37)
        Me.FieldDetails_CheckChkbx.Name = "FieldDetails_CheckChkbx"
        Me.FieldDetails_CheckChkbx.Size = New System.Drawing.Size(57, 17)
        Me.FieldDetails_CheckChkbx.TabIndex = 56
        Me.FieldDetails_CheckChkbx.Text = "Check"
        Me.FieldDetails_CheckChkbx.UseVisualStyleBackColor = True
        '
        'FieldDetails_CheckTypeLbl
        '
        Me.FieldDetails_CheckTypeLbl.AutoSize = True
        Me.FieldDetails_CheckTypeLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_CheckTypeLbl.Location = New System.Drawing.Point(88, 21)
        Me.FieldDetails_CheckTypeLbl.Name = "FieldDetails_CheckTypeLbl"
        Me.FieldDetails_CheckTypeLbl.Size = New System.Drawing.Size(65, 13)
        Me.FieldDetails_CheckTypeLbl.TabIndex = 50
        Me.FieldDetails_CheckTypeLbl.Text = "Check Type"
        '
        'FieldDetails_CheckTypeCmbo
        '
        Me.FieldDetails_CheckTypeCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldDetails_CheckTypeCmbo.Enabled = False
        Me.FieldDetails_CheckTypeCmbo.FormattingEnabled = True
        Me.FieldDetails_CheckTypeCmbo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldDetails_CheckTypeCmbo.Items.AddRange(New Object() {"LIKE", "IN", "Numeric/Logical Expresion/Other"})
        Me.FieldDetails_CheckTypeCmbo.Location = New System.Drawing.Point(88, 40)
        Me.FieldDetails_CheckTypeCmbo.Name = "FieldDetails_CheckTypeCmbo"
        Me.FieldDetails_CheckTypeCmbo.Size = New System.Drawing.Size(156, 21)
        Me.FieldDetails_CheckTypeCmbo.TabIndex = 55
        '
        'FieldDetails_StringPstnLbl
        '
        Me.FieldDetails_StringPstnLbl.AutoSize = True
        Me.FieldDetails_StringPstnLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_StringPstnLbl.Location = New System.Drawing.Point(257, 21)
        Me.FieldDetails_StringPstnLbl.Name = "FieldDetails_StringPstnLbl"
        Me.FieldDetails_StringPstnLbl.Size = New System.Drawing.Size(74, 13)
        Me.FieldDetails_StringPstnLbl.TabIndex = 52
        Me.FieldDetails_StringPstnLbl.Text = "String Position"
        '
        'FieldDetails_CheckPstnCmbo
        '
        Me.FieldDetails_CheckPstnCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldDetails_CheckPstnCmbo.Enabled = False
        Me.FieldDetails_CheckPstnCmbo.FormattingEnabled = True
        Me.FieldDetails_CheckPstnCmbo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldDetails_CheckPstnCmbo.Items.AddRange(New Object() {"Before any string", "After any string", "Between any string", "Other/Specific"})
        Me.FieldDetails_CheckPstnCmbo.Location = New System.Drawing.Point(260, 40)
        Me.FieldDetails_CheckPstnCmbo.Name = "FieldDetails_CheckPstnCmbo"
        Me.FieldDetails_CheckPstnCmbo.Size = New System.Drawing.Size(156, 21)
        Me.FieldDetails_CheckPstnCmbo.TabIndex = 51
        '
        'FieldDetails_CheckFld
        '
        Me.FieldDetails_CheckFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldDetails_CheckFld.Enabled = False
        Me.FieldDetails_CheckFld.Location = New System.Drawing.Point(6, 70)
        Me.FieldDetails_CheckFld.Multiline = True
        Me.FieldDetails_CheckFld.Name = "FieldDetails_CheckFld"
        Me.FieldDetails_CheckFld.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.FieldDetails_CheckFld.Size = New System.Drawing.Size(435, 104)
        Me.FieldDetails_CheckFld.TabIndex = 53
        Me.FieldDetails_CheckFld.WordWrap = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FieldDetails_ReferenceGrp, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FieldDetails_ConstraintGrp, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(447, 110)
        Me.TableLayoutPanel1.TabIndex = 73
        '
        'FieldDetails_ReferenceGrp
        '
        Me.FieldDetails_ReferenceGrp.Controls.Add(Me.FieldDetails_ReferentialLbl)
        Me.FieldDetails_ReferenceGrp.Controls.Add(Me.FieldDetails_OnDeleteCmbo)
        Me.FieldDetails_ReferenceGrp.Controls.Add(Me.FieldDetails_ReferenceChkBx)
        Me.FieldDetails_ReferenceGrp.Controls.Add(Me.FieldDetails_OnUpdateCmbo)
        Me.FieldDetails_ReferenceGrp.Controls.Add(Me.FieldDetails_ReferenceFld)
        Me.FieldDetails_ReferenceGrp.Controls.Add(Me.FieldDetails_OnDeleteChkbx)
        Me.FieldDetails_ReferenceGrp.Controls.Add(Me.FieldDetails_OnUpdateChkBx)
        Me.FieldDetails_ReferenceGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldDetails_ReferenceGrp.Location = New System.Drawing.Point(0, 0)
        Me.FieldDetails_ReferenceGrp.Margin = New System.Windows.Forms.Padding(0)
        Me.FieldDetails_ReferenceGrp.Name = "FieldDetails_ReferenceGrp"
        Me.FieldDetails_ReferenceGrp.Size = New System.Drawing.Size(268, 110)
        Me.FieldDetails_ReferenceGrp.TabIndex = 67
        '
        'FieldDetails_ReferentialLbl
        '
        Me.FieldDetails_ReferentialLbl.AutoSize = True
        Me.FieldDetails_ReferentialLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldDetails_ReferentialLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FieldDetails_ReferentialLbl.Location = New System.Drawing.Point(6, -3)
        Me.FieldDetails_ReferentialLbl.Name = "FieldDetails_ReferentialLbl"
        Me.FieldDetails_ReferentialLbl.Size = New System.Drawing.Size(78, 15)
        Me.FieldDetails_ReferentialLbl.TabIndex = 70
        Me.FieldDetails_ReferentialLbl.Text = "Referential"
        '
        'FieldDetails_OnDeleteCmbo
        '
        Me.FieldDetails_OnDeleteCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldDetails_OnDeleteCmbo.Enabled = False
        Me.FieldDetails_OnDeleteCmbo.FormattingEnabled = True
        Me.FieldDetails_OnDeleteCmbo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldDetails_OnDeleteCmbo.Items.AddRange(New Object() {"CASCADE", "SET NULL", "SET DEFAULT", "NO ACTION"})
        Me.FieldDetails_OnDeleteCmbo.Location = New System.Drawing.Point(89, 83)
        Me.FieldDetails_OnDeleteCmbo.Name = "FieldDetails_OnDeleteCmbo"
        Me.FieldDetails_OnDeleteCmbo.Size = New System.Drawing.Size(124, 21)
        Me.FieldDetails_OnDeleteCmbo.TabIndex = 61
        '
        'FieldDetails_ReferenceChkBx
        '
        Me.FieldDetails_ReferenceChkBx.AutoSize = True
        Me.FieldDetails_ReferenceChkBx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_ReferenceChkBx.Location = New System.Drawing.Point(9, 25)
        Me.FieldDetails_ReferenceChkBx.Name = "FieldDetails_ReferenceChkBx"
        Me.FieldDetails_ReferenceChkBx.Size = New System.Drawing.Size(81, 17)
        Me.FieldDetails_ReferenceChkBx.TabIndex = 54
        Me.FieldDetails_ReferenceChkBx.Text = "References"
        Me.FieldDetails_ReferenceChkBx.UseVisualStyleBackColor = True
        '
        'FieldDetails_OnUpdateCmbo
        '
        Me.FieldDetails_OnUpdateCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldDetails_OnUpdateCmbo.Enabled = False
        Me.FieldDetails_OnUpdateCmbo.FormattingEnabled = True
        Me.FieldDetails_OnUpdateCmbo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldDetails_OnUpdateCmbo.Items.AddRange(New Object() {"CASCADE", "SET NULL", "SET DEFAULT", "NO ACTION"})
        Me.FieldDetails_OnUpdateCmbo.Location = New System.Drawing.Point(90, 51)
        Me.FieldDetails_OnUpdateCmbo.Name = "FieldDetails_OnUpdateCmbo"
        Me.FieldDetails_OnUpdateCmbo.Size = New System.Drawing.Size(124, 21)
        Me.FieldDetails_OnUpdateCmbo.TabIndex = 60
        '
        'FieldDetails_ReferenceFld
        '
        Me.FieldDetails_ReferenceFld.Enabled = False
        Me.FieldDetails_ReferenceFld.Location = New System.Drawing.Point(91, 22)
        Me.FieldDetails_ReferenceFld.Name = "FieldDetails_ReferenceFld"
        Me.FieldDetails_ReferenceFld.Size = New System.Drawing.Size(153, 20)
        Me.FieldDetails_ReferenceFld.TabIndex = 55
        '
        'FieldDetails_OnDeleteChkbx
        '
        Me.FieldDetails_OnDeleteChkbx.AutoSize = True
        Me.FieldDetails_OnDeleteChkbx.Enabled = False
        Me.FieldDetails_OnDeleteChkbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_OnDeleteChkbx.Location = New System.Drawing.Point(9, 87)
        Me.FieldDetails_OnDeleteChkbx.Name = "FieldDetails_OnDeleteChkbx"
        Me.FieldDetails_OnDeleteChkbx.Size = New System.Drawing.Size(74, 17)
        Me.FieldDetails_OnDeleteChkbx.TabIndex = 59
        Me.FieldDetails_OnDeleteChkbx.Text = "On Delete"
        Me.FieldDetails_OnDeleteChkbx.UseVisualStyleBackColor = True
        '
        'FieldDetails_OnUpdateChkBx
        '
        Me.FieldDetails_OnUpdateChkBx.AutoSize = True
        Me.FieldDetails_OnUpdateChkBx.Enabled = False
        Me.FieldDetails_OnUpdateChkBx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_OnUpdateChkBx.Location = New System.Drawing.Point(9, 55)
        Me.FieldDetails_OnUpdateChkBx.Name = "FieldDetails_OnUpdateChkBx"
        Me.FieldDetails_OnUpdateChkBx.Size = New System.Drawing.Size(78, 17)
        Me.FieldDetails_OnUpdateChkBx.TabIndex = 57
        Me.FieldDetails_OnUpdateChkBx.Text = "On Update"
        Me.FieldDetails_OnUpdateChkBx.UseVisualStyleBackColor = True
        '
        'FieldDetails_ConstraintGrp
        '
        Me.FieldDetails_ConstraintGrp.Controls.Add(Me.FieldDetails_ConstraintsLbl)
        Me.FieldDetails_ConstraintGrp.Controls.Add(Me.FieldDetails_ForeignChkbx)
        Me.FieldDetails_ConstraintGrp.Controls.Add(Me.FieldDetails_NotNullChkbx)
        Me.FieldDetails_ConstraintGrp.Controls.Add(Me.FieldDetails_UniqueChkbx)
        Me.FieldDetails_ConstraintGrp.Controls.Add(Me.FieldDetails_PrimChkbx)
        Me.FieldDetails_ConstraintGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldDetails_ConstraintGrp.Location = New System.Drawing.Point(268, 0)
        Me.FieldDetails_ConstraintGrp.Margin = New System.Windows.Forms.Padding(0)
        Me.FieldDetails_ConstraintGrp.Name = "FieldDetails_ConstraintGrp"
        Me.FieldDetails_ConstraintGrp.Size = New System.Drawing.Size(179, 110)
        Me.FieldDetails_ConstraintGrp.TabIndex = 68
        '
        'FieldDetails_ConstraintsLbl
        '
        Me.FieldDetails_ConstraintsLbl.AutoSize = True
        Me.FieldDetails_ConstraintsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldDetails_ConstraintsLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FieldDetails_ConstraintsLbl.Location = New System.Drawing.Point(0, -3)
        Me.FieldDetails_ConstraintsLbl.Name = "FieldDetails_ConstraintsLbl"
        Me.FieldDetails_ConstraintsLbl.Size = New System.Drawing.Size(79, 15)
        Me.FieldDetails_ConstraintsLbl.TabIndex = 70
        Me.FieldDetails_ConstraintsLbl.Text = "Constraints"
        '
        'FieldDetails_ForeignChkbx
        '
        Me.FieldDetails_ForeignChkbx.AutoSize = True
        Me.FieldDetails_ForeignChkbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_ForeignChkbx.Location = New System.Drawing.Point(3, 45)
        Me.FieldDetails_ForeignChkbx.Name = "FieldDetails_ForeignChkbx"
        Me.FieldDetails_ForeignChkbx.Size = New System.Drawing.Size(98, 17)
        Me.FieldDetails_ForeignChkbx.TabIndex = 58
        Me.FieldDetails_ForeignChkbx.Text = "FOREIGN KEY"
        Me.FieldDetails_ForeignChkbx.UseVisualStyleBackColor = True
        '
        'FieldDetails_NotNullChkbx
        '
        Me.FieldDetails_NotNullChkbx.AutoSize = True
        Me.FieldDetails_NotNullChkbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_NotNullChkbx.Location = New System.Drawing.Point(3, 68)
        Me.FieldDetails_NotNullChkbx.Name = "FieldDetails_NotNullChkbx"
        Me.FieldDetails_NotNullChkbx.Size = New System.Drawing.Size(80, 17)
        Me.FieldDetails_NotNullChkbx.TabIndex = 54
        Me.FieldDetails_NotNullChkbx.Text = "NOT NULL"
        Me.FieldDetails_NotNullChkbx.UseVisualStyleBackColor = True
        '
        'FieldDetails_UniqueChkbx
        '
        Me.FieldDetails_UniqueChkbx.AutoSize = True
        Me.FieldDetails_UniqueChkbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_UniqueChkbx.Location = New System.Drawing.Point(3, 91)
        Me.FieldDetails_UniqueChkbx.Name = "FieldDetails_UniqueChkbx"
        Me.FieldDetails_UniqueChkbx.Size = New System.Drawing.Size(68, 17)
        Me.FieldDetails_UniqueChkbx.TabIndex = 57
        Me.FieldDetails_UniqueChkbx.Text = "UNIQUE"
        Me.FieldDetails_UniqueChkbx.UseVisualStyleBackColor = True
        '
        'FieldDetails_PrimChkbx
        '
        Me.FieldDetails_PrimChkbx.AutoSize = True
        Me.FieldDetails_PrimChkbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_PrimChkbx.Location = New System.Drawing.Point(3, 24)
        Me.FieldDetails_PrimChkbx.Name = "FieldDetails_PrimChkbx"
        Me.FieldDetails_PrimChkbx.Size = New System.Drawing.Size(99, 17)
        Me.FieldDetails_PrimChkbx.TabIndex = 44
        Me.FieldDetails_PrimChkbx.Text = "PRIMARY KEY"
        Me.FieldDetails_PrimChkbx.UseVisualStyleBackColor = True
        '
        'FieldDetails_CreateFieldBtn
        '
        Me.FieldDetails_CreateFieldBtn.AutoSize = True
        Me.FieldDetails_CreateFieldBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FieldDetails_CreateFieldBtn.Depth = 0
        Me.FieldDetails_CreateFieldBtn.Location = New System.Drawing.Point(9, 293)
        Me.FieldDetails_CreateFieldBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.FieldDetails_CreateFieldBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.FieldDetails_CreateFieldBtn.Name = "FieldDetails_CreateFieldBtn"
        Me.FieldDetails_CreateFieldBtn.Primary = False
        Me.FieldDetails_CreateFieldBtn.Size = New System.Drawing.Size(48, 36)
        Me.FieldDetails_CreateFieldBtn.TabIndex = 72
        Me.FieldDetails_CreateFieldBtn.Text = "Done"
        Me.FieldDetails_CreateFieldBtn.UseVisualStyleBackColor = True
        '
        'CreateTable_BtbTableLayout
        '
        Me.CreateTable_BtbTableLayout.ColumnCount = 4
        Me.CreateTable_BtbTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CreateTable_BtbTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CreateTable_BtbTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CreateTable_BtbTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CreateTable_BtbTableLayout.Controls.Add(Me.CreateTable_AddPrimKeyBtn, 1, 0)
        Me.CreateTable_BtbTableLayout.Controls.Add(Me.CreateTable_CompleteTableBtn, 3, 0)
        Me.CreateTable_BtbTableLayout.Controls.Add(Me.CreateTable_AddForeignKeyBtn, 2, 0)
        Me.CreateTable_BtbTableLayout.Controls.Add(Me.CreateTable_AddColumnBtn, 0, 0)
        Me.CreateTable_BtbTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateTable_BtbTableLayout.Location = New System.Drawing.Point(3, 64)
        Me.CreateTable_BtbTableLayout.Name = "CreateTable_BtbTableLayout"
        Me.CreateTable_BtbTableLayout.RowCount = 1
        Me.CreateTable_BtbTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CreateTable_BtbTableLayout.Size = New System.Drawing.Size(444, 55)
        Me.CreateTable_BtbTableLayout.TabIndex = 6
        '
        'CreateTable_AddPrimKeyBtn
        '
        Me.CreateTable_AddPrimKeyBtn.AutoSize = True
        Me.CreateTable_AddPrimKeyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateTable_AddPrimKeyBtn.Depth = 0
        Me.CreateTable_AddPrimKeyBtn.Enabled = False
        Me.CreateTable_AddPrimKeyBtn.Location = New System.Drawing.Point(115, 6)
        Me.CreateTable_AddPrimKeyBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CreateTable_AddPrimKeyBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateTable_AddPrimKeyBtn.Name = "CreateTable_AddPrimKeyBtn"
        Me.CreateTable_AddPrimKeyBtn.Primary = False
        Me.CreateTable_AddPrimKeyBtn.Size = New System.Drawing.Size(103, 36)
        Me.CreateTable_AddPrimKeyBtn.TabIndex = 65
        Me.CreateTable_AddPrimKeyBtn.Text = "Add Primay Key"
        Me.CreateTable_AddPrimKeyBtn.UseVisualStyleBackColor = True
        '
        'CreateTable_CompleteTableBtn
        '
        Me.CreateTable_CompleteTableBtn.AutoSize = True
        Me.CreateTable_CompleteTableBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateTable_CompleteTableBtn.Depth = 0
        Me.CreateTable_CompleteTableBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateTable_CompleteTableBtn.Enabled = False
        Me.CreateTable_CompleteTableBtn.Location = New System.Drawing.Point(337, 6)
        Me.CreateTable_CompleteTableBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CreateTable_CompleteTableBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateTable_CompleteTableBtn.Name = "CreateTable_CompleteTableBtn"
        Me.CreateTable_CompleteTableBtn.Primary = False
        Me.CreateTable_CompleteTableBtn.Size = New System.Drawing.Size(103, 43)
        Me.CreateTable_CompleteTableBtn.TabIndex = 68
        Me.CreateTable_CompleteTableBtn.Text = "complete table"
        Me.CreateTable_CompleteTableBtn.UseVisualStyleBackColor = True
        '
        'CreateTable_AddForeignKeyBtn
        '
        Me.CreateTable_AddForeignKeyBtn.AutoSize = True
        Me.CreateTable_AddForeignKeyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateTable_AddForeignKeyBtn.Depth = 0
        Me.CreateTable_AddForeignKeyBtn.Enabled = False
        Me.CreateTable_AddForeignKeyBtn.Location = New System.Drawing.Point(226, 6)
        Me.CreateTable_AddForeignKeyBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CreateTable_AddForeignKeyBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateTable_AddForeignKeyBtn.Name = "CreateTable_AddForeignKeyBtn"
        Me.CreateTable_AddForeignKeyBtn.Primary = False
        Me.CreateTable_AddForeignKeyBtn.Size = New System.Drawing.Size(103, 36)
        Me.CreateTable_AddForeignKeyBtn.TabIndex = 67
        Me.CreateTable_AddForeignKeyBtn.Text = "Add Foreign Key"
        Me.CreateTable_AddForeignKeyBtn.UseVisualStyleBackColor = True
        '
        'CreateTable_AddColumnBtn
        '
        Me.CreateTable_AddColumnBtn.AutoSize = True
        Me.CreateTable_AddColumnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateTable_AddColumnBtn.Depth = 0
        Me.CreateTable_AddColumnBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateTable_AddColumnBtn.Enabled = False
        Me.CreateTable_AddColumnBtn.Location = New System.Drawing.Point(4, 6)
        Me.CreateTable_AddColumnBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CreateTable_AddColumnBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateTable_AddColumnBtn.Name = "CreateTable_AddColumnBtn"
        Me.CreateTable_AddColumnBtn.Primary = False
        Me.CreateTable_AddColumnBtn.Size = New System.Drawing.Size(103, 43)
        Me.CreateTable_AddColumnBtn.TabIndex = 66
        Me.CreateTable_AddColumnBtn.Text = "Add Column"
        Me.CreateTable_AddColumnBtn.UseVisualStyleBackColor = True
        '
        'AlterTablePage
        '
        Me.AlterTablePage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AlterTablePage.Controls.Add(Me.AlterTableLayoutPanel)
        Me.AlterTablePage.Location = New System.Drawing.Point(4, 22)
        Me.AlterTablePage.Name = "AlterTablePage"
        Me.AlterTablePage.Padding = New System.Windows.Forms.Padding(3)
        Me.AlterTablePage.Size = New System.Drawing.Size(456, 686)
        Me.AlterTablePage.TabIndex = 3
        Me.AlterTablePage.Text = "Alter Table"
        '
        'AlterTableLayoutPanel
        '
        Me.AlterTableLayoutPanel.ColumnCount = 1
        Me.AlterTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AlterTableLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.AlterTableLayoutPanel.Controls.Add(Me.Panel13, 0, 2)
        Me.AlterTableLayoutPanel.Controls.Add(Me.AlterButtonsTableLayout, 0, 1)
        Me.AlterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
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
        Me.AlterTableLayoutPanel.Size = New System.Drawing.Size(450, 680)
        Me.AlterTableLayoutPanel.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Alter_Table_Name)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 49)
        Me.Panel1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(176, 2)
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
        Me.Alter_Table_Name.Size = New System.Drawing.Size(418, 23)
        Me.Alter_Table_Name.TabIndex = 37
        Me.Alter_Table_Name.UseSystemPasswordChar = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.RenameGroup)
        Me.Panel13.Controls.Add(Me.DropGroup)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 122)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(450, 61)
        Me.Panel13.TabIndex = 40
        '
        'RenameGroup
        '
        Me.RenameGroup.Controls.Add(Me.Label15)
        Me.RenameGroup.Controls.Add(Me.Rename)
        Me.RenameGroup.Controls.Add(Me.NewTableName)
        Me.RenameGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RenameGroup.Location = New System.Drawing.Point(0, 0)
        Me.RenameGroup.Name = "RenameGroup"
        Me.RenameGroup.Size = New System.Drawing.Size(450, 61)
        Me.RenameGroup.TabIndex = 6
        Me.RenameGroup.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(13, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 15)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Rename Table"
        '
        'Rename
        '
        Me.Rename.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Rename.AutoSize = True
        Me.Rename.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Rename.BackColor = System.Drawing.Color.White
        Me.Rename.Depth = 0
        Me.Rename.ForeColor = System.Drawing.Color.Transparent
        Me.Rename.Location = New System.Drawing.Point(382, 26)
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
        Me.NewTableName.Location = New System.Drawing.Point(6, 36)
        Me.NewTableName.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableName.Name = "NewTableName"
        Me.NewTableName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewTableName.SelectedText = ""
        Me.NewTableName.SelectionLength = 0
        Me.NewTableName.SelectionStart = 0
        Me.NewTableName.Size = New System.Drawing.Size(364, 23)
        Me.NewTableName.TabIndex = 38
        Me.NewTableName.UseSystemPasswordChar = False
        '
        'DropGroup
        '
        Me.DropGroup.Controls.Add(Me.Label16)
        Me.DropGroup.Controls.Add(Me.Alter_Drop_Table)
        Me.DropGroup.Controls.Add(Me.DropColumn)
        Me.DropGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropGroup.Location = New System.Drawing.Point(0, 0)
        Me.DropGroup.Name = "DropGroup"
        Me.DropGroup.Size = New System.Drawing.Size(450, 61)
        Me.DropGroup.TabIndex = 5
        Me.DropGroup.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(12, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 15)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Delete Column"
        '
        'Alter_Drop_Table
        '
        Me.Alter_Drop_Table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Alter_Drop_Table.Depth = 0
        Me.Alter_Drop_Table.Hint = ""
        Me.Alter_Drop_Table.Location = New System.Drawing.Point(15, 33)
        Me.Alter_Drop_Table.MouseState = MaterialSkin.MouseState.HOVER
        Me.Alter_Drop_Table.Name = "Alter_Drop_Table"
        Me.Alter_Drop_Table.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Alter_Drop_Table.SelectedText = ""
        Me.Alter_Drop_Table.SelectionLength = 0
        Me.Alter_Drop_Table.SelectionStart = 0
        Me.Alter_Drop_Table.Size = New System.Drawing.Size(364, 23)
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
        Me.DropColumn.Location = New System.Drawing.Point(395, 23)
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
        Me.AlterButtonsTableLayout.Location = New System.Drawing.Point(3, 64)
        Me.AlterButtonsTableLayout.Name = "AlterButtonsTableLayout"
        Me.AlterButtonsTableLayout.RowCount = 1
        Me.AlterButtonsTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AlterButtonsTableLayout.Size = New System.Drawing.Size(444, 55)
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
        Me.AlterModify.Size = New System.Drawing.Size(103, 43)
        Me.AlterModify.TabIndex = 10
        Me.AlterModify.Text = "Modify Column"
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
        Me.AlterRename.Size = New System.Drawing.Size(103, 43)
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
        Me.AlterDrop.Size = New System.Drawing.Size(103, 43)
        Me.AlterDrop.TabIndex = 9
        Me.AlterDrop.Text = "Delete Column"
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
        Me.AlterAdd.Size = New System.Drawing.Size(103, 43)
        Me.AlterAdd.TabIndex = 8
        Me.AlterAdd.Text = "Add Column"
        Me.AlterAdd.UseVisualStyleBackColor = True
        '
        'InsertPage
        '
        Me.InsertPage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InsertPage.Controls.Add(Me.InsertTableLayout)
        Me.InsertPage.Location = New System.Drawing.Point(4, 22)
        Me.InsertPage.Name = "InsertPage"
        Me.InsertPage.Padding = New System.Windows.Forms.Padding(3)
        Me.InsertPage.Size = New System.Drawing.Size(456, 686)
        Me.InsertPage.TabIndex = 4
        Me.InsertPage.Text = "Insert"
        '
        'InsertTableLayout
        '
        Me.InsertTableLayout.ColumnCount = 1
        Me.InsertTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InsertTableLayout.Controls.Add(Me.Panel6, 0, 0)
        Me.InsertTableLayout.Controls.Add(Me.Panel7, 0, 9)
        Me.InsertTableLayout.Controls.Add(Me.Panel10, 0, 1)
        Me.InsertTableLayout.Controls.Add(Me.DataItemsGroup, 0, 5)
        Me.InsertTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InsertTableLayout.Location = New System.Drawing.Point(3, 3)
        Me.InsertTableLayout.Name = "InsertTableLayout"
        Me.InsertTableLayout.RowCount = 11
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.4775!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.45225!))
        Me.InsertTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InsertTableLayout.Size = New System.Drawing.Size(450, 680)
        Me.InsertTableLayout.TabIndex = 44
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.InsertTable)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(444, 51)
        Me.Panel6.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(176, 5)
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
        Me.InsertTable.Size = New System.Drawing.Size(418, 23)
        Me.InsertTable.TabIndex = 37
        Me.InsertTable.UseSystemPasswordChar = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Insert_Button)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 564)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(444, 51)
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
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label13)
        Me.Panel10.Controls.Add(Me.Specify_CheckBox)
        Me.Panel10.Controls.Add(Me.Columns)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 60)
        Me.Panel10.Name = "Panel10"
        Me.InsertTableLayout.SetRowSpan(Me.Panel10, 4)
        Me.Panel10.Size = New System.Drawing.Size(444, 270)
        Me.Panel10.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(7, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 15)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Specify Columns"
        '
        'Specify_CheckBox
        '
        Me.Specify_CheckBox.AutoSize = True
        Me.Specify_CheckBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Specify_CheckBox.Location = New System.Drawing.Point(10, 40)
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
        Me.Columns.Location = New System.Drawing.Point(9, 76)
        Me.Columns.Multiline = True
        Me.Columns.Name = "Columns"
        Me.Columns.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Columns.Size = New System.Drawing.Size(425, 188)
        Me.Columns.TabIndex = 54
        Me.Columns.WordWrap = False
        '
        'DataItemsGroup
        '
        Me.DataItemsGroup.Controls.Add(Me.Label14)
        Me.DataItemsGroup.Controls.Add(Me.DataItems)
        Me.DataItemsGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataItemsGroup.Location = New System.Drawing.Point(3, 336)
        Me.DataItemsGroup.Name = "DataItemsGroup"
        Me.InsertTableLayout.SetRowSpan(Me.DataItemsGroup, 4)
        Me.DataItemsGroup.Size = New System.Drawing.Size(444, 222)
        Me.DataItemsGroup.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(7, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 15)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Data Items"
        '
        'DataItems
        '
        Me.DataItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataItems.Location = New System.Drawing.Point(10, 22)
        Me.DataItems.Multiline = True
        Me.DataItems.Name = "DataItems"
        Me.DataItems.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DataItems.Size = New System.Drawing.Size(425, 197)
        Me.DataItems.TabIndex = 54
        Me.DataItems.WordWrap = False
        '
        'DeleteTablePage
        '
        Me.DeleteTablePage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeleteTablePage.Controls.Add(Me.DropTableLayout)
        Me.DeleteTablePage.Location = New System.Drawing.Point(4, 22)
        Me.DeleteTablePage.Name = "DeleteTablePage"
        Me.DeleteTablePage.Padding = New System.Windows.Forms.Padding(3)
        Me.DeleteTablePage.Size = New System.Drawing.Size(456, 686)
        Me.DeleteTablePage.TabIndex = 5
        Me.DeleteTablePage.Text = "Delete Table"
        '
        'DropTableLayout
        '
        Me.DropTableLayout.ColumnCount = 1
        Me.DropTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DropTableLayout.Controls.Add(Me.Panel5, 0, 0)
        Me.DropTableLayout.Controls.Add(Me.Panel8, 0, 1)
        Me.DropTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropTableLayout.Location = New System.Drawing.Point(3, 3)
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
        Me.DropTableLayout.Size = New System.Drawing.Size(450, 680)
        Me.DropTableLayout.TabIndex = 47
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.TableName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(444, 50)
        Me.Panel5.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(176, 5)
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
        Me.TableName.Size = New System.Drawing.Size(418, 23)
        Me.TableName.TabIndex = 37
        Me.TableName.UseSystemPasswordChar = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.DropButton)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 59)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(444, 50)
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
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.Home_Main_Layout.SetColumnSpan(Me.TableLayoutPanel4, 6)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ScriptGrp, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ToolStrip1, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(467, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.Home_Main_Layout.SetRowSpan(Me.TableLayoutPanel4, 10)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(694, 706)
        Me.TableLayoutPanel4.TabIndex = 7
        '
        'ScriptGrp
        '
        Me.ScriptGrp.Controls.Add(Me.Sequence)
        Me.ScriptGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScriptGrp.Location = New System.Drawing.Point(0, 0)
        Me.ScriptGrp.Margin = New System.Windows.Forms.Padding(0)
        Me.ScriptGrp.Name = "ScriptGrp"
        Me.ScriptGrp.Size = New System.Drawing.Size(694, 676)
        Me.ScriptGrp.TabIndex = 7
        Me.ScriptGrp.TabStop = False
        Me.ScriptGrp.Text = "Script"
        '
        'Sequence
        '
        Me.Sequence.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Sequence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sequence.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sequence.FormattingEnabled = True
        Me.Sequence.HorizontalScrollbar = True
        Me.Sequence.Location = New System.Drawing.Point(3, 16)
        Me.Sequence.Name = "Sequence"
        Me.Sequence.ScrollAlwaysVisible = True
        Me.Sequence.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.Sequence.Size = New System.Drawing.Size(688, 657)
        Me.Sequence.TabIndex = 0
        Me.Tip.SetToolTip(Me.Sequence, "Clear Script")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 676)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(694, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel1.Text = "0 Lines"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripLabel2.Text = "Sequence.Font.Size"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripLabel2.ToolTipText = "Click to reset font size."
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(181, 25)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(906, 39)
        Me.MaterialTabSelector1.TabIndex = 2
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1164, 765)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.Home_Main_Layout)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Home"
        Me.Text = "SQL Script Generator"
        Me.Home_Main_Layout.ResumeLayout(False)
        Me.TabContainerPanel.ResumeLayout(False)
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.HomePage.ResumeLayout(False)
        Me.Home_MngScriptGrp.ResumeLayout(False)
        Me.Home_MngScriptGrp.PerformLayout()
        Me.Home_MngScriptTableLayout.ResumeLayout(False)
        CType(Me.Home_ScriptNewBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptBrkBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptUndoBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptIncTxtBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptDecTxtBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptExprtBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Home_InfoTableLayout.ResumeLayout(False)
        CType(Me.Home_InfoBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatabasePage.ResumeLayout(False)
        Me.DatabaseTableLayout.ResumeLayout(False)
        Me.Database_NameGrp.ResumeLayout(False)
        Me.Database_NameGrp.PerformLayout()
        Me.Database_ButtonTableLayout.ResumeLayout(False)
        Me.Database_ButtonTableLayout.PerformLayout()
        Me.CreateTablePage.ResumeLayout(False)
        Me.CreateActionLayout.ResumeLayout(False)
        Me.CreateTable_NameGrp.ResumeLayout(False)
        Me.CreateTable_NameGrp.PerformLayout()
        Me.FieldDetails.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.FieldGroup.ResumeLayout(False)
        Me.FieldGroup.PerformLayout()
        CType(Me.FieldDetails_Precision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldDetails_Size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldDetails_Scale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FieldDetails_ForeignKeyGrp.ResumeLayout(False)
        Me.FieldDetails_ForeignKeyGrp.PerformLayout()
        Me.FieldDetails_PrimyGrp.ResumeLayout(False)
        Me.FieldDetails_PrimyGrp.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FieldDetails_CheckGrp.ResumeLayout(False)
        Me.FieldDetails_CheckGrp.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FieldDetails_ReferenceGrp.ResumeLayout(False)
        Me.FieldDetails_ReferenceGrp.PerformLayout()
        Me.FieldDetails_ConstraintGrp.ResumeLayout(False)
        Me.FieldDetails_ConstraintGrp.PerformLayout()
        Me.CreateTable_BtbTableLayout.ResumeLayout(False)
        Me.CreateTable_BtbTableLayout.PerformLayout()
        Me.AlterTablePage.ResumeLayout(False)
        Me.AlterTableLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.RenameGroup.ResumeLayout(False)
        Me.RenameGroup.PerformLayout()
        Me.DropGroup.ResumeLayout(False)
        Me.DropGroup.PerformLayout()
        Me.AlterButtonsTableLayout.ResumeLayout(False)
        Me.AlterButtonsTableLayout.PerformLayout()
        Me.InsertPage.ResumeLayout(False)
        Me.InsertTableLayout.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.DataItemsGroup.ResumeLayout(False)
        Me.DataItemsGroup.PerformLayout()
        Me.DeleteTablePage.ResumeLayout(False)
        Me.DropTableLayout.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ScriptGrp.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Home_Main_Layout As TableLayoutPanel
    Friend WithEvents Tip As ToolTip
    Friend WithEvents Home_MngScriptTableLayout As TableLayoutPanel
    Friend WithEvents Home_ScriptBrkBtn As PictureBox
    Friend WithEvents Home_ScriptUndoBtn As PictureBox
    Friend WithEvents Home_ScriptIncTxtBtn As PictureBox
    Friend WithEvents Home_ScriptDecTxtBtn As PictureBox
    Friend WithEvents Home_ScriptExprtBtn As PictureBox
    Friend WithEvents CreateActionLayout As TableLayoutPanel
    Friend WithEvents CreateTable_NameGrp As Panel
    Friend WithEvents CreateTable_NameLbl As Label
    Friend WithEvents CreateTable_CreateBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents CreateTable_NameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FieldDetails As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents FieldDetails_FormulaChkbx As CheckBox
    Friend WithEvents FieldDetails_DefFld As TextBox
    Friend WithEvents FieldDetails_DefValChkbx As CheckBox
    Friend WithEvents FieldDetails_Precision As NumericUpDown
    Friend WithEvents FieldDetails_SizeLbl As Label
    Friend WithEvents FieldDetails_Size As NumericUpDown
    Friend WithEvents FieldDetails_Scale As NumericUpDown
    Friend WithEvents FieldDetails_TypeLbl As Label
    Friend WithEvents FieldDetails_PreScleLbl As Label
    Friend WithEvents FieldDetails_ColumnTYpeCmbo As ComboBox
    Friend WithEvents FieldDetails_ColumnNameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FieldDetails_ColumnNameLbl As Label
    Friend WithEvents FieldDetails_PrimFld As TextBox
    Friend WithEvents FieldDetails_ForeignKeyFld As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FieldDetails_ForeignChkbx As CheckBox
    Friend WithEvents FieldDetails_UniqueChkbx As CheckBox
    Friend WithEvents FieldDetails_NotNullChkbx As CheckBox
    Friend WithEvents FieldDetails_PrimChkbx As CheckBox
    Friend WithEvents FieldDetails_OnDeleteCmbo As ComboBox
    Friend WithEvents FieldDetails_OnUpdateCmbo As ComboBox
    Friend WithEvents FieldDetails_OnDeleteChkbx As CheckBox
    Friend WithEvents FieldDetails_OnUpdateChkBx As CheckBox
    Friend WithEvents FieldDetails_ReferenceChkBx As CheckBox
    Friend WithEvents FieldDetails_ReferenceFld As TextBox
    Friend WithEvents FieldDetails_CreateFieldBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FieldDetails_CheckChkbx As CheckBox
    Friend WithEvents FieldDetails_CheckTypeCmbo As ComboBox
    Friend WithEvents FieldDetails_CheckTypeLbl As Label
    Friend WithEvents FieldDetails_CheckFld As TextBox
    Friend WithEvents FieldDetails_CheckPstnCmbo As ComboBox
    Friend WithEvents FieldDetails_StringPstnLbl As Label
    Friend WithEvents CreateTable_BtbTableLayout As TableLayoutPanel
    Friend WithEvents CreateTable_AddForeignKeyBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents CreateTable_AddPrimKeyBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents CreateTable_CompleteTableBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents CreateTable_AddColumnBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Alter_Table_Name As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DropGroup As Panel
    Friend WithEvents Alter_Drop_Table As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DropColumn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Rename As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents NewTableName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents AlterButtonsTableLayout As TableLayoutPanel
    Friend WithEvents AlterModify As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterRename As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterDrop As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterAdd As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DropTableLayout As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TableName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DropButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DatabaseTableLayout As TableLayoutPanel
    Friend WithEvents Database_NameGrp As Panel
    Friend WithEvents Database_NameLbl As Label
    Friend WithEvents Database_NameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Database_ButtonTableLayout As TableLayoutPanel
    Friend WithEvents Database_SelectBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Database_CreateBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Database_DeleteBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents InsertTableLayout As TableLayoutPanel
    Friend WithEvents DataItems As TextBox
    Friend WithEvents Specify_CheckBox As CheckBox
    Friend WithEvents Columns As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents InsertTable As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Insert_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ScriptGrp As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents HomePage As TabPage
    Friend WithEvents DatabasePage As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents CreateTablePage As TabPage
    Friend WithEvents AlterTablePage As TabPage
    Friend WithEvents InsertPage As TabPage
    Friend WithEvents DeleteTablePage As TabPage
    Friend WithEvents TabContainerPanel As Panel
    Friend WithEvents Home_InfoTableLayout As TableLayoutPanel
    Friend WithEvents Home_InfoBtn As PictureBox
    Friend WithEvents Home_ScriptNewBtn As PictureBox
    Friend WithEvents Home_MngScriptLlb As Label
    Friend WithEvents Home_MngScriptGrp As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents DataItemsGroup As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents RenameGroup As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents FieldGroup As Panel
    Friend WithEvents FieldDetails_ForeignKeyGrp As Panel
    Friend WithEvents FieldDetails_ColumnLbl As Label
    Friend WithEvents FieldDetails_PrimyGrp As Panel
    Friend WithEvents FieldDetails_ForeignKeyLbl As Label
    Friend WithEvents FieldDetails_PrimLbl As Label
    Friend WithEvents FieldDetails_ReferenceGrp As Panel
    Friend WithEvents FieldDetails_ReferentialLbl As Label
    Friend WithEvents FieldDetails_ConstraintGrp As Panel
    Friend WithEvents FieldDetails_ConstraintsLbl As Label
    Friend WithEvents FieldDetails_CheckGrp As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Sequence As ListBox
End Class
