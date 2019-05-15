Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.AspNetCore.Http
Imports Microsoft.Extensions.DependencyInjection
Public Class Startup
    Public Sub ConfigureServices(ByVal services As IServiceCollection)
    End Sub

    Public Sub Configure(ByVal app As IApplicationBuilder, ByVal env As IHostingEnvironment)
        If env.IsDevelopment() Then
            app.UseDeveloperExceptionPage()
        End If

        app.Run(Async Function(context)
                    Await context.Response.WriteAsync("Hello World!")
                End Function)
    End Sub
End Class
