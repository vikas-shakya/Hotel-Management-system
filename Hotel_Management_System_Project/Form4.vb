Imports System.Data.OleDb

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Visible = False

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        MessageBox.Show("Thank You For Purchasing!!")
        Form5.Show()



    End Sub


End Class