Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Module General
    ReadOnly varKey As String = "!hX7W#i]3:nh<Fj>+{[,.MvIRF=Kk!+Sm8DBFEqi@9dU/\iLS}UR;C)]LZ;fm?>"
    Dim generator As New Random
    Dim varName As String = "Guest"
    Dim censoredWords As IList(Of String)
    Dim varCorrect As Integer
    Dim varAnswered As Integer
    Dim varMaxQuestion As Integer = 9
    Dim varNumber1 As Decimal = generator.Next(1, 5)
    Dim varNumber2 As Decimal = generator.Next(1, 5)
    Dim varAnswer As Decimal
    Dim varType As Integer = generator.Next(1, 4)
    Dim varTopic As String

    Public Property Name() As String
        Get
            Return varName
        End Get
        Set(ByVal value As String)
            If IsEmptyNullOrWhitespaceOnly(value) = False Then
                LoadFilter()
                Dim censor As New Censor(censoredWords)
                If censor.CensorText(value) Then
                    MessageBox.Show("The name you entered contains bad language.", "Name not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    varName = "Guest"
                Else
                    Dim temp As String
                    Try
                        temp = value.Insert(value.IndexOf(" ") + 1, value.ToUpper.Chars(value.IndexOf(" ") + 1))
                        temp = temp.Remove(value.IndexOf(" ") + 2, 1)
                    Catch ArgumentOutOfRangeException As Exception
                        temp = value
                    End Try
                    temp = temp.Insert(0, temp.ToUpper.Chars(0))
                    varName = temp.Remove(1, 1)
                End If
            Else
                varName = "Guest"
            End If
        End Set
    End Property

    Public Property Correct() As Integer
        Get
            Return varCorrect
        End Get
        Set(ByVal value As Integer)
            varCorrect = value
        End Set
    End Property

    Public Property Answered() As Integer
        Get
            Return varAnswered
        End Get
        Set(ByVal value As Integer)
            varAnswered = value
        End Set
    End Property

    Public Property Number1() As Decimal
        Get
            Return varNumber1
        End Get
        Set(ByVal value As Decimal)
            varNumber1 = value
        End Set
    End Property

    Public Property Number2() As Decimal
        Get
            Return varNumber2
        End Get
        Set(ByVal value As Decimal)
            varNumber2 = value
        End Set
    End Property

    Public Property Answer() As Decimal
        Get
            Return varAnswer
        End Get
        Set(ByVal value As Decimal)
            varAnswer = value
        End Set
    End Property

    Public Property Type() As Integer
        Get
            Return varType
        End Get
        Set(ByVal value As Integer)
            varType = value
        End Set
    End Property

    Public Sub Generate()
        General.Number1 = generator.Next(1, 5)
        General.Number2 = generator.Next(1, 5)
        General.Type = generator.Next(1, 4)
    End Sub

    Public Sub MenuAction(ByVal CurrentForm As Form, ByVal NextForm As Form, ByVal Name As String)
        General.Name = Name
        NextForm.Show()
        CurrentForm.Close()
    End Sub

    Public Sub MenuAction(ByVal CurrentForm As Form, ByVal NextForm As Form)
        NextForm.Show()
        CurrentForm.Close()
    End Sub

    Public Sub ApplicationExit()
        Dim button As DialogResult
        button = MessageBox.Show("By exiting " & My.Application.Info.Title & " you work will not be saved" & vbNewLine & "To exit press Yes", "Exit " & My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        If button = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Public Sub LoadFilter()
        Try
            Using str As FileStream = File.OpenRead("filter.db")
                Dim bf As New BinaryFormatter()
                Dim stfi As ArrayList = New ArrayList(DirectCast(bf.Deserialize(str), ArrayList))
                censoredWords = New List(Of String)
                For Each word As String In stfi
                    Dim temp As String = Crypto.DecryptTripleDES(word, General.Key)
                    censoredWords.Add(temp)
                Next
            End Using
        Catch ex As Exception
            censoredWords = New List(Of String)()
        End Try
    End Sub

    Public Function IsEmptyNullOrWhitespaceOnly(ByVal stringToCheck As String, ByVal ParamArray whitespaceChars() As Char) As Boolean
        If String.IsNullOrEmpty(stringToCheck) Then Return True
        Return IsWhitespaceOnly(stringToCheck, whitespaceChars)
    End Function

    Public Function IsWhitespaceOnly(ByVal stringToCheck As String, ByVal ParamArray whitespaceChars() As Char) As Boolean
        Dim length As Int32 = stringToCheck.Length
        Dim middle As Int32 = length \ 2
        Dim first As Int32 = middle
        Dim second As Int32 = middle + 1
        Dim chr As Char

        If whitespaceChars Is Nothing OrElse whitespaceChars.Length = 0 Then
            whitespaceChars = New Char() {" "c, ChrW(&H3000)}
        End If

        Dim whitespaceUbound As Int32 = whitespaceChars.Length - 1
        Dim hasNonWhitespace As Boolean = False

        For i As Int32 = 0 To middle

            If first >= 0 Then
                hasNonWhitespace = True
                chr = stringToCheck.Chars(first)
                For j As Int32 = 0 To whitespaceUbound
                    If chr = whitespaceChars(j) Then
                        hasNonWhitespace = False
                        Exit For
                    End If
                Next
                first -= 1
            End If

            If hasNonWhitespace Then Return False

            If second < length Then
                hasNonWhitespace = True
                chr = stringToCheck.Chars(second)
                For j As Int32 = 0 To whitespaceUbound
                    If chr = whitespaceChars(j) Then
                        hasNonWhitespace = False
                        Exit For
                    End If
                Next
                second += 1
            End If

            If hasNonWhitespace Then Return False

        Next

        Return Not hasNonWhitespace

    End Function

    Public Function MD5Hash(ByVal strToEncrypt As String) As String
        Dim ue As System.Text.UTF8Encoding = New System.Text.UTF8Encoding
        Dim bytes As Byte() = ue.GetBytes(strToEncrypt)
        Dim md5 As System.Security.Cryptography.MD5CryptoServiceProvider = New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim hashBytes As Byte() = md5.ComputeHash(bytes)
        Dim hashString As String = ""
        Dim i As Integer = 0
        While i < hashBytes.Length
            hashString += Convert.ToString(hashBytes(i), 16).PadLeft(2, "0"c)
            System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        Return hashString.PadLeft(32, "0"c)
    End Function

    Public Sub ClearResults()
        General.Correct = 0
        General.Answered = 0
    End Sub

    Public ReadOnly Property Key() As String
        Get
            Return varKey
        End Get
    End Property

    Public ReadOnly Property MaxQuestion() As Integer
        Get
            Return varMaxQuestion
        End Get
    End Property

    Public Property Topic() As String
        Get
            Return varTopic
        End Get
        Set(ByVal value As String)
            varTopic = value
        End Set
    End Property
End Module

