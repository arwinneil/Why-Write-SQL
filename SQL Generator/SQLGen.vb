Public Class Home

    Public NewLine, CurrentlyDoing As String


#Region "Main Operations"
    Private Sub CreatTableAction(sender As Object, e As EventArgs) Handles Act_Create_Table.Click

        Initialise.NewTable()

        ActionGroup.Visible = True
        CompleteTable_Button.Enabled = False

    End Sub
    Private Sub UpdateTableAction(sender As Object, e As EventArgs) Handles Act_Update.Click

        UpdateUI.ClearUp()
        Initialise.TableUpdate()

    End Sub
    Private Sub DeleteTableAction(sender As Object, e As EventArgs) Handles Act_Drop.Click
        Initialise.DeleteTable()

    End Sub

#End Region'Handles For the main funtions of the program

#Region "New Table Operation"

#Region "New Table Operation"
    Private Sub NewTable(sender As Object, e As EventArgs) Handles CreateButton.Click

        If Approve.Table = True Then
            SQL_Generator.Generate.Table()
            UpdateUI.EnableTableControls()
        End If

        Add_Field_Button.Enabled = True
        Add_Foreign_Key_Button.Enabled = True
        Add_Primary_Key_Button.Enabled = True
        CompleteTable_Button.Enabled = True

    End Sub
    Private Sub NewTableComplete(sender As Object, e As EventArgs) Handles CompleteTable_Button.Click

        Sequence.Items.Add(");")
        Initialise.NewTable()
        UpdateUI.ClearUp()

    End Sub
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click

    End Sub


#End Region'Handles For the 'New Table" Operation
    '  
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
    Private Sub FieldConsBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
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
        If Check_Type.Text = "Like" Then
            Check_Position.Enabled = True
        Else
            Check_Position.SelectedIndex = -1
            Check_Position.Enabled = False
        End If
    End Sub
    Private Sub FieldType_TextChanged(sender As Object, e As EventArgs)

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

        Initialise.Keys()

    End Sub
    Private Sub Add_Foreign_Key_Button_Click(sender As Object, e As EventArgs) Handles Add_Foreign_Key_Button.Click
        CurrentlyDoing = "AddForeignKey"
        FieldGroup.Visible = False
        PrimaryGroup.Visible = False
        ForeignKeyGroup.Visible = True

        Initialise.Keys()

    End Sub
    Private Sub Add_Field(sender As Object, e As EventArgs) Handles Add_Field_Button.Click
        CurrentlyDoing = "AddField"

        Initialise.NewField()

        FieldGroup.Visible = True
        PrimaryGroup.Visible = False
        ForeignKeyGroup.Visible = False


    End Sub



#End Region 'Handles for control dependent ofother controls

#End Region

End Class
Public Class Initialise

#Region "New Table Initialisers"
    Shared Sub NewTable()

        Home.ActionGroup.Text = "New Table"
        Home.CreateButton.Enabled = True

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
        Home.PrimCheck.Checked = False
        Home.NotNull.Checked = False
        Home.Unique.Checked = False
    End Sub

#End Region


    Shared Sub DeleteTable()
        Home.ActionGroup.Text = "Delete Table"
    End Sub
    Shared Sub TableUpdate()
        Home.ActionGroup.Text = "Update Details"
    End Sub


End Class
Public Class Generate
    Shared Sub Table()
        Home.NewLine = "CREATE TABLE " & Home.NewTableField.Text & " ("
        Home.Sequence.Items.Add(Home.NewLine)
    End Sub
    Shared Sub Field()
        Dim FieldName As String
        Dim LineType As String
        Dim LineSize As String
        Dim LineConstraint As String
        Dim Constraint As String



        If Home.CheckBox.Checked = True Then 'Check if any constraint apply
            Constraint = Home.Check_String.Text

            Select Case Home.Check_Type.Text
                Case "Like"


                    Select Case Home.Check_Position.Text 'Case of Position of LIKE String
                        Case "Before Any"
                            LineConstraint = "LIKE '" & Constraint & "%" & "'"
                        Case "After Any"
                            LineConstraint = "LIKE '" & "%" & Constraint & "'"
                        Case "Between Any"
                            LineConstraint = "LIKE '" & "%" & Constraint & "%'"
                        Case "Other/Specific"
                            LineConstraint = "LIKE '" & Constraint & "'"
                    End Select

                Case "Predefied"

                    Dim PreDef As String() = Home.Check_String.Lines 'Multiline list converted to array

                    LineConstraint = "IN('"

                    For i As Integer = 0 To Home.Check_String.Lines.Count - 1  'Loop creat string from array
                        LineConstraint = LineConstraint + PreDef(i)
                        If i < Home.Check_String.Lines.Count - 1 Then
                            LineConstraint = LineConstraint + "','"
                        Else
                            LineConstraint = LineConstraint + "')"
                        End If
                    Next

                Case "Numeric/Logical/Other"
                    LineConstraint = Constraint

            End Select
        End If

        FieldName = Home.FieldField.Text
        LineSize = Home.FieldSize.Value



        Home.NewLine = FieldName & " " & Home.FieldType.Text & " "

        If Approve.DataTypeSize = "Precise" Then

            Home.NewLine = Home.NewLine & "(" & Home.Precision.Value & "," & Home.Scale_.Value & ") "

        ElseIf Approve.DataTypeSize = "Integer" Then

            Home.NewLine = Home.NewLine & "(" & Home.FieldSize.Value & ") "
        End If


        If Home.PrimCheck.Checked = True Then
            Home.NewLine = Home.NewLine & "PRIMARY KEY "
        End If

        If Home.NotNull.Checked = True Then
            Home.NewLine = Home.NewLine & "NOT NULL "
        End If

        If Home.Unique.Checked = True Then
            Home.NewLine = Home.NewLine & "UNIQUE "
        End If

        If Home.CheckBox.Checked = True Then
            Home.NewLine = Home.NewLine & "CHECK (" & LineConstraint & ") "
        End If

        If Home.ReferenceBox.Checked = True Then
            Home.NewLine = Home.NewLine & "REFERENCES " & Home.ReferenceText.Text & " "

            If Home.OnUpdateBox.Checked = True Then
                Home.NewLine = Home.NewLine & "ON UPDATE " & Home.OnUpdateAction.Text & " "
            End If

            If Home.OnDeleteBox.Checked = True Then
                Home.NewLine = Home.NewLine & "ON DELETE " & Home.OnDeleteAction.Text & " "
            End If
        End If


        Home.NewLine = vbTab & Home.NewLine + ","

        Home.Sequence.Items.Add(Home.NewLine)

    End Sub



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



End Class
Public Class UpdateUI

    Shared Sub ClearUp()
        Home.ActionGroup.Visible = False
    End Sub
    Shared Sub EnableTableControls()
        Home.CreateButton.Enabled = False 'Prevents Creating same table multiple times
        Home.Add_Field_Button.Enabled = True
        Home.CompleteTable_Button.Enabled = True
    End Sub



End Class

'If Approve.Field() = True Then
'Generate.Field()
'Initialise.NewField()
'End If