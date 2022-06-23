# Instructions

### Demo 1 Finding the maximum value of three double parameters
- Create a new file called MaximumFinder.java
- In this file, create a class named MaximumFinder
- Add a static method named maximum
    - Inside the parenthesis, enter a list of parameters separated by comma
    - Left side of the parameter is the data type
    - Right side of the parameter is the name
- In the maximum method
    - Declare a double variable named maximumValue and set to X
    - Use if-else logic to determine if Y or Z are greater than X
        - Override maximumValue accordingly
- Add a main method
- In the main method
    - Create a Scanner object to take input from user
    - Print instructions in the console, prompt user to enter three values separated by spaces
    - Declare three double variables
        - Assign each value received from the console to each variable
    - Declare a variable named result to store the value of calling maximum and passing the three variables from the step above as parameters
    - Display the result in the console
    
### Demo 2 Generating Random Numbers
- Create a new file called RandomNumbers.java
- In this file, create a class named RandomNumbers
- Import java.security.secureRandom at the top if your file
- Add a main method
- In the main method
    - Create a SecureRandom object named randomNumbers
    - Add a for loop and iterate 20 times
        - Each time declare an int variable named face to store the result of calling randomNumbers.nextInt(6) + 1 to pick a random integer from 1 to 6
        - Print out the generated value in the same line (don't use newlines %n)
        - If counter is divisible by 5, start a new line of output by calling System.out.printl()

### Demo 3 Rolling a six-sided die 60,000 times
- Create a new file called RollDie.java
- In this file, create a class named RollDie
- Import java.security.secureRandom at the top if your file
- Add a main method
- In the main method
    - Create a SecureRandom object named randomNumbers
    - Declare 6 variables to keep count of frequency of 1s, 2s, 3s, 4s, 5s, and 6s rolled
        - Set all to 0
    - Add a for loop and iterate 60,000 times
        - Each time declare an int variable named face to store the result of calling randomNumbers.nextInt(6) + 1 to pick a random integer from 1 to 6
        - Use a switch statement to determine which counter to increment
            - If face is then increment counter for 1s
            - Do the same for 2s, 3s, 4s, 5s, and 6s
    - Print out the frequency value for each variable

### Demo 4 Demonstrating how scope in a class
- Create a new file called Scope.java
- In this file, create a class named Scope
    - Declare a private static int variable named X and set to 1
        - Fields are accessible to all methods of this class
- Add a new method named useLocalVariable without any parameters
- In this method
    - Declare an int variable named x and set to 25
        - This is initialized each time the method is called
    - Print out the value of decreasing x by 1
    - Print out the value of x
- Add a new method named useField without any parameters
- In this method
    - Print out the value of decreasing x by 1
    - Print out the value of x
- Add a main method
- In the main method
    - Declare an int variable named x and set to 5
        - Method's local variable x shadows field x
    - Print out value of x
    - Call useLocalVariable()
    - Call useField()
    - Call useLocalVariable()
    - Call useField()
    - Print out the value of X
    
### Demo 5 Overloading Methods
- Create a new file called MethodOverload.java
- In this file, create a class named MethodOverload
- Add a new static method name square which takes an int parameter
- In this method
    - Print out the value of the parameter
    - Return the result of multiplying the parameter value times itself
- Add a new static method name square which takes a double parameter
- In this method
    - Print out the value of the parameter
    - Return the result of multiplying the parameter value times itself
- Add a main method
- In the main method
    - Print out the result of calling square with one int parameter
    - Print out the result of calling square with one double parameter