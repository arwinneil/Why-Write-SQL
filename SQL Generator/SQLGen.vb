Public Class SQLGENHOME

    Dim NewLine As String
    Private Sub GenTable(sender As Object, e As EventArgs) Handles NewTableCreate.Click
        NewLine = "CREATE TABLE " & NewTableField.Text & "("
        Sequence.Items.Add(NewLine)
        NewTableCreate.Enabled = False 'Prevents Creating same table multiple times 
    End Sub

    Private Sub GenField(sender As Object, e As EventArgs) Handles AddField.Click
        Dim FieldName As String
        Dim LineType As String
        Dim LineSize As String
        Dim LineConstraint As String
        Dim Constraint As String

        'Field Generation 1 - Identify Type
        '                 2 - Identify Constraint  
        '                 3 - Get Name,Create Final string using Size, and check for Primary key

        Select Case FieldType.Text
            Case "Text"
                LineType = "VARCHAR"
            Case "Character"
                LineType = "CHAr"
            Case "Integer"
                LineType = "INTEGER"
            Case "Small Integer"
                LineType = "SMALLINTEGER"
            Case "Bit"
                LineType = "BIT"
        End Select

        If FieldConsStat.Checked = True Then 'Check if any constraint apply

            Select Case ConsType.Text
                Case "Like" 'Case of LIKE
                    Constraint = ConsBox.Text

                    Select Case ConsPositn.Text 'Case of Position of LIKE String
                        Case "Before Any"
                            LineConstraint = "LIKE '" & Constraint & "%" & "'"
                        Case "After Any"
                            LineConstraint = "LIKE '" & "%" & Constraint & "'"
                        Case "Between Any"
                            LineConstraint = "LIKE '" & "%" & Constraint & "%'"
                        Case "Other / Specific"
                            LineConstraint = "LIKE " & Constraint & "'"
                    End Select

                Case "Predefied" 'Case of Predefined 

                    Dim PreDef As String() = ConsBox.Lines 'Multiline list converted to array

                    LineConstraint = "IN('"

                    For i As Integer = 0 To ConsBox.Lines.Count - 1  'Loop creat string from array
                        LineConstraint = LineConstraint + PreDef(i)
                        If i < ConsBox.Lines.Count - 1 Then
                            LineConstraint = LineConstraint + "','"
                        Else
                            LineConstraint = LineConstraint + "')"
                        End If
                    Next

            End Select
        End If

        FieldName = FieldField.Text
        LineSize = FieldSize.Value

        If FieldConsStat.Checked = True Then
            If PrimCheck.Checked = True Then
                NewLine = FieldName & " " & LineType & "(" & LineSize & ") PRIMARY KEY CHECK(" & LineConstraint & "),"
            Else
                NewLine = FieldName & " " & LineType & "(" & LineSize & ") (" & LineConstraint & "),"
            End If
        Else
            If PrimCheck.Checked = True Then
                NewLine = FieldName & " " & LineType & "(" & LineSize & ") PRIMARY KEY CHECK ),"
            Else
                NewLine = FieldName & " " & LineType & "(" & LineSize & "),"
            End If
        End If

        Sequence.Items.Add(NewLine)

    End Sub
End Class

