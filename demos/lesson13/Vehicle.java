// parent class
public class Vehicle {
    private int tyres; // primitive data type, no helper methods
    private String engineType;
    private String manufacturer;
    private Integer doors; // using wrapper class, multiple helper methods

    public void Honk(){
        System.out.println("Tuut tuut!");
    }
    public void Drive(String addressFrom, String addressTo) {
        System.out.println("Arrived!");
    }
}
