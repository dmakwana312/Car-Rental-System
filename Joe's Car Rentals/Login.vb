Public Class Login

    Private Sub butEnter_Click(sender As Object, e As EventArgs) Handles butEnter.Click
        'Username and password variables are defined for users inpputs
        Dim username As String = txtfldUsername.Text.ToUpper()
        Dim password As String = txtfldPassword.Text

        'Correct username and password are defineds
        Dim cUsername As String = "MAI1234"
        Dim cPassword As String = "JP123"

        'If credentials are correct, customer form is shown and this form is closed.
        If username = cUsername Then
            If password = cPassword Then
                Customer.Show()
                Me.Close()
            Else
                MsgBox("Incorrect Credentials")
            End If
        Else
            MsgBox("Incorrect Credentials")
        End If

    End Sub

    Private Sub butTest_Click(sender As Object, e As EventArgs)


        Customer.Show()
        Me.Close()
    End Sub


   
End Class