# 🏋️ BeFit Mobile

A cross-platform workout tracking application built with **.NET MAUI**. Track your exercises, training sessions, and monitor your fitness progress with an intuitive and modern interface.

![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-9.0-purple?style=flat-square&logo=dotnet)
![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20iOS%20%7C%20Windows-blue?style=flat-square)
![SQLite](https://img.shields.io/badge/Database-SQLite-green?style=flat-square)

## ✨ Features

### 🔐 User Authentication
- User registration with first name, last name, email, and password
- Secure login with password hashing (SHA256)
- Role-based access control (Admin / User)
- Default test accounts for quick testing

### 💪 Exercise Management
- Browse available exercise types
- Admin users can add, edit, and delete exercise types
- Detailed view for each exercise

### 📅 Training Sessions
- Create training sessions with start and end times
- Track session duration
- Edit and delete sessions
- Duplicate session prevention

### 🏃 Workout Tracking
- Log exercises with load (kg), sets, and repetitions
- Associate exercises with training sessions
- Full CRUD operations for workout entries
- Duplicate exercise prevention per session

### 📊 Statistics Dashboard
- View exercise statistics for the last 4 weeks
- Track total reps, average load, and max load per exercise
- Visual summary of workout progress

### 👤 Account Management
- Update personal information
- Change password
- Delete account (with data cascade)

### 👑 Admin Features
- View all registered users
- Delete user accounts
- Manage exercise types globally

## 🛠️ Technology Stack

| Component | Technology |
|-----------|------------|
| Framework | .NET MAUI 9.0 |
| Language | C# 12 |
| Database | SQLite (via EF Core) |
| Architecture | MVVM-lite with Code-Behind |
| UI | XAML with Custom Styles |
| Auth | Custom with SHA256 Password Hashing |

## 📱 Supported Platforms

- ✅ **Android** (API 21+)
- ✅ **iOS** (14.0+)
- ✅ **Windows** (10.0.19041+)
- ✅ **macOS** (via Mac Catalyst)

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 (17.8+) with MAUI workload
- For Android: Android SDK (API 35)
- For iOS: Xcode 15+ (macOS only)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/BeFitMobile.git
   cd BeFitMobile
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run on your preferred platform**
   ```bash
   # Windows
   dotnet build -f net9.0-windows10.0.19041.0
   
   # Android
   dotnet build -f net9.0-android
   
   # iOS (macOS only)
   dotnet build -f net9.0-ios
   ```

### Test Accounts

| Role | Email | Password |
|------|-------|----------|
| Admin | admin@befit.local | Admin123! |
| User | user1@befit.local | User123! |

## 📁 Project Structure

```
BeFitMaui/
├── App.xaml(.cs)           # Application entry point
├── MainTabbedPage.cs       # Main navigation (TabBar)
├── MainPage.xaml(.cs)      # Home/Dashboard
├── Data/
│   └── BeFitDbContext.cs   # EF Core database context
├── Models/
│   ├── User.cs             # User model
│   ├── ExerciseType.cs     # Exercise type model
│   ├── TrainingSession.cs  # Training session model
│   └── TrainingExercise.cs # Workout entry model
├── Pages/
│   ├── LoginPage.xaml(.cs)
│   ├── RegisterPage.xaml(.cs)
│   ├── ExerciseTypesPage.xaml(.cs)
│   ├── TrainingSessionsPage.xaml(.cs)
│   ├── TrainingExercisesPage.xaml(.cs)
│   ├── StatsPage.xaml(.cs)
│   ├── AccountPage.xaml(.cs)
│   └── AdminUsersPage.xaml(.cs)
├── Services/
│   └── AuthService.cs      # Authentication service
└── Resources/
    └── Styles/Colors.xaml  # Theme colors
```

## 🎨 UI Theme

The app features a modern, clean design with a purple-based color scheme:

- **Primary**: `#6C5CE7` (Purple)
- **Secondary**: `#A29BFE` (Light Purple)
- **Success**: `#00B894` (Green)
- **Warning**: `#FDCB6E` (Yellow)
- **Danger**: `#D63031` (Red)

## 📋 Data Validation

All models include validation attributes:

- **ExerciseType**: Name (required, 2-100 chars)
- **TrainingSession**: Start/End time (required)
- **TrainingExercise**: Load (0-500 kg), Sets (1-20), Reps (1-100)

## 🔒 Security

- Passwords are hashed using SHA256 before storage
- No plain-text password storage
- User-specific data isolation (users can only see their own data)
- Admin-only actions for sensitive operations

## 📄 License

This project is for educational purposes.

## 🤝 Contributing

Contributions are welcome! Feel free to submit issues and pull requests.

---

**Built with ❤️ using .NET MAUI**
