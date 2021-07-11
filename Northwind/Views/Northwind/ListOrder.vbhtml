@ModelType IEnumerable(Of Northwind.Orders)

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.OrderDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RequiredDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShippedDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Freight)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShipName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShipAddress)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShipCity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShipRegion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShipPostalCode)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShipCountry)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Customers.CompanyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Employees.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Shippers.CompanyName)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.OrderDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RequiredDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShippedDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Freight)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShipName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShipAddress)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShipCity)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShipRegion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShipPostalCode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShipCountry)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Customers.CompanyName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Employees.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Shippers.CompanyName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.OrderID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.OrderID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.OrderID })
        </td>
    </tr>
Next

</table>
