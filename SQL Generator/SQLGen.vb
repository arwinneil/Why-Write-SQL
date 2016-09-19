Public Class SQLGENHOME
    Public NewLine As String
    Private Sub NewTable(sender As Object, e As EventArgs) Handles NewTableCreate.Click
        If NewTableField.Text = "" Then
            MsgBox("Please enter table name before continuing.")
        Else
            Generate.Table()
            NewTableCreate.Enabled = False 'Prevents Creating same table multiple times
            AddField.Enabled = True
            CompleteTable.Enabled = True
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
        NewTablePane.Visible = False

    End Sub

    Private Sub CreatTableAction(sender As Object, e As EventArgs) Handles Act_Create_Table.Click
        Initialise.NewTable()

        NewTablePane.Visible = True
        CompleteTable.Enabled = False

    End Sub

End Class
Public Class Initialise
    Shared Sub NewTable()

        SQLGENHOME.NewTableField.Text = ""
        SQLGENHOME.FieldField.Text = ""
        SQLGENHOME.FieldType.SelectedIndex = -1
        SQLGENHOME.ReferenceText.Text = ""
        SQLGENHOME.ConsType.SelectedIndex = -1
        SQLGENHOME.ConsPositn.SelectedIndex = -1
        SQLGENHOME.ConsBox.Text = ""
        SQLGENHOME.NewTableCreate.Enabled = True
        SQLGENHOME.FieldSize.Value = 0
        SQLGENHOME.PrimCheck.Checked = False
        SQLGENHOME.ReferenceBox.Checked = False
        SQLGENHOME.FieldConsStat.Checked = False
        SQLGENHOME.AddField.Enabled = False

    End Sub
    Shared Sub NewField()

        SQLGENHOME.FieldField.Text = ""
        SQLGENHOME.FieldType.SelectedIndex = -1
        SQLGENHOME.ReferenceText.Text = ""
        SQLGENHOME.ConsType.SelectedIndex = -1
        SQLGENHOME.ConsPositn.SelectedIndex = -1
        SQLGENHOME.ConsBox.Text = ""
        SQLGENHOME.NewTableCreate.Enabled = True
        SQLGENHOME.FieldSize.Value = 0
        SQLGENHOME.PrimCheck.Checked = False
        SQLGENHOME.ReferenceBox.Checked = False
        SQLGENHOME.FieldConsStat.Checked = False

    End Sub

End Class

Public Class Generate
    Shared Sub Table()
        SQLGENHOME.NewLine = "CREATE TABLE " & SQLGENHOME.NewTableField.Text & " ("
        SQLGENHOME.Sequence.Items.Add(SQLGENHOME.NewLine)
    End Sub

    Shared Sub Field()
        Dim FieldName As String
        Dim LineType As String
        Dim LineSize As String
        Dim LineConstraint As String
        Dim Constraint As String

        'Field Generation 1 - Identify Type
        '                 2 - Identify Constraint  
        '                 3 - Get Name,Create Final string using Size, and check for Primary key

        Select Case SQLGENHOME.FieldType.Text
            Case "Text"
                LineType = "VARCHAR"
            Case "Character"
                LineType = "CHAR"
            Case "Integer"
                LineType = "INTEGER"
            Case "Small Integer"
                LineType = "SMALLINTEGER"
            Case "Bit"
                LineType = "BIT"
        End Select

        If SQLGENHOME.FieldConsStat.Checked = True Then 'Check if any constraint apply
            Constraint = SQLGENHOME.ConsBox.Text

            Select Case SQLGENHOME.ConsType.Text
                Case "Like" 'Case of LIKE


                    Select Case SQLGENHOME.ConsPositn.Text 'Case of Position of LIKE String
                        Case "Before Any"
                            LineConstraint = "LIKE '" & Constraint & "%" & "'"
                        Case "After Any"
                            LineConstraint = "LIKE '" & "%" & Constraint & "'"
                        Case "Between Any"
                            LineConstraint = "LIKE '" & "%" & Constraint & "%'"
                        Case "Other/Specific"
                            LineConstraint = "LIKE '" & Constraint & "'"
                    End Select

                Case "Predefied" 'Case of Predefined 

                    Dim PreDef As String() = SQLGENHOME.ConsBox.Lines 'Multiline list converted to array

                    LineConstraint = "IN('"

                    For i As Integer = 0 To SQLGENHOME.ConsBox.Lines.Count - 1  'Loop creat string from array
                        LineConstraint = LineConstraint + PreDef(i)
                        If i < SQLGENHOME.ConsBox.Lines.Count - 1 Then
                            LineConstraint = LineConstraint + "','"
                        Else
                            LineConstraint = LineConstraint + "')"
                        End If
                    Next

                Case "Numeric/Logical/Other"
                    LineConstraint = Constraint

            End Select
        End If

        FieldName = SQLGENHOME.FieldField.Text
        LineSize = SQLGENHOME.FieldSize.Value



        SQLGENHOME.NewLine = FieldName & " " & LineType & "(" & LineSize & ") "
        If SQLGENHOME.PrimCheck.Checked = True Then
            SQLGENHOME.NewLine = SQLGENHOME.NewLine & "PRIMARY KEY "
        End If

        If SQLGENHOME.FieldConsStat.Checked = True Then
            SQLGENHOME.NewLine = SQLGENHOME.NewLine & "CHECK (" & LineConstraint & ") "
        End If

        If SQLGENHOME.ReferenceBox.Checked = True Then
            SQLGENHOME.NewLine = SQLGENHOME.NewLine & "REFERENCES " & SQLGENHOME.ReferenceText.Text & " ON UPDATE CASCADE "
        End If


        SQLGENHOME.NewLine = vbTab & SQLGENHOME.NewLine + ","

        SQLGENHOME.Sequence.Items.Add(SQLGENHOME.NewLine)

    End Sub

End Class

Public Class Approve

    Shared Function Field()
        Dim Validated As Boolean
        Validated = True

        If SQLGENHOME.FieldField.Text = "" Then
            MsgBox("Please enter field name")
            Validated = False
        End If

        If SQLGENHOME.FieldType.SelectedIndex = -1 Then
            MsgBox("Please select field type")
            Validated = False
        End If

        If SQLGENHOME.ReferenceBox.Checked = True And SQLGENHOME.ReferenceText.Text = "" Then
            MsgBox("Please Enter Reference")
            Validated = False
        End If

        If SQLGENHOME.ConsType.Text = "Like" And SQLGENHOME.ConsPositn.SelectedIndex = -1 Then
            MsgBox("Please select position of constraint")
            Validated = False
        End If

        If SQLGENHOME.FieldConsStat.Checked = True And ((SQLGENHOME.ConsType.SelectedIndex = -1) Or (SQLGENHOME.ConsBox.Text = "")) Then
            MsgBox("Please Enter constraint")
            Validated = False
        End If




        Return Validated
    End Function
End Class

