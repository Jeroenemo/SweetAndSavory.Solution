# Pierre's Sweet and Savory Treats!

#### A Simple Database Application

#### By Jeroen van Seeters

## Technologies Used

* C#
* .Net 5.0
* Asp.Net Core
* Razor
* Entity Core
* Identity
* MySql
* REPL
* Git and GitHub

## Description

This is a basic application designed to display my grasp on databases and user authentication, using a many to many relationship. In this application, the user can View, create, update and delete both flavors and treats, utilizing full CRUD methodology for both. Furthermore, the user can associate flavors with treats, and vice versa. Anyone can view the items in the database, but only a signed in user is able to create, edit and delete flavors and treats! This application was created with the guidance of **EPICODUS**, the greatest coding bootcamp in the known universe, and google.

## Setup/Installation Requirements

**Set up the Application:**
* You need to have .net 5.0 installed on your machine in order to run this program. You can find the download [here](https://dotnet.microsoft.com/download/dotnet/5.0)
* Clone the repository from GitHub using `git clone https://github.com/Jeroenemo/SweetAndSavory.Solution.git`
* Navigate to the downloaded folder using the cd command
* Navigate down one level into the SweetAndSavory directory. `cd SweetAndSavory`
* Create an appsettings.json file in the SweetAndSavory directory. `touch appsettings.json`
* Add the following code to your appsettings.json file
* ```
    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
        }
    }
* Please note that the variables in brackets need to be replaced with your own database name and password.
* Run a restore and build command. `dotnet restore` and `dotnet build`

**Set up the Database:**

* You need to have MySqlWorkbench installed on your machine. You can download it [here](https://www.mysql.com/products/workbench/)
* In the navigator > Administration window, select Data Import/Restore
* In Import Options select Import from Self-Contained File.
* Navigate to jeroen_van_seeters.sql in the SweetAndSavory.Solutions directory
* Under Default Schema to be Imported To, select the New button.
* Enter the name of your database
* Click ok
* Click Start Import
* Reopen the Navigator > Schemas tab. Right click and select Refresh All. 

*Alternatively, install the enitity framework migrations tool by running the following comand `dotnet tool install --global dotnet-ef`
*In SweetAndSavory.Solution > SweetAndSavory, run `dotnet ef database update`
*Voila! 

**Run the Application**
* Back in your terminal, in the SweetAndSavory.Solution > SweetAndSavory directory, type `dotnet run`
* Open your browser and visit http://localhost:5000

## Future Enhancements

* Include form for search functionality
* Add order form
* Add seperate log in roles
* Continue Styling


## License

MIT

Copyright (c) 2021 Jeroen van Seeters

## Contact Information

Jeroen van Seeters vanseetersjeroen@gmail.com
