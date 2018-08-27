<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Purchase_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBProjectDataSet = New Vincent_Music_Store.DBProjectDataSet()
        Me.Grand_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IncludesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncludesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Music_StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Music_StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Music_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Music_StockTableAdapter = New Vincent_Music_Store.DBProjectDataSetTableAdapters.Music_StockTableAdapter()
        Me.TableAdapterManager = New Vincent_Music_Store.DBProjectDataSetTableAdapters.TableAdapterManager()
        Me.Purchase_DetailsTableAdapter = New Vincent_Music_Store.DBProjectDataSetTableAdapters.Purchase_DetailsTableAdapter()
        Me.IncludesTableAdapter = New Vincent_Music_Store.DBProjectDataSetTableAdapters.IncludesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Submission_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Submission_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Purchase_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchase_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncludesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncludesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(159, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 65
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button5.Location = New System.Drawing.Point(1019, 553)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(235, 58)
        Me.Button5.TabIndex = 68
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(1018, 493)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 55)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "<< Main Menu"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(119, 556)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 55)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Purchase_DetailsBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(230, 141)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 73
        '
        'Purchase_DetailsBindingSource
        '
        Me.Purchase_DetailsBindingSource.DataMember = "Purchase_Details"
        Me.Purchase_DetailsBindingSource.DataSource = Me.DBProjectDataSet
        '
        'DBProjectDataSet
        '
        Me.DBProjectDataSet.DataSetName = "DBProjectDataSet"
        Me.DBProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Grand_TotalTextBox
        '
        Me.Grand_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase_DetailsBindingSource, "Grand_Total", True))
        Me.Grand_TotalTextBox.Location = New System.Drawing.Point(230, 165)
        Me.Grand_TotalTextBox.Name = "Grand_TotalTextBox"
        Me.Grand_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Grand_TotalTextBox.TabIndex = 75
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase_DetailsBindingSource, "Employee_ID", True))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(230, 189)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Employee_IDTextBox.TabIndex = 77
        '
        'Purchase_DetailsDataGridView
        '
        Me.Purchase_DetailsDataGridView.AllowUserToOrderColumns = True
        Me.Purchase_DetailsDataGridView.AutoGenerateColumns = False
        Me.Purchase_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Purchase_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Submission_Type})
        Me.Purchase_DetailsDataGridView.DataSource = Me.Purchase_DetailsBindingSource
        Me.Purchase_DetailsDataGridView.Location = New System.Drawing.Point(43, 267)
        Me.Purchase_DetailsDataGridView.Name = "Purchase_DetailsDataGridView"
        Me.Purchase_DetailsDataGridView.Size = New System.Drawing.Size(419, 220)
        Me.Purchase_DetailsDataGridView.TabIndex = 83
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Purchase_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Purchase_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Grand_Total"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Grand_Total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Employee_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Employee_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(119, 493)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 55)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'IncludesDataGridView
        '
        Me.IncludesDataGridView.AutoGenerateColumns = False
        Me.IncludesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncludesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.IncludesDataGridView.DataSource = Me.IncludesBindingSource
        Me.IncludesDataGridView.Location = New System.Drawing.Point(961, 267)
        Me.IncludesDataGridView.Name = "IncludesDataGridView"
        Me.IncludesDataGridView.Size = New System.Drawing.Size(329, 220)
        Me.IncludesDataGridView.TabIndex = 84
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Music_ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Music_ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Purchase_ID"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Purchase_ID"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'IncludesBindingSource
        '
        Me.IncludesBindingSource.DataMember = "Includes"
        Me.IncludesBindingSource.DataSource = Me.DBProjectDataSet
        '
        'Music_StockDataGridView
        '
        Me.Music_StockDataGridView.AutoGenerateColumns = False
        Me.Music_StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Music_StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.Music_StockDataGridView.DataSource = Me.Music_StockBindingSource
        Me.Music_StockDataGridView.Location = New System.Drawing.Point(469, 267)
        Me.Music_StockDataGridView.Name = "Music_StockDataGridView"
        Me.Music_StockDataGridView.Size = New System.Drawing.Size(482, 220)
        Me.Music_StockDataGridView.TabIndex = 84
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Music_ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Music_ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Vendor_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Vendor_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Tape_quantity"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tape_quantity"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CD_Quantity"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CD_Quantity"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Artist"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Artist"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Producer"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Producer"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Year"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Music_Subject"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Music_Subject"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'Music_StockBindingSource
        '
        Me.Music_StockBindingSource.DataMember = "Music_Stock"
        Me.Music_StockBindingSource.DataSource = Me.DBProjectDataSet
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncludesBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(1101, 217)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(187, 20)
        Me.QuantityTextBox.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(978, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Quantity:"
        '
        'Music_IDTextBox
        '
        Me.Music_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncludesBindingSource, "Music_ID", True))
        Me.Music_IDTextBox.Location = New System.Drawing.Point(1101, 171)
        Me.Music_IDTextBox.Name = "Music_IDTextBox"
        Me.Music_IDTextBox.Size = New System.Drawing.Size(187, 20)
        Me.Music_IDTextBox.TabIndex = 87
        '
        'Purchase_IDTextBox1
        '
        Me.Purchase_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncludesBindingSource, "Purchase_ID", True))
        Me.Purchase_IDTextBox1.Location = New System.Drawing.Point(1101, 194)
        Me.Purchase_IDTextBox1.Name = "Purchase_IDTextBox1"
        Me.Purchase_IDTextBox1.Size = New System.Drawing.Size(187, 20)
        Me.Purchase_IDTextBox1.TabIndex = 88
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button6.Location = New System.Drawing.Point(582, 493)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(234, 55)
        Me.Button6.TabIndex = 89
        Me.Button6.Text = "Save List"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Music_StockTableAdapter
        '
        Me.Music_StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CityTableAdapter = Nothing
        Me.TableAdapterManager.HandlesTableAdapter = Nothing
        Me.TableAdapterManager.HasTableAdapter = Nothing
        Me.TableAdapterManager.IncludesTableAdapter = Nothing
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.Music_StockTableAdapter = Me.Music_StockTableAdapter
        Me.TableAdapterManager.PersonTableAdapter = Nothing
        Me.TableAdapterManager.Postal_CodeTableAdapter = Nothing
        Me.TableAdapterManager.Purchase_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.ShipmentTableAdapter = Nothing
        Me.TableAdapterManager.SurburbTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Vincent_Music_Store.DBProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorTableAdapter = Nothing
        '
        'Purchase_DetailsTableAdapter
        '
        Me.Purchase_DetailsTableAdapter.ClearBeforeFill = True
        '
        'IncludesTableAdapter
        '
        Me.IncludesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(978, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Music ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(950, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Purchase ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(132, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(70, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Grand Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(66, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 20)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Employee ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1128, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Submission_Type
        '
        Me.Submission_Type.DataPropertyName = "Submission_Type"
        Me.Submission_Type.HeaderText = "Submission_Type"
        Me.Submission_Type.Name = "Submission_Type"
        '
        'Submission_TypeTextBox
        '
        Me.Submission_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Purchase_DetailsBindingSource, "Submission_Type", True))
        Me.Submission_TypeTextBox.Location = New System.Drawing.Point(229, 213)
        Me.Submission_TypeTextBox.Name = "Submission_TypeTextBox"
        Me.Submission_TypeTextBox.Size = New System.Drawing.Size(201, 20)
        Me.Submission_TypeTextBox.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(66, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 20)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Submission Type:"
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1323, 742)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Submission_TypeTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Purchase_IDTextBox1)
        Me.Controls.Add(Me.Music_IDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Music_StockDataGridView)
        Me.Controls.Add(Me.IncludesDataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Purchase_DetailsDataGridView)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.Grand_TotalTextBox)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Sales"
        Me.Text = "Sales Applications"
        CType(Me.Purchase_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchase_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncludesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncludesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DBProjectDataSet As Vincent_Music_Store.DBProjectDataSet
    Friend WithEvents Music_StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Music_StockTableAdapter As Vincent_Music_Store.DBProjectDataSetTableAdapters.Music_StockTableAdapter
    Friend WithEvents TableAdapterManager As Vincent_Music_Store.DBProjectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Purchase_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Purchase_DetailsTableAdapter As Vincent_Music_Store.DBProjectDataSetTableAdapters.Purchase_DetailsTableAdapter
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Grand_TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Employee_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Purchase_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents IncludesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncludesTableAdapter As Vincent_Music_Store.DBProjectDataSetTableAdapters.IncludesTableAdapter
    Friend WithEvents IncludesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Music_StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Music_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Purchase_IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Submission_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Submission_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
