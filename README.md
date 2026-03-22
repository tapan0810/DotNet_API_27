# 🚀 DotNet_API_27

A modern ASP.NET Core Web API built using clean architecture principles with Entity Framework Core, AutoMapper, and DTO-based design. This project demonstrates scalable and maintainable backend development practices.

---

## 📌 Features

- Clean and modular project structure  
- Entity Framework Core with migrations  
- DTO-based architecture (separation of concerns)  
- AutoMapper integration for object mapping  
- Environment-based configuration  
- API testing using .http file and Scalar  

---

## 📂 Project Structure

```
DotNet_API_27/
│── Data/              # DbContext and database configuration
│── Entities/          # Models and DTOs
│── Mapping/           # AutoMapper profiles
│── Migrations/        # EF Core migrations
│── Properties/        # Project settings
│── Program.cs         # Application entry point
│── appsettings.json   # Configuration files
│── DotNet_API_27.http # API testing file
```

---

## 🛠️ Tech Stack

- .NET (ASP.NET Core Web API)
- Entity Framework Core
- AutoMapper
- SQL Server

---

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/DotNet_API_27.git
cd DotNet_API_27
```

### 2. Setup Database

Update connection string in `appsettings.json` and run:

```bash
dotnet ef database update
```

### 3. Run the Application

```bash
dotnet run
```

### 4. Test APIs

- Use the `.http` file in the project  
- Or tools like Postman / Scalar  

---

## 🔄 Migrations

```bash
dotnet ef migrations add MigrationName
dotnet ef database update
```

---

## 🎯 Purpose

This project showcases clean architecture, best practices in .NET API development, and a scalable backend structure suitable for real-world applications.

---

## 📌 Future Improvements

- Add JWT Authentication  
- Implement Repository & Service layers  
- Add logging and global exception handling  
- Docker support  

---

## 🤝 Contributing

Feel free to fork this repository and submit pull requests.

---

## 📄 License

This project is open-source under the MIT License.
