// Learning a new language > repetition
// Basketball 3-pointers > repetition
public class School {
    // two instance variables of different types
    private String schoolName;
    private int yearFounded;

    // setter/getter methods
    public void SetSchoolName(String schoolName) {
        this.schoolName = schoolName;
    }

    public String GetSchoolName() {
        return this.schoolName;
    }

    public void SetYearFounded(int yearFounded) {
        this.yearFounded = yearFounded;
    }

    public int GetYearFound() {
        return this.yearFounded;
    }

    // default constructor
    public School() {
        this.schoolName = "School Object";
        this.yearFounded = 2022;
    }

    // custom constructor (constructor with arguments)
    public School(String schoolName, int yearFounded) {
        this.schoolName = schoolName;
        this.yearFounded = yearFounded;
    }
    
    // Classes define methods, methods represent behaviour of the entity the class represents
    public boolean AdmitStudent(String name, String address, Double score) {
        // logic to admit student
        // if score is higher than requirement then 
        return true;
    }

    public boolean HireTeacher(String name, String address, boolean hasExperience) {
        // logic to decide whether to hire the teacher
        // if experience is enough then
        return true;
    }

    public boolean HireTeacher(String name, String address, int yearsOfExperience) {
        // determine whether to hire this person based on years of exp
         return true;
    }

    public int CountStudents() {
        // logic to query the database and return the count of students
        return 1000;
    }
}