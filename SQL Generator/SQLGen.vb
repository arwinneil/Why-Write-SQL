Public Class Home
    Public NewLine As String
#Region "Main Operations"
    Private Sub CreatTableAction(sender As Object, e As EventArgs) Handles Act_Create_Table.Click

        Initialise.NewTable()

        ActionGroup.Visible = True
        CompleteTable.Enabled = False

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
    Private Sub NewTable(sender As Object, e As EventArgs) Handles NewTableCreate.Click

        If Approve.Table = True Then
            Generate.Table()
            UpdateUI.EnableTableControls()
        End If

    End Sub
    Private Sub NewField(sender As Object, e As EventArgs) Handles AddField.Click

        If Approve.Field() = True Then
            Generate.Field()
            Initialise.NewField()
        End If

    End Sub
    Private Sub NewTableComplete(sender As Object, e As EventArgs) Handles CompleteTable.Click

        Sequence.Items.Add(");")
        Initialise.NewTable()
        UpdateUI.ClearUp()

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
    Private Sub FieldConsBox_CheckedChanged(sender As Object, e As EventArgs) Handles FieldConsBox.CheckedChanged
        If FieldConsBox.Checked = True Then
            ConsType.Enabled = True
            ConsList.Enabled = True
        Else
            ConsType.SelectedIndex = -1
            ConsType.Enabled = False
            ConsList.Enabled = False
            ConsList.Text = ""

        End If
    End Sub
    Private Sub ConsType_TextChanged(sender As Object, e As EventArgs) Handles ConsType.TextChanged
        If ConsType.Text = "Like" Then
            ConsPositn.Enabled = True
        Else
            ConsPositn.SelectedIndex = -1
            ConsPositn.Enabled = False
        End If
    End Sub
    Private Sub FieldType_TextChanged(sender As Object, e As EventArgs) Handles FieldType.TextChanged, FieldType.SelectedIndexChanged

        If Approve.DataTypeSize = "Precise" Then
            FieldSize.Enabled = False
            Precision.Enabled = True
            Scale.Enabled = True

        ElseIf Approve.DataTypeSize = "NoSize" Then
            FieldSize.Enabled = False
            Precision.Enabled = False
            Scale.Enabled = False
        Else
            FieldSize.Enabled = True
            Precision.Enabled = False
            Scale.Enabled = False

        End If
    End Sub





#End Region 'Handles for control dependent ofother controls

#End Region

End Class
Public Class Initialise
    Shared Sub NewTable()

        Home.ActionGroup.Text = "New Table"
        Home.NewTableField.Text = ""
        Home.FieldField.Text = ""
        Home.FieldType.SelectedIndex = -1
        Home.ReferenceText.Text = ""
        Home.ConsType.SelectedIndex = -1
        Home.ConsPositn.SelectedIndex = -1
        Home.ConsType.Enabled = False
        Home.ConsPositn.Enabled = False
        Home.ConsList.Text = ""
        Home.NewTableCreate.Enabled = True
        Home.FieldSize.Value = 0
        Home.PrimCheck.Checked = False
        Home.ReferenceBox.Checked = False
        Home.FieldConsBox.Checked = False
        Home.AddField.Enabled = False


    End Sub
    Shared Sub NewField()

        Home.FieldField.Text = ""
        Home.FieldType.SelectedIndex = -1
        Home.ConsType.SelectedIndex = -1
        Home.ConsPositn.SelectedIndex = -1
        Home.ConsType.Enabled = False
        Home.ConsPositn.Enabled = False
        Home.ConsList.Text = ""
        Home.FieldSize.Value = 0
        Home.PrimCheck.Checked = False
        Home.ReferenceBox.Checked = False
        Home.FieldConsBox.Checked = False
        Home.ConsList.Enabled = False
        Home.FieldSize.Enabled = False
        Home.Precision.Enabled = False
        Home.Scale.Enabled = False
        Initialise.ReferenceComponents()

    End Sub
    Shared Sub DeleteTable()
        Home.ActionGroup.Text = "Delete Table"
    End Sub
    Shared Sub TableUpdate()
        Home.ActionGroup.Text = "Update Details"
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



        If Home.FieldConsBox.Checked = True Then 'Check if any constraint apply
            Constraint = Home.ConsList.Text

            Select Case Home.ConsType.Text
                Case "Like"


                    Select Case Home.ConsPositn.Text 'Case of Position of LIKE String
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

                    Dim PreDef As String() = Home.ConsList.Lines 'Multiline list converted to array

                    LineConstraint = "IN('"

                    For i As Integer = 0 To Home.ConsList.Lines.Count - 1  'Loop creat string from array
                        LineConstraint = LineConstraint + PreDef(i)
                        If i < Home.ConsList.Lines.Count - 1 Then
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

            Home.NewLine = Home.NewLine & "(" & Home.Precision.Value & "," & Home.Scale.Value & ") "

        ElseIf Approve.DataTypeSize = "Integer" Then

            Home.NewLine = Home.NewLine & "(" & Home.FieldSize.Value & ") "
        End If


        If Home.PrimCheck.Checked = True Then
            Home.NewLine = Home.NewLine & "PRIMARY KEY "
        End If

        If Home.FieldConsBox.Checked = True Then
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

        If Home.ConsType.Text = "Like" And Home.ConsPositn.SelectedIndex = -1 Then
            MsgBox("Please select position of constraint.")
            Approved = False
        End If

        If Home.FieldConsBox.Checked = True And ((Home.ConsType.SelectedIndex = -1) Or (Home.ConsList.Text = "")) Then
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
        Home.NewTableCreate.Enabled = False 'Prevents Creating same table multiple times
        Home.AddField.Enabled = True
        Home.CompleteTable.Enabled = True
    End Sub



End Class

