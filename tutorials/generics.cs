List<int> scores = [95, 87, 72, 91];
Dictionary<string, decimal> prices = new()
{
    ["Widget"] = 19.99m,
    ["Gadget"] = 29.99m
};
Task<string> greeting = Task.FromResult("Hello, generics!");
Func<int, bool> isPositive = n => n > 0;

Console.WriteLine($"Forst score: {scores[0]}");
Console.WriteLine($"Widget price: {prices["Widget"]:C}");
Console.WriteLine($"Greeting: {await greeting}");
Console.WriteLine($"Is 5 positive? {isPositive(5)}");

List<string> names = ["Alice", "Bob", "Carol"];
names.Add("Dave");

var inventory = new Dictionary<string, int>
{
    ["Apples"] = 50,
    ["Bananas"] = 30
};
inventory["Bananas"] = 25;
HashSet<int> uniqueIds = [1,2,3,2,1];
Console.WriteLine($"Unique IDs count: {uniqueIds.Count}");

Queue<string> tasks = new();
tasks.Enqueue("Build");
tasks.Enqueue("Test");
Console.WriteLine($"Next task: {tasks.Dequeue()}");

static void Print<T>(T value) => Console.WriteLine($"Value: {value}");

Print(42); // Compiler infer type T as int
Print("Hello"); // Compiler infer type T as string
Print(3.14); // Compiler infer type T as double

// Collection expressions 
List<string> fruits = ["Apple", "Banana", "Cherry"];

int[] numbers = [1, 2, 3, 4, 5]; // array

IReadOnlyList<double> temperatures = [72.0, 68.5, 75.3];

Console.WriteLine($"Fruits: {string.Join(", ", fruits)}");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.WriteLine($"Temperatures: {string.Join(", ", temperatures)}");

List<int> first = [1,2,3];
List<int> second = [4,5,6];


List<int> combined = [.. first, .. second];
Console.WriteLine($"Combined: {string.Join(", ", combined)}");

List<int> withExtras = [0, .. first, 99, .. second, 100];
Console.WriteLine($"With Extras: {string.Join(", ", withExtras)}");

// Dictonary collection expression

Dictionary<string, int> scores1 = new()
{
    ["Alice"] = 90,
    ["Bob"] = 85,
    ["Charlie"] = 95
};

foreach (var (name, score) in scores1)
{
    Console.WriteLine($"{name}: {score}");
}

Dictionary<string, int> defaults = new()
{
    ["Timeout"] = 60,
    ["Retries"] = 3
};

Dictionary<string, int> overrides = new()
{
    ["Timeout"] = 60
};

Dictionary<string, int> config = new(defaults);

foreach (var(key, value) in overrides)
{
    config[key] = value;
}

Console.WriteLine($"Timeout: {config["Timeout"]}, Retries: {config["Retries"]}");

static T Max<T> (T a, T b) where T : IComparable<T> => a.CompareTo(b) >= 0 ? a : b;

Console.WriteLine(Max(3,7));
Console.WriteLine(Max("apple", "banana"));

static T CreateDefault<T> () where T: new() => new T();

var list = CreateDefault<List<int>>(); // Creates an empty List<int>
Console.WriteLine($"Empty list count: {list.Count}");

// Covariance: IEnumerable<Dog> can e used as IEnumerable<Animal>
// because IEnumerable<out T> is covariant

List<Dog> dogs = [new("Rex", new ("Buddy"))];
IEnumerable<Animal> animals = dogs;

foreach (var animal in animals)
{
    Console.WriteLine(animal.Name);
}

// Contravariance: Actin<Animal> can be used as Action<Dog> 
// becuase Action<in T> is controvariant 
Action<Animal> printAnimal = a => Console.WriteLine($"Animal: {a.Name}");
Action<Dog> printDog = printAnimal;

printDog(new Dog("Max"));

public class Genericlist<T>
{
    private class Node(T data)
    {
        public T Data {get; set;} = data;
        public Node? Next {get; set;}
    }

    private Node? head;

    public void AddHead(T data)
    {
        var node = new Node(data) {Next = head};
        head = node;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = head;
        while (current is not null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
}
