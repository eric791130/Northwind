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
            Return View(Cust)
        End Function

        Public Function Delete(ByVal id As String) As ActionResult
            Dim Cust As Customers = db.Customers.Where(Function(x) x.CustomerID = id).FirstOrDefault
            db.Customers.Remove(Cust)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function
    End Class

End Namespace