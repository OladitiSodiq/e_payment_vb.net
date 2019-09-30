<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProjectDataSet = New Result.ProjectDataSet()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New Result.ProjectDataSetTableAdapters.StudentsTableAdapter()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LVLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MATRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARITALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RELIGIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEXTOFKINNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEXTOFKINADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEXTOFKINEMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEXTOFKINPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOSTELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnameDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.OnameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.LVLDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.MATRDataGridViewTextBoxColumn, Me.YRDataGridViewTextBoxColumn, Me.PHONEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.LGADataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.DEPARTMENTDataGridViewTextBoxColumn, Me.STATEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.MARITALDataGridViewTextBoxColumn, Me.RELIGIONDataGridViewTextBoxColumn, Me.NEXTOFKINNAMEDataGridViewTextBoxColumn, Me.NEXTOFKINADDRESSDataGridViewTextBoxColumn, Me.NEXTOFKINEMAILDataGridViewTextBoxColumn, Me.NEXTOFKINPHONEDataGridViewTextBoxColumn, Me.HOSTELDataGridViewTextBoxColumn, Me.PictureDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1362, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.ProjectDataSet
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "sname"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "sname"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'OnameDataGridViewTextBoxColumn
        '
        Me.OnameDataGridViewTextBoxColumn.DataPropertyName = "oname"
        Me.OnameDataGridViewTextBoxColumn.HeaderText = "oname"
        Me.OnameDataGridViewTextBoxColumn.Name = "OnameDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'LVLDataGridViewTextBoxColumn
        '
        Me.LVLDataGridViewTextBoxColumn.DataPropertyName = "LVL"
        Me.LVLDataGridViewTextBoxColumn.HeaderText = "LVL"
        Me.LVLDataGridViewTextBoxColumn.Name = "LVLDataGridViewTextBoxColumn"
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        '
        'MATRDataGridViewTextBoxColumn
        '
        Me.MATRDataGridViewTextBoxColumn.DataPropertyName = "MATR"
        Me.MATRDataGridViewTextBoxColumn.HeaderText = "MATR"
        Me.MATRDataGridViewTextBoxColumn.Name = "MATRDataGridViewTextBoxColumn"
        '
        'YRDataGridViewTextBoxColumn
        '
        Me.YRDataGridViewTextBoxColumn.DataPropertyName = "YR"
        Me.YRDataGridViewTextBoxColumn.HeaderText = "YR"
        Me.YRDataGridViewTextBoxColumn.Name = "YRDataGridViewTextBoxColumn"
        '
        'PHONEDataGridViewTextBoxColumn
        '
        Me.PHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE"
        Me.PHONEDataGridViewTextBoxColumn.HeaderText = "PHONE"
        Me.PHONEDataGridViewTextBoxColumn.Name = "PHONEDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'LGADataGridViewTextBoxColumn
        '
        Me.LGADataGridViewTextBoxColumn.DataPropertyName = "LGA"
        Me.LGADataGridViewTextBoxColumn.HeaderText = "LGA"
        Me.LGADataGridViewTextBoxColumn.Name = "LGADataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'DEPARTMENTDataGridViewTextBoxColumn
        '
        Me.DEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT"
        Me.DEPARTMENTDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT"
        Me.DEPARTMENTDataGridViewTextBoxColumn.Name = "DEPARTMENTDataGridViewTextBoxColumn"
        '
        'STATEDataGridViewTextBoxColumn
        '
        Me.STATEDataGridViewTextBoxColumn.DataPropertyName = "STATE"
        Me.STATEDataGridViewTextBoxColumn.HeaderText = "STATE"
        Me.STATEDataGridViewTextBoxColumn.Name = "STATEDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'MARITALDataGridViewTextBoxColumn
        '
        Me.MARITALDataGridViewTextBoxColumn.DataPropertyName = "MARITAL"
        Me.MARITALDataGridViewTextBoxColumn.HeaderText = "MARITAL"
        Me.MARITALDataGridViewTextBoxColumn.Name = "MARITALDataGridViewTextBoxColumn"
        '
        'RELIGIONDataGridViewTextBoxColumn
        '
        Me.RELIGIONDataGridViewTextBoxColumn.DataPropertyName = "RELIGION"
        Me.RELIGIONDataGridViewTextBoxColumn.HeaderText = "RELIGION"
        Me.RELIGIONDataGridViewTextBoxColumn.Name = "RELIGIONDataGridViewTextBoxColumn"
        '
        'NEXTOFKINNAMEDataGridViewTextBoxColumn
        '
        Me.NEXTOFKINNAMEDataGridViewTextBoxColumn.DataPropertyName = "NEXT_OF_KIN_NAME"
        Me.NEXTOFKINNAMEDataGridViewTextBoxColumn.HeaderText = "NEXT_OF_KIN_NAME"
        Me.NEXTOFKINNAMEDataGridViewTextBoxColumn.Name = "NEXTOFKINNAMEDataGridViewTextBoxColumn"
        '
        'NEXTOFKINADDRESSDataGridViewTextBoxColumn
        '
        Me.NEXTOFKINADDRESSDataGridViewTextBoxColumn.DataPropertyName = "NEXT_OF_KIN_ADDRESS"
        Me.NEXTOFKINADDRESSDataGridViewTextBoxColumn.HeaderText = "NEXT_OF_KIN_ADDRESS"
        Me.NEXTOFKINADDRESSDataGridViewTextBoxColumn.Name = "NEXTOFKINADDRESSDataGridViewTextBoxColumn"
        '
        'NEXTOFKINEMAILDataGridViewTextBoxColumn
        '
        Me.NEXTOFKINEMAILDataGridViewTextBoxColumn.DataPropertyName = "NEXT_OF_KIN_EMAIL"
        Me.NEXTOFKINEMAILDataGridViewTextBoxColumn.HeaderText = "NEXT_OF_KIN_EMAIL"
        Me.NEXTOFKINEMAILDataGridViewTextBoxColumn.Name = "NEXTOFKINEMAILDataGridViewTextBoxColumn"
        '
        'NEXTOFKINPHONEDataGridViewTextBoxColumn
        '
        Me.NEXTOFKINPHONEDataGridViewTextBoxColumn.DataPropertyName = "NEXT_OF_KIN_PHONE"
        Me.NEXTOFKINPHONEDataGridViewTextBoxColumn.HeaderText = "NEXT_OF_KIN_PHONE"
        Me.NEXTOFKINPHONEDataGridViewTextBoxColumn.Name = "NEXTOFKINPHONEDataGridViewTextBoxColumn"
        '
        'HOSTELDataGridViewTextBoxColumn
        '
        Me.HOSTELDataGridViewTextBoxColumn.DataPropertyName = "HOSTEL"
        Me.HOSTELDataGridViewTextBoxColumn.HeaderText = "HOSTEL"
        Me.HOSTELDataGridViewTextBoxColumn.Name = "HOSTELDataGridViewTextBoxColumn"
        '
        'PictureDataGridViewTextBoxColumn
        '
        Me.PictureDataGridViewTextBoxColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewTextBoxColumn.HeaderText = "Picture"
        Me.PictureDataGridViewTextBoxColumn.Name = "PictureDataGridViewTextBoxColumn"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 497)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProjectDataSet As Result.ProjectDataSet
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As Result.ProjectDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents SnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LVLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MATRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LGADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARITALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RELIGIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEXTOFKINNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEXTOFKINADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEXTOFKINEMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEXTOFKINPHONEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSTELDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
