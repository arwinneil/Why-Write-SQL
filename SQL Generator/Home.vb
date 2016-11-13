Imports MaterialSkin
Public Class Home
    Public CurrentlyDoing As String

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStrip_FontSize.Text = " Font size : " & Sequence.Font.Size & " (Default)"
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Red600, Primary.Red800, Primary.Red400, Accent.Cyan400, TextShade.WHITE)
    End Sub

#Region "New Table Sub-Operation" 'Handles For the 'New Table" Operation

#Region "New Table Operation Handles"

    Private Sub CreateTable_CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateTable_CreateBtn.Click

        CreateTable()
    End Sub

    Private Sub CreateTable_NameFld_KeyDown(sender As Object, e As KeyEventArgs) Handles CreateTable_NameFld.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            CreateTable()
        End If
    End Sub

    Private Sub CreateTable()

        If Approve.Table = True Then
            CreateTable_CreateBtn.Enabled = False
            Generate.Table()

            CreateTable_AddColumnBtn.Enabled = True
            CreateTable_CompleteTableBtn.Enabled = True

            UpdateLine()

            CreateTable_NameFld.Enabled = False
            CreateTable_AddColumnBtn.Enabled = True
            CreateTable_AddForeignKeyBtn.Enabled = True
            CreateTable_AddPrimKeyBtn.Enabled = True
            CreateTable_CompleteTableBtn.Enabled = True

            Add_Field()

        End If

    End Sub
    Private Sub CompleteTableStatement(sender As Object, e As EventArgs) Handles CreateTable_CompleteTableBtn.Click

        FieldDetails_CreateFieldBtn.Enabled = True

        Dim i As Integer = Sequence.Items.Count - 1
        Dim str As String = Sequence.Items(i)
        Sequence.Items.Item(i) = str.Trim(",")

        Sequence.Items.Add(");")
        Sequence.Items.Add("")

        Initialise.NewTable()

        CreateTable_AddColumnBtn.Enabled = False
        CreateTable_AddPrimKeyBtn.Enabled = False
        CreateTable_AddForeignKeyBtn.Enabled = False
        CreateTable_CompleteTableBtn.Enabled = False

    End Sub
    Private Sub CreateField(sender As Object, e As EventArgs) Handles FieldDetails_CreateFieldBtn.Click

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
    Private Sub AddColumn(sender As Object, e As EventArgs) Handles CreateTable_AddColumnBtn.Click
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
    Private Sub Check_CheckedChanged(sender As Object, e As EventArgs) Handles FieldDetails_CheckChkbx.CheckedChanged
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

    Private Sub Insert(sender As Object, e As EventArgs) Handles Insert_DataItemsConfirmBtn.Click

        If Approve.Insert() = True Then
            Generate.InsertData()
            UpdateLine()
            Initialise.InsertData()

        End If

    End Sub
    Private Sub Specify_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Insert_SpecifyColumnChkbx.CheckedChanged

        If Insert_SpecifyColumnChkbx.Checked = True Then
            Insert_SpecifyColumnFld.Enabled = True
        Else
            Insert_SpecifyColumnFld.Text = ""
            Insert_DataItemsLbl.Text = "Data Values"
            Insert_SpecifyColumnFld.Enabled = False
        End If

    End Sub
    Private Sub Columns_TextChanged(sender As Object, e As EventArgs) Handles Insert_DataItemsFld.TextChanged, Insert_SpecifyColumnFld.TextChanged

        If Insert_SpecifyColumnChkbx.Checked = True Then
            If Insert_DataItemsFld.Lines.Count <= Insert_SpecifyColumnFld.Lines.Count Then
                Insert_DataItemsLbl.Text = "Data Items" & " ( Enter " & (Insert_SpecifyColumnFld.Lines.Count - Insert_DataItemsFld.Lines.Count) & " more item(s). )"
            Else
                Insert_DataItemsLbl.Text = "Data Items" & " ( " & (Insert_DataItemsFld.Lines.Count - Insert_SpecifyColumnFld.Lines.Count) & " redundent item(s). )"
            End If
        End If

    End Sub

#End Region

#Region "Delete Table Sub-Operation"

    Private Sub Delete_ConfirmBtn_Click(sender As Object, e As EventArgs) Handles Delete_ConfirmBtn.Click
        DeleteTable()
    End Sub

    Private Sub Delete_TableNameFld_KeyDown(sender As Object, e As KeyEventArgs) Handles Delete_TableNameFld.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            DeleteTable()
        End If
    End Sub

    Private Sub DeleteTable()

        If Approve.DropTable = True Then
            Generate.DropTable()
            Initialise.DeleteTable()

            UpdateLine()
        End If

    End Sub

#End Region

#Region "Database Operations Sub Operations"
    Private Sub Create_Database(sender As Object, e As EventArgs) Handles Database_CreateBtn.Click

        If Approve.Database = True Then
            Generate.CreateDatabase()
            Initialise.Database()
            UpdateLine()
        End If

    End Sub
    Private Sub Delete_Database(sender As Object, e As EventArgs) Handles Database_DeleteBtn.Click

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

#End Region

#Region "Alter Table Sub Operation"
    Private Sub AlterTable_DeleteColumnConfirmBtn_Click(sender As Object, e As EventArgs) Handles AlterTable_DeleteColumnConfirmBtn.Click
        DeleteColumn()
    End Sub
    Private Sub AlterTable_DeleteColumnFld_KeyDown(sender As Object, e As KeyEventArgs) Handles AlterTable_DeleteColumnFld.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            DeleteColumn()
        End If
    End Sub
    Private Sub DeleteColumn()

        If Approve.Alter_Table() = True And Approve.DropColumn() = True Then
            Generate.AlterTable()
            Generate.DropField()
            Initialise.DeleteColumn()
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

    Private Sub AlterTable_RenameFld_KeyDown(sender As Object, e As KeyEventArgs) Handles AlterTable_RenameFld.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            RenameTable()
        End If
    End Sub

    Private Sub AlterTable_RenameConfirmBtn_Click(sender As Object, e As EventArgs) Handles AlterTable_RenameConfirmBtn.Click
        RenameTable()
    End Sub

    Private Sub RenameTable()

        If Approve.Alter_Table() = True And Approve.Rename() = True Then
            Generate.AlterTable()
            Generate.RenameTable()
            Initialise.Rename()
            UpdateLine()
        End If

    End Sub
    Private Sub AlterRename_Click(sender As Object, e As EventArgs) Handles AlterTable_RenameBtn.Click

        AlterTable_RenamePnl.Visible = True
        AlterTable_DeleteColumnPnl.Visible = False
        FieldDetails.Visible = False

    End Sub
    Private Sub AlterAdd_Click(sender As Object, e As EventArgs) Handles AlterTable_AddColumnBtn.Click

        FieldDetails_CreateFieldBtn.Enabled = True

        FieldDetails_ColumnLbl.Text = "Add Column"

        FieldGroup.Enabled = True

        AlterTable_RenamePnl.Visible = False
        AlterTable_DeleteColumnPnl.Visible = False
        FieldDetails.Visible = True

        FieldGroup.Text = "Add Field"
        CurrentlyDoing = "AddField"

    End Sub
    Private Sub AlterModify_Click(sender As Object, e As EventArgs) Handles AlterTable_ModifyColumnBtn.Click

        FieldDetails_CreateFieldBtn.Enabled = True

        FieldDetails_ColumnLbl.Text = "Modify Column"

        FieldGroup.Enabled = True

        FieldDetails.Visible = True

        FieldGroup.Text = "Modify Field"
        AlterTable_RenamePnl.Visible = False
        AlterTable_DeleteColumnPnl.Visible = False
        CurrentlyDoing = "ModifyField"

    End Sub
    Private Sub AlterDrop_Click(sender As Object, e As EventArgs) Handles AlterTable_DeleteColumnBtn.Click

        AlterTable_RenamePnl.Visible = False
        AlterTable_DeleteColumnPnl.Visible = True
        FieldDetails.Visible = False

    End Sub

#End Region

#Region "Scipt Management"

    Private Sub IncreaseFontSize(sender As Object, e As EventArgs) Handles Home_ScriptIncTxtBtn.Click

        If Sequence.Font.Size >= 40 Then
            ToolStrip_FontSize.Text = " Font size : " & Sequence.Font.Size & " (Max.)"
        Else
            Sequence.Font = New Font(Sequence.Font.FontFamily, Sequence.Font.Size + 1, Sequence.Font.Style)
            ToolStrip_FontSize.Text = " Font size : " & Sequence.Font.Size
        End If

    End Sub
    Private Sub DecreaseFontSize(sender As Object, e As EventArgs) Handles Home_ScriptDecTxtBtn.Click

        If Sequence.Font.Size <= 6 Then
            ToolStrip_FontSize.Text = " Font size : " & Sequence.Font.Size & " (Min.)"
        Else
            Sequence.Font = New Font(Sequence.Font.FontFamily, Sequence.Font.Size - 1, Sequence.Font.Style)
            ToolStrip_FontSize.Text = " Font size : " & Sequence.Font.Size
        End If
    End Sub
    Private Sub Break(sender As Object, e As EventArgs) Handles Home_ScriptBrkBtn.Click

        Sequence.Items.Add("")
        UpdateLine()

    End Sub
    Private Sub Undo(sender As Object, e As EventArgs) Handles Home_ScriptUndoBtn.Click

        If Sequence.Items.Count > 0 Then

            Sequence.Items.RemoveAt(Sequence.Items.Count - 1)
            UpdateLine()

        End If
    End Sub
    Private Sub SequenceSelectedIndexChanged(sender As Object, e As EventArgs) Handles Sequence.TextChanged, Sequence.SelectedIndexChanged
        UpdateLine()

    End Sub
    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStrip_FontSize.Click

        Sequence.Font = New Font(Sequence.Font.FontFamily, 9.75, Sequence.Font.Style)
        ToolStrip_FontSize.Text = " Font size : " & Sequence.Font.Size & " (Default)"
    End Sub
    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Home_ScriptExprtBtn.Click

        SaveFileDialog.Filter = "SQL File|*.sql|Text File|*.txt"
        SaveFileDialog.Title = "Export Script"

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then

            Dim objWriter As New System.IO.StreamWriter(SaveFileDialog.FileName)

            For i As Integer = 0 To Sequence.Items.Count - 1  'Loop creat string from array

                objWriter.WriteLine(Sequence.Items.Item(i))

            Next
            objWriter.Close()

        Else

            Return

        End If

        SaveFileDialog.Dispose()

    End Sub
    Private Sub MaterialTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialTabControl.SelectedIndexChanged

        Select Case MaterialTabControl.SelectedIndex
            Case 1
                Initialise.Database()

            Case 2
                Initialise.NewTable()

                FieldDetails_CreateFieldBtn.Enabled = False

                FieldDetails_ColumnLbl.Text = "Add Column"

                FieldDetails.Parent = CreateActionLayout
                CreateActionLayout.SetRow(FieldDetails, 2)
                FieldGroup.Text = "Add Field"
                FieldDetails_CreateFieldBtn.Visible = True

                FieldDetails.Visible = True

            Case 3

                CurrentlyDoing = "AlterTable"
                AlterTableLayoutPanel.Visible = True
                FieldDetails.Parent = AlterTableLayoutPanel
                AlterTableLayoutPanel.SetRow(FieldDetails, 2)
                AlterTableLayoutPanel.SetRowSpan(FieldDetails, 10)
                FieldDetails.Dock = DockStyle.Fill

                Initialise.NewTable()

                FieldDetails.Visible = False

            Case 4

                Initialise.Insert()

            Case 5

                Initialise.DeleteTable()

        End Select

    End Sub
    Private Sub Clear(sender As Object, e As EventArgs) Handles Home_ScriptNewBtn.Click

        Sequence.Items.Clear()
        UpdateLine()

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
    Sub UpdateLine()
        ToolStrip_Line.Text = (Sequence.Items.Count) & " lines"
    End Sub

    Private Sub Info(sender As Object, e As EventArgs) Handles Home_InfoBtn.Click

        About.Show()

    End Sub
    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Animation.Close(sender)

    End Sub

    Private Sub Home_FeedbackBtn_Click(sender As Object, e As EventArgs) Handles Home_FeedbackBtn.Click
        Process.Start("https://goo.gl/forms/rldiWUoFZx4LjSeq2")
    End Sub

    Private Sub Home_ScriptCopyBtn_Click(sender As Object, e As EventArgs) Handles Home_ScriptCopyBtn.Click

        Dim buffer As String

        For i = 0 To Sequence.Items.Count - 1

            buffer = buffer + Sequence.Items.Item(i) + vbCrLf

        Next

        Clipboard.Clear()
        Clipboard.SetText(buffer)
    End Sub

#End Region

End Class