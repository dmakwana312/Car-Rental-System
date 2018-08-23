Imports System.IO

Public Class Rental

    'File and array to import customer informaition are defined as variables
    Dim customerImport As String = "..\..\..\Resources\TransferFiles\customerTransfer.txt"
    Dim customerTransferArray() As String = File.ReadAllLines(customerImport)

    'File names for exporting details are defined to variable
    Dim vehicleExportFileName As String = "..\..\..\Resources\TransferFiles\vehicleTransfer.txt"
    Dim rentalExportFileName As String = "..\..\..\Resources\TransferFiles\rentalTransfer.txt"

    'Arrays to hold details before export are created
    Dim vehicleSearch(7) As String
    Dim rentalInfomation(10) As String

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

    'Variables to hold customer inputs are declared as well as dates
    Dim customerID, registrationNo, firstName, lastName, mobileNo, manufacturer, model As String
    Dim startDate, endDate As Date

    'When the form loads
    Private Sub Rental_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Necessary about the customer is imported
        txtfldCustomerID.Text = customerTransferArray(0)
        txtfldFirstName.Text = customerTransferArray(1)
        txtfldLastName.Text = customerTransferArray(2)

        'Values of the start and end date fields are declared
        txtfldStartDate.MinDate = DateTime.Now
        txtfldEndDate.MinDate = DateTime.Now.AddDays(1)

        'Data base provider and source is assigned
        connection.ConnectionString = dbProvider & dbSource

        'Conenction is opened and query is created
        connection.Open()
        query = "SELECT * FROM Vehicle"

        'Adapter for the data is created using the query and connection variables
        'and dataset is filed
        dataAdapter = New OleDb.OleDbDataAdapter(query, connection)
        dataAdapter.Fill(dataSet, "Vehicle")

        'Datagridview in form is filled
        Me.dgvVehicleRecords.DataSource = dataSet
        Me.dgvVehicleRecords.DataMember = "Vehicle"

        'Connection is closed
        connection.Close()

        'Picture box is made visibles
        pbCar.Visible = False

    End Sub

    'Customer form button
    Private Sub butCustomer_Click(sender As System.Object, e As System.EventArgs) Handles butCustomer.Click
        'Customer form is shown and this form is hidden
        Customer.Show()
        Me.Hide()

    End Sub
    'Agreement form button
    Private Sub butAgreement_Click(sender As Object, e As EventArgs) Handles butAgreement.Click
        MessageBox.Show("Please Complete this Rental Form to Access This Form")
    End Sub
    'Invoice form button
    Private Sub butInvoice_Click(sender As Object, e As EventArgs) Handles butInvoice.Click
        MessageBox.Show("Please Complete this Customer Form to Access This Form")
    End Sub

    'Close button
    Private Sub butClose_Click(sender As System.Object, e As System.EventArgs) Handles butClose.Click
        'All external files are wiped
        IO.File.WriteAllText(customerImport, "")
        IO.File.WriteAllText(vehicleExportFileName, "")
        IO.File.WriteAllText(rentalExportFileName, "")

        'Program is closed
        Application.Exit()
    End Sub

    'Clear button
    Private Sub butClear_Click(sender As System.Object, e As System.EventArgs) Handles butClear.Click

        'All text field are cleared
        txtfldRentalID.Text = ""
        txtfldCustomerID.Text = ""
        txtfldRegistrationNo.Text = ""
        txtfldFirstName.Text = ""
        txtfldLastName.Text = ""
        txtfldMobile.Text = ""
        txtfldManufacturer.Text = ""
        txtfldModel.Text = ""
        txtfldStartDate.Value = DateTime.Now
        txtfldEndDate.Value = DateTime.Now.AddDays(1)
        txtfldDuration.Text = ""

        'External files are wiped
        IO.File.WriteAllText(customerImport, "")
        IO.File.WriteAllText(vehicleExportFileName, "")
        IO.File.WriteAllText(rentalExportFileName, "")

    End Sub

    'Search buttor
    Private Sub butSearch_Click(sender As System.Object, e As System.EventArgs) Handles butSearch.Click

        'Registration number is capitalised and assigned to variable
        registrationNo = txtfldRegistrationNo.Text.ToUpper()

        'Variable used in while loop are defined
        Dim index As Integer
        Dim rowCount As Integer

        'Path to folder with images is defined to variable 
        Dim path As String = "..\..\..\Resources\Images"
        Dim fullImgPath As String
        Dim vehicleFound As Boolean = False

        'If registration number is valid
        If registrationNo.Length <= 10 Then
            'Number of rows in data set are assigned to variable
            rowCount = dataSet.Tables(0).Rows.Count

            'While the value of index is less than the number of rows
            While index < rowCount

                'If a record is found
                If dataSet.Tables("Vehicle").Rows(index).Item(0) = registrationNo Then

                    'Elements of the records are added to an array from the database
                    vehicleSearch(0) = registrationNo
                    vehicleSearch(1) = dataSet.Tables("Vehicle").Rows(index).Item(1)
                    vehicleSearch(2) = dataSet.Tables("Vehicle").Rows(index).Item(2)
                    vehicleSearch(3) = dataSet.Tables("Vehicle").Rows(index).Item(3)
                    vehicleSearch(4) = dataSet.Tables("Vehicle").Rows(index).Item(4)
                    vehicleSearch(5) = dataSet.Tables("Vehicle").Rows(index).Item(5)
                    vehicleSearch(6) = dataSet.Tables("Vehicle").Rows(index).Item(6)
                    vehicleSearch(7) = dataSet.Tables("Vehicle").Rows(index).Item(7)

                    'The path to the image is defined
                    fullImgPath = System.IO.Path.Combine("../../../Resources/Images/", registrationNo & ".png")
                    'Image is inserted into picture box
                    pbCar.Image = Image.FromFile(fullImgPath)
                    'Picture box is shown
                    pbCar.Visible = True

                    vehicleFound = True

                    'Necessary information is imported and inserted into text fields
                    txtfldManufacturer.Text = vehicleSearch(1)
                    txtfldModel.Text = vehicleSearch(2)
                    txtfldRegistrationNo.Text = txtfldRegistrationNo.Text.ToUpper

                    Exit While

                    'If vehicle is not found
                ElseIf dataSet.Tables("Vehicle").Rows(index).Item(0) <> registrationNo Then

                    '1 is added to the index
                    index += 1

                End If

            End While

        End If

        'If vehicle is not found
        If vehicleFound = False Then
            MessageBox.Show("Vehicle Not Found")
        End If

    End Sub

    Private Sub butCreate_Click(sender As System.Object, e As System.EventArgs) Handles butCreate.Click
        'Variable that will be used to check if inputs are valid is created and delcared
        Dim valid_inputs As Boolean = True

        'Inputs are assigned to variables
        customerID = txtfldCustomerID.Text
        registrationNo = txtfldRegistrationNo.Text
        firstName = txtfldFirstName.Text
        lastName = txtfldLastName.Text
        mobileNo = txtfldMobile.Text
        manufacturer = txtfldManufacturer.Text
        model = txtfldModel.Text
        startDate = CDate(txtfldStartDate.Text)
        endDate = CDate(txtfldEndDate.Text)

        'Mobile number validation
        If mobileNo = "" Or mobileNo.Length() <> 11 Or Not IsNumeric(mobileNo) Then
            valid_inputs = False
            mobileError.Text = "Invalid Telephone Number"
        End If

        'Duration validation
        If txtfldDuration.Text = "" Or Not IsNumeric(txtfldDuration.Text) Then

            durationError.Text = "Invalid Duration"
        End If

        'Validation for data
        If startDate >= endDate Then
            valid_inputs = False
            sDateError.Text = "Invalid Start Date"
            eDateError.Text = "Invalid End Date"
        End If
        If startDate < Date.Today Then
            valid_inputs = False
            sDateError.Text = "Invalid Start Date"
        End If

        'If inputs are valid
        If valid_inputs = True Then

            'Price is calculated
            Dim price As Double
            price = vehicleSearch(6) * txtfldDuration.Text

            'Message box to show price is shown and user option is assigned to variable
            Dim proceed As String = MsgBox("Cost of Rental will be: £" & price & vbCrLf & "Would you like to proceed?", vbYesNo)

            'If the user wishes to proceed, inputs are exported to external file
            If proceed = vbYes Then
                rentalInfomation(0) = registrationNo.ToUpper
                rentalInfomation(1) = customerID
                rentalInfomation(2) = registrationNo.ToUpper
                rentalInfomation(3) = firstName
                rentalInfomation(4) = lastName
                rentalInfomation(5) = mobileNo
                rentalInfomation(6) = manufacturer
                rentalInfomation(7) = model
                rentalInfomation(8) = startDate
                rentalInfomation(9) = endDate
                rentalInfomation(10) = txtfldDuration.Text

                IO.File.WriteAllLines(vehicleExportFileName, vehicleSearch)
                IO.File.WriteAllLines(rentalExportFileName, rentalInfomation)

                'Agreement form is shown and this form is closed
                Agreement.Show()
                Me.Close()

            Else
                MessageBox.Show("Please make changes required")
            End If

        End If

    End Sub

    'Start date value change
    Private Sub txtfldStartDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtfldStartDate.ValueChanged
        'Dates from form are assigned to variable
        startDate = CDate(txtfldStartDate.Text)
        endDate = CDate(txtfldEndDate.Text)

        'Validation
        If endDate < startDate Then
            endDate.AddDays(1)
        End If

    End Sub

    'End data value change
    Private Sub txtfldEndDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtfldEndDate.ValueChanged

        'Start date and end date are assigned to variables
        startDate = CDate(txtfldStartDate.Text)
        endDate = CDate(txtfldEndDate.Text)

        'If the inputs are not valid an error message is shown
        If startDate >= endDate Then

            sDateError.Text = "Invalid Start Date"
            eDateError.Text = "Invalid End Date"

        ElseIf startDate < Date.Today Then

            sDateError.Text = "Invalid Starts Date"

        Else
            'The dates are subtracted to find the duration
            txtfldDuration.Text = endDate.Subtract(startDate).TotalDays
        End If

    End Sub
End Class