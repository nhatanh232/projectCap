Imports System.Collections.Generic
Imports System.Linq

Public Class Order
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set
            m_Id = Value
        End Set
    End Property
    Private m_Id As Integer
    Public Property ProductName() As String
        Get
            Return m_ProductName
        End Get
        Set
            m_ProductName = Value
        End Set
    End Property
    Private m_ProductName As String
    Public Property Price() As Single
        Get
            Return m_Price
        End Get
        Set
            m_Price = Value
        End Set
    End Property
    Private m_Price As Single
    Public Property Discount() As Single
        Get
            Return m_Discount
        End Get
        Set
            m_Discount = Value
        End Set
    End Property
    Private m_Discount As Single
    Public Property OrderDate() As DateTime
        Get
            Return m_OrderDate
        End Get
        Set
            m_OrderDate = Value
        End Set
    End Property
    Private m_OrderDate As DateTime
    Public Property ShipCountry() As String
        Get
            Return m_ShipCountry
        End Get
        Set
            m_ShipCountry = Value
        End Set
    End Property
    Private m_ShipCountry As String
    Public Property ShippedDate() As DateTime
        Get
            Return m_ShippedDate
        End Get
        Set
            m_ShippedDate = Value
        End Set
    End Property
    Private m_ShippedDate As DateTime
    Public Shared ReadOnly Property All() As IQueryable(Of Order)
        Get
            Return _all.Value
        End Get
    End Property

    Private Shared _all As New Lazy(Of IQueryable(Of Order))(AddressOf GetData)
    Public Shared Function GetData() As IQueryable(Of Order)
        Dim productNames = New String() {"PlayStation 4", "XBOX ONE", "Wii U", "PlayStation Vita", "PlayStation 3", "XBOX 360",
            "PlayStation Portable", "3 DS", "Dream Cast", "Nintendo 64", "Wii", "PlayStation 2",
            "PlayStation 1", "XBOX"}
        Dim countries = New String() {"US", "Germany", "UK", "Japan", "Italy", "Greece"}
        Dim list = New List(Of Order)()
        Dim i As Integer = 0, length As Integer = 200000
        While i < length
            Dim orderDate = New DateTime(2017, New Random(i).[Next](1, 12), New Random(i).[Next](1, 28))
            list.Add(New Order() With {
                .Id = i,
                .ProductName = productNames(i Mod productNames.Length),
                .Price = New Random(i).[Next](0, 10000) / 100.0F,
                .Discount = New Random(i).[Next](0, 100) / 100.0F,
                .OrderDate = orderDate,
                .ShipCountry = countries(i Mod countries.Length),
                .ShippedDate = orderDate.AddDays(30)
            })
            i += 1
        End While

        Return list.AsQueryable()
    End Function
End Class