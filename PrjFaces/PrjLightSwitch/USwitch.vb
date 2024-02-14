Public Class USwitch

    Public bool As Integer = 0

    Private Sub pbSwitch_Click(sender As Object, e As EventArgs) _
            Handles pbSwitch.Click

        If bool = 0 Then
            pbSwitch.Image = imgSwitch.Images(1)
            bool = 1
        Else
            pbSwitch.Image = imgSwitch.Images(0)
            bool = 0
        End If
    End Sub

    Private Sub USwitch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbSwitch.Image = imgSwitch.Images(0)
    End Sub
End Class
