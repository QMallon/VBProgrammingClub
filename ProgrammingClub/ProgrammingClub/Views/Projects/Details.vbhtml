@ModelType ProgrammingClub.Project
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_ProjectLayout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Project</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Category)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Category)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MainLanguage)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MainLanguage)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.GithubURl)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GithubURl)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.projectID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
