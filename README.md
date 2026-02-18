# Personal Application

**Personal Application** is a feature-rich desktop personal organizer built with **C#** and **.NET Framework 4.7.2** using **Windows Forms**. It is designed to demonstrate Object-Oriented Programming (OOP) principles, Design Patterns, and file-based data persistence in a real-world scenario.

This application allows users to manage their daily digital life, including contacts, notes, reminders, and personal profiles, with a robust user management system.

## 📑 Table of Contents
- [Features](#-features)
- [Architecture & Design Patterns](#-architecture--design-patterns)
- [Installation & Setup](#-installation--setup)
- [Usage Guide](#-usage-guide)
- [Project Structure](#-project-structure)
- [Contributors](#-contributors)

---

## 🚀 Features

### 1. User Management & Security
*   **Secure Authentication:** Users log in with a username and password. Passwords are hashed using **SHA-256** before storage, ensuring security.
*   **Role-Based Access Control (RBAC):**
    *   **Admin (`*`):** Can view all users, change user roles (Admin, User, Part-time), and reset passwords.
    *   **User (`+`):** Standard access to personal modules.
    *   **Part-time User (`-`):** Limited access (affects salary calculation logic).
    *   **Auto-Admin Assignment:** The **first user** to sign up in the system is automatically granted **Admin (`*`)** privileges. Subsequent users are registered as standard Users (`+`).
*   **Password Recovery:** Admins can change a user's password, which triggers an automatic email notification to the user's registered email address via SMTP.

### 2. Personal Information (Profile)
*   **Editable Profile:** Users can update their Name, Surname, Address, Phone, and Email.
*   **Photo Support:** Users can upload a profile picture. The image is converted to a **Base64 string** and stored directly in the CSV database, ensuring portability.
*   **Undo/Redo System:** Accidentally deleted your name? The profile editor supports unlimited Undo (Ctrl+Z) and Redo (Ctrl+Y) operations during a session.

### 3. Modules
*   **📞 Phonebook:**
    *   Store contacts with Name, Surname, Phone, Address, Description, and Email.
    *   **Validation:** built-in Regex validation for email addresses.
    *   Search and list view for easy management.
*   **📝 Notes:**
    *   A simple note-taking module to save thoughts and ideas.
    *   Notes are saved privately for each user.
*   **⏰ Reminders:**
    *   Set reminders for specific dates and times.
    *   **Visual & Audio Alert:** When a reminder triggers, the application window shakes and changes its title to grab the user's attention.
    *   **Types:** Supports two types of reminders: **Meeting** and **Task**.
*   **💰 Salary Calculator:**
    *   Computes an estimated salary based on a complex algorithm involving:
        *   Experience Years
        *   Education Degree (Bachelor, Master, PhD)
        *   Foreign Languages known
        *   Management Position
        *   Management Position
        *   Family Status (Spouse status, Children count)
    *   **Calculation Logic:** 
        *   Base Salary is set to **17,002 TL**.
        *   Includes specific benefits for children (0-6 years: +10%, 7-18 years: +12%) and spouse (+10%).
        *   *Note: The project includes a Builder Pattern structure for salary calculation, though the current form implementation uses direct arithmetic logic.*
    *   Logic varies based on user type (Full-time vs. Part-time).

---

## 🏗 Architecture & Design Patterns

The project follows a layered approach, separating the User Interface (Forms) from Logic and Data Access.

### Design Patterns Used

#### 1. Memento Pattern
*   **Purpose:** To implement the **Undo/Redo** functionality in the Personal Information screen.
*   **Implementation:**
    *   `Memento` class stores the state of a `User` object.
    *   `Memory` class acts as the caretaker.
    *   As you type or change fields, the state is pushed onto a Stack. `Ctrl+Z` pops the previous state and restores it.

#### 2. Builder Pattern
*   **Purpose:** To handle the complex construction of the Salary calculation logic, which depends on many independent parameters.
*   **Implementation:**
    *   `SalaryBuilder` (Abstract Base)
    *   `UserSalary` & `PartTimeUserSalary` (Concrete Builders): Define how parameters affect the final calculation.
    *   `SalaryDirector`: Orchestrates the calculation process.

#### 3. Singleton Pattern
*   **Purpose:** To manage the currently logged-in user session.
*   **Implementation:** `LoginedUser` class ensures only one active user instance exists throughout the application lifecycle.

### Data Persistence
The application uses a **CSV (Comma Separated Values)** file system for data storage, located in the `data/` directory. No SQL database is required.
*   **`User.csv`:** Stores all user credentials and profile data.
*   **`[Username]Phonebook.csv`:** Stores contacts for a specific user (e.g., `adminPhonebook.csv`).
*   **`[Username]Notes.csv`:** Stores notes for a specific user.
*   **`[Username]Reminder.csv`:** Stores reminders for a specific user.

---

## ⚙ Installation & Setup

### Prerequisites
*   **OS:** Windows 7, 8, 10, or 11.
*   **IDE:** Visual Studio 2019 / 2022.
*   **.NET Framework:** Version 4.7.2.

### Steps
1.  **Clone the Repository**
    ```bash
    git clone https://github.com/emreilr/js_projects.git PersonalApplication
    ```
2.  **Open Solution**
    *   Navigate to the folder and open `PersonalApplication.sln` with Visual Studio.
3.  **Build**
    *   Go to **Build** > **Build Solution** (or press `Ctrl+Shift+B`).
    *   *Note: Ensure the `data/` directory exists in the output folder (`bin/Debug/data`) if it's not created automatically, though the code creates files as needed.*
4.  **Run**
    *   Press **Start** or `F5`.

### ⚠️ Configuration (Important)
To use the **Password Recovery (Email)** feature, you must configure a valid Sender Email in the source code:
1.  Open `src/UserManagement.cs`.
2.  Locate the `btnChangePassword_Click` method.
3.  Update the email and password fields with your own credentials:
    ```csharp
    mail.From = new MailAddress("your-email@gmail.com");
    smtp.Credentials = new NetworkCredential("your-email@gmail.com", "your-app-password");
    ```
    *Note: For Gmail, use an [App Password](https://support.google.com/accounts/answer/185833) instead of your main password.*

---

## 📖 Usage Guide

1.  **Sign Up:** Click the "Sign Up" button on the login screen to create a new account.
2.  **Login:** Enter your credentials.
    *   *Tip: Use the "Remember Me" checkbox to auto-login next time.*
3.  **Dashboard:** Access all modules from the main colorful dashboard.
4.  **Admin Panel (For Admins Only):**
    *   If you are an Admin, a "User Management" button will appear.
    *   Use this to promote/demote users or reset their passwords.

---

## 📂 Project Structure

*   `src/`
    *   `Forms/`: (GUI) `LoginForm`, `MainWindow`, `PersonalInformation`, `Phonebook`, etc.
    *   `Classes/`:
        *   `User.cs`: Core user entity.
        *   `Util.cs`: Helper methods for Hashing, CSV I/O, and Image conversion.
        *   `BuilderFactory.cs`: Salary calculation logic.
    *   `Program.cs`: Entry point.

---
