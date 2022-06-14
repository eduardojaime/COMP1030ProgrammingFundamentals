// program counts from 1 to 10 using do...while
public class DoWhileTest {
    public static void main(String[] args) {
        int counter = 1;

        do {
            // this will execute at least once
            System.out.printf("%d ", counter);
            ++counter;
        } while (counter <= 10);

        System.out.println();// prints empty line
    }
}
