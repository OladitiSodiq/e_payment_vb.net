Imports System.Data.OleDb
Public Class Admin
    '"C:\Users\Matthew\app\e payment - C\Result\bin\Debug\Project.accdb"
    Dim connString As String = ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Project.accdb")
    Dim Myconn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim Source1 As New BindingSource
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      

        Myconn = New OleDbConnection
        Myconn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT *FROM [Project]", Myconn)
        da.Fill(ds, "Project")
        Dim view As New DataView(tables(0))
        Source1.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.ProjectDataSet.Students)

    End Sub
End Class