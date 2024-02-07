Public Class CTekstiPooraja
    Implements ITeisendused

    'Klassi CTesktiPooraja atribuudid (muutujad)
    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String


    'Liidese omaduste seadistamine
    'Atribuut intAlgus seadistamine
    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSymbol 'küsimisel tagasta intAlgusSymbol
        End Get
        Set(ByVal value As Integer)
            intAlgusSymbol = value 'atribuudi väärtuse seadistamine
        End Set
    End Property

    'Atribuut intLopp seadistamine
    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol
        End Get
        Set(ByVal value As Integer)
            intLoppSymbol = value
        End Set
    End Property

    'Atribuut strTekst seadistamine
    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTekst = value
        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) _
        Implements ITeisendused.teisendaTekst
        strPooratavTekst = StrReverse(strSisendTekst)
    End Sub

    Private Function pooraTekst() As String _
        Implements ITeisendused.pooraTekst
        Return StrReverse(strPooratavTekst)
    End Function
End Class
