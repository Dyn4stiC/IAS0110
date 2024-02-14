Public Class UBulb
    'Klassisisene meetod kuvatava pildi määramiseks
    Private Sub selectLightMode(ByVal intMood As Integer)
        pbBulb.Image = imgBulb.Images(intMood)

    End Sub
    ' Avalik liidesmeetod
    Public Sub setLight(ByVal intLight As Integer)
        Select Case intLight
            Case 0
                Me.selectLightMode(0)
            Case 1
                Me.selectLightMode(1)
        End Select
    End Sub


End Class