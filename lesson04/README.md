# Instructions

### Demo 1 Showing examples of loop structures and use cases

- Create a new folder called lesson01
- Inside of this folder create another one called loopstructures
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - While loops should be used when we don't know how many iterations we have to perform
        - Declare a Random variable named myRandom and assign an instance of the Random class
        - Declare an int variable named counter1 and assign the result of calling Next(1, 11) method in myRandom
            - This will be used in the while example
        - Declare an int variable named counter2 and assign the result of calling Next(1, 11) method in myRandom
            - This will be used in the do-while example
        - Start a while loop
            - Add condition to check that counter1 is less than 10
            - Inside the while block:
                - Print current value of counter1
                - Increase counter1 by 1
        - Start a do-while loop
            - Inside the while block:
                - Print current value of counter2
                - Increase counter2 by 1
            - Add condition to check that counter2 is less than 10
    - For loops should be used when we know exactly how many iterations we have to perform
        - Start a for loop
            - Declare an int variable named i and set value to 1
            - Add condition to check that i is less than or equal to 10
            - Add expression to increment i by 1
            - Inside the for block:
                - Use Console.Write to print value of i and a space in the same line
            - Print an empty line
        - Foreach loops require a list so declare an array of string named daysOfWeek
        - Initialize the array by passing a list of string values corresponding to each day of the week
        - Start a foreach loop
            - Iterate based on a string variable named day
            - Inside the foreach block:
                - Print the value of day for the current iteration

### Demo 2 Showing examples of loop control

- Create a new folder called lesson01
- Inside of this folder create another one called loopcontrol
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - The following code is intended to print only odd numbers
    - Start a for loop
        - Declare an int variable named i and set value to 1
        - Add condition to check that i is less than or equal to 100
        - Add expression to increment i by 1
        - Inside the for block:
            - Declare an int variable named remainder
            - Set its value to the result of calculating i % 2 (reminder operator)
            - Start an if statement
                - Check if remainder is 0
                - Inside the if block, use the break statement
            - Use Console.Writeline to print value of i as a string
        - Print an empty line
    - Run the program by using the dotnet run command in the terminal
    - Was it the expected outcome?
        - Break stops the execution here and does not continue
    - Go back to the if block
        - Comment out the break statement
        - Add a continue statement
    - Run the program by using the dotnet run command in the terminal
    - Was it the expected outcome?
        - Continue skips the rest of the code in the for block and carries on with the next iteration

### Demo 3 Creating a program that allows users to order pizzas

- Create a new folder called lesson01
- Inside of this folder create another one called pizzapicker
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - Print a welcome message
    - We want to keep count of how many pizzas of each type are ordered
        - Declare an int variable named pepperoniCount and set its value to 0
        - Declare an int variable named hawaiianCount and set its value to 0
        - Declare an int variable named vegetarianCount and set its value to 0
        - Declare an int variable named cheeseCount and set its value to 0
    - Declare a boolean variable named addPizza and set its value to true
    - Start a while loop
        - Add a condition to check whether addPizza is true
        - Inside the while block
            - Print a message to show the pizza options to the user
                - 1 for Pepperoni
                - 2 for Hawaiian
                - 3 for Vegetarian
                - 4 for Cheese and Tomato
                - 0 to exit
            - Retrieve the user option by using Console.ReadKey()
            - Add a nested if statement to increment each count variable accordingly
            - Inside the else statement for when user enters any other value that doesn't match our options, set addPizza to false
            - Declare a string variable named message and write the message template that will be shown to the user using a literal string ('@')
            - Call string.Replace 4 times and replace the COUNT template string with the actual value of the corresponding count
            - Show message to user
    - Run the program by using the dotnet run command in the terminal
    - Was it the expected outcome?
        - We need to continue asking the user if they want another pizza and add that to the order
    - Start a while loop right before the options string variable
        - Enclose all code after wards inside the while block
        - Add a condition to check that addPizza is still true

### Demo 4 Creating a basic game loop program structure

- Create a new folder called lesson01
- Inside of this folder create another one called gameloop
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - Declare a boolean variable named keepPlaying and set its value to true
    - Declare a char variable named selection and set its value to true
    - Start a do-while loop, since you want to play the game at least once
        - Inside the do block
            - Print a message to simulate user is playing the game
            - Print a message to ask the user whether they want to play another round
            - Retrieve the user option by using Console.ReadKey()
            - If selection is y or Y set keepPlaying to true
            - Else set keepPlaying to false
        - Add a condition in the while section to check if keepPlaying is true to do another iteration
        - Print a thank you message