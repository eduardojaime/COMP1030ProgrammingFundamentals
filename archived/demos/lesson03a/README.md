# Instructions

### Part 1 Making a program that simulates throwing dice

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

### Part 2 	

- Create a new folder inside lesson01 called grades
- Open with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - INPUT Step
        - Declare a char variable named grade and assign value of 'B'
    - PROCESS Step
        - Use a switch statement to determine what to do with grade
        - In case it's an A 
            - Show 'Excellent job!'
            - Add a break instruction
        - In case it's a B or a C 
            - Show 'Well done!'
            - Add a break instruction
        - In case it's a D 
            - Show 'You passed…'
            - Add a break instruction
        - In case it's a F
            - Show 'Better try again'
            - Add a break instruction
        - As a default case
            - Show 'Invalid Grade'
            - Add a break instruction