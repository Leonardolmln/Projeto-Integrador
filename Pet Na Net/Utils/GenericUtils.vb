Imports System.Text.RegularExpressions

Module GenericUtils

    Public Function AddZeros(str As String) As String
        Do While str.Length < 11
            str = "0" & str
        Loop
        Return str
    End Function

    Public Function CleanString(str As String) As String
        Return Regex.Replace(str, "[^a-zA-Z0-9]", "")
    End Function

    Public Function GenerateMatricula() As String
        Dim gen As New Random
        Dim mat As String = ""
        For cont = 1 To 6
            mat += gen.Next(0, 9).ToString()
        Next
        Return mat
    End Function

    Public Function GenerateSenha() As String
        Dim gen As New Random
        Dim pass As String = ""
        pass += Chr(gen.Next(65, 90))
        For cont = 1 To 3
            pass += Chr(gen.Next(97, 122))
        Next
        For cont = 1 To 4
            pass += gen.Next(0, 9).ToString()
        Next
        Return pass
    End Function

End Module
