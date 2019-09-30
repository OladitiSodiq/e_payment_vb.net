Public Class last
     Private Sub last_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Login.lsname.Text = Me.Label2.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateAndTime.Now
        If Label3.ForeColor = Color.White Then
            Label3.ForeColor = Color.Red
        ElseIf Label3.ForeColor = Color.Red Then
            Label3.ForeColor = Color.Yellow
        ElseIf Label3.ForeColor = Color.Yellow Then
            Label3.ForeColor = Color.Green
        ElseIf Label3.ForeColor = Color.Green Then
            Label3.ForeColor = Color.Pink
        ElseIf Label3.ForeColor = Color.Pink Then
            Label3.ForeColor = Color.Blue
        ElseIf Label3.ForeColor = Color.Blue Then
            Label3.ForeColor = Color.Black
        ElseIf Label3.ForeColor = Color.Black Then
            Label3.ForeColor = Color.White
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)
        If Label3.ForeColor = Color.White Then
            Label3.ForeColor = Color.Red
        ElseIf Label3.ForeColor = Color.Red Then
            Label3.ForeColor = Color.Yellow
        ElseIf Label3.ForeColor = Color.Yellow Then
            Label3.ForeColor = Color.Green
        ElseIf Label3.ForeColor = Color.Green Then
            Label3.ForeColor = Color.Pink
        ElseIf Label3.ForeColor = Color.Pink Then
            Label3.ForeColor = Color.Blue
        ElseIf Label3.ForeColor = Color.Blue Then
            Label3.ForeColor = Color.Black
        ElseIf Label3.ForeColor = Color.Black Then
            Label3.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Visible = True
        Label5.Visible = True
        ComboBox2.Visible = True
        ComboBox3.Visible = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem.Equals("New Student") Then
            NewStudent.ShowDialog()
        ElseIf ComboBox2.SelectedItem.Equals("Search Student") Then
            search.ShowDialog()
        ElseIf ComboBox2.SelectedItem.Equals("View Students") Then
            examcom.ShowDialog()
        ElseIf ComboBox2.SelectedItem.Equals("Course Form") Then
            CourseReg.ShowDialog()
            'ElseIf ComboBox3.SelectedItem.Equals("Exit") Then
            End
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem.Equals("Make Payment") Then
            PAYMENT_2.ShowDialog()
        ElseIf ComboBox3.SelectedItem.Equals("Search Student") Then
            examcom.ShowDialog()
        ElseIf ComboBox3.SelectedItem.Equals("Course Form") Then
            CourseReg.ShowDialog()
        ElseIf ComboBox3.SelectedItem.Equals("Exit") Then
            End
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conf As String
        conf = MsgBox("YOU ARE WELCOME TO ADMINISTRATION", MsgBoxStyle.OkCancel + MsgBoxStyle.SystemModal)
        If conf = vbOK Then
            LoginForm1.ShowDialog()
           
        ElseIf conf = vbCancel Then
            MsgBox("Thank you for visiting, kindly click on DASHBOARD... Read more on the Home screen")

        End If

    End Sub
End Class