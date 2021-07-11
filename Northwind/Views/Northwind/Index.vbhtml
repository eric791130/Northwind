@ModelType IEnumerable(Of Northwind.Customers)

<p>
    @Html.ActionLink("新增客戶資料", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CompanyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContactName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContactTitle)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.City)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Region)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PostalCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Country)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Phone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Fax)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CompanyName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContactName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContactTitle)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Address)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.City)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Region)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PostalCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Country)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Phone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Fax)
        </td>
        <td>
            @Html.ActionLink("編輯", "Edit", New With {.id = item.CustomerID}) |
            @Html.ActionLink("詳細資料", "Details", New With {.id = item.CustomerID}) |
            @Html.ActionLink("刪除", "Delete", New With {.id = item.CustomerID})
        </td>
    </tr>
Next

</table>
