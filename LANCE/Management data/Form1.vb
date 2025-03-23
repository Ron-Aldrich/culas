Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label3.Text = ProgressBar1.Value & "%"
        If (ProgressBar1.Value = 100) Then
            Me.Hide()
            Form2.Show()
            Timer1.Enabled = False
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
End Class
