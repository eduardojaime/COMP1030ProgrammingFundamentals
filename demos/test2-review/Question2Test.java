public class Question2Test {
    public static void main(String[] args) {
        // test your question2 class
        Question2 question2 = new Question2();
        // call overloaded methods
        question2.myMethod("ABCDEFG", 10, 10);
        question2.myMethod("ABCDEFG", 10.0, 10.0);
        question2.myMethod("ABCDEFG", "10", "10");
    }
}
