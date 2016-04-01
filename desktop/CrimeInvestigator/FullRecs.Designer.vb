<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FullRecs
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
        Me.check_box_by_crime = New System.Windows.Forms.CheckBox
        Me.button_find = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.text_box_search = New System.Windows.Forms.TextBox
        Me.check_box_lname = New System.Windows.Forms.CheckBox
        Me.FullRecordView = New System.Windows.Forms.ListView
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'check_box_by_crime
        '
        Me.check_box_by_crime.Location = New System.Drawing.Point(337, 20)
        Me.check_box_by_crime.Name = "check_box_by_crime"
        Me.check_box_by_crime.Size = New System.Drawing.Size(84, 22)
        Me.check_box_by_crime.TabIndex = 7
        Me.check_box_by_crime.Text = "By Crime"
        Me.check_box_by_crime.UseVisualStyleBackColor = True
        '
        'button_find
        '
        Me.button_find.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_find.Location = New System.Drawing.Point(522, 19)
        Me.button_find.Name = "button_find"
        Me.button_find.Size = New System.Drawing.Size(124, 26)
        Me.button_find.TabIndex = 5
        Me.button_find.Text = "Find"
        Me.button_find.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.text_box_search)
        Me.GroupBox1.Controls.Add(Me.check_box_by_crime)
        Me.GroupBox1.Controls.Add(Me.button_find)
        Me.GroupBox1.Controls.Add(Me.check_box_lname)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 423)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 52)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Record"
        '
        'text_box_search
        '
        Me.text_box_search.AcceptsReturn = True
        Me.text_box_search.AcceptsTab = True
        Me.text_box_search.Location = New System.Drawing.Point(7, 19)
        Me.text_box_search.Name = "text_box_search"
        Me.text_box_search.Size = New System.Drawing.Size(320, 23)
        Me.text_box_search.TabIndex = 8
        Me.text_box_search.TabStop = False
        '
        'check_box_lname
        '
        Me.check_box_lname.Location = New System.Drawing.Point(427, 20)
        Me.check_box_lname.Name = "check_box_lname"
        Me.check_box_lname.Size = New System.Drawing.Size(89, 23)
        Me.check_box_lname.TabIndex = 6
        Me.check_box_lname.Text = "Last Name"
        Me.check_box_lname.UseVisualStyleBackColor = True
        '
        'FullRecordView
        '
        Me.FullRecordView.GridLines = True
        Me.FullRecordView.HideSelection = False
        Me.FullRecordView.Location = New System.Drawing.Point(4, 3)
        Me.FullRecordView.MultiSelect = False
        Me.FullRecordView.Name = "FullRecordView"
        Me.FullRecordView.Size = New System.Drawing.Size(644, 419)
        Me.FullRecordView.TabIndex = 9
        Me.FullRecordView.UseCompatibleStateImageBehavior = False
        Me.FullRecordView.View = System.Windows.Forms.View.Details
        '
        'FullRecs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FullRecordView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FullRecs"
        Me.Size = New System.Drawing.Size(652, 475)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents check_box_by_crime As System.Windows.Forms.CheckBox
    Friend WithEvents button_find As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents check_box_lname As System.Windows.Forms.CheckBox
    Friend WithEvents FullRecordView As System.Windows.Forms.ListView
    Friend WithEvents text_box_search As System.Windows.Forms.TextBox

End Class
