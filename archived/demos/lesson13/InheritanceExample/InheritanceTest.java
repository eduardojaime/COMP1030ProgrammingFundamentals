public class InheritanceTest {
    public static void main(String[] args) {
        // you should not need to create an instance of vehicle in your program
        Car myCar = new Car();
        myCar.Honk(); // access methods and attributes from vehicle

        int kmDriven = myCar.GetKilometersDriven();
        System.out.print(kmDriven);
        
        Truck myTruck = new Truck();
        myTruck.Honk(); // access methods and attributes from vehicle
        myTruck.TowSmallTrailer(); // access methods and attributes from truck
    }
}
