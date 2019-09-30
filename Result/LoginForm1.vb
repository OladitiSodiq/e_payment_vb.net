Imports System.Data.OleDb
Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
        Dim cmd As New System.Data.OleDb.OleDbCommand
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try
            If UsernameTextBox.Text <> "" Then
                'creating a connection string with microsoft access database..
                Dim dr As OleDbDataReader
                cmd.CommandText = System.Data.CommandType.Text
                'Checking the database for the matric number of the student that is currently being registered...
                Dim str As String
                str = "SELECT Uname,Pword,Fullname,Add_As FROM admin WHERE Uname ='" & UsernameTextBox.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                'con.Open()
                dr = cd.ExecuteReader
                dr.Read()
                If dr("Add_As") = "ADMIN" Then
                    lname.Text = dr("Fullname").ToString
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Me.Close()
                    last.Show()
                    ADDITION.Show()
                Else
                    MsgBox("You are just a user not Admin.")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Me.Close()
                    last.Show()
                End If
                'CLOSE connection...
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
        End Try 'ENDS the try statement...
   
        'End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
