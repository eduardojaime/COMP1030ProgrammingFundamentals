public class EnhancedForTest {
    public static void main(String[] args) {
        int[] arr1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int total = 0;

        // 1) sum totals with a standard for loop
        // use when you know or can know how many elements come in the array
        // or maybe you have a limit
        // iterate and add to total
        for (int i = 0; i < arr1.length; i++) {
            // use shorthand += to add to total
            total += arr1[i]; // add value in position i
        }
        // print out result
        System.out.println("Total with for loop " + total);

        // 2) foreach loop
        // use this when you are going to iterate through ALL elements in the array
        // also when you don't know exactly how many elements there are
        // or maybe you just don't care/need to worry about indexes
        total = 0; //reset
        for (int element : arr1) { // means for each element in the array...
            total += element;
        }
        System.out.println("Total with foreach loop " + total);

    }
}
