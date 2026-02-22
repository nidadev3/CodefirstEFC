Student CRUD Application  ASP.NET Core & Entity Framework Core (Code First)
📌 Project Overview
I am currently learning ASP.NET Core and Entity Framework Core, and this project was developed as a hands-on implementation of the concepts I am studying.
This application is part of my learning journey where I apply theoretical concepts by building practical projects. The project demonstrates how to develop a web application using the **MVC architecture** and manage database operations using the Code First approach in Entity Framework Core.
The goal of this project is to strengthen my backend development skills by implementing a complete CRUD system connected to a SQL Server database.

🚀 Features
✅ Create new student records
✅ View all students data
✅ Update student information
✅ Delete student records
✅ Database creation using Code First migrations
✅ Structured MVC-based application

---
🛠️ Technologies Used
C#
ASP.NET Core MVC
.NET
Entity Framework Core (Code First)
SQL Server
HTML, CSS, Bootstrap
Visual Studio

---

🧱 Project Architecture
The application follows the **Model–View–Controller (MVC)** pattern:
Models → Student entity and DbContext
Views → User interface for CRUD operations
Controllers → Application logic and request handling

---

🗄️ Database Information
Database Name: `CodeFirstDB`
The database and table are automatically generated using Entity Framework Core migrations.
Students Table Structure

| Column Name   | Description                        |
| ------------- | ---------------------------------- |
| StudentId     | Unique identifier for each student |
| StudentName   | Name of the student                |
| StudentAge    | Age of the student                 |
| StudentGender | Gender of the student              |

---
⚙️ Setup Instructions
 1️⃣ Clone the Repository
```bash
git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
```
2️⃣ Open the Project
Open the solution (`.sln`) file using Visual Studio.
3️⃣ Configure Connection String
Update `appsettings.json`:
```json
"ConnectionStrings": {
  "dbcs": "Server=localhost;Database=CodeFirstDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
4️⃣ Apply Database Migration
Open Package Manager Console and run:
```powershell
Update-Database
```
This command will create the database and Students table automatically.
5️⃣ Run the Application
Press:
```
Ctrl + F5
```
or run the project from Visual Studio.

---
🎯 Learning Objectives
Through this project, I practiced and learned:
* ASP.NET Core MVC workflow
* Entity Framework Core Code First approach
* Database migrations
* CRUD operations implementation
* SQL Server integration with .NET applications
---
👩‍💻 Author
Nida Arshad
Computer Science Student | Learning ASP.NET Core & Backend Development
---
🌱 Learning Journey

This repository is part of my continuous learning journey in backend and web development, where I build practical applications to strengthen my programming and software development skills.

---
⭐ Future Improvements
* Search and filtering functionality
* Pagination support
* Authentication & authorization
* REST API development
* UI enhancements

---
📄 License

This project is created for educational and learning purposes.
