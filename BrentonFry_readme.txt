Working on the API for Paypal, the examples I have been using uses .aspx files which is not supported in the current project format. As time is finite, it was decided to scrap the API code, and have simple link to a user's paypal.

This link could easily be managed/updated, so any payment service could be used (Paypal, Google Pay, Venmo, etc.,). This allows the client to easily incorporate a simple payment method as needed. 

Working on the pages for a user to register, I ran into problems with my migration and database update failing. No context was provided in the error other than "Build Failed." I have noticed that VS 2019 is no longer supported, and I have error/warning message stating the following:

Error	NU1202	Package Microsoft.VisualStudio.Web.CodeGeneration.Design 5.0.2 is not compatible with netcoreapp3.0 (.NETCoreApp,Version=v3.0). Package Microsoft.VisualStudio.Web.CodeGeneration.Design 5.0.2 supports: net5.0 (.NETCoreApp,Version=v5.0)

Lastly, meeting with the team, some of our code conflicts. I will be attempting to see what is the same or different, and try to combine the code as necessary. With all of the problems I have faced with in Sprint 2, I feel like I haven't provided any true deliverables which is frustrating to me. 