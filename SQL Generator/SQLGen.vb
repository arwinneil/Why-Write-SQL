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
    '

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
                Generate.PrimaryKey()
                PrimCheck.Enabled = False
                Add_Primary_Key_Button.Enabled = False
                UpdateLine()
            Case = "AddForeignKey"
                Generate.ForeignKey()
                UpdateLine()
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

        RenameGroup.Visible = False
        DropGroup.Visible = False
        FieldDetails.Visible = True

        FieldGroup.Text = "Add Field"
        CurrentlyDoing = "AddField"
        First = True

    End Sub

    Private Sub AlterModify_Click(sender As Object, e As EventArgs) Handles AlterModify.Click
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
            Me.Opacity = Me.Opacity - 0.02
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

#End Region

End Class

Class Initialise

#Region "New Table Initialisers"
    Shared Sub NewTable()

        Home.CreateButton.Enabled = True
        Home.NewTableField.Text = ""
        Home.NewTableField.Enabled = True

        NewField()

        Keys()

        Check()

        Constraints()

    End Sub
    Shared Sub NewField()

        Home.FieldField.Text = ""
        Home.FieldType.SelectedIndex = -1
        Home.FieldSize.Value = 0
        Home.FieldSize.Enabled = False
        Home.Precision.Enabled = False
        Home.Scale_.Enabled = False
        Home.Precision.Value = 0
        Home.Scale_.Value = 0
        Home.DefaultValue.Text = ""
        Home.Default_Value_Checkbox.Checked = False
        Home.Formula.Checked = False
        Home.Formula.Enabled = False

        Keys()

        Check()

        Constraints()
    End Sub
    Shared Sub ReferenceComponents()

        Home.OnUpdateBox.Enabled = False
        Home.OnUpdateAction.Enabled = False
        Home.OnDeleteAction.Enabled = False
        Home.OnDeleteBox.Enabled = False
        Home.OnUpdateAction.SelectedIndex = -1
        Home.OnDeleteAction.SelectedIndex = -1
        Home.OnUpdateBox.Checked = False
        Home.OnDeleteBox.Checked = False
        Home.ReferenceText.Text = ""
        Home.ReferenceText.Enabled = False
        Home.ReferenceBox.Checked = False

    End Sub
    Shared Sub Keys()
        Home.PrimaryKeys.Text = ""
        Home.ForeignKeys.Text = ""
        ReferenceComponents()
        Constraints()
    End Sub
    Shared Sub Check()
        Home.Check_Type.SelectedIndex = -1
        Home.Check_Position.SelectedIndex = -1
        Home.Check_Type.Enabled = False
        Home.Check_Position.Enabled = False
        Home.Check_String.Text = ""
        Home.CheckBox.Checked = False
    End Sub
    Shared Sub Constraints()
        Home.ConstraintGroup.Enabled = True
        Home.PrimCheck.Checked = False
        Home.NotNull.Checked = False
        Home.Unique.Checked = False
    End Sub

#End Region

    Shared Sub DropTable()

        Home.TableName.Text = ""
    End Sub
    Shared Sub Database()
        Home.DatabaseName.Text = ""
    End Sub
    Shared Sub TableUpdate()

        Home.InsertTable.Text = ""
        Home.Specify_CheckBox.Checked = False
        Home.Columns.Text = ""
        Home.DataItemsGroup.Text = "Data Items"
        Home.DataItems.Text = ""

    End Sub

#Region "Alter Table Initialisers"
    Shared Sub Rename()
        Home.NewTableName.Text = ""
    End Sub

    Shared Sub DropColumn()
        Home.Alter_Drop_Table.Text = ""
    End Sub

    Shared Sub Alter_table()
        Home.Alter_Table_Name.Text = ""

        DropColumn()
        Rename()
        NewField()

    End Sub
#End Region

End Class

Public Class Generate

#Region "New Table Generators"
    Shared Sub Table()
        Dim NewLine As String
        NewLine = "CREATE TABLE " & Home.NewTableField.Text & " ("
        Home.Sequence.Items.Add(NewLine)

    End Sub
    Shared Sub NewField()
        Dim NewLine As String

        NewLine = Field()

        Home.Sequence.Items.Add(NewLine)

    End Sub
    Shared Function Constraints()
        Dim LineConstraint As String
        Dim Constraint As String

        Constraint = Home.Check_String.Text

        Select Case Home.Check_Type.Text
            Case "LIKE"

                Select Case Home.Check_Position.Text 'Case of Position of LIKE String
                    Case "Before any string"
                        LineConstraint = "LIKE '" & Constraint & "%" & "'"
                    Case "After any string"
                        LineConstraint = "LIKE '" & "%" & Constraint & "'"
                    Case "Between any string"
                        LineConstraint = "LIKE '" & "%" & Constraint & "%'"
                    Case "Other/Specific"
                        LineConstraint = "LIKE '" & Constraint & "'"
                End Select

            Case "IN"

                Dim Str As String() = Home.Check_String.Lines 'Multiline list converted to array

                LineConstraint = "IN('"

                For i As Integer = 0 To Home.Check_String.Lines.Count - 1  'Loop creat string from array
                    LineConstraint = LineConstraint + Str(i)
                    If i < Home.Check_String.Lines.Count - 1 Then
                        LineConstraint = LineConstraint + "','"
                    Else
                        LineConstraint = LineConstraint + "')"
                    End If
                Next

            Case "Numeric/Logical Expresion/Other"
                LineConstraint = Constraint

        End Select

        Return LineConstraint

    End Function
    Shared Sub PrimaryKey()
        Dim NewLine As String
        Dim LineConstraint As String

        NewLine = "PRIMARY KEY ("

        Dim Keys As String() = Home.PrimaryKeys.Lines 'Multiline list converted to array

        For i As Integer = 0 To Home.PrimaryKeys.Lines.Count - 1  'Loop creat string from array

            NewLine = NewLine + Keys(i)

            If i < Home.PrimaryKeys.Lines.Count - 1 Then
                NewLine = NewLine + ","
            Else
                NewLine = NewLine + ") "
            End If
        Next

        If Home.CheckBox.Checked = True Then 'Check if any constraint apply
            LineConstraint = Constraints()
            NewLine = NewLine & "CHECK (" & LineConstraint & ") "
        End If

        NewLine = vbTab & NewLine + ","

        Home.Sequence.Items.Add(NewLine)

    End Sub
    Shared Sub ForeignKey()

        Dim NewLine As String
        Dim LineConstraint As String

        NewLine = "FOREIGN KEY ("

        Dim Keys As String() = Home.ForeignKeys.Lines 'Multiline list converted to array

        For i As Integer = 0 To Home.ForeignKeys.Lines.Count - 1  'Loop creat string from array

            NewLine = NewLine + Keys(i)

            If i < Home.ForeignKeys.Lines.Count - 1 Then
                NewLine = NewLine + ","
            Else
                NewLine = NewLine + ") "
            End If
        Next

        If Home.CheckBox.Checked = True Then 'Check if any constraint apply
            LineConstraint = Constraints()
            NewLine = NewLine & "CHECK (" & LineConstraint & ") "
        End If

        NewLine = vbTab & NewLine + ","

        Home.Sequence.Items.Add(NewLine)
    End Sub

#End Region

#Region "Insert Generators"

    Shared Sub InsertData()
        Dim NewLine As String

        NewLine = "INSERT INTO " & Home.InsertTable.Text

        If Home.Specify_CheckBox.Checked = True Then

            NewLine = NewLine + "("

            Dim columns As String() = Home.Columns.Lines 'Multiline list converted to array

            For i As Integer = 0 To Home.Columns.Lines.Count - 1  'Loop creat string from array
                NewLine = NewLine + columns(i)

                If i < Home.Columns.Lines.Count - 1 Then
                    NewLine = NewLine + ","
                Else
                    NewLine = NewLine + ") "
                End If

            Next
        End If

        Home.Sequence.Items.Add(NewLine)

        NewLine = "VALUES ("

        Dim DataItem As String() = Home.DataItems.Lines 'Multiline list converted to array

        For i As Integer = 0 To Home.DataItems.Lines.Count - 1  'Loop creat string from array

            If i = 0 And IsNumeric(DataItem(i)) = False Then
                NewLine = NewLine + "'"
            End If

            NewLine = NewLine + DataItem(i)

            If IsNumeric(DataItem(i)) = False And (i < (Home.DataItems.Lines.Count - 1)) Then
                NewLine = NewLine + "'"
            End If

            If i < Home.DataItems.Lines.Count - 1 Then
                NewLine = NewLine + ","

                If IsNumeric(DataItem(i + 1)) = False Then
                    NewLine = NewLine + "'"
                End If

            Else
                If IsNumeric(DataItem(i)) = False Then
                    NewLine = NewLine + "'"
                End If

                NewLine = NewLine + "); "
            End If

        Next

        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")

    End Sub

#End Region

    Shared Sub CreateDatabase()
        Dim NewLine As String

        NewLine = "CREATE DATABASE " & Home.DatabaseName.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")

    End Sub
    Shared Sub DropDatabase()
        Dim NewLine As String

        NewLine = "DROP DATABASE " & Home.DatabaseName.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub
    Shared Sub SelectDatabase()
        Dim NewLine As String

        NewLine = "USE " & Home.DatabaseName.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub
    Shared Sub DropTable()
        Dim NewLine As String

        NewLine = "DROP TABLE " & Home.TableName.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub

    Shared Sub AlterTable()
        Dim NewLine As String
        NewLine = "ALTER TABLE " & Home.Alter_Table_Name.Text

        Home.Sequence.Items.Add(NewLine)
    End Sub

    Shared Sub AddField()

        Dim NewLine As String

        NewLine = "ADD " & Field()

        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub

    Shared Sub DropField()
        Dim NewLine As String

        NewLine = "DROP COLUMN " & Home.Alter_Drop_Table.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub

    Shared Sub ModifyField()
        Dim NewLine As String

        NewLine = "MODIFY " & Field()

        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")

    End Sub

    Shared Sub RenameTable()
        Dim NewLine As String

        NewLine = vbTab & "RENAME TO " & Home.NewTableName.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub

    Shared Function Field()
        Dim FieldName As String
        Dim LineType As String
        Dim LineSize As String
        Dim LineConstraint As String
        Dim Constraint As String
        Dim NewLine As String

        If Home.CheckBox.Checked = True Then 'Check if any constraint apply
            LineConstraint = Constraints()

        End If

        FieldName = Home.FieldField.Text
        LineSize = Home.FieldSize.Value

        NewLine = FieldName & " " & Home.FieldType.Text & " "

        If Approve.DataTypeSize = "Precise" Then

            NewLine = NewLine & "(" & Home.Precision.Value & "," & Home.Scale_.Value & ") "

        ElseIf Approve.DataTypeSize = "Integer" Then

            NewLine = NewLine & "(" & Home.FieldSize.Value & ") "
        End If

        If Home.Default_Value_Checkbox.Checked = True Then

            If Home.Formula.Checked = True Or IsNumeric(Home.DefaultValue.Text) = True Then

                NewLine = NewLine & "DEFAULT " & Home.DefaultValue.Text & " "
            Else
                NewLine = NewLine & "DEFAULT '" & Home.DefaultValue.Text & "' "
            End If

        End If
        If Home.PrimCheck.Checked = True Then
            NewLine = NewLine & "PRIMARY KEY "
        End If

        If Home.ForCheck.Checked = True Then
            NewLine = NewLine & "FOREIGN KEY "
        End If

        If Home.NotNull.Checked = True Then
            NewLine = NewLine & "NOT NULL "
        End If

        If Home.Unique.Checked = True Then
            NewLine = NewLine & "UNIQUE "
        End If

        If Home.CheckBox.Checked = True Then
            NewLine = NewLine & "CHECK (" & LineConstraint & ") "
        End If

        If Home.ReferenceBox.Checked = True Then
            NewLine = NewLine & "REFERENCES " & Home.ReferenceText.Text & " "

            If Home.OnUpdateBox.Checked = True Then
                NewLine = NewLine & "ON UPDATE " & Home.OnUpdateAction.Text & " "
            End If

            If Home.OnDeleteBox.Checked = True Then
                NewLine = NewLine & "ON DELETE " & Home.OnDeleteAction.Text & " "
            End If
        End If

        If Home.CurrentlyDoing = "AddNewField" Then
            NewLine = vbTab & NewLine + ","

        Else
            NewLine = NewLine + ";"
        End If

        Return NewLine

    End Function

End Class

Public Class Approve

    Shared Function Field()
        Dim Approved As Boolean
        Approved = True

        If Home.FieldField.Text = "" Then
            MsgBox("Please enter field name")
            Approved = False
        End If

        If Home.FieldType.SelectedIndex = -1 Then
            MsgBox("Please select field type.")
            Approved = False
        End If

        If Home.ReferenceBox.Checked = True And Home.ReferenceText.Text = "" Then
            MsgBox("Please Enter reference.")
            Approved = False
        End If

        If Home.Check_Type.Text = "Like" And Home.Check_Position.SelectedIndex = -1 Then
            MsgBox("Please select position of constraint.")
            Approved = False
        End If

        If Home.CheckBox.Checked = True And ((Home.Check_Type.SelectedIndex = -1) Or (Home.Check_String.Text = "")) Then
            MsgBox("Please Enter constraint.")
            Approved = False
        End If

        If Home.OnUpdateBox.Checked = True And Home.OnUpdateAction.SelectedIndex = -1 Then
            MsgBox("Please specify action on update.")
            Approved = False
        End If

        If Home.OnDeleteBox.Checked = True And Home.OnDeleteAction.SelectedIndex = -1 Then
            MsgBox("Please specify action on delete.")
            Approved = False
        End If

        If Home.Default_Value_Checkbox.Checked = True And Home.DefaultValue.Text = "" Then
            MsgBox("Please specify field default value.")
            Approved = False
        End If

        If Home.Check_Type.Text = "LIKE" And Home.Check_Position.SelectedIndex = -1 Then
            MsgBox("Please specify string position for LIKE CHECK.")
            Approved = False
        End If

        Return Approved
    End Function

    Shared Function Table()
        Dim Approved As Boolean
        Approved = True

        If Home.NewTableField.Text = "" Then
            MsgBox("Please enter table name before continuing.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function DataTypeSize()
        Dim Size As String
        If (Home.FieldType.Text = "NUMERIC") Or (Home.FieldType.Text = "DECIMAL") Then

            Size = "Precise"

        ElseIf (Home.FieldType.Text = "DATE") Or (Home.FieldType.Text = "TIME") Or (Home.FieldType.Text = "INTEGER") Or (Home.FieldType.Text = "BIT") Then
            Size = "NoSize"
        Else

            Size = "Integer"

        End If
        Return Size
    End Function

    Shared Function Alter_Table()
        Dim Approved As Boolean
        Approved = True

        If Home.Alter_Table_Name.Text = "" Then
            MsgBox("Please enter table name before continuing.")
            Approved = False

        End If
        Return Approved
    End Function
    Shared Function Rename()
        Dim Approved As Boolean
        Approved = True

        If Home.NewTableName.Text = "" Then
            MsgBox("Please enter new table name before continuing.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function DropColumn()
        Dim Approved As Boolean
        Approved = True

        If Home.Alter_Drop_Table.Text = "" Then
            MsgBox("Please enter name of column to be deleted.")
            Approved = False

        End If
        Return Approved
    End Function
    Shared Function Insert()

        Dim Approved As Boolean
        Approved = True

        If Home.InsertTable.Text = "" Then
            MsgBox("Please enter name of Table.")
            Approved = False
        End If

        If Home.Specify_CheckBox.Checked = True And Home.Columns.Text = "" Then
            MsgBox("Please enter Columns.")
            Approved = False
        End If

        If Home.DataItems.Text = "" Then
            MsgBox("Please enter data items.")
            Approved = False
        End If

        Return Approved
    End Function

    Shared Function Database()
        Dim Approved As Boolean
        Approved = True

        If Home.DatabaseName.Text = "" Then
            MsgBox("Please enter name of Database.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function DropTable()
        Dim Approved As Boolean
        Approved = True

        If Home.TableName.Text = "" Then
            MsgBox("Please enter name of table.")
            Approved = False

        End If
        Return Approved
    End Function

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