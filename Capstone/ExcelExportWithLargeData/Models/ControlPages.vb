Public NotInheritable Class ControlPages
    Private Sub New()
    End Sub
    Public Shared Function GetPageSources() As IDictionary(Of String, String)
        Dim pageSources = New Dictionary(Of String, String)()
        Dim controllerName = "Home"
        Dim actionName = "Index"
        Dim controllerFileName = controllerName + "Controller.vb"
        Dim controllerFilePath = HttpContext.Current.Server.MapPath(String.Format("~/Controllers/{0}", controllerFileName))
        Dim controllerFileHtml = GetFileAsHtmlContent(controllerFilePath)
        pageSources.Add(controllerFileName, controllerFileHtml)

        Dim viewFileName = actionName + ".vbhtml"
        Dim viewFilePath = HttpContext.Current.Server.MapPath(String.Format("~/Views/{0}/{1}", controllerName, viewFileName))
        Dim viewFileHtml = GetFileAsHtmlContent(viewFilePath)
        pageSources.Add(viewFileName, viewFileHtml)

        Dim startup = "Startup.vb"
        Dim startupFilePath = HttpContext.Current.Server.MapPath(String.Format("~/{0}", startup))
        pageSources.Add(startup, GetFileAsHtmlContent(startupFilePath))

        Return pageSources
    End Function

    Private Shared Function GetFileAsHtmlContent(controllerFilePath As String) As String
        Return System.IO.File.ReadAllText(controllerFilePath)
    End Function
End Class