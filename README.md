# GraduationTracker

This project provides a service to determine if a student has met the requirements for graduation.

## Design and SOLID Principles

This project is structured to follow SOLID principles and promote clean code.

- **Dependency Inversion Principle (DIP):** The core business logic in `GraduationTracker.Services.GraduationTracker` depends on abstractions (`IRepository`, `IStudentRepository`, etc.) rather than concrete implementations. Dependencies are provided via constructor injection, decoupling the service from its data sources.

- **Repository Pattern:** Data access is abstracted using the repository pattern. Interfaces like `IStudentRepository` and `IDiplomaRepository` define contracts for data operations, and the concrete implementations (`StudentRepository`, `DiplomaRepository`) handle the specific data access logic (currently using in-memory data).

- **Separation of Concerns:** Each module performs a specific task. This separation makes the codebase easier to understand, maintain, and test.

## How to Build and Run

This project is a class library, so it doesn't run as a standalone application. The primary way to execute the logic is by running the unit tests.

### Build the solution

```bash
dotnet build
```

### Run the tests

To run the unit tests, execute the following command from the root directory:

```bash
dotnet test
```
