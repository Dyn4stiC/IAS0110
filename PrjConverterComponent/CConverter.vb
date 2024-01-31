Public Class CConverter
    Implements IConverter

    Const KM2Mi = 1.609344
    Public Function ConvertKilometersToMiles(kilometers As Double) As Double Implements IConverter.ConvertKilometersToMiles
        Return kilometers / KM2Mi

    End Function
End Class
