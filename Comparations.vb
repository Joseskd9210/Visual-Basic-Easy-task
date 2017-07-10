Public Class Form1
    'Im going to put six buttons with differents function to each one
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'we are going to create a boolean variable to save the result of the comparation
        Dim result As Boolean
        'we are comparing the differents TextBox's values, if we got the same value the msgbox show us a true if no it show a false
        result = tb1.Text = tb2.Text
        MsgBox(result)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'we are going to create a boolean variable to save the result of the comparation
        Dim result As Boolean
        'we are comparing the differents TextBox's values, if tb1 is greater than the second one the msgbox show us a true if no it show a false
        result = tb1.Text > tb2.Text
        MsgBox(result)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'we are going to create a boolean variable to save the result of the comparation
        Dim result As Boolean
        'we are comparing the differents TextBox's values, if tb1 is smaller than the second one the msgbox show us a true if no it show a false
        result = tb1.Text < tb2.Text
        MsgBox(result)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'we are going to create a boolean variable to save the result of the comparation
        Dim result As Boolean
        'we are comparing the differents TextBox's values, if tb1 is greater or equal than the second one the msgbox show us a true if no it show a false
        result = tb1.Text >= tb2.Text
        MsgBox(result)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'we are going to create a boolean variable to save the result of the comparation
        Dim result As Boolean
        'we are comparing the differents TextBox's values, if tb1 is smaller or equal than the second one the msgbox show us a true if no it show a false
        result = tb1.Text <= tb2.Text
        MsgBox(result)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'we are going to create a boolean variable to save the result of the comparation
        Dim result As Boolean
        'we are comparing the differents TextBox's values, if tb1 is different than the second one the msgbox show us a true if no it show a false
        result = tb1.Text <> tb2.Text
        MsgBox(result)
    End Sub
End Class