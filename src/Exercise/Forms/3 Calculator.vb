
'Calman 0.5.5
'2012/10/20 - 2012/11/27
'Calculator without using toolbox
'Mim. Alef.

Public Class Calculator

#Region "Declare"

    'Variables
    Dim Answer As Double = 0
    Dim Switch As Boolean = False
    Dim Operators As String = ""

    'Create Text Box
    Dim txtShow As New TextBox With {.Parent = Me, .Name = "txtShow", .Top = 12, .Left = 12, .Width = 175, .Font = New Font("Tahoma", 14), .ReadOnly = True, .MaxLength = 12}

#End Region

#Region "Function"

    'receipt number and operater then calculate and return answer
    Public Sub Calculate(ByVal Number As Double, ByVal Operater As String)

        Select Case Operater

            Case "+" : Answer = Answer + Number
            Case "-" : Answer = Answer - Number
            Case "*" : Answer = Answer * Number
            Case "/" : Answer = Answer / Number
            Case "^" : Answer = Answer ^ Number
            Case "sqr" : Answer = Answer ^ (1 / 2)
            Case Else : Answer = Number

        End Select

        txtShow.Text = Answer

    End Sub

    'clear text
    Private Sub Clear(ByVal s As Object, ByVal e As EventArgs)

        If Switch = True Then
            txtShow.Text = ""
            Switch = False
        End If

    End Sub

    'buttons handel
    Private Sub Button_Click(ByVal Sender As Object, ByVal e As EventArgs)

        Select Case CStr(Sender.Text)

            Case "0" To "9", "."
                txtShow.Text = txtShow.Text + Sender.Text

            Case "+", "-", "*", "/", "^", "sqr"
                Calculate(txtShow.Text, Operators)
                Operators = Sender.Text
                Switch = True

            Case "<-"
                txtShow.Text = txtShow.Text \ 10

            Case "C"
                Answer = 0
                Operators = ""
                txtShow.Text = ""

            Case "="
                Calculate(txtShow.Text, Operators)
                Operators = ""
                Switch = True

        End Select

    End Sub

#End Region

#Region "Event"

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Form Properties
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Calman"
        Me.BackColor = Color.Turquoise
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Width = 205
        Me.Height = 230

        'Create Button
        Dim Button(20) As Button
        Dim Top = 49, Left = 12, Counter As Byte = 1
        Dim Texts(,) As String = {{"1", "2", "3", "+", "<-"}, {"4", "5", "6", "-", "C"}, {"7", "8", "9", "*", "^"}, {".", "0", "=", "/", "sqr"}}

        For i As Integer = 0 To 3
            For j As Integer = 0 To 4
                Button(Counter) = New Button
                With Button(Counter)
                    .Parent = Me
                    .FlatStyle = FlatStyle.System
                    .Top = Top
                    .Left = Left
                    .Width = 30
                    .Height = 30
                    .Text = Texts(i, j)
                    AddHandler .Click, AddressOf Button_Click
                    If Counter = 1 Or Counter = 2 Or Counter = 3 Or Counter = 6 Or Counter = 7 Or Counter = 8 Or Counter = 11 Or Counter = 12 Or Counter = 13 Or Counter = 17 Then AddHandler .MouseDown, AddressOf Clear
                End With
                Counter += 1 : Left += 36
            Next
            Left = 12 : Top += 36
        Next

    End Sub

    Private Sub Calculator_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Main.Visible = True

    End Sub

#End Region

End Class