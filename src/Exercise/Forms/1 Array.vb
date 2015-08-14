
'Creeparray 0.2.3
'2012/10/10 - 2012/11/27
'Simple Program to work with arrays
'Mim. Alef.

Public Class Array

    Dim A() As Integer

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If A Is Nothing Then ReDim A(0) Else ReDim A(A.Length)
        A(A.GetUpperBound(0)) = InputBox("Insert Interger: ", "Input Box")
        List.Items.Add(A(A.GetUpperBound(0)))
    End Sub

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        MsgBox("The count of array is " & A.Length, MsgBoxStyle.OkOnly, "Array Count")
    End Sub

    Private Sub Array_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Visible = True
    End Sub

End Class