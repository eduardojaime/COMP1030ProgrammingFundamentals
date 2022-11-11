# Instructions

### Part 1 Coding a Black Jack Game

- Create a new folder called lesson09
- Open this folder with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - Modify the default Console.WriteLine() message to read "Hello, BlackJack!"
    - Declare and initialize the following variables that affect the score
        - A Random object to generate a value from 1 to 12 which represents a card dealt to the user
        - An int named currentCard to store the card that will be dealt to the user
        - An int named playerTotal to store the player's score
        - An int named computerTotal to store the computer's score
    - Declare and initialize the following variables that affect the inner game play
        - A string named choiceCard to store whether the user wants to receive another card (Y/N)
        - A boolean flag named anotherCard to store whether the user wants to receive another card (true/false)
    - Declare and initialize the following variables that affect the entire game
        - A string named choiceGame to store whether the user wants to play again (Y/N)
        - A boolean flag named anotherGame to store whether the user wants to play again (true/false)
    - For the main game loop, start a while loop and check whether the anotherGame flag is set to true
        - As a first step, setup/reset the game
            - Set all score variables to 0
            - Set all flags to true
        - For the inner game loop which is the user playing, start another while loop and check whether the anotherCard flag is set to true
            - Generate a random number from 1 to 12 and store in currentCard
            - Add the currentCard value to playerTotal
            - Print out the current player score to the console
            - Use if-else statements to verify the following conditions
                - Option to keep playing when total is less than 21, and if true
                    - Print a message asking whether the user wants another card
                    - Store the response from the user in choiceCard
                    - If "Y" then set another card to true
                    - Else set another card to false
                    - Print a new line
                - Instant win when the user scores exactly 21
                    - Print a celebratory message in the console
                    - Set anotherCard to false
                    - Print a new line
                - Instant lose when the user scores more than 21
                    - Print an oops message in the console
                    - Set anotherCard to false
                    - Print a new line
            - This ends the inner game loop for the user
        - For the computer to play
            - Generate a random number from 15 to 21
            - Store this value in computerTotal
            - Print the computer score
            - Print a new line
        - Check the result of the game
            - If player score is exactly 21 print out Player Won!
            - If player score is greater than computer score print out Player Won!
            - If player score is the same as computer score print out It's a Tie!
            - If player score is greater than 21 print out Player Lost!
            - For anything else print out Player Lost!
            - Print out the final scores for both player and computer
            - Print a new line
    - Print a message asking whether the user wants to play again
    - Store the response from the user in choiceGame
    - If "Y" then set another game to true
    - Else set another game to false
    - Print a new line

### Part 2 Using methods to simplify programs

- Analyze Program.cs
    - What pieces of code seem duplicate or at least very similar?
    - What pieces of code belong to the same "action"?
        - Reset Game
        - Play as the User
        - Play as the Computer
        - Determine the result of the game
- Outside the Main method()
    - Write a method named ComputerPlays
        - This method represents the computer playing
        - Make it private static
        - Return type as int since we'll return the generated score
        - It needs to receive a Random object as parameter
        - Copy over the code that generates the computer's score
            - Make computerTotal a local method variable
            - Return computerTotal at the end of the method
        - Call ComputerPlays instead the lines of code copied over, pass the Random object as argument
    - Write a method named ResetGame
        - This method resets all variables at the beginning of the game to their default values
        - Make it private static
        - Return type void (nothing)
        - Copy over the code that resets all variables to their default values just after entering the game loop
        - In order for this method to work, it must accept all these variables as parameters
            - Use the 'ref' keyword for each parameter in the list to allow the method to modify their values
        - Call this method instead of the lines copied over and pass the corresponding variables as arguments
    - Write a method named ProcessYesNoInput
        - Our main program asks y/n questions to the user and makes a flag true/false accordingly
        - Make it private static
        - Return type void (nothing)
        - In order for this method to work, it needs to accept the following parameters
            - String named message
            - Boolean named anotherOne, marked as 'ref' since we want to modify its value
        - Copy over code that asks user whether they want to play again or get another card
            - We will standardize this method so we can reuse its code
            - Rename choice variable to just choice
            - Rename flag variable to just anotherOne
            - Remove the text from Console.WriteLine and use a string variable named question instead
        - Call this method instead of the lines copied over and pass the corresponding variables as arguments
    - Write a method named InnerPlayerLoop
        - This represents the user playing the game. They might want another card which adds to their score
        - Make it private static
        - Return type void (nothing)
        - In order for this method to work, it needs to accept the following parameters
            - Random object
            - Boolean named anotherCard, marked as 'ref' since we want to modify its value
            - Int named playerTotal, marked as 'ref' since we want to modify its value
        - Copy over the inner game loop (while) and all its contents
        - Notice that methods can call other methods
            - This method calls ProcessYesNoInput()
        - Call this method instead of the lines copied over and pass the corresponding variables as arguments
- Take another look at the Main method, and think about the following questions:
    - How has readability improved? Is it easier to improve the program?
    - If we wanted to make changes to the way we process Y/N inputs. How many methods would we need to modify? Compare that to the initial program.
    - Would another programmer understand our game logic better?