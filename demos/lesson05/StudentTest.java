// Class with a main method to test Student objects
public class StudentTest {
    public static void main(String[] args) {
        // code to test students
        Student student1 = new Student("Edward James",75.6);
        Student student2 = new Student("Marc Anthony", 45.0); // sings better than he codes

        // test
        System.out.printf("%s's letter grade is : %s%n",
                student1.getName(),
                student1.getLetterGrade()); // expected result C

        // %s is a wildcards or placeholders
        System.out.printf("%s's letter grade is : %s%n",
                student2.getName(),
                student2.getLetterGrade()); // expected result F
    }
}
