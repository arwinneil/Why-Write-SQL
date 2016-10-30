Friend Class Generate

#Region "New Table Generators"
    Shared Sub Table()
        Dim NewLine As String
        NewLine = "CREATE TABLE " & Home.CreateTable_NameFld.Text & " ("
        Home.Sequence.Items.Add(NewLine)

    End Sub
    Shared Sub NewField()
        Dim NewLine As String

        NewLine = Field()

        Home.Sequence.Items.Add(NewLine)

    End Sub
    Shared Function Constraints(ColumnName As String)

        Dim LineConstraint As String
        Dim Constraint As String = Home.FieldDetails_CheckFld.Text

        Select Case Home.FieldDetails_CheckTypeCmbo.Text
            Case "LIKE"

                Select Case Home.FieldDetails_CheckPstnCmbo.Text 'Case of Position of LIKE String
                    Case "Before any string"
                        LineConstraint = "(" & ColumnName & " LIKE '" & Constraint & "%" & "')"
                    Case "After any string"
                        LineConstraint = "(" & ColumnName & " LIKE '" & "%" & Constraint & "')"
                    Case "Between any string"
                        LineConstraint = "(" & ColumnName & " LIKE '" & "%" & Constraint & "%')"
                    Case "Other/Specific"
                        LineConstraint = "(" & ColumnName & " LIKE '" & Constraint & "')"
                End Select

            Case "IN"

                Dim Str As String() = Home.FieldDetails_CheckFld.Lines 'Multiline list converted to array

                LineConstraint = "IN('"

                For i As Integer = 0 To Home.FieldDetails_CheckFld.Lines.Count - 1  'Loop creat string from array
                    LineConstraint = LineConstraint + Str(i)
                    If i < Home.FieldDetails_CheckFld.Lines.Count - 1 Then
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

        Dim Keys As String() = Home.FieldDetails_PrimFld.Lines 'Multiline list converted to array

        For i As Integer = 0 To Home.FieldDetails_PrimFld.Lines.Count - 1  'Loop creat string from array

            NewLine = NewLine + Keys(i)

            If i < Home.FieldDetails_PrimFld.Lines.Count - 1 Then
                NewLine = NewLine + ","
            Else
                NewLine = NewLine + ") "
            End If
        Next

        If Home.FieldDetails_CheckChkbx.Checked = True Then 'Check if any constraint apply

            NewLine = NewLine & "CHECK (" & LineConstraint & ") "
        End If

        NewLine = vbTab & NewLine + ","

        Home.Sequence.Items.Add(NewLine)

    End Sub
    Shared Sub ForeignKey()

        Dim NewLine As String
        Dim LineConstraint As String

        NewLine = "FOREIGN KEY ("

        Dim Keys As String() = Home.FieldDetails_ForeignKeyFld.Lines 'Multiline list converted to array

        For i As Integer = 0 To Home.FieldDetails_ForeignKeyFld.Lines.Count - 1  'Loop creat string from array

            NewLine = NewLine + Keys(i)

            If i < Home.FieldDetails_ForeignKeyFld.Lines.Count - 1 Then
                NewLine = NewLine + ","
            Else
                NewLine = NewLine + ") "
            End If
        Next

        If Home.FieldDetails_CheckChkbx.Checked = True Then 'Check if any constraint apply

            NewLine = NewLine & "CHECK (" & LineConstraint & ") "
        End If

        NewLine = vbTab & NewLine + ","

        Home.Sequence.Items.Add(NewLine)
    End Sub

#End Region

#Region "Insert Generators"

    Shared Sub InsertData()
        Dim NewLine As String

        NewLine = "INSERT INTO " & Home.Insert_TableNameFld.Text

        If Home.Insert_SpecifyColumnChkbx.Checked = True Then

            NewLine = NewLine + "("

            Dim columns As String() = Home.Insert_SpecifyColumnFld.Lines 'Multiline list converted to array

            For i As Integer = 0 To Home.Insert_SpecifyColumnFld.Lines.Count - 1  'Loop creat string from array
                NewLine = NewLine + columns(i)

                If i < Home.Insert_SpecifyColumnFld.Lines.Count - 1 Then
                    NewLine = NewLine + ","
                Else
                    NewLine = NewLine + ") "
                End If

            Next
        End If

        Home.Sequence.Items.Add(NewLine)

        NewLine = "VALUES ("

        Dim DataItem As String() = Home.Insert_DataItemsFld.Lines 'Multiline list converted to array

        For i As Integer = 0 To Home.Insert_DataItemsFld.Lines.Count - 1  'Loop creat string from array

            If i = 0 And IsNumeric(DataItem(i)) = False Then
                NewLine = NewLine + "'"
            End If

            NewLine = NewLine + DataItem(i)

            If IsNumeric(DataItem(i)) = False And (i < (Home.Insert_DataItemsFld.Lines.Count - 1)) Then
                NewLine = NewLine + "'"
            End If

            If i < Home.Insert_DataItemsFld.Lines.Count - 1 Then
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

        NewLine = "CREATE DATABASE " & Home.Database_NameFld.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")

    End Sub
    Shared Sub DropDatabase()
        Dim NewLine As String

        NewLine = "DROP DATABASE " & Home.Database_NameFld.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub
    Shared Sub SelectDatabase()
        Dim NewLine As String

        NewLine = "USE " & Home.Database_NameFld.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub
    Shared Sub DropTable()
        Dim NewLine As String

        NewLine = "DROP TABLE " & Home.Delete_TableNameFld.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub
    Shared Sub AlterTable()
        Dim NewLine As String
        NewLine = "ALTER TABLE " & Home.AlterTable_TableNameFld.Text

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

        NewLine = "DROP COLUMN " & Home.AlterTable_DeleteColumnFld.Text & ";"
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

        NewLine = "RENAME TO " & Home.AlterTable_RenameFld.Text & ";"
        Home.Sequence.Items.Add(NewLine)
        Home.Sequence.Items.Add("")
    End Sub
    Shared Function Field()
        Dim FieldName As String
#Disable Warning BC42024 ' Unused local variable: 'LineType'.
        Dim LineType As String
#Enable Warning BC42024 ' Unused local variable: 'LineType'.
        Dim LineSize As String
        Dim LineConstraint As String
#Disable Warning BC42024 ' Unused local variable: 'Constraint'.
        Dim Constraint As String
#Enable Warning BC42024 ' Unused local variable: 'Constraint'.
        Dim NewLine As String

        FieldName = Home.FieldDetails_ColumnNameFld.Text
        LineSize = Home.FieldDetails_Size.Value

        If Home.FieldDetails_CheckChkbx.Checked = True Then 'Check if any constraint apply
            LineConstraint = Constraints(FieldName)

        End If

        NewLine = FieldName & " " & Home.FieldDetails_ColumnTYpeCmbo.Text & " "

        If Approve.DataTypeSize = "Precise" Then

            NewLine = NewLine & "(" & Home.FieldDetails_Precision.Value & "," & Home.FieldDetails_Scale.Value & ") "

        ElseIf Approve.DataTypeSize = "Integer" Then

            NewLine = NewLine & "(" & Home.FieldDetails_Size.Value & ") "
        End If

        If Home.FieldDetails_DefValChkbx.Checked = True Then

            If Home.FieldDetails_FormulaChkbx.Checked = True Or IsNumeric(Home.FieldDetails_DefFld.Text) = True Then

                NewLine = NewLine & "DEFAULT " & Home.FieldDetails_DefFld.Text & " "
            Else
                NewLine = NewLine & "DEFAULT '" & Home.FieldDetails_DefFld.Text & "' "
            End If

        End If
        If Home.FieldDetails_PrimChkbx.Checked = True Then
            NewLine = NewLine & "PRIMARY KEY "
        End If

        If Home.FieldDetails_ForeignChkbx.Checked = True Then
            NewLine = NewLine & "FOREIGN KEY "
        End If

        If Home.FieldDetails_NotNullChkbx.Checked = True Then
            NewLine = NewLine & "NOT NULL "
        End If

        If Home.FieldDetails_UniqueChkbx.Checked = True Then
            NewLine = NewLine & "UNIQUE "
        End If

        If Home.FieldDetails_CheckChkbx.Checked = True Then
            NewLine = NewLine & "CHECK " & LineConstraint
        End If

        If Home.FieldDetails_ReferenceChkBx.Checked = True Then
            NewLine = NewLine & "REFERENCES " & Home.FieldDetails_ReferenceFld.Text & " "

            If Home.FieldDetails_OnUpdateChkBx.Checked = True Then
                NewLine = NewLine & "ON UPDATE " & Home.FieldDetails_OnUpdateCmbo.Text & " "
            End If

            If Home.FieldDetails_OnDeleteChkbx.Checked = True Then
                NewLine = NewLine & "ON DELETE " & Home.FieldDetails_OnDeleteCmbo.Text & " "
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