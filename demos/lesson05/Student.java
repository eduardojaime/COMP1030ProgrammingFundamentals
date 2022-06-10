// Class that represents a student
// stores name and average
// has a constructor to initialize name and average
// provides a method to obtain a grade letter based on average value
public class Student {
    private String name; // make private so we can control access to its value
    private double average; // use double for numbers with decimal values

    // constructor that receives two parameters: name and average
    public Student(String name, double average) {
        // initialize private values
        this.name = name;

        // this.average = average; // is this correct? think about possible values: -10,
        // 0, 100
        // use if statement to validate values
        // an average is valid if its value is between 0 and 100
        if (average >= 0.0) {
            // what other validation to add??
            if (average <= 100) {
                this.average = average;
            }
        }
        // what happens if I don't initialize a number? default is 0 (int, doubles,
        // floats)
    }

    // Getters and setters for my private variables
    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return this.name;
    }

    public void setAverage(double average) {
        if (average >= 0.0) {
            if (average <= 100) {
                this.average = average;
            }
        }
    }

    public double getAverage() {
        return average;
    }

    // helper method that returns a grade letter based on average value
    public String getLetterGrade() {
        String letter = ""; // initialize string as empty

        // use nested if statements to calculate value of letter
        if (average >= 90.0) {
            letter = "A";
        } else if (average >= 80.0) {
            letter = "B";
        } else if (average >= 70.0) {
            letter = "C";
        } else if (average >= 60.0) {
            letter = "D";
        } else {
            letter = "F";
        }

        return letter;
    }
}