Public Class Rööpkülik
    Inherits Nelinurk

    Private korgus As Double
    Public Sub New(ByVal alus As Double, ByVal haar As Double, ByVal korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Rööpkülik", alus, haar, alus, haar)

        Me.korgus = korgus
    End Sub

    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
