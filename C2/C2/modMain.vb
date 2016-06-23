Module modMain

    'Global variable declaration
    Public Title, Slogan, YName, FSString As String
    Public FSNum, SATotal, CCWTotal, IITotal, DITotal, SCTotal, STTotal, LTTotal, SETotal As Decimal
    Public Exemptions, Income, AGI, TotalExemptions, TaxableIncome, TotalTax, Withheld, Taxes As Decimal

    Sub IsInvalidSSN(ByRef o As Object, ByRef b As Boolean)
        'Tests for invalid Social Security Number
        If Not o.Text Like "###-##-####" Then
            MsgBox(o.AccessibleName & " is not valid. Must be in ###-##-#### format.", MsgBoxStyle.Critical, "Error")
            o.Focus()
            b = True
        Else
            b = False
        End If
    End Sub

    Function IsBlank(o As Object) As Boolean
        'Tests for blank input
        If (Len(Trim(o.Text.ToString)) > 0) Then Return False
        Return True
    End Function

    Function IsNegative(d As Decimal) As Boolean
        'Tests for negative input
        If (d >= 0) Then Return False
        Return True
    End Function

    Function CZer(o As Object) As Decimal
        'Converts textbox from blank or non-numeric to zero
        If o = "" Then o = 0
        If Not IsNumeric(o) Then o = 0
        Return o
    End Function

End Module