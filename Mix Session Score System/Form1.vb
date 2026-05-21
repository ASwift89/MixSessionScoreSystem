Imports System.Data.SQLite
Public Class Form1
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
            "Notes TEXT)"
        'EXECUTES THE DROP TABLE COMMAND
        dropTableCommand.ExecuteNonQuery()
        Dim createTableCommand As New SQLiteCommand(createTableQuery, connection)

        'CREATES THE SESSIONS TABLE IN THE DATABASE IF IT DOESNT ALREADY EXIST
        createTableCommand.ExecuteNonQuery().ToString()
        'SQLite INSERT QUERY USED TO SAVE THE SESSION INFORMATION INTO THE DATABAS TABLE
        Dim insertQuery As String =
            "insert INTO Sessions (SongTitle, Artist, BPM, MusicalKey, Notes)" &
            "VALUES (@SongTitle, @Artist, @BPM, @MusicalKey, @Notes)"

        'CREATES THE SQL COMMAND OBJECT FOR THE INSERT QUERY
        Dim insertCommand As New SQLiteCommand(insertQuery, connection)
        'PARAMETERS SAFELY CONNECT USER INPUT VALUES TO THE SQL QUERY
        insertCommand.Parameters.AddWithValue("@SongTitle", songTitle)
        insertCommand.Parameters.AddWithValue("@Artist", artist)
        insertCommand.Parameters.AddWithValue("@BPM", bpm)
        insertCommand.Parameters.AddWithValue("@MusicalKey", musicalKey)
        insertCommand.Parameters.AddWithValue("@Notes", notes)
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
        Dim completedTasks As Integer = 0
        Dim totalTasks As Integer = 7

        If chkVocalsEdited.Checked Then completedTasks += 1
        If chkGainStaging.Checked Then completedTasks += 1
        If chkEQCleanup.Checked Then completedTasks += 1
        If chkCompression.Checked Then completedTasks += 1
        If chkExportSettings.Checked Then completedTasks += 1
        If chkDeBreathing.CHecked Then completedTasks += 1
        If chkDeEssing.Checked Then completedTasks += 1

        Dim readinessScore As Integer
        readinessScore = CalculateReadinessScore(completedTasks, totalTasks)

        MessageBox.Show("Rediness Score: " & readinessScore & "%")

    End Sub
End Class
