Imports MaterialSkin
Public Class Home
    Public CurrentlyDoing As String
    Public First As Boolean
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size & " (Default)"
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Red600, Primary.Red800, Primary.Red400, Accent.Cyan400, TextShade.WHITE)
    End Sub

#Region "New Table Sub-Operation" 'Handles For the 'New Table" Operation

#Region "New Table Operation Handles"
    Private Sub NewTable(sender As Object, e As EventArgs) Handles CreateTable_CreateBtn.Click

        If Approve.Table = True Then
            CreateTable_CreateBtn.Enabled = False
            Generate.Table()
            UpdateUI.EnableTableControls()
            UpdateLine()

            CreateTable_NameFld.Enabled = False
            CreateTable_AddColumnBtn.Enabled = True
            CreateTable_AddForeignKeyBtn.Enabled = True
            CreateTable_AddPrimKeyBtn.Enabled = True
            CreateTable_CompleteTableBtn.Enabled = True

            Add_Field()

        End If

    End Sub
    Private Sub NewTableComplete(sender As Object, e As EventArgs) Handles CreateTable_CompleteTableBtn.Click

        Sequence.Items.Add(");")
        Sequence.Items.Add("")
        Initialise.NewTable()
        UpdateUI.ClearUp()

        CreateTable_AddColumnBtn.Enabled = False
        CreateTable_AddPrimKeyBtn.Enabled = False
        CreateTable_AddForeignKeyBtn.Enabled = False
        CreateTable_CompleteTableBtn.Enabled = False

    End Sub
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles FieldDetails_CreateFieldBtn.Click
        Select Case CurrentlyDoing

            Case = "AddNewField"
                If Approve.Field() = True Then
                    If FieldDetails_PrimChkbx.Checked = True Then
                        FieldDetails_PrimChkbx.Enabled = False
                        CreateTable_AddPrimKeyBtn.Enabled = False
                    End If
                    Generate.NewField()
                    Initialise.NewField()
                    UpdateLine()
                End If

            Case = "AddPrimaryKey"

                If Approve.PrimaryKey() = True Then
                    Generate.PrimaryKey()
                    FieldDetails_PrimChkbx.Enabled = False
                    CreateTable_AddPrimKeyBtn.Enabled = False
                    UpdateLine()
                End If

            Case = "AddForeignKey"

                If Approve.ForeignKey() = True Then
                    Generate.ForeignKey()
                    UpdateLine()
                End If

            Case = "AddField"
                AlterAddField()

            Case = "ModifyField"
                AlterModifyField()

        End Select

    End Sub
    Private Sub Add_Field_Butt(sender As Object, e As EventArgs) Handles CreateTable_AddColumnBtn.Click
        FieldGroup.Enabled = True

        Add_Field()

    End Sub

    Private Sub Add_Field()
        CurrentlyDoing = "AddNewField"

        FieldDetails.Visible = True
        Initialise.NewField()
        FieldDetails_ReferenceGrp.Enabled = True
        FieldGroup.Visible = True
        FieldDetails_PrimyGrp.Visible = False
        FieldDetails_ForeignKeyGrp.Visible = False

        FieldDetails_CreateFieldBtn.Enabled = True

    End Sub

#End Region

#Region "New Table Operation Dependent UI Changes"
    Private Sub ReferenceBox_CheckedChanged(sender As Object, e As EventArgs) Handles FieldDetails_ReferenceChkBx.CheckedChanged

        If FieldDetails_ReferenceChkBx.Checked = True Then
            FieldDetails_OnUpdateChkBx.Enabled = True
            FieldDetails_ReferenceFld.Enabled = True
            FieldDetails_OnDeleteChkbx.Enabled = True
        Else
            Initialise.ReferenceComponents()
        End If

    End Sub
    Private Sub OnUpdateBox_CheckedChanged(sender As Object, e As EventArgs) Handles FieldDetails_OnUpdateChkBx.CheckedChanged
        If FieldDetails_OnUpdateChkBx.Checked = True Then
            FieldDetails_OnUpdateCmbo.Enabled = True
        Else
            FieldDetails_OnUpdateCmbo.SelectedIndex = -1
            FieldDetails_OnUpdateCmbo.Enabled = False
        End If

    End Sub
    Private Sub OnDeleteBox_CheckedChanged(sender As Object, e As EventArgs) Handles FieldDetails_OnDeleteChkbx.CheckedChanged
        If FieldDetails_OnDeleteChkbx.Checked = True Then
            FieldDetails_OnDeleteCmbo.Enabled = True
        Else
            FieldDetails_OnDeleteCmbo.SelectedIndex = -1
            FieldDetails_OnDeleteCmbo.Enabled = False
        End If

    End Sub
    Private Sub CheckBOx_CheckedChanged(sender As Object, e As EventArgs) Handles FieldDetails_CheckChkbx.CheckedChanged
        If FieldDetails_CheckChkbx.Checked = True Then
            FieldDetails_CheckTypeCmbo.Enabled = True
            FieldDetails_CheckFld.Enabled = True
        Else
            FieldDetails_CheckTypeCmbo.SelectedIndex = -1
            FieldDetails_CheckTypeCmbo.Enabled = False
            FieldDetails_CheckFld.Enabled = False
            FieldDetails_CheckFld.Text = ""

        End If
    End Sub
    Private Sub Check_Type_TextChanged(sender As Object, e As EventArgs) Handles FieldDetails_CheckTypeCmbo.TextChanged
        If FieldDetails_CheckTypeCmbo.Text = "LIKE" Then
            FieldDetails_CheckPstnCmbo.Enabled = True
        Else
            FieldDetails_CheckPstnCmbo.SelectedIndex = -1
            FieldDetails_CheckPstnCmbo.Enabled = False
        End If
    End Sub
    Private Sub FieldType_TextChanged(sender As Object, e As EventArgs) Handles FieldDetails_ColumnTYpeCmbo.TextChanged

        If Approve.DataTypeSize = "Precise" Then
            FieldDetails_Size.Enabled = False
            FieldDetails_Precision.Enabled = True
            FieldDetails_Scale.Enabled = True

        ElseIf Approve.DataTypeSize = "NoSize" Then
            FieldDetails_Size.Enabled = False
            FieldDetails_Precision.Enabled = False
            FieldDetails_Scale.Enabled = False
        Else
            FieldDetails_Size.Enabled = True
            FieldDetails_Precision.Enabled = False
            FieldDetails_Scale.Enabled = False

        End If
    End Sub
    Private Sub Add_Primary_Key_Button_Click(sender As Object, e As EventArgs) Handles CreateTable_AddPrimKeyBtn.Click
        CurrentlyDoing = "AddPrimaryKey"
        FieldGroup.Visible = False
        FieldDetails_PrimyGrp.Visible = True
        FieldDetails_ForeignKeyGrp.Visible = False
        FieldDetails_ReferenceGrp.Enabled = False
        Initialise.Keys()
        FieldDetails_ConstraintGrp.Enabled = False
    End Sub
    Private Sub ForCheck_CheckedChanged(sender As Object, e As EventArgs) Handles FieldDetails_ForeignChkbx.CheckedChanged
        If FieldDetails_ForeignChkbx.Checked = True Then
            FieldDetails_PrimChkbx.Checked = False
            FieldDetails_PrimChkbx.Enabled = False
            FieldDetails_NotNullChkbx.Enabled = False
            FieldDetails_UniqueChkbx.Enabled = False
        Else
            FieldDetails_PrimChkbx.Enabled = True
            FieldDetails_NotNullChkbx.Enabled = True
            FieldDetails_UniqueChkbx.Enabled = True
        End If
    End Sub
    Private Sub PrimCheck_CheckedChanged(sender As Object, e As EventArgs) Handles FieldDetails_PrimChkbx.CheckedChanged
        If FieldDetails_PrimChkbx.Checked = True Then
            FieldDetails_ForeignChkbx.Checked = False
            FieldDetails_ForeignChkbx.Enabled = False
            FieldDetails_NotNullChkbx.Enabled = False
            FieldDetails_UniqueChkbx.Enabled = False
        Else
            FieldDetails_ForeignChkbx.Enabled = True
            FieldDetails_NotNullChkbx.Enabled = True
            FieldDetails_UniqueChkbx.Enabled = True
        End If
    End Sub
    Private Sub Default_Value_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles FieldDetails_DefValChkbx.CheckedChanged
        If FieldDetails_DefValChkbx.Checked = True Then
            FieldDetails_DefFld.Enabled = True
            FieldDetails_FormulaChkbx.Enabled = True

        Else
            FieldDetails_DefFld.Text = ""
            FieldDetails_FormulaChkbx.Checked = False
            FieldDetails_FormulaChkbx.Enabled = False
            FieldDetails_DefFld.Enabled = False

        End If
    End Sub

#End Region 'Handles for control dependent ofother controls

#End Region

#Region "Insert Table Sub-Operation"

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        If Approve.Insert() = True Then
            Generate.InsertData()
            UpdateLine()
            UpdateUI.ClearUp()

        End If

    End Sub

    Private Sub Specify_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Specify_CheckBox.CheckedChanged
        If Specify_CheckBox.Checked = True Then
            Columns.Enabled = True
        Else
            Columns.Text = ""
            DataItemsGroup.Text = "Data Values"
            Columns.Enabled = False
        End If
    End Sub

    Private Sub Columns_TextChanged(sender As Object, e As EventArgs) Handles DataItems.TextChanged, Columns.TextChanged

        If Specify_CheckBox.Checked = True Then
            If DataItems.Lines.Count <= Columns.Lines.Count Then
                DataItemsGroup.Text = "Data Items" & " ( Enter " & (Columns.Lines.Count - DataItems.Lines.Count) & " more item(s). )"
            Else
                DataItemsGroup.Text = "Data Items" & " ( " & (DataItems.Lines.Count - Columns.Lines.Count) & " redundent item(s). )"
            End If
        End If

    End Sub

#End Region

#Region "Drop Table Sub-Operation"
    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click

        If Approve.DropTable = True Then
            Generate.DropTable()
            Initialise.DropTable()
            UpdateUI.ClearUp()
            UpdateLine()
        End If

    End Sub

#End Region

#Region "Database Operations Sub Operations"
    Private Sub Create_Database_Click(sender As Object, e As EventArgs) Handles Database_CreateBtn.Click

        If Approve.Database = True Then
            Generate.CreateDatabase()
            Initialise.Database()
            UpdateLine()
        End If

    End Sub
    Private Sub Drop_Database_Click(sender As Object, e As EventArgs) Handles Database_DeleteBtn.Click

        If Approve.Database = True Then
            Generate.DropDatabase()
            Initialise.Database()
            UpdateLine()
        End If

    End Sub
    Private Sub Select_Database_Click(sender As Object, e As EventArgs) Handles Database_SelectBtn.Click
        If Approve.Database = True Then
            Generate.SelectDatabase()
            Initialise.Database()
            UpdateLine()
        End If

    End Sub

    Private Sub Select_Query_Click(sender As Object, e As EventArgs)
        MsgBox("Comming Soon!")

    End Sub

#End Region

#Region "Alter Table Sub Operation"

    Private Sub DropColumn_Click(sender As Object, e As EventArgs) Handles DropColumn.Click
        If Approve.Alter_Table() = True And Approve.DropColumn() = True Then
            Generate.AlterTable()
            Generate.DropField()
            Initialise.DropColumn()
            UpdateLine()

        End If
    End Sub

    Private Sub AlterModifyField()
        If Approve.Field() And Approve.Alter_Table = True Then

            Generate.AlterTable()

            Generate.ModifyField()
            UpdateLine()
            Initialise.NewField()
        End If

    End Sub

    Private Sub AlterAddField()

        If Approve.Alter_Table() = True And Approve.Field() = True Then

            Generate.AlterTable()

            Generate.AddField()
            UpdateLine()

            Initialise.NewField()
        End If

    End Sub

    Private Sub Rename_Click(sender As Object, e As EventArgs) Handles Rename.Click

        If Approve.Alter_Table() = True And Approve.Rename() = True Then
            Generate.AlterTable()
            Generate.RenameTable()
            Initialise.Rename()
            UpdateLine()
        End If

    End Sub

    Private Sub AlterRename_Click(sender As Object, e As EventArgs) Handles AlterRename.Click
        RenameGroup.Visible = True
        DropGroup.Visible = False
        FieldDetails.Visible = False

    End Sub

    Private Sub AlterAdd_Click(sender As Object, e As EventArgs) Handles AlterAdd.Click
        FieldDetails_ColumnLbl.Text = "Add Column"

        FieldGroup.Enabled = True

        RenameGroup.Visible = False
        DropGroup.Visible = False
        FieldDetails.Visible = True

        FieldGroup.Text = "Add Field"
        CurrentlyDoing = "AddField"
        First = True

    End Sub

    Private Sub AlterModify_Click(sender As Object, e As EventArgs) Handles AlterModify.Click
        FieldDetails_ColumnLbl.Text = "Modify Column"

        FieldGroup.Enabled = True

        RenameGroup.Visible = False
        DropGroup.Visible = False
        FieldDetails.Visible = True

        FieldGroup.Text = "Modify Field"
        CurrentlyDoing = "ModifyField"
        First = True
    End Sub

    Private Sub AlterDrop_Click(sender As Object, e As EventArgs) Handles AlterDrop.Click

        RenameGroup.Visible = False
        DropGroup.Visible = True
        FieldDetails.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        UpdateUI.ClearUp()

    End Sub

#End Region

#Region "Home UI"

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles Home_ScriptIncTxtBtn.Click
        If Sequence.Font.Size >= 40 Then
            ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size & " (Max.)"
        Else
            Sequence.Font = New Font(Sequence.Font.FontFamily, Sequence.Font.Size + 1, Sequence.Font.Style)
            ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size
        End If

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles Home_ScriptDecTxtBtn.Click

        If Sequence.Font.Size <= 6 Then
            ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size & " (Min.)"
        Else
            Sequence.Font = New Font(Sequence.Font.FontFamily, Sequence.Font.Size - 1, Sequence.Font.Style)
            ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles Home_ScriptBrkBtn.Click
        Sequence.Items.Add("")
        UpdateLine()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles Home_ScriptUndoBtn.Click
        If Sequence.Items.Count > 0 Then

            Sequence.Items.RemoveAt(Sequence.Items.Count - 1)
            UpdateLine()

        End If
    End Sub
    Private Sub SequenceSelectedIndexChanged(sender As Object, e As EventArgs) Handles Sequence.TextChanged, Sequence.SelectedIndexChanged
        UpdateLine()

    End Sub
    Sub UpdateLine()
        ToolStripLabel1.Text = (Sequence.Items.Count) & " lines"
    End Sub

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Animation.Close(sender)

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click

        Sequence.Font = New Font(Sequence.Font.FontFamily, 9.75, Sequence.Font.Style)
        ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size & " (Default)"
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Home_ScriptExprtBtn.Click
        SaveFileDialog1.Filter = "SQL File|*.sql|Text File|*.txt"
        SaveFileDialog1.Title = "Export Script"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim objWriter As New System.IO.StreamWriter(SaveFileDialog1.FileName)

            For i As Integer = 0 To Sequence.Items.Count - 1  'Loop creat string from array

                objWriter.WriteLine(Sequence.Items.Item(i))

            Next
            objWriter.Close()
        Else
            Return

        End If

        SaveFileDialog1.Dispose()

    End Sub

    Private Sub Database_Operations_Click_1(sender As Object, e As EventArgs)
        Dim tabpage As New TabPage
        tabpage.Text = "Database"

        MaterialTabControl1.TabPages.Add(tabpage)
        MaterialTabControl1.SelectTab(2)

    End Sub

    Private Sub MaterialTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialTabControl1.SelectedIndexChanged
        If MaterialTabControl1.SelectedIndex = 3 Then
            CurrentlyDoing = "AlterTable"
            AlterTableLayoutPanel.Visible = True
            FieldDetails.Parent = AlterTableLayoutPanel
            AlterTableLayoutPanel.SetRow(FieldDetails, 2)
            AlterTableLayoutPanel.SetRowSpan(FieldDetails, 10)
            FieldDetails.Dock = DockStyle.Fill

            FieldDetails.Visible = False

        End If

        If MaterialTabControl1.SelectedIndex = 2 Then

            Initialise.NewTable()

            FieldDetails_ColumnLbl.Text = "Add Column"

            FieldDetails.Parent = CreateActionLayout
            CreateActionLayout.SetRow(FieldDetails, 2)
            FieldGroup.Text = "Add Field"
            FieldDetails_CreateFieldBtn.Visible = True

            FieldDetails.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Home_ScriptNewBtn.Click
        Sequence.Items.Clear()
        UpdateLine()
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles Home_InfoBtn.Click
        About.Show()

    End Sub

    Private Sub CreateTable_AddForeignKeyBtn_Click(sender As Object, e As EventArgs) Handles CreateTable_AddForeignKeyBtn.Click
        CurrentlyDoing = "AddForeignKey"

        FieldGroup.Visible = False
        FieldDetails_PrimyGrp.Visible = False
        FieldDetails_ForeignKeyGrp.Visible = True
        FieldDetails_ReferenceGrp.Enabled = False
        Initialise.Keys()
        FieldDetails_ConstraintGrp.Enabled = False
    End Sub

#End Region

End Class
Public Class UpdateUI

    Shared Sub ClearUp()

        Home.First = False

    End Sub
    Shared Sub EnableTableControls()
        Home.CreateTable_AddColumnBtn.Enabled = True
        Home.CreateTable_CompleteTableBtn.Enabled = True
    End Sub

End Class