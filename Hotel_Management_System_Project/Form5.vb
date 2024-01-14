Public Class Form5
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""

        TrackBar1.Value = 0
        DrakeUIListBox1.Items.Clear()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form4.Visible = False


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim fq, sq, cle, acc, rate As String
        'fq'
        fq = ComboBox1.Text

        'sq'
        sq = ComboBox2.Text

        'cle'
        cle = ComboBox3.Text

        'acc'
        acc = ComboBox4.Text

        'rating'
        rate = TrackBar1.Value.ToString()
        'Output'
        DrakeUIListBox1.Items.Add(Guna2DateTimePicker1.Text)
        DrakeUIListBox1.Items.Add(fq)
        DrakeUIListBox1.Items.Add(sq)
        DrakeUIListBox1.Items.Add(cle)
        DrakeUIListBox1.Items.Add(acc)
        DrakeUIListBox1.Items.Add(rate)
        MessageBox.Show("Thank You For Your Feedback!!")
    End Sub
End Class