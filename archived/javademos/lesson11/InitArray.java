public class InitArray {
    public static void main(String[] args) {
        int[][] array1 = {
                { 1, 2, 3 },
                { 4, 5, 6 }
        };
        int[][] array2 = {
                { 1, 2 }, // row = 0, length = 2
                { 3 }, // row = 1, length = 1
                { 4, 5, 6 } // row = 2, length = 3
        };
        System.out.println("Values of arr1 by row");
        outputArray(array1);
        
        System.out.println("Values of arr2 by row");
        outputArray(array2);
    }

    public static void outputArray(int[][] arr) {
        // for loop for rows
        for (int row = 0; row < arr.length; row++) {
            // inner for loop for colums
            for (int col = 0; col < arr[row].length; col++) {
                int element = arr[row][col]; // similar to coordinates
                System.out.printf("%d  ", element);
            }
            System.out.println("");
        }
    }
}
