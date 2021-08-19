# ASPNETWebAPINet5DemoService
Web API service app, with all 5 standard HTTP operations, REST, RESTful designs, Azure SQL

Service published on Azure at https://aspnetwebapinet5service.azurewebsites.net. Use Postman, or whatever else, to do manual requests.

Or use Swagger directly at https://aspnetwebapinet5service.azurewebsites.net/swagger/index.html



Hello there, and good day.

This is a decent example of an ASP.NET-built Web API, with all the standard HTTP operations on it. I will be hosting the whole thing on my Azure shortly, with Azure SQL database as well.

So this is an employee registry service app, where API's are exposed to allow to work with it - all the standard CRUD operations - Get, Put, Post, etc.

I will further add more to this in the coming days.

So this is standard ASP.NET setup, Startup class has all our basic configrations. MainController runs all the fun stuff. DTO's are setup, as per good practice, to hide source code. Entity Framework is used, with migrations setup. Azure SQL database is setup and running on my Azure account.

Quite a decent general template for most of the common REST setups, operations and coding. It has all the important pieces here.

GET is used for ALL request, as well as {id}, of course. PATCH is implemented, and as you know, is pretty complicated to set up. PATCH requires additional library, in order to work. And also requires a bit of setting up. POST is the usual create, and so on. I just couldn't think of any more operations I could implement, in addition to what's already here.

Absolutely love working in C# and .NET, and anything related to Microsoft and Azure.

Here is Swagger of it:
![alt text](https://github.com/VBukowsky81/ASPNETWebAPINet5DemoService/blob/master/Other/MyAPISwagger.jpg)

And GetAll response:
![alt text](https://github.com/VBukowsky81/ASPNETWebAPINet5DemoService/blob/master/Other/GetAll.jpg)

Thanks, good day

Vic
