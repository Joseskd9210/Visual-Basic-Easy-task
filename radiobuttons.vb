Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'We'll save the TextBox's values in this variables
        Dim n1, n2 As Integer
        Dim result As Double
        'We got the values wrote by the user
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        'Now we have the differents if, elseif and else to do the operation
        If (sum.Checked) Then
            result = n1 + n2
        ElseIf (remainder.Checked) Then
            result = n1 - n2
        ElseIf (multiplication.Checked) Then
            result = n1 * n2
        Else
            result = n1 / n2
        End If
        MsgBox("The result is " + result.ToString)
    End Sub
End Class