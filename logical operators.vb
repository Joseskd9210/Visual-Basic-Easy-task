Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'We need a boolean's variable for save he result
        Dim result As Boolean
        'with (AND) just it show us true if all the values are true
        result = (1 = 1) And (2 = 2)
        'this msgBox show us true
        MsgBox(result)
        result = (1 = 2) And (2 = 2)
        'but now the msgbox show us false, because the two comparations are not the same
        MsgBox(result)
        'with (OR) just it show us false if all the values are false
        result = (1 = 1) Or (2 = 2)
        'this msgBox show us true
        MsgBox(result)
        result = (1 = 2) Or (2 = 2)
        'this msgBox also show us true
        MsgBox(result)
        result = (1 = 2) Or (2 = 3)
        'But this msgBox show us false, because the two values are different
        MsgBox(result)
        'with (NOT) if we have a true sentence it show us false as value
        result = Not (2 = 2)
        'this msgBox show us false, because it's a true sentece 
        MsgBox(result)
        result = Not (2 <> 2)
        'this msgBox show us true, because we have the same values
        MsgBox(result)


    End Sub
End Class