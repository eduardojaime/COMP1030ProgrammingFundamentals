

public class Keyboard {
    private String brand;
    private String region;

    public Keyboard(String brand, String region) {
        this.brand = brand;
        this.region = region;
    }

    public String GetKeyboardInfo() {
        return "Brand: " + this.brand +", Region: " + this.region;
    }
}
