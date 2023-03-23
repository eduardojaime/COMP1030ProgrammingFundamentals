# Instructions

### Part 1 Creating a simple Student Management program

- Create a new folder called lesson10
- Open this folder with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - Modify the default Console.WriteLine() message to read "Hello, Georgian College!"

### Part 2 Creating a Student class

- Let's do a little bit of design
    - What properties describe a student?
    - What properties need to be kept private? If any? E.g. SIN
    - What methods can be used to describe actions a student performs? E.g. Enrolling to a class
- Create a new file called Student.cs
- In this file, create a class named Student
- Add the following properties with the corresponding getter/setter methods:
    - FirstName
    - LastName
    - EmailAddress
    - BirthDate
    - Program
    - Average
- Add FullName as a read-only property
    - Setter returns the result of appending FirstName and LastName
- Add a constructor that takes these properties as parameters and use these values to initialize internal name and average properties
- Make the following modifications to the class:
    - In the constructor, use nested if statements to validate the following:
        - Average value is only set if provided value is greater than 0.0
        - Average value is only set if provided value is less than or equal to 100.0
    - In Average setter method, use nested if statements to validate the following:
        - Average value is only set if provided value is greater than 0.0
        - Average value is only set if provided value is less than or equal to 100.0
    - Create a GetLetterGrade() method to determine what letter to print based on the students grade
        - Average greater than or equal to 90.0 receives an A
        - Average greater than or equal to 80.0 receives an A
        - Average greater than or equal to 70.0 receives an C
        - Average greater than or equal to 60.0 receives an D
        - Any other value receives an F

### Part 3 Implementing the Student class in the main Program

- In Program.cs
    - Go to the main method
        - Declare and initialize two instances of the student class
        - Print the average value for and letter grade for both
        - Comment out the previous lines
        - Declare a List of Students variable named StudentList and initialize as empty
        - Implement a while loop and in each iteration:
            - Ask the user to enter FirstName, LastName and Average
            - Declare an initialize an instance of Student class using this information
            - Add the new instance of Student to the list
            - Ask the user whether they want to add a new Student to the list
                - If Y then do another iteration 
                - Else exit the loop
    - Write a new method named PrintStudentsList that takes the students list as a parameter 
        - Implement a foreach loop
            - Print the full name and grade letter for the current student in the same line
    - Back to the main method
        - Call PrintStudentsList and pass the students list as a parameter
    - Run the program and verify its output 