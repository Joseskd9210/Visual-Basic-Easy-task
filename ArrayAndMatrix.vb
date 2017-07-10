Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'How to create a String's array
        Dim array(3) As String
        array(0) = "Hello"
        array(1) = "world"
        array(2) = "!!!"
        MsgBox(array(0) + " " + array(1) + " " + array(2))
        'How to create a integer's array
        Dim array2() As Integer
        array2 = New Integer() {1, 2, 3}
        MsgBox(array2(0).ToString + " " + array2(1).ToString + " " + array2(2).ToString)
        'How to resize a integer's array keeping the data
        ReDim Preserve array2(2)
        MsgBox(array2(0).ToString + " " + array2(1).ToString)
        'How to resize a integer's array without keeping the data
        ReDim array2(3)
        MsgBox(array2(0).ToString + " " + array2(1).ToString)
        'How to resize a integer's matrix 
        Dim matrix(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        MsgBox(matrix(1, 1).ToString)

    End Sub
End Class