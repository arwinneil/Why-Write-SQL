Public Class Home
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

        Home.NewTableField.Text = ""
        Home.FieldField.Text = ""
        Home.FieldType.SelectedIndex = -1
        Home.ReferenceText.Text = ""
        Home.ConsType.SelectedIndex = -1
        Home.ConsPositn.SelectedIndex = -1
        Home.ConsBox.Text = ""
        Home.NewTableCreate.Enabled = True
        Home.FieldSize.Value = 0
        Home.PrimCheck.Checked = False
        Home.ReferenceBox.Checked = False
        Home.FieldConsStat.Checked = False
        Home.AddField.Enabled = False

    End Sub
    Shared Sub NewField()

        Home.FieldField.Text = ""
        Home.FieldType.SelectedIndex = -1
        Home.ReferenceText.Text = ""
        Home.ConsType.SelectedIndex = -1
        Home.ConsPositn.SelectedIndex = -1
        Home.ConsBox.Text = ""
        Home.NewTableCreate.Enabled = True
        Home.FieldSize.Value = 0
        Home.PrimCheck.Checked = False
        Home.ReferenceBox.Checked = False
        Home.FieldConsStat.Checked = False

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

        'Field Generation 1 - Identify Type
        '                 2 - Identify Constraint  
        '                 3 - Get Name,Create Final string using Size, and check for Primary key

        Select Case Home.FieldType.Text
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

        If Home.FieldConsStat.Checked = True Then 'Check if any constraint apply
            Constraint = Home.ConsBox.Text

            Select Case Home.ConsType.Text
                Case "Like" 'Case of LIKE


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

                Case "Predefied" 'Case of Predefined 

                    Dim PreDef As String() = Home.ConsBox.Lines 'Multiline list converted to array

                    LineConstraint = "IN('"

                    For i As Integer = 0 To Home.ConsBox.Lines.Count - 1  'Loop creat string from array
                        LineConstraint = LineConstraint + PreDef(i)
                        If i < Home.ConsBox.Lines.Count - 1 Then
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



        Home.NewLine = FieldName & " " & LineType & "(" & LineSize & ") "
        If Home.PrimCheck.Checked = True Then
            Home.NewLine = Home.NewLine & "PRIMARY KEY "
        End If

        If Home.FieldConsStat.Checked = True Then
            Home.NewLine = Home.NewLine & "CHECK (" & LineConstraint & ") "
        End If

        If Home.ReferenceBox.Checked = True Then
            Home.NewLine = Home.NewLine & "REFERENCES " & Home.ReferenceText.Text & " ON UPDATE CASCADE "
        End If


        Home.NewLine = vbTab & Home.NewLine + ","

        Home.Sequence.Items.Add(Home.NewLine)

    End Sub

End Class

Public Class Approve

    Shared Function Field()
        Dim Validated As Boolean
        Validated = True

        If Home.FieldField.Text = "" Then
            MsgBox("Please enter field name")
            Validated = False
        End If

        If Home.FieldType.SelectedIndex = -1 Then
            MsgBox("Please select field type")
            Validated = False
        End If

        If Home.ReferenceBox.Checked = True And Home.ReferenceText.Text = "" Then
            MsgBox("Please Enter Reference")
            Validated = False
        End If

        If Home.ConsType.Text = "Like" And Home.ConsPositn.SelectedIndex = -1 Then
            MsgBox("Please select position of constraint")
            Validated = False
        End If

        If Home.FieldConsStat.Checked = True And ((Home.ConsType.SelectedIndex = -1) Or (Home.ConsBox.Text = "")) Then
            MsgBox("Please Enter constraint")
            Validated = False
        End If


        Return Validated
    End Function
End Class

