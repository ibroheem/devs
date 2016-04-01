Public Class FormLogin
    Public Sub New()
        InitializeComponent()
        clear_status_text()
    End Sub

    Public Sub clear_status_text()
        status_label.Text = ""
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If textbox_username.Text = "" And textbox_password.Text = "" Then
            Me.Hide()
            HomePage.Show()
            clear_status_text()
        Else
            status_label.Text = "Invalid Username or Password!"
            status_label.ForeColor = Color.Red
            textbox_username.ForeColor = Color.Red
            textbox_password.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub textbox_username_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles textbox_username.Enter
        textbox_username.ForeColor = Color.Black
    End Sub

    Private Sub textbox_password_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles textbox_password.Enter
        textbox_password.ForeColor = Color.Black
    End Sub
End Class

