Friend Class Animation
    Shared Sub Close(Form As Object)

        Do
            Form.Opacity = Form.Opacity - 0.02
            System.Threading.Thread.Sleep(4)
        Loop Until Form.Opacity = 0

    End Sub
End Class
