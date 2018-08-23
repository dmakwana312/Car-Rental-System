Public Class Agreement


    'Names for external files are defined
    Dim customerExportFileName As String = "..\..\..\Resources\TransferFiles\customerTransfer.txt"
    Dim vehicleExportFileName As String = "..\..\..\Resources\TransferFiles\vehicleTransfer.txt"
    Dim rentalExportFileName As String = "..\..\..\Resources\TransferFiles\rentalTransfer.txt"

    'If agreement Accepted, invoice form is shown
    Private Sub butAccept_Click(sender As Object, e As EventArgs) Handles butAccept.Click
        Invoice.Show()
        Me.Close()
    End Sub

    'If agreement is declined external files are wiped and customer form is shown
    Private Sub butDecline_Click(sender As Object, e As EventArgs) Handles butDecline.Click
        IO.File.WriteAllText(customerExportFileName, "")
        IO.File.WriteAllText(vehicleExportFileName, "")
        IO.File.WriteAllText(rentalExportFileName, "")

        Customer.Show()
        Me.Close()

    End Sub

    'Customer form button
    Private Sub butCustomer_Click(sender As Object, e As EventArgs) Handles butCustomer.Click
        Customer.Show()
        Me.Close()
    End Sub

    'Rental form button
    Private Sub butRental_Click(sender As Object, e As EventArgs) Handles butRental.Click
        Rental.Show()
        Me.Close()
    End Sub

    'Invoice button form
    Private Sub butInvoice_Click(sender As Object, e As EventArgs) Handles butInvoice.Click

        MessageBox.Show("Please Complete this Agreement Form to Access This Form")

    End Sub
End Class