Imports System.Data.SQLite
Public Class Form1

    Private completedTasks As Integer = 0
    Private totalTasks As Integer = 7
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSongTitle.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnSaveSession_Click(sender As Object, e As EventArgs) Handles btnSaveSession.Click
        Dim songTitle As String = txtSongTitle.Text
        Dim artist As String = txtArtist.Text
        Dim bpm As String = txtBPM.Text
        Dim musicalKey As String = txtKey.Text
        Dim notes As String = txtNotes.Text
        Dim connectionString As String = "Data Source=sessions2.db;Version=3;"
        Dim readinessScore As Integer = CalculateReadinessScore(completedTasks, totalTasks)

        'THIS CONNECTION STRING TELLS SQLITE WHAT DATABASE FILE TO CREATE AND USE
        Dim connection As New SQLiteConnection(connectionString)

        'OPENS THE DATABASE CONNECTION BEFORE RUNNING SQL COMMANDS
        connection.Open()

        'REMOVES THE OLD SESSIONS TABLE DURING TESTING SO INCORRECT COLUMNS DO NOT REMAIN
        '(DURING DEVELOPMENT, OLD TABLE COLUMNS WERE STUCK IN THE DATABASE POST MODIFICATIONS

        Dim dropTableCommand As New SQLiteCommand("DROP TABLE IF EXISTS Sessions", connection)

        'SQL QUERY USED TO CREATE THE SESSIONS TABLE WITH THE CORRECT COLUMN NAMES
        Dim createTableQuery As String =
            "CREATE TABLE IF NOT EXISTS Sessions (" &
            "Id INTEGER PRIMARY KEY AUTOINCREMENT, " &
            "SongTitle TEXT, " & 'THIS COLUMS HAS A TYPE THAT TOOK OURS TO FIND> SingleTitle vs SongTitle
            "Artist TEXT, " &
            "BPM TEXT, " &
            "MusicalKey TEXT, " &
            "Notes TEXT, " &
            "ReadinessScore TEXT)"

        'EXECUTES THE DROP TABLE COMMAND
        dropTableCommand.ExecuteNonQuery()
        Dim createTableCommand As New SQLiteCommand(createTableQuery, connection)
        createTableCommand.ExecuteNonQuery()

        'CREATES THE SESSIONS TABLE IN THE DATABASE IF IT DOESNT ALREADY EXIST
        createTableCommand.ExecuteNonQuery().ToString()
        'SQLite INSERT QUERY USED TO SAVE THE SESSION INFORMATION INTO THE DATABAS TABLE
        Dim insertQuery As String =
            "insert INTO Sessions (SongTitle, Artist, BPM, MusicalKey, Notes, ReadinessScore)" &
            "VALUES (@SongTitle, @Artist, @BPM, @MusicalKey, @Notes, @ReadinessScore)"

        'CREATES THE SQL COMMAND OBJECT FOR THE INSERT QUERY
        Dim insertCommand As New SQLiteCommand(insertQuery, connection)
        'PARAMETERS SAFELY CONNECT USER INPUT VALUES TO THE SQL QUERY
        insertCommand.Parameters.AddWithValue("@SongTitle", songTitle)
        insertCommand.Parameters.AddWithValue("@Artist", artist)
        insertCommand.Parameters.AddWithValue("@BPM", bpm)
        insertCommand.Parameters.AddWithValue("@MusicalKey", musicalKey)
        insertCommand.Parameters.AddWithValue("@Notes", notes)
        insertCommand.Parameters.AddWithValue("@ReadinessScore", readinessScore)
        'ACTUALLY SAVES SESSION INTO THE DATABASE
        insertCommand.ExecuteNonQuery()

        'DISPLAYS CONFIRMATION THE SESSION WAS STORED
        MessageBox.Show("Session saved to database")
        connection.Close()
        'DISPLAYS CONFIRMATION OF THE DATA THAT Is BEING STORED
        MessageBox.Show(songTitle & vbCrLf & artist & vbCrLf & bpm & vbCrLf & musicalKey & vbCrLf & notes)
    End Sub
    'CALCULATE THE READINESS PERCENTAGE BASED ON CHECKLIST ITEMS. BECAUSE THE FUNCTION ON NEEDS TWO
    'NUMBERS TO RETURN ONE SCORE, THIS SUFFICES AS TESTABLE CODE.
    Private Function CalculateReadinessScore(completedTasks As Integer, totalTasks As Integer) As Integer
        If totalTasks = 0 Then
            Return 0
        End If

        Return CInt((completedTasks / totalTasks * 100))
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnCalculateScore_Click(sender As Object, e As EventArgs) Handles btnCalculateScore.Click

        completedTasks = 0
        If chkVocalsEdited.Checked Then completedTasks += 1
        If chkGainStaging.Checked Then completedTasks += 1
        If chkEQCleanup.Checked Then completedTasks += 1
        If chkCompression.Checked Then completedTasks += 1
        If chkExportSettings.Checked Then completedTasks += 1
        If chkDeBreathing.Checked Then completedTasks += 1
        If chkDeEssing.Checked Then completedTasks += 1

        Dim readinessScore As Integer
        readinessScore = CalculateReadinessScore(completedTasks, totalTasks)

        MessageBox.Show("Rediness Score: " & readinessScore & "%")

    End Sub
    'This section creates the button click event handler for the Session
    'Metadata Search feature. When the user presses the Search button,
    'this triggers the logic responsible for retrieving matching
    'session information from the SQLite database based on the metadata entered
    'into the search field.
    Private Sub btnSearchSessions_Click(sender As Object, e As EventArgs) Handles btnSearchSessions.Click
        Dim searchValue As String = txtSearch.Text
        Dim connectionString As String = "Data Source=sessions2.db;Version=3;"
        Using connection As New SQLiteConnection(connectionString)


            connection.Open()
            Dim createTableQuery As String =
                "CREATE TABLE IF NOT EXISTS Sessions (" &
                "Id INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "SongTitle TEXT, " &
                "Artist TEXT, " &
                "BPM TEXT, " &
                "MusicalKey TEXT, " &
                "Notes TEXT, " &
                "ReadinessScore TEXT)"

            Dim createTableCommand As New SQLiteCommand(createTableQuery, connection)
            createTableCommand.ExecuteNonQuery()
            Dim query As String = "Select * FROM Sessions WHERE SongTitle Like @search Or Artist Like @search"
            Dim command As New SQLiteCommand(query, connection)

            command.Parameters.AddWithValue("@search", "%" & searchValue & "%")
            Dim reader As SQLiteDataReader = command.ExecuteReader()
            Dim foundResult As Boolean = False

            'CREATES A LOOP THAT WILL GO THROUGH EVERY MATCHING SESSION RETURNED FROM THE DATABASE SEARCH
            While reader.Read()
                'PULLS MATCHING DATABASE VALUES OUT OF EACH RETURNED SESSION RECORD
                Dim songTitle As String = reader("SongTitle").ToString()
                Dim artist As String = reader("Artist").ToString()
                Dim readinessScore As String = reader("ReadinessScore").ToString()

                foundResult = True

                MessageBox.Show("Song: " & songTitle & vbCrLf &
                                "Artist: " & artist & vbCrLf &
                                "Readiness Score: " & readinessScore & "%")


            End While
            If foundResult = False Then
                MessageBox.Show("No matching session found.")
            End If
        End Using
    End Sub
End Class
