// Summing integers with the for loop
public class Sum {
    public static void main(String[] args) {
        int total = 0;

        for (int number = 2; number <= 20; number += 2) {
            total += number; // total = total + number;
        } 

        System.out.printf("Sum is %d%n", total);
    }
}