<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtfldUsername = New System.Windows.Forms.TextBox()
        Me.txtfldPassword = New System.Windows.Forms.TextBox()
        Me.butEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Berlin Sans FB Demi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(146, 192)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(106, 24)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Berlin Sans FB Demi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(146, 246)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(102, 24)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'txtfldUsername
        '
        Me.txtfldUsername.Location = New System.Drawing.Point(258, 196)
        Me.txtfldUsername.MaxLength = 10
        Me.txtfldUsername.Name = "txtfldUsername"
        Me.txtfldUsername.Size = New System.Drawing.Size(98, 20)
        Me.txtfldUsername.TabIndex = 2
        '
        'txtfldPassword
        '
        Me.txtfldPassword.Location = New System.Drawing.Point(258, 252)
        Me.txtfldPassword.MaxLength = 10
        Me.txtfldPassword.Name = "txtfldPassword"
        Me.txtfldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtfldPassword.Size = New System.Drawing.Size(98, 20)
        Me.txtfldPassword.TabIndex = 3
        Me.txtfldPassword.UseSystemPasswordChar = True
        '
        'butEnter
        '
        Me.butEnter.BackgroundImage = CType(resources.GetObject("butEnter.BackgroundImage"), System.Drawing.Image)
        Me.butEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butEnter.Location = New System.Drawing.Point(225, 298)
        Me.butEnter.Name = "butEnter"
        Me.butEnter.Size = New System.Drawing.Size(76, 29)
        Me.butEnter.TabIndex = 4
        Me.butEnter.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(512, 384)
        Me.Controls.Add(Me.butEnter)
        Me.Controls.Add(Me.txtfldPassword)
        Me.Controls.Add(Me.txtfldUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtfldUsername As TextBox
    Friend WithEvents txtfldPassword As TextBox
    Friend WithEvents butEnter As Button
End Class
