﻿Public Class Form5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.ForeColor = Color.Orange
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.LightGreen
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.ForeColor = Color.Orange
        Label3.ForeColor = Color.White
        Label1.ForeColor = Color.LightGreen
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label3.ForeColor = Color.Orange
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.LightGreen
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer1.Interval = 300
        Timer2.Interval = 400
        Timer3.Interval = 500
    End Sub
End Class