Public Class FormConverter

    Const KM2MI_CONV_RATE = 1.609344
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Try
            txtMi.Text = txtKm.Text / KM2MI_CONV_RATE
        Catch ex As Exception
            'MsgBox("Tekkis viga!", MsgBoxStyle.Critical, "KÕIK ON KATKI!!!")
            txtMi.Text = "Sisendi viga!"
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Timer südmus "tick" käivitatakse iga sek tagant
        timerClock.Interval = 1000

        ' Lülitame timeri sisse
        timerClock.Enabled = True
    End Sub

    Private Sub VäljuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VäljuToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub timerClock_Tick(sender As Object, e As EventArgs) Handles timerClock.Tick
        lblClock.Text = DateTime.Now
    End Sub

    Private Sub lblClock_Click(sender As Object, e As EventArgs) Handles lblClock.Click
        timerClock.Enabled = Not timerClock.Enabled
        lblClock.Text = "meow"
    End Sub
End Class