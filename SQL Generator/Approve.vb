Friend Class Approve

    Shared Function Field()
        Dim Approved As Boolean
        Approved = True

        If Home.FieldDetails_ColumnNameFld.Text = "" Then
            MsgBox("Please enter column name")
            Approved = False
        End If

        If Home.FieldDetails_ColumnTYpeCmbo.SelectedIndex = -1 Then
            MsgBox("Please select column type.")
            Approved = False
        End If

        If Home.FieldDetails_ReferenceChkBx.Checked = True And Home.FieldDetails_ReferenceFld.Text = "" Then
            MsgBox("Please Enter reference.")
            Approved = False
        End If

        If Home.FieldDetails_CheckTypeCmbo.Text = "Like" And Home.FieldDetails_CheckPstnCmbo.SelectedIndex = -1 Then
            MsgBox("Please select position of constraint.")
            Approved = False
        End If

        If Home.FieldDetails_CheckChkbx.Checked = True And ((Home.FieldDetails_CheckTypeCmbo.SelectedIndex = -1) Or (Home.FieldDetails_CheckFld.Text = "")) Then
            MsgBox("Please Enter constraint.")
            Approved = False
        End If

        If Home.FieldDetails_OnUpdateChkBx.Checked = True And Home.FieldDetails_OnUpdateCmbo.SelectedIndex = -1 Then
            MsgBox("Please specify action on update.")
            Approved = False
        End If

        If Home.FieldDetails_OnDeleteChkbx.Checked = True And Home.FieldDetails_OnDeleteCmbo.SelectedIndex = -1 Then
            MsgBox("Please specify action on delete.")
            Approved = False
        End If

        If Home.FieldDetails_DefValChkbx.Checked = True And Home.FieldDetails_DefFld.Text = "" Then
            MsgBox("Please specify column default value.")
            Approved = False
        End If

        If Home.FieldDetails_CheckTypeCmbo.Text = "LIKE" And Home.FieldDetails_CheckPstnCmbo.SelectedIndex = -1 Then
            MsgBox("Please specify string position for LIKE CHECK.")
            Approved = False
        End If

        Return Approved
    End Function

    Shared Function Table()
        Dim Approved As Boolean
        Approved = True

        If Home.CreateTable_NameFld.Text = "" Then
            MsgBox("Please enter table name before continuing.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function DataTypeSize()
        Dim Size As String
        If (Home.FieldDetails_ColumnTYpeCmbo.Text = "NUMERIC") Or (Home.FieldDetails_ColumnTYpeCmbo.Text = "DECIMAL") Then

            Size = "Precise"

        ElseIf (Home.FieldDetails_ColumnTYpeCmbo.Text = "DATE") Or (Home.FieldDetails_ColumnTYpeCmbo.Text = "TIME") Or (Home.FieldDetails_ColumnTYpeCmbo.Text = "INTEGER") Or (Home.FieldDetails_ColumnTYpeCmbo.Text = "BIT") Then
            Size = "NoSize"
        Else

            Size = "Integer"

        End If
        Return Size
    End Function

    Shared Function Alter_Table()
        Dim Approved As Boolean
        Approved = True

        If Home.AlterTable_TableNameFld.Text = "" Then
            MsgBox("Please enter table name before continuing.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function Rename()
        Dim Approved As Boolean
        Approved = True

        If Home.AlterTable_RenameFld.Text = "" Then
            MsgBox("Please enter new table name before continuing.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function DropColumn()
        Dim Approved As Boolean
        Approved = True

        If Home.AlterTable_DeleteColumnFld.Text = "" Then
            MsgBox("Please enter name of column to be deleted.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function Insert()

        Dim Approved As Boolean
        Approved = True

        If Home.Insert_TableNameFld.Text = "" Then
            MsgBox("Please enter name of table.")
            Approved = False
        End If

        If Home.Insert_SpecifyColumnChkbx.Checked = True And Home.Insert_SpecifyColumnFld.Text = "" Then
            MsgBox("Please enter columns.")
            Approved = False
        End If

        If Home.Insert_DataItemsFld.Text = "" Then
            MsgBox("Please enter data items.")
            Approved = False
        End If

        Return Approved
    End Function

    Shared Function Database()
        Dim Approved As Boolean
        Approved = True

        If Home.Database_NameFld.Text = "" Then
            MsgBox("Please enter name of database.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function DropTable()
        Dim Approved As Boolean
        Approved = True

        If Home.Delete_TableNameFld.Text = "" Then
            MsgBox("Please enter name of table.")
            Approved = False

        End If
        Return Approved
    End Function

    Shared Function PrimaryKey()
        Dim Approved As Boolean = True

        If Home.FieldDetails_PrimFld.Text = "" Then
            MsgBox("Please enter name(s) of primary key(s).")
            Approved = False
        End If

        Return Approved

    End Function

    Shared Function ForeignKey()
        Dim Approved As Boolean = True

        If Home.FieldDetails_ForeignKeyFld.Text = "" Then
            MsgBox("Please enter name(s) of foreign key(s).")
            Approved = False
        End If

        Return Approved

    End Function

End Class