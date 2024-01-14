Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Form2
    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Form1.Visible = False
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Guna2TextBox1.Clear()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2RadioButton1.Checked = False
        Guna2RadioButton2.Checked = False
        Guna2RadioButton3.Checked = False


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Not Regex.Match(Guna2TextBox1.Text, "^[a-zA-Z\s]+$").Success Then
            MessageBox.Show("First name Invalid")
        ElseIf Not Regex.Match(Guna2TextBox7.Text, "^[a-zA-Z\s]+$").Success Then
            MessageBox.Show("last name Invalid")
        ElseIf Not Regex.Match(Guna2TextBox4.Text, "^[\w\.-]*[a-zAA-Z0-9]@[\w\.-]*[a-zA-Z0-9]\.*$").Success Then
            MessageBox.Show("Error Email")
        ElseIf Not Regex.Match(Guna2TextBox3.Text, "^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$").Success Then
            MessageBox.Show("Your Password Does Meet The Requirement")
        ElseIf Not Guna2TextBox3.Text = Guna2TextBox2.Text Then
            MessageBox.Show("Password Doest Not Match")
            ''ElseIf Not Regex.Match(Guna2TextBox5.Text, "^.*({10,})([0-9])+$").Success Then
            ' MessageBox.Show("Phone Number is Not 10 Digits")
        ElseIf Not (Guna2RadioButton1.Checked Or Guna2RadioButton2.Checked Or Guna2RadioButton3.Checked) Then
            MessageBox.Show("Kindly Select Your Gender")
        Else
            Dim F_name As String = Guna2TextBox1.Text
            Dim M_name As String = Guna2TextBox6.Text
            Dim L_name As String = Guna2TextBox7.Text
            Dim Email As String = Guna2TextBox4.Text
            Dim Pass As String = Guna2TextBox3.Text
            Dim Phono As String = Guna2TextBox5.Text
            Dim Date_Of_Birth As String = Guna2DateTimePicker1.Text

            Dim Gender As String

            If Guna2RadioButton1.Checked Then
                Gender = "Male"
            ElseIf Guna2RadioButton2.Checked Then
                Gender = "Female"
            ElseIf Guna2RadioButton3.Checked Then
                Gender = "Other"
            End If
            Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\shrey\source\repos\Hotel_Management_System_Project\Hotel_System.mdb")
            Dim sql As String
            Form1.Show()

            Try
                conn.Open()
                sql = "INSERT INTO [customer_details] ([F_Name],[M_Name],[L_Name],[Email],[Pass],[Phone_no],[Date_Of_Birth],[Gender])
                        VALUES (@F_name,@M_name,@L_nam,@Email,@Pass,@Phono,@Date_Of_Birth,@Gender);"
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@F_name", F_name)
                cmd.Parameters.AddWithValue("@M_name", M_name)
                cmd.Parameters.AddWithValue("@L_name", L_name)
                cmd.Parameters.AddWithValue("@Email", Email)
                cmd.Parameters.AddWithValue("@Pass", Pass)
                cmd.Parameters.AddWithValue("@Phono", Phono)
                cmd.Parameters.AddWithValue("@Date_Of_Birth", Date_Of_Birth)
                cmd.Parameters.AddWithValue("@Gender", Gender)
                cmd.ExecuteNonQuery()



            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
            Me.Close()


        End If





    End Sub


End Class