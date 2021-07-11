Imports System.Web.Mvc

Namespace Controllers
    Public Class NorthwindController
        Inherits Controller

        Dim db As dbnorthwndEntities = New dbnorthwndEntities

        ' GET: Northwind
        Function Index() As ActionResult
            Dim CustList As Entity.DbSet = db.Customers
            Return View(CustList)
        End Function

        Public Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Public Function Create(ByVal NewCust As Customers) As ActionResult
            db.Customers.Add(NewCust)
            db.SaveChanges()
            Return Index()
        End Function

    End Class
End Namespace