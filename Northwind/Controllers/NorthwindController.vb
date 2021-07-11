Imports System.Web.Mvc

Namespace Controllers
    Public Class NorthwindController
        Inherits Controller

        Dim db As dbnorthwndEntities = New dbnorthwndEntities

        ' GET: Northwind
        Function Index() As ActionResult
            Dim CustList As List(Of Customers) = db.Customers.OrderBy(Function(x) x.CustomerID).ToList
            Return View(CustList)
        End Function

        Public Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Public Function Create(ByVal NewCust As Customers) As ActionResult
            db.Customers.Add(NewCust)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Public Function Edit(ByVal id As String) As ActionResult
            Dim Cust As Customers = db.Customers.Where(Function(x) x.CustomerID = id).FirstOrDefault
            Return View(Cust)
        End Function

        <HttpPost>
        Public Function Edit(ByVal TargetCust As Customers) As ActionResult

            Dim CustID As String = TargetCust.CustomerID
            Dim Cust As Customers = db.Customers.Where(Function(x) x.CustomerID = CustID).FirstOrDefault
            With Cust
                .Address = TargetCust.Address
                .City = TargetCust.City
                .CompanyName = TargetCust.CompanyName
                .ContactName = TargetCust.ContactName
                .ContactTitle = TargetCust.ContactTitle
                .Country = TargetCust.Country
                .Phone = TargetCust.Phone
                .PostalCode = TargetCust.PostalCode
                .Region = TargetCust.Region
            End With
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Public Function Details(ByVal id As String) As ActionResult
            Dim Cust As Customers = db.Customers.Where(Function(x) x.CustomerID = id).FirstOrDefault
            Dim Order As Orders = db.Orders.Where(Function(x) x.CustomerID = id).FirstOrDefault
            Return View(Cust)
        End Function

        Public Function Delete(ByVal id As String) As ActionResult
            Dim Cust As Customers = db.Customers.Where(Function(x) x.CustomerID = id).FirstOrDefault
            Dim Order As Orders = db.Orders.Where(Function(x) x.CustomerID = id).FirstOrDefault
            db.Customers.Remove(Cust)
            db.Orders.Remove(Order)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        <HttpPost>
        Public Function DeleteSelected(ByVal id() As String) As ActionResult
            If id Is Nothing Then Return RedirectToAction("Index")
            If id.Length = 0 Then
                Return RedirectToAction("Index")
            End If

            For i As Integer = 0 To id.Length - 1
                Dim Cust As Customers = db.Customers.Where(Function(x) x.CustomerID = id(i)).FirstOrDefault
                db.Customers.Remove(Cust)
                db.SaveChanges()
            Next
            Return RedirectToAction("Index")
        End Function

        Public Function ListOrder() As ActionResult
            Dim OrderList As List(Of Orders) = db.Orders.OrderBy(Function(x) x.OrderID).ToList
            Return View(OrderList)
        End Function

        Public Function ViewSelectedOrder(ByVal id As String) As ActionResult
            Dim Order As Orders = db.Orders.Where(Function(x) x.CustomerID = id).FirstOrDefault
            Return View(Order)
        End Function

        Public Function EditSelectedOrder(ByVal id As String) As ActionResult
            Dim Order As Orders = db.Orders.Where(Function(x) x.CustomerID = id).FirstOrDefault
            Return View(Order)
        End Function

        <HttpPost>
        Public Function EditSelectedOrder(ByVal TargetOrder As Orders) As ActionResult

            Dim OrderID As String = TargetOrder.OrderID
            Dim Order As Orders = db.Orders.Where(Function(x) x.OrderID = OrderID).FirstOrDefault
            With Order
                .EmployeeID = TargetOrder.EmployeeID
                .Freight = TargetOrder.Freight
                .OrderDate = TargetOrder.OrderDate
                .RequiredDate = TargetOrder.RequiredDate
                .ShipAddress = TargetOrder.ShipAddress
                .ShipCity = TargetOrder.ShipCity
                .ShipCountry = TargetOrder.ShipCountry
                .ShipName = TargetOrder.ShipName
                .ShippedDate = TargetOrder.ShippedDate
                .Shippers = TargetOrder.Shippers
                .ShipPostalCode = TargetOrder.ShipPostalCode
                .ShipRegion = TargetOrder.ShipRegion
                .ShipVia = TargetOrder.ShipVia
            End With
            db.SaveChanges()
            Return RedirectToAction("ViewSelectedOrder")
        End Function

    End Class

End Namespace