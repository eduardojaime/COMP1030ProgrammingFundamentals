public class Question3 {
    public static String myMethod(String longStr, String shortStr) {
        // ABCDEFGHIJKLMNO and DEF
        int pos = longStr.indexOf(shortStr);
        int posFixed = pos + shortStr.length();

        String result = longStr.substring(posFixed, posFixed + 3);
        return result;
    }
}
