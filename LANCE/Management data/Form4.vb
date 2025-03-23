Imports MySql.Data.MySqlClient
Public Class Form4
    Dim DataAdapter As MySqlDataAdapter
    Dim Dset As DataSet
    Dim Source1 As New BindingSource
    Private Sub studentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection("server=127.0.0.1; username=root; password=''; database=systemdatabase;")
        conn.Open()


        Dset = New DataSet
        DataAdapter = New MySqlDataAdapter("SELECT * FROM student_information", conn)
        DataAdapter.Fill(Dset, "student_information")

        If Dset.Tables.Count > 0 Then
            Dim View As New DataView(Dset.Tables(0))
            Source1.DataSource = View
            DataGridView1.DataSource = Source1
        Else
            MessageBox.Show("No data found in student_password table.")
        End If

        conn.Close()
    End Sub
End Class