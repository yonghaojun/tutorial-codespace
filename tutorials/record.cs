var p1 = new Person("grace", "hopper", Array.Empty<string>());
var p2 = p1;
Console.WriteLine(ReferenceEquals(p1,p2));

var c1 = new Coordinate(47.6062, -122.3321);
var c2 = c1;
c2.Longitude = 0.0;
Console.WriteLine(c1.Longitude);
Console.WriteLine(c2.Longitude);

var home = new Coordinate(47.6062, -122.3321);
var copy = home;
Console.WriteLine(home);
Console.WriteLine(home == copy);

// Person is a record type with three properties: FirstName, LastName, and PhoneNumbers.
var phones = new string[] { "555-1234" };
var person1 = new Person("Grace", "Hopper", phones);
var person2 = new Person("Grace", "Hopper", phones);

Console.WriteLine(person1 == person2);              // True
Console.WriteLine(ReferenceEquals(person1, person2)); // False

person1.PhoneNumbers[0] = "555-9999";
Console.WriteLine(person2.PhoneNumbers[0]); // 555-9999 — same array


var original = new Person("John", "Doe", Array.Empty<string>());
var modified = original with {firstName = "Jane" };

Console.WriteLine(original);
Console.WriteLine(modified);
Console.WriteLine(original == modified);

var copy1 = original with {};
Console.WriteLine(original == copy1);

var shifted = home with { Longitude =  -122.0 };
Console.WriteLine(shifted);
Console.WriteLine(home == shifted); // False, because the Longitude property is different

var (first = "grass", last = "hoppers") = person;
Console.WriteLine($"First Name: {first}, Last Name: {last}");


public record Studnet(string FirstName, string LastName, int GradeLevel) : Person(FirstName, LastName);

public record Person(string firstName, string LastName, string[] PhoneNumbers);

public record struct Coordinate(double Latitude, double Longitude);

public readonly record struct Temperature(double Celsius)
{
    public double fahrenheit => Celsius * 9.0 / 5.0 + 32.0;
}

public record Product
{
    public required string Name {get; init;}
    public decimal Price {get; set;}

}
