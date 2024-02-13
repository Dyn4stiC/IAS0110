Public Class UBulb
    'Klassisisene meetod kuvatava pildi määramiseks
    Private Sub selectLightMode(ByVal intMood As Integer)
        pbBulb.Image = imgBulb.Images(intMood)

    End Sub
    ' Avalik liidesmeetod
    Public Sub setLight(ByVal strMood As String)
        Select Case strMood
            Case "off"
                Me.selectMood(0)
            Case "on"
                Me.selectMood(1)
            Case Else
                Me.selectMood(0)
        End Select
    End Sub
End Class
