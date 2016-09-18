Public Class Form1
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        BuildTab()
    End Sub

    Private Sub EnterCheck(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BuildTab()
        End If
    End Sub

    Private Sub BuildTab()
        Dim NewTabName As String
        NewTabName = MaterialSingleLineTextField1.Text
        TabControl1.TabPages.Add(NewTabName)
    End Sub
End Class

