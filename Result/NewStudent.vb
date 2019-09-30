Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class NewStudent
    '"C:\Users\Matthew\app\e payment - C\Result\bin\Debug\Project.accdb"
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb"
    Dim Myconn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim Source1 As New BindingSource
    Dim aspid As String
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'clear all fields first then close the window...
        txtfname.Text = ""
        txtmatr.Text = ""
        txtonames.Text = ""
        txtsname.Text = ""
        txtyr.Text = ""
        CBdept.SelectedItem = Nothing
        CBlevel.SelectedItem = Nothing
        CBsex.SelectedItem = Nothing
        Me.Close()
        last.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        last.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'checking if all information has been provided...
        If txtsname.Text = "" Or txtfname.Text = "" Or txtonames.Text = "" Or txtmatr.Text = "" Or txtyr.Text = "" Or CBdept.SelectedItem = Nothing Or CBlevel.SelectedItem = Nothing Or CBsex.SelectedItem = Nothing Then
            MsgBox("You need to enter all details", MsgBoxStyle.Information, "ALERT")
            'checking if the entered matric number is a=indeed a number or otherwise...
        ElseIf Not IsNumeric(txtmatr.Text) Then
            MsgBox("The MATRIC NUMBER that you entered contains unrecognized characters. Please, check again and ensure that your input is purely numbers", MsgBoxStyle.Information, "INVALID")
            'checking if the entered year is indeed a number or otherwise...
        ElseIf Not IsNumeric(txtyr.Text) Then
            MsgBox("The YEAR that you entered contains unrecognized characters. Please, check again and ensure that your input is purely numbers", MsgBoxStyle.Information, "INVALID")
            'checking if the firstname entered contains unrecognized characters... eg: numbers...
        ElseIf IsNumeric(txtfname.Text) Then
            MsgBox("The FIRSTNAME that you entered contains unrecognized characters. Please, check again and ensure that your input does not contain numbers or characters", MsgBoxStyle.Information, "INVALID")
        Else
            'trying to connect to the database and then execute some some subsequent processes...
            Try
                'creating a connection string with microsoft access database...
                Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
                'Checking the state of the connection.. Open the connection if it is currently closed...
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim cmd, cmd1 As New System.Data.OleDb.OleDbCommand
                Dim dr As OleDbDataReader
                cmd.CommandText = System.Data.CommandType.Text
                'Checking the database for the matric number of the student that is currently being registered...
                Dim str As String
                str = " SELECT MATR FROM Students WHERE MATR ='" & txtmatr.Text & "'"
                Dim cd As OleDbCommand = New OleDbCommand(str, con)
                dr = cd.ExecuteReader
                'if the matric number exists... display a message...
                If dr.Read() = txtmatr.Text Then ' CHECKING for student's existence...
                    'ERROR MESSAGE...
                    MsgBox("The student you are trying to register has already been registered. Please, check the supplied NAMES and MATRIC. NUMBER to be sure you are not repeating any of them.", MsgBoxStyle.Information, "ALERT")
                    'if the matric number does not exist, insert the student's information into the database...
                Else
                    'INSERTING the student's information into the database...
                    cmd.CommandText = "INSERT INTO Students (SNAME,FNAME,ONAME,SEX,LVL,DEPT,MATR,YR,PHONE,EMAIL,LGA,DOB,DEPARTMENT,STATE,ADDRESS,MARITAL,RELIGION,NEXT_OF_KIN_NAME,NEXT_OF_KIN_ADDRESS,NEXT_OF_KIN_EMAIL,NEXT_OF_KIN_PHONE, HOSTEL,Picture) VALUES ('" & txtsname.Text & "','" & txtfname.Text & "','" & txtonames.Text & "','" & CBsex.Text & "','" & CBlevel.Text & "','" & CBdept.Text & "','" & txtmatr.Text & "','" & txtyr.Text & "','" & txtphone.Text & "','" & txtemail.Text & "','" & txtlga.Text & "','" & txtdob.Text & "','" & txtdep.Text & "','" & Combostate.SelectedItem & "','" & txtadd.Text & "','" & Combomar.SelectedItem & "','" & Comborel.SelectedItem & "','" & txtnam.Text & "','" & txtnextadd.Text & "','" & txtnextemail.Text & "','" & txtnextphon.Text & "','" & ComboHOSTEL.SelectedItem & "','" & TextBox2.Text & "')"
                    cmd1.CommandText = "INSERT INTO  (aspid,vote) VALUES ('" & aspid & "','0')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    'CLOSING the connection after a successful student registration...
                    con.Close()

                    'SUCCESS MESSAGE...
                    MsgBox(txtsname.Text & " " & txtfname.Text & " has been added to the school's database!", MsgBoxStyle.Information)
                    'TRYING TO NAVIGATE USER TO THE COURSE REGISTRATION PAGE IF USER SO WISHES...
                    If MsgBox("Would you like to pay your school fees now " & txtmatr.Text & ".", vbYesNo + MsgBoxStyle.Information) = Windows.Forms.DialogResult.Yes Then
                        'IF USER CLICKS OK, SHOW THE COURSE REGISTRATION FORM.. ELSE, COTINUE WITH THE INITIAL PROCESS...
                        PAYMENT_2.ShowDialog()
                    Else
                    End If
                    'ENDS THE COURSE REGISTRATION NAVIGATOR IF... STATEMENT...
                End If 'ENDS the if statement that checks for students' existence in the database and then loads the new record if record does not already exist...
                'if insertion or connection is not successful...
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "ALERT")
            End Try 'ENDS the try statement...
        End If 'THIS 'IF' STATEMENT ends the primary one at the begining of this PRIVATE SUB...
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With OpenFileDialog1
            .Filter = "JPEG (*.jpg)|*.jpg"
            .FilterIndex = 1
            .Title = "Demo Open File Dialog"
        End With
        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save the file path and name
                TextBox2.Text = OpenFileDialog1.FileName
                PictureBox3.BackgroundImage = Image.FromFile(TextBox2.Text)
                PictureBox3.BackgroundImageLayout = ImageLayout.Zoom

            Catch ex As Exception
                MsgBox("Do you want to save", MsgBoxStyle.YesNo)
            End Try
        End If
        'Dim resized As Image = ResizeImage(Image.FromFile(txtmatr.Text), New Size(60, 60))
        'resized.Save("C:\Users\Matthew\app\e payment - Copy (2)\Result\bin\Electronic payment" & aspid & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)


    End Sub
    Public Shared Function ResizeImage(ByVal image As Image, _
ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
        percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'clears all the fields and combo boxes...
        txtfname.Text = ""
        txtmatr.Text = ""
        txtonames.Text = ""
        txtsname.Text = ""
        txtyr.Text = ""
        TextBox2.Text = ""
        PictureBox3.Image = Nothing
        CBdept.SelectedItem = Nothing
        CBlevel.SelectedItem = Nothing
        CBsex.SelectedItem = Nothing
        txtphone.Text = ""
        txtemail.Text = ""
        txtlga.Text = ""
        txtdob.Text = ""
        txtdep.Text = ""
        Combostate.SelectedItem = Nothing
        txtadd.Text = ""
        Combomar.SelectedItem = Nothing
        Comborel.SelectedItem = Nothing
        txtnam.Text = ""
        txtnextadd.Text = ""
        txtnextemail.Text = ""
        txtnextphon.Text = ""
    End Sub

    Private Sub CBdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBdept.SelectedIndexChanged
    End Sub


    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
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
            sSQL = "SELECT SNAME,FNAME,ONAME,SEX,LVL,DEPT,MATR,YR,PHONE,EMAIL,LGA,DOB,DEPARTMENT,STATE,ADDRESS,MARITAL,RELIGION,NEXT_OF_KIN_NAME,NEXT_OF_KIN_ADDRESS,NEXT_OF_KIN_EMAIL,NEXT_OF_KIN_PHONE, HOSTEL,Picture FROM Students"
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

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim sSQL As String = String.Empty


        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(Get_Constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sSQL = "SELECT SNAME,FNAME,ONAME,SEX,LVL,DEPT,MATR,YR,PHONE,EMAIL,LGA,DOB,DEPARTMENT,STATE,ADDRESS,MARITAL,RELIGION,NEXT_OF_KIN_NAME,NEXT_OF_KIN_ADDRESS,NEXT_OF_KIN_EMAIL,NEXT_OF_KIN_PHONE, HOSTEL,Picture FROM Students"

            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
            If dt.Rows.Count = 0 Then
                MsgBox("No record found!")
            End If


        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
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
End Class