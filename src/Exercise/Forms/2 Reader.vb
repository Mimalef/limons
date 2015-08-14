
'Reader 0.7.2
'Change number to word, and text to speech!
'2012/10/11 - 2012/12/23
'Mim. Alef.

Public Class Reader

#Region "Declare"

    Dim enOnes() As String = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
    Dim enTens() As String = {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
    Dim enGroup() As String = {"", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septendecillion", "Octodecillion"}

    Dim faOnes() As String = {"صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه", "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هیفده", "هجده", "نوزده"}
    Dim faTens() As String = {"", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود"}
    Dim faGroup() As String = {"", "هزار", "ملیون", "بیلیون", "بیلیارد", "تریلیون", "تریلیارد", "کادریلیون", "کادریلیارد", "کوانتینیوم", "کوانتینیارد", "سکستیلیون", "سکستیلیارد", "سپتیلیون", "سپتیلیارد", "اکتیلیون", "اکتیلیارد", "نانیلیون", "نانیلیارد", "دسیلیون"}

    Dim Ones(), Tens(), Group() As String

    Dim EndPoint As Integer = 1

#End Region

#Region "Events"

    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged

        If IsNumeric(txtInput.Text) Then
            txtEN.Text = NumToWord(txtInput.Text, "en")
            txtFA.Text = NumToWord(txtInput.Text, "fa")
        Else
            txtInput.Text = ""
        End If

    End Sub

    Private Sub txtEN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEN.Click

        Dim SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(txtEN.Text)

    End Sub

    Private Sub txtFA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFA.Click

        While (txtEN.TextLength > EndPoint)

            Dim StartPoint As Integer = EndPoint

            EndPoint = InStr(EndPoint, txtEN.Text, " ")

            If EndPoint Then
                txtEN.Focus()
                txtEN.SelectionStart = StartPoint - 1
                txtEN.SelectionLength = EndPoint - StartPoint
                Read(txtEN.SelectedText)
            End If

            EndPoint = EndPoint + 1

        End While

        EndPoint = 1

    End Sub

    Private Sub Reader_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Main.Visible = True

    End Sub

#End Region

#Region "Functions"

    Public Function NumToWord(ByVal Number As Decimal, ByVal Language As String) As String

        Dim Remainder As Decimal = Number
        Dim Counter As Byte = 0
        Dim Outcome As String = ""

        If Language = "en" Then Ones = enOnes.Clone : Tens = enTens.Clone : Group = enGroup.Clone
        If Language = "fa" Then Ones = faOnes.Clone : Tens = faTens.Clone : Group = faGroup.Clone

        While (Remainder > 0)
            Outcome = Hundred(Remainder Mod 1000, Language) & " " & Group(Counter) & " " & Outcome
            Remainder = Fix(Remainder / 1000)
            Counter += 1
        End While

        Return (Outcome)

    End Function

    Public Function Hundred(ByVal Number As Integer, ByVal Language As String) As String

        Dim One = "", Ten = "", Hun As String = ""

        Select Case (Number)

            Case 1 To 19
                One = Ones(Number)

            Case 20 To 99
                Ten = Tens(Number \ 10)
                If Number Mod 10 <> 0 Then One = " " & Ones(Number Mod 10)

            Case 100 To 999
                If Language = "en" Then
                    Hun = Ones(Number \ 100) & " Hundred"
                    If Number Mod 100 <> 0 Then
                        Ten = " " & Tens((Number Mod 100) \ 10)
                    End If
                End If
                If Language = "fa" Then
                    Hun = Ones(Number \ 100) & " صد و"
                    If Number Mod 100 <> 0 Then
                        Ten = " " & Tens((Number Mod 100) \ 10) & " و "
                    End If
                End If
                If Number Mod 10 <> 0 Then
                    One = " " & Ones(Number Mod 10)
                End If

        End Select

        Return (Hun & Ten & One)

    End Function

    Public Sub Read(ByVal Number As String)

        If Number <> "" Then

            My.Computer.Audio.Play("..\..\Sound\" + Number + ".wav", AudioPlayMode.WaitToComplete)

        End If
    End Sub

#End Region

End Class