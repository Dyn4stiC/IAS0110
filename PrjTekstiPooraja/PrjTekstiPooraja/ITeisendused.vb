Public Interface ITeisendused
    Property intAlgus As Integer 'teksti esimene sümbol ASCII koodi jaoks
    Property intLopp As Integer 'teksti viimane sümbol ASCII koodi jaoks
    Property strTekst As String 'Kasutaja sisestatud teksti jaoks

    Function pooraTekst() As String 'Liidese meetodid koodi ei oma
    Function otsiTaishaalik() As String 'Funktsionn taishaalikute arvu leidmsks
    Sub teisendaTekst(ByRef strSisendTekst As String)


End Interface
