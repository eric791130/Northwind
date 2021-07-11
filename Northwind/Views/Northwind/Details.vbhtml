@ModelType Northwind.Customers

<div>
    <h4>Customers</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CompanyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CompanyName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContactName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContactName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ContactTitle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ContactTitle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Address)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.City)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.City)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Region)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Region)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PostalCode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PostalCode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Country)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Country)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Phone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Phone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Fax)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fax)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.CustomerID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
