'header stuff

Option Strict On 'No conversions by compiler
Option Explicit On 'Must declare all variables

Module VariableExamples 'PascalCase

    Sub Main()
        Dim x As Integer
        Dim y As Double
        Dim result As Decimal

        Const TAXRATE = 0.06@ 'type specifier forces desired type

        Dim personName As String 'camelCase
        Dim firstName As String
        Dim lastName As String
        Dim age As Integer

        x = 10

        result = x * TAXRATE
        'result = result + x
        result += x

        'y = 2.5
        'result = x + CInt(y) 'force myself to convert to integer


        'age% = 42
        'firstName$ = "Joe"
        'lastName$ = "Barnes"

        'personName = firstName & " " & lastName
        'Console.WriteLine(personName _
        '                    & " is " _
        '                    & CStr(age) _
        '                    & " years old.") 'wrap long lines with SPACE underscore " _"

        Console.Read()
    End Sub

End Module
