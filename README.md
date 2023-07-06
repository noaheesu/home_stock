# Home Stock Project

The Home Stock project is a web application built using C# MVC and JavaScript. It allows users to manage and track their home inventory for various categories, including bathroom supplies, laundry supplies, kitchen supplies, living room supplies, and pet supplies. The project provides CRUD (Create, Read, Update, Delete) functionality for each category.

## Purpose

The purpose of this project is to provide a convenient solution for managing and organizing home supplies inventory. With the Home Stock application, users can easily add, view, edit, and delete items in different supply categories. This helps users keep track of their stock, monitor expiration dates, and make informed decisions when shopping for supplies.

## Tools and Technologies Used

- **C# MVC**: The project is built using the C# programming language and the Model-View-Controller (MVC) architectural pattern. MVC provides a structured approach to developing web applications, separating concerns and promoting code reusability.
- **JavaScript**: JavaScript is used to enhance the interactivity and functionality of the application on the client-side. It allows dynamic manipulation of the DOM and provides event handling for user interactions.
- **Microsoft.AspNetCore.Authorization**: This library is used for authorization purposes. It provides functionality to secure specific routes or actions within the application.
- **HTML and CSS**: HTML is used for structuring the web pages, while CSS is used for styling and layout.
- **Entity Framework**: Entity Framework is used as an Object-Relational Mapping (ORM) tool to interact with the database and perform CRUD operations.
- **Microsoft SQL Server**: Microsoft SQL Server is used as the database management system to store and retrieve data related to the home inventory.

## Project Structure

The project consists of the following files and directories:

- `Controllers/HomeController.cs`: Contains the C# code for handling HTTP requests and managing the application logic.
- `Views/Home/*.cshtml`: Contains the Razor views for each supply category, including bathroom, kitchen, laundry room, living room, and pet.
- `wwwroot/js/site.js`: Contains the JavaScript code that handles dynamic interactions and event handling on the client-side.
- `wwwroot/css/site.css`: Contains the CSS styles for the application's visual appearance.

## Installation and Setup

To run the Home Stock project locally, follow these steps:

1. Clone the repository: `git clone https://github.com/your-username/home-stock-project.git`
2. Open the project in your preferred development environment (Visual Studio, Visual Studio Code, etc.).
3. Restore NuGet packages and dependencies.
4. Ensure that you have a Microsoft SQL Server instance running.
5. Update the database connection string in the `appsettings.json` file.
6. Run the database migrations to create the necessary tables.
7. Build and run the project.

## Usage

Once the project is running, you can access the different supply categories through the navigation menu. Each category provides options to view, add, edit, and delete items. The user interface allows you to enter details such as the item name, quantity, expiration date, and edit date.

## Contributing

Contributions to the Home Stock project are welcome! If you have any suggestions, bug fixes, or feature enhancements, please open an issue or submit a pull request.
