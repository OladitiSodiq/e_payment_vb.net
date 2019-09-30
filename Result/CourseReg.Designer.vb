<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseReg))
        Me.lblmatr = New System.Windows.Forms.Label()
        Me.txtmatric = New System.Windows.Forms.TextBox()
        Me.lblsname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lbloname = New System.Windows.Forms.Label()
        Me.lbldept = New System.Windows.Forms.Label()
        Me.btnver = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblsem = New System.Windows.Forms.Label()
        Me.lblsess = New System.Windows.Forms.Label()
        Me.CBclass = New System.Windows.Forms.ComboBox()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.CBsem = New System.Windows.Forms.ComboBox()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Butref = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtsess = New System.Windows.Forms.Label()
        Me.txtdept = New System.Windows.Forms.Label()
        Me.txtoname = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.Label()
        Me.ProjectDataSet = New Result.ProjectDataSet()
        Me.ProjectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New Result.ProjectDataSetTableAdapters.DepartmentTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmatr
        '
        Me.lblmatr.AutoSize = True
        Me.lblmatr.BackColor = System.Drawing.Color.White
        Me.lblmatr.Location = New System.Drawing.Point(687, 25)
        Me.lblmatr.Name = "lblmatr"
        Me.lblmatr.Size = New System.Drawing.Size(199, 13)
        Me.lblmatr.TabIndex = 0
        Me.lblmatr.Text = "ENTER MATRIC. NUMBER HERE"
        '
        'txtmatric
        '
        Me.txtmatric.Location = New System.Drawing.Point(740, 41)
        Me.txtmatric.MaxLength = 4
        Me.txtmatric.Name = "txtmatric"
        Me.txtmatric.Size = New System.Drawing.Size(100, 20)
        Me.txtmatric.TabIndex = 1
        '
        'lblsname
        '
        Me.lblsname.AutoSize = True
        Me.lblsname.BackColor = System.Drawing.Color.White
        Me.lblsname.Location = New System.Drawing.Point(26, 242)
        Me.lblsname.Name = "lblsname"
        Me.lblsname.Size = New System.Drawing.Size(68, 13)
        Me.lblsname.TabIndex = 3
        Me.lblsname.Text = "SURNAME"
        Me.lblsname.Visible = False
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.BackColor = System.Drawing.Color.White
        Me.lblfname.Location = New System.Drawing.Point(26, 272)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(78, 13)
        Me.lblfname.TabIndex = 5
        Me.lblfname.Text = "FIRSTNAME"
        Me.lblfname.Visible = False
        '
        'lbloname
        '
        Me.lbloname.AutoSize = True
        Me.lbloname.BackColor = System.Drawing.Color.White
        Me.lbloname.Location = New System.Drawing.Point(358, 238)
        Me.lbloname.Name = "lbloname"
        Me.lbloname.Size = New System.Drawing.Size(85, 13)
        Me.lbloname.TabIndex = 6
        Me.lbloname.Text = "OTHERNAME"
        Me.lbloname.Visible = False
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.BackColor = System.Drawing.Color.White
        Me.lbldept.Location = New System.Drawing.Point(358, 265)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(92, 13)
        Me.lbldept.TabIndex = 7
        Me.lbldept.Text = "DEPARTMENT"
        Me.lbldept.Visible = False
        '
        'btnver
        '
        Me.btnver.Location = New System.Drawing.Point(747, 64)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(83, 23)
        Me.btnver.TabIndex = 2
        Me.btnver.Text = "VERIFY"
        Me.btnver.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(556, 322)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 8
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = True
        Me.btnclose.Visible = False
        '
        'lblsem
        '
        Me.lblsem.AutoSize = True
        Me.lblsem.BackColor = System.Drawing.Color.White
        Me.lblsem.Location = New System.Drawing.Point(26, 296)
        Me.lblsem.Name = "lblsem"
        Me.lblsem.Size = New System.Drawing.Size(125, 13)
        Me.lblsem.TabIndex = 18
        Me.lblsem.Text = "SELECT SEMESTER"
        Me.lblsem.Visible = False
        '
        'lblsess
        '
        Me.lblsess.AutoSize = True
        Me.lblsess.BackColor = System.Drawing.Color.White
        Me.lblsess.Location = New System.Drawing.Point(358, 298)
        Me.lblsess.Name = "lblsess"
        Me.lblsess.Size = New System.Drawing.Size(61, 13)
        Me.lblsess.TabIndex = 19
        Me.lblsess.Text = "SESSION"
        Me.lblsess.Visible = False
        '
        'CBclass
        '
        Me.CBclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBclass.FormattingEnabled = True
        Me.CBclass.Items.AddRange(New Object() {"ND 1", "ND 2"})
        Me.CBclass.Location = New System.Drawing.Point(161, 322)
        Me.CBclass.Name = "CBclass"
        Me.CBclass.Size = New System.Drawing.Size(113, 21)
        Me.CBclass.TabIndex = 3
        Me.CBclass.Visible = False
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.BackColor = System.Drawing.Color.White
        Me.lblclass.Location = New System.Drawing.Point(26, 330)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(97, 13)
        Me.lblclass.TabIndex = 22
        Me.lblclass.Text = "SELECT CLASS"
        Me.lblclass.Visible = False
        '
        'CBsem
        '
        Me.CBsem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBsem.FormattingEnabled = True
        Me.CBsem.Items.AddRange(New Object() {"First", "Second"})
        Me.CBsem.Location = New System.Drawing.Point(161, 288)
        Me.CBsem.Name = "CBsem"
        Me.CBsem.Size = New System.Drawing.Size(113, 21)
        Me.CBsem.TabIndex = 4
        Me.CBsem.Visible = False
        '
        'btnsub
        '
        Me.btnsub.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsub.Location = New System.Drawing.Point(360, 322)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(83, 23)
        Me.btnsub.TabIndex = 6
        Me.btnsub.Text = "SUBMIT"
        Me.btnsub.UseVisualStyleBackColor = False
        Me.btnsub.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(451, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(598, 31)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "FEDERAL SCHOOL OF STATISTICS, IBADAN."
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 31)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "(National Bureau Of Statistics)"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(446, 26)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "P. O. Box 20753 U. I. Post Office, Ibadan."
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(394, 27)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "COURSE REGISTRATION FORM"
        Me.Label4.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Butref
        '
        Me.Butref.BackColor = System.Drawing.Color.Gainsboro
        Me.Butref.Location = New System.Drawing.Point(280, 322)
        Me.Butref.Name = "Butref"
        Me.Butref.Size = New System.Drawing.Size(75, 23)
        Me.Butref.TabIndex = 117
        Me.Butref.Text = "REFRESH"
        Me.Butref.UseVisualStyleBackColor = False
        Me.Butref.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Result.My.Resources.Resources.course
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(43, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(588, 127)
        Me.Button2.TabIndex = 134
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtsess
        '
        Me.txtsess.AutoSize = True
        Me.txtsess.BackColor = System.Drawing.Color.White
        Me.txtsess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsess.Location = New System.Drawing.Point(493, 292)
        Me.txtsess.Name = "txtsess"
        Me.txtsess.Size = New System.Drawing.Size(65, 17)
        Me.txtsess.TabIndex = 178
        Me.txtsess.Text = "Session"
        Me.txtsess.Visible = False
        '
        'txtdept
        '
        Me.txtdept.AutoSize = True
        Me.txtdept.BackColor = System.Drawing.Color.White
        Me.txtdept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdept.Location = New System.Drawing.Point(493, 265)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.Size = New System.Drawing.Size(92, 17)
        Me.txtdept.TabIndex = 179
        Me.txtdept.Text = "Department"
        Me.txtdept.Visible = False
        '
        'txtoname
        '
        Me.txtoname.AutoSize = True
        Me.txtoname.BackColor = System.Drawing.Color.White
        Me.txtoname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoname.Location = New System.Drawing.Point(493, 236)
        Me.txtoname.Name = "txtoname"
        Me.txtoname.Size = New System.Drawing.Size(88, 17)
        Me.txtoname.TabIndex = 180
        Me.txtoname.Text = "Othername"
        Me.txtoname.Visible = False
        '
        'txtfname
        '
        Me.txtfname.AutoSize = True
        Me.txtfname.BackColor = System.Drawing.Color.White
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(158, 263)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(79, 17)
        Me.txtfname.TabIndex = 181
        Me.txtfname.Text = "Firstname"
        Me.txtfname.Visible = False
        '
        'txtsname
        '
        Me.txtsname.AutoSize = True
        Me.txtsname.BackColor = System.Drawing.Color.White
        Me.txtsname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsname.Location = New System.Drawing.Point(158, 242)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(72, 17)
        Me.txtsname.TabIndex = 182
        Me.txtsname.Text = "Surname"
        Me.txtsname.Visible = False
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjectDataSetBindingSource
        '
        Me.ProjectDataSetBindingSource.DataSource = Me.ProjectDataSet
        Me.ProjectDataSetBindingSource.Position = 0
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.ProjectDataSetBindingSource
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 347)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(515, 450)
        Me.DataGridView1.TabIndex = 183
        '
        'CourseReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 300)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Result.My.Resources.Resources.epay
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(905, 691)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtoname)
        Me.Controls.Add(Me.txtdept)
        Me.Controls.Add(Me.txtsess)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Butref)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.lblsem)
        Me.Controls.Add(Me.lblsess)
        Me.Controls.Add(Me.CBclass)
        Me.Controls.Add(Me.lbldept)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.lblclass)
        Me.Controls.Add(Me.lblsname)
        Me.Controls.Add(Me.CBsem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbloname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.lblmatr)
        Me.Controls.Add(Me.txtmatric)
        Me.Controls.Add(Me.btnclose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CourseReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTER COURSES"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmatr As System.Windows.Forms.Label
    Friend WithEvents txtmatric As System.Windows.Forms.TextBox
    Friend WithEvents lblsname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lbloname As System.Windows.Forms.Label
    Friend WithEvents lbldept As System.Windows.Forms.Label
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblsem As System.Windows.Forms.Label
    Friend WithEvents lblsess As System.Windows.Forms.Label
    Friend WithEvents CBclass As System.Windows.Forms.ComboBox
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents CBsem As System.Windows.Forms.ComboBox
    Friend WithEvents btnsub As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Butref As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtsess As System.Windows.Forms.Label
    Friend WithEvents txtoname As System.Windows.Forms.Label
    Friend WithEvents txtdept As System.Windows.Forms.Label
    Friend WithEvents txtsname As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.Label
    Friend WithEvents ProjectDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProjectDataSet As Result.ProjectDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As Result.ProjectDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
