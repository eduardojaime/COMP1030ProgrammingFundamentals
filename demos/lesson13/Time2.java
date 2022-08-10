public class Time2 {
    // instance variables - private (encapsulation)
    private int hour; // 0 to 23
    private int minute; // 0 to 59
    private int second; // 0 to 59

    // overloaded constructors
    public Time2() {
        // assume all values are 0
        // reuse constructors
        this(0, 0, 0);
    }

    public Time2(int hour) {
        this(hour, 0, 0);
    }

    public Time2(int hour, int minute) {
        this(hour, minute, 0);
    }

    // constructor with 3 parameters
    public Time2(int hour, int minute, int second) {
        // validation
        if (hour < 0 || hour > 23) {
            throw new IllegalArgumentException("ERROR: hour must be a value between 0 and 23");
        }
        if (minute < 0 || minute > 59){
            throw new IllegalArgumentException("ERROR: minute must be a value between 0 and 59");
        }
        if (second < 0 || second > 59){
            throw new IllegalArgumentException("ERROR: second must be a value between 0 and 59");
        }

        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    // SET TIME
    public void setTime(int hour, int minute, int second) {
        // keyword 'this' refers to variables in this class
        // check if my parameters are in the right range
        // check for invalid ranges
        // since I'm not using 'this' then these below refer to the parameters
        if (hour < 0 || hour > 23 || minute < 0 || minute > 59 || second < 0 || second > 59) {
            // break execution using 'throw' keyword
            // specific exception
            throw new IllegalArgumentException("ERROR: invalid value for hour, minute or second");
            // OR generic exception
            // throw new Exception("ERROR: invalid value for hour, minute or second")
        }

        // at this point all values should be valid
        // use this to refer to instance variables or methods within this class
        // instance variable = parameter value
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    // RETURN TIME IN UNIVERSAL FORMAT (HH:MM:SS)
    public String toUniversalFormat() {
        return String.format("%02d:%02d:%02d", this.hour, this.minute, this.second);
    }

    // RETURN TIME IN STANDARD FORMAT (HH:MM:SS AM or PM)
    public String toStandardFormat() {
        return String.format("%d:%02d:%02d %s",
                ((this.hour == 0 || this.hour == 12) ? 12 : this.hour % 12), // hour coverts 18 to 6
                this.minute, // minute
                this.second, // second
                (this.hour < 12 ? "AM" : "PM") // am or pm > ternary operatior condition ? value if true : value if
                                               // false
        );
    }
}
