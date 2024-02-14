Public Class UBulb
    'Klassisisene meetod kuvatava pildi määramiseks
    Private Sub selectLightMode(ByVal intMood As Integer)
        ClearPictureBox()
        pbBulb.Image = imgBulb.Images(intMood)

    End Sub


    Private Sub ClearPictureBox()

        If pbBulb.Image IsNot Nothing Then
            ' Dispose the image to release resources
            pbBulb.Image.Dispose()
            ' Set the PictureBox's image property to Nothing
            pbBulb.Image = Nothing
        End If
    End Sub
    Public Sub setLight(ByVal intLight As Integer)
        Select Case intLight
            Case 0
                Me.selectLightMode(0)
            Case 1
                Me.selectLightMode(1)
        End Select
    End Sub


End Class