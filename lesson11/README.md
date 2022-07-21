# Instructions

### Demo 1 Passing arrays and individual array elements to methods
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

### Demo 2 Declaring and Initializing two-dimensional arrays
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

### Demo 3 Array class methods for array manipulation
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

### Demo 4 Finding the maximum value of three double parameters
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