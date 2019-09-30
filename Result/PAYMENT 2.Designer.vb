<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAYMENT_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAYMENT_2))
        Me.butsub = New System.Windows.Forms.Button()
        Me.butprint = New System.Windows.Forms.Button()
        Me.Combopay = New System.Windows.Forms.ComboBox()
        Me.txtmatr = New System.Windows.Forms.TextBox()
        Me.lblmatric = New System.Windows.Forms.Label()
        Me.Butmatr = New System.Windows.Forms.Button()
        Me.Inc_date = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rd1 = New System.Windows.Forms.RadioButton()
        Me.rd2 = New System.Windows.Forms.RadioButton()
        Me.lmatric = New System.Windows.Forms.Label()
        Me.lsurname = New System.Windows.Forms.Label()
        Me.loname = New System.Windows.Forms.Label()
        Me.lamount = New System.Windows.Forms.Label()
        Me.llevel = New System.Windows.Forms.Label()
        Me.lcash = New System.Windows.Forms.Label()
        Me.lsum = New System.Windows.Forms.Label()
        Me.ldept = New System.Windows.Forms.Label()
        Me.Pict_matric = New System.Windows.Forms.PictureBox()
        Me.Piclogo = New System.Windows.Forms.PictureBox()
        Me.Pict_Incidental = New System.Windows.Forms.PictureBox()
        Me.pict_develop = New System.Windows.Forms.PictureBox()
        Me.Pict_dev = New System.Windows.Forms.PictureBox()
        Me.Pict_Proj = New System.Windows.Forms.PictureBox()
        Me.Pict_DEPT = New System.Windows.Forms.PictureBox()
        Me.Pict_MED = New System.Windows.Forms.PictureBox()
        Me.Pict_SU = New System.Windows.Forms.PictureBox()
        Me.Pict_SUG = New System.Windows.Forms.PictureBox()
        Me.rd3 = New System.Windows.Forms.RadioButton()
        CType(Me.Pict_matric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_Incidental, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict_develop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_dev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_Proj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_DEPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_MED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_SU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_SUG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butsub
        '
        Me.butsub.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butsub.Location = New System.Drawing.Point(31, 652)
        Me.butsub.Name = "butsub"
        Me.butsub.Size = New System.Drawing.Size(99, 25)
        Me.butsub.TabIndex = 5
        Me.butsub.Text = "SUBMIT"
        Me.butsub.UseVisualStyleBackColor = True
        '
        'butprint
        '
        Me.butprint.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butprint.Location = New System.Drawing.Point(168, 650)
        Me.butprint.Name = "butprint"
        Me.butprint.Size = New System.Drawing.Size(99, 27)
        Me.butprint.TabIndex = 7
        Me.butprint.Text = "PRINT"
        Me.butprint.UseVisualStyleBackColor = True
        Me.butprint.Visible = False
        '
        'Combopay
        '
        Me.Combopay.BackColor = System.Drawing.Color.White
        Me.Combopay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combopay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combopay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Combopay.FormattingEnabled = True
        Me.Combopay.Location = New System.Drawing.Point(510, 322)
        Me.Combopay.Name = "Combopay"
        Me.Combopay.Size = New System.Drawing.Size(121, 21)
        Me.Combopay.Sorted = True
        Me.Combopay.TabIndex = 21
        '
        'txtmatr
        '
        Me.txtmatr.BackColor = System.Drawing.Color.White
        Me.txtmatr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatr.ForeColor = System.Drawing.Color.Black
        Me.txtmatr.Location = New System.Drawing.Point(510, 186)
        Me.txtmatr.MaxLength = 5
        Me.txtmatr.Name = "txtmatr"
        Me.txtmatr.Size = New System.Drawing.Size(135, 24)
        Me.txtmatr.TabIndex = 20
        '
        'lblmatric
        '
        Me.lblmatric.AutoSize = True
        Me.lblmatric.BackColor = System.Drawing.Color.White
        Me.lblmatric.Font = New System.Drawing.Font("Algerian", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatric.ForeColor = System.Drawing.Color.Blue
        Me.lblmatric.Location = New System.Drawing.Point(368, 167)
        Me.lblmatric.Name = "lblmatric"
        Me.lblmatric.Size = New System.Drawing.Size(287, 16)
        Me.lblmatric.TabIndex = 19
        Me.lblmatric.Text = "ENTER YOUR MATRIC NUMBER HERE"
        '
        'Butmatr
        '
        Me.Butmatr.BackColor = System.Drawing.Color.White
        Me.Butmatr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butmatr.Location = New System.Drawing.Point(510, 374)
        Me.Butmatr.Name = "Butmatr"
        Me.Butmatr.Size = New System.Drawing.Size(75, 23)
        Me.Butmatr.TabIndex = 18
        Me.Butmatr.Text = "CLICK"
        Me.Butmatr.UseVisualStyleBackColor = False
        '
        'Inc_date
        '
        Me.Inc_date.Checked = False
        Me.Inc_date.Enabled = False
        Me.Inc_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inc_date.Location = New System.Drawing.Point(155, 186)
        Me.Inc_date.Name = "Inc_date"
        Me.Inc_date.Size = New System.Drawing.Size(248, 23)
        Me.Inc_date.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(31, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 21)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(31, 268)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 21)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Surnames"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 360)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 21)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Amount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 21)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Matric"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 439)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 21)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Cashier"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 606)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 21)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Signature"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Sum Of"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 531)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Othernames"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(323, 650)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 27)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(164, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 21)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "#"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(489, 650)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 27)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rd1
        '
        Me.rd1.AutoSize = True
        Me.rd1.BackColor = System.Drawing.Color.Transparent
        Me.rd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd1.Location = New System.Drawing.Point(510, 223)
        Me.rd1.Name = "rd1"
        Me.rd1.Size = New System.Drawing.Size(54, 17)
        Me.rd1.TabIndex = 60
        Me.rd1.TabStop = True
        Me.rd1.Text = "ND 1"
        Me.rd1.UseVisualStyleBackColor = False
        '
        'rd2
        '
        Me.rd2.AutoSize = True
        Me.rd2.BackColor = System.Drawing.Color.Transparent
        Me.rd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd2.Location = New System.Drawing.Point(510, 256)
        Me.rd2.Name = "rd2"
        Me.rd2.Size = New System.Drawing.Size(54, 17)
        Me.rd2.TabIndex = 61
        Me.rd2.TabStop = True
        Me.rd2.Text = "ND 2"
        Me.rd2.UseVisualStyleBackColor = False
        '
        'lmatric
        '
        Me.lmatric.AutoSize = True
        Me.lmatric.BackColor = System.Drawing.Color.Transparent
        Me.lmatric.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmatric.Location = New System.Drawing.Point(164, 223)
        Me.lmatric.Name = "lmatric"
        Me.lmatric.Size = New System.Drawing.Size(65, 21)
        Me.lmatric.TabIndex = 62
        Me.lmatric.Text = "Matric"
        '
        'lsurname
        '
        Me.lsurname.AutoSize = True
        Me.lsurname.BackColor = System.Drawing.Color.Transparent
        Me.lsurname.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsurname.Location = New System.Drawing.Point(164, 268)
        Me.lsurname.Name = "lsurname"
        Me.lsurname.Size = New System.Drawing.Size(81, 21)
        Me.lsurname.TabIndex = 63
        Me.lsurname.Text = "Surnmae"
        '
        'loname
        '
        Me.loname.AutoSize = True
        Me.loname.BackColor = System.Drawing.Color.Transparent
        Me.loname.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loname.Location = New System.Drawing.Point(164, 316)
        Me.loname.Name = "loname"
        Me.loname.Size = New System.Drawing.Size(106, 21)
        Me.loname.TabIndex = 64
        Me.loname.Text = "Othernames"
        '
        'lamount
        '
        Me.lamount.AutoSize = True
        Me.lamount.BackColor = System.Drawing.Color.Transparent
        Me.lamount.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lamount.Location = New System.Drawing.Point(164, 481)
        Me.lamount.Name = "lamount"
        Me.lamount.Size = New System.Drawing.Size(75, 21)
        Me.lamount.TabIndex = 65
        Me.lamount.Text = "Amount"
        '
        'llevel
        '
        Me.llevel.AutoSize = True
        Me.llevel.BackColor = System.Drawing.Color.Transparent
        Me.llevel.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llevel.Location = New System.Drawing.Point(164, 398)
        Me.llevel.Name = "llevel"
        Me.llevel.Size = New System.Drawing.Size(55, 21)
        Me.llevel.TabIndex = 66
        Me.llevel.Text = "Level"
        '
        'lcash
        '
        Me.lcash.AutoSize = True
        Me.lcash.BackColor = System.Drawing.Color.Transparent
        Me.lcash.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcash.Location = New System.Drawing.Point(164, 439)
        Me.lcash.Name = "lcash"
        Me.lcash.Size = New System.Drawing.Size(71, 21)
        Me.lcash.TabIndex = 67
        Me.lcash.Text = "Cashier"
        '
        'lsum
        '
        Me.lsum.AutoSize = True
        Me.lsum.BackColor = System.Drawing.Color.Transparent
        Me.lsum.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsum.Location = New System.Drawing.Point(176, 360)
        Me.lsum.Name = "lsum"
        Me.lsum.Size = New System.Drawing.Size(69, 21)
        Me.lsum.TabIndex = 69
        Me.lsum.Text = "Sum Of"
        '
        'ldept
        '
        Me.ldept.AutoSize = True
        Me.ldept.BackColor = System.Drawing.Color.Transparent
        Me.ldept.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldept.Location = New System.Drawing.Point(164, 531)
        Me.ldept.Name = "ldept"
        Me.ldept.Size = New System.Drawing.Size(107, 21)
        Me.ldept.TabIndex = 70
        Me.ldept.Text = "Department"
        '
        'Pict_matric
        '
        Me.Pict_matric.BackgroundImage = Global.Result.My.Resources.Resources.Inc1
        Me.Pict_matric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict_matric.Image = Global.Result.My.Resources.Resources.matric1
        Me.Pict_matric.Location = New System.Drawing.Point(0, 0)
        Me.Pict_matric.Name = "Pict_matric"
        Me.Pict_matric.Size = New System.Drawing.Size(682, 702)
        Me.Pict_matric.TabIndex = 78
        Me.Pict_matric.TabStop = False
        Me.Pict_matric.Visible = False
        '
        'Piclogo
        '
        Me.Piclogo.BackgroundImage = Global.Result.My.Resources.Resources.LOGO
        Me.Piclogo.Location = New System.Drawing.Point(-6, 0)
        Me.Piclogo.Name = "Piclogo"
        Me.Piclogo.Size = New System.Drawing.Size(107, 127)
        Me.Piclogo.TabIndex = 38
        Me.Piclogo.TabStop = False
        '
        'Pict_Incidental
        '
        Me.Pict_Incidental.BackgroundImage = Global.Result.My.Resources.Resources.Inc1
        Me.Pict_Incidental.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict_Incidental.ErrorImage = Nothing
        Me.Pict_Incidental.Location = New System.Drawing.Point(0, 0)
        Me.Pict_Incidental.Name = "Pict_Incidental"
        Me.Pict_Incidental.Size = New System.Drawing.Size(682, 702)
        Me.Pict_Incidental.TabIndex = 55
        Me.Pict_Incidental.TabStop = False
        Me.Pict_Incidental.Visible = False
        '
        'pict_develop
        '
        Me.pict_develop.BackgroundImage = Global.Result.My.Resources.Resources.dev1
        Me.pict_develop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pict_develop.Location = New System.Drawing.Point(0, 0)
        Me.pict_develop.Name = "pict_develop"
        Me.pict_develop.Size = New System.Drawing.Size(682, 702)
        Me.pict_develop.TabIndex = 56
        Me.pict_develop.TabStop = False
        Me.pict_develop.Visible = False
        '
        'Pict_dev
        '
        Me.Pict_dev.BackgroundImage = Global.Result.My.Resources.Resources.Inc1
        Me.Pict_dev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict_dev.Image = Global.Result.My.Resources.Resources.dev11
        Me.Pict_dev.Location = New System.Drawing.Point(0, 0)
        Me.Pict_dev.Name = "Pict_dev"
        Me.Pict_dev.Size = New System.Drawing.Size(682, 702)
        Me.Pict_dev.TabIndex = 73
        Me.Pict_dev.TabStop = False
        Me.Pict_dev.Visible = False
        '
        'Pict_Proj
        '
        Me.Pict_Proj.BackgroundImage = Global.Result.My.Resources.Resources.Inc1
        Me.Pict_Proj.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict_Proj.Image = Global.Result.My.Resources.Resources.Proj1
        Me.Pict_Proj.Location = New System.Drawing.Point(0, 0)
        Me.Pict_Proj.Name = "Pict_Proj"
        Me.Pict_Proj.Size = New System.Drawing.Size(682, 702)
        Me.Pict_Proj.TabIndex = 72
        Me.Pict_Proj.TabStop = False
        Me.Pict_Proj.Visible = False
        '
        'Pict_DEPT
        '
        Me.Pict_DEPT.BackgroundImage = Global.Result.My.Resources.Resources.Inc1
        Me.Pict_DEPT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict_DEPT.Image = Global.Result.My.Resources.Resources.dept1
        Me.Pict_DEPT.Location = New System.Drawing.Point(0, 0)
        Me.Pict_DEPT.Name = "Pict_DEPT"
        Me.Pict_DEPT.Size = New System.Drawing.Size(682, 702)
        Me.Pict_DEPT.TabIndex = 74
        Me.Pict_DEPT.TabStop = False
        Me.Pict_DEPT.Visible = False
        '
        'Pict_MED
        '
        Me.Pict_MED.BackgroundImage = Global.Result.My.Resources.Resources.Inc1
        Me.Pict_MED.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict_MED.Image = Global.Result.My.Resources.Resources.med1
        Me.Pict_MED.Location = New System.Drawing.Point(0, 0)
        Me.Pict_MED.Name = "Pict_MED"
        Me.Pict_MED.Size = New System.Drawing.Size(682, 702)
        Me.Pict_MED.TabIndex = 75
        Me.Pict_MED.TabStop = False
        Me.Pict_MED.Visible = False
        '
        'Pict_SU
        '
        Me.Pict_SU.BackgroundImage = Global.Result.My.Resources.Resources.Inc1
        Me.Pict_SU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict_SU.Image = Global.Result.My.Resources.Resources.su1
        Me.Pict_SU.Location = New System.Drawing.Point(0, 0)
        Me.Pict_SU.Name = "Pict_SU"
        Me.Pict_SU.Size = New System.Drawing.Size(682, 702)
        Me.Pict_SU.TabIndex = 76
        Me.Pict_SU.TabStop = False
        Me.Pict_SU.Visible = False
        '
        'Pict_SUG
        '
        Me.Pict_SUG.BackgroundImage = Global.Result.My.Resources.Resources.Inc1
        Me.Pict_SUG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pict_SUG.Image = Global.Result.My.Resources.Resources.sug1
        Me.Pict_SUG.Location = New System.Drawing.Point(0, 0)
        Me.Pict_SUG.Name = "Pict_SUG"
        Me.Pict_SUG.Size = New System.Drawing.Size(682, 702)
        Me.Pict_SUG.TabIndex = 77
        Me.Pict_SUG.TabStop = False
        Me.Pict_SUG.Visible = False
        '
        'rd3
        '
        Me.rd3.AutoSize = True
        Me.rd3.BackColor = System.Drawing.Color.Transparent
        Me.rd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd3.Location = New System.Drawing.Point(510, 284)
        Me.rd3.Name = "rd3"
        Me.rd3.Size = New System.Drawing.Size(113, 17)
        Me.rd3.TabIndex = 79
        Me.rd3.TabStop = True
        Me.rd3.Text = "Non-Academics"
        Me.rd3.UseVisualStyleBackColor = False
        '
        'PAYMENT_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 702)
        Me.Controls.Add(Me.rd3)
        Me.Controls.Add(Me.ldept)
        Me.Controls.Add(Me.lsum)
        Me.Controls.Add(Me.lcash)
        Me.Controls.Add(Me.llevel)
        Me.Controls.Add(Me.lamount)
        Me.Controls.Add(Me.loname)
        Me.Controls.Add(Me.lsurname)
        Me.Controls.Add(Me.lmatric)
        Me.Controls.Add(Me.rd2)
        Me.Controls.Add(Me.rd1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Piclogo)
        Me.Controls.Add(Me.Inc_date)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Combopay)
        Me.Controls.Add(Me.butsub)
        Me.Controls.Add(Me.Butmatr)
        Me.Controls.Add(Me.txtmatr)
        Me.Controls.Add(Me.butprint)
        Me.Controls.Add(Me.lblmatric)
        Me.Controls.Add(Me.Pict_Incidental)
        Me.Controls.Add(Me.pict_develop)
        Me.Controls.Add(Me.Pict_dev)
        Me.Controls.Add(Me.Pict_Proj)
        Me.Controls.Add(Me.Pict_DEPT)
        Me.Controls.Add(Me.Pict_MED)
        Me.Controls.Add(Me.Pict_SU)
        Me.Controls.Add(Me.Pict_SUG)
        Me.Controls.Add(Me.Pict_matric)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PAYMENT_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT_2"
        CType(Me.Pict_matric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_Incidental, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict_develop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_dev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_Proj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_DEPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_MED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_SU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_SUG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butprint As System.Windows.Forms.Button
    Friend WithEvents butsub As System.Windows.Forms.Button
    Friend WithEvents Combopay As System.Windows.Forms.ComboBox
    Friend WithEvents txtmatr As System.Windows.Forms.TextBox
    Friend WithEvents lblmatric As System.Windows.Forms.Label
    Friend WithEvents Butmatr As System.Windows.Forms.Button
    Friend WithEvents Piclogo As System.Windows.Forms.PictureBox
    Friend WithEvents Inc_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Pict_Incidental As System.Windows.Forms.PictureBox
    Friend WithEvents pict_develop As System.Windows.Forms.PictureBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rd2 As System.Windows.Forms.RadioButton
    Friend WithEvents rd1 As System.Windows.Forms.RadioButton
    Friend WithEvents llevel As System.Windows.Forms.Label
    Friend WithEvents lamount As System.Windows.Forms.Label
    Friend WithEvents loname As System.Windows.Forms.Label
    Friend WithEvents lsurname As System.Windows.Forms.Label
    Friend WithEvents lmatric As System.Windows.Forms.Label
    Friend WithEvents ldept As System.Windows.Forms.Label
    Friend WithEvents lsum As System.Windows.Forms.Label
    Friend WithEvents lcash As System.Windows.Forms.Label
    Friend WithEvents Pict_Proj As System.Windows.Forms.PictureBox
    Friend WithEvents Pict_dev As System.Windows.Forms.PictureBox
    Friend WithEvents Pict_DEPT As System.Windows.Forms.PictureBox
    Friend WithEvents Pict_MED As System.Windows.Forms.PictureBox
    Friend WithEvents Pict_SU As System.Windows.Forms.PictureBox
    Friend WithEvents Pict_SUG As System.Windows.Forms.PictureBox
    Friend WithEvents Pict_matric As System.Windows.Forms.PictureBox
    Friend WithEvents rd3 As System.Windows.Forms.RadioButton
End Class
