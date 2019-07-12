' Developer: Chilka Patel
' Date: July 12, 2019
' Description: This program will let the user select the car make and year from combo box and also enter model and price. It also gives user to select whether the car is new or not
'              and list all the items in listview.
'              --> This program has been created with taking help from CustomerList.vb.

Option Strict On

Public Class frmCarInventory

    Private carList As New SortedList                                 ' collection of all the carList in the list
    Private currentCarIdentificationNumber As String = String.Empty ' current selected car identification number
    Private editMode As Boolean = False

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As car
        Dim carItem As ListViewItem

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            ' 
            lblMsg.Text = "It worked!"
            ' if the current car identification number has a no value
            ' then this is not an existing item from the listview
            If currentCarIdentificationNumber.Trim.Length = 0 Then

                ' create a new car object using the parameterized constructor
                car = New car(cmbMake.Text, txtModel.Text, cmbYear.Text, txtPrice.Text, chkNew.Checked)

                ' add the car to the carList collection
                ' using the identoification number as the key
                carList.Add(car.IdentificationNumber.ToString(), car)

            Else
                ' if the current car identification number has a value
                ' then the user has selected something from the list view

                car = CType(carList.Item(currentCarIdentificationNumber), car)

                ' update the data in the specific object
                ' from the controls
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = cmbYear.Text
                car.Price = txtPrice.Text
                car.IsNew = chkNew.Checked
            End If

            ' clear the items from the listview control
            lvwCars.Items.Clear()

            ' loop through the carList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the car from the list
                car = CType(carEntry.Value, car)

                ' assign the values to the ckecked control
                ' and the subitems
                carItem.Checked = car.IsNew
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add(car.Price)

                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwCars.Items.Add(carItem)

            Next carEntry

            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    Private Sub Reset()

        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        lblMsg.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered appropriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty
        Dim price As Double = 0.0

        ' check if the make has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the model has been entered
        If txtModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the year has been selected
        If cmbYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the price has been entered
        If txtPrice.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

            ' Check if the price is not taking any alphabetics and taking real values
        ElseIf Not Double.TryParse(txtPrice.Text.Trim, price) Then
            outputMessage += "Please enter car price in real number." & vbCrLf

            returnValue = False

            'check if the price is less than zero
        ElseIf price < 0 Then
            outputMessage += "Car price must be greater than zero." & vbCrLf

        End If

            ' check to see if any value
            ' did not validate
            If returnValue = False Then

            ' show the message(s) to the user
            lblMsg.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        Return returnValue

    End Function

    ''' <summary>
    ''' Resetting all the controls value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub


    ''' <summary>
    ''' Exit the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' lvwCars_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCars_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the car identification number 
        Const identificationSubItemIndex As Integer = 1

        ' Get the car identification number 
        currentCarIdentificationNumber = lvwCars.Items(lvwCars.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Use the car identification number to get the car from the collection object
        Dim car As car = CType(carList.Item(currentCarIdentificationNumber), car)

        ' set the controls on the form
        txtModel.Text = car.Model               ' get the model and set the text box
        txtPrice.Text = car.Price                 ' get the price and set the text box
        cmbMake.Text = car.Make                     ' get the make and set the combo box
        cmbYear.Text = car.Year                         ' get the year and set the combo box
        chkNew.Checked = car.IsNew                          ' get the new and set the combo box

        lblMsg.Text = car.GetSalutation()


    End Sub

End Class
