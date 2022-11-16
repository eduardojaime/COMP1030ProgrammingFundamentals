public class Student {
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string EmailAddress {get;set;}
    public decimal Average {get;set;}
    public string FullName {get {
        return $"{this.FirstName} {this.LastName}";
    }}

}