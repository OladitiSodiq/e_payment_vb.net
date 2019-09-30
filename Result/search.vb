Imports System.Data.OleDb
Public Class search

    Private Sub butsearch_Click(sender As Object, e As EventArgs) Handles butsearch.Click
        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                'creating a connection string with microsoft access database..
                Dim dr As OleDbDataReader
                cmd.CommandText = System.Data.CommandType.Text
                'Checking the database for the matric number of the student that is currently being registered...
                Dim str As String
                str = " SELECT MATR, sname, fname, oname, dept,sex,LVL,YR,PHONE,EMAIL,LGA,STATE,ADDRESS,MARITAL,RELIGION,DOB FROM Students WHERE MATR ='" & txtmatric.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                'con.Open()
                dr = cd.ExecuteReader
                'If matric number does exist...
                dr.Read()

                If dr("MATR") = txtmatric.Text Then
                    'ENDS ALL GRAFIXX...

                    'LOADING TEXTBOXES WITH MATRIC NUMBER'S RELATED INFORMATION AS SEEN IN THE DATABASE...
                    txtsur.Text = dr("sname").ToString
                    txtfname.Text = dr("fname").ToString
                    txtoname.Text = dr("oname").ToString
                    txtdept.Text = dr("dept").ToString
                    txtsex.Text = dr("sex").ToString
                    txtlevel.Text = dr("LVL").ToString
                    txtyear.Text = dr("YR").ToString
                    txtphone.Text = dr("PHONE").ToString
                    txtemail.Text = dr("EMAIL").ToString
                    txtlga.Text = dr("LGA").ToString
                    txtstate.Text = dr("STATE").ToString
                    txtadd.Text = dr("ADDRESS").ToString
                    txtmarital.Text = dr("MARITAL").ToString
                    txtrel.Text = dr("RELIGION").ToString
                    txtdob.Text = dr("DOB").ToString

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

    Private Sub butpay_Click(sender As Object, e As EventArgs) Handles butpay.Click
            If txtmatric.Text = "" Then
                MsgBox("You have to provide your Matric Number")
            ElseIf Not IsNumeric(txtmatric.Text) Then
                MsgBox("Your Matric. Number must be in Numeric")
            Else
                Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
                Dim cmd As New System.Data.OleDb.OleDbCommand
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Try
                    If txtinc.Text = "" Then
                        'creating a connection string with microsoft access database..
                        Dim dr As OleDbDataReader
                        cmd.CommandText = System.Data.CommandType.Text
                        'Checking the database for the matric number of the student that is currently being registered...
                        Dim str As String
                    str = " SELECT Matric,Amount FROM Incidental WHERE Matric ='" & txtmatric.Text & "'"
                        Dim cd As OleDbCommand = New OleDbCommand(str, con)
                        'con.Open()
                        dr = cd.ExecuteReader
                        dr.Read()
                        If dr("Matric") = txtmatric.Text Then
                        txtinc.Text = dr("Amount").ToString
                        Else
                            MsgBox("The matric number is invalid or does not exits")
                        End If
                        'CLOSE connection...
                        con.Close()
                    End If
                Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR INCIDENTAL FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        End If

        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtdev.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Development WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtdev.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR DEVELOPMENT FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        End If

        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtdeplevy.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Departmental WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtdeplevy.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR DEPARTMENTAL FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If


        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtacc.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Acceptance WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtacc.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR ACCEPTANCE FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If


        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtadm.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Admission WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtadm.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR ADMISSION FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If


        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txttranscript.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Transcript WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txttranscript.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR TRANSCRIPT FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If


        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtproj.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Project WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtproj.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR PROJECT FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If



        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtstatelevy.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM State_Union WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtstatelevy.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR STATE UNION FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If



        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txthostel.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Hostel WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txthostel.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR HOSTEL FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If


        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtmatrlevy.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Matriculation WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtmatrlevy.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR MATRICULATION FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If

        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtmed.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM Medical WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtmed.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR MEDICAL FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If



        If txtmatric.Text = "" Then
            MsgBox("You have to provide your Matric Number")
        ElseIf Not IsNumeric(txtmatric.Text) Then
            MsgBox("Your Matric. Number must be in Numeric")
        Else
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Try
                If txtsug.Text = "" Then
                    'creating a connection string with microsoft access database..
                    Dim dr As OleDbDataReader
                    cmd.CommandText = System.Data.CommandType.Text
                    'Checking the database for the matric number of the student that is currently being registered...
                    Dim str As String
                    str = " SELECT Matric,Amount FROM SUG WHERE Matric ='" & txtmatric.Text & "'"
                    Dim cd As OleDbCommand = New OleDbCommand(str, con)
                    'con.Open()
                    dr = cd.ExecuteReader
                    dr.Read()
                    If dr("Matric") = txtmatric.Text Then
                        txtsug.Text = dr("Amount").ToString
                    Else
                        MsgBox("The matric number is invalid or does not exits")
                    End If
                    'CLOSE connection...
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("YOU HAVE NOT PAY YOUR S.U. G FEE", MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        last.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c, d, f, g, h, i, j, k, l, m As Integer
        a = Val(txtadm.Text)
        b = Val(txtdeplevy.Text)
        c = Val(txtdev.Text)
        d = Val(txtinc.Text)
        f = Val(txtmatrlevy.Text)
        g = Val(txtproj.Text)
        h = Val(txtstatelevy.Text)
        i = Val(txtsug.Text)
        j = Val(txttranscript.Text)
        k = Val(txthostel.Text)
        l = Val(txtacc.Text)
        m = Val(txtmed.Text)
        txttotal.Text = a + b + c + d + f + g + h + i + j + k + l + m
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtacc.Clear()
        txtadd.Clear()
        txtadm.Clear()
        txtdeplevy.Clear()
        txtdept.Clear()
        txtdob.Clear()
        txtemail.Clear()
        txtfname.Clear()
        txthostel.Clear()
        txtinc.Clear()
        txtlevel.Clear()
        txtlga.Clear()
        txtmarital.Clear()
        txtmatric.Clear()
        txtmatrlevy.Clear()
        txtmed.Clear()
        txtoname.Clear()
        txtphone.Clear()
        txtproj.Clear()
        txtrel.Clear()
        txtsex.Clear()
        txtstate.Clear()
        txtstatelevy.Clear()
        txtsug.Clear()
        txtsur.Clear()
        txttotal.Clear()
        txttranscript.Clear()
        txtyear.Clear()
    End Sub

End Class