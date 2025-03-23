Public Class Form2
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim user As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If user = "lance" AndAlso password = "marianbantot" Then
            MessageBox.Show("Login Successful")
            Form3.Show()
        Else
            MessageBox.Show("Incorrect Password/Username")
            Form3.Hide()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class