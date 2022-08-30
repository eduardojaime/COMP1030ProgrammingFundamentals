public class Interest {
    public static void main(String[] args) {
        double principal = 1000.0; // 0.0 is a double, initial amount
        double rate = 0.05; // interest rate

        // display headers with tabulation
        // %20 is a tab character
        System.out.printf("%s%20s%n", "Year", "Amount on deposit");

        // calculate amount on deposit for each of ten years
        for (int year = 1; year <= 10; ++year) {
            // use formula a = p * (1 + r) ^ n
            double amount = principal * Math.pow((1.0 + rate), year);
            System.out.printf("%4d%,20.2f%n", year, amount);
        }
    }
}
