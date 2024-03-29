﻿Option Strict On
Public Class car

    Private Shared carCount As Integer
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String = String.Empty
    Private carPrice As String = String.Empty
    Private carIsNew As Boolean = False

    ''' <summary>
    ''' Constructor - Default - creates a new car object
    ''' </summary>
    Public Sub New()

        carCount += 1      ' increment the shared/static variable counter by 1
        carIdentificationNumber = carCount ' assign the cars id

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new car object
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="isNew"></param>
    Public Sub New(make As String, model As String, year As String, price As String, isNew As Boolean)

        ' call the other constructor 
        ' to set the car count and
        ' to set the car id
        Me.New()


        carMake = make          ' set the car make
        carModel = model        ' set the car model
        carYear = year          ' set the car year
        carPrice = price        ' set the car price
        carIsNew = isNew        ' set the car is new or not

    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of cars that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific cars identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' IsNew Property - >Gets and Sets the Is New of a car
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property IsNew() As Boolean
        Get
            Return carIsNew
        End Get
        Set(ByVal value As Boolean)
            carIsNew = value
        End Set
    End Property

    ''' <summary>
    ''' Make property - Gets and Sets the make of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Model property - Gets and Sets the model of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Year property - Gets and Sets the year of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Price property - Gets and Sets the price of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "Car make and model is " & carMake & carModel.ToString()
        Return "Car year and price is" & carYear & carPrice.ToString()
        Return "Car says, " & IIf(carIsNew = True, "I am New", "I am not New").ToString()

    End Function

End Class
