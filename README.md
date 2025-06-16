# 🎒 EquipEase – Equipment Rental Management System

**EquipEase** is a desktop application designed for managing equipment rentals in a multi-branch organization. Built using **C# and WinForms**, it provides tools to **hire, return, and track equipment**, and includes a reporting suite to analyze rental data.

---

## ✨ Features

- 🔎 **Rental Records Search** – Filter rentals by status (Ongoing, Upcoming, Past)
- ➕ **Hire Equipment** – Register customer info and schedule equipment hire
- 🔁 **Return Equipment** – Process returns, update availability, and track return branch
- 📊 **Reports Dashboard** – View analytics on:
  - Unique customers per branch
  - Average rental durations
  - Monthly rentals
  - Most rented equipment types
  - Total income per equipment type

---

## 🖥️ Technologies Used

- **Language**: C#  
- **UI Framework**: WinForms (.NET Framework)
- **Database**: SQL Server (Local)
- **Libraries**: `System.Data.SqlClient`, `System.Windows.Forms`

---

## 🗃️ File Structure

```plaintext
EquipEase/
├── Program.cs                # Main entry point
├── StartPage.cs              # Navigation UI
├── HireEquipment.cs          # Form to hire equipment
├── ReturnEquipment.cs        # Form to return equipment
├── RentalRecords.cs          # Search/filter rental records
├── Reports.cs                # Generate analytical reports
├── SQL.cs                    # Database interaction logic
├── Details.cs                # Customer and equipment detail handler
```

---

## 🛠️ Setup & Run Locally
1. Clone the Repository
```plaintext
git clone https://github.com/lucasziiN/EquipEase.git
cd EquipEase
```
2. Configure Database
- Open SQL Server and run the included schema scripts to create the EquipEaseDB
- Update the connection string in SQL.cs:
```plaintext
new SqlConnection(@"Data Source=YOUR_SERVER_NAME;Database=EquipEaseDB;Integrated Security=True");
```
3. Build and Run
- Open the .sln file in Visual Studio
- Press F5 to build and run

--- 

## 📚 Learning Outcomes
- Advanced use of WinForms and UI component handling
- SQL query design and integration
- Multi-form navigation and data flow
- Robust error handling and user input validation


--- 

## 👨‍💻 Author
Lucas Oda
Bachelor of Science in Computer Science
University of Waikato – 2025

---

## 📜 License
This project is for academic and educational use only.