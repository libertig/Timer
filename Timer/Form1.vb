Public Class Form1
    Dim hora As Integer
    Dim contador_horas As Integer
    Dim contador_minutos As Integer
    Dim minutos As Integer
    Dim tic As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer_segundos.Text = 0
        timer_minutos.Text = 0
        timer_horas.Text = 0
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        tic = tic + 1
        timer_segundos.Text = tic
        If tic = 60 Then
            timer_segundos.Text = 0
            contador_minutos = contador_minutos + 1
            minutos = minutos + 1
            timer_minutos.Text = minutos
            tic = 0
        End If
        If contador_minutos = 60 Then
            timer_minutos.Text = 0
            contador_horas = contador_horas + 1
            hora = hora + 1
            contador_minutos = 0
            timer_horas.Text = hora
            minutos = 0
        End If
        If contador_horas = 24 Then
            timer_horas.Text = 0
            hora = 0
            contador_horas = 0
        End If
    End Sub

    Private Sub Btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        timer.Enabled = True
        timer.Start()
    End Sub

    Private Sub Btn_pause_Click(sender As Object, e As EventArgs) Handles btn_pause.Click
        timer.Enabled = False
        timer.Stop()
    End Sub

    Private Sub Btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        timer.Enabled = False
        timer.Stop()
        timer_horas.Text = 0
        contador_horas = 0
        hora = 0
        timer_minutos.Text = 0
        contador_minutos = 0
        minutos = 0
        timer_segundos.Text = 0
        tic = 0
    End Sub
End Class
