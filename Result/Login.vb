Imports System.Data.OleDb
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
       
        Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
        Dim cmd As New System.Data.OleDb.OleDbCommand
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            If txtuname.Text <> "" Then
                'creating a connection string with microsoft access database..
                Dim dr As OleDbDataReader
                cmd.CommandText = System.Data.CommandType.Text
                'Checking the database for the matric number of the student that is currently being registered...
                Dim str As String
                str = "SELECT Uname,Pword,Fullname FROM admin WHERE Uname ='" & txtuname.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                'con.Open()
                dr = cd.ExecuteReader
                dr.Read()
                If dr("Uname") = txtuname.Text And dr("pword") = txtpass.Text Then
                    lsname.Text = dr("Fullname").ToString

                    Me.Hide()
                    last.Show()
                Else
                    MsgBox("The Username or password that you have entered is invalid or does not exit.")
                End If
                'CLOSE connection...
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
        End Try 'ENDS the try statement...
        last.Label2.Text = Me.lsname.Text
        PAYMENT_2.lcash.Text = Me.lsname.Text
        'End If

    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        End
    End Sub

    Private Sub Chkboxview_CheckedChanged(sender As Object, e As EventArgs) Handles Chkboxview.CheckedChanged
        If Chkboxview.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AddUser.ShowDialog()
    End Sub
End Class