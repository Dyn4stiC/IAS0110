Public Class Form1

    Private Sub btnConfused_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnConfused.Click
        UCtrlEmotion1.setMood("confused")
    End Sub

    Private Sub btnCool_Click(ByVal sender As Object, e As EventArgs) _
            Handles btnCool.Click
        UCtrlEmotion1.setMood("cool")
    End Sub

    Private Sub btnSmile_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnSmile.Click
        UCtrlEmotion1.setMood("smile")
    End Sub

    Private Sub btnStar_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnStar.Click
        UCtrlEmotion1.setMood("star")
    End Sub

    Private Sub btnTeeth_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnTeeth.Click
        UCtrlEmotion1.setMood("teeth")
    End Sub

    Private Sub btnYell_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnYell.Click
        UCtrlEmotion1.setMood("yell")
    End Sub
End Class
