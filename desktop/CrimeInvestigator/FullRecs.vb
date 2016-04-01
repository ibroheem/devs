Public Class FullRecs
    Dim sql As String = "SELECT * FROM ConvictRecords"
    Dim data_set As New DataSet
    Dim data_adapter As New OleDb.OleDbDataAdapter(sql, dbconn)

    Private Sub FullRecord_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        set_connection()
        init_columns()
    End Sub

    Public Sub set_connection()
        If System.IO.File.Exists(db_path) Then
            dbconn.ConnectionString = db_conn_string
            dbconn.Open()

            data_adapter.Fill(data_set, "criminal_rec")
        End If
    End Sub

    Function data_set_table(ByVal r, ByVal c)
        Return data_set.Tables("criminal_rec").Rows(r).Item(c)
    End Function

    Public Sub init_columns()
        With FullRecordView
            .View = View.Details
            .Columns.Add("Convict File", 50, HorizontalAlignment.Left)
            .Columns.Add("First Name", 100, HorizontalAlignment.Left)
            .Columns.Add("Last Name", 100, HorizontalAlignment.Left)
            .Columns.Add("City", 100)
            .Columns.Add("Address")
            .Columns.Add("State")
            .Columns.Add("Date_Day", 30)
            .Columns.Add("Date_Month", 30)
            .Columns.Add("Date_Year", 40)
            .Columns.Add("Crime")
            .Columns.Add("Height", 30)
            .Columns.Add("Weight", 30)
        End With

        For index_row As Integer = 0 To data_set.Tables("criminal_rec").Rows.Count - 1
            FullRecordView.Items.Add(data_set_table(index_row, 1))
            For index_col As Integer = 2 To data_set.Tables("criminal_rec").Columns.Count - 1
                With FullRecordView
                    .Items(index_row).SubItems().Add(data_set_table(index_row, index_col))
                End With
            Next index_col
        Next index_row

    End Sub

    Public Sub initialize_table()
        init_columns()
    End Sub

    Public Sub find_record()
        'Dim foundItem As ListViewItem = FullRecordView.FindItemWithText(FullRecordView.Text, False, 0, False)
        Dim search_index As Integer = 1
        If check_box_by_crime.Checked Then
            search_index = 9
        End If

        For index As Integer = 0 To FullRecordView.Items.Count - 1
            If FullRecordView.Items(index).SubItems(search_index).Text = text_box_search.Text.ToLower Then
                FullRecordView.Items(index).Focused = True
                FullRecordView.Items(index).BackColor = Color.Blue
                FullRecordView.Items(index).ForeColor = Color.White
                HomePage.status_bar_label.Text = "Found"
            End If
        Next index
    End Sub

    Private Sub button_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_find.Click
        find_record()
    End Sub

    Private Sub text_box_search_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_box_search.KeyUp
        If e.KeyCode = Keys.Enter Then
            find_record()
        End If
    End Sub

End Class
