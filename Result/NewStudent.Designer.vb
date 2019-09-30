<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewStudent))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtnam = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtnextphon = New System.Windows.Forms.TextBox()
        Me.txtnextemail = New System.Windows.Forms.TextBox()
        Me.txtnextadd = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboHOSTEL = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBlevel = New System.Windows.Forms.ComboBox()
        Me.txtonames = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBdept = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtyr = New System.Windows.Forms.TextBox()
        Me.txtdep = New System.Windows.Forms.TextBox()
        Me.txtmatr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBsex = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtlga = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.DateTimePicker()
        Me.Comborel = New System.Windows.Forms.ComboBox()
        Me.Combomar = New System.Windows.Forms.ComboBox()
        Me.Combostate = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New Result.ProjectDataSet()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StudentsTableAdapter = New Result.ProjectDataSetTableAdapters.StudentsTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1236, 742)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.txtadd)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ComboHOSTEL)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtfname)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtsname)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CBlevel)
        Me.TabPage1.Controls.Add(Me.txtonames)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CBdept)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtyr)
        Me.TabPage1.Controls.Add(Me.txtdep)
        Me.TabPage1.Controls.Add(Me.txtmatr)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.CBsex)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtlga)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtphone)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtemail)
        Me.TabPage1.Controls.Add(Me.txtdob)
        Me.TabPage1.Controls.Add(Me.Comborel)
        Me.TabPage1.Controls.Add(Me.Combomar)
        Me.TabPage1.Controls.Add(Me.Combostate)
        Me.TabPage1.ForeColor = System.Drawing.Color.Maroon
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1228, 716)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NEW STUDENT"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 372)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 20)
        Me.TextBox2.TabIndex = 151
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(32, 326)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 29)
        Me.Button5.TabIndex = 150
        Me.Button5.Text = "BROWSE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(8, 151)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(153, 161)
        Me.PictureBox3.TabIndex = 149
        Me.PictureBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(784, 542)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 33)
        Me.Button4.TabIndex = 147
        Me.Button4.Text = "CLOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(606, 331)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtadd.Size = New System.Drawing.Size(245, 72)
        Me.txtadd.TabIndex = 136
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Result.My.Resources.Resources.ref
        Me.PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 120)
        Me.PictureBox1.TabIndex = 126
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.txtnam)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtnextphon)
        Me.GroupBox4.Controls.Add(Me.txtnextemail)
        Me.GroupBox4.Controls.Add(Me.txtnextadd)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(885, 182)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(334, 241)
        Me.GroupBox4.TabIndex = 128
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "NEXT OF KIN:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(-125, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 55)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "CLOSE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtnam
        '
        Me.txtnam.Location = New System.Drawing.Point(83, 29)
        Me.txtnam.Name = "txtnam"
        Me.txtnam.Size = New System.Drawing.Size(245, 26)
        Me.txtnam.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(-109, -2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "ADDRESS"
        '
        'txtnextphon
        '
        Me.txtnextphon.Location = New System.Drawing.Point(83, 70)
        Me.txtnextphon.Name = "txtnextphon"
        Me.txtnextphon.Size = New System.Drawing.Size(245, 26)
        Me.txtnextphon.TabIndex = 49
        '
        'txtnextemail
        '
        Me.txtnextemail.Location = New System.Drawing.Point(83, 103)
        Me.txtnextemail.Name = "txtnextemail"
        Me.txtnextemail.Size = New System.Drawing.Size(245, 26)
        Me.txtnextemail.TabIndex = 50
        '
        'txtnextadd
        '
        Me.txtnextadd.Location = New System.Drawing.Point(83, 139)
        Me.txtnextadd.Multiline = True
        Me.txtnextadd.Name = "txtnextadd"
        Me.txtnextadd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtnextadd.Size = New System.Drawing.Size(245, 96)
        Me.txtnextadd.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(6, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "NAME"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(6, 77)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 13)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "PHONE NO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(6, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "ADDRESS"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 152)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(66, 13)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "ADDRESS"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(7, 111)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 13)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "E MAIL"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(372, 535)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 33)
        Me.Button2.TabIndex = 117
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboHOSTEL
        '
        Me.ComboHOSTEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboHOSTEL.FormattingEnabled = True
        Me.ComboHOSTEL.Items.AddRange(New Object() {"HOSTELER", "DAY SCHOLAR"})
        Me.ComboHOSTEL.Location = New System.Drawing.Point(1053, 457)
        Me.ComboHOSTEL.Name = "ComboHOSTEL"
        Me.ComboHOSTEL.Size = New System.Drawing.Size(121, 21)
        Me.ComboHOSTEL.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(482, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "ADDRESS"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(319, 225)
        Me.txtfname.MaxLength = 20
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(144, 20)
        Me.txtfname.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(482, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "DEPARTMENT"
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(319, 187)
        Me.txtsname.MaxLength = 20
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(144, 20)
        Me.txtsname.TabIndex = 107
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 542)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 33)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(195, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "FIRSTNAME"
        '
        'CBlevel
        '
        Me.CBlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBlevel.ForeColor = System.Drawing.Color.Maroon
        Me.CBlevel.FormattingEnabled = True
        Me.CBlevel.Items.AddRange(New Object() {"ND 1", "ND 2"})
        Me.CBlevel.Location = New System.Drawing.Point(640, 454)
        Me.CBlevel.Name = "CBlevel"
        Me.CBlevel.Size = New System.Drawing.Size(136, 21)
        Me.CBlevel.TabIndex = 113
        '
        'txtonames
        '
        Me.txtonames.Location = New System.Drawing.Point(319, 264)
        Me.txtonames.MaxLength = 20
        Me.txtonames.Name = "txtonames"
        Me.txtonames.Size = New System.Drawing.Size(144, 20)
        Me.txtonames.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(195, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "OTHERNAMES"
        '
        'CBdept
        '
        Me.CBdept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBdept.ForeColor = System.Drawing.Color.Maroon
        Me.CBdept.FormattingEnabled = True
        Me.CBdept.Items.AddRange(New Object() {"Business Administration", "Computer Science", "Statistics"})
        Me.CBdept.Location = New System.Drawing.Point(640, 422)
        Me.CBdept.Name = "CBdept"
        Me.CBdept.Size = New System.Drawing.Size(136, 21)
        Me.CBdept.Sorted = True
        Me.CBdept.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(195, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "SURNAME"
        '
        'txtyr
        '
        Me.txtyr.ForeColor = System.Drawing.Color.Maroon
        Me.txtyr.Location = New System.Drawing.Point(640, 494)
        Me.txtyr.MaxLength = 4
        Me.txtyr.Name = "txtyr"
        Me.txtyr.Size = New System.Drawing.Size(138, 20)
        Me.txtyr.TabIndex = 114
        '
        'txtdep
        '
        Me.txtdep.Location = New System.Drawing.Point(606, 298)
        Me.txtdep.Name = "txtdep"
        Me.txtdep.Size = New System.Drawing.Size(245, 20)
        Me.txtdep.TabIndex = 127
        '
        'txtmatr
        '
        Me.txtmatr.ForeColor = System.Drawing.Color.Maroon
        Me.txtmatr.Location = New System.Drawing.Point(640, 535)
        Me.txtmatr.MaxLength = 4
        Me.txtmatr.Name = "txtmatr"
        Me.txtmatr.Size = New System.Drawing.Size(138, 20)
        Me.txtmatr.TabIndex = 115
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(482, 462)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "LEVEL OF ENTRY"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(482, 501)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "YEAR OF ENTRY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(482, 542)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = " MATRIC. NUMBER"
        '
        'CBsex
        '
        Me.CBsex.BackColor = System.Drawing.Color.Magenta
        Me.CBsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBsex.ForeColor = System.Drawing.Color.Blue
        Me.CBsex.FormattingEnabled = True
        Me.CBsex.Items.AddRange(New Object() {"Male", "Female"})
        Me.CBsex.Location = New System.Drawing.Point(319, 302)
        Me.CBsex.Name = "CBsex"
        Me.CBsex.Size = New System.Drawing.Size(121, 21)
        Me.CBsex.TabIndex = 111
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(482, 305)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "FACULTY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(195, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "SEX"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(195, 400)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 13)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "STATE OF ORIGIN"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(882, 465)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(151, 13)
        Me.Label21.TabIndex = 145
        Me.Label21.Text = "ARE YOU A HOSTELER?"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Maroon
        Me.Label19.Location = New System.Drawing.Point(195, 444)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(114, 13)
        Me.Label19.TabIndex = 144
        Me.Label19.Text = "MARITAL STATUS"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(195, 489)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 143
        Me.Label18.Text = "RELIGION"
        '
        'txtlga
        '
        Me.txtlga.Location = New System.Drawing.Point(606, 229)
        Me.txtlga.Name = "txtlga"
        Me.txtlga.Size = New System.Drawing.Size(245, 20)
        Me.txtlga.TabIndex = 142
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(482, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "E MAIL"
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(319, 345)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(144, 20)
        Me.txtphone.TabIndex = 135
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(482, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "L. G. A"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(195, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "PHONE NO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(482, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "DATE OF BIRTH"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(606, 182)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(245, 20)
        Me.txtemail.TabIndex = 139
        '
        'txtdob
        '
        Me.txtdob.CalendarForeColor = System.Drawing.Color.Blue
        Me.txtdob.CalendarMonthBackground = System.Drawing.Color.Blue
        Me.txtdob.CalendarTitleForeColor = System.Drawing.Color.Blue
        Me.txtdob.CalendarTrailingForeColor = System.Drawing.Color.Blue
        Me.txtdob.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdob.Location = New System.Drawing.Point(606, 260)
        Me.txtdob.MinDate = New Date(1753, 2, 8, 0, 0, 0, 0)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(245, 25)
        Me.txtdob.TabIndex = 141
        Me.txtdob.Value = New Date(2015, 6, 5, 15, 5, 4, 0)
        '
        'Comborel
        '
        Me.Comborel.BackColor = System.Drawing.Color.Magenta
        Me.Comborel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Comborel.ForeColor = System.Drawing.Color.Blue
        Me.Comborel.FormattingEnabled = True
        Me.Comborel.Items.AddRange(New Object() {"Chrristianity", "Islamic", "Traditional"})
        Me.Comborel.Location = New System.Drawing.Point(320, 481)
        Me.Comborel.Name = "Comborel"
        Me.Comborel.Size = New System.Drawing.Size(135, 21)
        Me.Comborel.Sorted = True
        Me.Comborel.TabIndex = 138
        '
        'Combomar
        '
        Me.Combomar.BackColor = System.Drawing.Color.Magenta
        Me.Combomar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combomar.ForeColor = System.Drawing.Color.Blue
        Me.Combomar.FormattingEnabled = True
        Me.Combomar.Items.AddRange(New Object() {"Divorced", "Engaged", "Married", "Single"})
        Me.Combomar.Location = New System.Drawing.Point(319, 436)
        Me.Combomar.Name = "Combomar"
        Me.Combomar.Size = New System.Drawing.Size(135, 21)
        Me.Combomar.Sorted = True
        Me.Combomar.TabIndex = 137
        '
        'Combostate
        '
        Me.Combostate.BackColor = System.Drawing.Color.Magenta
        Me.Combostate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combostate.ForeColor = System.Drawing.Color.Blue
        Me.Combostate.FormattingEnabled = True
        Me.Combostate.Items.AddRange(New Object() {"Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa", "Benue", "Borno", "Cross River", "Delta", "Edo", "Enugu", "Imo", "Jigawa", "Kaduna", "katsina", "Kebbi", "Kongi", "Kwara", "Lagos", "Niger", "Ogun", "Osun", "Oyo", "Plateau", "Rivers", "Nasawa"})
        Me.Combostate.Location = New System.Drawing.Point(319, 392)
        Me.Combostate.Name = "Combostate"
        Me.Combostate.Size = New System.Drawing.Size(135, 21)
        Me.Combostate.TabIndex = 140
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.ButtonSearch)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1228, 662)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VIEW STUDENTS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1039, 18)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(110, 13)
        Me.LinkLabel1.TabIndex = 160
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "VIEW STUDENTS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1214, 603)
        Me.DataGridView1.TabIndex = 159
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(3, 3)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(128, 42)
        Me.ButtonSearch.TabIndex = 158
        Me.ButtonSearch.Text = "VIEW STUDENTS"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'NewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1236, 742)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(847, 726)
        Me.Name = "NewStudent"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD NEW STUDENT"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtnam As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtnextphon As System.Windows.Forms.TextBox
    Friend WithEvents txtnextemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnextadd As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboHOSTEL As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBlevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtonames As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBdept As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtyr As System.Windows.Forms.TextBox
    Friend WithEvents txtdep As System.Windows.Forms.TextBox
    Friend WithEvents txtmatr As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBsex As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtlga As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Comborel As System.Windows.Forms.ComboBox
    Friend WithEvents Combomar As System.Windows.Forms.ComboBox
    Friend WithEvents Combostate As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ProjectDataSet As Result.ProjectDataSet
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As Result.ProjectDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
