Imports System.Data.OleDb
Public Class PAYMENT_2

    Private Sub Butmatr_Click(sender As Object, e As EventArgs) Handles Butmatr.Click
        If llevel.Text = "ND 2" And Combopay.SelectedItem = "Matriculation" Then
            Combopay.Refresh()
            MsgBox("This payment is meant for ND 1 students")
        ElseIf llevel.Text = "ND 1" And Combopay.SelectedItem = "Project" Then
            Combopay.Refresh()
            MsgBox("This payment is meant for ND 2")
        Else
        End If

        Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
        Dim cmd As New System.Data.OleDb.OleDbCommand
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If txtmatr.Text = "" Then
            'Refreshing all text boxes and other controls...
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    Dim c As TextBox = ctrl
                    c.Text = ""
                End If
            Next
            If Combopay.SelectedItem = Nothing Then
                MsgBox("Please choose type of payment", MsgBoxStyle.OkOnly)
            End If
            ' txtsess.ReadOnly = True
            'displaying error message...
            MsgBox("You have not entered a Matric number", MsgBoxStyle.Information, "ALERT")
        ElseIf Not IsNumeric(txtmatr.Text) Then
            MsgBox("Your input is invalid, must be a number", MsgBoxStyle.Information, "ALERT")
        Else
            Try
                'creating a connection string with microsoft access database..
                Dim dr As OleDbDataReader
                cmd.CommandText = System.Data.CommandType.Text
                'Checking the database for the matric number of the student that is currently being registered...
                Dim str As String
                Dim wrd As String
                str = " SELECT MATR, sname, fname, oname, sex, LVL, dept FROM Students WHERE MATR ='" & txtmatr.Text & "'"

                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                'con.Open()
                dr = cd.ExecuteReader
                'If matric number does exist...
                dr.Read()


                If dr("MATR") = txtmatr.Text Then

                    lsurname.Text = dr("sname").ToString
                    loname.Text = dr("fname").ToString
                    lmatric.Text = dr("MATR").ToString
                    llevel.Text = dr("LVL").ToString
                    ldept.Text = dr("dept").ToString

                    dr.Close()
                    If Combopay.SelectedItem = "Incidental" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"
                        Pict_Incidental.Visible = True
                    ElseIf Combopay.SelectedItem = "Development" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"
                        Pict_dev.Visible = True
                    ElseIf Combopay.SelectedItem = "Departmental" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"
                        Pict_DEPT.Visible = True
                    ElseIf Combopay.SelectedItem = "States Union" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"
                        Pict_SU.Visible = True
                    ElseIf Combopay.SelectedItem = "Hostel" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"

                    ElseIf Combopay.SelectedItem = "Project" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"
                        Pict_Proj.Visible = True
                    ElseIf Combopay.SelectedItem = "Matriculation" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"
                        Pict_matric.Visible = True
                    ElseIf Combopay.SelectedItem = "Graduation" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"

                    ElseIf Combopay.SelectedItem = "Transcript" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"

                    ElseIf Combopay.SelectedItem = "Acceptance" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"

                    ElseIf Combopay.SelectedItem = "SUG" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"
                        Pict_SUG.Visible = True

                    ElseIf Combopay.SelectedItem = "Medical" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"
                        Pict_MED.Visible = True

                    ElseIf Combopay.SelectedItem = "Admission" Then
                        wrd = "SELECT PName,Amount,Figure FROM Payment WHERE PName='" & Combopay.SelectedItem & "'"

                    End If
                    Dim cdd As OleDbCommand = New OleDbCommand(wrd, con)
                    dr = cdd.ExecuteReader
                    dr.Read()
                    lamount.Text = dr("Amount").ToString
                    lsum.Text = dr("Figure").ToString

                Else
                    MsgBox("The matric number is invalid or does not exits")
                End If
                'CLOSE connection...
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        End If
    End Sub
    Private Sub butprint_Click(sender As Object, e As EventArgs) Handles butprint.Click
        If lmatric.Text = "" Or lamount.Text = "" Or lsum.Text = "" Or lcash.Text = "" Or ldept.Text = "" Or llevel.Text = "" Then
            MsgBox("Please there is nothing to print")

        Else
            butsub.Visible = False
            lblmatric.Visible = False
            Combopay.Visible = False
            txtmatr.Visible = False
            Butmatr.Visible = False
            rd1.Visible = False
            rd2.Visible = False
            rd3.Visible = False
            PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
            PrintForm1.Print()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lmatric.Refresh()
        lamount.Refresh()
        lsum.Refresh()
        lcash.Refresh()
        lsurname.Refresh()
        loname.Refresh()
        lblmatric.Visible = True
        Butmatr.Visible = True
        txtmatr.Visible = True
        Combopay.Visible = True
        llevel.Refresh()
        ldept.Refresh()
        txtmatr.Refresh()
        rd1.Visible = True
        rd2.Visible = True
        rd3.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Controls.Clear()
        InitializeComponent()
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rd1.CheckedChanged
        If rd1.Checked = True Then
            Combopay.Items.Clear()
            Combopay.Items.Add("Incidental")
            Combopay.Items.Add("Development")
            Combopay.Items.Add("SUG")
            Combopay.Items.Add("Medical")
            Combopay.Items.Add("Matriculation")
            Combopay.Items.Add("States Union")
            Combopay.Items.Add("Departmental")
        Else
            Combopay.SelectedItem = Nothing
        End If
    End Sub

    Private Sub rd2_CheckedChanged(sender As Object, e As EventArgs) Handles rd2.CheckedChanged
        If rd2.Checked = True Then
            Combopay.Items.Clear()
            Combopay.Items.Add("Incidental")
            Combopay.Items.Add("Development")
            Combopay.Items.Add("SUG")
            Combopay.Items.Add("Medical")
            Combopay.Items.Add("Project")
            Combopay.Items.Add("States Union")
            Combopay.Items.Add("Departmental")
        Else
            Combopay.SelectedItem = Nothing
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles rd3.CheckedChanged
        If rd3.Checked = True Then
            Combopay.Items.Add("Hostel")
            Combopay.Items.Add("Admission")
            Combopay.Items.Add("Transcript")
       
        End If
    End Sub

    Private Sub butsub_Click(sender As Object, e As EventArgs) Handles butsub.Click
        If Combopay.SelectedItem.Equals("Incidental") Then

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
                str = " SELECT Matric FROM Incidental WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Incidental (Matric,Surname,Othernames,BankdraftNumber,Amount,SumOf,Cashier,Dat,Class,Department) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "','" & llevel.Text & "','" & ldept.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                        'IF USER CLICKS OK, SHOW THE COURSE REGISTRATION FORM.. ELSE, COTINUE WITH THE INITIAL PROCESS...

                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("Graduation") Then

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
                str = " SELECT Matric FROM Graduation WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Graduation (Matric,Surname,Othernames,Department,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("Admission") Then

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
                str = " SELECT Matric FROM Admission WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Admission (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("Hostel") Then

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
                str = " SELECT Matric FROM Hostel WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Hostel (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        ElseIf Combopay.SelectedItem.Equals("Transcript") Then

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
                str = " SELECT Matric FROM Transcript WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Transcript (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("Acceptance") Then

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
                str = " SELECT Matric FROM Acceptance WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Acceptance (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("Project") Then
            Pict_Proj.Visible = True


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
                str = " SELECT Matric FROM Project WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Project (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("Matriculation") Then
            Pict_matric.Visible = True
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
                str = " SELECT Matric FROM Matriculation WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Matriculation (Matric,Surname,Othernames,Department,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("Medical") Then
            Pict_MED.Visible = True
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
                str = " SELECT Matric FROM Medical WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Medical (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("States Union") Then
            Pict_SU.Visible = True
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
                str = " SELECT Matric FROM State_Union WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO State_Union (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                        'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                    End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                    'if insertion or connection is not successful...
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        ElseIf Combopay.SelectedItem.Equals("Development") Then
            Pict_dev.Visible = True
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
                str = " SELECT Matric FROM Development WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Development (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("Departmental") Then
            Pict_DEPT.Visible = True
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
                str = " SELECT Matric FROM Departmental WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()


                    'if the matric number does not exist, insert the student's information into the database...
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Departmental (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        ElseIf Combopay.SelectedItem.Equals("SUG") Then
            Pict_SUG.Visible = True
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
                str = " SELECT Matric FROM SUG WHERE Matric ='" & lmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = lmatric.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("You have already paid. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating the payment.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                    lmatric.Refresh()
                    lamount.Refresh()
                    lsum.Refresh()
                    lcash.Refresh()
                    lsurname.Refresh()
                    loname.Refresh()
                    lblmatric.Visible = True
                    Butmatr.Visible = True
                    txtmatr.Visible = True
                    Combopay.Visible = True
                    llevel.Refresh()
                    ldept.Refresh()
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO SUG (Matric,Surname,Othernames,Departmental,Class,Amount,SumOf,Cashier,Dat) VALUES ('" & lmatric.Text & "','" & lsurname.Text & "','" & loname.Text & "','" & ldept.Text & "','" & llevel.Text & "','" & lamount.Text & "','" & lsum.Text & "','" & lcash.Text & "','" & Inc_date.Text & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()
                    'SUCCESS MESSAGE...
                    MsgBox(lsurname.Text & " " & loname.Text & " has been successfully paid for " & Combopay.SelectedItem)
                    If MsgBox(" Thank you for your payment") Then
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        End If 'THIS 'IF' STATEMENT ends the primary one at the begining of this PRIVATE SUB...
        lblmatric.Visible = False
        Butmatr.Visible = False
        txtmatr.Visible = False
        Combopay.Visible = False
        butprint.Visible = True
        rd1.Visible = False
        rd2.Visible = False
        rd3.Visible = False
    End Sub

End Class