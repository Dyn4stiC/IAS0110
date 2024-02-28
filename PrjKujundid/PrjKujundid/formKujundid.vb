Public Class formKujundid

    Private Sub tootleKujund(ByRef kujund As Kujund)
        lblTyyp.Text = kujund.annaTyyp



        txtPindala.Text = Math.Round(kujund.leiaPindala, cbTapsus.SelectedIndex)
        txtYmbermoot.Text = Math.Round(kujund.leiaYmberMoot, cbTapsus.SelectedIndex)
    End Sub

    Private Sub btnKolmnurk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnKolmnurk.Click

        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektKolmnurk)
    End Sub

    Private Sub btnRuut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRuut.Click

        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRistkylik.Click

        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
    End Sub


    Private Sub btnRomb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRomb.Click
        tootleKujund(New Romb(txtKylgA.Text, txtKorgus.Text))
    End Sub

    Private Sub btnRoopkylik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRoopkylik.Click
        tootleKujund(New Roopkylik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text))
    End Sub


    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tmr.Tick


        If IsNumeric(txtKylgA.Text) And IsNumeric(txtKylgB.Text) And IsNumeric(txtKorgus.Text) Then
            btnRuut.Enabled = True
            btnKolmnurk.Enabled = True
            btnRistkylik.Enabled = True
            btnRomb.Enabled = True
            btnRoopkylik.Enabled = True

        ElseIf IsNumeric(txtKylgA.Text) And IsNumeric(txtKylgB.Text) Then
            btnRuut.Enabled = True
            btnKolmnurk.Enabled = True
            btnRistkylik.Enabled = True
            btnRomb.Enabled = False
            btnRoopkylik.Enabled = False

        ElseIf IsNumeric(txtKylgA.Text) And Not IsNumeric(txtKylgB.Text) Then
            btnRuut.Enabled = True
            btnKolmnurk.Enabled = False
            btnRistkylik.Enabled = False
            btnRomb.Enabled = False
            btnRoopkylik.Enabled = False

        Else
            btnRuut.Enabled = False
            btnKolmnurk.Enabled = False
            btnRistkylik.Enabled = False
            btnRomb.Enabled = False
            btnRoopkylik.Enabled = False
        End If
    End Sub

    Private Sub formKujundid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTapsus.SelectedIndex = 0
    End Sub
End Class
