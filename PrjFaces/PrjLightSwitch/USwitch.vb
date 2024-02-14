Public Class USwitch
    'Klassisisene meetod kuvatava pildi määramiseks
    Private Sub selectSwitch(ByVal intMood As Integer)
        pbSwitch.Image = imgSwitch.Images(intMood)

    End Sub
    ' Avalik liidesmeetod
    Public Sub setSwitch(ByVal strMood As String)
        Select Case strMood
            Case "off"
                Me.selectSwitch(0)
            Case "on"
                Me.selectSwitch(1)
        End Select
    End Sub


End Class
