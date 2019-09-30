Imports System.Data.OleDb
Public Class ADDITION

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BUTSUBMIT.Click
        Try
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            'Checking the state of the connection.. Open the connection if it is currently closed...
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New System.Data.OleDb.OleDbCommand
            'Dim dr As OleDbDataReader
            cmd.CommandText = System.Data.CommandType.Text
            cmd.CommandText = "INSERT INTO Department (Dept,Course,Code,Unit,Semester,Yr) VALUES ('" & txtdpt.Text & "','" & cos1.Text & "','" & cod1.Text & "','" & un1.Text & "','" & cbsem.SelectedItem & "','" & cbyr.SelectedItem & "')"
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            'CLOSING the connection after a successful student registration...
            con.Close()
            'SUCCESS MESSAGE...
            MsgBox("You have successfully add " & cos1.Text & " with Course code" & cod1.Text & " and unit of " & un1.Text & " to the department of " & txtdpt.Text & " in " & cbsem.SelectedItem)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
        End Try 'ENDS the try statement...
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtdpt.Text = ""
        cos1.Text = ""
        cod1.Text = ""
        un1.Text = ""
        cbsem.SelectedItem = Nothing
        cbyr.SelectedItem = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtdpt.Text = ""
        cos1.Text = ""
        cod1.Text = ""
        un1.Text = ""
        cbsem.SelectedItem = Nothing
        cbyr.SelectedItem = Nothing
        Me.Hide()
        last.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            'Checking the state of the connection.. Open the connection if it is currently closed...
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New System.Data.OleDb.OleDbCommand
            'Dim dr As OleDbDataReader
            cmd.CommandText = System.Data.CommandType.Text
            cmd.CommandText = "INSERT INTO Payment (PName,Amount,Figure,Semester,Yr) VALUES ('" & txtpat.Text & "','" & txtamount.Text & "','" & txtfig.Text & "','" & txtsem.SelectedItem & "','" & txtyr.SelectedItem & "')"
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            'CLOSING the connection after a successful student registration...
            con.Close()
            'SUCCESS MESSAGE...
            MsgBox(txtpat.Text & " " & txtamount.Text & " has been successfully paid for " & txtfig.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
        End Try 'ENDS the try statement...
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If txtpassword.Text <> txtconfrm.Text Then
            txtpassword.Clear()
            txtconfrm.Clear()
            MsgBox("Your Password didnt not match, may be you make it show")
        Else

            Try
                Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
                'Checking the state of the connection.. Open the connection if it is currently closed...
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim cmd As New System.Data.OleDb.OleDbCommand
                'Dim dr As OleDbDataReader
                cmd.CommandText = System.Data.CommandType.Text
                cmd.CommandText = "INSERT INTO admin (Uname,Pword,Fullname,Confirm_Password,Add_As,Phone_No,Question,Answer) VALUES ('" & txtuname.Text & "','" & txtpassword.Text & "','" & txtfname.Text & "','" & txtconfrm.Text & "','" & txtadd.SelectedItem & "','" & txtphone.Text & "','" & cbsecret.SelectedItem & "','" & txtanswer.Text & "')"
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                'CLOSING the connection after a successful student registration...
                con.Close()
                'SUCCESS MESSAGE...
                MsgBox(txtfname.Text & " with username " & txtuname.Text & " has been successfully add as " & txtadd.SelectedItem)
                txtuname.Text = ""
                txtpassword.Text = ""
                txtfname.Text = ""
                txtconfrm.Text = ""
                txtadd.Text = ""
                txtphone.Text = ""
                cbsecret.SelectedItem = Nothing
                txtanswer.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtuname.Text = ""
        txtpassword.Text = ""
        txtfname.Text = ""
        txtconfrm.Text = ""
        txtadd.Text = ""
        txtphone.Text = ""
        cbsecret.SelectedItem = Nothing
        txtanswer.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If LinkLabel1.Enabled = True Then
            txtpassword.PasswordChar = ""
            txtconfrm.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
            txtconfrm.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LinkLabel1.Enabled = True Then
            txtpassword.PasswordChar = "*"
            txtconfrm.PasswordChar = "*"
        Else
            txtpassword.PasswordChar = ""
            txtconfrm.PasswordChar = ""
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtuname.Text = ""
        txtpassword.Text = ""
        txtfname.Text = ""
        txtconfrm.Text = ""
        txtadd.Text = ""
        txtphone.Text = ""
        cbsecret.SelectedItem = Nothing
        txtanswer.Text = ""
        Me.Hide()
        last.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtpat.Clear()
        txtamount.Clear()
        txtfig.Clear()
        txtyr.SelectedItem = Nothing
        txtsem.SelectedItem = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtpat.Clear()
        txtamount.Clear()
        txtfig.Clear()
        txtyr.SelectedItem = Nothing
        txtsem.SelectedItem = Nothing
        last.Show()
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim sSQL As String = String.Empty


        Try

            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sSQL = "SELECT PName,Amount,Figure FROM Payment"
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
            If dt.Rows.Count = 0 Then
                MsgBox("No Record Found")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim sSQL As String = String.Empty


        Try

            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sSQL = "SELECT Dept,Course,Code,Unit,Semester,Yr FROM Department"
            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
            If dt.Rows.Count = 0 Then
                MsgBox("No Record Found")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub
End Class