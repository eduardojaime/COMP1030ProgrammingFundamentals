# Instructions

### Setting up your environment

- Sign up for a HackerRank account
    - Navigate to https://www.hackerrank.com/auth/signup
- Sign up for a GitHub account
    - Navigate to https://github.com
- Download GitHub Desktop (UI for GitHub)
    - Navigate to https://desktop.github.com/
    - Watch this video tutorial to create and clone your first repository https://youtu.be/sObZ61W66GU
- Download VS Code
    - Navigate to https://code.visualstudio.com/
- Install the following extensions
    - C#
    - C# Extensions
    - Auto-using for C#
    - C# Sort Using
    - Code Spell Checker
    - Todo Tree
- Download .NET 7 SDK
    - Navigate to https://dotnet.microsoft.com/en-us/download

### Creating a sample Hello World application

- On your computer, select a folder where you will store all the source code for this class
- In this folder, create a new folder called Lesson01
- Open Visual Studio Code
    - In the menu at the top select File > Open Folder
    - Navigate to the folder you created, click on it and then 'select folder'
    - In the menu at the top select Terminal > New Terminal
    - On the terminal, run the following commands:
        - Verify that .NET is installed on your computer
            - dotnet --version
        - Explore the list of commands available for creating a new project
            - dotnet new -l
        - Create a new Console Application with a classic template
            - dotnet new console --use-program-main
        - Run the project
            - dotnet run
            - Verify that you can see "Hello, World" in the terminal