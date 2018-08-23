Public Class SplashScreen

    'When the form loads
    Private Sub SplashScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Timers are started
        Timer1.Start()
        Timer2.Start()
    End Sub

    'When timer 1 is complete login window is shown
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Login.Show()
        Me.Close()
    End Sub

    'When timer 2 is complete, progress bar continues.
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.PerformStep()
    End Sub
End Class
