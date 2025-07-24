# C# Selenium Project

## Overview
This project is a C# application that utilizes Selenium WebDriver to automate web browser interactions. It is designed to perform login actions on a specified web application.

## Project Structure
```
csharp-selenium-project
├── src
│   └── Program.cs        # Main entry point of the application
├── .gitignore            # Specifies files and directories to ignore by Git
├── csharp-selenium-project.sln  # Solution file for the C# project
└── README.md             # Documentation for the project
```

## Setup Instructions
1. Ensure you have the .NET SDK installed on your machine.
2. Clone the repository:
   ```
   git clone <repository-url>
   ```
3. Navigate to the project directory:
   ```
   cd csharp-selenium-project
   ```
4. Restore the project dependencies:
   ```
   dotnet restore
   ```

## Usage
1. Open the `src/Program.cs` file and update the `your_username` and `your_password` placeholders with your actual credentials.
2. Run the application:
   ```
   dotnet run --project src/Program.cs
   ```

## Dependencies
- Selenium WebDriver
- ChromeDriver

## License
This project is licensed under the MIT License.