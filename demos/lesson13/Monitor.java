

public class Monitor {
    private String brand;
    private String connectorType;

    public Monitor(String brand, String connectorType){
        this.brand = brand;
        this.connectorType = connectorType;
    }

    public String GetMonitorInfo(){
        return "Brand: " + this.brand + ", Connector Type: " + this.connectorType;
    }
}
