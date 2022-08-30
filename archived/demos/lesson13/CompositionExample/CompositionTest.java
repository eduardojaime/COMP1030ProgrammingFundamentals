

public class CompositionTest {
    public static void main(String[] args) {
        // in order to create a computer we need 2 monitors and 1 keyboard
        Keyboard myKeyboard = new Keyboard("Microsoft", "NorthAmerica");
        Monitor myMonitorA = new Monitor("Acer", "HDMI");
        Monitor myMonitorB = new Monitor("HP", "VGA");
        
        // Composition
        // I have all the pieces, let's create a computer
        Computer myComputer = new Computer("DESKTOP", myKeyboard, myMonitorA, myMonitorB);
        // print info about my monitors
        myComputer.GetMonitorAInfo();
        myComputer.GetMonitorBInfo();
    }
}
