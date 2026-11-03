

var person = new Person { FirstName = "Grace", LastName = "Hoopper" };
Console.WriteLine($"{person.FirstName} {person.LastName}");


var manager = new Manager(person,"Engineering");
Console.WriteLine($"{manager.FirstName} {manager.LastName} - {manager.Department}");

// public class Container
// {
//     private int _capacity;
// }

// public class Container
// {
//     private int _capacity;

//     public Continaer(int capcity) => _capacity = capacity;
// }

public class Person
{
    public required string FirstName {get; set;}
    public required string LastName {get; set;}

}

public class Manager : Person
{
    public required string Department {get; set;}

    public Manager(Person person, string department)
    {
        FirstName = person.FirstName;
        LastName = person.LastName;
        Department = department;
    }

}

