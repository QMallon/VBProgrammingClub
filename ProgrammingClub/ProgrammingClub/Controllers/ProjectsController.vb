Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ProgrammingClub

Namespace Controllers
    Public Class ProjectsController
        Inherits System.Web.Mvc.Controller

        Private db As New programmingclubEntities

        ' GET: Projects
        Function Index() As ActionResult
            Return View(db.Projects.ToList())
        End Function

        ' GET: Projects/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim project As Project = db.Projects.Find(id)
            If IsNothing(project) Then
                Return HttpNotFound()
            End If
            Return View(project)
        End Function

        ' GET: Projects/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Projects/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="projectID,Description,Category,MainLanguage,GithubURl")> ByVal project As Project) As ActionResult
            If ModelState.IsValid Then
                db.Projects.Add(project)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(project)
        End Function

        ' GET: Projects/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim project As Project = db.Projects.Find(id)
            If IsNothing(project) Then
                Return HttpNotFound()
            End If
            Return View(project)
        End Function

        ' POST: Projects/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="projectID,Description,Category,MainLanguage,GithubURl")> ByVal project As Project) As ActionResult
            If ModelState.IsValid Then
                db.Entry(project).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(project)
        End Function

        ' GET: Projects/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim project As Project = db.Projects.Find(id)
            If IsNothing(project) Then
                Return HttpNotFound()
            End If
            Return View(project)
        End Function

        ' POST: Projects/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim project As Project = db.Projects.Find(id)
            db.Projects.Remove(project)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
