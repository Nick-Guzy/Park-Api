# Project Name
Park-Api
# Contributor name
Nicholas Guzy
# Description
This is an API 
# Link to website
https://github.com/Nick-Guzy/Park-Api.git
# Technologies used:
* C#
* .NET6
* MySQL
* EF Core
* Razor
* ASP
* Identity
* JWT bearer tokening 
# Setup steps
1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called "ParkAPI".
3. Create the file appsettings.json file in your project directory, configure it with the following code
    {
    "JwtSettings": {
      "securitykey": "thisisoursecurekey"
    },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[databasename];uid=[username];pwd=[password];"
  }
} 
and input the database name for [databasename], your username for [username], and password for [password]
4. Create the file appsettings.Development.json and configure it with the following code
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
5. Configure your ParkApiContext.cs with your data 
6. In the production directory run dotnet ef migrations add Initial
7. In the production directory run dotnet ef database update
8. In the production directory run dotnet watch run to use the application and get your token from swagger
9. Your API is ready to get, put, post, and delete data
10. These are the endpoints for your api calls: Replace {ID} with the ID of the data entry you want to call on with no {}. The endpoints are the same for State Park data, just replacing NationalPark with StatePark.
GET api/NationalPark
GET: api/NationalPark/{ID}
POST api/NationalPark
DELETE: api/NationalPark/{ID}
# Known bugs
None
# License information with copyright and date
Copyright <2023> <Nicholas Guzy>
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.