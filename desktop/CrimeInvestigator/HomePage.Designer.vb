<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.button_new_criminal_record = New System.Windows.Forms.Button
        Me.button_local_check = New System.Windows.Forms.Button
        Me.button_online_check = New System.Windows.Forms.Button
        Me.button_help = New System.Windows.Forms.Button
        Me.button_full_records = New System.Windows.Forms.Button
        Me.button_about_us = New System.Windows.Forms.Button
        Me.panel_display = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.button_exit = New System.Windows.Forms.Button
        Me.button_logout = New System.Windows.Forms.Button
        Me.status_bar = New System.Windows.Forms.StatusStrip
        Me.status_bar_label = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1.SuspendLayout()
        Me.status_bar.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_new_criminal_record
        '
        Me.button_new_criminal_record.FlatAppearance.BorderSize = 0
        Me.button_new_criminal_record.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_new_criminal_record.Location = New System.Drawing.Point(9, 34)
        Me.button_new_criminal_record.Name = "button_new_criminal_record"
        Me.button_new_criminal_record.Size = New System.Drawing.Size(140, 34)
        Me.button_new_criminal_record.TabIndex = 0
        Me.button_new_criminal_record.Tag = ""
        Me.button_new_criminal_record.Text = "New Criminal Record"
        Me.button_new_criminal_record.UseVisualStyleBackColor = True
        '
        'button_local_check
        '
        Me.button_local_check.FlatAppearance.BorderSize = 0
        Me.button_local_check.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_local_check.Location = New System.Drawing.Point(7, 141)
        Me.button_local_check.Name = "button_local_check"
        Me.button_local_check.Size = New System.Drawing.Size(140, 34)
        Me.button_local_check.TabIndex = 1
        Me.button_local_check.Text = "Local Check"
        Me.button_local_check.UseVisualStyleBackColor = True
        '
        'button_online_check
        '
        Me.button_online_check.FlatAppearance.BorderSize = 0
        Me.button_online_check.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_online_check.Location = New System.Drawing.Point(7, 181)
        Me.button_online_check.Name = "button_online_check"
        Me.button_online_check.Size = New System.Drawing.Size(140, 34)
        Me.button_online_check.TabIndex = 2
        Me.button_online_check.Text = "Online Check"
        Me.button_online_check.UseVisualStyleBackColor = True
        '
        'button_help
        '
        Me.button_help.FlatAppearance.BorderSize = 0
        Me.button_help.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_help.Location = New System.Drawing.Point(9, 259)
        Me.button_help.Name = "button_help"
        Me.button_help.Size = New System.Drawing.Size(140, 34)
        Me.button_help.TabIndex = 3
        Me.button_help.Text = "Help"
        Me.button_help.UseVisualStyleBackColor = True
        '
        'button_full_records
        '
        Me.button_full_records.FlatAppearance.BorderSize = 0
        Me.button_full_records.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_full_records.Location = New System.Drawing.Point(9, 74)
        Me.button_full_records.Name = "button_full_records"
        Me.button_full_records.Size = New System.Drawing.Size(140, 34)
        Me.button_full_records.TabIndex = 4
        Me.button_full_records.Text = "Full Records"
        Me.button_full_records.UseVisualStyleBackColor = True
        '
        'button_about_us
        '
        Me.button_about_us.FlatAppearance.BorderSize = 0
        Me.button_about_us.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_about_us.Location = New System.Drawing.Point(9, 299)
        Me.button_about_us.Name = "button_about_us"
        Me.button_about_us.Size = New System.Drawing.Size(140, 34)
        Me.button_about_us.TabIndex = 5
        Me.button_about_us.Text = "About Us"
        Me.button_about_us.UseVisualStyleBackColor = True
        '
        'panel_display
        '
        Me.panel_display.Location = New System.Drawing.Point(184, 12)
        Me.panel_display.Name = "panel_display"
        Me.panel_display.Size = New System.Drawing.Size(599, 499)
        Me.panel_display.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.button_exit)
        Me.GroupBox1.Controls.Add(Me.button_logout)
        Me.GroupBox1.Controls.Add(Me.button_full_records)
        Me.GroupBox1.Controls.Add(Me.button_about_us)
        Me.GroupBox1.Controls.Add(Me.button_new_criminal_record)
        Me.GroupBox1.Controls.Add(Me.button_help)
        Me.GroupBox1.Controls.Add(Me.button_online_check)
        Me.GroupBox1.Controls.Add(Me.button_local_check)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 433)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'button_exit
        '
        Me.button_exit.FlatAppearance.BorderSize = 0
        Me.button_exit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_exit.Location = New System.Drawing.Point(9, 396)
        Me.button_exit.Name = "button_exit"
        Me.button_exit.Size = New System.Drawing.Size(140, 28)
        Me.button_exit.TabIndex = 7
        Me.button_exit.Text = "Exit"
        Me.button_exit.UseVisualStyleBackColor = True
        '
        'button_logout
        '
        Me.button_logout.FlatAppearance.BorderSize = 0
        Me.button_logout.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_logout.Location = New System.Drawing.Point(9, 365)
        Me.button_logout.Name = "button_logout"
        Me.button_logout.Size = New System.Drawing.Size(140, 28)
        Me.button_logout.TabIndex = 6
        Me.button_logout.Text = "Logout"
        Me.button_logout.UseVisualStyleBackColor = True
        '
        'status_bar
        '
        Me.status_bar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_bar_label})
        Me.status_bar.Location = New System.Drawing.Point(0, 518)
        Me.status_bar.Name = "status_bar"
        Me.status_bar.Size = New System.Drawing.Size(836, 22)
        Me.status_bar.TabIndex = 7
        Me.status_bar.Text = "StatusStrip1"
        '
        'status_bar_label
        '
        Me.status_bar_label.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_bar_label.Name = "status_bar_label"
        Me.status_bar_label.Size = New System.Drawing.Size(0, 17)
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 540)
        Me.Controls.Add(Me.status_bar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel_display)
        Me.MaximizeBox = False
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.status_bar.ResumeLayout(False)
        Me.status_bar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button_new_criminal_record As System.Windows.Forms.Button
    Friend WithEvents button_local_check As System.Windows.Forms.Button
    Friend WithEvents button_online_check As System.Windows.Forms.Button
    Friend WithEvents button_help As System.Windows.Forms.Button
    Friend WithEvents button_full_records As System.Windows.Forms.Button
    Friend WithEvents button_about_us As System.Windows.Forms.Button
    Friend WithEvents panel_display As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents button_logout As System.Windows.Forms.Button
    Friend WithEvents button_exit As System.Windows.Forms.Button
    Friend WithEvents status_bar As System.Windows.Forms.StatusStrip
    Friend WithEvents status_bar_label As System.Windows.Forms.ToolStripStatusLabel
End Class
