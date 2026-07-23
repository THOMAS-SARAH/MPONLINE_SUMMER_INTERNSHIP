# Student Registration Web Application

## 📌 Project Overview

The **Student Registration Web Application** is a web-based application developed using **ASP.NET Core MVC** that simplifies the process of managing students, courses, and course registrations. The application provides secure authentication and authorization using **ASP.NET Core Identity**, allowing only authenticated users to access the system while restricting administrative functionalities to authorized users.

The project follows the **Model-View-Controller (MVC)** architecture, ensuring a clear separation of concerns between data, business logic, and presentation. Entity Framework Core is used as the Object Relational Mapper (ORM) to interact with the SQL Server database.

---

# Objectives

* Develop a secure web application for student registration.
* Implement authentication and authorization using ASP.NET Core Identity.
* Manage course information efficiently.
* Maintain student profiles.
* Register students for available courses.
* Apply role-based access control for administrators and students.
* Demonstrate CRUD operations using Entity Framework Core.

---

# Features

### Authentication

* User Registration
* User Login
* User Logout
* Identity Authentication
* Password Hashing

### Authorization

* Role-Based Authorization
* Administrator Access
* Student Access
* Protected Pages using `[Authorize]`

### Course Management

* View Courses
* Add New Courses
* Edit Course Details
* Delete Courses

### Student Profile Management

* Create Student Profile
* View Student Profiles
* Update Student Information
* Delete Student Profiles

### Course Registration

* Register Students for Courses
* View Registered Courses
* Store Registration Date

### User Interface

* Responsive Navigation Bar
* Bootstrap UI
* Home Dashboard
* Validation Messages

---

# Technology Stack

| Technology            | Purpose                        |
| --------------------- | ------------------------------ |
| ASP.NET Core MVC      | Web Framework                  |
| C#                    | Backend Programming            |
| Entity Framework Core | ORM                            |
| SQL Server / LocalDB  | Database                       |
| ASP.NET Core Identity | Authentication & Authorization |
| Bootstrap             | Responsive UI                  |
| Razor Views           | Frontend                       |
| Visual Studio 2026    | IDE                            |
| .NET 8                | Framework                      |

---

# Project Architecture

```
StudentRegistrationWebApp
│
├── Controllers
│   ├── HomeController
│   ├── CoursesController
│   ├── StudentProfilesController
│   ├── CourseRegistrationsController
│
├── Models
│   ├── Course
│   ├── StudentProfile
│   ├── CourseRegistration
│
├── Data
│   └── ApplicationDbContext
│
├── Views
│   ├── Home
│   ├── Courses
│   ├── StudentProfiles
│   ├── CourseRegistrations
│   ├── Shared
│
├── wwwroot
│
├── Areas
│   └── Identity
│
├── appsettings.json
│
└── Program.cs
```

---

# Database Design

## Course Table

| Column     | Type     |
| ---------- | -------- |
| Id         | int      |
| CourseName | nvarchar |
| CourseCode | nvarchar |
| Credits    | int      |

---

## StudentProfile Table

| Column   | Type     |
| -------- | -------- |
| Id       | int      |
| UserId   | nvarchar |
| FullName | nvarchar |
| Address  | nvarchar |
| Phone    | nvarchar |

---

## CourseRegistration Table

| Column           | Type     |
| ---------------- | -------- |
| Id               | int      |
| StudentProfileId | int      |
| CourseId         | int      |
| RegistrationDate | datetime |

---

# Authentication Flow

```
User

↓

Register

↓

Identity Creates User

↓

Login

↓

Authentication Cookie Created

↓

Authorized User

↓

Access Protected Pages
```

---

# Authorization Flow

```
User Login

↓

Check Authentication

↓

Check User Role

↓

Administrator
        ↓
 Manage Courses

Student
        ↓
 View/Register Courses
```

---

# Entity Relationship

```
StudentProfile
      │
      │
      │ 1
      │
      ▼
CourseRegistration
      ▲
      │
      │ Many
      │
Course
```

---

# CRUD Operations

### Courses

* Create Course
* View Courses
* Update Course
* Delete Course

### Student Profiles

* Create Profile
* View Profile
* Edit Profile
* Delete Profile

### Course Registration

* Register Student
* View Registrations

---

# Validation

The application validates:

* Required Fields
* Empty Input
* Course Selection
* Student Selection
* Login Credentials
* Password Requirements

---

# Security Features

* ASP.NET Core Identity
* Password Hashing
* Cookie Authentication
* Authorization Attributes
* Role-Based Security
* Anti-Forgery Token Protection

---

# Installation Steps

### Clone Repository

```bash
git clone https://github.com/yourusername/StudentRegistrationWebApp.git
```

---

### Navigate to Project

```bash
cd StudentRegistrationWebApp
```

---

### Restore Packages

```bash
dotnet restore
```

---

### Apply Migration

```bash
Add-Migration InitialCreate
```

---

### Update Database

```bash
Update-Database
```

---

### Run Project

```bash
dotnet run
```

---

# Future Enhancements

* Student Dashboard
* Faculty Dashboard
* Course Search
* Email Notifications
* Attendance Management
* Grade Management
* Student Reports
* Export to PDF
* Export to Excel
* Responsive Dashboard
* API Integration
* Cloud Deployment

---

# Learning Outcomes

Through this project, the following concepts were learned:

* ASP.NET Core MVC Architecture
* Entity Framework Core
* ASP.NET Core Identity
* Authentication
* Authorization
* CRUD Operations
* SQL Server Integration
* Dependency Injection
* Razor Views
* Bootstrap UI Development
* MVC Routing
* Model Validation

---
# Conclusion

The **Student Registration Web Application** successfully demonstrates the implementation of a secure, role-based student management system using **ASP.NET Core MVC**, **Entity Framework Core**, and **ASP.NET Core Identity**. The project provides a structured solution for managing courses, student profiles, and course registrations while following MVC architecture and industry best practices. It showcases authentication, authorization, CRUD operations, database integration, and responsive user interface design, making it a strong foundation for scalable educational management systems and future enhancements.

