Public Class formKasutajaAken
    Private Sub formKasutajaAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtValjundTekst1_TextChanged(sender As Object, e As EventArgs) Handles txtValjundTekst1.TextChanged

    End Sub



    Private Sub btnPoora1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btnPoora1.Click

        'Objekti loomine liidese baasil; referentsmuutuja pooraja dekla.
        Dim pooraja As PrjTekstiPooraja.ITeisendused


        If cbAlgoritmiline.Checked = True Then

            'Seadistame referentsmuutuja viitama uuele objektile
            pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja

        Else

            'Seadistame referentsmuutuja viitama uuele objektile
            pooraja = New PrjTekstiPooraja.CTekstiPooraja

        End If

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

        If cbAlgoritmiline.Checked = True Then

            'Seadistame referentsmuutuja viitama uuele objektile
            pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja

        Else

            'Seadistame referentsmuutuja viitama uuele objektile
            pooraja = New PrjTekstiPooraja.CTekstiPooraja

        End If

        'TEOSTAME TESTI PÖÖRAMISE KASUTADES PARAMEETRISEERIMATA FUNKTSIOONI pooraTekst
        'NING LIIDESEATRIBUUTI strTekst
        'omistame liidese atrib. tkstiväljal oleva väärtuse
        pooraja.teisendaTekst(txtSisendTekst.Text)
        txtValjundTekst2.Text = pooraja.strTekst

    End Sub

    Private Sub TimerUuenda_Tick(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TimerUuenda.Tick


        If cbAlgoritmiline.Checked = True Then

            Dim pooraja As PrjTekstiPooraja.ITeisendused

            pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja


            pooraja.strTekst = txtSisendTekst.Text

            txtValjundTekst1.Text = pooraja.pooraTekst

        Else
            Dim pooraja As PrjTekstiPooraja.ITeisendused

            pooraja = New PrjTekstiPooraja.CTekstiPooraja


            pooraja.strTekst = txtSisendTekst.Text

            txtValjundTekst1.Text = pooraja.pooraTekst
        End If



    End Sub

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btnStart.Click

        'vajutus nupul btnStart lülitab taimeri timerUuenda sisse
        TimerUuenda.Enabled = True
        'vajutus nupul btnStart keelab vajutused nupul btnStart
        btnStart.Enabled = False
        btnStop.Enabled = True

    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btnStop.Click

        'vajutus nupul btnStart lülitab taimeri timerUuenda välja
        TimerUuenda.Enabled = False
        'vajutus nupul btnStart lubab vajutused nupul btnStart
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub


    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) _
        Handles txtSisendTekst.TextChanged

        lblTekstiPikkus.Text = Len(txtSisendTekst.Text)

        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja
        pooraja.strTekst = txtSisendTekst.Text
        lblTaisHaalikud.Text = pooraja.otsiTaishaalik



    End Sub


End Class
