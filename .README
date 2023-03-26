# _Factory Database_

#### By _**Brian Yoder**_

#### _An MVC that allows a user to set up many-to-many relationships between engineer and machine objects._

## Technologies Used

* MacBook Pro (13-inch, M1, 2020), macOS Ventura v. 13.0.1
* VSCode v. 1.76.1
* C#
* ASP.NET Core
* Razor Markup
* Entity Framework Core


## Setup / Installation Requirements / Configuration

* Open Terminal/Command line
* Navigate to the desktop by typing **cd ~/Desktop** and press Enter on the keybord
* type **git clone https://github.com/brianwilliamyoder/Factory** into the terminal and press Enter on the keyboard
* Navigate to the desktop and click on the "Factory.Solution" folder.
* Open the folder in VS Code


## Adding Packages

* In the terminal, navigate to "Factory" folder by using the following command: $ cd Factory
* Next, we'll add 2 essential packages using the following commands
  - $ dotnet add package Microsoft.EntityFramework -v 6.0.0
* Once the above has installed, enter this one next:
  - $ dotnet add package Pomelo.EntityFramework -v 6.0.0
* That's it for this part!

## Setting up appsettings.json
* In the terminal navigate to the project directory "Factory".
* Next, will add the file. In the terminal, enter the following:
  - $ touch appsettings.json
* Open the file in the code editor, and enter the following:
  ```json
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE NAME];uid=[YOUR USER ID];pwd=[YOUR PASSWORD];"
    }
  } 
  ```
* Save! Done!

## Creating the database

* Install the following in the terminal:

```
  $ dotnet tool install --global dotnet-ef --version 6.0.0
```
```
  $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```
``` 
  $ dotnet ef migrations add Initial
```
```
$ dotnet ef database update
```
* The database has been migarated and the program is now functional. 



## Running the program
* In the terminal, navigate to the Factory folder
* Next, type this in the terminal:
  - $ dotnet run
* The program is ready to run on localhost. 

## Known Bugs

* None

## [License](https://mit-license.org/)

_If there are any issues found with the site, feel free to contact me at_ [brianyoder@gmail.com](brianyoder@gmail.com)

Copyright (c) _2023_ _Brian Yoder_