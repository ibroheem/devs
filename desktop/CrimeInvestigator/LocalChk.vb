Imports GrFingerXLib

Public Class LocalChk
    Dim myUtil As Util = Nothing
    Dim finger_ids() As Integer = {}
    Dim finger_match_scores() As Integer = {}
    Dim current_id, current_score As Integer

    Private Sub init_finger() 'ByVal sender As Object, ByVal e As System.EventArgs
        Dim err As Integer

        ' alow util class to access controls in main form
        Control.CheckForIllegalCrossThreadCalls = False
        ' initialize util class
        myUtil = New Util(ListBox2, picture_box_source, AxGrFingerXCtrl1)
        ' initialize GrFingerX Library
        err = myUtil.InitializeGrFinger()
        ' print result in log
        If err < 0 Then
            myUtil.WriteError(err)
            Exit Sub
        Else
            myUtil.WriteLog("**GrFinger Initialized Successfully**")
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        init_finger()
    End Sub

    Private Sub buttton_load_fingerprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttton_load_fingerprint.Click
        picture_box_source.ImageLocation = open_file_dialog()
        load_image(myUtil, AxGrFingerXCtrl1, picture_box_source.ImageLocation)
    End Sub

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

    Private Sub LocalChk_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AxGrFingerXCtrl1.Dispose()
        myUtil = Nothing
    End Sub

    Private Sub buttton_compare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttton_compare.Click
        Dim sql As String = "SELECT * FROM Settings"
        Dim data_set As New DataSet
        Dim data_adapter As New OleDb.OleDbDataAdapter(sql, dbconn)

        Dim i As Integer

        If System.IO.File.Exists(db_path) And dbconn.State <> ConnectionState.Open Then
            dbconn.ConnectionString = db_conn_string
            dbconn.Open()
        Else
            data_adapter.Fill(data_set, "settings")
            For i = 0 To data_set.Tables("settings").Rows.Count - 1
                If current_score = data_set.Tables("settings").Rows(i).Item(0) Then
                    picture_box_target.ImageLocation = data_set.Tables("settings").Rows(i).Item(2)
                    label_match_status.Text = "Match Found"
                    Exit For
                ElseIf current_score <> data_set.Tables("settings").Rows(i).Item(0) And i = data_set.Tables("settings").Rows.Count - 1 Then
                    picture_box_target.ImageLocation = ""
                    label_match_status.Text = "Match Not Found"
                End If
            Next i
        End If

    End Sub

    Private Sub picture_box_source_LoadCompleted1(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles picture_box_source.LoadCompleted
        clear_database(myUtil)
        enroll_print(myUtil)
        current_score = identify_print(myUtil)
    End Sub
End Class
