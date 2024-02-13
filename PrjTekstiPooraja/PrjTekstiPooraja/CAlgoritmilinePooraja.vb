Public Class CAlgoritmilinePooraja
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

    Public Sub teisendaTekst(ByRef strSisendTekst As String) _
        Implements ITeisendused.teisendaTekst

        strPooratavTekst = strSisendTekst
        Dim charArray() As Char = strPooratavTekst.ToCharArray()
        Dim length As Integer = Len(strPooratavTekst)
        Dim left As Integer = 0
        Dim right As Integer = length - 1

        While left < right
            'vaheta charrid
            Dim temp As Char = charArray(left)
            charArray(left) = charArray(right)
            charArray(right) = temp

            'move counters towards the center
            left += 1
            right -= 1
        End While

        'Loo uus string tähtede massiivist
        strPooratavTekst = New String(charArray)
    End Sub


    Public Function pooraTekst() As String _
        Implements ITeisendused.pooraTekst

        Dim charArray() As Char = strPooratavTekst.ToCharArray()
        Dim length As Integer = charArray.Length
        Dim left As Integer = 0
        Dim right As Integer = length - 1

        While left < right
            ' vaheta charrid
            Dim temp As Char = charArray(left)
            charArray(left) = charArray(right)
            charArray(right) = temp

            ' Move pointers towards the center
            left += 1
            right -= 1
        End While

        'tagasta uus string tähtede massiivist
        Return New String(charArray)
    End Function

    Private Function otsiTaishaalik() As String _
        Implements ITeisendused.otsiTaishaalik

        Dim I As Integer
        Dim nVowels As Integer
        Dim Vowels As String
        Dim InputString As String

        Vowels = "aeiouõäöü"
        InputString = LCase(strPooratavTekst)

        For I = 1 To Len(InputString)
            If InStr(Vowels, Mid(InputString, I, 1)) Then
                nVowels = nVowels + 1
            End If
        Next
        Return "Täishäälikuid: " & nVowels
    End Function
End Class
