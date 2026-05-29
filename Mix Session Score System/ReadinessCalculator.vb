Public Class ReadinessCalculator

    Public Function CalculateScore(completedTasks As Integer, totalTasks As Integer) As Integer

        If totalTasks = 0 Then
            Return 0
        End If

        Dim score As Double = (completedTasks / totalTasks) * 100
        Return CInt(score)

    End Function

End Class