public class Time2Test {
    public static void main(String[] args) {
        // having only one constructor forces the user to enter all parameters
        Time2 myTime1 = new Time2(12, 30, 00);
        System.out.println(myTime1.toUniversalFormat()); // 12:30:00
        // multiple constructors allow user to instantiate objects in different ways
        Time2 myTime2 = new Time2(); 
        System.out.println(myTime2.toUniversalFormat()); // 00:00:00

        Time2 myTime3 = new Time2(13);
        System.out.println(myTime3.toUniversalFormat()); // 13:00:00

        Time2 myTime4 = new Time2(14,30);
        System.out.println(myTime4.toUniversalFormat()); // 14:30:00
    }
}
