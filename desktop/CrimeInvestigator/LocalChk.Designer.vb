<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocalChk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocalChk))
        Me.label_match_status = New System.Windows.Forms.Label
        Me.buttton_compare = New System.Windows.Forms.Button
        Me.buttton_load_fingerprint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.combobox_crimes = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.textbox_convict_file = New System.Windows.Forms.TextBox
        Me.label_convict_file = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.button_refresh_listing = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.AxGrFingerXCtrl1 = New AxGrFingerXLib.AxGrFingerXCtrl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.picture_box_target = New System.Windows.Forms.PictureBox
        Me.picture_box_source = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picture_box_target, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture_box_source, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_match_status
        '
        Me.label_match_status.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_match_status.Location = New System.Drawing.Point(354, 175)
        Me.label_match_status.Name = "label_match_status"
        Me.label_match_status.Size = New System.Drawing.Size(164, 26)
        Me.label_match_status.TabIndex = 69
        '
        'buttton_compare
        '
        Me.buttton_compare.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttton_compare.Location = New System.Drawing.Point(220, 47)
        Me.buttton_compare.Name = "buttton_compare"
        Me.buttton_compare.Size = New System.Drawing.Size(121, 25)
        Me.buttton_compare.TabIndex = 57
        Me.buttton_compare.Text = "Compare"
        Me.buttton_compare.UseVisualStyleBackColor = True
        '
        'buttton_load_fingerprint
        '
        Me.buttton_load_fingerprint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttton_load_fingerprint.Location = New System.Drawing.Point(18, 175)
        Me.buttton_load_fingerprint.Name = "buttton_load_fingerprint"
        Me.buttton_load_fingerprint.Size = New System.Drawing.Size(175, 26)
        Me.buttton_load_fingerprint.TabIndex = 60
        Me.buttton_load_fingerprint.Text = "Load Finger Print"
        Me.buttton_load_fingerprint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local Check"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.combobox_crimes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.textbox_convict_file)
        Me.GroupBox2.Controls.Add(Me.label_convict_file)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 205)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Details"
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(0, 14)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(336, 144)
        Me.ListBox2.TabIndex = 63
        '
        'combobox_crimes
        '
        Me.combobox_crimes.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_crimes.FormattingEnabled = True
        Me.combobox_crimes.Location = New System.Drawing.Point(95, 159)
        Me.combobox_crimes.Name = "combobox_crimes"
        Me.combobox_crimes.Size = New System.Drawing.Size(212, 27)
        Me.combobox_crimes.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Crime(s):"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(95, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(212, 27)
        Me.TextBox2.TabIndex = 34
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(95, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 27)
        Me.TextBox1.TabIndex = 33
        '
        'textbox_convict_file
        '
        Me.textbox_convict_file.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_convict_file.Location = New System.Drawing.Point(95, 38)
        Me.textbox_convict_file.Name = "textbox_convict_file"
        Me.textbox_convict_file.Size = New System.Drawing.Size(212, 27)
        Me.textbox_convict_file.TabIndex = 32
        '
        'label_convict_file
        '
        Me.label_convict_file.AutoSize = True
        Me.label_convict_file.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_convict_file.Location = New System.Drawing.Point(8, 44)
        Me.label_convict_file.Name = "label_convict_file"
        Me.label_convict_file.Size = New System.Drawing.Size(78, 16)
        Me.label_convict_file.TabIndex = 23
        Me.label_convict_file.Text = "Convict File:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "First Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Last Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.button_refresh_listing)
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(351, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(174, 205)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FingerPrint"
        '
        'button_refresh_listing
        '
        Me.button_refresh_listing.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_refresh_listing.Location = New System.Drawing.Point(8, 176)
        Me.button_refresh_listing.Name = "button_refresh_listing"
        Me.button_refresh_listing.Size = New System.Drawing.Size(159, 25)
        Me.button_refresh_listing.TabIndex = 34
        Me.button_refresh_listing.Text = "Refresh Lisiting"
        Me.button_refresh_listing.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(8, 26)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(160, 148)
        Me.ListBox1.TabIndex = 27
        '
        'AxGrFingerXCtrl1
        '
        Me.AxGrFingerXCtrl1.Enabled = True
        Me.AxGrFingerXCtrl1.Location = New System.Drawing.Point(255, 139)
        Me.AxGrFingerXCtrl1.Name = "AxGrFingerXCtrl1"
        Me.AxGrFingerXCtrl1.OcxState = CType(resources.GetObject("AxGrFingerXCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxGrFingerXCtrl1.Size = New System.Drawing.Size(32, 32)
        Me.AxGrFingerXCtrl1.TabIndex = 63
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.picture_box_target)
        Me.Panel1.Controls.Add(Me.AxGrFingerXCtrl1)
        Me.Panel1.Controls.Add(Me.picture_box_source)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.buttton_load_fingerprint)
        Me.Panel1.Controls.Add(Me.buttton_compare)
        Me.Panel1.Controls.Add(Me.label_match_status)
        Me.Panel1.Location = New System.Drawing.Point(14, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 434)
        Me.Panel1.TabIndex = 63
        '
        'picture_box_target
        '
        Me.picture_box_target.BackColor = System.Drawing.SystemColors.Control
        Me.picture_box_target.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picture_box_target.Location = New System.Drawing.Point(351, 16)
        Me.picture_box_target.Name = "picture_box_target"
        Me.picture_box_target.Size = New System.Drawing.Size(177, 156)
        Me.picture_box_target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture_box_target.TabIndex = 70
        Me.picture_box_target.TabStop = False
        '
        'picture_box_source
        '
        Me.picture_box_source.BackColor = System.Drawing.SystemColors.Control
        Me.picture_box_source.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picture_box_source.Location = New System.Drawing.Point(16, 15)
        Me.picture_box_source.Name = "picture_box_source"
        Me.picture_box_source.Size = New System.Drawing.Size(177, 156)
        Me.picture_box_source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture_box_source.TabIndex = 62
        Me.picture_box_source.TabStop = False
        '
        'LocalChk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LocalChk"
        Me.Text = "LocalChk"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picture_box_target, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture_box_source, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label_match_status As System.Windows.Forms.Label
    Friend WithEvents buttton_compare As System.Windows.Forms.Button
    Friend WithEvents buttton_load_fingerprint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents combobox_crimes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents textbox_convict_file As System.Windows.Forms.TextBox
    Friend WithEvents label_convict_file As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents button_refresh_listing As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents AxGrFingerXCtrl1 As AxGrFingerXLib.AxGrFingerXCtrl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picture_box_source As System.Windows.Forms.PictureBox
    Friend WithEvents picture_box_target As System.Windows.Forms.PictureBox
End Class
