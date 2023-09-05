Public Class Form1
    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub BtnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim Name As String
        Dim Surname As String
        Dim Gender As String

        Name = txtName.Text
        Surname = txtSurname.Text
        Gender = txtGender.Text

        MsgBox("hello " & Name & "  " & Surname & " it is good to know you are " & Gender)
    End Sub
End Class
