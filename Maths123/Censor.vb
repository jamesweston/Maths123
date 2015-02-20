Imports System.Text.RegularExpressions

Public Class Censor

    Private _CensoredWords As IList(Of String)
    Public Property CensoredWords() As IList(Of String)
        Get
            Return _CensoredWords
        End Get
        Private Set(ByVal value As IList(Of String))
            _CensoredWords = value
        End Set
    End Property


    Public Sub New(ByVal censoredWords__1 As IEnumerable(Of String))
        If censoredWords__1 Is Nothing Then

            Throw New ArgumentNullException("censoredWords")
        End If
        CensoredWords = New List(Of String)(censoredWords__1)
    End Sub

    Public Function CensorText(ByVal text As String) As Boolean

        If text Is Nothing Then
            Throw New ArgumentNullException("text")
        End If

        Dim censoredText As String = text
        For Each censoredWord As String In CensoredWords
            
            Dim regularExpression As String = ToRegexPattern(censoredWord)
            If Regex.IsMatch(censoredText, regularExpression, RegexOptions.IgnoreCase Or RegexOptions.CultureInvariant) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Shared Function StarCensoredMatch(ByVal m As Match) As String
        Dim word As String = m.Captures(0).Value
        Return New String("*"c, word.Length)
    End Function


    Private Function ToRegexPattern(ByVal wildcardSearch As String) As String
        Dim regexPattern As String = Regex.Escape(wildcardSearch)
        regexPattern = regexPattern.Replace("\*", ".*?")
        regexPattern = regexPattern.Replace("\?", ".")
        If regexPattern.StartsWith(".*?") Then
            regexPattern = regexPattern.Substring(3)
            regexPattern = "(^\b)*?" & regexPattern
        End If
        regexPattern = "\b" & regexPattern & "\b"
        Return regexPattern
    End Function
End Class

