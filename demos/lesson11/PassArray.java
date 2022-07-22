public class PassArray {
    public static void main(String[] args) {
        int[] array = { 1, 2, 3, 4, 5 };

        System.out.println("Effects of passing reference to entire array");
        System.out.println("The values of the original array are: ");
        // output the values
        for(int value: array) {
            System.out.printf("    %d", value);
        }

        System.out.println("\nThe values of the modified array are:");
        modifyArray(array);

        // output the values
        for(int value: array) {
            System.out.printf("    %d", value);
        }

        System.out.println("\nThe effects of passing array element BEFORE modifying it");
        System.out.println(array[3]);

        modifyElement(array[3]);

        System.out.println("The effects of passing array element AFTER modifying it");
        System.out.println(array[3]);
    }

    // multiply each element of the array by 2
    public static void modifyArray(int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            arr[i] *= 2; // similar to arr[i] = arr[i] * 2
        }
    }

    // multiply a single element by 2
    public static void modifyElement(int element) {
        element *= 2;
        System.out.println("Value of element in modifyElement: " + element);
    }
}