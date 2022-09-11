# Instructions

### Part 1 Creating a new program

- Create a new folder called lesson01
- Inside of this folder create another one called basicprogram
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Open Program.cs and examine its contents

### Part 2 Using Data Types in your program

- In the main method under Program.cs
    - Declare a variable for each of the following types
        - Byte
        - Int
        - Decimal
        - String
        - Boolean
        - DateTime
    - Assign a value to each variable created above
    - Print each value to the console
        - Use the built-in ToString() method of each type to convert it's value to string
    - Declare three more int variables and assign a value
        - a = 10
        - b = 100
        - result = 0
    - Review the basic mathematical operators and perform each operation storing the value in result
    - Print the value of result after each operation
        - Addition
        - Subtraction
        - Multiplication
        - Division
    - Try converting int to byte
    - Try converting byte to int
    - Utilize the following string methods
        - Length
        - ToUpper
        - ToLower
        - Concat
        - StartsWith
        - EndsWith
        - Contains
        - Trim
        - Replace
        - Substring
    
### Part 3 Making a program that simulates throwing dice

- Create a new folder called lesson01
- Inside of this folder create another one called throwdice
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - INPUT Step
        - Declare two long and one string variables
            - Long are numeric values which will store the result of throwing the dice
        - Print a welcome message to the user
        - Print an instruction message to the user
        - Retrieve input from command line by calling Console.ReadLine()
    - PROCESS Step
        - Use if-else statement to exit or continue
        - If continue
            - Print informative message to the user
            - Create an instance of Random object
            - Call NextInt64() method twice and store the result in each long variable accordingly
                - Pass bound parameters 1 (inclusive) and 7 (exclusive) to generate a number from 1 to 6
            - Print result message using string interpolation
        - Else
            - Print result message displaying goodbye
    - OUTPUT Step
        - Print the generated result
