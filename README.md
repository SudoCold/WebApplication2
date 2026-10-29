# Student CRUD Web API

A simple Student Management REST API built with **C#, ASP.NET Core 10 Web API, Entity Framework Core, and SQLite**.

## Project Structure

```text
WebApplication1/
│
├── Controllers/
│   └── StudentsController.cs
│
├── Data/
│   └── StudentContext.cs
│
├── Models/
│   └── Student.cs
│
├── Properties/
│   └── launchSettings.json
│
├── bin/
├── obj/
│
├── students.db
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── WebApplication1.csproj
├── WebApplication1.http
└── README.md
```

## Folder and File Descriptions

| File / Folder | Description |
|---|---|
| `Controllers/` | Handles HTTP requests and API endpoints. |
| `StudentsController.cs` | Implements Create, Read, Update, and Delete operations for students. |
| `Data/` | Contains the database context. |
| `StudentContext.cs` | Connects the application to SQLite using Entity Framework Core. |
| `Models/` | Contains the application's data models. |
| `Student.cs` | Defines student properties such as ID, name, age, and course. |
| `Properties/` | Contains development and launch configuration. |
| `launchSettings.json` | Configures local development URLs and launch profiles. |
| `bin/` | Contains compiled application output. |
| `obj/` | Contains intermediate build files. |
| `students.db` | SQLite database file storing student records. |
| `appsettings.json` | Contains application configuration. |
| `appsettings.Development.json` | Contains development-specific configuration. |
| `Program.cs` | Configures services, middleware, database access, and controller routing. |
| `WebApplication1.csproj` | Defines the project framework, dependencies, and build settings. |
| `WebApplication1.http` | Contains HTTP requests for testing API endpoints. |
| `README.md` | Documents the project and explains how to use it. |

## CRUD Endpoints

| HTTP Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/students` | Retrieve all students. |
| `GET` | `/api/students/{id}` | Retrieve a student by ID. |
| `POST` | `/api/students` | Create a new student. |
| `PUT` | `/api/students/{id}` | Update an existing student. |
| `DELETE` | `/api/students/{id}` | Delete a student. |

## Technologies Used

- **C#** — Programming language
- **ASP.NET Core 10 Web API** — API framework
- **Entity Framework Core** — Object-relational mapper (ORM)
- **SQLite** — Database
- **Swagger / OpenAPI** — API documentation and testing

## Getting Started

### 1. Clone the repository

```bash
git clone <your-repository-url>
cd WebApplication1
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Run the application

```bash
dotnet run
```

### 4. Open Swagger

Navigate to the Swagger URL shown in the terminal, typically:

```text
https://localhost:<your-https-port>/swagger
```

Use Swagger to test the CRUD endpoints.

## Notes

- The SQLite database is created locally when the application starts.
- The `bin/` and `obj/` folders are generated during builds and generally should not be committed to Git.
- Avoid committing local database files if they contain private or sensitive data.


<img width="242" height="372" alt="image" src="https://github.com/user-attachments/assets/d515100c-5112-4e16-960d-2ecdb7e96e5f" />
