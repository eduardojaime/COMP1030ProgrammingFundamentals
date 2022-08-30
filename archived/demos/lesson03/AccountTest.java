import java.util.Scanner;

public class AccountTest {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        // Create object based on account class
        // Account myAccount = new Account(); // standard way of creating an object
        // Account myAccount = new Account("Default");
        Account myAccount = new Account("Default", 100);
        // print initial value of name
        System.out.printf("Initial name is %s%n", myAccount.getName());
        System.out.printf("%s balance: $%.2f%n", myAccount.getName(), myAccount.getBalance());

        // modify value of name based on user input
        System.out.println("Enter a new name for the account:");
        String name = input.nextLine();
        myAccount.setName(name); // pass the value obtained from the user to overwrite initial name
        System.out.println(("Enter a deposit amount:"));
        double depositAmt = input.nextDouble();
        myAccount.deposit(depositAmt);
        System.out.println(); // prints a blank line

        // print mofidied value of name
        System.out.printf("Modified name is %s%n", myAccount.getName());
        System.out.printf("%s balance: $%.2f%n", myAccount.getName(), myAccount.getBalance());
    }
}
