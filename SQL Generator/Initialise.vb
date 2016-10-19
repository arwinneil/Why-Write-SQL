Friend Class Initialise


#Region "New Table Initialisers"
    Shared Sub NewTable()

            Home.CreateButton.Enabled = True
            Home.NewTableField.Text = ""
            Home.NewTableField.Enabled = True

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
            Home.Precision.Value = 0
            Home.Scale_.Value = 0
            Home.DefaultValue.Text = ""
            Home.Default_Value_Checkbox.Checked = False
            Home.Formula.Checked = False
            Home.Formula.Enabled = False

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
            Home.ConstraintGroup.Enabled = True
            Home.PrimCheck.Checked = False
            Home.NotNull.Checked = False
            Home.Unique.Checked = False
        End Sub

#End Region

        Shared Sub DropTable()

            Home.TableName.Text = ""
        End Sub
        Shared Sub Database()
            Home.DatabaseName.Text = ""
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
