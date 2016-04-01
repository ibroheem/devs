
Public Class HomePage
    Dim original_height As Integer = Me.Height
    Dim original_width As Integer = Me.Width

    'Dim ctrl_local_check As LocalChk
    'Dim ctrl_new_criminal As NewCriminalRecord

    <STAThread()> _
    Private Sub HomePageOld_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ctrl_local_check = New LocalChk
        'ctrl_new_criminal = New NewCriminalRecord
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button_new_criminal_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_new_criminal_record.Click
        'ctrl_local_check = Nothing
        'ctrl_new_criminal = New NewCriminalRecord
        Dim ctrl_new_criminal As New NewCriminalRecord
        Static Dim w As Int32 = Me.Width - 10
        Static Dim h As Int32 = Me.Height - 10

        panel_display.Controls.Clear()
        panel_display.Controls.Add(ctrl_new_criminal.Panel1)
        panel_display.Width = ctrl_new_criminal.Width + 10
        panel_display.Height = ctrl_new_criminal.Height + 10
    End Sub

    Private Sub button_local_check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_local_check.Click
        Static Dim w As Int32 = Me.Width - 10
        Static Dim h As Int32 = Me.Height - 10

        Dim ctrl_local_check As New LocalChk
        If ctrl_local_check Is Nothing Then
            ctrl_local_check = New LocalChk
        End If

        panel_display.Controls.Clear()
        panel_display.Controls.Add(ctrl_local_check.Panel1)
        panel_display.Width = ctrl_local_check.Width + 10
        panel_display.Height = ctrl_local_check.Height + 10
        'LocalChk.Show()
    End Sub

    Private Sub button_full_records_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_full_records.Click
        Dim ctrl As New FullRecs
        Static Dim w As Int32 = Me.Width - 10
        Static Dim h As Int32 = Me.Height - 10

        panel_display.Controls.Clear()
        panel_display.Controls.Add(ctrl)
        panel_display.Width = ctrl.Width + 10
        panel_display.Height = ctrl.Height + 10
    End Sub

    Public Sub cleanup()
        panel_display.Controls.Clear()
    End Sub

    Private Sub button_logout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_logout.Click
        FormLogin.Show()
        Me.Hide()
        cleanup()
    End Sub

    Public Sub display_new_criminal_records()
        Dim cr_details As New NewCriminalRecord
        Static Dim w As Int32 = original_width - 10
        Static Dim h As Int32 = original_height - 10

        panel_display.Controls.Clear()
        panel_display.Controls.Add(cr_details.Panel1)

        'Me.Width = w
        'Me.Height = h
    End Sub

    Private Sub button_criminal_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_new_criminal_record.Click
        display_new_criminal_records()
    End Sub

    Private Sub HomePage_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormLogin.Close()
    End Sub

    Public Sub display_help()
        Dim home_page_ctrl As HelpPage = New HelpPage
        home_page_ctrl.Dock = DockStyle.Fill
        panel_display.Controls.Clear()
        panel_display.Controls.Add(home_page_ctrl)
    End Sub

    Private Sub button_help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_help.Click
        display_help()
    End Sub

    Private Sub button_check_online_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_online_check.Click
        Dim check_online As OnlineCheck = New OnlineCheck
        Static Dim h As Int32 = Me.Height - 150
        check_online.Dock = DockStyle.Fill
        panel_display.Controls.Clear()
        panel_display.Controls.Add(check_online)
        'Me.Height = h
    End Sub

    Private Sub button_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_exit.Click
        Close()
        Application.Exit()
    End Sub

    Private Sub button_online_check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_online_check.Click

    End Sub
End Class