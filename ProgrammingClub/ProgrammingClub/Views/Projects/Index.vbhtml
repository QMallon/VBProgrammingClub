@ModelType IEnumerable(Of ProgrammingClub.Project)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_ProjectLayout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Category)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MainLanguage)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.GithubURl)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Category)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MainLanguage)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.GithubURl)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.projectID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.projectID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.projectID })
        </td>
    </tr>
Next

</table>
