﻿Imports PrjLightSwitch

Public Class Form1

    Dim state As Integer
    Private bool As Boolean = False
    Private Sub btnConfused_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnConfused.Click
        UCtrlEmotion1.setMood("confused")
        btnClear.Enabled = True
    End Sub

    Private Sub btnCool_Click(ByVal sender As Object, e As EventArgs) _
            Handles btnCool.Click
        UCtrlEmotion1.setMood("cool")
        btnClear.Enabled = True
    End Sub

    Private Sub btnSmile_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnSmile.Click
        UCtrlEmotion1.setMood("smile")
        btnClear.Enabled = True
    End Sub

    Private Sub btnStar_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnStar.Click
        UCtrlEmotion1.setMood("star")
        btnClear.Enabled = True
    End Sub

    Private Sub btnTeeth_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnTeeth.Click
        UCtrlEmotion1.setMood("teeth")
        btnClear.Enabled = True
    End Sub

    Private Sub btnYell_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnYell.Click
        UCtrlEmotion1.setMood("yell")
        btnClear.Enabled = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnClear.Click
        UCtrlEmotion1.ClearPictureBox()
        btnClear.Enabled = False
    End Sub

    Private Sub UBulb1_Load(sender As Object, e As EventArgs) _
         Handles UBulb1.Load
        UBulb1.setLight(0)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrBulb.Start()
    End Sub


    Private Sub tmrBulb_Tick(sender As Object, e As EventArgs) Handles tmrBulb.Tick

        state = USwitch1.bool
        UBulb1.setLight(state)

    End Sub

End Class
