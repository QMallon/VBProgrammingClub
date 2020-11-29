@ModelType ProgrammingClub.Project
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_ProjectLayout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
