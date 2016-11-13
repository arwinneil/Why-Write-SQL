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
        Me.MaterialTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.HomePage = New System.Windows.Forms.TabPage()
        Me.Home_MngScriptGrp = New System.Windows.Forms.Panel()
        Me.Home_MngScriptLlb = New System.Windows.Forms.Label()
        Me.Home_MngScriptTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Home_ScriptCopyBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptNewBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptBrkBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptUndoBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptIncTxtBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptDecTxtBtn = New System.Windows.Forms.PictureBox()
        Me.Home_ScriptExprtBtn = New System.Windows.Forms.PictureBox()
        Me.Home_InfoTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Home_FeedbackBtn = New System.Windows.Forms.PictureBox()
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
        Me.CreateTable_ActionDetailContainerPnl = New System.Windows.Forms.Panel()
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
        Me.CreateTable_ActionDetailContainerPnl2 = New System.Windows.Forms.Panel()
        Me.FieldDetails_CheckGrp = New System.Windows.Forms.Panel()
        Me.FieldDetails_CheckLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_CheckChkbx = New System.Windows.Forms.CheckBox()
        Me.FieldDetails_CheckTypeLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_CheckTypeCmbo = New System.Windows.Forms.ComboBox()
        Me.FieldDetails_StringPstnLbl = New System.Windows.Forms.Label()
        Me.FieldDetails_CheckPstnCmbo = New System.Windows.Forms.ComboBox()
        Me.FieldDetails_CheckFld = New System.Windows.Forms.TextBox()
        Me.FieldDetails_RefConsTableLayout = New System.Windows.Forms.TableLayoutPanel()
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
        Me.CreateTable_AddColumnBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CreateTable_AddForeignKeyBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterTablePage = New System.Windows.Forms.TabPage()
        Me.AlterTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AlterTable_TableNamePnl = New System.Windows.Forms.Panel()
        Me.AlterTable_TableNamaLbl = New System.Windows.Forms.Label()
        Me.AlterTable_TableNameFld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.AlterTable_ActionContainerPnl = New System.Windows.Forms.Panel()
        Me.AlterTable_RenamePnl = New System.Windows.Forms.Panel()
        Me.AlterTable_RenameLbl = New System.Windows.Forms.Label()
        Me.AlterTable_RenameConfirmBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterTable_RenameFld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.AlterTable_DeleteColumnPnl = New System.Windows.Forms.Panel()
        Me.AlterTable_DeleteColumnLbl = New System.Windows.Forms.Label()
        Me.AlterTable_DeleteColumnFld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.AlterTable_DeleteColumnConfirmBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterTable_BtnTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.AlterTable_ModifyColumnBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterTable_RenameBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterTable_DeleteColumnBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AlterTable_AddColumnBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.InsertPage = New System.Windows.Forms.TabPage()
        Me.InsertTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Insert_TableNamePnl = New System.Windows.Forms.Panel()
        Me.Insert_TableNameLbl = New System.Windows.Forms.Label()
        Me.Insert_TableNameFld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Insert_ConfirmPnl = New System.Windows.Forms.Panel()
        Me.Insert_DataItemsConfirmBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Insert_SpecifyColumnPnl = New System.Windows.Forms.Panel()
        Me.Insert_SpecifyColumnLbl = New System.Windows.Forms.Label()
        Me.Insert_SpecifyColumnChkbx = New System.Windows.Forms.CheckBox()
        Me.Insert_SpecifyColumnFld = New System.Windows.Forms.TextBox()
        Me.Insert_DataItemsPnl = New System.Windows.Forms.Panel()
        Me.Insert_DataItemsLbl = New System.Windows.Forms.Label()
        Me.Insert_DataItemsFld = New System.Windows.Forms.TextBox()
        Me.DeleteTablePage = New System.Windows.Forms.TabPage()
        Me.DropTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Delete_TableNamePnl = New System.Windows.Forms.Panel()
        Me.Delete_TableNamePnlLbl = New System.Windows.Forms.Label()
        Me.Delete_TableNameFld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Delete_ConfirmPnl = New System.Windows.Forms.Panel()
        Me.Delete_ConfirmBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ScriptGrp = New System.Windows.Forms.GroupBox()
        Me.Sequence = New System.Windows.Forms.ListBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip_Line = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip_FontSize = New System.Windows.Forms.ToolStripLabel()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.MaterialTabSelector = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Insert_Help = New System.Windows.Forms.PictureBox()
        Me.FieldDetails_CheckHelp = New System.Windows.Forms.PictureBox()
        Me.Home_Main_Layout.SuspendLayout()
        Me.TabContainerPanel.SuspendLayout()
        Me.MaterialTabControl.SuspendLayout()
        Me.HomePage.SuspendLayout()
        Me.Home_MngScriptGrp.SuspendLayout()
        Me.Home_MngScriptTableLayout.SuspendLayout()
        CType(Me.Home_ScriptCopyBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptNewBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptBrkBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptUndoBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptIncTxtBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptDecTxtBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_ScriptExprtBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Home_InfoTableLayout.SuspendLayout()
        CType(Me.Home_FeedbackBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home_InfoBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatabasePage.SuspendLayout()
        Me.DatabaseTableLayout.SuspendLayout()
        Me.Database_NameGrp.SuspendLayout()
        Me.Database_ButtonTableLayout.SuspendLayout()
        Me.CreateTablePage.SuspendLayout()
        Me.CreateActionLayout.SuspendLayout()
        Me.CreateTable_NameGrp.SuspendLayout()
        Me.FieldDetails.SuspendLayout()
        Me.CreateTable_ActionDetailContainerPnl.SuspendLayout()
        Me.FieldGroup.SuspendLayout()
        CType(Me.FieldDetails_Precision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldDetails_Size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldDetails_Scale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FieldDetails_ForeignKeyGrp.SuspendLayout()
        Me.FieldDetails_PrimyGrp.SuspendLayout()
        Me.CreateTable_ActionDetailContainerPnl2.SuspendLayout()
        Me.FieldDetails_CheckGrp.SuspendLayout()
        Me.FieldDetails_RefConsTableLayout.SuspendLayout()
        Me.FieldDetails_ReferenceGrp.SuspendLayout()
        Me.FieldDetails_ConstraintGrp.SuspendLayout()
        Me.CreateTable_BtbTableLayout.SuspendLayout()
        Me.AlterTablePage.SuspendLayout()
        Me.AlterTableLayoutPanel.SuspendLayout()
        Me.AlterTable_TableNamePnl.SuspendLayout()
        Me.AlterTable_ActionContainerPnl.SuspendLayout()
        Me.AlterTable_RenamePnl.SuspendLayout()
        Me.AlterTable_DeleteColumnPnl.SuspendLayout()
        Me.AlterTable_BtnTableLayout.SuspendLayout()
        Me.InsertPage.SuspendLayout()
        Me.InsertTableLayout.SuspendLayout()
        Me.Insert_TableNamePnl.SuspendLayout()
        Me.Insert_ConfirmPnl.SuspendLayout()
        Me.Insert_SpecifyColumnPnl.SuspendLayout()
        Me.Insert_DataItemsPnl.SuspendLayout()
        Me.DeleteTablePage.SuspendLayout()
        Me.DropTableLayout.SuspendLayout()
        Me.Delete_TableNamePnl.SuspendLayout()
        Me.Delete_ConfirmPnl.SuspendLayout()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.ScriptGrp.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.Insert_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldDetails_CheckHelp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Home_Main_Layout.Controls.Add(Me.MainTableLayoutPanel, 4, 0)
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
        Me.TabContainerPanel.Controls.Add(Me.MaterialTabControl)
        Me.TabContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabContainerPanel.Location = New System.Drawing.Point(0, 0)
        Me.TabContainerPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TabContainerPanel.Name = "TabContainerPanel"
        Me.Home_Main_Layout.SetRowSpan(Me.TabContainerPanel, 10)
        Me.TabContainerPanel.Size = New System.Drawing.Size(464, 712)
        Me.TabContainerPanel.TabIndex = 0
        '
        'MaterialTabControl
        '
        Me.MaterialTabControl.Controls.Add(Me.HomePage)
        Me.MaterialTabControl.Controls.Add(Me.DatabasePage)
        Me.MaterialTabControl.Controls.Add(Me.CreateTablePage)
        Me.MaterialTabControl.Controls.Add(Me.AlterTablePage)
        Me.MaterialTabControl.Controls.Add(Me.InsertPage)
        Me.MaterialTabControl.Controls.Add(Me.DeleteTablePage)
        Me.MaterialTabControl.Depth = 0
        Me.MaterialTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl.Name = "MaterialTabControl"
        Me.MaterialTabControl.SelectedIndex = 0
        Me.MaterialTabControl.Size = New System.Drawing.Size(464, 712)
        Me.MaterialTabControl.TabIndex = 2
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
        Me.Home_MngScriptTableLayout.Controls.Add(Me.Home_ScriptCopyBtn, 0, 1)
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
        'Home_ScriptCopyBtn
        '
        Me.Home_ScriptCopyBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_ScriptCopyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_ScriptCopyBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_ScriptCopyBtn.Image = CType(resources.GetObject("Home_ScriptCopyBtn.Image"), System.Drawing.Image)
        Me.Home_ScriptCopyBtn.Location = New System.Drawing.Point(3, 64)
        Me.Home_ScriptCopyBtn.Name = "Home_ScriptCopyBtn"
        Me.Home_ScriptCopyBtn.Size = New System.Drawing.Size(84, 58)
        Me.Home_ScriptCopyBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_ScriptCopyBtn.TabIndex = 17
        Me.Home_ScriptCopyBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_ScriptCopyBtn, "Copy To Clipboard")
        '
        'Home_ScriptNewBtn
        '
        Me.Home_ScriptNewBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_ScriptNewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_ScriptNewBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_ScriptNewBtn.Image = CType(resources.GetObject("Home_ScriptNewBtn.Image"), System.Drawing.Image)
        Me.Home_ScriptNewBtn.Location = New System.Drawing.Point(93, 64)
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
        Me.Home_InfoTableLayout.Controls.Add(Me.Home_FeedbackBtn, 3, 0)
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
        'Home_FeedbackBtn
        '
        Me.Home_FeedbackBtn.BackColor = System.Drawing.Color.Transparent
        Me.Home_FeedbackBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_FeedbackBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home_FeedbackBtn.Image = CType(resources.GetObject("Home_FeedbackBtn.Image"), System.Drawing.Image)
        Me.Home_FeedbackBtn.Location = New System.Drawing.Point(273, 3)
        Me.Home_FeedbackBtn.Name = "Home_FeedbackBtn"
        Me.Home_FeedbackBtn.Padding = New System.Windows.Forms.Padding(10)
        Me.Home_FeedbackBtn.Size = New System.Drawing.Size(84, 58)
        Me.Home_FeedbackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Home_FeedbackBtn.TabIndex = 12
        Me.Home_FeedbackBtn.TabStop = False
        Me.Tip.SetToolTip(Me.Home_FeedbackBtn, "Leave Feedback")
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
        Me.CreateTable_NameFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.FieldDetails.Controls.Add(Me.CreateTable_ActionDetailContainerPnl)
        Me.FieldDetails.Controls.Add(Me.CreateTable_ActionDetailContainerPnl2)
        Me.FieldDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldDetails.Location = New System.Drawing.Point(3, 125)
        Me.FieldDetails.Name = "FieldDetails"
        Me.CreateActionLayout.SetRowSpan(Me.FieldDetails, 9)
        Me.FieldDetails.Size = New System.Drawing.Size(444, 552)
        Me.FieldDetails.TabIndex = 0
        '
        'CreateTable_ActionDetailContainerPnl
        '
        Me.CreateTable_ActionDetailContainerPnl.Controls.Add(Me.FieldGroup)
        Me.CreateTable_ActionDetailContainerPnl.Controls.Add(Me.FieldDetails_ForeignKeyGrp)
        Me.CreateTable_ActionDetailContainerPnl.Controls.Add(Me.FieldDetails_PrimyGrp)
        Me.CreateTable_ActionDetailContainerPnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.CreateTable_ActionDetailContainerPnl.Location = New System.Drawing.Point(0, 0)
        Me.CreateTable_ActionDetailContainerPnl.Name = "CreateTable_ActionDetailContainerPnl"
        Me.CreateTable_ActionDetailContainerPnl.Size = New System.Drawing.Size(444, 160)
        Me.CreateTable_ActionDetailContainerPnl.TabIndex = 13
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
        Me.FieldGroup.Enabled = False
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
        Me.Tip.SetToolTip(Me.FieldDetails_ForeignKeyFld, "Enter 1 Item Per Line")
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
        Me.Tip.SetToolTip(Me.FieldDetails_PrimyGrp, "Enter 1 Item Per Line")
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
        'CreateTable_ActionDetailContainerPnl2
        '
        Me.CreateTable_ActionDetailContainerPnl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateTable_ActionDetailContainerPnl2.Controls.Add(Me.FieldDetails_CheckGrp)
        Me.CreateTable_ActionDetailContainerPnl2.Controls.Add(Me.FieldDetails_RefConsTableLayout)
        Me.CreateTable_ActionDetailContainerPnl2.Controls.Add(Me.FieldDetails_CreateFieldBtn)
        Me.CreateTable_ActionDetailContainerPnl2.Location = New System.Drawing.Point(0, 163)
        Me.CreateTable_ActionDetailContainerPnl2.Margin = New System.Windows.Forms.Padding(0)
        Me.CreateTable_ActionDetailContainerPnl2.Name = "CreateTable_ActionDetailContainerPnl2"
        Me.CreateTable_ActionDetailContainerPnl2.Size = New System.Drawing.Size(444, 335)
        Me.CreateTable_ActionDetailContainerPnl2.TabIndex = 12
        '
        'FieldDetails_CheckGrp
        '
        Me.FieldDetails_CheckGrp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckHelp)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckLbl)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckChkbx)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckTypeLbl)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckTypeCmbo)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_StringPstnLbl)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckPstnCmbo)
        Me.FieldDetails_CheckGrp.Controls.Add(Me.FieldDetails_CheckFld)
        Me.FieldDetails_CheckGrp.Location = New System.Drawing.Point(0, 110)
        Me.FieldDetails_CheckGrp.Margin = New System.Windows.Forms.Padding(0)
        Me.FieldDetails_CheckGrp.Name = "FieldDetails_CheckGrp"
        Me.FieldDetails_CheckGrp.Size = New System.Drawing.Size(441, 174)
        Me.FieldDetails_CheckGrp.TabIndex = 74
        '
        'FieldDetails_CheckLbl
        '
        Me.FieldDetails_CheckLbl.AutoSize = True
        Me.FieldDetails_CheckLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FieldDetails_CheckLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FieldDetails_CheckLbl.Location = New System.Drawing.Point(6, 3)
        Me.FieldDetails_CheckLbl.Name = "FieldDetails_CheckLbl"
        Me.FieldDetails_CheckLbl.Size = New System.Drawing.Size(46, 15)
        Me.FieldDetails_CheckLbl.TabIndex = 70
        Me.FieldDetails_CheckLbl.Text = "Check"
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
        Me.FieldDetails_CheckTypeLbl.Location = New System.Drawing.Point(67, 16)
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
        Me.FieldDetails_CheckTypeCmbo.Location = New System.Drawing.Point(67, 35)
        Me.FieldDetails_CheckTypeCmbo.Name = "FieldDetails_CheckTypeCmbo"
        Me.FieldDetails_CheckTypeCmbo.Size = New System.Drawing.Size(156, 21)
        Me.FieldDetails_CheckTypeCmbo.TabIndex = 55
        '
        'FieldDetails_StringPstnLbl
        '
        Me.FieldDetails_StringPstnLbl.AutoSize = True
        Me.FieldDetails_StringPstnLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FieldDetails_StringPstnLbl.Location = New System.Drawing.Point(236, 16)
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
        Me.FieldDetails_CheckPstnCmbo.Location = New System.Drawing.Point(239, 35)
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
        Me.Tip.SetToolTip(Me.FieldDetails_CheckFld, "Enter 1 Item Per Line")
        Me.FieldDetails_CheckFld.WordWrap = False
        '
        'FieldDetails_RefConsTableLayout
        '
        Me.FieldDetails_RefConsTableLayout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldDetails_RefConsTableLayout.ColumnCount = 2
        Me.FieldDetails_RefConsTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.FieldDetails_RefConsTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.FieldDetails_RefConsTableLayout.Controls.Add(Me.FieldDetails_ReferenceGrp, 0, 0)
        Me.FieldDetails_RefConsTableLayout.Controls.Add(Me.FieldDetails_ConstraintGrp, 1, 0)
        Me.FieldDetails_RefConsTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.FieldDetails_RefConsTableLayout.Name = "FieldDetails_RefConsTableLayout"
        Me.FieldDetails_RefConsTableLayout.RowCount = 1
        Me.FieldDetails_RefConsTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FieldDetails_RefConsTableLayout.Size = New System.Drawing.Size(447, 110)
        Me.FieldDetails_RefConsTableLayout.TabIndex = 73
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
        Me.CreateTable_BtbTableLayout.Controls.Add(Me.CreateTable_AddColumnBtn, 0, 0)
        Me.CreateTable_BtbTableLayout.Controls.Add(Me.CreateTable_AddForeignKeyBtn, 2, 0)
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
        Me.CreateTable_AddPrimKeyBtn.Text = "Add Primary Key"
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
        Me.CreateTable_CompleteTableBtn.Text = "complete Statement"
        Me.CreateTable_CompleteTableBtn.UseVisualStyleBackColor = True
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
        Me.AlterTableLayoutPanel.Controls.Add(Me.AlterTable_TableNamePnl, 0, 0)
        Me.AlterTableLayoutPanel.Controls.Add(Me.AlterTable_ActionContainerPnl, 0, 2)
        Me.AlterTableLayoutPanel.Controls.Add(Me.AlterTable_BtnTableLayout, 0, 1)
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
        'AlterTable_TableNamePnl
        '
        Me.AlterTable_TableNamePnl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterTable_TableNamePnl.Controls.Add(Me.AlterTable_TableNamaLbl)
        Me.AlterTable_TableNamePnl.Controls.Add(Me.AlterTable_TableNameFld)
        Me.AlterTable_TableNamePnl.Location = New System.Drawing.Point(3, 6)
        Me.AlterTable_TableNamePnl.Name = "AlterTable_TableNamePnl"
        Me.AlterTable_TableNamePnl.Size = New System.Drawing.Size(444, 49)
        Me.AlterTable_TableNamePnl.TabIndex = 1
        '
        'AlterTable_TableNamaLbl
        '
        Me.AlterTable_TableNamaLbl.AutoSize = True
        Me.AlterTable_TableNamaLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AlterTable_TableNamaLbl.Location = New System.Drawing.Point(176, 2)
        Me.AlterTable_TableNamaLbl.Name = "AlterTable_TableNamaLbl"
        Me.AlterTable_TableNamaLbl.Size = New System.Drawing.Size(93, 13)
        Me.AlterTable_TableNamaLbl.TabIndex = 41
        Me.AlterTable_TableNamaLbl.Text = "Enter Table Name"
        '
        'AlterTable_TableNameFld
        '
        Me.AlterTable_TableNameFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterTable_TableNameFld.Depth = 0
        Me.AlterTable_TableNameFld.Hint = ""
        Me.AlterTable_TableNameFld.Location = New System.Drawing.Point(9, 19)
        Me.AlterTable_TableNameFld.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_TableNameFld.Name = "AlterTable_TableNameFld"
        Me.AlterTable_TableNameFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AlterTable_TableNameFld.SelectedText = ""
        Me.AlterTable_TableNameFld.SelectionLength = 0
        Me.AlterTable_TableNameFld.SelectionStart = 0
        Me.AlterTable_TableNameFld.Size = New System.Drawing.Size(418, 23)
        Me.AlterTable_TableNameFld.TabIndex = 37
        Me.AlterTable_TableNameFld.UseSystemPasswordChar = False
        '
        'AlterTable_ActionContainerPnl
        '
        Me.AlterTable_ActionContainerPnl.Controls.Add(Me.AlterTable_RenamePnl)
        Me.AlterTable_ActionContainerPnl.Controls.Add(Me.AlterTable_DeleteColumnPnl)
        Me.AlterTable_ActionContainerPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterTable_ActionContainerPnl.Location = New System.Drawing.Point(0, 122)
        Me.AlterTable_ActionContainerPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.AlterTable_ActionContainerPnl.Name = "AlterTable_ActionContainerPnl"
        Me.AlterTable_ActionContainerPnl.Size = New System.Drawing.Size(450, 61)
        Me.AlterTable_ActionContainerPnl.TabIndex = 40
        '
        'AlterTable_RenamePnl
        '
        Me.AlterTable_RenamePnl.Controls.Add(Me.AlterTable_RenameLbl)
        Me.AlterTable_RenamePnl.Controls.Add(Me.AlterTable_RenameConfirmBtn)
        Me.AlterTable_RenamePnl.Controls.Add(Me.AlterTable_RenameFld)
        Me.AlterTable_RenamePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterTable_RenamePnl.Location = New System.Drawing.Point(0, 0)
        Me.AlterTable_RenamePnl.Name = "AlterTable_RenamePnl"
        Me.AlterTable_RenamePnl.Size = New System.Drawing.Size(450, 61)
        Me.AlterTable_RenamePnl.TabIndex = 6
        Me.AlterTable_RenamePnl.Visible = False
        '
        'AlterTable_RenameLbl
        '
        Me.AlterTable_RenameLbl.AutoSize = True
        Me.AlterTable_RenameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlterTable_RenameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AlterTable_RenameLbl.Location = New System.Drawing.Point(13, 8)
        Me.AlterTable_RenameLbl.Name = "AlterTable_RenameLbl"
        Me.AlterTable_RenameLbl.Size = New System.Drawing.Size(101, 15)
        Me.AlterTable_RenameLbl.TabIndex = 57
        Me.AlterTable_RenameLbl.Text = "Rename Table"
        '
        'AlterTable_RenameConfirmBtn
        '
        Me.AlterTable_RenameConfirmBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AlterTable_RenameConfirmBtn.AutoSize = True
        Me.AlterTable_RenameConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterTable_RenameConfirmBtn.BackColor = System.Drawing.Color.White
        Me.AlterTable_RenameConfirmBtn.Depth = 0
        Me.AlterTable_RenameConfirmBtn.ForeColor = System.Drawing.Color.Transparent
        Me.AlterTable_RenameConfirmBtn.Location = New System.Drawing.Point(382, 26)
        Me.AlterTable_RenameConfirmBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterTable_RenameConfirmBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_RenameConfirmBtn.Name = "AlterTable_RenameConfirmBtn"
        Me.AlterTable_RenameConfirmBtn.Primary = False
        Me.AlterTable_RenameConfirmBtn.Size = New System.Drawing.Size(48, 36)
        Me.AlterTable_RenameConfirmBtn.TabIndex = 39
        Me.AlterTable_RenameConfirmBtn.Text = "Done"
        Me.AlterTable_RenameConfirmBtn.UseVisualStyleBackColor = False
        '
        'AlterTable_RenameFld
        '
        Me.AlterTable_RenameFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterTable_RenameFld.Depth = 0
        Me.AlterTable_RenameFld.Hint = ""
        Me.AlterTable_RenameFld.Location = New System.Drawing.Point(7, 33)
        Me.AlterTable_RenameFld.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_RenameFld.Name = "AlterTable_RenameFld"
        Me.AlterTable_RenameFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AlterTable_RenameFld.SelectedText = ""
        Me.AlterTable_RenameFld.SelectionLength = 0
        Me.AlterTable_RenameFld.SelectionStart = 0
        Me.AlterTable_RenameFld.Size = New System.Drawing.Size(364, 23)
        Me.AlterTable_RenameFld.TabIndex = 38
        Me.AlterTable_RenameFld.UseSystemPasswordChar = False
        '
        'AlterTable_DeleteColumnPnl
        '
        Me.AlterTable_DeleteColumnPnl.Controls.Add(Me.AlterTable_DeleteColumnLbl)
        Me.AlterTable_DeleteColumnPnl.Controls.Add(Me.AlterTable_DeleteColumnFld)
        Me.AlterTable_DeleteColumnPnl.Controls.Add(Me.AlterTable_DeleteColumnConfirmBtn)
        Me.AlterTable_DeleteColumnPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterTable_DeleteColumnPnl.Location = New System.Drawing.Point(0, 0)
        Me.AlterTable_DeleteColumnPnl.Name = "AlterTable_DeleteColumnPnl"
        Me.AlterTable_DeleteColumnPnl.Size = New System.Drawing.Size(450, 61)
        Me.AlterTable_DeleteColumnPnl.TabIndex = 5
        Me.AlterTable_DeleteColumnPnl.Visible = False
        '
        'AlterTable_DeleteColumnLbl
        '
        Me.AlterTable_DeleteColumnLbl.AutoSize = True
        Me.AlterTable_DeleteColumnLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlterTable_DeleteColumnLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AlterTable_DeleteColumnLbl.Location = New System.Drawing.Point(12, 8)
        Me.AlterTable_DeleteColumnLbl.Name = "AlterTable_DeleteColumnLbl"
        Me.AlterTable_DeleteColumnLbl.Size = New System.Drawing.Size(102, 15)
        Me.AlterTable_DeleteColumnLbl.TabIndex = 57
        Me.AlterTable_DeleteColumnLbl.Text = "Delete Column"
        '
        'AlterTable_DeleteColumnFld
        '
        Me.AlterTable_DeleteColumnFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterTable_DeleteColumnFld.Depth = 0
        Me.AlterTable_DeleteColumnFld.Hint = ""
        Me.AlterTable_DeleteColumnFld.Location = New System.Drawing.Point(15, 33)
        Me.AlterTable_DeleteColumnFld.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_DeleteColumnFld.Name = "AlterTable_DeleteColumnFld"
        Me.AlterTable_DeleteColumnFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AlterTable_DeleteColumnFld.SelectedText = ""
        Me.AlterTable_DeleteColumnFld.SelectionLength = 0
        Me.AlterTable_DeleteColumnFld.SelectionStart = 0
        Me.AlterTable_DeleteColumnFld.Size = New System.Drawing.Size(364, 23)
        Me.AlterTable_DeleteColumnFld.TabIndex = 38
        Me.AlterTable_DeleteColumnFld.UseSystemPasswordChar = False
        '
        'AlterTable_DeleteColumnConfirmBtn
        '
        Me.AlterTable_DeleteColumnConfirmBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AlterTable_DeleteColumnConfirmBtn.AutoSize = True
        Me.AlterTable_DeleteColumnConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterTable_DeleteColumnConfirmBtn.BackColor = System.Drawing.Color.White
        Me.AlterTable_DeleteColumnConfirmBtn.Depth = 0
        Me.AlterTable_DeleteColumnConfirmBtn.Location = New System.Drawing.Point(395, 23)
        Me.AlterTable_DeleteColumnConfirmBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.AlterTable_DeleteColumnConfirmBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_DeleteColumnConfirmBtn.Name = "AlterTable_DeleteColumnConfirmBtn"
        Me.AlterTable_DeleteColumnConfirmBtn.Primary = False
        Me.AlterTable_DeleteColumnConfirmBtn.Size = New System.Drawing.Size(48, 36)
        Me.AlterTable_DeleteColumnConfirmBtn.TabIndex = 39
        Me.AlterTable_DeleteColumnConfirmBtn.Text = "Done"
        Me.AlterTable_DeleteColumnConfirmBtn.UseVisualStyleBackColor = False
        '
        'AlterTable_BtnTableLayout
        '
        Me.AlterTable_BtnTableLayout.ColumnCount = 4
        Me.AlterTable_BtnTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AlterTable_BtnTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AlterTable_BtnTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AlterTable_BtnTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.AlterTable_BtnTableLayout.Controls.Add(Me.AlterTable_ModifyColumnBtn, 3, 0)
        Me.AlterTable_BtnTableLayout.Controls.Add(Me.AlterTable_RenameBtn, 0, 0)
        Me.AlterTable_BtnTableLayout.Controls.Add(Me.AlterTable_DeleteColumnBtn, 2, 0)
        Me.AlterTable_BtnTableLayout.Controls.Add(Me.AlterTable_AddColumnBtn, 1, 0)
        Me.AlterTable_BtnTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterTable_BtnTableLayout.Location = New System.Drawing.Point(3, 64)
        Me.AlterTable_BtnTableLayout.Name = "AlterTable_BtnTableLayout"
        Me.AlterTable_BtnTableLayout.RowCount = 1
        Me.AlterTable_BtnTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AlterTable_BtnTableLayout.Size = New System.Drawing.Size(444, 55)
        Me.AlterTable_BtnTableLayout.TabIndex = 6
        '
        'AlterTable_ModifyColumnBtn
        '
        Me.AlterTable_ModifyColumnBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterTable_ModifyColumnBtn.AutoSize = True
        Me.AlterTable_ModifyColumnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterTable_ModifyColumnBtn.Depth = 0
        Me.AlterTable_ModifyColumnBtn.Location = New System.Drawing.Point(337, 6)
        Me.AlterTable_ModifyColumnBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterTable_ModifyColumnBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_ModifyColumnBtn.Name = "AlterTable_ModifyColumnBtn"
        Me.AlterTable_ModifyColumnBtn.Primary = False
        Me.AlterTable_ModifyColumnBtn.Size = New System.Drawing.Size(103, 43)
        Me.AlterTable_ModifyColumnBtn.TabIndex = 10
        Me.AlterTable_ModifyColumnBtn.Text = "Modify Column"
        Me.AlterTable_ModifyColumnBtn.UseVisualStyleBackColor = True
        '
        'AlterTable_RenameBtn
        '
        Me.AlterTable_RenameBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterTable_RenameBtn.AutoSize = True
        Me.AlterTable_RenameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterTable_RenameBtn.Depth = 0
        Me.AlterTable_RenameBtn.Location = New System.Drawing.Point(4, 6)
        Me.AlterTable_RenameBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterTable_RenameBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_RenameBtn.Name = "AlterTable_RenameBtn"
        Me.AlterTable_RenameBtn.Primary = False
        Me.AlterTable_RenameBtn.Size = New System.Drawing.Size(103, 43)
        Me.AlterTable_RenameBtn.TabIndex = 7
        Me.AlterTable_RenameBtn.Text = "Rename Table"
        Me.AlterTable_RenameBtn.UseVisualStyleBackColor = True
        '
        'AlterTable_DeleteColumnBtn
        '
        Me.AlterTable_DeleteColumnBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterTable_DeleteColumnBtn.AutoSize = True
        Me.AlterTable_DeleteColumnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterTable_DeleteColumnBtn.Depth = 0
        Me.AlterTable_DeleteColumnBtn.Location = New System.Drawing.Point(226, 6)
        Me.AlterTable_DeleteColumnBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterTable_DeleteColumnBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_DeleteColumnBtn.Name = "AlterTable_DeleteColumnBtn"
        Me.AlterTable_DeleteColumnBtn.Primary = False
        Me.AlterTable_DeleteColumnBtn.Size = New System.Drawing.Size(103, 43)
        Me.AlterTable_DeleteColumnBtn.TabIndex = 9
        Me.AlterTable_DeleteColumnBtn.Text = "Delete Column"
        Me.AlterTable_DeleteColumnBtn.UseVisualStyleBackColor = True
        '
        'AlterTable_AddColumnBtn
        '
        Me.AlterTable_AddColumnBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterTable_AddColumnBtn.AutoSize = True
        Me.AlterTable_AddColumnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlterTable_AddColumnBtn.Depth = 0
        Me.AlterTable_AddColumnBtn.Location = New System.Drawing.Point(115, 6)
        Me.AlterTable_AddColumnBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AlterTable_AddColumnBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.AlterTable_AddColumnBtn.Name = "AlterTable_AddColumnBtn"
        Me.AlterTable_AddColumnBtn.Primary = False
        Me.AlterTable_AddColumnBtn.Size = New System.Drawing.Size(103, 43)
        Me.AlterTable_AddColumnBtn.TabIndex = 8
        Me.AlterTable_AddColumnBtn.Text = "Add Column"
        Me.AlterTable_AddColumnBtn.UseVisualStyleBackColor = True
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
        Me.InsertTableLayout.Controls.Add(Me.Insert_TableNamePnl, 0, 0)
        Me.InsertTableLayout.Controls.Add(Me.Insert_ConfirmPnl, 0, 9)
        Me.InsertTableLayout.Controls.Add(Me.Insert_SpecifyColumnPnl, 0, 1)
        Me.InsertTableLayout.Controls.Add(Me.Insert_DataItemsPnl, 0, 5)
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
        'Insert_TableNamePnl
        '
        Me.Insert_TableNamePnl.Controls.Add(Me.Insert_TableNameLbl)
        Me.Insert_TableNamePnl.Controls.Add(Me.Insert_TableNameFld)
        Me.Insert_TableNamePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Insert_TableNamePnl.Location = New System.Drawing.Point(3, 3)
        Me.Insert_TableNamePnl.Name = "Insert_TableNamePnl"
        Me.Insert_TableNamePnl.Size = New System.Drawing.Size(444, 51)
        Me.Insert_TableNamePnl.TabIndex = 0
        '
        'Insert_TableNameLbl
        '
        Me.Insert_TableNameLbl.AutoSize = True
        Me.Insert_TableNameLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Insert_TableNameLbl.Location = New System.Drawing.Point(176, 5)
        Me.Insert_TableNameLbl.Name = "Insert_TableNameLbl"
        Me.Insert_TableNameLbl.Size = New System.Drawing.Size(93, 13)
        Me.Insert_TableNameLbl.TabIndex = 41
        Me.Insert_TableNameLbl.Text = "Enter Table Name"
        '
        'Insert_TableNameFld
        '
        Me.Insert_TableNameFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Insert_TableNameFld.Depth = 0
        Me.Insert_TableNameFld.Hint = ""
        Me.Insert_TableNameFld.Location = New System.Drawing.Point(10, 21)
        Me.Insert_TableNameFld.MouseState = MaterialSkin.MouseState.HOVER
        Me.Insert_TableNameFld.Name = "Insert_TableNameFld"
        Me.Insert_TableNameFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Insert_TableNameFld.SelectedText = ""
        Me.Insert_TableNameFld.SelectionLength = 0
        Me.Insert_TableNameFld.SelectionStart = 0
        Me.Insert_TableNameFld.Size = New System.Drawing.Size(418, 23)
        Me.Insert_TableNameFld.TabIndex = 37
        Me.Insert_TableNameFld.UseSystemPasswordChar = False
        '
        'Insert_ConfirmPnl
        '
        Me.Insert_ConfirmPnl.Controls.Add(Me.Insert_DataItemsConfirmBtn)
        Me.Insert_ConfirmPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Insert_ConfirmPnl.Location = New System.Drawing.Point(3, 564)
        Me.Insert_ConfirmPnl.Name = "Insert_ConfirmPnl"
        Me.Insert_ConfirmPnl.Size = New System.Drawing.Size(444, 51)
        Me.Insert_ConfirmPnl.TabIndex = 44
        '
        'Insert_DataItemsConfirmBtn
        '
        Me.Insert_DataItemsConfirmBtn.AutoSize = True
        Me.Insert_DataItemsConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Insert_DataItemsConfirmBtn.Depth = 0
        Me.Insert_DataItemsConfirmBtn.Location = New System.Drawing.Point(9, 2)
        Me.Insert_DataItemsConfirmBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Insert_DataItemsConfirmBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Insert_DataItemsConfirmBtn.Name = "Insert_DataItemsConfirmBtn"
        Me.Insert_DataItemsConfirmBtn.Primary = False
        Me.Insert_DataItemsConfirmBtn.Size = New System.Drawing.Size(48, 36)
        Me.Insert_DataItemsConfirmBtn.TabIndex = 39
        Me.Insert_DataItemsConfirmBtn.Text = "Done"
        Me.Insert_DataItemsConfirmBtn.UseVisualStyleBackColor = True
        '
        'Insert_SpecifyColumnPnl
        '
        Me.Insert_SpecifyColumnPnl.Controls.Add(Me.Insert_Help)
        Me.Insert_SpecifyColumnPnl.Controls.Add(Me.Insert_SpecifyColumnLbl)
        Me.Insert_SpecifyColumnPnl.Controls.Add(Me.Insert_SpecifyColumnChkbx)
        Me.Insert_SpecifyColumnPnl.Controls.Add(Me.Insert_SpecifyColumnFld)
        Me.Insert_SpecifyColumnPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Insert_SpecifyColumnPnl.Location = New System.Drawing.Point(3, 60)
        Me.Insert_SpecifyColumnPnl.Name = "Insert_SpecifyColumnPnl"
        Me.InsertTableLayout.SetRowSpan(Me.Insert_SpecifyColumnPnl, 4)
        Me.Insert_SpecifyColumnPnl.Size = New System.Drawing.Size(444, 270)
        Me.Insert_SpecifyColumnPnl.TabIndex = 45
        '
        'Insert_SpecifyColumnLbl
        '
        Me.Insert_SpecifyColumnLbl.AutoSize = True
        Me.Insert_SpecifyColumnLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert_SpecifyColumnLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Insert_SpecifyColumnLbl.Location = New System.Drawing.Point(7, 13)
        Me.Insert_SpecifyColumnLbl.Name = "Insert_SpecifyColumnLbl"
        Me.Insert_SpecifyColumnLbl.Size = New System.Drawing.Size(113, 15)
        Me.Insert_SpecifyColumnLbl.TabIndex = 56
        Me.Insert_SpecifyColumnLbl.Text = "Specify Columns"
        '
        'Insert_SpecifyColumnChkbx
        '
        Me.Insert_SpecifyColumnChkbx.AutoSize = True
        Me.Insert_SpecifyColumnChkbx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Insert_SpecifyColumnChkbx.Location = New System.Drawing.Point(10, 40)
        Me.Insert_SpecifyColumnChkbx.Name = "Insert_SpecifyColumnChkbx"
        Me.Insert_SpecifyColumnChkbx.Size = New System.Drawing.Size(157, 17)
        Me.Insert_SpecifyColumnChkbx.TabIndex = 55
        Me.Insert_SpecifyColumnChkbx.Text = "Insert Into Specific Columns"
        Me.Insert_SpecifyColumnChkbx.UseVisualStyleBackColor = True
        '
        'Insert_SpecifyColumnFld
        '
        Me.Insert_SpecifyColumnFld.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Insert_SpecifyColumnFld.Enabled = False
        Me.Insert_SpecifyColumnFld.Location = New System.Drawing.Point(10, 63)
        Me.Insert_SpecifyColumnFld.Multiline = True
        Me.Insert_SpecifyColumnFld.Name = "Insert_SpecifyColumnFld"
        Me.Insert_SpecifyColumnFld.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Insert_SpecifyColumnFld.Size = New System.Drawing.Size(425, 188)
        Me.Insert_SpecifyColumnFld.TabIndex = 54
        Me.Tip.SetToolTip(Me.Insert_SpecifyColumnFld, "Enter 1 Item Per Line")
        Me.Insert_SpecifyColumnFld.WordWrap = False
        '
        'Insert_DataItemsPnl
        '
        Me.Insert_DataItemsPnl.Controls.Add(Me.Insert_DataItemsLbl)
        Me.Insert_DataItemsPnl.Controls.Add(Me.Insert_DataItemsFld)
        Me.Insert_DataItemsPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Insert_DataItemsPnl.Location = New System.Drawing.Point(3, 336)
        Me.Insert_DataItemsPnl.Name = "Insert_DataItemsPnl"
        Me.InsertTableLayout.SetRowSpan(Me.Insert_DataItemsPnl, 4)
        Me.Insert_DataItemsPnl.Size = New System.Drawing.Size(444, 222)
        Me.Insert_DataItemsPnl.TabIndex = 46
        '
        'Insert_DataItemsLbl
        '
        Me.Insert_DataItemsLbl.AutoSize = True
        Me.Insert_DataItemsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert_DataItemsLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Insert_DataItemsLbl.Location = New System.Drawing.Point(7, 0)
        Me.Insert_DataItemsLbl.Name = "Insert_DataItemsLbl"
        Me.Insert_DataItemsLbl.Size = New System.Drawing.Size(76, 15)
        Me.Insert_DataItemsLbl.TabIndex = 57
        Me.Insert_DataItemsLbl.Text = "Data Items"
        '
        'Insert_DataItemsFld
        '
        Me.Insert_DataItemsFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Insert_DataItemsFld.Location = New System.Drawing.Point(10, 22)
        Me.Insert_DataItemsFld.Multiline = True
        Me.Insert_DataItemsFld.Name = "Insert_DataItemsFld"
        Me.Insert_DataItemsFld.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Insert_DataItemsFld.Size = New System.Drawing.Size(425, 197)
        Me.Insert_DataItemsFld.TabIndex = 54
        Me.Tip.SetToolTip(Me.Insert_DataItemsFld, "Enter 1 Item Per Line")
        Me.Insert_DataItemsFld.WordWrap = False
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
        Me.DropTableLayout.Controls.Add(Me.Delete_TableNamePnl, 0, 0)
        Me.DropTableLayout.Controls.Add(Me.Delete_ConfirmPnl, 0, 1)
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
        'Delete_TableNamePnl
        '
        Me.Delete_TableNamePnl.Controls.Add(Me.Delete_TableNamePnlLbl)
        Me.Delete_TableNamePnl.Controls.Add(Me.Delete_TableNameFld)
        Me.Delete_TableNamePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Delete_TableNamePnl.Location = New System.Drawing.Point(3, 3)
        Me.Delete_TableNamePnl.Name = "Delete_TableNamePnl"
        Me.Delete_TableNamePnl.Size = New System.Drawing.Size(444, 50)
        Me.Delete_TableNamePnl.TabIndex = 0
        '
        'Delete_TableNamePnlLbl
        '
        Me.Delete_TableNamePnlLbl.AutoSize = True
        Me.Delete_TableNamePnlLbl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Delete_TableNamePnlLbl.Location = New System.Drawing.Point(176, 5)
        Me.Delete_TableNamePnlLbl.Name = "Delete_TableNamePnlLbl"
        Me.Delete_TableNamePnlLbl.Size = New System.Drawing.Size(93, 13)
        Me.Delete_TableNamePnlLbl.TabIndex = 41
        Me.Delete_TableNamePnlLbl.Text = "Enter Table Name"
        '
        'Delete_TableNameFld
        '
        Me.Delete_TableNameFld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Delete_TableNameFld.Depth = 0
        Me.Delete_TableNameFld.Hint = ""
        Me.Delete_TableNameFld.Location = New System.Drawing.Point(10, 21)
        Me.Delete_TableNameFld.MouseState = MaterialSkin.MouseState.HOVER
        Me.Delete_TableNameFld.Name = "Delete_TableNameFld"
        Me.Delete_TableNameFld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Delete_TableNameFld.SelectedText = ""
        Me.Delete_TableNameFld.SelectionLength = 0
        Me.Delete_TableNameFld.SelectionStart = 0
        Me.Delete_TableNameFld.Size = New System.Drawing.Size(418, 23)
        Me.Delete_TableNameFld.TabIndex = 37
        Me.Delete_TableNameFld.UseSystemPasswordChar = False
        '
        'Delete_ConfirmPnl
        '
        Me.Delete_ConfirmPnl.Controls.Add(Me.Delete_ConfirmBtn)
        Me.Delete_ConfirmPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Delete_ConfirmPnl.Location = New System.Drawing.Point(3, 59)
        Me.Delete_ConfirmPnl.Name = "Delete_ConfirmPnl"
        Me.Delete_ConfirmPnl.Size = New System.Drawing.Size(444, 50)
        Me.Delete_ConfirmPnl.TabIndex = 44
        '
        'Delete_ConfirmBtn
        '
        Me.Delete_ConfirmBtn.AutoSize = True
        Me.Delete_ConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Delete_ConfirmBtn.BackColor = System.Drawing.Color.White
        Me.Delete_ConfirmBtn.Depth = 0
        Me.Delete_ConfirmBtn.Location = New System.Drawing.Point(10, 6)
        Me.Delete_ConfirmBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Delete_ConfirmBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Delete_ConfirmBtn.Name = "Delete_ConfirmBtn"
        Me.Delete_ConfirmBtn.Primary = False
        Me.Delete_ConfirmBtn.Size = New System.Drawing.Size(105, 36)
        Me.Delete_ConfirmBtn.TabIndex = 2
        Me.Delete_ConfirmBtn.Text = "Delete Table"
        Me.Delete_ConfirmBtn.UseVisualStyleBackColor = False
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 1
        Me.Home_Main_Layout.SetColumnSpan(Me.MainTableLayoutPanel, 6)
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.ScriptGrp, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.ToolStrip, 0, 1)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(467, 3)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 2
        Me.Home_Main_Layout.SetRowSpan(Me.MainTableLayoutPanel, 10)
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(694, 706)
        Me.MainTableLayoutPanel.TabIndex = 7
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
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip_Line, Me.ToolStripSeparator1, Me.ToolStrip_FontSize})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 676)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(694, 25)
        Me.ToolStrip.TabIndex = 8
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStrip_Line
        '
        Me.ToolStrip_Line.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStrip_Line.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStrip_Line.Name = "ToolStrip_Line"
        Me.ToolStrip_Line.Size = New System.Drawing.Size(43, 22)
        Me.ToolStrip_Line.Text = "0 Lines"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip_FontSize
        '
        Me.ToolStrip_FontSize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStrip_FontSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStrip_FontSize.Name = "ToolStrip_FontSize"
        Me.ToolStrip_FontSize.Size = New System.Drawing.Size(108, 22)
        Me.ToolStrip_FontSize.Text = "Sequence.Font.Size"
        Me.ToolStrip_FontSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_FontSize.ToolTipText = "Click to reset font size."
        '
        'MaterialTabSelector
        '
        Me.MaterialTabSelector.BaseTabControl = Me.MaterialTabControl
        Me.MaterialTabSelector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialTabSelector.Depth = 0
        Me.MaterialTabSelector.Location = New System.Drawing.Point(181, 25)
        Me.MaterialTabSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector.Name = "MaterialTabSelector"
        Me.MaterialTabSelector.Size = New System.Drawing.Size(906, 39)
        Me.MaterialTabSelector.TabIndex = 2
        Me.MaterialTabSelector.Text = "MaterialTabSelector1"
        '
        'Insert_Help
        '
        Me.Insert_Help.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Insert_Help.BackColor = System.Drawing.Color.Transparent
        Me.Insert_Help.Cursor = System.Windows.Forms.Cursors.Help
        Me.Insert_Help.Image = CType(resources.GetObject("Insert_Help.Image"), System.Drawing.Image)
        Me.Insert_Help.Location = New System.Drawing.Point(396, 13)
        Me.Insert_Help.Name = "Insert_Help"
        Me.Insert_Help.Size = New System.Drawing.Size(39, 34)
        Me.Insert_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Insert_Help.TabIndex = 57
        Me.Insert_Help.TabStop = False
        Me.Tip.SetToolTip(Me.Insert_Help, "Enter 1 Item Per Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Separate each items by changing lines, for example:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ite" &
        "m 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Field autodetects numeric values." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'FieldDetails_CheckHelp
        '
        Me.FieldDetails_CheckHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FieldDetails_CheckHelp.BackColor = System.Drawing.Color.Transparent
        Me.FieldDetails_CheckHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.FieldDetails_CheckHelp.Image = CType(resources.GetObject("FieldDetails_CheckHelp.Image"), System.Drawing.Image)
        Me.FieldDetails_CheckHelp.Location = New System.Drawing.Point(401, 20)
        Me.FieldDetails_CheckHelp.Name = "FieldDetails_CheckHelp"
        Me.FieldDetails_CheckHelp.Size = New System.Drawing.Size(39, 34)
        Me.FieldDetails_CheckHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FieldDetails_CheckHelp.TabIndex = 71
        Me.FieldDetails_CheckHelp.TabStop = False
        Me.Tip.SetToolTip(Me.FieldDetails_CheckHelp, "Enter 1 Item Per Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Separate each items by changing lines, for example:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ite" &
        "m 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Field autodetects numeric values.")
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1164, 765)
        Me.Controls.Add(Me.MaterialTabSelector)
        Me.Controls.Add(Me.Home_Main_Layout)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Home"
        Me.Text = "SQL Script Generator"
        Me.Home_Main_Layout.ResumeLayout(False)
        Me.TabContainerPanel.ResumeLayout(False)
        Me.MaterialTabControl.ResumeLayout(False)
        Me.HomePage.ResumeLayout(False)
        Me.Home_MngScriptGrp.ResumeLayout(False)
        Me.Home_MngScriptGrp.PerformLayout()
        Me.Home_MngScriptTableLayout.ResumeLayout(False)
        CType(Me.Home_ScriptCopyBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptNewBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptBrkBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptUndoBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptIncTxtBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptDecTxtBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home_ScriptExprtBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Home_InfoTableLayout.ResumeLayout(False)
        CType(Me.Home_FeedbackBtn, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.CreateTable_ActionDetailContainerPnl.ResumeLayout(False)
        Me.FieldGroup.ResumeLayout(False)
        Me.FieldGroup.PerformLayout()
        CType(Me.FieldDetails_Precision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldDetails_Size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldDetails_Scale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FieldDetails_ForeignKeyGrp.ResumeLayout(False)
        Me.FieldDetails_ForeignKeyGrp.PerformLayout()
        Me.FieldDetails_PrimyGrp.ResumeLayout(False)
        Me.FieldDetails_PrimyGrp.PerformLayout()
        Me.CreateTable_ActionDetailContainerPnl2.ResumeLayout(False)
        Me.CreateTable_ActionDetailContainerPnl2.PerformLayout()
        Me.FieldDetails_CheckGrp.ResumeLayout(False)
        Me.FieldDetails_CheckGrp.PerformLayout()
        Me.FieldDetails_RefConsTableLayout.ResumeLayout(False)
        Me.FieldDetails_ReferenceGrp.ResumeLayout(False)
        Me.FieldDetails_ReferenceGrp.PerformLayout()
        Me.FieldDetails_ConstraintGrp.ResumeLayout(False)
        Me.FieldDetails_ConstraintGrp.PerformLayout()
        Me.CreateTable_BtbTableLayout.ResumeLayout(False)
        Me.CreateTable_BtbTableLayout.PerformLayout()
        Me.AlterTablePage.ResumeLayout(False)
        Me.AlterTableLayoutPanel.ResumeLayout(False)
        Me.AlterTable_TableNamePnl.ResumeLayout(False)
        Me.AlterTable_TableNamePnl.PerformLayout()
        Me.AlterTable_ActionContainerPnl.ResumeLayout(False)
        Me.AlterTable_RenamePnl.ResumeLayout(False)
        Me.AlterTable_RenamePnl.PerformLayout()
        Me.AlterTable_DeleteColumnPnl.ResumeLayout(False)
        Me.AlterTable_DeleteColumnPnl.PerformLayout()
        Me.AlterTable_BtnTableLayout.ResumeLayout(False)
        Me.AlterTable_BtnTableLayout.PerformLayout()
        Me.InsertPage.ResumeLayout(False)
        Me.InsertTableLayout.ResumeLayout(False)
        Me.Insert_TableNamePnl.ResumeLayout(False)
        Me.Insert_TableNamePnl.PerformLayout()
        Me.Insert_ConfirmPnl.ResumeLayout(False)
        Me.Insert_ConfirmPnl.PerformLayout()
        Me.Insert_SpecifyColumnPnl.ResumeLayout(False)
        Me.Insert_SpecifyColumnPnl.PerformLayout()
        Me.Insert_DataItemsPnl.ResumeLayout(False)
        Me.Insert_DataItemsPnl.PerformLayout()
        Me.DeleteTablePage.ResumeLayout(False)
        Me.DropTableLayout.ResumeLayout(False)
        Me.Delete_TableNamePnl.ResumeLayout(False)
        Me.Delete_TableNamePnl.PerformLayout()
        Me.Delete_ConfirmPnl.ResumeLayout(False)
        Me.Delete_ConfirmPnl.PerformLayout()
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.MainTableLayoutPanel.PerformLayout()
        Me.ScriptGrp.ResumeLayout(False)
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.Insert_Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldDetails_CheckHelp, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CreateTable_ActionDetailContainerPnl2 As Panel
    Friend WithEvents FieldDetails_RefConsTableLayout As TableLayoutPanel
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
    Friend WithEvents AlterTable_TableNamePnl As Panel
    Friend WithEvents AlterTable_TableNamaLbl As Label
    Friend WithEvents AlterTable_TableNameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents AlterTable_DeleteColumnPnl As Panel
    Friend WithEvents AlterTable_DeleteColumnFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents AlterTable_DeleteColumnConfirmBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterTable_RenameConfirmBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterTable_RenameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents AlterTable_BtnTableLayout As TableLayoutPanel
    Friend WithEvents AlterTable_ModifyColumnBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterTable_RenameBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterTable_DeleteColumnBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AlterTable_AddColumnBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DropTableLayout As TableLayoutPanel
    Friend WithEvents Delete_TableNamePnl As Panel
    Friend WithEvents Delete_TableNamePnlLbl As Label
    Friend WithEvents Delete_TableNameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Delete_ConfirmPnl As Panel
    Friend WithEvents Delete_ConfirmBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DatabaseTableLayout As TableLayoutPanel
    Friend WithEvents Database_NameGrp As Panel
    Friend WithEvents Database_NameLbl As Label
    Friend WithEvents Database_NameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Database_ButtonTableLayout As TableLayoutPanel
    Friend WithEvents Database_SelectBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Database_CreateBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Database_DeleteBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents InsertTableLayout As TableLayoutPanel
    Friend WithEvents Insert_DataItemsFld As TextBox
    Friend WithEvents Insert_SpecifyColumnChkbx As CheckBox
    Friend WithEvents Insert_SpecifyColumnFld As TextBox
    Friend WithEvents Insert_TableNamePnl As Panel
    Friend WithEvents Insert_TableNameLbl As Label
    Friend WithEvents Insert_TableNameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Insert_ConfirmPnl As Panel
    Friend WithEvents Insert_DataItemsConfirmBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents ScriptGrp As GroupBox
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ToolStrip_Line As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStrip_FontSize As ToolStripLabel
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents MaterialTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents HomePage As TabPage
    Friend WithEvents DatabasePage As TabPage
    Friend WithEvents MaterialTabSelector As MaterialSkin.Controls.MaterialTabSelector
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
    Friend WithEvents Insert_SpecifyColumnPnl As Panel
    Friend WithEvents Insert_SpecifyColumnLbl As Label
    Friend WithEvents Insert_DataItemsPnl As Panel
    Friend WithEvents Insert_DataItemsLbl As Label
    Friend WithEvents AlterTable_RenamePnl As Panel
    Friend WithEvents AlterTable_RenameLbl As Label
    Friend WithEvents AlterTable_DeleteColumnLbl As Label
    Friend WithEvents AlterTable_ActionContainerPnl As Panel
    Friend WithEvents FieldDetails_ReferenceGrp As Panel
    Friend WithEvents FieldDetails_ReferentialLbl As Label
    Friend WithEvents FieldDetails_ConstraintGrp As Panel
    Friend WithEvents FieldDetails_ConstraintsLbl As Label
    Friend WithEvents FieldDetails_CheckGrp As Panel
    Friend WithEvents FieldDetails_CheckLbl As Label
    Friend WithEvents CreateTable_ActionDetailContainerPnl As Panel
    Friend WithEvents FieldGroup As Panel
    Friend WithEvents FieldDetails_ColumnLbl As Label
    Friend WithEvents FieldDetails_FormulaChkbx As CheckBox
    Friend WithEvents FieldDetails_ColumnTYpeCmbo As ComboBox
    Friend WithEvents FieldDetails_DefFld As TextBox
    Friend WithEvents FieldDetails_ColumnNameLbl As Label
    Friend WithEvents FieldDetails_DefValChkbx As CheckBox
    Friend WithEvents FieldDetails_ColumnNameFld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FieldDetails_Precision As NumericUpDown
    Friend WithEvents FieldDetails_PreScleLbl As Label
    Friend WithEvents FieldDetails_SizeLbl As Label
    Friend WithEvents FieldDetails_TypeLbl As Label
    Friend WithEvents FieldDetails_Size As NumericUpDown
    Friend WithEvents FieldDetails_Scale As NumericUpDown
    Friend WithEvents FieldDetails_ForeignKeyGrp As Panel
    Friend WithEvents FieldDetails_ForeignKeyLbl As Label
    Friend WithEvents FieldDetails_ForeignKeyFld As TextBox
    Friend WithEvents FieldDetails_PrimyGrp As Panel
    Friend WithEvents FieldDetails_PrimLbl As Label
    Friend WithEvents FieldDetails_PrimFld As TextBox
    Friend WithEvents Sequence As ListBox
    Friend WithEvents Home_FeedbackBtn As PictureBox
    Friend WithEvents Home_ScriptCopyBtn As PictureBox
    Friend WithEvents Insert_Help As PictureBox
    Friend WithEvents FieldDetails_CheckHelp As PictureBox
End Class
