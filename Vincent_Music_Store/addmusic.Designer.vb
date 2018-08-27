<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addmusic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addmusic))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MusicIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TapequantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProducerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusicSubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Music_StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBProjectDataSet = New Vincent_Music_Store.DBProjectDataSet()
        Me.Music_StockTableAdapter = New Vincent_Music_Store.DBProjectDataSetTableAdapters.Music_StockTableAdapter()
        Me.TableAdapterManager = New Vincent_Music_Store.DBProjectDataSetTableAdapters.TableAdapterManager()
        Me.Music_StockBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Music_StockBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Vendor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Tape_quantityTextBox = New System.Windows.Forms.TextBox()
        Me.CD_QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.ArtistTextBox = New System.Windows.Forms.TextBox()
        Me.ProducerTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Music_SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Music_StockBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Music_StockBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(22, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Year:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(22, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Genre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(22, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(22, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(22, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Producer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(21, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Artist:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1000, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button5.Location = New System.Drawing.Point(148, 492)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(235, 47)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "< Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(389, 488)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 55)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "<< Main Menu"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(148, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 55)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Add Music"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(22, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "CD Quantity:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(21, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Tape Quantity:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(22, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Vendor ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MusicIDDataGridViewTextBoxColumn, Me.VendorIDDataGridViewTextBoxColumn, Me.TapequantityDataGridViewTextBoxColumn, Me.CDQuantityDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.ArtistDataGridViewTextBoxColumn, Me.ProducerDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.MusicSubjectDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Music_StockBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(646, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(580, 385)
        Me.DataGridView1.TabIndex = 44
        '
        'MusicIDDataGridViewTextBoxColumn
        '
        Me.MusicIDDataGridViewTextBoxColumn.DataPropertyName = "Music_ID"
        Me.MusicIDDataGridViewTextBoxColumn.HeaderText = "Music_ID"
        Me.MusicIDDataGridViewTextBoxColumn.Name = "MusicIDDataGridViewTextBoxColumn"
        '
        'VendorIDDataGridViewTextBoxColumn
        '
        Me.VendorIDDataGridViewTextBoxColumn.DataPropertyName = "Vendor_ID"
        Me.VendorIDDataGridViewTextBoxColumn.HeaderText = "Vendor_ID"
        Me.VendorIDDataGridViewTextBoxColumn.Name = "VendorIDDataGridViewTextBoxColumn"
        '
        'TapequantityDataGridViewTextBoxColumn
        '
        Me.TapequantityDataGridViewTextBoxColumn.DataPropertyName = "Tape_quantity"
        Me.TapequantityDataGridViewTextBoxColumn.HeaderText = "Tape_quantity"
        Me.TapequantityDataGridViewTextBoxColumn.Name = "TapequantityDataGridViewTextBoxColumn"
        '
        'CDQuantityDataGridViewTextBoxColumn
        '
        Me.CDQuantityDataGridViewTextBoxColumn.DataPropertyName = "CD_Quantity"
        Me.CDQuantityDataGridViewTextBoxColumn.HeaderText = "CD_Quantity"
        Me.CDQuantityDataGridViewTextBoxColumn.Name = "CDQuantityDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'ArtistDataGridViewTextBoxColumn
        '
        Me.ArtistDataGridViewTextBoxColumn.DataPropertyName = "Artist"
        Me.ArtistDataGridViewTextBoxColumn.HeaderText = "Artist"
        Me.ArtistDataGridViewTextBoxColumn.Name = "ArtistDataGridViewTextBoxColumn"
        '
        'ProducerDataGridViewTextBoxColumn
        '
        Me.ProducerDataGridViewTextBoxColumn.DataPropertyName = "Producer"
        Me.ProducerDataGridViewTextBoxColumn.HeaderText = "Producer"
        Me.ProducerDataGridViewTextBoxColumn.Name = "ProducerDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'MusicSubjectDataGridViewTextBoxColumn
        '
        Me.MusicSubjectDataGridViewTextBoxColumn.DataPropertyName = "Music_Subject"
        Me.MusicSubjectDataGridViewTextBoxColumn.HeaderText = "Music_Subject"
        Me.MusicSubjectDataGridViewTextBoxColumn.Name = "MusicSubjectDataGridViewTextBoxColumn"
        '
        'Music_StockBindingSource
        '
        Me.Music_StockBindingSource.DataMember = "Music_Stock"
        Me.Music_StockBindingSource.DataSource = Me.DBProjectDataSet
        '
        'DBProjectDataSet
        '
        Me.DBProjectDataSet.DataSetName = "DBProjectDataSet"
        Me.DBProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Music_StockBindingNavigator
        '
        Me.Music_StockBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Music_StockBindingNavigator.BindingSource = Me.Music_StockBindingSource
        Me.Music_StockBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Music_StockBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Music_StockBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Music_StockBindingNavigatorSaveItem})
        Me.Music_StockBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Music_StockBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Music_StockBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Music_StockBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Music_StockBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Music_StockBindingNavigator.Name = "Music_StockBindingNavigator"
        Me.Music_StockBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Music_StockBindingNavigator.Size = New System.Drawing.Size(1175, 25)
        Me.Music_StockBindingNavigator.TabIndex = 45
        Me.Music_StockBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Music_StockBindingNavigatorSaveItem
        '
        Me.Music_StockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Music_StockBindingNavigatorSaveItem.Image = CType(resources.GetObject("Music_StockBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Music_StockBindingNavigatorSaveItem.Name = "Music_StockBindingNavigatorSaveItem"
        Me.Music_StockBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Music_StockBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Vendor_IDTextBox
        '
        Me.Vendor_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "Vendor_ID", True))
        Me.Vendor_IDTextBox.Location = New System.Drawing.Point(188, 365)
        Me.Vendor_IDTextBox.Name = "Vendor_IDTextBox"
        Me.Vendor_IDTextBox.Size = New System.Drawing.Size(321, 20)
        Me.Vendor_IDTextBox.TabIndex = 9
        '
        'Tape_quantityTextBox
        '
        Me.Tape_quantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "Tape_quantity", True))
        Me.Tape_quantityTextBox.Location = New System.Drawing.Point(188, 313)
        Me.Tape_quantityTextBox.Name = "Tape_quantityTextBox"
        Me.Tape_quantityTextBox.Size = New System.Drawing.Size(321, 20)
        Me.Tape_quantityTextBox.TabIndex = 7
        '
        'CD_QuantityTextBox
        '
        Me.CD_QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "CD_Quantity", True))
        Me.CD_QuantityTextBox.Location = New System.Drawing.Point(188, 339)
        Me.CD_QuantityTextBox.Name = "CD_QuantityTextBox"
        Me.CD_QuantityTextBox.Size = New System.Drawing.Size(321, 20)
        Me.CD_QuantityTextBox.TabIndex = 8
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(188, 235)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(321, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'ArtistTextBox
        '
        Me.ArtistTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "Artist", True))
        Me.ArtistTextBox.Location = New System.Drawing.Point(188, 157)
        Me.ArtistTextBox.Name = "ArtistTextBox"
        Me.ArtistTextBox.Size = New System.Drawing.Size(321, 20)
        Me.ArtistTextBox.TabIndex = 1
        '
        'ProducerTextBox
        '
        Me.ProducerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "Producer", True))
        Me.ProducerTextBox.Location = New System.Drawing.Point(188, 212)
        Me.ProducerTextBox.Name = "ProducerTextBox"
        Me.ProducerTextBox.Size = New System.Drawing.Size(321, 20)
        Me.ProducerTextBox.TabIndex = 3
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(188, 186)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(321, 20)
        Me.YearTextBox.TabIndex = 2
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(188, 284)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(321, 20)
        Me.PriceTextBox.TabIndex = 6
        '
        'Music_SubjectTextBox
        '
        Me.Music_SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Music_StockBindingSource, "Music_Subject", True))
        Me.Music_SubjectTextBox.Location = New System.Drawing.Point(188, 261)
        Me.Music_SubjectTextBox.Name = "Music_SubjectTextBox"
        Me.Music_SubjectTextBox.Size = New System.Drawing.Size(321, 20)
        Me.Music_SubjectTextBox.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(389, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 55)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Save Music"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'addmusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1175, 585)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Vendor_IDTextBox)
        Me.Controls.Add(Me.Tape_quantityTextBox)
        Me.Controls.Add(Me.CD_QuantityTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.ArtistTextBox)
        Me.Controls.Add(Me.ProducerTextBox)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.Music_SubjectTextBox)
        Me.Controls.Add(Me.Music_StockBindingNavigator)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addmusic"
        Me.Text = "Music Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Music_StockBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Music_StockBindingNavigator.ResumeLayout(False)
        Me.Music_StockBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DBProjectDataSet As Vincent_Music_Store.DBProjectDataSet
    Friend WithEvents Music_StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Music_StockTableAdapter As Vincent_Music_Store.DBProjectDataSetTableAdapters.Music_StockTableAdapter
    Friend WithEvents TableAdapterManager As Vincent_Music_Store.DBProjectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Music_StockBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Music_StockBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Vendor_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tape_quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CD_QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArtistTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProducerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Music_SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MusicIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TapequantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProducerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MusicSubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
