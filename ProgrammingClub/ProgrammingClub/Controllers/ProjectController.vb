Imports System.Web.Mvc

Namespace Controllers
    Public Class ProjectController
        Inherits Controller

        ' GET: Project
        Function Index() As String
            Return "THIS IS A STRING"
        End Function
        Function Home() As ActionResult
            Return View()
        End Function
        Function ViewProjects() As ActionResult


            Return View()
        End Function
    End Class
End Namespace