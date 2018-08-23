<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agreement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agreement))
        Me.butCustomer = New System.Windows.Forms.Button()
        Me.butRental = New System.Windows.Forms.Button()
        Me.butAgreement = New System.Windows.Forms.Button()
        Me.butInvoice = New System.Windows.Forms.Button()
        Me.rtnAgreement = New System.Windows.Forms.RichTextBox()
        Me.butAccept = New System.Windows.Forms.Button()
        Me.butDecline = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.butRental.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butRental.Location = New System.Drawing.Point(268, -1)
        Me.butRental.Name = "butRental"
        Me.butRental.Size = New System.Drawing.Size(225, 46)
        Me.butRental.TabIndex = 1
        Me.butRental.UseVisualStyleBackColor = True
        '
        'butAgreement
        '
        Me.butAgreement.BackgroundImage = CType(resources.GetObject("butAgreement.BackgroundImage"), System.Drawing.Image)
        Me.butAgreement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butAgreement.Location = New System.Drawing.Point(536, -1)
        Me.butAgreement.Name = "butAgreement"
        Me.butAgreement.Size = New System.Drawing.Size(225, 46)
        Me.butAgreement.TabIndex = 2
        Me.butAgreement.UseVisualStyleBackColor = True
        '
        'butInvoice
        '
        Me.butInvoice.BackgroundImage = CType(resources.GetObject("butInvoice.BackgroundImage"), System.Drawing.Image)
        Me.butInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butInvoice.Location = New System.Drawing.Point(818, 0)
        Me.butInvoice.Name = "butInvoice"
        Me.butInvoice.Size = New System.Drawing.Size(206, 46)
        Me.butInvoice.TabIndex = 3
        Me.butInvoice.UseVisualStyleBackColor = True
        '
        'rtnAgreement
        '
        Me.rtnAgreement.Location = New System.Drawing.Point(48, 226)
        Me.rtnAgreement.Name = "rtnAgreement"
        Me.rtnAgreement.ReadOnly = True
        Me.rtnAgreement.Size = New System.Drawing.Size(925, 475)
        Me.rtnAgreement.TabIndex = 4
        Me.rtnAgreement.Text = resources.GetString("rtnAgreement.Text")
        '
        'butAccept
        '
        Me.butAccept.BackgroundImage = CType(resources.GetObject("butAccept.BackgroundImage"), System.Drawing.Image)
        Me.butAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butAccept.Location = New System.Drawing.Point(461, 744)
        Me.butAccept.Name = "butAccept"
        Me.butAccept.Size = New System.Drawing.Size(93, 34)
        Me.butAccept.TabIndex = 5
        Me.butAccept.UseVisualStyleBackColor = True
        '
        'butDecline
        '
        Me.butDecline.BackgroundImage = CType(resources.GetObject("butDecline.BackgroundImage"), System.Drawing.Image)
        Me.butDecline.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butDecline.Location = New System.Drawing.Point(623, 744)
        Me.butDecline.Name = "butDecline"
        Me.butDecline.Size = New System.Drawing.Size(93, 34)
        Me.butDecline.TabIndex = 6
        Me.butDecline.UseVisualStyleBackColor = True
        '
        'Agreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 819)
        Me.Controls.Add(Me.butDecline)
        Me.Controls.Add(Me.butAccept)
        Me.Controls.Add(Me.rtnAgreement)
        Me.Controls.Add(Me.butInvoice)
        Me.Controls.Add(Me.butAgreement)
        Me.Controls.Add(Me.butRental)
        Me.Controls.Add(Me.butCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agreement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agreement"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents butCustomer As Button
    Friend WithEvents butRental As Button
    Friend WithEvents butAgreement As Button
    Friend WithEvents butInvoice As Button
    Friend WithEvents rtnAgreement As RichTextBox
    Friend WithEvents butAccept As Button
    Friend WithEvents butDecline As Button
End Class
