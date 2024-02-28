Public Class formKujundid

    Private Sub tootleKujund(ByRef kujund As Kujund)
        lblTyyp.Text = kujund.annaTyyp

        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmberMoot
    End Sub
End Class
