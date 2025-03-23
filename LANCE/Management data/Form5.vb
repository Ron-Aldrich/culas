Imports MySql.Data.MySqlClient

Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If text.Text = "" Then
            MessageBox.Show("Please enter the ID number of the student to delete.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim conn As New MySqlConnection("server=127.0.0.1; username=root; password=; database=systemdatabase; ")
        Try
            conn.Open()

            Dim query As String = "DELETE FROM student_information WHERE LRN = @LRN"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@LRN", text.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Student record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                MessageBox.Show("No record found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()

        End Try
    End Sub
End Class