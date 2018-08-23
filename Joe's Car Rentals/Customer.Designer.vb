<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
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
        Dim lblCustomerID As System.Windows.Forms.Label
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblAddress1 As System.Windows.Forms.Label
        Dim lblAddress2 As System.Windows.Forms.Label
        Dim lblPostCode As System.Windows.Forms.Label
        Dim lblEmail As System.Windows.Forms.Label
        Dim lblLincenseNo As System.Windows.Forms.Label
        Dim lblDOB As System.Windows.Forms.Label
        Dim lblTel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.butRental = New System.Windows.Forms.Button()
        Me.butAgreement = New System.Windows.Forms.Button()
        Me.butInvoice = New System.Windows.Forms.Button()
        Me.butCreate = New System.Windows.Forms.Button()
        Me.butClear = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.butSearch = New System.Windows.Forms.Button()
        Me.txtfldCustomerID = New System.Windows.Forms.TextBox()
        Me.txtfldFirstName = New System.Windows.Forms.TextBox()
        Me.txtfldLastName = New System.Windows.Forms.TextBox()
        Me.txtfldDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtfldTel = New System.Windows.Forms.TextBox()
        Me.txtfldAddress1 = New System.Windows.Forms.TextBox()
        Me.txtfldAddress2 = New System.Windows.Forms.TextBox()
        Me.txtfldPostCode = New System.Windows.Forms.TextBox()
        Me.txtfldEmail = New System.Windows.Forms.TextBox()
        Me.txtfldLicenseNo = New System.Windows.Forms.TextBox()
        Me.fNameError = New System.Windows.Forms.Label()
        Me.lNameError = New System.Windows.Forms.Label()
        Me.telError = New System.Windows.Forms.Label()
        Me.addrL1Error = New System.Windows.Forms.Label()
        Me.addrL2Error = New System.Windows.Forms.Label()
        Me.postCodeError = New System.Windows.Forms.Label()
        Me.emailError = New System.Windows.Forms.Label()
        Me.licenseNoError = New System.Windows.Forms.Label()
        lblCustomerID = New System.Windows.Forms.Label()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblAddress1 = New System.Windows.Forms.Label()
        lblAddress2 = New System.Windows.Forms.Label()
        lblPostCode = New System.Windows.Forms.Label()
        lblEmail = New System.Windows.Forms.Label()
        lblLincenseNo = New System.Windows.Forms.Label()
        lblDOB = New System.Windows.Forms.Label()
        lblTel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCustomerID
        '
        lblCustomerID.AutoSize = True
        lblCustomerID.BackColor = System.Drawing.Color.Transparent
        lblCustomerID.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCustomerID.Location = New System.Drawing.Point(45, 282)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New System.Drawing.Size(107, 21)
        lblCustomerID.TabIndex = 9
        lblCustomerID.Text = "Customer ID"
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.BackColor = System.Drawing.Color.Transparent
        lblFirstName.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblFirstName.Location = New System.Drawing.Point(46, 320)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(98, 21)
        lblFirstName.TabIndex = 11
        lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.BackColor = System.Drawing.Color.Transparent
        lblLastName.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblLastName.Location = New System.Drawing.Point(45, 358)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(99, 21)
        lblLastName.TabIndex = 13
        lblLastName.Text = "Last Name"
        '
        'lblAddress1
        '
        lblAddress1.AutoSize = True
        lblAddress1.BackColor = System.Drawing.Color.Transparent
        lblAddress1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblAddress1.Location = New System.Drawing.Point(45, 472)
        lblAddress1.Name = "lblAddress1"
        lblAddress1.Size = New System.Drawing.Size(82, 21)
        lblAddress1.TabIndex = 19
        lblAddress1.Text = "Address 1"
        '
        'lblAddress2
        '
        lblAddress2.AutoSize = True
        lblAddress2.BackColor = System.Drawing.Color.Transparent
        lblAddress2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblAddress2.Location = New System.Drawing.Point(45, 510)
        lblAddress2.Name = "lblAddress2"
        lblAddress2.Size = New System.Drawing.Size(86, 21)
        lblAddress2.TabIndex = 21
        lblAddress2.Text = "Address 2"
        '
        'lblPostCode
        '
        lblPostCode.AutoSize = True
        lblPostCode.BackColor = System.Drawing.Color.Transparent
        lblPostCode.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblPostCode.Location = New System.Drawing.Point(45, 548)
        lblPostCode.Name = "lblPostCode"
        lblPostCode.Size = New System.Drawing.Size(91, 21)
        lblPostCode.TabIndex = 23
        lblPostCode.Text = "Post Code"
        '
        'lblEmail
        '
        lblEmail.AutoSize = True
        lblEmail.BackColor = System.Drawing.Color.Transparent
        lblEmail.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblEmail.Location = New System.Drawing.Point(46, 586)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New System.Drawing.Size(55, 21)
        lblEmail.TabIndex = 25
        lblEmail.Text = "Email"
        '
        'lblLincenseNo
        '
        lblLincenseNo.AutoSize = True
        lblLincenseNo.BackColor = System.Drawing.Color.Transparent
        lblLincenseNo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblLincenseNo.Location = New System.Drawing.Point(45, 624)
        lblLincenseNo.Name = "lblLincenseNo"
        lblLincenseNo.Size = New System.Drawing.Size(95, 21)
        lblLincenseNo.TabIndex = 27
        lblLincenseNo.Text = "License No"
        '
        'lblDOB
        '
        lblDOB.AutoSize = True
        lblDOB.BackColor = System.Drawing.Color.Transparent
        lblDOB.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblDOB.Location = New System.Drawing.Point(45, 396)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New System.Drawing.Size(49, 21)
        lblDOB.TabIndex = 29
        lblDOB.Text = "DOB"
        '
        'lblTel
        '
        lblTel.AutoSize = True
        lblTel.BackColor = System.Drawing.Color.Transparent
        lblTel.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        lblTel.Location = New System.Drawing.Point(45, 432)
        lblTel.Name = "lblTel"
        lblTel.Size = New System.Drawing.Size(121, 21)
        lblTel.TabIndex = 30
        lblTel.Text = "Telephone No"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'butRental
        '
        Me.butRental.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.butRental.BackgroundImage = CType(resources.GetObject("butRental.BackgroundImage"), System.Drawing.Image)
        Me.butRental.Location = New System.Drawing.Point(256, 0)
        Me.butRental.Name = "butRental"
        Me.butRental.Size = New System.Drawing.Size(225, 46)
        Me.butRental.TabIndex = 1
        Me.butRental.UseVisualStyleBackColor = False
        '
        'butAgreement
        '
        Me.butAgreement.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.butAgreement.BackgroundImage = CType(resources.GetObject("butAgreement.BackgroundImage"), System.Drawing.Image)
        Me.butAgreement.Location = New System.Drawing.Point(543, 0)
        Me.butAgreement.Name = "butAgreement"
        Me.butAgreement.Size = New System.Drawing.Size(225, 46)
        Me.butAgreement.TabIndex = 2
        Me.butAgreement.UseVisualStyleBackColor = False
        '
        'butInvoice
        '
        Me.butInvoice.BackgroundImage = CType(resources.GetObject("butInvoice.BackgroundImage"), System.Drawing.Image)
        Me.butInvoice.Location = New System.Drawing.Point(819, 0)
        Me.butInvoice.Name = "butInvoice"
        Me.butInvoice.Size = New System.Drawing.Size(206, 45)
        Me.butInvoice.TabIndex = 3
        Me.butInvoice.UseVisualStyleBackColor = True
        '
        'butCreate
        '
        Me.butCreate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.butCreate.BackgroundImage = CType(resources.GetObject("butCreate.BackgroundImage"), System.Drawing.Image)
        Me.butCreate.Location = New System.Drawing.Point(517, 761)
        Me.butCreate.Name = "butCreate"
        Me.butCreate.Size = New System.Drawing.Size(93, 34)
        Me.butCreate.TabIndex = 4
        Me.butCreate.UseVisualStyleBackColor = False
        '
        'butClear
        '
        Me.butClear.BackgroundImage = CType(resources.GetObject("butClear.BackgroundImage"), System.Drawing.Image)
        Me.butClear.Location = New System.Drawing.Point(658, 761)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(93, 34)
        Me.butClear.TabIndex = 5
        Me.butClear.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.BackgroundImage = CType(resources.GetObject("butClose.BackgroundImage"), System.Drawing.Image)
        Me.butClose.Location = New System.Drawing.Point(802, 761)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(93, 34)
        Me.butClose.TabIndex = 6
        Me.butClose.UseVisualStyleBackColor = True
        '
        'butSearch
        '
        Me.butSearch.BackgroundImage = CType(resources.GetObject("butSearch.BackgroundImage"), System.Drawing.Image)
        Me.butSearch.Location = New System.Drawing.Point(373, 282)
        Me.butSearch.Name = "butSearch"
        Me.butSearch.Size = New System.Drawing.Size(59, 23)
        Me.butSearch.TabIndex = 7
        Me.butSearch.UseVisualStyleBackColor = True
        '
        'txtfldCustomerID
        '
        Me.txtfldCustomerID.Location = New System.Drawing.Point(188, 283)
        Me.txtfldCustomerID.MaxLength = 6
        Me.txtfldCustomerID.Name = "txtfldCustomerID"
        Me.txtfldCustomerID.Size = New System.Drawing.Size(142, 20)
        Me.txtfldCustomerID.TabIndex = 10
        '
        'txtfldFirstName
        '
        Me.txtfldFirstName.Location = New System.Drawing.Point(188, 321)
        Me.txtfldFirstName.Name = "txtfldFirstName"
        Me.txtfldFirstName.Size = New System.Drawing.Size(142, 20)
        Me.txtfldFirstName.TabIndex = 12
        '
        'txtfldLastName
        '
        Me.txtfldLastName.Location = New System.Drawing.Point(188, 359)
        Me.txtfldLastName.Name = "txtfldLastName"
        Me.txtfldLastName.Size = New System.Drawing.Size(142, 20)
        Me.txtfldLastName.TabIndex = 14
        '
        'txtfldDOB
        '
        Me.txtfldDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfldDOB.Location = New System.Drawing.Point(188, 397)
        Me.txtfldDOB.Name = "txtfldDOB"
        Me.txtfldDOB.Size = New System.Drawing.Size(142, 20)
        Me.txtfldDOB.TabIndex = 16
        Me.txtfldDOB.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'txtfldTel
        '
        Me.txtfldTel.Location = New System.Drawing.Point(188, 435)
        Me.txtfldTel.MaxLength = 11
        Me.txtfldTel.Name = "txtfldTel"
        Me.txtfldTel.Size = New System.Drawing.Size(142, 20)
        Me.txtfldTel.TabIndex = 18
        '
        'txtfldAddress1
        '
        Me.txtfldAddress1.Location = New System.Drawing.Point(188, 473)
        Me.txtfldAddress1.Name = "txtfldAddress1"
        Me.txtfldAddress1.Size = New System.Drawing.Size(142, 20)
        Me.txtfldAddress1.TabIndex = 20
        '
        'txtfldAddress2
        '
        Me.txtfldAddress2.Location = New System.Drawing.Point(188, 511)
        Me.txtfldAddress2.Name = "txtfldAddress2"
        Me.txtfldAddress2.Size = New System.Drawing.Size(142, 20)
        Me.txtfldAddress2.TabIndex = 22
        '
        'txtfldPostCode
        '
        Me.txtfldPostCode.Location = New System.Drawing.Point(188, 549)
        Me.txtfldPostCode.Name = "txtfldPostCode"
        Me.txtfldPostCode.Size = New System.Drawing.Size(142, 20)
        Me.txtfldPostCode.TabIndex = 24
        '
        'txtfldEmail
        '
        Me.txtfldEmail.Location = New System.Drawing.Point(188, 587)
        Me.txtfldEmail.Name = "txtfldEmail"
        Me.txtfldEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtfldEmail.TabIndex = 26
        '
        'txtfldLicenseNo
        '
        Me.txtfldLicenseNo.Location = New System.Drawing.Point(188, 625)
        Me.txtfldLicenseNo.MaxLength = 6
        Me.txtfldLicenseNo.Name = "txtfldLicenseNo"
        Me.txtfldLicenseNo.Size = New System.Drawing.Size(142, 20)
        Me.txtfldLicenseNo.TabIndex = 28
        '
        'fNameError
        '
        Me.fNameError.AutoSize = True
        Me.fNameError.BackColor = System.Drawing.Color.Transparent
        Me.fNameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fNameError.ForeColor = System.Drawing.Color.Red
        Me.fNameError.Location = New System.Drawing.Point(370, 328)
        Me.fNameError.Name = "fNameError"
        Me.fNameError.Size = New System.Drawing.Size(0, 13)
        Me.fNameError.TabIndex = 31
        '
        'lNameError
        '
        Me.lNameError.AutoSize = True
        Me.lNameError.BackColor = System.Drawing.Color.Transparent
        Me.lNameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNameError.ForeColor = System.Drawing.Color.Red
        Me.lNameError.Location = New System.Drawing.Point(370, 366)
        Me.lNameError.Name = "lNameError"
        Me.lNameError.Size = New System.Drawing.Size(0, 13)
        Me.lNameError.TabIndex = 32
        '
        'telError
        '
        Me.telError.AutoSize = True
        Me.telError.BackColor = System.Drawing.Color.Transparent
        Me.telError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telError.ForeColor = System.Drawing.Color.Red
        Me.telError.Location = New System.Drawing.Point(370, 442)
        Me.telError.Name = "telError"
        Me.telError.Size = New System.Drawing.Size(0, 13)
        Me.telError.TabIndex = 33
        '
        'addrL1Error
        '
        Me.addrL1Error.AutoSize = True
        Me.addrL1Error.BackColor = System.Drawing.Color.Transparent
        Me.addrL1Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addrL1Error.ForeColor = System.Drawing.Color.Red
        Me.addrL1Error.Location = New System.Drawing.Point(370, 480)
        Me.addrL1Error.Name = "addrL1Error"
        Me.addrL1Error.Size = New System.Drawing.Size(0, 13)
        Me.addrL1Error.TabIndex = 34
        '
        'addrL2Error
        '
        Me.addrL2Error.AutoSize = True
        Me.addrL2Error.BackColor = System.Drawing.Color.Transparent
        Me.addrL2Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addrL2Error.ForeColor = System.Drawing.Color.Red
        Me.addrL2Error.Location = New System.Drawing.Point(370, 518)
        Me.addrL2Error.Name = "addrL2Error"
        Me.addrL2Error.Size = New System.Drawing.Size(0, 13)
        Me.addrL2Error.TabIndex = 35
        '
        'postCodeError
        '
        Me.postCodeError.AutoSize = True
        Me.postCodeError.BackColor = System.Drawing.Color.Transparent
        Me.postCodeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postCodeError.ForeColor = System.Drawing.Color.Red
        Me.postCodeError.Location = New System.Drawing.Point(370, 556)
        Me.postCodeError.Name = "postCodeError"
        Me.postCodeError.Size = New System.Drawing.Size(0, 13)
        Me.postCodeError.TabIndex = 36
        '
        'emailError
        '
        Me.emailError.AutoSize = True
        Me.emailError.BackColor = System.Drawing.Color.Transparent
        Me.emailError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailError.ForeColor = System.Drawing.Color.Red
        Me.emailError.Location = New System.Drawing.Point(370, 594)
        Me.emailError.Name = "emailError"
        Me.emailError.Size = New System.Drawing.Size(0, 13)
        Me.emailError.TabIndex = 37
        '
        'licenseNoError
        '
        Me.licenseNoError.AutoSize = True
        Me.licenseNoError.BackColor = System.Drawing.Color.Transparent
        Me.licenseNoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.licenseNoError.ForeColor = System.Drawing.Color.Red
        Me.licenseNoError.Location = New System.Drawing.Point(370, 632)
        Me.licenseNoError.Name = "licenseNoError"
        Me.licenseNoError.Size = New System.Drawing.Size(0, 13)
        Me.licenseNoError.TabIndex = 38
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 819)
        Me.Controls.Add(Me.licenseNoError)
        Me.Controls.Add(Me.emailError)
        Me.Controls.Add(Me.postCodeError)
        Me.Controls.Add(Me.addrL2Error)
        Me.Controls.Add(Me.addrL1Error)
        Me.Controls.Add(Me.telError)
        Me.Controls.Add(Me.lNameError)
        Me.Controls.Add(Me.fNameError)
        Me.Controls.Add(lblTel)
        Me.Controls.Add(lblDOB)
        Me.Controls.Add(lblLincenseNo)
        Me.Controls.Add(Me.txtfldLicenseNo)
        Me.Controls.Add(lblEmail)
        Me.Controls.Add(Me.txtfldEmail)
        Me.Controls.Add(lblPostCode)
        Me.Controls.Add(Me.txtfldPostCode)
        Me.Controls.Add(lblAddress2)
        Me.Controls.Add(Me.txtfldAddress2)
        Me.Controls.Add(lblAddress1)
        Me.Controls.Add(Me.txtfldAddress1)
        Me.Controls.Add(Me.txtfldTel)
        Me.Controls.Add(Me.txtfldDOB)
        Me.Controls.Add(lblLastName)
        Me.Controls.Add(Me.txtfldLastName)
        Me.Controls.Add(lblFirstName)
        Me.Controls.Add(Me.txtfldFirstName)
        Me.Controls.Add(lblCustomerID)
        Me.Controls.Add(Me.txtfldCustomerID)
        Me.Controls.Add(Me.butSearch)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butClear)
        Me.Controls.Add(Me.butCreate)
        Me.Controls.Add(Me.butInvoice)
        Me.Controls.Add(Me.butAgreement)
        Me.Controls.Add(Me.butRental)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Joe's Car Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents butRental As Button
    Friend WithEvents butAgreement As Button
    Friend WithEvents butInvoice As Button
    Friend WithEvents butCreate As Button
    Friend WithEvents butClear As Button
    Friend WithEvents butClose As Button
    Friend WithEvents butSearch As Button
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtfldCustomerID As TextBox
    Friend WithEvents txtfldFirstName As TextBox
    Friend WithEvents txtfldLastName As TextBox
    Friend WithEvents txtfldDOB As DateTimePicker
    Friend WithEvents txtfldTel As TextBox
    Friend WithEvents txtfldAddress1 As TextBox
    Friend WithEvents txtfldAddress2 As TextBox
    Friend WithEvents txtfldPostCode As TextBox
    Friend WithEvents txtfldEmail As TextBox
    Friend WithEvents txtfldLicenseNo As TextBox
    Friend WithEvents fNameError As System.Windows.Forms.Label
    Friend WithEvents lNameError As System.Windows.Forms.Label
    Friend WithEvents telError As System.Windows.Forms.Label
    Friend WithEvents addrL1Error As System.Windows.Forms.Label
    Friend WithEvents addrL2Error As System.Windows.Forms.Label
    Friend WithEvents postCodeError As System.Windows.Forms.Label
    Friend WithEvents emailError As System.Windows.Forms.Label
    Friend WithEvents licenseNoError As System.Windows.Forms.Label
End Class
