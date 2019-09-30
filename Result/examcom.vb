Imports System.Data.OleDb
Public Class examcom

    Private Sub btnnext_Click(sender As Object, e As EventArgs)
        Me.Close()
        last.Show()
    End Sub


    Private Sub VIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWToolStripMenuItem.Click
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
            sSQL = "SELECT SNAME,FNAME,ONAME,SEX,LVL,DEPT,MATR,YR,PHONE,EMAIL,LGA,DOB,DEPARTMENT,STATE,ADDRESS,MARITAL,RELIGION,NEXT_OF_KIN_NAME,NEXT_OF_KIN_ADDRESS,NEXT_OF_KIN_EMAIL,NEXT_OF_KIN_PHONE, HOSTEL FROM Students"
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

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class