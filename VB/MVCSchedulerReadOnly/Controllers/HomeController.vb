Imports System.Web.Mvc
Imports MVCSchedulerReadOnly.Models

Namespace MVCSchedulerReadOnly.Views

    Public Class HomeController
        Inherits Controller

        '
        ' GET: /Home/
'#Region "#commonactions"
        Public Function Index() As ActionResult
            Return View(SchedulerDataHelper.DataObject)
        End Function

        Public Function SchedulerPartial() As ActionResult
            Return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject)
        End Function
'#End Region  ' #commonactions
    End Class
End Namespace
