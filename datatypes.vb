Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'How to create a integer in Visual basic   
        Dim int As Integer = 1
        MsgBox(int)
        'How to change variable's value   
        int = 2
        MsgBox(int)
        'How to create a double in Visual basic   
        Dim dou As Double = 2.333
        MsgBox(dou)
        'How to change variable's value
        dou = 2.5
        MsgBox(dou)
        'How to create a double in Visual basic   
        Dim text As String = " Hi World"
        MsgBox(text)
        Dim text2 As String = " Bye World"
        'How to join two variables Visual basic   
        MsgBox(text + text2)
        'How to put dates Visual basic   
        Dim dat As Date = "01/02/1992"
        MsgBox(dat)
        'How to put dates Visual basic   
        Dim dat2 As Date = "01/jan/12"
        MsgBox(dat2)
    End Sub
End Class