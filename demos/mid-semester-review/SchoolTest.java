public class SchoolTest {
    public static void main(String[] args) {
        School georgian = new School(); // default constructor
        // set values using setter methods
        georgian.SetSchoolName("Georgian College");
        georgian.SetYearFounded(1967);

        System.out.println(georgian.GetSchoolName());
        System.out.println(georgian.GetYearFound());

        boolean isEduardoHired = georgian.HireTeacher("Eduardo", "1 Yonge St", true);
        System.out.println(isEduardoHired);

        boolean isJohnHired = georgian.HireTeacher("John", "2 Yonge St", 10);
        System.out.println(isJohnHired);
    }
}
