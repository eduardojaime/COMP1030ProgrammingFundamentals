# Instructions

### Demo 1 Declaring and Initializing Arrays
- Create a new file called InitArray1.java
- In this file, create a class named InitArray1
- Add a main method
    - Declare an int array variable 
    - Initialize the array object with a length of 10
    - Print a line in the console to display column headings
    - Use a for loop to iterate through the positions of the array and print counter, and value in the corresponding position in the array
- Create a new file called InitArray2.java
- In this file, create a class named InitArray2
- Add a main method
    - Declare an int array variable 
    - Initialize the array object by providing a list of values
        - List must be a enclosed in curly brackets
        - Each element is separate by a comma
        - Initializer list specifies the initial value for each element position
    - Print a line in the console to display column headings
    - Use a for loop to iterate through the positions of the array and print counter, and value in the corresponding position in the array
- Create a new file called InitArray3.java
- In this file, create a class named InitArray3
- Add a main method
    - Declare a final int variable and set value to 10
    - Declare an int array variable 
    - Initialize the array object and use the final int variable declared above to set the length
    - Use a for loop to iterate through the positions of the array
        - Each time, set the value of the corresponding position to 2 + 2 * counter
    - Print a line in the console to display column headings
    - Use a for loop to iterate through the positions of the array and print counter, and value in the corresponding position in the array

### Demo 2 Calculating the sum of the elements of an array
- Create a new file called SumArray.java
- In this file, create a class named SumArray
- Add a main method
    - Declare and initialize an int array of 10 elements
    - Declare an int variable named total and set value to 0, this will be used to keep sum amount
    - Use a for loop to iterate through the positions of the array
        - Each time, add the value in the current position of the array to the total
    - Print the total

### Demo 3 Card Shuffling and Dealing Simulation
- Create a new file called Card.java
- In this file, create a class named Card
    - Add two instance variables:
        - Face of type string and final
        - Suit of type string and final
    - Add a two-argument constructor that initializes card's face and suit
    - Add a helper method named ToString() which returns a string
        - Return the concatenation of face and suit
- Create a new file called DeckOfCards.java
- In this file, create a class named DeckOfCards
    - Add two instance variables:
        - Secure random object
        - Constant containing number of cards with value set to 52
        - Array of cards named Deck and initialized to an array of 52 cards
        - Int variable named current card with value set to 0 which will keep the index of the card that's currently being dealt
    - Add a constructor method without parameters and returning void
        - Declare an array of strings which contains face values: Ace to King
        - Declare an array of suits which contains suit values: Hearts, Diamonds, Clubs, and Spades
        - Use a for loop to iterate through each position of the deck array
            - Each time, generate a new card object and set suit and face value randomly
                - faces[count % 13]
                - suits[count / 13]
            - Store this card object in the corresponding position of the deck array
    - Add a helper method called Shuffle without parameters
        - Set current card value to 0, this means the card at the very top of the deck is being picked
        - Use a for loop to iterate through each position of the deck array
            - Each time, generate a random number between 0 and 51
            - Swap current card with the card at the randomly generated position
    - Add a helper method named DealCard without parameters and returning a Card object
        - Using and if statement
            - Determine whether Cards remain to be dealt
                - In which case, return the card from the deck at the current position
                - Increase the current card counter variable by 1
            - If there are no more cards
                - Deck is considered empty when counter reached 52
                - Return null
- Create a new file called DeckOfCardsTest.java
- In this file, create a class named DeckOfCardsTest
- Add a main method
    - Declare and initialize an object of type DeckOfCards
    - Call the shuffle method
    - Use a for each loop to iterate 52 times
        - Print all 52 Cards in the order in which they are dealt
        - Call dealCard method
        - Print card value
        - Output a newline after every fourth card

### Demo 4 Finding the maximum value of three double parameters
- Create a new file called EnhancedForTest.java
- In this file, create a class named EnhancedForTest
- Add a main method
    - Declare and initialize an int array of 10 elements
    - Declare an int variable named total and set value to 0, this will be used to keep sum amount
    - Use a foreach loop to iterate through each element in the array
        - Note the different syntax
        - There's no need to keep a counter in the foreach loop
        - Each time, add the value in the current position of the array to the total
    - Print the total

### Demo 5 Passing arrays and individual array elements to methods
- Create a new file called PassArray.java
- In this file, create a class named PassArray
- Add a helper method named modifyArray which accepts an array of integers as parameter and returns void
    - Use a for loop to iterate through the positions of the array
        - Each time, set the value of the corresponding position to value * 2 
- Add a helper method named modifyElement which accepts an integer value as parameter and returns void
    - Set the value of the parameter to value * 2 
    - Print the modified value
- Add a main method
    - Declare and initialize an int array variable of 5 elements
    - Use a foreach loop to print the original array elements
    - Call modifyArray and pass the array as parameter
    - Use a foreach loop to print the modified array elements
    - Call modifyElement and pass a valid position as parameter
    - Print the element at the specified position in the array to verify that the value was modified

### Demo 6 Declaring and Initializing two-dimensional arrays
- Create a new file called InitArray.java
- In this file, create a class named InitArray
- Add a helper method named outputArray which access a multi-dimensional array as parameter and returns void
    - Use a for loop to iterate through the rows of the array
        - Use a for loop to iterate through the columns of the array
            - Print the value at row,col position
        - Print a new line
- Add a main method
    - Declare and initialize an int array variable of 3 elements in two rows
    - Declare and initialize an int array variable of variable elements in 3 rows
    - Call outputArray and pass the first array as parameter to view its values
    - Call outputArray and pass the second array as parameter to view its values

### Demo 7 Array class methods for array manipulation
- Create a new file called ArrayManipulations.java
- In this file, create a class named ArrayManipulations
- Add a main method
    - Declare and initialize a double array variable of 5 elements
    - Call Array.sort and pass the array as parameter
    - Use a foreach loop to print each element of the array
    - Declare and initialize an int array variable of 10 empty positions
    - Call Array.fill and pass the array and the number 7 as parameter
    - Use a foreach loop to print each element of the array
    - Declare and initialize an int array variable of 5 elements
    - Declare and initialize an int array variable of 5 empty positions
    - Call System.arrayCopy and pass both arrays as parameters
    - Use a foreach loop to print each element of the first array
    - Use a foreach loop to print each element of the second array
    - Call Array.equals to compare both arrays for equality
    - Call Array.binarySearch and pass the first array and a numeric value to perform earch
        - If found, this method returns the position at which the value was found
        - If this position is greater than or equal to 0 then a value was found
            - Print the position at which the value was found
        - If this position is -1 then no value was found


### Demo 8 Finding the maximum value of three double parameters
- Create a new file called ArrayListCollection.java
- In this file, create a class named ArrayListCollection
- Add a main method
    - Declare and initialize an object of type ArrayList of strings
    - Call add two times to add values to this array
    - Use a for loop to display the elements in the list
        - Use a counter variable
        - Call the size() method to obtain the current length of the array
        - Call get(pos) to retrieve the string value at that position
    - Call add two times to add more values to this array
    - Use a for loop to display the elements in the list
        - Use a counter variable
        - Call the size() method to obtain the current length of the array
        - Call get(pos) to retrieve the string value at that position
    - Call remove and pass a string value as parameter to remove the first appearance of that value in the array
    - Use a for loop to display the elements in the list
        - Use a counter variable
        - Call the size() method to obtain the current length of the array
        - Call get(pos) to retrieve the string value at that position