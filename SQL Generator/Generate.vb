Friend Class Generate

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
