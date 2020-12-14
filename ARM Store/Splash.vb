Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar2.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 40 Then

        End If
        If ProgressBar1.Value = 100 Then
            Form1.Show()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub
End Class