'------------------------------------------------------------------------------
' <auto-generated>
'     這個程式碼是由範本產生。
'
'     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
'     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Products
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property SupplierID As Nullable(Of Integer)
    Public Property CategoryID As Nullable(Of Integer)
    Public Property QuantityPerUnit As String
    Public Property UnitPrice As Nullable(Of Decimal)
    Public Property UnitsInStock As Nullable(Of Short)
    Public Property UnitsOnOrder As Nullable(Of Short)
    Public Property ReorderLevel As Nullable(Of Short)
    Public Property Discontinued As Boolean

    Public Overridable Property Categories As Categories
    Public Overridable Property Order_Details As ICollection(Of Order_Details) = New HashSet(Of Order_Details)
    Public Overridable Property Suppliers As Suppliers

End Class
