Public Class formKasutajaAken
    Private Sub formKasutajaAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtValjundTekst1_TextChanged(sender As Object, e As EventArgs) Handles txtValjundTekst1.TextChanged

    End Sub

    Private Sub btnPoora1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btnPoora1.Click

        'Objekti loomine liidese baasil; referentsmuutuja pooraja dekla.
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'TEOSTAME TESTI PÖÖRAMISE KASUTADES PARAMEETRISEERIMATA FUNKTSIOONI pooraTekst
        'NING LIIDESEATRIBUUTI strTekst
        'omistame liidese atrib. tkstiväljal oleva väärtuse
        pooraja.strTekst = txtSisendTekst.Text

        txtValjundTekst1.Text = pooraja.pooraTekst()

    End Sub

    Private Sub btnPoora2_Click(sender As Object, e As EventArgs) _
        Handles btnPoora2.Click

        'Objekti loomine liidese baasil; referentsmuutuja pooraja dekla.
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'TEOSTAME TESTI PÖÖRAMISE KASUTADES PARAMEETRISEERIMATA FUNKTSIOONI pooraTekst
        'NING LIIDESEATRIBUUTI strTekst
        'omistame liidese atrib. tkstiväljal oleva väärtuse
        pooraja.teisendaTekst(txtSisendTekst.Text)

        txtValjundTekst2.Text = pooraja.strTekst

    End Sub

    Private Sub TimerUuenda_Tick(sender As Object, e As EventArgs) Handles TimerUuenda.Tick

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) _
        Handles btnStart.Click

        'vajutus nupul btnStart lülitab taimeri timerUuenda sisse
        TimerUuenda.Enabled = True
        'vajutus nupul btnStart keelab vajutused nupul btnStart
        btnStart.Enabled = False

    End Sub
End Class
