Public Class USwitch

    Public bool As Integer = 0
    Private Sub selectSwitchMode(ByVal intMood As Integer)
        ClearPictureBox()
        pbSwitch.Image = imgSwitch.Images(intMood)

    End Sub


    Private Sub pbSwitch_Click(sender As Object, e As EventArgs) _
            Handles pbSwitch.Click

        If bool = 0 Then
            Me.selectSwitchMode(1)
            bool = 1
        Else
            Me.selectSwitchMode(0)
            bool = 0
        End If
    End Sub


    Private Sub ClearPictureBox()

        If pbSwitch.Image IsNot Nothing Then
            ' Dispose the image to release resources
            pbSwitch.Image.Dispose()
            ' Set the PictureBox's image property to Nothing
            pbSwitch.Image = Nothing
        End If
    End Sub


    Private Sub USwitch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbSwitch.Image = imgSwitch.Images(0)
    End Sub
End Class
