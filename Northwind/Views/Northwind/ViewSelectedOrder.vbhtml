@ModelType Northwind.Orders

<div>
    <h4>Orders</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.OrderDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OrderDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RequiredDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RequiredDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShippedDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShippedDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Freight)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Freight)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShipName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShipName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShipAddress)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShipAddress)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShipCity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShipCity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShipRegion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShipRegion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShipPostalCode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShipPostalCode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ShipCountry)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ShipCountry)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Customers.CompanyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Customers.CompanyName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Employees.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Employees.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Shippers.CompanyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Shippers.CompanyName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.OrderID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
