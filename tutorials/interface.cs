Dog dog = new dog();
Cat cat = new Cat();

dog.makeSound();
cat.makeSound();

interface IEquatable<T>
{
    bool Equals(T obj);
}

public class Car : IEquatable<Car>
{
    public string? Make{get; set;}
    public string? Model{get; set;}
    public string? Year{get; set;}

    public bool Equals(Car? car) => car is not null && (Make, Model, Year) == (car.Make, car.Model, car.Year);
}

interface Ilogger
{
    void Log(string message);
    string Name {get;}
}

public class ConsoleLogger : Ilogger
{
    public string Name => "Console";
    public void Log(string message) => Console.WriteLine($"[{Name}] {message}");
}

public class Filelogger : Ilogger
{
    public string Name => "file";

    public void Log(string message)
    {
        // code to write the message to a file
        Console.WriteLine($"[{Name}] {message}");
    }
}

// Explicit Implementation
interface IMetric
{
    double getDistance();
}

interface IImperial
{
    double getDistance();
}

public class Runway(double meters) : IMetric, IImperial
{
    // explicit implmentation for Imetric
    double IMetric.getDistance() => meters;

    double IImperial.getDistance() => meters * 3.28084;

}


interface IDrawable
{
    void Draw();
}

interface IShape : IDrawable
{
    double Area {get;}
}

public class Circle(double radius) : IShape
{
    public double area => Math.PI * radius * radius;

    public void Draw() => console.WriteLine($"Drawing cirlce with area {Area:F2}");
}

internal class Internalconfiguration
{
    public string Setting{ get; set;} = "";
}

internal interface ILoggable
{
    void Log(string message);
}

internal interface IConfigurable
{
    void Configure(Internalconfiguration config);
}

public class ServiceImplementation : Iloggable, IConifurable
{
    // Implicit implemetaton: ILoffale uses only public types in its signature
    public void Log(string message) => Console.WriteLine($"Log: {message}");

    void IConfigurable.configure(internalConfiguration config) => Console.WriteLine($"configured with: {config.Setting}");
}

public interface IAnimal
{
    void makeSound();
}

public class Dog : IAnimal
{
    public string kind => "corgi";
    public void makeSound() => Console.WriteLine("woof");
}

public class Cat : IAnimal
{
    public void makeSound() => Console.WriteLine("meow");
}

public interface IPayment
{
    void Pay(double amount);
}

public class CreditCard: IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using credit card");
    }
}

public class OnineBanking: IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount:C} using online banking");
    }
}



