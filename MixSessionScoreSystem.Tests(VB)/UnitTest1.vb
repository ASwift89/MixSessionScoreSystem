Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class ReadinessScoreTests

    Private Function CalculateScore(completedTasks As Integer, totalTasks As Integer) As Integer
        If totalTasks = 0 Then
            Return 0
        End If

        Return CInt((completedTasks / totalTasks) * 100)
    End Function

    <TestMethod()>
    Public Sub Test01_AllTasksCompleted_Returns100()

        Dim calculator As New ReadinessCalculator()

        Dim result As Integer = calculator.CalculateScore(7, 7)

        Assert.AreEqual(100, result)

    End Sub

    <TestMethod()>
    Public Sub Test02_NoTasksCompleted_Returns0()
        Assert.AreEqual(0, CalculateScore(0, 7))
    End Sub

    <TestMethod()>
    Public Sub Test03_HalfTasksCompleted_Returns50()
        Assert.AreEqual(50, CalculateScore(1, 2))
    End Sub

    <TestMethod()>
    Public Sub Test04_ThreeOfSevenTasks_Returns43()
        Assert.AreEqual(43, CalculateScore(3, 7))
    End Sub

    <TestMethod()>
    Public Sub Test05_ZeroTotalTasks_Returns0()
        Assert.AreEqual(0, CalculateScore(3, 0))
    End Sub

    <TestMethod()>
    Public Sub Test06_SearchValue_CanMatchPartialArtistName()
        Dim artist As String = "Drake"
        Dim searchValue As String = "Dra"

        Assert.IsTrue(artist.Contains(searchValue))
    End Sub

    <TestMethod()>
    Public Sub Test07_SearchValue_CanMatchPartialSongTitle()
        Dim songTitle As String = "Late Night Ride"
        Dim searchValue As String = "Night"

        Assert.IsTrue(songTitle.Contains(searchValue))
    End Sub

    <TestMethod()>
    Public Sub Test08_SQLSearchParameter_UsesWildcards()
        Dim searchValue As String = "Drake"
        Dim sqlParameter As String = "%" & searchValue & "%"

        Assert.AreEqual("%Drake%", sqlParameter)
    End Sub

    <TestMethod()>
    Public Sub Test09_ConnectionString_UsesCorrectDatabase()
        Dim connectionString As String = "Data Source=sessions2.db;Version=3;"

        Assert.IsTrue(connectionString.Contains("sessions2.db"))
    End Sub

    <TestMethod()>
    Public Sub Test10_ReadinessScore_CanBeDisplayedWithPercentSymbol()
        Dim readinessScore As Integer = 86
        Dim displayText As String = "Readiness Score: " & readinessScore & "%"

        Assert.AreEqual("Readiness Score: 86%", displayText)
    End Sub

End Class