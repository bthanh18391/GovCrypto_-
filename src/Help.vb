Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles Me.Load

        '### Sprache laden
        If Parameter.cbENG = "No" Then
            RichTextBox2.Visible = False
            RichTextBox1.Visible = True
        Else
            RichTextBox2.Visible = True
            RichTextBox1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class