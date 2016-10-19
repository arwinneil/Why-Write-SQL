Friend Class Initialise

#Region "New Table Initialisers"
    Shared Sub NewTable()


        NewField()

        Keys()

        Check()

        Constraints()

    End Sub
    Shared Sub NewField()


        Keys()

        Check()

        Constraints()
    End Sub
    Shared Sub ReferenceComponents()


    End Sub
    Shared Sub Keys()
        ReferenceComponents()
        Constraints()
    End Sub
    Shared Sub Check()
    End Sub
    Shared Sub Constraints()
    End Sub

#End Region

    Shared Sub DropTable()

        Home.TableName.Text = ""
    End Sub
    Shared Sub Database()
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