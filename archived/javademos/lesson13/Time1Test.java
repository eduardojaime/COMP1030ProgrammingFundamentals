public class Time1Test {
    public static void main(String[] args) {
        // instantiate a time object
        Time1 myTime = new Time1();
        // encapsulation > private instance variables cannot be accessed from outside
        // myTime.hour = 2; // breaks

        // print time
        System.out.println("Time right after object is created");
        System.out.println("Universal: " + myTime.toUniversalFormat()); // 00:00:00
        System.out.println("Standard: " + myTime.toStandardFormat()); // 0:00:00 AM
        System.out.println(); // print empty line

        // set time
        myTime.setTime(18, 45, 0);

        // print time again
        System.out.println("Time right after setting time to 18:45:00");
        System.out.println("Universal: " + myTime.toUniversalFormat()); // 18:45:00
        System.out.println("Standard: " + myTime.toStandardFormat()); // 6:45:00 PM
        System.out.println(); // print empty line

        // use try catch blocks to enclose code that might fail
        try {
            // attempt to set time with invalid values
            myTime.setTime(40, 90, 75); // ONLY 24 HOURS IN THE DAY
        } catch (IllegalArgumentException e) {
            // e will contain info about the error
            System.out.println("Oops! there was an error in the program: " + e.getMessage());
        }

        // print time again
        System.out.println("Time right after setting time to 40:90:75");
        System.out.println("Universal: " + myTime.toUniversalFormat()); // BREAK
        System.out.println("Standard: " + myTime.toStandardFormat()); // BREAK
        System.out.println(); // print empty line
    }
}
