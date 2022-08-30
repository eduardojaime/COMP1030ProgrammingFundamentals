// use break statement to exit a for statement
public class BreakTest {
    public static void main(String[] args) {
        int count; // declare outside so it can be used outside the for loop
        // loop 10 times
        for (count = 1; count<=10; count++) {
            if (count == 5) {
                break;
            }
            System.out.printf("%d ", count);
        }

        System.out.printf("%nBroke out of loop at count == %d%n", count);
    }
}
