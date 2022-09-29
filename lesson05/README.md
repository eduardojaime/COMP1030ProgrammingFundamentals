# Instructions

### Demo 1 Declaring and Initializing Arrays

- Create a new folder called lesson05
- Inside of this folder create another one called basicarrays
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - Declare an int array variable 
        - Initialize the array with a length of 10
        - Use a for loop to iterate through the positions of the array
            - print counter, and value in the corresponding position in the array to see its default values
    - Declare another int array variable 
        - Initialize the array object by providing a list of values
            - List must be a enclosed in curly brackets
            - Each element is separate by a comma
            - Initializer list specifies the initial value for each element position
        - Use a for loop to iterate through the positions of the array and print counter, and value in the corresponding position in the array
    - Declare another int array variable
        - Initialize the array with a length of 10
        - Use a for loop to iterate through the positions of the array
            - Each time, set the value of the corresponding position to 2 + 2 * counter
        - Use another for loop to iterate through the positions of the array
            - Print counter, and new value in the corresponding position in the array
    - Declare and initialize an int array of 10 elements
        - Declare an int variable named total and set value to 0, this will be used to keep sum amount
        - Use a for loop to iterate through the positions of the array
            - Each time, add the value in the current position of the array to the total
        - Print total
        
### Demo 2 Using an ArrayList to store a list of students

- Create a new folder called lesson05
- Inside of this folder create another one called arraylists
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - Declare an ArrayList variable named studentList and initialize it accordingly
        - For ArrayList to work, make sure to add using System.Collection at the very top of your Program.cs file
    - Declare a bool variable named addAnother and set to true
        - This will be our control variable for the while loop
    - Start a while loop and check the value of addAnother
        - Print a message to the console prompting the user to enter a name
        - Declare a string variable named studentName and use Console.ReadLine() to store input from the user in it
        - Call the Add method of the studentList ArrayList and pass the studentName variable as parameter
            - This will add the new value to the end of the list
            - Note that there's no need to specify index
        - Print a message to the console to ask whether the user wants to enter another name
        - Declare a char variable named selection and retrieve the input from the terminal by calling Console.ReadKey().KeyChar
        - Print an empty line
        - Add an if-else statement
            - Set addAnother to true if input is y or Y
            - Set addAnother to false if otherwise (exit condition is met)
    - Outside of the while loop
        - Use Count attribute from the ArrayList object to print the total number of students in the list
        - Use a foreach loop to print all the names that were added to the list

### Demo 3 Using the System.Array Class to manipulate an Array

- Create a new folder called lesson05
- Inside of this folder create another one called arrayclass
- Open this with VS Code
- Open the terminal and run the following command
    - dotnet new console --use-program-main
- Go to Program.cs > main method
    - Declare an array of int variable named arr1 and initialize to a list of numbers
    - Declare an array of int variable named arr2 and initialize to the same values as arr1
    - Use a foreach loop to print the values in arr1
        - Use Console.Write() to print in the same line
    - Print an empty line after the foreach loop
    - Use the Reverse method in the Array class and pass arr2 as parameter
        - This will reverse the order of the elements in the array
    - Use a foreach loop to print the values in arr2
        - Use Console.Write() to print in the same line
    - Use the Sort method in the Array class and pass arr1 as parameter
        - This will sort the elements in the array
    - Use a foreach loop to print the values in arr1
        - Use Console.Write() to print in the same line

### Demo 4 Debugging

- Place a breakpoint in the line of code that calls Array.Sort(arr1)
- Press F5 to run the program in debugging mode
- Explore the controls to continue the execution line by line