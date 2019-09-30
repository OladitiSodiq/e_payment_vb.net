Imports System.Data.OleDb
Public Class CourseReg
    Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
    Dim cmd As New System.Data.OleDb.OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnver.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        txtdept.Refresh()
        txtfname.Refresh()
        txtoname.Refresh()
        txtsname.Refresh()
        If txtmatric.Text = "" Then
            'Clearing all text boxes and other controls...
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    Dim c As TextBox = ctrl
                    c.Text = ""
                End If
            Next
            'displaying error message...
            MsgBox("You have not entered a Matric number", MsgBoxStyle.Information, "ALERT")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your input is invalid, must be a number", MsgBoxStyle.Information, "ALERT")
        Else
            Try
                'creating a connection string with microsoft access database..
                Dim dr As OleDbDataReader
                cmd.CommandText = System.Data.CommandType.Text
                'Checking the database for the matric number of the student that is currently being registered...
                Dim str As String
                str = " SELECT MATR, sname, fname, oname, dept,YR FROM Students WHERE MATR ='" & txtmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                'con.Open()
                dr = cd.ExecuteReader
                'If matric number does exist...
                dr.Read()
               
                If dr("MATR") = txtmatric.Text Then
                    Me.BackgroundImage = Nothing
                   
                    lblmatr.Visible = False
                    lblmatr.Visible = False
                    txtmatric.Visible = False
                    btnver.Visible = False
                    lblclass.Visible = True
                    CBclass.Visible = True

                    lblsess.Visible = True
                    txtsess.Visible = True
                    btnsub.Visible = True
                    btnclose.Visible = True
                    Label1.Visible = True
                    Label2.Visible = True
                    Label3.Visible = True
                    Button1.Visible = True
                    Label4.Visible = True
                    'PictureBox1.Visible = True
                    txtdept.Visible = True
                    txtfname.Visible = True
                    txtoname.Visible = True
                    txtsname.Visible = True
                    lblsname.Visible = True
                    lbldept.Visible = True
                    lbloname.Visible = True
                    lblfname.Visible = True
                    Butref.Visible = True
                    lblsem.Visible = True
                    CBsem.Visible = True



                    'ENDS ALL GRAFIXX..
                    'LOADING TEXTBOXES WITH MATRIC NUMBER'S RELATED INFORMATION AS SEEN IN THE DATABASE...
                    txtsname.Text = dr("sname").ToString
                    txtfname.Text = dr("fname").ToString
                    txtoname.Text = dr("oname").ToString
                    txtdept.Text = dr("dept").ToString
                    txtsess.Text = dr("YR").ToString
                Else
                    MsgBox("The matric number is invalid or does not exits")
                End If
                'CLOSE connection...
                con.Close()
            Catch ex As Exception
                MsgBox("The matric number is not valid", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Controls.Clear()
        InitializeComponent()
        Me.Close()
    End Sub
    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If CBclass.SelectedItem = "" Or CBsem.SelectedItem = "" Then
            MsgBox("You need to select a class and semester to continue. Please, ensure you have selected both options to continue", MsgBoxStyle.Information, "INFORMATION")
        Else
            Dim cmd As New OleDb.OleDbCommand("SELECT Dept,Course,Code,Unit,Semester,Yr FROM Department WHERE Dept ='" & txtdept.Text & "' and Yr ='" & CBclass.SelectedItem & "' and Semester ='" & CBsem.SelectedItem & "'", con)
            cmd.ExecuteNonQuery()
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader
            If reader.HasRows Then
                lblsess.Visible = True
                txtsess.Visible = True
                DataGridView1.Visible = True
                btnclose.Visible = True
                DataGridView1.Rows.Clear()
                Dim c As Integer = 0
                While (reader.Read())
                    Dim title, code, unit As String
                    title = Convert.ToString(reader("Course"))
                    code = Convert.ToString(reader("Code"))
                    unit = Convert.ToString(reader("Unit"))
                    Dim n As Integer = DataGridView1.Rows.Add()
                    DataGridView1.Rows.Item(n).Cells(0).Value = title
                    DataGridView1.Rows.Item(n).Cells(1).Value = code
                    DataGridView1.Rows.Item(n).Cells(2).Value = unit
                End While
                con.Close()
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'trying to connect to the database and then execute some some subsequent processes...
        Try
            'creating a connection string with microsoft access database...
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            'Checking the state of the connection.. Open the connection if it is currently closed...
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New System.Data.OleDb.OleDbCommand
            Dim dr As OleDbDataReader
            cmd.CommandText = System.Data.CommandType.Text
            'Checking the database for the matric number of the student that is currently being registered...
            Dim str As String
            str = " SELECT Matric FROM Incidental WHERE Matric ='" & txtmatric.Text & "'"
            str = " SELECT Matric FROM Development WHERE Matric ='" & txtmatric.Text & "'"
            str = " SELECT Matric FROM project WHERE Matric ='" & txtmatric.Text & "'"
            str = " SELECT Matric FROM Matriculation WHERE Matric ='" & txtmatric.Text & "'"
            str = " SELECT Matric FROM State_Union WHERE Matric ='" & txtmatric.Text & "'"
            str = " SELECT Matric FROM SUG WHERE Matric ='" & txtmatric.Text & "'"
            str = " SELECT Matric FROM Departmental WHERE Matric ='" & txtmatric.Text & "'"
            str = " SELECT Matric FROM Medical WHERE Matric ='" & txtmatric.Text & "'"

            Dim cd As OleDbCommand = New OleDbCommand(str, con)
            dr = cd.ExecuteReader
            'if the matric number exists... display a message...
            If dr.Read() = txtmatric.Text Then ' CHECKING for student's existence...
                'ERROR MESSAGE...
                MsgBox(txtsname.Text & " " & txtfname.Text & " with matriculation " & txtmatric.Text & " thank you for your payment and take your copy")
                'if the matric number does not exist, insert the student's information into the database...
                PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
                PrintForm1.Print()

            Else
                MsgBox(txtsname.Text & " " & txtfname.Text & " with matriculation " & txtmatric.Text & " you have not completed your payment please")


                'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
            End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
            'if insertion or connection is not successful...
            Butref.Visible = True
            Button1.Visible = True
            btnclose.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
        End Try 'ENDS the try statement...
    End Sub

    Private Sub Butref_Click(sender As Object, e As EventArgs) Handles Butref.Click
        CBclass.SelectedItem = Nothing
        txtsess.Refresh()
        ' PictureBox1.Visible = False
        
        'txt14.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        lbldept.Visible = False
        lblfname.Visible = False
        lblsname.Visible = False
        lbloname.Visible = False
        txtdept.Visible = False
        txtsname.Visible = False
        txtfname.Visible = False
        txtoname.Visible = False
        lblclass.Visible = False
        lblsess.Visible = False
        CBclass.Visible = False
        txtsess.Visible = False
        btnsub.Visible = False
        btnclose.Visible = False
        Button1.Visible = False
        lblmatr.Visible = True
        btnver.Visible = True
        txtmatric.Visible = True
        txtmatric.Clear()



    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CourseReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.ProjectDataSet.Department)

    End Sub
End Class