Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Mix_Session_Score_System

<TestClass()>
Public Class ReadinessScoreTests

    <TestMethod()>
    Public Sub Test01_AllTasksCompleted_Returns100()

        Dim calculator As New ReadinessCalculator()

        Dim result As Integer = calculator.CalculateScore(7, 7)

        Assert.AreEqual(100, result)

    End Sub

End Class