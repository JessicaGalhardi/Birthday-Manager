# 🎂 Birthday Manager

A simple and scalable Birthday Manager application built with **.NET**, designed to manage friends and their birthdays through a clean, layered architecture.

---

## 📌 Overview

Birthday Manager is a multi-layered application that allows users to store, manage, and retrieve information about friends and their birthdays. The project was developed with a focus on **separation of concerns**, **maintainability**, and **scalability**, following common enterprise patterns.

---

## 🏗️ Architecture

The solution is organized into multiple projects, each with a clear responsibility:

* **Friends.API**
  Exposes RESTful endpoints for managing friends and birthdays.

* **Friends.Web**
  Front-end layer (MVC/Razor) responsible for user interaction.

* **Friends.Service**
  Contains business logic and application rules.

* **Friends.Domain**
  Core domain models and entities.

---

## ⚙️ Technologies Used

* .NET (ASP.NET Core)
* C#
* Entity Framework (if applicable)
* SQL Server
* REST API
* MVC / Razor (Web layer)

---

## 🚀 Features

* Add, edit, and delete friends
* Store and manage birthdays
* Retrieve birthday lists
* Basic data organization and structure
* Layered architecture for easy extension

---

## ▶️ How to Run the Project

### Prerequisites

* .NET SDK installed
* SQL Server (or compatible database)

### Steps

1. Clone the repository:

```bash
git clone https://github.com/your-username/Birthday-Manager.git
```

2. Open the solution file:

```bash
Birthday-Manager.sln
```

3. Configure the database connection string in:

```
appsettings.json
```

4. Apply database setup (if needed):

* Run SQL scripts OR
* Execute migrations (if configured)

5. Run the project:

* Set `Friends.API` or `Friends.Web` as the startup project
* Press `F5` or run via CLI:

```bash
dotnet run
```

---

## 📁 Project Structure

```
Birthday-Manager
│
├── Friends.API        # API layer (controllers/endpoints)
├── Friends.Web        # Front-end (UI)
├── Friends.Service    # Business logic
├── Friends.Domain     # Core entities/models
└── SQLQuery1.sql      # Database script (initial setup)
```

---

## 🧠 Design Decisions

* **Layered Architecture**
  Keeps responsibilities separated and improves maintainability.

* **Service Layer**
  Centralizes business logic instead of placing it in controllers.

* **Domain Layer Isolation**
  Makes the core models reusable and independent from infrastructure.

---

## 🔧 Possible Improvements

This project can be extended with:

* Unit and integration tests
* Authentication and authorization
* Birthday notifications/reminders
* Filtering (e.g., upcoming birthdays)
* Improved UI/UX
* Use of DTOs and AutoMapper
* Full database migration setup

---

## 📄 License

This project is for study and portfolio purposes.

---

## 👩‍💻 Author

Developed by **Jessica Galhardi**
Feel free to connect or explore more projects on GitHub.

---

