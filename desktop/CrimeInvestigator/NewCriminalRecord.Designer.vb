<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCriminalRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCriminalRecord))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.button_cancel = New System.Windows.Forms.Button
        Me.button_clear = New System.Windows.Forms.Button
        Me.button_save = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.button_load_fingerprint = New System.Windows.Forms.Button
        Me.picture_box_fingerprint = New System.Windows.Forms.PictureBox
        Me.button_capture_fingerprint = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.textbox_year = New System.Windows.Forms.TextBox
        Me.textbox_weight = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.combobox_crimes = New System.Windows.Forms.ComboBox
        Me.combobox_month = New System.Windows.Forms.ComboBox
        Me.combobox_day = New System.Windows.Forms.ComboBox
        Me.textbox_height = New System.Windows.Forms.TextBox
        Me.textbox_state = New System.Windows.Forms.TextBox
        Me.textbox_address = New System.Windows.Forms.TextBox
        Me.textbox_city = New System.Windows.Forms.TextBox
        Me.textbox_lname = New System.Windows.Forms.TextBox
        Me.textbox_fname = New System.Windows.Forms.TextBox
        Me.textbox_convict_file = New System.Windows.Forms.TextBox
        Me.label_convict_file = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.picture_box_passport = New System.Windows.Forms.PictureBox
        Me.button_change_passport = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxGrFingerXCtrl1 = New AxGrFingerXLib.AxGrFingerXCtrl
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picture_box_fingerprint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picture_box_passport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.button_cancel)
        Me.Panel1.Controls.Add(Me.button_clear)
        Me.Panel1.Controls.Add(Me.button_save)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AxGrFingerXCtrl1)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 469)
        Me.Panel1.TabIndex = 14
        '
        'button_cancel
        '
        Me.button_cancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancel.Location = New System.Drawing.Point(349, 432)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(104, 28)
        Me.button_cancel.TabIndex = 31
        Me.button_cancel.Text = "Cancel"
        Me.button_cancel.UseVisualStyleBackColor = True
        '
        'button_clear
        '
        Me.button_clear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_clear.Location = New System.Drawing.Point(239, 432)
        Me.button_clear.Name = "button_clear"
        Me.button_clear.Size = New System.Drawing.Size(104, 28)
        Me.button_clear.TabIndex = 30
        Me.button_clear.Text = "Clear Changes"
        Me.button_clear.UseVisualStyleBackColor = True
        '
        'button_save
        '
        Me.button_save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_save.Location = New System.Drawing.Point(123, 432)
        Me.button_save.Name = "button_save"
        Me.button_save.Size = New System.Drawing.Size(110, 28)
        Me.button_save.TabIndex = 26
        Me.button_save.Text = "Save Changes"
        Me.button_save.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.button_load_fingerprint)
        Me.GroupBox3.Controls.Add(Me.picture_box_fingerprint)
        Me.GroupBox3.Controls.Add(Me.button_capture_fingerprint)
        Me.GroupBox3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(398, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(156, 195)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FingerPrint"
        '
        'button_load_fingerprint
        '
        Me.button_load_fingerprint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_load_fingerprint.Location = New System.Drawing.Point(88, 165)
        Me.button_load_fingerprint.Name = "button_load_fingerprint"
        Me.button_load_fingerprint.Size = New System.Drawing.Size(65, 26)
        Me.button_load_fingerprint.TabIndex = 26
        Me.button_load_fingerprint.Text = "Load..."
        Me.button_load_fingerprint.UseVisualStyleBackColor = True
        '
        'picture_box_fingerprint
        '
        Me.picture_box_fingerprint.Image = CType(resources.GetObject("picture_box_fingerprint.Image"), System.Drawing.Image)
        Me.picture_box_fingerprint.Location = New System.Drawing.Point(7, 25)
        Me.picture_box_fingerprint.Name = "picture_box_fingerprint"
        Me.picture_box_fingerprint.Size = New System.Drawing.Size(143, 136)
        Me.picture_box_fingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture_box_fingerprint.TabIndex = 24
        Me.picture_box_fingerprint.TabStop = False
        '
        'button_capture_fingerprint
        '
        Me.button_capture_fingerprint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_capture_fingerprint.Location = New System.Drawing.Point(7, 166)
        Me.button_capture_fingerprint.Name = "button_capture_fingerprint"
        Me.button_capture_fingerprint.Size = New System.Drawing.Size(75, 26)
        Me.button_capture_fingerprint.TabIndex = 25
        Me.button_capture_fingerprint.Text = "Capture"
        Me.button_capture_fingerprint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.textbox_year)
        Me.GroupBox2.Controls.Add(Me.textbox_weight)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.combobox_crimes)
        Me.GroupBox2.Controls.Add(Me.combobox_month)
        Me.GroupBox2.Controls.Add(Me.combobox_day)
        Me.GroupBox2.Controls.Add(Me.textbox_height)
        Me.GroupBox2.Controls.Add(Me.textbox_state)
        Me.GroupBox2.Controls.Add(Me.textbox_address)
        Me.GroupBox2.Controls.Add(Me.textbox_city)
        Me.GroupBox2.Controls.Add(Me.textbox_lname)
        Me.GroupBox2.Controls.Add(Me.textbox_fname)
        Me.GroupBox2.Controls.Add(Me.textbox_convict_file)
        Me.GroupBox2.Controls.Add(Me.label_convict_file)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 407)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Details"
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(78, 237)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(293, 144)
        Me.ListBox2.TabIndex = 64
        '
        'textbox_year
        '
        Me.textbox_year.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_year.Location = New System.Drawing.Point(213, 263)
        Me.textbox_year.Multiline = True
        Me.textbox_year.Name = "textbox_year"
        Me.textbox_year.Size = New System.Drawing.Size(109, 25)
        Me.textbox_year.TabIndex = 45
        '
        'textbox_weight
        '
        Me.textbox_weight.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_weight.Location = New System.Drawing.Point(110, 376)
        Me.textbox_weight.Name = "textbox_weight"
        Me.textbox_weight.Size = New System.Drawing.Size(72, 23)
        Me.textbox_weight.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Weight:"
        '
        'combobox_crimes
        '
        Me.combobox_crimes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_crimes.FormattingEnabled = True
        Me.combobox_crimes.Location = New System.Drawing.Point(110, 302)
        Me.combobox_crimes.Name = "combobox_crimes"
        Me.combobox_crimes.Size = New System.Drawing.Size(212, 26)
        Me.combobox_crimes.TabIndex = 42
        '
        'combobox_month
        '
        Me.combobox_month.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_month.FormattingEnabled = True
        Me.combobox_month.Location = New System.Drawing.Point(163, 263)
        Me.combobox_month.Name = "combobox_month"
        Me.combobox_month.Size = New System.Drawing.Size(44, 26)
        Me.combobox_month.TabIndex = 41
        '
        'combobox_day
        '
        Me.combobox_day.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_day.FormattingEnabled = True
        Me.combobox_day.Location = New System.Drawing.Point(110, 263)
        Me.combobox_day.Name = "combobox_day"
        Me.combobox_day.Size = New System.Drawing.Size(44, 26)
        Me.combobox_day.TabIndex = 39
        '
        'textbox_height
        '
        Me.textbox_height.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_height.Location = New System.Drawing.Point(110, 340)
        Me.textbox_height.Name = "textbox_height"
        Me.textbox_height.Size = New System.Drawing.Size(72, 23)
        Me.textbox_height.TabIndex = 38
        '
        'textbox_state
        '
        Me.textbox_state.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_state.Location = New System.Drawing.Point(110, 227)
        Me.textbox_state.Name = "textbox_state"
        Me.textbox_state.Size = New System.Drawing.Size(212, 23)
        Me.textbox_state.TabIndex = 37
        '
        'textbox_address
        '
        Me.textbox_address.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_address.Location = New System.Drawing.Point(110, 189)
        Me.textbox_address.Name = "textbox_address"
        Me.textbox_address.Size = New System.Drawing.Size(212, 23)
        Me.textbox_address.TabIndex = 36
        '
        'textbox_city
        '
        Me.textbox_city.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_city.Location = New System.Drawing.Point(110, 152)
        Me.textbox_city.Name = "textbox_city"
        Me.textbox_city.Size = New System.Drawing.Size(212, 23)
        Me.textbox_city.TabIndex = 35
        '
        'textbox_lname
        '
        Me.textbox_lname.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_lname.Location = New System.Drawing.Point(110, 112)
        Me.textbox_lname.Name = "textbox_lname"
        Me.textbox_lname.Size = New System.Drawing.Size(212, 23)
        Me.textbox_lname.TabIndex = 34
        '
        'textbox_fname
        '
        Me.textbox_fname.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_fname.Location = New System.Drawing.Point(110, 73)
        Me.textbox_fname.Name = "textbox_fname"
        Me.textbox_fname.Size = New System.Drawing.Size(212, 23)
        Me.textbox_fname.TabIndex = 33
        '
        'textbox_convict_file
        '
        Me.textbox_convict_file.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_convict_file.Location = New System.Drawing.Point(110, 37)
        Me.textbox_convict_file.Name = "textbox_convict_file"
        Me.textbox_convict_file.Size = New System.Drawing.Size(212, 23)
        Me.textbox_convict_file.TabIndex = 32
        '
        'label_convict_file
        '
        Me.label_convict_file.AutoSize = True
        Me.label_convict_file.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_convict_file.Location = New System.Drawing.Point(15, 39)
        Me.label_convict_file.Name = "label_convict_file"
        Me.label_convict_file.Size = New System.Drawing.Size(82, 18)
        Me.label_convict_file.TabIndex = 23
        Me.label_convict_file.Text = "Convict File:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "State:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Height:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Crime(s):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Date Of Birth:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Last Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Address:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picture_box_passport)
        Me.GroupBox1.Controls.Add(Me.button_change_passport)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(398, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 198)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Passport"
        '
        'picture_box_passport
        '
        Me.picture_box_passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picture_box_passport.Image = CType(resources.GetObject("picture_box_passport.Image"), System.Drawing.Image)
        Me.picture_box_passport.Location = New System.Drawing.Point(7, 25)
        Me.picture_box_passport.Name = "picture_box_passport"
        Me.picture_box_passport.Size = New System.Drawing.Size(143, 136)
        Me.picture_box_passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture_box_passport.TabIndex = 24
        Me.picture_box_passport.TabStop = False
        '
        'button_change_passport
        '
        Me.button_change_passport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_change_passport.Location = New System.Drawing.Point(6, 165)
        Me.button_change_passport.Name = "button_change_passport"
        Me.button_change_passport.Size = New System.Drawing.Size(143, 28)
        Me.button_change_passport.TabIndex = 25
        Me.button_change_passport.Text = "Change Passport..."
        Me.button_change_passport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 35)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "New Criminal Record"
        Me.Label1.Visible = False
        '
        'AxGrFingerXCtrl1
        '
        Me.AxGrFingerXCtrl1.Enabled = True
        Me.AxGrFingerXCtrl1.Location = New System.Drawing.Point(366, 200)
        Me.AxGrFingerXCtrl1.Name = "AxGrFingerXCtrl1"
        Me.AxGrFingerXCtrl1.OcxState = CType(resources.GetObject("AxGrFingerXCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxGrFingerXCtrl1.Size = New System.Drawing.Size(32, 32)
        Me.AxGrFingerXCtrl1.TabIndex = 32
        '
        'NewCriminalRecord
        '
        Me.AcceptButton = Me.button_cancel
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 497)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewCriminalRecord"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.picture_box_fingerprint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picture_box_passport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents button_clear As System.Windows.Forms.Button
    Friend WithEvents button_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents button_load_fingerprint As System.Windows.Forms.Button
    Friend WithEvents picture_box_fingerprint As System.Windows.Forms.PictureBox
    Friend WithEvents button_capture_fingerprint As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents textbox_year As System.Windows.Forms.TextBox
    Friend WithEvents textbox_weight As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents combobox_crimes As System.Windows.Forms.ComboBox
    Friend WithEvents combobox_month As System.Windows.Forms.ComboBox
    Friend WithEvents combobox_day As System.Windows.Forms.ComboBox
    Friend WithEvents textbox_height As System.Windows.Forms.TextBox
    Friend WithEvents textbox_state As System.Windows.Forms.TextBox
    Friend WithEvents textbox_address As System.Windows.Forms.TextBox
    Friend WithEvents textbox_city As System.Windows.Forms.TextBox
    Friend WithEvents textbox_lname As System.Windows.Forms.TextBox
    Friend WithEvents textbox_fname As System.Windows.Forms.TextBox
    Friend WithEvents textbox_convict_file As System.Windows.Forms.TextBox
    Friend WithEvents label_convict_file As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picture_box_passport As System.Windows.Forms.PictureBox
    Friend WithEvents button_change_passport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AxGrFingerXCtrl1 As AxGrFingerXLib.AxGrFingerXCtrl
End Class
