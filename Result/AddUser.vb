Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Win32
Public Class AddUser
    
    Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
    Dim cmd As New System.Data.OleDb.OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
      
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = System.Data.CommandType.Text
        Dim str As String

        If txtuname.Text = "" Then
            MsgBox("Please, Enter your valid username", MsgBoxStyle.Information, "INFORMATION")
        Else
            str = " SELECT Uname,Question FROM admin WHERE Uname ='" & txtuname.Text & "'"
            Dim cd As OleDbCommand = New OleDbCommand(str, con)
            dr = cd.ExecuteReader
            If dr.Read() = True Then
                lblsecque.Text = dr("Question").ToString
                Do Until Me.Height = 400

                    Me.Height += 1
                    System.Threading.Thread.Sleep(10)
                Loop
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = System.Data.CommandType.Text
        Dim str As String
        If txtanswer.Text = "" Then
            MsgBox("Please, Enter your valid username", MsgBoxStyle.Information, "INFORMATION")
        End If
        str = " SELECT Uname,Answer,Pword FROM Admin WHERE Answer ='" & txtanswer.Text & "'"
        Dim cd As OleDbCommand = New OleDbCommand(str, con)
        dr = cd.ExecuteReader
        If dr.Read() = True Then
            lblpwrd.Text = dr("Pword").ToString
            Do Until Me.Height = 470
                Me.Height += 1
                System.Threading.Thread.Sleep(10)
            Loop
        Else
            MsgBox("Your answer is incorrect", MsgBoxStyle.Information, "INFORMATION")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
  
        Me.Close()

    End Sub
End Class