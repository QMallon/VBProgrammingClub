@Code
    Layout = "~/Views/Shared/_ProjectLayout.vbhtml"
    ViewData("Title") = "Projects Home"
End Code
<div class="row">
    <div class="col-lg-12 glyphicon-align-left">
        <h2>@ViewData("Title")</h2>
        <h3>This is the home page for projects search or view projects here</h3>
    </div>
</div>
<div class="container">
    <div class="row m-t-50">
        <h1 class="text-center">Search For Projects</h1>
        <div class="col-xs-12 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3 col-lg-6 col-lg-offset-3">
            <form class="form-inline">
                <div class="form-group">
                    <div class="input-group">
                        <input class="form-control" type="text" name="search" placeholder="Search..." required />
                        <span class="input-group-btn">
                            <button class="btn btn-success" type="submit"><span class="glyphicon glyphicon-search" aria-hidden="true"></span>Search</button>
                        </span>
                    </div>
                </div>
            </form>
        </div>
    </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h3>Discover Projects</h3>
            <br />
            <p>Look at what some members are working on right now</p>
        </div>
        <div class="col-md-4">
            <h3>Join Projects</h3>
            <br />
            <p>Contribute to projects</p>
        </div>
        <div class="col-md-4">
            <h3>Create Projects</h3>
            <br />
            <p>Add your current project to get help or collaborate</p>
        </div>
    </div>
