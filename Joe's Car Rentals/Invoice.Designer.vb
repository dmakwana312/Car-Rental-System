<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.butInvoice = New System.Windows.Forms.Button()
        Me.butAgreement = New System.Windows.Forms.Button()
        Me.butRental = New System.Windows.Forms.Button()
        Me.butCustomer = New System.Windows.Forms.Button()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfldAmountDue = New System.Windows.Forms.TextBox()
        Me.txtfldAmountPaid = New System.Windows.Forms.TextBox()
        Me.txtfldChange = New System.Windows.Forms.TextBox()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.lblNameOnCard = New System.Windows.Forms.Label()
        Me.lblExpiryDate = New System.Windows.Forms.Label()
        Me.lblCardNo = New System.Windows.Forms.Label()
        Me.lblSecurityCode = New System.Windows.Forms.Label()
        Me.txtfldCardNo = New System.Windows.Forms.TextBox()
        Me.txtfldNameOnCard = New System.Windows.Forms.TextBox()
        Me.txtfldSecurityCode = New System.Windows.Forms.TextBox()
        Me.butPay = New System.Windows.Forms.Button()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.rtbReceipt = New System.Windows.Forms.RichTextBox()
        Me.txtfldExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'butInvoice
        '
        Me.butInvoice.BackgroundImage = CType(resources.GetObject("butInvoice.BackgroundImage"), System.Drawing.Image)
        Me.butInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butInvoice.Location = New System.Drawing.Point(819, 0)
        Me.butInvoice.Name = "butInvoice"
        Me.butInvoice.Size = New System.Drawing.Size(206, 46)
        Me.butInvoice.TabIndex = 7
        Me.butInvoice.UseVisualStyleBackColor = True
        '
        'butAgreement
        '
        Me.butAgreement.BackgroundImage = CType(resources.GetObject("butAgreement.BackgroundImage"), System.Drawing.Image)
        Me.butAgreement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butAgreement.Location = New System.Drawing.Point(537, -1)
        Me.butAgreement.Name = "butAgreement"
        Me.butAgreement.Size = New System.Drawing.Size(225, 46)
        Me.butAgreement.TabIndex = 6
        Me.butAgreement.UseVisualStyleBackColor = True
        '
        'butRental
        '
        Me.butRental.BackgroundImage = CType(resources.GetObject("butRental.BackgroundImage"), System.Drawing.Image)
        Me.butRental.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butRental.Location = New System.Drawing.Point(269, -1)
        Me.butRental.Name = "butRental"
        Me.butRental.Size = New System.Drawing.Size(225, 46)
        Me.butRental.TabIndex = 5
        Me.butRental.UseVisualStyleBackColor = True
        '
        'butCustomer
        '
        Me.butCustomer.BackgroundImage = CType(resources.GetObject("butCustomer.BackgroundImage"), System.Drawing.Image)
        Me.butCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butCustomer.Location = New System.Drawing.Point(1, 0)
        Me.butCustomer.Name = "butCustomer"
        Me.butCustomer.Size = New System.Drawing.Size(204, 45)
        Me.butCustomer.TabIndex = 4
        Me.butCustomer.UseVisualStyleBackColor = True
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.BackColor = System.Drawing.Color.Transparent
        Me.lblCash.Font = New System.Drawing.Font("Calisto MT", 28.0!)
        Me.lblCash.Location = New System.Drawing.Point(206, 253)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(102, 44)
        Me.lblCash.TabIndex = 8
        Me.lblCash.Text = "Cash"
        '
        'lblAmountDue
        '
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountDue.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblAmountDue.Location = New System.Drawing.Point(82, 317)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(167, 37)
        Me.lblAmountDue.TabIndex = 9
        Me.lblAmountDue.Text = "Amount Due"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountPaid.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblAmountPaid.Location = New System.Drawing.Point(82, 374)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(170, 37)
        Me.lblAmountPaid.TabIndex = 10
        Me.lblAmountPaid.Text = "Amount Paid"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Change"
        '
        'txtfldAmountDue
        '
        Me.txtfldAmountDue.Location = New System.Drawing.Point(269, 334)
        Me.txtfldAmountDue.Name = "txtfldAmountDue"
        Me.txtfldAmountDue.Size = New System.Drawing.Size(123, 20)
        Me.txtfldAmountDue.TabIndex = 12
        '
        'txtfldAmountPaid
        '
        Me.txtfldAmountPaid.Location = New System.Drawing.Point(269, 391)
        Me.txtfldAmountPaid.Name = "txtfldAmountPaid"
        Me.txtfldAmountPaid.Size = New System.Drawing.Size(123, 20)
        Me.txtfldAmountPaid.TabIndex = 13
        '
        'txtfldChange
        '
        Me.txtfldChange.Enabled = False
        Me.txtfldChange.Location = New System.Drawing.Point(269, 448)
        Me.txtfldChange.Name = "txtfldChange"
        Me.txtfldChange.Size = New System.Drawing.Size(123, 20)
        Me.txtfldChange.TabIndex = 14
        '
        'lblCard
        '
        Me.lblCard.AutoSize = True
        Me.lblCard.BackColor = System.Drawing.Color.Transparent
        Me.lblCard.Font = New System.Drawing.Font("Calisto MT", 28.0!)
        Me.lblCard.Location = New System.Drawing.Point(206, 501)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(100, 44)
        Me.lblCard.TabIndex = 15
        Me.lblCard.Text = "Card"
        '
        'lblNameOnCard
        '
        Me.lblNameOnCard.AutoSize = True
        Me.lblNameOnCard.BackColor = System.Drawing.Color.Transparent
        Me.lblNameOnCard.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblNameOnCard.Location = New System.Drawing.Point(82, 647)
        Me.lblNameOnCard.Name = "lblNameOnCard"
        Me.lblNameOnCard.Size = New System.Drawing.Size(189, 37)
        Me.lblNameOnCard.TabIndex = 18
        Me.lblNameOnCard.Text = "Name on Card"
        '
        'lblExpiryDate
        '
        Me.lblExpiryDate.AutoSize = True
        Me.lblExpiryDate.BackColor = System.Drawing.Color.Transparent
        Me.lblExpiryDate.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblExpiryDate.Location = New System.Drawing.Point(82, 596)
        Me.lblExpiryDate.Name = "lblExpiryDate"
        Me.lblExpiryDate.Size = New System.Drawing.Size(151, 37)
        Me.lblExpiryDate.TabIndex = 17
        Me.lblExpiryDate.Text = "Expiry Date"
        '
        'lblCardNo
        '
        Me.lblCardNo.AutoSize = True
        Me.lblCardNo.BackColor = System.Drawing.Color.Transparent
        Me.lblCardNo.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblCardNo.Location = New System.Drawing.Point(82, 545)
        Me.lblCardNo.Name = "lblCardNo"
        Me.lblCardNo.Size = New System.Drawing.Size(177, 37)
        Me.lblCardNo.TabIndex = 16
        Me.lblCardNo.Text = "Card Number"
        '
        'lblSecurityCode
        '
        Me.lblSecurityCode.AutoSize = True
        Me.lblSecurityCode.BackColor = System.Drawing.Color.Transparent
        Me.lblSecurityCode.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblSecurityCode.Location = New System.Drawing.Point(82, 698)
        Me.lblSecurityCode.Name = "lblSecurityCode"
        Me.lblSecurityCode.Size = New System.Drawing.Size(180, 37)
        Me.lblSecurityCode.TabIndex = 19
        Me.lblSecurityCode.Text = "Security Code"
        '
        'txtfldCardNo
        '
        Me.txtfldCardNo.Location = New System.Drawing.Point(269, 558)
        Me.txtfldCardNo.Name = "txtfldCardNo"
        Me.txtfldCardNo.Size = New System.Drawing.Size(123, 20)
        Me.txtfldCardNo.TabIndex = 20
        '
        'txtfldNameOnCard
        '
        Me.txtfldNameOnCard.Location = New System.Drawing.Point(269, 660)
        Me.txtfldNameOnCard.Name = "txtfldNameOnCard"
        Me.txtfldNameOnCard.Size = New System.Drawing.Size(123, 20)
        Me.txtfldNameOnCard.TabIndex = 22
        '
        'txtfldSecurityCode
        '
        Me.txtfldSecurityCode.Location = New System.Drawing.Point(268, 711)
        Me.txtfldSecurityCode.Name = "txtfldSecurityCode"
        Me.txtfldSecurityCode.Size = New System.Drawing.Size(123, 20)
        Me.txtfldSecurityCode.TabIndex = 23
        '
        'butPay
        '
        Me.butPay.BackgroundImage = CType(resources.GetObject("butPay.BackgroundImage"), System.Drawing.Image)
        Me.butPay.Location = New System.Drawing.Point(502, 754)
        Me.butPay.Name = "butPay"
        Me.butPay.Size = New System.Drawing.Size(93, 34)
        Me.butPay.TabIndex = 24
        Me.butPay.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.BackgroundImage = CType(resources.GetObject("butCancel.BackgroundImage"), System.Drawing.Image)
        Me.butCancel.Location = New System.Drawing.Point(639, 754)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(93, 34)
        Me.butCancel.TabIndex = 25
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'rtbReceipt
        '
        Me.rtbReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbReceipt.Location = New System.Drawing.Point(547, 279)
        Me.rtbReceipt.Name = "rtbReceipt"
        Me.rtbReceipt.ReadOnly = True
        Me.rtbReceipt.Size = New System.Drawing.Size(315, 419)
        Me.rtbReceipt.TabIndex = 26
        Me.rtbReceipt.Text = ""
        '
        'txtfldExpiryDate
        '
        Me.txtfldExpiryDate.Location = New System.Drawing.Point(269, 612)
        Me.txtfldExpiryDate.Name = "txtfldExpiryDate"
        Me.txtfldExpiryDate.Size = New System.Drawing.Size(123, 20)
        Me.txtfldExpiryDate.TabIndex = 27
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 819)
        Me.Controls.Add(Me.txtfldExpiryDate)
        Me.Controls.Add(Me.rtbReceipt)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butPay)
        Me.Controls.Add(Me.txtfldSecurityCode)
        Me.Controls.Add(Me.txtfldNameOnCard)
        Me.Controls.Add(Me.txtfldCardNo)
        Me.Controls.Add(Me.lblSecurityCode)
        Me.Controls.Add(Me.lblNameOnCard)
        Me.Controls.Add(Me.lblExpiryDate)
        Me.Controls.Add(Me.lblCardNo)
        Me.Controls.Add(Me.lblCard)
        Me.Controls.Add(Me.txtfldChange)
        Me.Controls.Add(Me.txtfldAmountPaid)
        Me.Controls.Add(Me.txtfldAmountDue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.butInvoice)
        Me.Controls.Add(Me.butAgreement)
        Me.Controls.Add(Me.butRental)
        Me.Controls.Add(Me.butCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butInvoice As System.Windows.Forms.Button
    Friend WithEvents butAgreement As System.Windows.Forms.Button
    Friend WithEvents butRental As System.Windows.Forms.Button
    Friend WithEvents butCustomer As System.Windows.Forms.Button
    Friend WithEvents lblCash As Label
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfldAmountDue As TextBox
    Friend WithEvents txtfldAmountPaid As TextBox
    Friend WithEvents txtfldChange As TextBox
    Friend WithEvents lblCard As Label
    Friend WithEvents lblNameOnCard As Label
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents lblCardNo As Label
    Friend WithEvents lblSecurityCode As Label
    Friend WithEvents txtfldCardNo As TextBox
    Friend WithEvents txtfldNameOnCard As TextBox
    Friend WithEvents txtfldSecurityCode As TextBox
    Friend WithEvents butPay As Button
    Friend WithEvents butCancel As Button
    Friend WithEvents rtbReceipt As RichTextBox
    Friend WithEvents txtfldExpiryDate As DateTimePicker
End Class
