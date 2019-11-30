Imports C1.Web.Mvc
Imports C1.Web.Mvc.Serialization

Public Class HomeController
    Inherits Controller

    Public Function Index() As ActionResult
        Return View(Order.All)
    End Function

    Public Function OrdersData(<C1JsonRequest> request As CollectionViewRequest(Of Order)) As ActionResult
        Return Me.C1Json(CollectionViewHelper.Read(request, Order.All))
    End Function
End Class
