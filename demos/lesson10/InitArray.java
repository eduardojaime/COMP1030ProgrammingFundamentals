public class InitArray {
    public static void main(String[] args) {
        // declare an array of int with 10 positions
        int[] arr1 = new int[10]; // this creates a list of 10 numbers, all default to 0
        // { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }
        System.out.printf("%s%8s%n", "Index", "Value");
        // output each element in the console
        // i <= (arr1.length-1)
        // i < 10 << not a best practice
        for (int i = 0; i < arr1.length; i++) {
            // print index and value
            System.out.printf("%5d%8d%n", i, arr1[i]);
        }

        System.out.println(); // prints empty line

        // declare and initialize array with custom values
        int[] arr2 = { 10, 20, 30, 40, 50 }; // initialize with 5 elements
        System.out.printf("%s%8s%n", "Index", "Value");
        for (int i = 0; i < arr2.length; i++) {
            // print index and value
            System.out.printf("%5d%8d%n", i, arr2[i]);
        }

        System.out.println(); // prints empty line

        // best practice: use a constant to define array sizes
        final int ARRAY_LENGTH = 10; // constants are named in all uppercase
        // declare
        int[] arr3 = new int[ARRAY_LENGTH]; // 10 positions
        // calculate values
        for (int i = 0; i < arr3.length; i++) { // i is for index
            arr3[i] = 2 + 2 * i;
        }
        // print out values
        System.out.printf("%s%8s%n", "Index", "Value");
        for (int i = 0; i < arr3.length; i++) {
            // print index and value
            System.out.printf("%5d%8d%n", i, arr3[i]);
        }

        // strings as arrays
        // string = char[]
        String title = "TOP GUN MAVERICK"; // 16 CHARS including spaces
        char[] arr4 = title.toCharArray(); // use this line to convert string to char array
        for (int i = 0; i < arr4.length; i++) {
            System.out.println(arr4[i]);
            arr4[i] = 'X'; 
            System.out.println(arr4[i]);
        }
    }
}