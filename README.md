# 🎬 CinemaWeb – May 2025 Skeleton

A modern web application skeleton for building cinema-related platforms using ASP.NET Core and Entity Framework. This template provides a robust foundation for managing movies, screenings, bookings, and user authentication.

---

## 🚀 Features

- **Modular Architecture**: Clean separation of concerns with layered architecture.
- **Entity Framework Core Integration**: Simplified data access with code-first migrations.
- **User Authentication & Authorization**: Built-in support for user registration, login, and role management.
- **Responsive UI**: Pre-configured with Bootstrap for mobile-first design.
- **API-Ready**: Structured to easily expose RESTful endpoints.

---

## 🛠️ Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQLite](https://www.sqlite.org/download.html)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/edvinhubbyy/CinemaWeb-May-2025-Skeleton.git
   cd CinemaWeb-May-2025-Skeleton
   ```

2. **Restore dependencies**:

   ```bash
   dotnet restore
   ```

3. **Apply migrations and update the database**:

   ```bash
   dotnet ef database update
   ```

4. **Run the application**:

   ```bash
   dotnet run
   ```

   Navigate to `https://localhost:5001` in your browser.

---

## 📁 Project Structure

```plaintext
CinemaWeb-May-2025-Skeleton/
├── Controllers/           # MVC Controllers
├── Models/                # Entity Framework Models
├── Views/                 # Razor Views
├── Data/                  # Database Context and Migrations
├── wwwroot/               # Static Files (CSS, JS, Images)
├── Services/              # Business Logic Services
├── appsettings.json       # Configuration Settings
└── Program.cs             # Application Entry Point
```

---

## 🧪 Testing

Unit and integration tests can be added using xUnit or NUnit.

```bash
dotnet test
```

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 🤝 Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

---

## 📬 Contact

For questions or support, please open an issue on the [GitHub repository](https://github.com/edvinhubbyy/CinemaWeb-May-2025-Skeleton/issues).
