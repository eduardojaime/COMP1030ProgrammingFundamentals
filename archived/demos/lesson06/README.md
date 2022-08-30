# Instructions

### Demo 1 Summing the Even Integers from 2 to 20

- Create a new file called Sum.java
- In this file, create a class named Sum
- Add a main method
- In the main method
    - Declare an int variable and set to 0, this will be used to store my resulting total
    - Add a for loop
        - Initialize control variable as 2
        - Set looping condition as number is less than or equal to 20
        - Increment number by 2
        - Add number to total
    - Print out the resulting total

### Demo 2 Compund-Interest Calculations

- Create a new file called Interest.java
- In this file, create a class named Interest
- Add a main method
- In the main method
    - Declare a double variable called principal and set to 1000
    - Declare a double variable called rate and set to 0.05
    - Print out table headers with justification (tabs)
    - Add a for loop to calculate amount on deposit for each of ten years
        - Declare and set control variable as 1
        - Set looping condition as year less than or equal to 10
        - Preincrement the year
        - Declare double variable amount and set to the result of multiplying principal times (1 * rate) ^ year
        - Display the year and the amount

### Demo 3 do…while iteration

- Create a new file called DoWhileTest.java
- In this file, create a class named DoWhileTest
- Add a main method
- In the main method
    - Declare int variable counter and set to 1
    - Write a do…while statement
        - Print counter value
        - Pre-increment counter
        - Check if counter is less than or equal to 10 to do another iteration
    - Print out an empty line

### Demo 4 Calculating letter grades with switch statement

- Create a new file called LetterGrades.java
- In this file, create a class named LetterGrades
- Add a main method
- In the main method
    - Declare the following int variables, and set all to 0
        - Total which will store the sum of grades
        - gradeCounter which will store number of grades entered
        - aCount which will store count of A grades
        - bCount which will store count of B grades
        - cCount which will store count of C grades
        - dCount which will store count of D grades
        - fCount which will store count of F grades
    - Create scanner object
    - Prompt user to enter grades in the range of 0 to 100
    - Create a while loop, checking that there's next input
        - Declare int variable grade and store nextInt() input
        - Add grade to total
        - Pre-increment gradeCounter
        - Add a switch statement that verifies the value of (grade/10)
            - If 9 then do nothing
            - If 10 then pre-increment aCount and break
            - If 8 then pre-increment bCount and break
            - If 7 then pre-increment cCount and break
            - If 6 then pre-increment dCount and break
            - By default pre-increment fCount and break
        - Print out grade report
            - If gradeCounter is not 0
                - Calculate class average
                - Print out class average
            - Print out all grades and their corresponding count

### Demo 5 Break and Continue Test

- Create a new file called BreakTest.java
- In this file, create a class named BreakTest
- Add a main method
- In the main method
    - Declare an int variable called count
    - Add a for loop
        - Initialize count to 1
        - Set looping condition to count less than or equal to 10
        - Increment count
        - Check if count is 5
            - Terminate loop using break
        - Print out count value
    - Print out count value
- Create a new file called ContinueTest.java
- In this file, create a class named ContinueTest
- Add a main method
- In the main method
    - Declare an int variable called count
    - Add a for loop
        - Initialize count to 1
        - Set looping condition to count less than or equal to 10
        - Increment count
        - Check if count is 5
            - Continue loop using continue
        - Print out count value
    - Print out count value