# _AnimalShelterAPI_

#### By _**Jeff Lai**_

#### _This application demonstrates basic use of API building._

## Technologies Used

* _C#_
* _.NET_
* _ASP .NET Core_
* _Entity Framework_
* _MySQL_
* _Swashbuckle_

## Setup/Installation Requirements

* _C#/.NET_
* _MySQL_
* _Entity Framework_

* _Clone repository or download zip file from "https://github.com/popoyuyu/AnimalShelterAPI.Solution.git"_
* _Navigate to AnimalShelterAPI directory and run "dotnet restore" in your terminal_
* _Create file name 'appsettings.json' and input code into file: "{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=AnimalShelterAPI;uid=[user mysql username];pwd=[user mysql password];" } }"_
  * _Replace [] with your own information_
* _run "dotnet ef migrations add Initial" and "dotnet ef database update" to create database for project_
* _Watch live changes with program run "dotnet watch run" in "http://localhost:5000/"_
* _To see list of animals in database follow the swagger documentation with "http://localhost:5000/api/animals"_



## Known Bugs

* _Any known issues_
* _should go here_

## License

_Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE._


Copyright (c) _January 21 2022_ _Jeff Lai_