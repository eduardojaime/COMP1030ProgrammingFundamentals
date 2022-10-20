### Demo 1 Creating a basic game loop program structure

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