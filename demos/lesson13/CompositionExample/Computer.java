

public class Computer {
    private String type; // laptop, PC, something else
    // composition
    // computer has a keyboard
    private Keyboard keyboard;
    // computer has a monitor
    private Monitor monitorA;
    private Monitor monitorB;

    public Computer(String type, Keyboard keyboard, Monitor monitorA, Monitor monitorB) {
        this.type = type;
        this.keyboard = keyboard;
        this.monitorA = monitorA;
        this.monitorB = monitorB;
    }
    // methods to print monitor info
    public void GetMonitorAInfo() {
        System.out.println(this.monitorA.GetMonitorInfo());
    }

    public void GetMonitorBInfo() {
        System.out.println(this.monitorB.GetMonitorInfo());
    }
}
