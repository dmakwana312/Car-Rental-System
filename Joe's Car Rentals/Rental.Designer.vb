<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblRentalID As System.Windows.Forms.Label
        Dim lblCustomerID As System.Windows.Forms.Label
        Dim lblRegistrationNo As System.Windows.Forms.Label
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblMobile As System.Windows.Forms.Label
        Dim lblManufacturer As System.Windows.Forms.Label
        Dim lblModel As System.Windows.Forms.Label
        Dim lblStartDate As System.Windows.Forms.Label
        Dim lblEndDate As System.Windows.Forms.Label
        Dim lblDuration As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rental))
        Me.butCustomer = New System.Windows.Forms.Button()
        Me.butRental = New System.Windows.Forms.Button()
        Me.butAgreement = New System.Windows.Forms.Button()
        Me.butInvoice = New System.Windows.Forms.Button()
        Me._Joe_s_Car_Rental_DatabaseDataSet = New Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSet()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalTableAdapter = New Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSetTableAdapters.RentalTableAdapter()
        Me.TableAdapterManager = New Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.txtfldRentalID = New System.Windows.Forms.TextBox()
        Me.txtfldCustomerID = New System.Windows.Forms.TextBox()
        Me.txtfldRegistrationNo = New System.Windows.Forms.TextBox()
        Me.txtfldFirstName = New System.Windows.Forms.TextBox()
        Me.txtfldLastName = New System.Windows.Forms.TextBox()
        Me.txtfldMobile = New System.Windows.Forms.TextBox()
        Me.txtfldManufacturer = New System.Windows.Forms.TextBox()
        Me.txtfldModel = New System.Windows.Forms.TextBox()
        Me.txtfldStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtfldEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtfldDuration = New System.Windows.Forms.TextBox()
        Me.butSearch = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.butClear = New System.Windows.Forms.Button()
        Me.butCreate = New System.Windows.Forms.Button()
        Me.pbCar = New System.Windows.Forms.PictureBox()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter = New Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSetTableAdapters.VehicleTableAdapter()
        Me.dgvVehicleRecords = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobileError = New System.Windows.Forms.Label()
        Me.durationError = New System.Windows.Forms.Label()
        Me.eDateError = New System.Windows.Forms.Label()
        Me.sDateError = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        lblRentalID = New System.Windows.Forms.Label()
        lblCustomerID = New System.Windows.Forms.Label()
        lblRegistrationNo = New System.Windows.Forms.Label()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblMobile = New System.Windows.Forms.Label()
        lblManufacturer = New System.Windows.Forms.Label()
        lblModel = New System.Windows.Forms.Label()
        lblStartDate = New System.Windows.Forms.Label()
        lblEndDate = New System.Windows.Forms.Label()
        lblDuration = New System.Windows.Forms.Label()
        CType(Me._Joe_s_Car_Rental_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVehicleRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRentalID
        '
        lblRentalID.AutoSize = True
        lblRentalID.BackColor = System.Drawing.Color.Transparent
        lblRentalID.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblRentalID.Location = New System.Drawing.Point(47, 239)
        lblRentalID.Name = "lblRentalID"
        lblRentalID.Size = New System.Drawing.Size(84, 21)
        lblRentalID.TabIndex = 5
        lblRentalID.Text = "Rental ID"
        '
        'lblCustomerID
        '
        lblCustomerID.AutoSize = True
        lblCustomerID.BackColor = System.Drawing.Color.Transparent
        lblCustomerID.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCustomerID.Location = New System.Drawing.Point(47, 279)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New System.Drawing.Size(107, 21)
        lblCustomerID.TabIndex = 7
        lblCustomerID.Text = "Customer ID"
        '
        'lblRegistrationNo
        '
        lblRegistrationNo.AutoSize = True
        lblRegistrationNo.BackColor = System.Drawing.Color.Transparent
        lblRegistrationNo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblRegistrationNo.Location = New System.Drawing.Point(47, 316)
        lblRegistrationNo.Name = "lblRegistrationNo"
        lblRegistrationNo.Size = New System.Drawing.Size(134, 21)
        lblRegistrationNo.TabIndex = 9
        lblRegistrationNo.Text = "Registration No"
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.BackColor = System.Drawing.Color.Transparent
        lblFirstName.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFirstName.Location = New System.Drawing.Point(47, 353)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(98, 21)
        lblFirstName.TabIndex = 11
        lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.BackColor = System.Drawing.Color.Transparent
        lblLastName.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLastName.Location = New System.Drawing.Point(47, 390)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(99, 21)
        lblLastName.TabIndex = 13
        lblLastName.Text = "Last Name"
        '
        'lblMobile
        '
        lblMobile.AutoSize = True
        lblMobile.BackColor = System.Drawing.Color.Transparent
        lblMobile.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMobile.Location = New System.Drawing.Point(47, 427)
        lblMobile.Name = "lblMobile"
        lblMobile.Size = New System.Drawing.Size(63, 21)
        lblMobile.TabIndex = 15
        lblMobile.Text = "Mobile"
        '
        'lblManufacturer
        '
        lblManufacturer.AutoSize = True
        lblManufacturer.BackColor = System.Drawing.Color.Transparent
        lblManufacturer.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblManufacturer.Location = New System.Drawing.Point(47, 464)
        lblManufacturer.Name = "lblManufacturer"
        lblManufacturer.Size = New System.Drawing.Size(119, 21)
        lblManufacturer.TabIndex = 17
        lblManufacturer.Text = "Manufacturer"
        '
        'lblModel
        '
        lblModel.AutoSize = True
        lblModel.BackColor = System.Drawing.Color.Transparent
        lblModel.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblModel.Location = New System.Drawing.Point(47, 501)
        lblModel.Name = "lblModel"
        lblModel.Size = New System.Drawing.Size(59, 21)
        lblModel.TabIndex = 19
        lblModel.Text = "Model"
        '
        'lblStartDate
        '
        lblStartDate.AutoSize = True
        lblStartDate.BackColor = System.Drawing.Color.Transparent
        lblStartDate.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStartDate.Location = New System.Drawing.Point(47, 538)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New System.Drawing.Size(95, 21)
        lblStartDate.TabIndex = 21
        lblStartDate.Text = "Start Date"
        '
        'lblEndDate
        '
        lblEndDate.AutoSize = True
        lblEndDate.BackColor = System.Drawing.Color.Transparent
        lblEndDate.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEndDate.Location = New System.Drawing.Point(47, 575)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New System.Drawing.Size(86, 21)
        lblEndDate.TabIndex = 23
        lblEndDate.Text = "End Date"
        '
        'lblDuration
        '
        lblDuration.AutoSize = True
        lblDuration.BackColor = System.Drawing.Color.Transparent
        lblDuration.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDuration.Location = New System.Drawing.Point(47, 612)
        lblDuration.Name = "lblDuration"
        lblDuration.Size = New System.Drawing.Size(81, 21)
        lblDuration.TabIndex = 25
        lblDuration.Text = "Duration"
        '
        'butCustomer
        '
        Me.butCustomer.BackgroundImage = CType(resources.GetObject("butCustomer.BackgroundImage"), System.Drawing.Image)
        Me.butCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butCustomer.Location = New System.Drawing.Point(0, 0)
        Me.butCustomer.Name = "butCustomer"
        Me.butCustomer.Size = New System.Drawing.Size(204, 45)
        Me.butCustomer.TabIndex = 0
        Me.butCustomer.UseVisualStyleBackColor = True
        '
        'butRental
        '
        Me.butRental.BackgroundImage = CType(resources.GetObject("butRental.BackgroundImage"), System.Drawing.Image)
        Me.butRental.Location = New System.Drawing.Point(259, -1)
        Me.butRental.Name = "butRental"
        Me.butRental.Size = New System.Drawing.Size(224, 46)
        Me.butRental.TabIndex = 1
        Me.butRental.UseVisualStyleBackColor = True
        '
        'butAgreement
        '
        Me.butAgreement.BackgroundImage = CType(resources.GetObject("butAgreement.BackgroundImage"), System.Drawing.Image)
        Me.butAgreement.Location = New System.Drawing.Point(538, -1)
        Me.butAgreement.Name = "butAgreement"
        Me.butAgreement.Size = New System.Drawing.Size(225, 46)
        Me.butAgreement.TabIndex = 2
        Me.butAgreement.UseVisualStyleBackColor = True
        '
        'butInvoice
        '
        Me.butInvoice.BackgroundImage = CType(resources.GetObject("butInvoice.BackgroundImage"), System.Drawing.Image)
        Me.butInvoice.Location = New System.Drawing.Point(819, -1)
        Me.butInvoice.Name = "butInvoice"
        Me.butInvoice.Size = New System.Drawing.Size(206, 46)
        Me.butInvoice.TabIndex = 3
        Me.butInvoice.UseVisualStyleBackColor = True
        '
        '_Joe_s_Car_Rental_DatabaseDataSet
        '
        Me._Joe_s_Car_Rental_DatabaseDataSet.DataSetName = "_Joe_s_Car_Rental_DatabaseDataSet"
        Me._Joe_s_Car_Rental_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalBindingSource
        '
        Me.RentalBindingSource.DataMember = "Rental"
        Me.RentalBindingSource.DataSource = Me._Joe_s_Car_Rental_DatabaseDataSet
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Me.RentalTableAdapter
        Me.TableAdapterManager.UpdateOrder = Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehicleTableAdapter = Nothing
        '
        'txtfldRentalID
        '
        Me.txtfldRentalID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "RentalID", True))
        Me.txtfldRentalID.Location = New System.Drawing.Point(198, 239)
        Me.txtfldRentalID.Name = "txtfldRentalID"
        Me.txtfldRentalID.Size = New System.Drawing.Size(142, 20)
        Me.txtfldRentalID.TabIndex = 6
        '
        'txtfldCustomerID
        '
        Me.txtfldCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "CustomerID", True))
        Me.txtfldCustomerID.Location = New System.Drawing.Point(198, 276)
        Me.txtfldCustomerID.Name = "txtfldCustomerID"
        Me.txtfldCustomerID.Size = New System.Drawing.Size(142, 20)
        Me.txtfldCustomerID.TabIndex = 8
        '
        'txtfldRegistrationNo
        '
        Me.txtfldRegistrationNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "RegistrationNo", True))
        Me.txtfldRegistrationNo.Location = New System.Drawing.Point(198, 313)
        Me.txtfldRegistrationNo.Name = "txtfldRegistrationNo"
        Me.txtfldRegistrationNo.Size = New System.Drawing.Size(142, 20)
        Me.txtfldRegistrationNo.TabIndex = 10
        '
        'txtfldFirstName
        '
        Me.txtfldFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "FirstName", True))
        Me.txtfldFirstName.Location = New System.Drawing.Point(198, 350)
        Me.txtfldFirstName.Name = "txtfldFirstName"
        Me.txtfldFirstName.Size = New System.Drawing.Size(142, 20)
        Me.txtfldFirstName.TabIndex = 12
        '
        'txtfldLastName
        '
        Me.txtfldLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "LastName", True))
        Me.txtfldLastName.Location = New System.Drawing.Point(198, 387)
        Me.txtfldLastName.Name = "txtfldLastName"
        Me.txtfldLastName.Size = New System.Drawing.Size(142, 20)
        Me.txtfldLastName.TabIndex = 14
        '
        'txtfldMobile
        '
        Me.txtfldMobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "Mobile", True))
        Me.txtfldMobile.Location = New System.Drawing.Point(198, 424)
        Me.txtfldMobile.MaxLength = 11
        Me.txtfldMobile.Name = "txtfldMobile"
        Me.txtfldMobile.Size = New System.Drawing.Size(142, 20)
        Me.txtfldMobile.TabIndex = 16
        '
        'txtfldManufacturer
        '
        Me.txtfldManufacturer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "Manufacturer", True))
        Me.txtfldManufacturer.Location = New System.Drawing.Point(198, 461)
        Me.txtfldManufacturer.Name = "txtfldManufacturer"
        Me.txtfldManufacturer.Size = New System.Drawing.Size(142, 20)
        Me.txtfldManufacturer.TabIndex = 18
        '
        'txtfldModel
        '
        Me.txtfldModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "Model", True))
        Me.txtfldModel.Location = New System.Drawing.Point(198, 498)
        Me.txtfldModel.Name = "txtfldModel"
        Me.txtfldModel.Size = New System.Drawing.Size(142, 20)
        Me.txtfldModel.TabIndex = 20
        '
        'txtfldStartDate
        '
        Me.txtfldStartDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RentalBindingSource, "StartDate", True))
        Me.txtfldStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfldStartDate.Location = New System.Drawing.Point(198, 536)
        Me.txtfldStartDate.Name = "txtfldStartDate"
        Me.txtfldStartDate.Size = New System.Drawing.Size(142, 20)
        Me.txtfldStartDate.TabIndex = 22
        '
        'txtfldEndDate
        '
        Me.txtfldEndDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RentalBindingSource, "EndDate", True))
        Me.txtfldEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfldEndDate.Location = New System.Drawing.Point(198, 573)
        Me.txtfldEndDate.Name = "txtfldEndDate"
        Me.txtfldEndDate.Size = New System.Drawing.Size(142, 20)
        Me.txtfldEndDate.TabIndex = 24
        '
        'txtfldDuration
        '
        Me.txtfldDuration.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "Duration", True))
        Me.txtfldDuration.Enabled = False
        Me.txtfldDuration.Location = New System.Drawing.Point(198, 609)
        Me.txtfldDuration.Name = "txtfldDuration"
        Me.txtfldDuration.Size = New System.Drawing.Size(142, 20)
        Me.txtfldDuration.TabIndex = 26
        '
        'butSearch
        '
        Me.butSearch.BackgroundImage = CType(resources.GetObject("butSearch.BackgroundImage"), System.Drawing.Image)
        Me.butSearch.Location = New System.Drawing.Point(356, 313)
        Me.butSearch.Name = "butSearch"
        Me.butSearch.Size = New System.Drawing.Size(59, 23)
        Me.butSearch.TabIndex = 27
        Me.butSearch.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.BackgroundImage = CType(resources.GetObject("butClose.BackgroundImage"), System.Drawing.Image)
        Me.butClose.Location = New System.Drawing.Point(799, 761)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(93, 34)
        Me.butClose.TabIndex = 30
        Me.butClose.UseVisualStyleBackColor = True
        '
        'butClear
        '
        Me.butClear.BackgroundImage = CType(resources.GetObject("butClear.BackgroundImage"), System.Drawing.Image)
        Me.butClear.Location = New System.Drawing.Point(655, 761)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(93, 34)
        Me.butClear.TabIndex = 29
        Me.butClear.UseVisualStyleBackColor = True
        '
        'butCreate
        '
        Me.butCreate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.butCreate.BackgroundImage = CType(resources.GetObject("butCreate.BackgroundImage"), System.Drawing.Image)
        Me.butCreate.Location = New System.Drawing.Point(514, 761)
        Me.butCreate.Name = "butCreate"
        Me.butCreate.Size = New System.Drawing.Size(93, 34)
        Me.butCreate.TabIndex = 28
        Me.butCreate.UseVisualStyleBackColor = False
        '
        'pbCar
        '
        Me.pbCar.Location = New System.Drawing.Point(699, 191)
        Me.pbCar.Name = "pbCar"
        Me.pbCar.Size = New System.Drawing.Size(230, 173)
        Me.pbCar.TabIndex = 31
        Me.pbCar.TabStop = False
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me._Joe_s_Car_Rental_DatabaseDataSet
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'dgvVehicleRecords
        '
        Me.dgvVehicleRecords.AutoGenerateColumns = False
        Me.dgvVehicleRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicleRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvVehicleRecords.DataSource = Me.VehicleBindingSource
        Me.dgvVehicleRecords.Location = New System.Drawing.Point(582, 424)
        Me.dgvVehicleRecords.Name = "dgvVehicleRecords"
        Me.dgvVehicleRecords.Size = New System.Drawing.Size(421, 220)
        Me.dgvVehicleRecords.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RegistrationNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RegistrationNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Manufacturer"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Manufacturer"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Engine"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Engine"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EngineSize"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EngineSize"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Colour"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Colour"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DailyFee"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DailyFee"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "GearBox"
        Me.DataGridViewTextBoxColumn8.HeaderText = "GearBox"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'mobileError
        '
        Me.mobileError.AutoSize = True
        Me.mobileError.BackColor = System.Drawing.Color.Transparent
        Me.mobileError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobileError.ForeColor = System.Drawing.Color.Red
        Me.mobileError.Location = New System.Drawing.Point(353, 427)
        Me.mobileError.Name = "mobileError"
        Me.mobileError.Size = New System.Drawing.Size(0, 13)
        Me.mobileError.TabIndex = 34
        '
        'durationError
        '
        Me.durationError.AutoSize = True
        Me.durationError.BackColor = System.Drawing.Color.Transparent
        Me.durationError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.durationError.ForeColor = System.Drawing.Color.Red
        Me.durationError.Location = New System.Drawing.Point(353, 612)
        Me.durationError.Name = "durationError"
        Me.durationError.Size = New System.Drawing.Size(0, 13)
        Me.durationError.TabIndex = 39
        '
        'eDateError
        '
        Me.eDateError.AutoSize = True
        Me.eDateError.BackColor = System.Drawing.Color.Transparent
        Me.eDateError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eDateError.ForeColor = System.Drawing.Color.Red
        Me.eDateError.Location = New System.Drawing.Point(353, 575)
        Me.eDateError.Name = "eDateError"
        Me.eDateError.Size = New System.Drawing.Size(0, 13)
        Me.eDateError.TabIndex = 40
        '
        'sDateError
        '
        Me.sDateError.AutoSize = True
        Me.sDateError.BackColor = System.Drawing.Color.Transparent
        Me.sDateError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sDateError.ForeColor = System.Drawing.Color.Red
        Me.sDateError.Location = New System.Drawing.Point(353, 538)
        Me.sDateError.Name = "sDateError"
        Me.sDateError.Size = New System.Drawing.Size(0, 13)
        Me.sDateError.TabIndex = 41
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 819)
        Me.Controls.Add(Me.sDateError)
        Me.Controls.Add(Me.eDateError)
        Me.Controls.Add(Me.durationError)
        Me.Controls.Add(Me.mobileError)
        Me.Controls.Add(Me.dgvVehicleRecords)
        Me.Controls.Add(Me.pbCar)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butClear)
        Me.Controls.Add(Me.butCreate)
        Me.Controls.Add(Me.butSearch)
        Me.Controls.Add(lblDuration)
        Me.Controls.Add(Me.txtfldDuration)
        Me.Controls.Add(lblEndDate)
        Me.Controls.Add(Me.txtfldEndDate)
        Me.Controls.Add(lblStartDate)
        Me.Controls.Add(Me.txtfldStartDate)
        Me.Controls.Add(lblModel)
        Me.Controls.Add(Me.txtfldModel)
        Me.Controls.Add(lblManufacturer)
        Me.Controls.Add(Me.txtfldManufacturer)
        Me.Controls.Add(lblMobile)
        Me.Controls.Add(Me.txtfldMobile)
        Me.Controls.Add(lblLastName)
        Me.Controls.Add(Me.txtfldLastName)
        Me.Controls.Add(lblFirstName)
        Me.Controls.Add(Me.txtfldFirstName)
        Me.Controls.Add(lblRegistrationNo)
        Me.Controls.Add(Me.txtfldRegistrationNo)
        Me.Controls.Add(lblCustomerID)
        Me.Controls.Add(Me.txtfldCustomerID)
        Me.Controls.Add(lblRentalID)
        Me.Controls.Add(Me.txtfldRentalID)
        Me.Controls.Add(Me.butInvoice)
        Me.Controls.Add(Me.butAgreement)
        Me.Controls.Add(Me.butRental)
        Me.Controls.Add(Me.butCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rental"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental"
        CType(Me._Joe_s_Car_Rental_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVehicleRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butCustomer As System.Windows.Forms.Button
    Friend WithEvents butRental As System.Windows.Forms.Button
    Friend WithEvents butAgreement As System.Windows.Forms.Button
    Friend WithEvents butInvoice As System.Windows.Forms.Button
    Friend WithEvents _Joe_s_Car_Rental_DatabaseDataSet As Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSet
    Friend WithEvents RentalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RentalTableAdapter As Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSetTableAdapters.RentalTableAdapter
    Friend WithEvents TableAdapterManager As Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtfldRentalID As System.Windows.Forms.TextBox
    Friend WithEvents txtfldCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtfldRegistrationNo As System.Windows.Forms.TextBox
    Friend WithEvents txtfldFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtfldLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtfldMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtfldManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents txtfldModel As System.Windows.Forms.TextBox
    Friend WithEvents txtfldStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfldEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfldDuration As System.Windows.Forms.TextBox
    Friend WithEvents butSearch As System.Windows.Forms.Button
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents butClear As System.Windows.Forms.Button
    Friend WithEvents butCreate As System.Windows.Forms.Button
    Friend WithEvents pbCar As System.Windows.Forms.PictureBox
    Friend WithEvents VehicleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehicleTableAdapter As Joe_s_Car_Rentals._Joe_s_Car_Rental_DatabaseDataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents dgvVehicleRecords As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mobileError As System.Windows.Forms.Label
    Friend WithEvents durationError As System.Windows.Forms.Label
    Friend WithEvents eDateError As Label
    Friend WithEvents sDateError As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
