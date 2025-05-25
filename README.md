ReservationSystem
A complete, real-time scheduling and reservation system built with ASP.NET Core, Blazor, SignalR, and Entity Framework Core. This system allows users to create and manage reservations with validation, filtering, and admin controls.

Features
🔐 Authentication – Secure login system for users and admins.

📅 Scheduling – Create and manage time-based reservations.

✅ Validation – Prevent duplicate bookings and validate availability.

🔄 Real-time Notifications – Powered by SignalR for live reservation updates.

🌐 Modern UI – Built with Blazor Server for an interactive single-page experience.

Tech Stack
ASP.NET Core 8.0

Blazor Server

Entity Framework Core

SignalR

SQL Server

Getting Started
Prerequisites
.NET 8 SDK

SQL Server

IDE (e.g. Visual Studio 2022+ or Rider)

Setup
Clone the repository

bash
Copy
Edit
git clone https://github.com/hejazij88/ReservationSystem.git
cd ReservationSystem
Update the connection string

Edit appsettings.json to point to your SQL Server instance:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=ReservationSystemDb;Trusted_Connection=True;"
}
Apply migrations and update the database

bash
Copy
Edit
dotnet ef database update
Run the application

bash
Copy
Edit
dotnet run
Navigate to https://localhost:5001 in your browser.
