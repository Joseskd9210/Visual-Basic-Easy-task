Public Class Form1

    'When we do a double click on the button We access to put a function onclick for the button like JavaScript
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        'create variables to sum the numbers
        Dim num1, num2, sum As Integer
        'to accces to the textBox's value we need to put variable.Text
        num1 = TBnum1.Text
        num2 = TBnum2.Text
        sum = num1 + num2
        MsgBox(sum)
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'Other button close the application
        Me.Close()

    End Sub
End Class
