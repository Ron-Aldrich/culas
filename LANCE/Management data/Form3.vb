Imports System.ComponentModel.Design
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class Form3
    Dim DataAdapter As MySqlDataAdapter
    Dim Dset As DataSet
    Dim Source1 As New BindingSource




    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection("server=127.0.0.1; username=root ;password=''; database=systemdatabase;")
        Try
            conn.Open()

            Dset = New DataSet
            DataAdapter = New MySqlDataAdapter("SELECT * FROM student_information", conn)
            DataAdapter.Fill(Dset, "student_information")

            If Dset.Tables.Count > 0 Then
                Dim View As New DataView(Dset.Tables(0))
                Source1.DataSource = View
                DataGridView1.DataSource = Source1
            End If

            If conn.State = ConnectionState.Open Then
                MessageBox.Show("Connected")
            Else
                MessageBox.Show("Not connected")
            End If
        Catch ex As Exception
            MessageBox.Show("Not Connected")
        Finally
            conn.Close()

        End Try

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sq As New Form4
        sq.Show()
        Dim query = "SELECT * FROM students"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim connString = "Server=localhost;Port=3306;Database=systemdatabase;Uid=root;Pwd=;"
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query = "INSERT INTO student_information (FIRSTNAME, LASTNAME, AGE, LRN, YEARLEVEL) VALUES (@FIRSTNAME, @LASTNAME, @AGE, @LRN, @YEARLEVEL)"





                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FIRSTNAME", txtf.Text)
                    cmd.Parameters.AddWithValue("@LASTNAME", txtl.Text)
                    cmd.Parameters.AddWithValue("@AGE", txtage.Text)
                    cmd.Parameters.AddWithValue("@LRN", txtlrn.Text)
                    cmd.Parameters.AddWithValue("@YEARLEVEL", txtlevel.Text)



                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Student information added successfully!")



                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtf.Clear()
        txtm.Clear()
        txtl.Clear()
        txtd.Clear()
        txtage.Clear()
        txtp.Clear()
        txth.Clear()
        txte.Clear()
        txtlrn.Clear()
        txtlevel.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim deletes As New Form5()
        deletes.Show()
    End Sub
End Class