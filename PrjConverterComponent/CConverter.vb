Public Class CConverter
    Implements IConverter

    Private Property Miles As Double

    Const KM2Mi = 1.609344
    Public Function ConvertKilometersToMiles(kilometers As Double) As Double Implements IConverter.ConvertKilometersToMiles
        Return kilometers / KM2Mi

    End Function

    ' demonstratiivne, mitte praktiline - näitame protseduuri kasutust 
    Private Sub ConvKm2Mi(ByVal km As Double)
        Miles = km / KM2Mi
    End Sub
End Class
