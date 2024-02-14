Imports PrjLightSwitch

Public Class Form1

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
        UBulb1.setLight("off")
    End Sub

    Private Sub USwitch1_Load(sender As Object, e As EventArgs) _
            Handles USwitch1.Load
        USwitch1.setSwitch("on")
    End Sub

    Private Sub USwitch1_Click(sender As Object, e As EventArgs) _
        Handles USwitch1.Click


    End Sub


    Private Sub USwitch1_MouseClick(sender As Object, e As MouseEventArgs) Handles USwitch1.MouseClick
        If bool = False Then
            USwitch1.setSwitch("on")
            UBulb1.setLight("off")
            bool = True
        Else
            USwitch1.setSwitch("off")
            UBulb1.setLight("on")
            bool = False
        End If
    End Sub
End Class
