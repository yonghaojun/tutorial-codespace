string? city = null;

// ?. — access a member only when non-null
int? len = city?.Length;

// ?? — substitute a default when null
string display = city ?? "unknown";

// is null — preferred null test
if (city is null)
{
    Console.WriteLine(display);
}
else
{
    Console.WriteLine(display);
}
// Output: No city provided.

int? age = null;
double? price = 9.99;
bool? isActive = null;

age = 30;

isActive = true;

int?[] scores = [100, null, 85, null, 90];

int? temperature = 72;

if (temperature is int degrees)
{
    Console.WriteLine($"Temperature is {degrees}F");
} else
{
    Console.WriteLine("Temperature is not recorded.");
}


int? count = 42;

if (count.HasValue)
{
    Console.WriteLine($"Count is {count.Value}.");
} else
{
    Console.WriteLine("Count is no value.");
}


int? quantity = null;

if (quantity != null)
{
    Console.WriteLine($"Quantity: {quantity.Value}");
} else
{
    Console.WriteLine("Quantity is not set.");
}

int? rating = null;

int result1 = rating.GetValueOrDefault();
int result2 = rating.GetValueOrDefault(-1);

Console.WriteLine(result1);
Console.WriteLine(result2);

rating = 5;
int result3 = rating.GetValueOrDefault(-1);
Console.WriteLine(result3);

int? priority = null;

int effective = priority ?? 0;
Console.WriteLine(effective);

int? a = 10;
int? b = 20;
int? c = null;

int? sum = a + b;
int? product = a * c;

Console.WriteLine(sum);
Console.WriteLine(product.HasValue);

static void Annotations()
{
    string required = "always set";
    string? optional = null;

    Console.WriteLine(required.Length);

    if (optional is not null)
    {
        Console.WriteLine(optional.Length);
    }
}

static void DesignIntent()
{
    Person p1 = new("Ada", "Lovelace") {MiddleName = "King"};
    Console.WriteLine(p1);

    Person p2 = new("Alan", "Turing");
    Console.WriteLine(p2);
}

static void NullSttaeTracking()
{
    string? message = null;
    Console.WriteLine(message.Length);
    message = "Hello, World!";
    Console.WriteLine(message.Length);
}

static void FlowAnalysis(Node start)
{
    Node? current = start;
    while (current is not null)
    {
        Console.WriteLine(current.Name);
        current = current.Parent;
    }
}

static void Nullforgiving()
{
    // "ada" matches a switch arm that returns a non-null string,
    // but the return type is string? so the compiler treats the 
    // result as possibly null. 

    string? maybeName = LookUpName("ada");

    // the ! teels the compiler "trust me, this isnt null." We just 
    // passed "ada" to LookUpName, which the switcj maps to Ada Lovelace

    int length = maybeName!.Length;
    Console.WriteLine(length);
}

// Returns string? because the wildcard arm yields null
static string? LookUpName(string id) => id switch
{
    "ada" => "Ada Lovelace",
    "alan" => "Alan Turing",
    _ => null
};

// static bool IsPresent([NotNullWhen(true)] string? value) => !string.IsNullOrEmpty(value);

// static void NullAnalysisAttributes()
// {
//     string? input = readInput();

//     if (IsPresent(input))
//     {
//         Console.WriteLine(input.Length);
//     }
// }

static string? ReadInput() => "Hello";

static void DefaultStructPitfall()
{
    Student s = default;
    Console.WriteLine(s.FirstName?.Length ?? -1);
}

static void ArrayPitFall()
{
    string[] values = new string[3];
    Console.WriteLine(values[0]?.Length ?? -1);

    string[] initialized = ["a", "b", "c"];
    Console.WriteLine(initialized[0].Length);
}

ArrayPitFall();

public sealed class Person(string firstName, string lastName)
{
    public string FirstName { get;} = firstName;
    public string? MiddleName { get; init;}
    public string LastName { get;} = lastName;

    public override string ToString() => MiddleName is null ? $"{FirstName} {LastName}" : $"{FirstName} {MiddleName} {LastName}";
}

public sealed class Node(string name)
{
    public string Name {get;} = name;
    public Node? Parent {get; init;}
}

public struct Student
{
    public string FirstName;
    public string? MiddleName;
    public string LastName;
}
