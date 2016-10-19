Friend Class Approve

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


    Shared Function PrimaryKey()
        Dim Approved As Boolean = True

        If Home.PrimaryKeys.Text = "" Then
            MsgBox("Please enter name(s) of primary key(s).")
            Approved = False
        End If

        Return Approved

    End Function

    Shared Function ForeignKey()
        Dim Approved As Boolean = True

        If Home.ForeignKeys.Text = "" Then
            MsgBox("Please enter name(s) of foreign key(s).")
            Approved = False
        End If

        Return Approved

    End Function

End Class

