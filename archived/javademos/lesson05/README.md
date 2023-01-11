# Instructions

### Demo 1 Creating a Student class that stores name and average

- Create a new file called Student.java
- In this file, create a class named Student
- Add two properties: name and average with their corresponding setter and getter methods
- Add a constructor that takes name and average as parameters and use these values to initialize internal name and average properties
- Make the following modifications to the class:
    - In the constructor, use nested if statements to validate the following:
        - Average value is only set if provided value is greater than 0.0
        - Average value is only set if provided value is less than or equal to 100.0
    - In Average setter method, use nested if statements to validate the following:
        - Average value is only set if provided value is greater than 0.0
        - Average value is only set if provided value is less than or equal to 100.0
    - Create a getLetterGrade() method to determine what letter to print based on the students grade
        - Average greater than or equal to 90.0 receives an A
        - Average greater than or equal to 80.0 receives an A
        - Average greater than or equal to 70.0 receives an C
        - Average greater than or equal to 60.0 receives an D
        - Any other value receives an F
- Create a new file called StudentTest.java
- In this file, create a class named StudentTest
- Create two student objects with different averages
- Print their letter grades to verify

### Demo 2 Solving the class-average problem using counter-controlled iteration

- Create a new file called ClassAverage.java
- In this file, create a class named ClassAverage
- Add a main method
- Inside the main method, implement the following logic:
    - Create a scanner object to obtain input from user
    - Declare and Initialize two int variables: total and gradeCounter
    - Implement a while loop to iterate 10 times, each time
        - Prompt user to enter grade
        - Declare an int variable named grade to store the provided value
        - Calculate total so far
        - Increment grade counter
        - Stop loop when grade counter is greater than 11
    - Declare an int variable called average and calculate this value accordingly based on the total grades
    - Print Total grades, and Average value

### Demo 3 Solving the class-average problem using sentinel-controlled iteration

- Modify the main method in the ClassAverage above to implement the following logic:
    - Create a scanner object to obtain input from user
    - Declare and Initialize two int variables: total and gradeCounter
    - Prompt the user to enter a grade or -1 to stop
    - Declare an int variable named grade to store the provided value
    - Modify the while loop to do the following:
        - Loop will iterate when grade value is different than -1
        - Calculate total so far
        - Increment grade counter
        - Prompt the user to enter a grade or -1 to stop
        - Store the provided value in grade variable
    - If gradeCounter is 0 then no grades were entered, show corresponding message in the console
    - If gradeCounter value is different than 0:
        - Declare a double variable called average to use numbers with decimal points
        - Calculate average value, cast total to double and divide accordingly
        - Print Total and Class Average values

### Demo 4 Analyzing examination results using nested control statements

- Create a new file called Analysis.java
- In this file, create a class named Analysis
- Add a main method
- Inside the main method, implement the following logic:
    - Create a Scanner object to obtain input from user
    - Declare and initialize three int variables: passes, failures, studentCounter
    - Implement a while loop to iterate 10 times, each time
        - Prompt user for input: 1 for pass and 2 for fail
        - Declare a result variable and store the provided value in it
        - Use if-else to increment passes or failures
        - Increment studentCounter
    - Display the number of passes and failures
    - If passes are greater than 8, print bonus to instructor

### Demo 5 Using Prefix increment and postfix increment operators

- Create a new file called Increment.java
- In this file, create a class named Increment
- Add a main method
- Inside the main method, implement the following logic:
    - Declare an int variable called c
    - Initialize c to 5
    - Use system.out.printf to output the following messages
        - Print the value of c
        - Print the value of c++
        - Print the value of c
    - Set c to 5
    - Use system.out.printf to output the following messages
        - Print the value of c
        - Print the value of ++c
        - Print the value of c