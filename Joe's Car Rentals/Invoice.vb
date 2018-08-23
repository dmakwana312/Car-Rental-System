Imports System.Data.OleDb
Imports System.IO
Imports System.Globalization

Public Class Invoice

    'Variables for final price, discout and duration are declared
    Dim finalPrice As Decimal
    Dim discount As Decimal
    Dim duration As Integer

    'Variable for payment type is declared
    Dim paymentType As String

    'Variables for fee and duration are declared
    Dim fee As Integer

    'Details are imported from external files
    Dim customerImport As String = "..\..\..\Resources\TransferFiles\customerTransfer.txt"
    Dim customerTransferArray() As String = File.ReadAllLines(customerImport)
    Dim VehicleImport As String = "..\..\..\Resources\TransferFiles\VehicleTransfer.txt"
    Dim VehicleTransferArray() As String = File.ReadAllLines(VehicleImport)
    Dim RentalImport As String = "..\..\..\Resources\TransferFiles\RentalTransfer.txt"
    Dim RentalTransferArray() As String = File.ReadAllLines(RentalImport)

    'Start and end date are parsed to dates and assignment to variables
    Dim sDate As DateTime = Date.ParseExact(RentalTransferArray(8), "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo)
    Dim eDate As DateTime = Date.ParseExact(RentalTransferArray(9), "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo)

    'Details required to create conenction with database are created and declared
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim theDatabase As String = "/Joe's Car Rental Database.mdb"
    Dim dbPath As String = "..\.."
    Dim fullDbPath As String = dbPath & theDatabase
    Dim dbSource As String = "Data Source =" & fullDbPath
    Dim dataSet As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim query As String

    'When the form loads
    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'User is asked how they will be paying (cash or card) and input is assigned to variable
        paymentType = MsgBox("Will you be Paying by Cash?" & vbCrLf & "If no, it will be assumed you are paying by card", vbYesNo)

        'Payment method variable is declared
        Dim paymentMethod As String

        'If payment method is cash, text fields for card payments are disabled
        If paymentType = vbYes Then
            txtfldCardNo.Enabled = False
            txtfldNameOnCard.Enabled = False
            txtfldExpiryDate.Enabled = False
            txtfldSecurityCode.Enabled = False
            paymentMethod = "Cash"

            'If payment method is card, text fields for cash payments are disabled
        Else
            txtfldAmountDue.Enabled = False
            txtfldAmountPaid.Enabled = False
            txtfldChange.Enabled = False
            paymentMethod = "Card"
        End If

        'Fee and duration is imported from external file
        fee = Decimal.Parse(VehicleTransferArray(6))
        duration = Decimal.Parse(RentalTransferArray(10))

        'Price is calculated and assigned to variable
        Dim price As Decimal = fee * duration

        'Based on price, discount rate is determined
        If price < 300 Then
            discount = 0
        ElseIf price >= 300 And price < 500 Then
            discount = 0.2
        ElseIf price >= 500 And price < 600 Then
            discount = 0.3
        ElseIf price > 600 Then
            discount = 0.4
        Else
            discount = 0.5
        End If

        'Using discount final price is calculated
        If discount = 0 Then
            finalPrice = price
        Else
            finalPrice = (price * (1 - discount))

        End If

        'Final price is formated to 2 decimal place
        finalPrice = Format(finalPrice, "0.00")

        'Final price is entered to text field
        txtfldAmountDue.Text = finalPrice

        'Receipt is made
        rtbReceipt.Text = "Receipt " & vbCrLf & vbCrLf & "Date of Purchase: " & DateTime.Today _
            & vbCrLf & vbCrLf & "Start of Rental: " & sDate & vbCrLf & "End of Rental: " & eDate _
            & vbCrLf & "Duration: " & duration & " Day(s)" & vbCrLf & vbCrLf & "Payment Method: " & paymentMethod _
            & vbCrLf & "Cost: £" & price & vbCrLf & "Discount: " & (discount * 100) & "%" & vbCrLf & vbCrLf _
            & "Amount Due: £" & finalPrice
    End Sub

    'Pay button
    Private Sub butPay_Click(sender As Object, e As EventArgs) Handles butPay.Click

        'Variable to check for successful payment is declared
        Dim paymentSuccessful As Boolean = True

        'Based on payment validation occurs
        If paymentType = vbYes Then
            Dim amountDue As Decimal = txtfldAmountDue.Text
            Dim amountPaid As Decimal = txtfldAmountPaid.Text
            If amountPaid >= amountDue Then
                txtfldChange.Text = amountPaid - amountDue

            ElseIf amountPaid < amountDue Then
                MessageBox.Show("Payment Unsuccessful")
                paymentSuccessful = False
            End If
        Else

            Dim expiryDate As Date = CDate(txtfldExpiryDate.Text)
            If txtfldCardNo.Text.Length <> 16 Or Not IsNumeric(txtfldCardNo.Text) Then
                MessageBox.Show("Payment Unsuccessful")
                paymentSuccessful = False
            End If
            If expiryDate < Date.Now() Then

                MessageBox.Show("Payment Unsuccessful")
                paymentSuccessful = False
            End If
            If txtfldNameOnCard.Text = "" Then
                MessageBox.Show("Payment Unsuccessful")
                paymentSuccessful = False
            End If

            If txtfldSecurityCode.Text.Length <> 3 Or Not IsNumeric(txtfldSecurityCode.Text) Then
                MessageBox.Show("Payment Unsuccessful")
                paymentSuccessful = False
            End If
        End If

        'If payment is successful
        If paymentSuccessful = True Then
            'An attempt is made to add data to database
            Try

                'Data base provider and source is assigned
                connection.ConnectionString = dbProvider & dbSource

                'connection is opened
                connection.Open()

                'SQL query is assigned to variable
                query = "INSERT INTO Rental (RentalID, CustomerID, RegistrationNo, FirstName, LastName, " _
                         & "Mobile, Manufacturer, Model, StartDate, EndDate, Duration) " _
                         & "VALUES (@RentalID, CustomerID, @RegistrationNo, @FirstName, @LastName," _
                         & "@Mobile, @Manufacturer, @Model, @StartDate, @EndDate, @Duration)"


                'Command variable is created to execute the query
                Dim command As New OleDbCommand(query, connection)

                'Rental and Invoice ID are generated
                Dim rentalID As Integer = randomInteger(4)
                Dim InvoiceID As Integer = randomInteger(4)

                'Placeholders in query are replaced with acutal values
                command.Parameters.AddWithValue("@RentalID", rentalID)
                command.Parameters.AddWithValue("@CustomerID", Integer.Parse(RentalTransferArray(1)))
                command.Parameters.AddWithValue("@RegistrationNo", RentalTransferArray(2))
                command.Parameters.AddWithValue("@FirstName", RentalTransferArray(3))
                command.Parameters.AddWithValue("@LastName", RentalTransferArray(4))
                command.Parameters.AddWithValue("@Mobile", RentalTransferArray(5))
                command.Parameters.AddWithValue("@Manufacturer", RentalTransferArray(6))
                command.Parameters.AddWithValue("@Model", RentalTransferArray(7))
                command.Parameters.AddWithValue("@StartDate", sDate)
                command.Parameters.AddWithValue("@EndDate", eDate)
                command.Parameters.AddWithValue("@Duration", duration)

                'Query is executed
                command.ExecuteNonQuery()

                'SQL query is assigned to variable
                query = "INSERT INTO Invoice (InvoiceID, CustomerID, RegistrationNo, FirstName, " _
                    & "LastName, Discount, Cost, RentalID) " _
                    & "VALUES (@InvoiceID, @CustomerID, @RegistrationNo, @FirstName, " _
                    & "@LastName, @Discount, @Cost, @RentalID)"
                'Command variable is created to execute the query
                Dim command2 As New OleDbCommand(query, connection)
                'Placeholders in query are replaced with acutal values
                command2.Parameters.AddWithValue("@InvoiceID", InvoiceID)
                command2.Parameters.AddWithValue("@CustomerID", Integer.Parse(RentalTransferArray(1)))
                command2.Parameters.AddWithValue("@RegistrationNo", RentalTransferArray(2))
                command2.Parameters.AddWithValue("@FirstName", RentalTransferArray(3))
                command2.Parameters.AddWithValue("@LastName", RentalTransferArray(4))
                command2.Parameters.AddWithValue("@Discount", discount)
                command2.Parameters.AddWithValue("@Cost", finalPrice)
                command2.Parameters.AddWithValue("@RentalID", rentalID)

                'Query is executed
                command2.ExecuteNonQuery()

                'Conenction is closed
                connection.Close()

                'Confirmation is shown to the user
                MsgBox("Rental Was Created Successfully" & vbCrLf & vbCrLf _
                       & "You will be returned to the Customer Form")

                'External files are wiped
                IO.File.WriteAllText(customerImport, "")
                IO.File.WriteAllText(VehicleImport, "")
                IO.File.WriteAllText(RentalImport, "")

                'Customer form is shown
                Customer.Show()
                Me.Close()

            Catch ex As Exception

                'Connection is closed
                connection.Close()

                'Error message is displayed
                MsgBox(ex.Message)

            End Try
        End If

    End Sub

    'Cancel button
    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        'Variable for the confirmation message box is created
        Dim confirmation As String

        'Message box for the confirmation is created 
        confirmation = MsgBox("Do you wish to cancel? ", vbYesNo)

        'If user wants to cancel, external files are wiped and customer form is shown
        If confirmation = vbYes Then
            IO.File.WriteAllText(customerImport, "")
            IO.File.WriteAllText(VehicleImport, "")
            IO.File.WriteAllText(RentalImport, "")

            Customer.Show()
            Me.Close()

        End If
    End Sub

End Class