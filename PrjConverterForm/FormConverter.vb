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
End Class