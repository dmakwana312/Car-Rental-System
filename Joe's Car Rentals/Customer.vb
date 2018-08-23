Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Customer

    Dim customerExport(9) As String
    Dim customerExportFileName As String = "..\..\..\Resources\TransferFiles\customerTransfer.txt"

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

    'Variable that will be in validation stage, before inserting data to database
    Dim valid_inputs As Boolean = True

    'Variables to hold the data inputted are created
    Dim customerID, firstName, lastName, DOB, tel, addrL1, addrL2, postCode, email, LicenseNo As String

    'When the form loads up
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Data from file is imported into an array
        Dim customerImportFileName As String = "..\..\..\Resources\TransferFiles\customerTransfer.txt"
        Dim customerImport() As String = File.ReadAllLines(customerImportFileName)

        'If there is data in the file, the array is split up into the text fields on the form
        If customerImport.Length = 9 Then

            txtfldCustomerID.Text = customerImport(0)
            txtfldFirstName.Text = customerImport(1)
            txtfldLastName.Text = customerImport(2)
            txtfldDOB.Text = customerImport(3)
            txtfldTel.Text = customerImport(4)
            txtfldAddress1.Text = customerImport(5)
            txtfldAddress2.Text = customerImport(6)
            txtfldPostCode.Text = customerImport(7)
            txtfldEmail.Text = customerImport(8)
            txtfldLicenseNo.Text = customerImport(9)

        End If
    End Sub

    'Rental form button
    Private Sub butRental_Click(sender As System.Object, e As System.EventArgs) Handles butRental.Click

        MessageBox.Show("Please Complete this Customer Form to Access This Form")

    End Sub

    'Agreement formbutton
    Private Sub butAgreement_Click(sender As Object, e As EventArgs) Handles butAgreement.Click

        MessageBox.Show("Please Complete this Customer Form to Access This Form")

    End Sub

    'Invoice form button
    Private Sub butInvoice_Click(sender As Object, e As EventArgs) Handles butInvoice.Click

        MessageBox.Show("Please Complete this Customer Form to Access This Form")
    End Sub

    'Search button
    Private Sub butSearch_Click(sender As Object, e As EventArgs) Handles butSearch.Click

        'Dataset is cleared
        dataSet.Tables.Clear()

        'CustomerID is assigned to a variable
        customerID = txtfldCustomerID.Text

        'Validation for the customer ID
        If customerID.Length() <> 6 Or Not IsNumeric(customerID) Then
            MsgBox("Invalid Customer ID")

        Else

            'If customer ID is valid, attempt will be made to find record of the customer
            Try
                'Data base provider and source is assigned
                connection.ConnectionString = dbProvider & dbSource

                'connection is opened
                connection.Open()

                'Query is assigned to variable
                query = "SELECT * FROM Customer WHERE CustomerID = " & customerID & ""

                'Adapter for the data is created using the query and connection variables
                dataAdapter = New OleDb.OleDbDataAdapter(query, connection)

                'DataSet is filled
                dataAdapter.Fill(dataSet, "Customer")

                'Connection is closed
                connection.Close()

                'If a record is found with the customer ID
                If dataSet.Tables("Customer").Rows.Count = 1 Then

                    'First name and last name from the record are combined
                    Dim customer_Name As String = (dataSet.Tables("Customer").Rows(0).Item(1) & " " & dataSet.Tables("Customer").Rows(0).Item(2)).ToString()

                    'Variable for the confirmation message box is created
                    Dim confirmation As String

                    'Message box for the confirmation is created 
                    confirmation = MsgBox("Confirm you are: " & customer_Name, vbYesNo)

                    'If confirmed
                    If confirmation = vbYes Then
                        'Values in the record will be used to fill the form
                        txtfldFirstName.Text = dataSet.Tables("Customer").Rows(0).Item(1)
                        txtfldLastName.Text = dataSet.Tables("Customer").Rows(0).Item(2)
                        txtfldDOB.Text = dataSet.Tables("Customer").Rows(0).Item(3)
                        txtfldTel.Text = dataSet.Tables("Customer").Rows(0).Item(4)
                        txtfldAddress1.Text = dataSet.Tables("Customer").Rows(0).Item(5)
                        txtfldAddress2.Text = dataSet.Tables("Customer").Rows(0).Item(6)
                        txtfldPostCode.Text = dataSet.Tables("Customer").Rows(0).Item(7)
                        txtfldEmail.Text = dataSet.Tables("Customer").Rows(0).Item(8)
                        txtfldLicenseNo.Text = dataSet.Tables("Customer").Rows(0).Item(9)

                        'Data found dataset is inserted to array and written to external text file
                        customerExport(0) = customerID
                        customerExport(1) = txtfldFirstName.Text
                        customerExport(2) = txtfldLastName.Text
                        customerExport(3) = txtfldDOB.Text
                        customerExport(4) = txtfldTel.Text
                        customerExport(5) = txtfldAddress1.Text
                        customerExport(6) = txtfldAddress2.Text
                        customerExport(7) = txtfldPostCode.Text
                        customerExport(8) = txtfldEmail.Text
                        customerExport(9) = txtfldLicenseNo.Text

                        IO.File.WriteAllLines(customerExportFileName, customerExport)

                        'Customer form is closed and rental form is opened
                        Rental.Show()
                        Me.Close()

                    Else
                        'If not confirmed, message is shown to correct the customer ID
                        MsgBox("Please Ensure Customer ID is Correct")
                    End If

                Else
                    'If record is not found, error message is shown
                    MsgBox("Customer Does Not Exist")

                End If

                'If error occurs when searching database, it will be catched and displayed
            Catch ex As Exception

                'Connection is closed
                connection.Close()

                'Error message is displayed
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    'Create button
    Private Sub butCreate_Click(sender As Object, e As EventArgs) Handles butCreate.Click

        IO.File.WriteAllText(customerExportFileName, "")

        'Inputted data is stored in a correspending variable
        firstName = txtfldFirstName.Text
        lastName = txtfldLastName.Text
        DOB = txtfldDOB.Text
        tel = txtfldTel.Text
        addrL1 = txtfldAddress1.Text
        addrL2 = txtfldAddress2.Text
        postCode = txtfldPostCode.Text
        email = txtfldEmail.Text
        LicenseNo = txtfldLicenseNo.Text

        customerID = LicenseNo

        'Validation for first name
        If firstName = "" Then
            valid_inputs = False
            fNameError.Text = "Invalid First Name"
        Else
            fNameError.Text = ""
        End If

        'Validation for last name
        If lastName = "" Then
            valid_inputs = False
            lNameError.Text = "Invalid Last Name"
        Else
            lNameError.Text = ""
        End If

        'Validation for telephone number
        If tel = "" Or tel.Length() <> 11 Or Not IsNumeric(tel) Then
            valid_inputs = False
            telError.Text = "Invalid Telephone Number"
        Else
            telError.Text = ""
        End If

        'Validation for address line 1
        If addrL1 = "" Then
            valid_inputs = False
            addrL1Error.Text = "Invalid Address Line 1"
        Else
            addrL1Error.Text = ""
        End If

        'Validation for address line2
        If addrL2 = "" Then
            valid_inputs = False
            addrL2Error.Text = "Invalid Address Line 2"
        Else
            addrL2Error.Text = ""
        End If

        'Validation for postcode
        If postCode = "" Or postCode.Length() > 10 Then
            valid_inputs = False
            postCodeError.Text = "Invalid Post Code"
        Else
            postCodeError.Text = ""
        End If


        'Valid character that can be in email are assigned to variable
        Dim validCharacters As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        'Validation for email
        If Regex.IsMatch(email, validCharacters) Then
            emailError.Text = ""
        Else
            valid_inputs = False
            emailError.Text = "Invalid Email"
        End If

        'Validation for license no
        If LicenseNo = "" Or LicenseNo.Length() <> 6 Or Not IsNumeric(LicenseNo) Then
            valid_inputs = False
            licenseNoError.Text = "Invalid License Number"
        Else
            licenseNoError.Text = ""
        End If

        'If all inputs are valid
        If valid_inputs = True Then

            'An attempt is made to add data to database
            Try

                'Data base provider and source is assigned
                connection.ConnectionString = dbProvider & dbSource

                'connection is opened
                connection.Open()

                'SQL query is assigned to variable
                query = "INSERT INTO Customer (CustomerID, firstName, lastName, DOB, tel, AddrLine1, AddrLine2, " _
                         & "PostCode, Email, LicenseNumber)" _
                         & "Values (@customerID, @firstName, @lastName, @DOB, @tel, @addrL1, @addrL2, @postCode, " _
                         & "@email, @licenseNo)"

                'Command variable is created to execute the query
                Dim command As New OleDbCommand(query, connection)

                'Place holders are replaced with actual inputs
                command.Parameters.AddWithValue("@customerID", customerID)
                command.Parameters.AddWithValue("@firstName", firstName)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@DOB", DOB)
                command.Parameters.AddWithValue("@tel", tel)
                command.Parameters.AddWithValue("@addrL1", addrL1)
                command.Parameters.AddWithValue("@addrL2", addrL2)
                command.Parameters.AddWithValue("@postCode", postCode)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@licenseNo", LicenseNo)

                'Query is executed
                command.ExecuteNonQuery()

                'Conenction is closed
                connection.Close()

                'Confirmation is shown to the user
                MsgBox("Customer Record has been added --> Customer ID: " & customerID & "")

                'Entries form the form are entered into array and written to external text file
                customerExport(0) = customerID
                customerExport(1) = txtfldFirstName.Text
                customerExport(2) = txtfldLastName.Text
                customerExport(3) = txtfldDOB.Text
                customerExport(4) = txtfldTel.Text
                customerExport(5) = txtfldAddress1.Text
                customerExport(6) = txtfldAddress2.Text
                customerExport(7) = txtfldPostCode.Text
                customerExport(8) = txtfldEmail.Text
                customerExport(9) = txtfldLicenseNo.Text

                IO.File.WriteAllLines(customerExportFileName, customerExport)

                ''Customer form is closed and rental form is opened
                Rental.Show()
                Me.Close()

                'All fields are reset
                txtfldCustomerID.Clear()
                txtfldFirstName.Clear()
                txtfldLastName.Clear()
                txtfldDOB.Value = New Date(1990, 1, 1)
                txtfldTel.Clear()
                txtfldAddress1.Clear()
                txtfldAddress2.Clear()
                txtfldPostCode.Clear()
                txtfldEmail.Clear()
                txtfldLicenseNo.Clear()

                'If error occurs when inserting data, it will be catched and displayed
            Catch ex As Exception

                'Connection is closed
                connection.Close()

                'Error message is displayed
                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub butClear_Click(sender As Object, e As EventArgs) Handles butClear.Click

        'All text fields are cleared and DOB field is reset
        txtfldCustomerID.Clear()
        txtfldFirstName.Clear()
        txtfldLastName.Clear()
        txtfldDOB.Value = New Date(1990, 1, 1)
        txtfldTel.Clear()
        txtfldAddress1.Clear()
        txtfldAddress2.Clear()
        txtfldPostCode.Clear()
        txtfldEmail.Clear()
        txtfldLicenseNo.Clear()

        'Error message labels are reset
        fNameError.Text = ""
        lNameError.Text = ""
        telError.Text = ""
        addrL1Error.Text = ""
        addrL2Error.Text = ""
        postCodeError.Text = ""
        emailError.Text = ""
        licenseNoError.Text = ""

        'Data set is cleared
        dataSet.Tables.Clear()

        IO.File.WriteAllText(customerExportFileName, "")

    End Sub

    'Close button
    Private Sub butClose_Click(sender As Object, e As EventArgs) Handles butClose.Click

        'External file is wiped
        IO.File.WriteAllText(customerExportFileName, "")

        'Application is exited
        Application.Exit()
    End Sub

End Class