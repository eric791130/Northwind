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

Partial Public Class Categories
    Public Property CategoryID As Integer
    Public Property CategoryName As String
    Public Property Description As String
    Public Property Picture As Byte()

    Public Overridable Property Products As ICollection(Of Products) = New HashSet(Of Products)

End Class
