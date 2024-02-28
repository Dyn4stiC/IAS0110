Public Class Romb
    Inherits Nelinurk

    Private korgus As Double
    Public Sub New(ByVal kylg As Double, ByVal korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Romb", kylg, kylg, kylg, kylg)

        Me.korgus = korgus
    End Sub

    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function

End Class
