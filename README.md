💻 .NET Interview Quiz Application

A professional quiz application built with ASP.NET Core MVC to help .NET interns prepare for technical interviews. Features a modern, responsive UI with instant scoring and feedback.

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat&logo=microsoft-sql-server)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?style=flat)

✨ Features

- 🎯 30 Professional Questions covering C#, ASP.NET Core, OOP, LINQ, and Entity Framework
- 🎲 Random Question Selection - 5 questions per quiz attempt
- 👤 Personalized Experience - Candidates enter their name before starting
- 📊 Instant Results - Real-time scoring with visual feedback
- 🎨 Modern UI/UX - Professional gradient design with animations
- 📱 Fully Responsive - Works on desktop, tablet, and mobile devices
- 🔄 Session Management - Maintains user context throughout the quiz

🚀 Technologies Used

- ASP.NET Core MVC - Web framework
- Entity Framework Core - ORM for database operations
- SQL Server - Database
- C# - Programming language
- Razor Pages - View engine
- HTML/CSS - Frontend styling
- Session Management - User state management

📋 Prerequisites

Before running this application, make sure you have:

- [.NET 6.0 SDK or later](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express or higher)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

🛠️ Installation & Setup

 1. Clone the Repository

```bash
git clone https://github.com/yourusername/dotnet-quiz-app.git
cd dotnet-quiz-app
```

2. Update Database Connection String

Open `appsettings.json` and update the connection string with your SQL Server details:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=Quize_app_db;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

3. Create Database and Run Migrations

Open SQL Server Management Studio (SSMS) and run:

```sql
CREATE DATABASE Quize_app_db;
```

Then in Package Manager Console or Terminal:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

4. Import Sample Questions

Run the SQL script provided in the repository (`SampleQuestions.sql`) in SSMS to populate the database with 30 interview questions.

5. Run the Application

```bash
dotnet run
```

The application will start at `https://localhost:5001` or `http://localhost:5000`

📁 Project Structure

```
Quize_app/
├── Controllers/
│   └── QuizController.cs          # Main application controller
├── Data/
│   └── ApplicationDbContext.cs    # Entity Framework DbContext
├── Models/
│   └── question.cs                # Question model
├── Views/
│   └── Quiz/
│       ├── Home.cshtml            # Welcome page
│       ├── Index.cshtml           # Quiz questions page
│       └── Result.cshtml          # Results page
├── appsettings.json               # Configuration file
├── Program.cs                     # Application entry point
└── README.md                      # Project documentation
```

🎮 How to Use

1. Welcome Screen - Enter your name to begin
2. Take Quiz - Answer 5 randomly selected multiple-choice questions
3. View Results - See your score, percentage, and performance feedback
4. Try Again - Take the quiz again with different questions

📊 Question Topics Covered

- C# Fundamentals - CLR, data types, keywords, nullable types
- ASP.NET Core - MVC, middleware, routing, dependency injection
- OOP Concepts - Inheritance, polymorphism, abstract classes, interfaces
- LINQ & Collections - Filtering, querying, IEnumerable
- Entity Framework Core - DbContext, database operations
- Async Programming - async/await patterns
- Design Patterns - Repository pattern
- HTTP Protocols - Status codes, HTTP methods

🎨 Screenshots

Home Page
Professional welcome screen with candidate name entry
<img width="1343" height="598" alt="image" src="https://github.com/user-attachments/assets/803c6b58-1bf5-4547-a01a-9e9218d6ee55" />


Quiz Page
Interactive questions with modern card design and hover effects
<img width="1351" height="598" alt="image" src="https://github.com/user-attachments/assets/9586221f-bee2-4771-9d15-24895f4319f0" />


Results Page
Animated circular progress bar showing performance with detailed statistics
![Uploading image.png…]()


🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

📝 Future Enhancements

- [ ] Add timer for each quiz
- [ ] Show correct answers after submission
- [ ] Add difficulty levels (Easy, Medium, Hard)
- [ ] Export results as PDF
- [ ] Add user authentication
- [ ] Create admin panel to manage questions
- [ ] Add more question categories
- [ ] Implement leaderboard

📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

👨‍💻 Author

Pramodya Warnakula
- GitHub: https://github.com/pramodya112
- LinkedIn: https://www.linkedin.com/in/pramodya-warnakula-10682626a/

🙏 Acknowledgments

- Inspired by the need to help .NET interns prepare for technical interviews
- Built as a learning project to demonstrate ASP.NET Core MVC skills
- Special thanks to the .NET community for excellent documentation

---

Happy Coding! 🚀
