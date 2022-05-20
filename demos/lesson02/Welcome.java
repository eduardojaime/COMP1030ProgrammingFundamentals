// Basic program that prints text
// Every program in Java is represented by a class with a main method
// this is a single line comment
public class Welcome {
    // Java is case sensitive
    // these two are different
    String welcomeMessage = "A";
    String WelcomeMessage = "B";

    /**
     * main is the method that is executed when Welcome runs
     * 
     * @param args is a list of strings
     */
    public static void main(String[] args) {
        // Use built-in object and method to print a line of text
        System.out.println("Welcome to Java Programming!");
        /*
         * This is a multiline comment
         * you can add as many lines as you want
         */
        System.out.println("Java is a great language to learn!");
        System.out.println("\"Show me the money\" \n --Eduardo 1998");
        System.out.printf("%s%n%s%n", "Hi again!", "This text is formatted");
    }
}
