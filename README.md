# Classroom API Project

## Overview

This project demonstrates a simple implementation of **Dependency Injection (DI)** within an ASP.NET Core Web API. The application models a classroom environment, where a `Teacher` entity is injected into a `ClassRoom` class. Through API endpoints, the teacher's information can be retrieved. The project is designed to show how DI can simplify the management of dependencies between classes in a Web API context.

## Features

- **Teacher Information Management:** The project contains a `Teacher` class that holds basic information such as the teacher's first name and last name.
- **Classroom Setup:** The `ClassRoom` class uses a `Teacher` instance injected via constructor injection, demonstrating the use of DI in ASP.NET Core.
- **RESTful API:** A simple API is provided to retrieve the teacher's information from the `ClassRoom` class.

## Technologies

- **ASP.NET Core 6.0**
- **Dependency Injection**
- **C#**

## Endpoints

- **GET /api/classroom/get-teacher-info:** Returns the full name of the teacher assigned to the classroom.

## Project Structure

- `Teacher`: A class that holds the teacher's `FirstName` and `LastName`.
- `IOgretmen`: An interface implemented by the `Teacher` class to define the structure of the teacher's properties and methods.
- `ClassRoom`: A class that accepts an instance of `Teacher` (injected via DI) and provides methods to retrieve teacher information.
- `ClassRoomController`: A Web API controller that exposes an endpoint to get teacher information.

## Getting Started

1. **Clone the repository.**
   ```
   git clone https://github.com/your-repo/classroom-api-project.git
   ```

2. **Build and Run:**
   - Open the project in Visual Studio or any preferred C# IDE.
   - Build the project.
   - Run the application.

3. **Access the API:**
   - Open a browser or a tool like Postman.
   - Send a GET request to the following endpoint:
     ```
     https://localhost:5001/api/classroom/get-teacher-info
     ```

## How Dependency Injection Works

In this project, the `ClassRoom` class depends on the `Teacher` instance. Instead of creating the `Teacher` instance manually inside the `ClassRoom` class, we inject it using ASP.NET Core's built-in Dependency Injection system. This allows for better testability, separation of concerns, and code maintenance.

## Conclusion

This project provides a simple demonstration of how Dependency Injection can be used in an ASP.NET Core Web API to manage class dependencies. It serves as a foundational example for building more complex APIs with loosely coupled components.



![image](https://github.com/user-attachments/assets/10e063e7-6454-4c3c-bbaa-4a82466dad39)
