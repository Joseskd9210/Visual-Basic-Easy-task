Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim num1, num2 As Integer
        num1 = TB1.Text
        num2 = TB2.Text
        'For do the comparations we need to put the word If () then END IF, if we wanna do another comparation we put ElseIf and Else for the las option
        If (num1 < num2) Then
            MsgBox("the number " & num1 & " is smaller than " & num2)
        ElseIf (num1 = num2) Then
            MsgBox("The number " & num1 & "is equal than" & num2)
        Else
            MsgBox("the number " & num2 & "is smaller than " & num1)
        End If
    End Sub
    'for search a word in a sentence we put nameofTextBox.Text.Contains("WORDTOSEARCH) in a if"
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (TB1.Text.Contains("WORLD")) Then
            MsgBox("the sentece contains the word WORLD")
        Else
            MsgBox("the sentece don't containt the word WORLD")
        End If
    End Sub
End Class