<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.status_label = New System.Windows.Forms.Label
        Me.admin_label = New System.Windows.Forms.Label
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.textbox_password = New System.Windows.Forms.TextBox
        Me.textbox_username = New System.Windows.Forms.TextBox
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'status_label
        '
        Me.status_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.status_label.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_label.Location = New System.Drawing.Point(143, 207)
        Me.status_label.Name = "status_label"
        Me.status_label.Size = New System.Drawing.Size(216, 19)
        Me.status_label.TabIndex = 16
        Me.status_label.Text = "&Invalid Username Or Password!"
        Me.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_label
        '
        Me.admin_label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admin_label.AutoSize = True
        Me.admin_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.admin_label.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_label.Location = New System.Drawing.Point(141, 9)
        Me.admin_label.Name = "admin_label"
        Me.admin_label.Size = New System.Drawing.Size(125, 27)
        Me.admin_label.TabIndex = 15
        Me.admin_label.Text = "&Admin Login"
        Me.admin_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(255, 168)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 26)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(146, 168)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 26)
        Me.OK.TabIndex = 13
        Me.OK.Text = "&OK"
        '
        'textbox_password
        '
        Me.textbox_password.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_password.Location = New System.Drawing.Point(146, 131)
        Me.textbox_password.Name = "textbox_password"
        Me.textbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textbox_password.Size = New System.Drawing.Size(203, 21)
        Me.textbox_password.TabIndex = 12
        '
        'textbox_username
        '
        Me.textbox_username.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_username.Location = New System.Drawing.Point(146, 75)
        Me.textbox_username.Name = "textbox_username"
        Me.textbox_username.Size = New System.Drawing.Size(203, 21)
        Me.textbox_username.TabIndex = 10
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(143, 111)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(64, 20)
        Me.PasswordLabel.TabIndex = 11
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(143, 53)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 8
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 69)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(104, 79)
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'FormLogin
        '
        Me.AcceptButton = Me.Cancel
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 234)
        Me.Controls.Add(Me.status_label)
        Me.Controls.Add(Me.admin_label)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.textbox_password)
        Me.Controls.Add(Me.textbox_username)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FormLogin"
        Me.Text = "Admin Login Page"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents status_label As System.Windows.Forms.Label
    Friend WithEvents admin_label As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents textbox_password As System.Windows.Forms.TextBox
    Friend WithEvents textbox_username As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

End Class
