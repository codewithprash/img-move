Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        car.Left += 2
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 10
    End Sub

    Private Sub car_LocationChanged(sender As Object, e As EventArgs) Handles car.LocationChanged
        If car.Left >= Width Then
            car.Left = 0
        End If
    End Sub
End Class
