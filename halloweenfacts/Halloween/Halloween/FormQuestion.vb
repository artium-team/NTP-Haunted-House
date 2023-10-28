Public Class FormQuestion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "skeleton" Then
            Me.Hide()
            FormMain.Show()
        ElseIf TextBox1.Text = "Skeleton" Then
            Me.Hide()
            FormMain.Show()
        Else

        End If
    End Sub
End Class