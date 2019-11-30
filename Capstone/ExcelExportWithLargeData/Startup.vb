Imports System.IO
Imports Microsoft.Owin
Imports Owin

<Assembly: OwinStartup(GetType(Startup))>
Public Class Startup
    Public Property Product() As Object
        Get
            Return m_Product
        End Get
        Private Set
            m_Product = Value
        End Set
    End Property
    Private m_Product As Object

    Public Sub Configuration(app As IAppBuilder)
        app.UseDataProviders().AddItemsSource("orders", Function() Order.All)
        app.UseStorageProviders().AddDiskStorage("files", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "files")))
    End Sub
End Class
