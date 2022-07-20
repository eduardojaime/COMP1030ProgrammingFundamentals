public class SumArray {
    public static void main(String[] args) {
        // declare and initialize array with elements
        int[] arr1 = { 10, 20, 30, 40, 50 };
        int total = 0;
        // iterate and add to total
        for (int i = 0; i < arr1.length; i++) {
            // use shorthand += to add to total
            total += arr1[i]; // add value in position i
        }
        // print out result
        System.out.println(total);
    }
}
