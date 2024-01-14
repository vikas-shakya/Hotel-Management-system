Imports System.Data.OleDb

Public Class Form3
    Private Function Calculate(ByVal quantity As Integer, ByVal price As Integer)
        Return quantity * price
    End Function
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim SelectedItems As String
        Dim Total, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 As Integer
        Dim Quan1, Quan2, Quan3, Quan4, Quan5, Quan6, Quan7, Quan8, Quan9, Quan10 As Integer
        SelectedItems = ""
        Total = 0
        If Guna2CheckBox1.Checked Then
            SelectedItems = "Butter Chicken "
            Quan1 = Val(Guna2ComboBox1.Text)
            p1 = 180
            Total += Calculate(Quan1, p1)
            Form4.Guna2HtmlLabel6.Text = "Butter Chicken"
            Form4.Guna2HtmlLabel16.Text = Quan1
            Form4.Guna2HtmlLabel26.Text = p1
            Form4.Guna2HtmlLabel36.Text = Calculate(Quan1, p1)
        End If
        If Guna2CheckBox2.Checked Then
            SelectedItems &= "Checken Tandoori "
            Quan2 = Val(Guna2ComboBox2.Text)
            p2 = 320
            Total += Calculate(Quan2, p2)
            Form4.Guna2HtmlLabel7.Text = "Chicken Tandoori"
            Form4.Guna2HtmlLabel17.Text = Quan2
            Form4.Guna2HtmlLabel27.Text = p2
            Form4.Guna2HtmlLabel37.Text = Calculate(Quan2, p2)
        End If
        If Guna2CheckBox3.Checked Then
            SelectedItems &= "Veg Fried Rice "
            Quan3 = Val(Guna2ComboBox3.Text)
            p3 = 100
            Total += Calculate(Quan3, p3)
            Form4.Guna2HtmlLabel8.Text = "Veg Fried Rice"
            Form4.Guna2HtmlLabel18.Text = Quan3
            Form4.Guna2HtmlLabel28.Text = p3
            Form4.Guna2HtmlLabel38.Text = Calculate(Quan3, p3)
        End If
        If Guna2CheckBox4.Checked Then
            SelectedItems &= "Paneer Tikka "
            Quan4 = Val(Guna2ComboBox4.Text)
            p4 = 160
            Total += Calculate(Quan4, p4)
            Form4.Guna2HtmlLabel9.Text = "Paneer Tikka"
            Form4.Guna2HtmlLabel19.Text = Quan4
            Form4.Guna2HtmlLabel29.Text = p4
            Form4.Guna2HtmlLabel39.Text = Calculate(Quan4, p4)
        End If
        If Guna2CheckBox5.Checked Then
            SelectedItems &= "Palak Paneer "
            Quan5 = Val(Guna2ComboBox5.Text)
            p5 = 160
            Total += Calculate(Quan5, p5)
            Form4.Guna2HtmlLabel10.Text = "Palak Paneer"
            Form4.Guna2HtmlLabel20.Text = Quan5
            Form4.Guna2HtmlLabel30.Text = p5
            Form4.Guna2HtmlLabel40.Text = Calculate(Quan5, p5)
        End If
        If Guna2CheckBox6.Checked Then
            SelectedItems &= "Margherita pizza "
            Quan6 = Val(Guna2ComboBox6.Text)
            p6 = 450
            Total += Calculate(Quan6, p6)
            Form4.Guna2HtmlLabel11.Text = "Margherita pizza"
            Form4.Guna2HtmlLabel21.Text = Quan6
            Form4.Guna2HtmlLabel31.Text = p6
            Form4.Guna2HtmlLabel41.Text = Calculate(Quan6, p6)
        End If
        If Guna2CheckBox7.Checked Then
            SelectedItems &= "BBq Chicken Pizza "
            Quan7 = Val(Guna2ComboBox7.Text)
            p7 = 350
            Total += Calculate(Quan7, p7)
            Form4.Guna2HtmlLabel12.Text = "BBq Chicken Pizza"
            Form4.Guna2HtmlLabel22.Text = Quan7
            Form4.Guna2HtmlLabel32.Text = p7
            Form4.Guna2HtmlLabel42.Text = Calculate(Quan7, p7)
        End If
        If Guna2CheckBox8.Checked Then
            SelectedItems &= "Pepperoni Pizza "
            Quan8 = Val(Guna2ComboBox8.Text)
            p8 = 280
            Total += Calculate(Quan8, p8)
            Form4.Guna2HtmlLabel13.Text = "Pepperoni Pizza"
            Form4.Guna2HtmlLabel23.Text = Quan8
            Form4.Guna2HtmlLabel33.Text = p8
            Form4.Guna2HtmlLabel43.Text = Calculate(Quan8, p8)
        End If
        If Guna2CheckBox9.Checked Then
            SelectedItems &= "Cheese N' Corn Pizza "
            Quan9 = Val(Guna2ComboBox9.Text)
            p9 = 200
            Total += Calculate(Quan9, p9)
            Form4.Guna2HtmlLabel14.Text = "Butter Chicken"
            Form4.Guna2HtmlLabel24.Text = Quan9
            Form4.Guna2HtmlLabel34.Text = p9
            Form4.Guna2HtmlLabel44.Text = Calculate(Quan9, p9)
        End If
        If Guna2CheckBox10.Checked Then
            SelectedItems &= "Double Cheese Margherita "
            Quan10 = Val(Guna2ComboBox10.Text)
            p10 = 600
            Total += Calculate(Quan10, p10)
            Form4.Guna2HtmlLabel15.Text = "Double Cheese \n
                                                Margherita"
            Form4.Guna2HtmlLabel25.Text = Quan10
            Form4.Guna2HtmlLabel35.Text = p10
            Form4.Guna2HtmlLabel45.Text = Calculate(Quan10, p10)
        End If
        Form4.Guna2HtmlLabel47.Text = Total

        Form4.Show()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Visible = False
        Guna2ComboBox1.Text = 1
        Guna2ComboBox2.Text = 1
        Guna2ComboBox3.Text = 1
        Guna2ComboBox4.Text = 1
        Guna2ComboBox5.Text = 1
        Guna2ComboBox6.Text = 1
        Guna2ComboBox7.Text = 1
        Guna2ComboBox8.Text = 1
        Guna2ComboBox9.Text = 1
        Guna2ComboBox10.Text = 1
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub
End Class