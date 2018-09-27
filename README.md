# ASP.NET-Core-MVC-Localization-Test

This code illustrates the incorrect and correct approaches to setting the culture in an ASP.NET Core application:

'master' branch shows the incorrect way of setting the culture (too late in the MVC pipeline, affects only the controller code)
'alternate' branch shows the proper way early in the MV pipeline which sets the culture for all downstream code, including views 

See https://stackoverflow.com/questions/49382172/asp-net-mvc-async-currentculture-is-not-shared-between-controller-and-view
for an explanation of the differences.
