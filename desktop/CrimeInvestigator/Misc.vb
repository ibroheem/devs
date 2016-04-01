Imports GrFingerXLib

Module Misc
    Public Sub clear_text_field(ByRef text_box)
        text_box.text = ""
    End Sub

    Public Function open_file_dialog(Optional ByVal start_path = "")
        Dim fopen_dialog As New OpenFileDialog

        fopen_dialog.Filter = "Images|*.jpg;*.png;*.bmp|All files (*.*)|*.*"
        fopen_dialog.Title = "Select An Image"
        fopen_dialog.FilterIndex = 1
        fopen_dialog.RestoreDirectory = True

        If fopen_dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return fopen_dialog.FileName
        End If

        Return ""

    End Function

    Public Function load_image(ByRef myUtil As Util, ByRef axgr As AxGrFingerXLib.AxGrFingerXCtrl, ByRef fpath As String)
        Dim resolution As Integer
        resolution = 500

        If (resolution <> 0) Then
            If axgr.CapLoadImageFromFile(fpath, resolution) <> GrFingerXLib.GRConstants.GR_OK Then
                myUtil.WriteLog("Fail to load the file.")
                Return False
            End If
        End If
        Return True
    End Function

    Public Function open_image_old(ByRef myUtil As Util, ByRef axgr As AxGrFingerXLib.AxGrFingerXCtrl)
        Dim OpenFileDialog1 As New OpenFileDialog
        Dim resolution As Integer

        ' open "load" dialog
        OpenFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        ' load image
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Getting resolution.
            resolution = 500 'Val(InputBox("What is the image resolution?", "Resolution", ""))
            ' Checking if action was canceled, no value or an invalid value was entered.
            If (resolution <> 0) Then
                If axgr.CapLoadImageFromFile(OpenFileDialog1.FileName, resolution) <> GrFingerXLib.GRConstants.GR_OK Then
                    myUtil.WriteLog("Fail to load the file.")
                End If
            End If
        End If
        Return OpenFileDialog1.FileName
    End Function

    Public Sub resize_array(ByRef arr() As Integer, Optional ByVal sz As Integer = 1)
        ReDim Preserve arr(arr.Length + sz)
    End Sub

End Module

Module FingerPrintOperations
    Public Sub clear_database(ByRef myUtil As Util)
        myUtil.DB.clearDB()
        ' write result to log
        myUtil.WriteLog("Database is clear...")
    End Sub

    Public Sub extract_template(ByRef myUtil As Util)
        Dim ret As Integer

        ' extract template
        ret = myUtil.ExtractTemplate()
        ' write template quality to log
        If ret = GRConstants.GR_BAD_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. Bad quality.")
        ElseIf ret = GRConstants.GR_MEDIUM_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. Medium quality.")
        ElseIf ret = GRConstants.GR_HIGH_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. High quality.")
        End If
        If ret >= 0 Then
            ' if no error, display minutiae/segments/directions into the image
            myUtil.PrintBiometricDisplay(True, GRConstants.GR_NO_CONTEXT)
        Else
            ' write error to log
            myUtil.WriteError(ret)
        End If
    End Sub

    Public Function enroll_print(ByRef myUtil As Util)
        extract_template(myUtil)
        Dim id As Integer

        ' add fingerprint
        id = myUtil.Enroll()
        ' write result to log
        If id >= 0 Then
            myUtil.WriteLog("Fingerprint enrolled with id = " & id)
            Return id
        Else
            myUtil.WriteLog("Error: Fingerprint not enrolled")
        End If
        Return -1
    End Function

    Public Function identify_print(ByRef myUtil As Util)
        Dim ret As Integer, score As Integer

        score = 0
        ' identify it
        ret = myUtil.Identify(score)
        ' write result to log
        If ret > 0 Then
            myUtil.WriteLog("Fingerprint identified. ID = " & ret & ". Score = " & score & ".")
            myUtil.PrintBiometricDisplay(True, GrFingerXLib.GRConstants.GR_DEFAULT_CONTEXT)
            Return score
        ElseIf ret = 0 Then
            myUtil.WriteLog("Fingerprint not Found.")
            Return -1
        Else
            myUtil.WriteError(ret)
            Return -2
        End If
        Return -2
    End Function

    Public Sub verify_print(ByRef myUtil As Util)
        Dim ret As Integer
        Dim score As Integer
        Dim sid As String

        ' ask target fingerprint ID
        score = 0
        sid = InputBox("Enter the ID to verify", "Verify", "")
        If sid <> "" Then
            ' compare fingerprints
            ret = myUtil.Verify(Val(sid), score)
            ' write result to log
            If ret < 0 Then
                myUtil.WriteError(ret)
            ElseIf ret = GRConstants.GR_NOT_MATCH Then
                myUtil.WriteLog("Did not match with score = " & score)
            Else
                myUtil.WriteLog("Matched with score = " & score)
                ' if they match, display matching minutiae/segments/directions
                myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
            End If
        End If
    End Sub
End Module

Module DataBaseOperations
    Public dbconn As New OleDb.OleDbConnection
    Public db_path = "..\..\Database.mdb", _
        db_conn_string As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & db_path

    Public sql_string_cvr As String = "SELECT * FROM ConvictRecords"
    Public ds_settings = New DataSet, ds_criminal_records As New DataSet

    Public da_criminal_records As New OleDb.OleDbDataAdapter(sql_string_cvr, dbconn)
    Public da_settings As New OleDb.OleDbDataAdapter("SELECT * FROM Settings", dbconn)
End Module