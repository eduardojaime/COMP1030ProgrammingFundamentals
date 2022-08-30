import java.util.ArrayList;

public class ArrayListCollection {
    public static void main(String[] arg) {
        ArrayList<String> items = new ArrayList<String>();

        items.add("red"); // adds element at the end of the list
        items.add(0, "yellow"); // adds element at the specified position

        display(items, "Initial elements");

        items.add("green");
        items.add("yellow");
        items.add("red");

        display(items, "Added new elements");

        items.remove("yellow"); // deletes first occurrence of yellow

        display(items, "Removed first yellow");

        boolean containsYellow = items.contains("yellow");
        System.out.println("Does the list contain Yellow? " + containsYellow);

        boolean containsBlack = items.contains("black");
        System.out.println("Does the list contain black? " + containsBlack);


    }

    public static void display(ArrayList<String> items, String description) {
        System.out.println(description);

        for (int i = 0; i < items.size(); i++) {
            System.out.printf(" %s", items.get(i));
        }

        // for (String item: items) {
        // System.out.print(item);
        // }

        System.out.println("");
    }
}
