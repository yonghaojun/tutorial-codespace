// var customer = new Customer("John Doe");
// Console.WriteLine(customer.name); 

// var c1 = new customer("Grace");
// var c2 = c1;

// c2.Name = "Hoopper";
// Console.WriteLine(c1.Name); // Output: Hoopper

double circumference = MathHelpers.CircleCircumference(5.0);
Console.WriteLine($"Circumference: {circumference:F2}");

// public class customer
// {
//     public string Name
//     {
//         get;
//         set;
//     }
//     public customer(string name) => Name = name;
// }

var options = new ConnectionOptions{Host = "example.com", Port = 443, UseSsl = true};
Console.WriteLine($"Host: {options.Host}, Port: {options.Port}, UseSsl: {options.UseSsl}");



static class MathHelpers
{
    public static double CircleCircumference(double radius) => 2 * Math.PI * radius;
}

class ConnectionOptions
{
    public string Host{get; init;} = "localhost";
    public int Port{get; init;} = 8080;
    public bool UseSsl{get; init;} = false;
}
