int a = 5;
int b = a + 2;

bool test = true;

// Explicit type 
int count = 10;
double temperature = 36.6;

// Let compiler infer the type 
var name = "C#";
var items = new List<string> {"apple", "banana", "cherry"};

static string GetGreeting(string name, int visitCount)
{
    return visitCount switch
    {
        1 => $"Hello {name}, welcome for the first time!",
        _ => $"Hello {name}, welcome back! This is your visit number {visitCount}."
    };
}

// Value type: each vairable holds its own copy of data
var point1 = new Coords(1, 2);
var point2 = point1;
Console.WriteLine($"Point1: ({point1.X}, {point1.Y})");
Console.WriteLine($"Point2: ({point2.X}, {point2.Y})");
// point1 and point2 are independent copies, changing one does not affect the other

// Reference type: both variable refers to the same object 
var list1 = new List<int> {1,2,3};
var list2 = list1;
list2.Add(4);
Console.WriteLine($"list1 count: {list1.Count}");
Console.WriteLine($"list2 count: {list2.Count}");

public readonly record struct Coords(int X, int Y);
