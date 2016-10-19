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
    Private Sub NewTable(sender As Object, e As EventArgs) Handles CreateButton.Click

        If Approve.Table = True Then
            CreateButton.Enabled = False
            Generate.Table()
            UpdateUI.EnableTableControls()
            UpdateLine()

            NewTableField.Enabled = False
            Add_Field_Button.Enabled = True
            Add_Foreign_Key_Button.Enabled = True
            Add_Primary_Key_Button.Enabled = True
            CompleteTable_Button.Enabled = True

            Add_Field()

        End If

    End Sub
    Private Sub NewTableComplete(sender As Object, e As EventArgs) Handles CompleteTable_Button.Click

        Sequence.Items.Add(");")
        Sequence.Items.Add("")
        Initialise.NewTable()
        UpdateUI.ClearUp()

        Add_Field_Button.Enabled = False
        Add_Primary_Key_Button.Enabled = False
        Add_Foreign_Key_Button.Enabled = False
        CompleteTable_Button.Enabled = False

    End Sub
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles CreateField.Click
        Select Case CurrentlyDoing

            Case = "AddNewField"
                If Approve.Field() = True Then
                    If PrimCheck.Checked = True Then
                        PrimCheck.Enabled = False
                        Add_Primary_Key_Button.Enabled = False
                    End If
                    Generate.NewField()
                    Initialise.NewField()
                    UpdateLine()
                End If

            Case = "AddPrimaryKey"

                If Approve.PrimaryKey() = True Then
                    Generate.PrimaryKey()
                    PrimCheck.Enabled = False
                    Add_Primary_Key_Button.Enabled = False
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
    Private Sub Add_Field_Butt(sender As Object, e As EventArgs) Handles Add_Field_Button.Click
        Add_Field()

    End Sub

    Private Sub Add_Field()
        CurrentlyDoing = "AddNewField"

        FieldDetails.Visible = True
        Initialise.NewField()
        ReferenceGroup.Enabled = True
        FieldGroup.Visible = True
        PrimaryGroup.Visible = False
        ForeignKeyGroup.Visible = False

        CreateField.Enabled = True

    End Sub

#End Region

#Region "New Table Operation Dependent UI Changes"
    Private Sub ReferenceBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReferenceBox.CheckedChanged

        If ReferenceBox.Checked = True Then
            OnUpdateBox.Enabled = True
            ReferenceText.Enabled = True
            OnDeleteBox.Enabled = True
        Else
            Initialise.ReferenceComponents()
        End If

    End Sub
    Private Sub OnUpdateBox_CheckedChanged(sender As Object, e As EventArgs) Handles OnUpdateBox.CheckedChanged
        If OnUpdateBox.Checked = True Then
            OnUpdateAction.Enabled = True
        Else
            OnUpdateAction.SelectedIndex = -1
            OnUpdateAction.Enabled = False
        End If

    End Sub
    Private Sub OnDeleteBox_CheckedChanged(sender As Object, e As EventArgs) Handles OnDeleteBox.CheckedChanged
        If OnDeleteBox.Checked = True Then
            OnDeleteAction.Enabled = True
        Else
            OnDeleteAction.SelectedIndex = -1
            OnDeleteAction.Enabled = False
        End If

    End Sub
    Private Sub CheckBOx_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        If CheckBox.Checked = True Then
            Check_Type.Enabled = True
            Check_String.Enabled = True
        Else
            Check_Type.SelectedIndex = -1
            Check_Type.Enabled = False
            Check_String.Enabled = False
            Check_String.Text = ""

        End If
    End Sub
    Private Sub Check_Type_TextChanged(sender As Object, e As EventArgs) Handles Check_Type.TextChanged
        If Check_Type.Text = "LIKE" Then
            Check_Position.Enabled = True
        Else
            Check_Position.SelectedIndex = -1
            Check_Position.Enabled = False
        End If
    End Sub
    Private Sub FieldType_TextChanged(sender As Object, e As EventArgs) Handles FieldType.TextChanged

        If Approve.DataTypeSize = "Precise" Then
            FieldSize.Enabled = False
            Precision.Enabled = True
            Scale_.Enabled = True

        ElseIf Approve.DataTypeSize = "NoSize" Then
            FieldSize.Enabled = False
            Precision.Enabled = False
            Scale_.Enabled = False
        Else
            FieldSize.Enabled = True
            Precision.Enabled = False
            Scale_.Enabled = False

        End If
    End Sub
    Private Sub Add_Primary_Key_Button_Click(sender As Object, e As EventArgs) Handles Add_Primary_Key_Button.Click
        CurrentlyDoing = "AddPrimaryKey"
        FieldGroup.Visible = False
        PrimaryGroup.Visible = True
        ForeignKeyGroup.Visible = False
        ReferenceGroup.Enabled = False
        Initialise.Keys()
        ConstraintGroup.Enabled = False
    End Sub
    Private Sub Add_Foreign_Key_Button_Click(sender As Object, e As EventArgs) Handles Add_Foreign_Key_Button.Click
        CurrentlyDoing = "AddForeignKey"
        ReferenceGroup.Enabled = True
        FieldGroup.Visible = False
        PrimaryGroup.Visible = False
        ForeignKeyGroup.Visible = True

        Initialise.Keys()
        ConstraintGroup.Enabled = False
    End Sub
    Private Sub ForCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ForCheck.CheckedChanged
        If ForCheck.Checked = True Then
            PrimCheck.Checked = False
            PrimCheck.Enabled = False
            NotNull.Enabled = False
            Unique.Enabled = False
        Else
            PrimCheck.Enabled = True
            NotNull.Enabled = True
            Unique.Enabled = True
        End If
    End Sub
    Private Sub PrimCheck_CheckedChanged(sender As Object, e As EventArgs) Handles PrimCheck.CheckedChanged
        If PrimCheck.Checked = True Then
            ForCheck.Checked = False
            ForCheck.Enabled = False
            NotNull.Enabled = False
            Unique.Enabled = False
        Else
            ForCheck.Enabled = True
            NotNull.Enabled = True
            Unique.Enabled = True
        End If
    End Sub
    Private Sub Default_Value_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Default_Value_Checkbox.CheckedChanged
        If Default_Value_Checkbox.Checked = True Then
            DefaultValue.Enabled = True
            Formula.Enabled = True

        Else
            DefaultValue.Text = ""
            Formula.Checked = False
            Formula.Enabled = False
            DefaultValue.Enabled = False

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
    Private Sub Create_Database_Click(sender As Object, e As EventArgs) Handles Create_Database.Click

        If Approve.Database = True Then
            Generate.CreateDatabase()
            Initialise.Database()
            UpdateLine()
        End If

    End Sub
    Private Sub Drop_Database_Click(sender As Object, e As EventArgs) Handles Drop_Database.Click

        If Approve.Database = True Then
            Generate.DropDatabase()
            Initialise.Database()
            UpdateLine()
        End If

    End Sub
    Private Sub Select_Database_Click(sender As Object, e As EventArgs) Handles Select_Database.Click
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
        Label17.Text = "Add Column"

        RenameGroup.Visible = False
        DropGroup.Visible = False
        FieldDetails.Visible = True

        FieldGroup.Text = "Add Field"
        CurrentlyDoing = "AddField"
        First = True

    End Sub

    Private Sub AlterModify_Click(sender As Object, e As EventArgs) Handles AlterModify.Click
        Label17.Text = "Modify Column"

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
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Do
            Me.Opacity = Me.Opacity - 0.03
            System.Threading.Thread.Sleep(4)
        Loop Until Opacity = 0

        Me.Close()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles Inc.Click
        If Sequence.Font.Size >= 40 Then
            ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size & " (Max.)"
        Else
            Sequence.Font = New Font(Sequence.Font.FontFamily, Sequence.Font.Size + 1, Sequence.Font.Style)
            ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size
        End If

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles Dec.Click

        If Sequence.Font.Size <= 6 Then
            ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size & " (Min.)"
        Else
            Sequence.Font = New Font(Sequence.Font.FontFamily, Sequence.Font.Size - 1, Sequence.Font.Style)
            ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles Br.Click
        Sequence.Items.Add("")
        UpdateLine()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles Undo.Click
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
        Do
            Me.Opacity = Me.Opacity - 0.02
            System.Threading.Thread.Sleep(4)
        Loop Until Opacity = 0

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click

        Sequence.Font = New Font(Sequence.Font.FontFamily, 9.75, Sequence.Font.Style)
        ToolStripLabel2.Text = " Font size : " & Sequence.Font.Size & " (Default)"
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
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

            Label17.Text = "Add Column"

            FieldDetails.Parent = CreateActionLayout
            CreateActionLayout.SetRow(FieldDetails, 2)
            FieldGroup.Text = "Add Field"
            CreateField.Visible = True

            FieldDetails.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Sequence.Items.Clear()
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        About.Show()

    End Sub




#End Region

End Class
Public Class UpdateUI

    Shared Sub ClearUp()

        Home.First = False

    End Sub
    Shared Sub EnableTableControls()
        Home.Add_Field_Button.Enabled = True
        Home.CompleteTable_Button.Enabled = True
    End Sub

End Class