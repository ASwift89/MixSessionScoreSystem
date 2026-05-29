Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace MixSessionScoreSystem.Tests
    <TestClass>
    Public Class ReadinessScoreTests
        <TestMethod>
        Public Sub CalculatingReadinessScore_AllTasksCompleted__Returns100()
            Dim completedTasks As Integer = 7
            Dim totalTasks As Integer = 7

            Dim readinessScore As Integer =
                CInt((completedTasks / totalTasks) * 100)

            Assert.AreEqual(100, readinessScore)


        End Sub
    End Class
End Namespace

