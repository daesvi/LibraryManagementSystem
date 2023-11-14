# LMS (Library Management System)
![image](https://img.shields.io/badge/MariaDB-003545?style=for-the-badge&logo=mariadb&logoColor=white](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white))
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)
![image](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)


Welcome to the Library Management System, a project designed to streamline library operations by efficiently managing books, loans, returns, and user interactions.


---
## Table of Contents

- [LMT (Library Management System)](#lmt-library-management-system)
  - [Description](#description)
  - [Functional Requirements](#functional-requirements)
  - [Non-Functional Requirements](#non-functional-requirements)
  - [Architecture](#architecture)
  - [Database](#database)
  - [Members](#members)
  - [License](#license)


---
## Description

**Objective:**
Develop a library management system to provide efficient tools for librarians and users to manage books, loans, and returns.

**Detailed Description:**
Library Management System is a Windows Forms application aiming to optimize library management. It provides librarians and users with an intuitive and efficient tool for book management.


---
## Functional Requirements

1. **Book Registration:**
   - Librarians can register books in the database.
   - Detailed information about each book (title, author, category, number of copies, etc.) is entered.

2. **Loan Management:**
   - Librarians can register loans of books to users.
   - Availability of books is checked before registering a loan.

3. **Return Registration:**
   - Librarians can register the return of books by users.

4. **Book Search and Query:**
   - Users can search for books by title, author, category, or keyword.
   - The system displays relevant search results and allows users to view details of available books.

5. **Authentication and Security:**
   - Librarians and users must authenticate to access the system.


---
## Non-Functional Requirements

1. **User-Friendly Interface:**
   - The interface is intuitive and user-friendly for both librarians and users.

2. **Scalability:**
   - The system is scalable to handle a growth in the number of books and users without performance loss.

3. **Efficient Performance:**
   - The system is fast and efficient in searching and retrieving information from the database.

4. **Availability:**
   - The system is available for use during library operating hours without prolonged interruptions.

5. **Maintenance and Updates:**
   - Maintenance and updates are easy to perform without significant service interruptions.


---
## Architecture

The project follows a layered architecture for better organization and separation of concerns:

- **data:** Configuration for mapping with Entity Framework.
- **interfaces:**
  - **repository:** Interacts with the database.
  - **service:** Business logic.
- **model:** Contains entities.
- **repository:**
- **resources:** Images used in the project.
- **service:**
- **ui:** Forms of the user interface.

This architecture promotes modularity and maintainability by separating database interactions, business logic, and the user interface into distinct layers.

---
## Database

MySQL is used as the database management system.


---
## Members

- [Daniel Estiven Villegas Bedoya](https://www.linkedin.com/in/daesvi/)


---
## License

This project is licensed under the [MIT License](LICENSE).
