import java.util.Arrays;

public class ArrayManipulations {
    public static void main(String[] args) {
        // sort an array in ascending order
        int[] intArray = { 3, 1, 10, 6, 5, 9 };
        Arrays.sort(intArray);
        displayArray(intArray, "Sorting values");

        // fill 10 element array with 7s
        int[] filledArray = new int[10]; // default all values will be 0
        Arrays.fill(filledArray, 7);
        displayArray(filledArray, "Filling array with number 7s");

        // copy arr1 to arr2
        int[] arr1 = {1,2,3,4,5,6};
        int[] arr2 = new int[arr1.length]; // both arrays have the same length
        System.arraycopy(arr1, 0, arr2, 0, arr1.length);
        displayArray(arr1, "Source Array");
        displayArray(arr2, "Destination Array");

        // compare arr1 and arr2 for equality
        boolean areArraysEqual = Arrays.equals(arr1, arr2);
        System.out.println("Are arrays arr1 and arr2 equal? " + areArraysEqual);

        // search for a value
        int pos = Arrays.binarySearch(arr1, 5);
        System.out.println("5 is in position " + pos); // returns index position of the value in the array if found
        
        pos = Arrays.binarySearch(arr1, 20);
        System.out.println("20 is in position " + pos); // returns negative number if not found


    }

    public static void displayArray(int[] arr, String description) {
        System.out.printf("%s: ", description);
        for (int elem : arr) {
            System.out.printf("%d ", elem);
        }
        System.out.println("");
    }
}
