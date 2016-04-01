<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnlineCheck
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.button_test_connection = New System.Windows.Forms.Button
        Me.combobox_server_protocol = New System.Windows.Forms.ComboBox
        Me.label_server_protocol = New System.Windows.Forms.Label
        Me.label_server_port = New System.Windows.Forms.Label
        Me.combobox_server_port = New System.Windows.Forms.ComboBox
        Me.label_server_ip = New System.Windows.Forms.Label
        Me.combobox_server_ip = New System.Windows.Forms.ComboBox
        Me.groupbox_server_details = New System.Windows.Forms.GroupBox
        Me.groupbox_data_transfer = New System.Windows.Forms.GroupBox
        Me.button_refresh = New System.Windows.Forms.Button
        Me.picturebox_server = New System.Windows.Forms.PictureBox
        Me.button_capture_fingerprint = New System.Windows.Forms.Button
        Me.button_load_fingerprint = New System.Windows.Forms.Button
        Me.picturebox_fingerprint = New System.Windows.Forms.PictureBox
        Me.button_send_to_server = New System.Windows.Forms.Button
        Me.button_stop_sending = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.groupbox_server_details.SuspendLayout()
        Me.groupbox_data_transfer.SuspendLayout()
        CType(Me.picturebox_server, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturebox_fingerprint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_test_connection
        '
        Me.button_test_connection.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_test_connection.Location = New System.Drawing.Point(426, 65)
        Me.button_test_connection.Name = "button_test_connection"
        Me.button_test_connection.Size = New System.Drawing.Size(94, 24)
        Me.button_test_connection.TabIndex = 1
        Me.button_test_connection.Text = "Test Connection"
        Me.button_test_connection.UseVisualStyleBackColor = True
        '
        'combobox_server_protocol
        '
        Me.combobox_server_protocol.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_server_protocol.FormattingEnabled = True
        Me.combobox_server_protocol.Items.AddRange(New Object() {"http", "https", "tcp"})
        Me.combobox_server_protocol.Location = New System.Drawing.Point(426, 33)
        Me.combobox_server_protocol.Name = "combobox_server_protocol"
        Me.combobox_server_protocol.Size = New System.Drawing.Size(94, 24)
        Me.combobox_server_protocol.TabIndex = 2
        Me.combobox_server_protocol.Text = "http"
        '
        'label_server_protocol
        '
        Me.label_server_protocol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label_server_protocol.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_server_protocol.Location = New System.Drawing.Point(353, 34)
        Me.label_server_protocol.Name = "label_server_protocol"
        Me.label_server_protocol.Size = New System.Drawing.Size(67, 21)
        Me.label_server_protocol.TabIndex = 3
        Me.label_server_protocol.Text = "Protocol:"
        '
        'label_server_port
        '
        Me.label_server_port.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label_server_port.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_server_port.Location = New System.Drawing.Point(6, 65)
        Me.label_server_port.Name = "label_server_port"
        Me.label_server_port.Size = New System.Drawing.Size(85, 21)
        Me.label_server_port.TabIndex = 5
        Me.label_server_port.Text = "Server Port:"
        '
        'combobox_server_port
        '
        Me.combobox_server_port.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_server_port.FormattingEnabled = True
        Me.combobox_server_port.Location = New System.Drawing.Point(87, 62)
        Me.combobox_server_port.Name = "combobox_server_port"
        Me.combobox_server_port.Size = New System.Drawing.Size(67, 24)
        Me.combobox_server_port.TabIndex = 4
        Me.combobox_server_port.Text = "9090"
        '
        'label_server_ip
        '
        Me.label_server_ip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label_server_ip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_server_ip.Location = New System.Drawing.Point(6, 34)
        Me.label_server_ip.Name = "label_server_ip"
        Me.label_server_ip.Size = New System.Drawing.Size(72, 19)
        Me.label_server_ip.TabIndex = 7
        Me.label_server_ip.Text = "Server IP:"
        '
        'combobox_server_ip
        '
        Me.combobox_server_ip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combobox_server_ip.FormattingEnabled = True
        Me.combobox_server_ip.Items.AddRange(New Object() {"255.255.255.255"})
        Me.combobox_server_ip.Location = New System.Drawing.Point(87, 31)
        Me.combobox_server_ip.Name = "combobox_server_ip"
        Me.combobox_server_ip.Size = New System.Drawing.Size(123, 24)
        Me.combobox_server_ip.TabIndex = 6
        Me.combobox_server_ip.Text = "255.255.255.255"
        '
        'groupbox_server_details
        '
        Me.groupbox_server_details.AutoSize = True
        Me.groupbox_server_details.Controls.Add(Me.label_server_ip)
        Me.groupbox_server_details.Controls.Add(Me.button_test_connection)
        Me.groupbox_server_details.Controls.Add(Me.combobox_server_protocol)
        Me.groupbox_server_details.Controls.Add(Me.label_server_protocol)
        Me.groupbox_server_details.Controls.Add(Me.combobox_server_port)
        Me.groupbox_server_details.Controls.Add(Me.label_server_port)
        Me.groupbox_server_details.Controls.Add(Me.combobox_server_ip)
        Me.groupbox_server_details.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox_server_details.Location = New System.Drawing.Point(13, 10)
        Me.groupbox_server_details.Name = "groupbox_server_details"
        Me.groupbox_server_details.Size = New System.Drawing.Size(531, 114)
        Me.groupbox_server_details.TabIndex = 8
        Me.groupbox_server_details.TabStop = False
        Me.groupbox_server_details.Text = "Server Details"
        '
        'groupbox_data_transfer
        '
        Me.groupbox_data_transfer.Controls.Add(Me.button_refresh)
        Me.groupbox_data_transfer.Controls.Add(Me.picturebox_server)
        Me.groupbox_data_transfer.Controls.Add(Me.button_capture_fingerprint)
        Me.groupbox_data_transfer.Controls.Add(Me.button_load_fingerprint)
        Me.groupbox_data_transfer.Controls.Add(Me.picturebox_fingerprint)
        Me.groupbox_data_transfer.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox_data_transfer.Location = New System.Drawing.Point(12, 146)
        Me.groupbox_data_transfer.Name = "groupbox_data_transfer"
        Me.groupbox_data_transfer.Size = New System.Drawing.Size(533, 217)
        Me.groupbox_data_transfer.TabIndex = 9
        Me.groupbox_data_transfer.TabStop = False
        Me.groupbox_data_transfer.Text = "Data Transfer"
        '
        'button_refresh
        '
        Me.button_refresh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_refresh.Location = New System.Drawing.Point(378, 185)
        Me.button_refresh.Name = "button_refresh"
        Me.button_refresh.Size = New System.Drawing.Size(143, 26)
        Me.button_refresh.TabIndex = 28
        Me.button_refresh.Text = "Refresh"
        Me.button_refresh.UseVisualStyleBackColor = True
        '
        'picturebox_server
        '
        Me.picturebox_server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picturebox_server.Location = New System.Drawing.Point(378, 28)
        Me.picturebox_server.Name = "picturebox_server"
        Me.picturebox_server.Size = New System.Drawing.Size(143, 151)
        Me.picturebox_server.TabIndex = 27
        Me.picturebox_server.TabStop = False
        '
        'button_capture_fingerprint
        '
        Me.button_capture_fingerprint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_capture_fingerprint.Location = New System.Drawing.Point(9, 186)
        Me.button_capture_fingerprint.Name = "button_capture_fingerprint"
        Me.button_capture_fingerprint.Size = New System.Drawing.Size(71, 26)
        Me.button_capture_fingerprint.TabIndex = 25
        Me.button_capture_fingerprint.Text = "Capture"
        Me.button_capture_fingerprint.UseVisualStyleBackColor = True
        '
        'button_load_fingerprint
        '
        Me.button_load_fingerprint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_load_fingerprint.Location = New System.Drawing.Point(87, 186)
        Me.button_load_fingerprint.Name = "button_load_fingerprint"
        Me.button_load_fingerprint.Size = New System.Drawing.Size(67, 26)
        Me.button_load_fingerprint.TabIndex = 26
        Me.button_load_fingerprint.Text = "Load"
        Me.button_load_fingerprint.UseVisualStyleBackColor = True
        '
        'picturebox_fingerprint
        '
        Me.picturebox_fingerprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picturebox_fingerprint.Location = New System.Drawing.Point(9, 28)
        Me.picturebox_fingerprint.Name = "picturebox_fingerprint"
        Me.picturebox_fingerprint.Size = New System.Drawing.Size(143, 151)
        Me.picturebox_fingerprint.TabIndex = 24
        Me.picturebox_fingerprint.TabStop = False
        '
        'button_send_to_server
        '
        Me.button_send_to_server.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_send_to_server.Location = New System.Drawing.Point(4, 4)
        Me.button_send_to_server.Name = "button_send_to_server"
        Me.button_send_to_server.Size = New System.Drawing.Size(82, 24)
        Me.button_send_to_server.TabIndex = 29
        Me.button_send_to_server.Text = "Send"
        Me.button_send_to_server.UseVisualStyleBackColor = True
        '
        'button_stop_sending
        '
        Me.button_stop_sending.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_stop_sending.Location = New System.Drawing.Point(90, 4)
        Me.button_stop_sending.Name = "button_stop_sending"
        Me.button_stop_sending.Size = New System.Drawing.Size(73, 24)
        Me.button_stop_sending.TabIndex = 30
        Me.button_stop_sending.Text = "Stop"
        Me.button_stop_sending.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(170, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(365, 23)
        Me.ProgressBar1.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.button_send_to_server)
        Me.Panel1.Controls.Add(Me.button_stop_sending)
        Me.Panel1.Location = New System.Drawing.Point(9, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 31)
        Me.Panel1.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.groupbox_data_transfer)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.groupbox_server_details)
        Me.Panel2.Location = New System.Drawing.Point(11, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(558, 430)
        Me.Panel2.TabIndex = 36
        '
        'OnlineCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "OnlineCheck"
        Me.Size = New System.Drawing.Size(581, 463)
        Me.groupbox_server_details.ResumeLayout(False)
        Me.groupbox_data_transfer.ResumeLayout(False)
        CType(Me.picturebox_server, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturebox_fingerprint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_test_connection As System.Windows.Forms.Button
    Friend WithEvents combobox_server_protocol As System.Windows.Forms.ComboBox
    Friend WithEvents label_server_protocol As System.Windows.Forms.Label
    Friend WithEvents label_server_port As System.Windows.Forms.Label
    Friend WithEvents combobox_server_port As System.Windows.Forms.ComboBox
    Friend WithEvents label_server_ip As System.Windows.Forms.Label
    Friend WithEvents combobox_server_ip As System.Windows.Forms.ComboBox
    Friend WithEvents groupbox_server_details As System.Windows.Forms.GroupBox
    Friend WithEvents groupbox_data_transfer As System.Windows.Forms.GroupBox
    Friend WithEvents button_load_fingerprint As System.Windows.Forms.Button
    Friend WithEvents picturebox_fingerprint As System.Windows.Forms.PictureBox
    Friend WithEvents button_capture_fingerprint As System.Windows.Forms.Button
    Friend WithEvents picturebox_server As System.Windows.Forms.PictureBox
    Friend WithEvents button_refresh As System.Windows.Forms.Button
    Friend WithEvents button_send_to_server As System.Windows.Forms.Button
    Friend WithEvents button_stop_sending As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
