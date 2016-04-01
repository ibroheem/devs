Imports GrFingerXLib

Public Class NewCriminalRecord
    Dim myUtil As Util
    Dim img_path As String ' For Controls that loads image
    Dim current_id, current_score As Integer

    Public Sub New()
        InitializeComponent()
        init_finger()
        init_date_of_birth()
        init_db_conn()
    End Sub

    Private Sub init_finger()
        Dim err As Integer

        ' alow util class to access controls in main form
        Control.CheckForIllegalCrossThreadCalls = False
        ' initialize util class
        myUtil = New Util(ListBox2, picture_box_fingerprint, AxGrFingerXCtrl1)
        ' initialize GrFingerX Library
        err = Me.myUtil.InitializeGrFinger()
        ' print result in log
        If err < 0 Then
            myUtil.WriteError(err)
            Exit Sub
        Else
            myUtil.WriteLog("**GrFinger Initialized Successfully**")
        End If
    End Sub

    Public Sub init_date_of_birth()
        Dim i As Integer
        For i = 1 To 31
            combobox_day.Items.Add(i)
            If i < 13 Then
                combobox_month.Items.Add(i)
            End If
        Next
    End Sub

    Public Sub init_db_conn()
        If dbconn.State = ConnectionState.Open Then
            dbconn.Close()
        End If

        If System.IO.File.Exists(db_path) Then
            dbconn.ConnectionString = db_conn_string
            dbconn.Open()

            da_criminal_records.Fill(ds_criminal_records, "criminal_records")
            da_settings.Fill(ds_settings, "settings")
        End If
    End Sub

    ' A fingerprint reader was plugged on system
    Private Sub AxGrFingerXCtrl1_SensorPlug(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent) Handles AxGrFingerXCtrl1.SensorPlug
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Plugged.")
        AxGrFingerXCtrl1.CapStartCapture(e.idSensor)
    End Sub

    ' A fingerprint reader was unplugged from system
    Private Sub AxGrFingerXCtrl1_SensorUnplug(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent) Handles AxGrFingerXCtrl1.SensorUnplug
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Unplugged.")
        AxGrFingerXCtrl1.CapStopCapture(e.idSensor)
    End Sub

    ' A finger was placed on reader
    Private Sub AxGrFingerXCtrl1_FingerDown(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent) Handles AxGrFingerXCtrl1.FingerDown
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Finger Placed.")
    End Sub

    ' A finger was removed from reader
    Private Sub AxGrFingerXCtrl1_FingerUp(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent) Handles AxGrFingerXCtrl1.FingerUp
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Finger removed.")
    End Sub

    ' An image was acquired from reader
    Private Sub AxGrFingerXCtrl1_ImageAcquired(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent) Handles AxGrFingerXCtrl1.ImageAcquired
        ' Copying aquired image
        myUtil.raw.height = e.height
        myUtil.raw.width = e.width
        myUtil.raw.res = e.res
        myUtil.raw.img = e.rawImage

        ' Signaling that an Image Event occurred.
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Image captured.")

        ' display fingerprint image
        myUtil.PrintBiometricDisplay(False, GRConstants.GR_DEFAULT_CONTEXT)

        ' now we have a fingerprint, so we can extract template
        'ExtractButton.Enabled = True
        'EnrollButton.Enabled = False
        'IdentifyButton.Enabled = False
        'VerifyButton.Enabled = False

        ' extracting template from image
        'If ckAutoExtract.Checked Then ExtractButton.PerformClick()

        ' identify fingerprint
        'If ckBoxAutoIdentify.Checked Then IdentifyButton().PerformClick()
    End Sub

    Public Sub clear_all_text_fields()
        clear_text_field(textbox_convict_file)
        clear_text_field(textbox_fname)
        clear_text_field(textbox_lname)
        clear_text_field(textbox_address)
        clear_text_field(textbox_state)
        clear_text_field(textbox_city)
        clear_text_field(textbox_year)
        clear_text_field(textbox_height)
        clear_text_field(textbox_weight)
    End Sub

    Private Sub button_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_save.Click
        Dim conn_builder_criminal_records As New OleDb.OleDbCommandBuilder(da_criminal_records)
        Dim conn_builder_settings As New OleDb.OleDbCommandBuilder(da_settings)
        Dim new_row_criminal, new_row_settings As DataRow

        new_row_criminal = ds_criminal_records.Tables("criminal_records").NewRow()
        new_row_settings = ds_settings.Tables("settings").NewRow()

        new_row_criminal.Item("ConvictNo") = textbox_convict_file.Text
        new_row_criminal.Item("FirstName") = textbox_fname.Text
        new_row_criminal.Item("LastName") = textbox_lname.Text
        new_row_criminal.Item("City") = textbox_city.Text
        new_row_criminal.Item("Address") = textbox_address.Text
        new_row_criminal.Item("State") = textbox_state.Text
        new_row_criminal.Item("Date_Day") = combobox_day.Text
        new_row_criminal.Item("Date_Month") = combobox_month.Text
        new_row_criminal.Item("Date_Year") = textbox_year.Text
        new_row_criminal.Item("Crime") = combobox_crimes.Text
        new_row_criminal.Item("Height") = textbox_height.Text
        new_row_criminal.Item("Weight") = textbox_weight.Text
        'new_row_criminal.Item("ID") = ds_criminal_records.Tables("criminal_records").Rows.Count + 1

        new_row_settings.Item("Score") = current_score
        new_row_settings.Item("ConvictNo") = textbox_convict_file.Text
        new_row_settings.Item("PassportLocation") = picture_box_passport.ImageLocation
        new_row_settings.Item("FingerprintLocation") = picture_box_fingerprint.ImageLocation

        ds_criminal_records.Tables("criminal_records").Rows.Add(new_row_criminal)
        da_criminal_records.Update(ds_criminal_records, "criminal_records")

        ds_settings.Tables("settings").Rows.Add(new_row_settings)
        da_settings.Update(ds_settings, "settings")
    End Sub

    Private Sub button_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_clear.Click
        clear_all_text_fields()
    End Sub

    Private Sub button_change_passport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_change_passport.Click
        img_path = open_file_dialog()
        picture_box_passport.ImageLocation = img_path
    End Sub

    Private Sub button_load_fingerprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_load_fingerprint.Click
        picture_box_fingerprint.ImageLocation = open_file_dialog()
        load_image(myUtil, AxGrFingerXCtrl1, picture_box_fingerprint.ImageLocation)
    End Sub

    Private Sub button_capture_fingerprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_capture_fingerprint.Click
        ' Fingerprint Technonlogy
    End Sub

    Private Sub picture_box_fingerprint_LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles picture_box_fingerprint.LoadCompleted
        clear_database(myUtil)
        enroll_print(myUtil)
        current_score = identify_print(myUtil)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
