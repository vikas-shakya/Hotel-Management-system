Imports System.Data.OleDb

Public Class Form1

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Email As String = Guna2TextBox1.Text

        Dim password As String = Guna2TextBox2.Text
        'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\shrey\source\repos\Hotel_Management_System_Project\Hotel_System.mdb
        'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\vikas\OneDrive\Documents\vb.net\Hotel_Management_System_Project\Hotel_System.mdb
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\shrey\source\repos\Hotel_Management_System_Project\Hotel_System.mdb")

        Dim sql As String
        Dim dr As OleDbDataReader

        Try
            conn.Open()
            sql = "select * from [customer_details] where [Email]=@Email and [Pass]=@password;"
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Email", Email)
            cmd.Parameters.AddWithValue("@password", password)
            dr = cmd.ExecuteReader()

            If dr.Read() = True Then
                MessageBox.Show("Login Sucessfully")
                Form3.Show()

            Else
                MessageBox.Show("Invalid Credentials")

            End If
        Catch ex As Exception

        End Try




    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Form2.Show()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Visible = False

    End Sub


End Class
