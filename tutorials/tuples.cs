
var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}.");

var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);

var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
// var person = (FirstName: "", LastName: "");
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

// Console.WriteLine($"{namedData} \n{person} \n{order}");

// Tuple with named elements
(string Name, int Age) person = ("Alice", 30);
Console.WriteLine($"{person.Name} is {person.Age} years old.");

// Tuple with default element names
(string, int) unnamed = ("Bob", 25);
Console.WriteLine($"(unnamed.Item1) is {unnamed.Item2} years old.");

// Tuple decalred with var and inline names
var city = (Name: "Seattle", Population: 750_0000);
Console.WriteLine($"{city.Name} has a population of {city.Population}");

var name = "Carol";
var age = 28;

// The compiler infers element names from the variable names 
var person1 = (name, age);
Console.WriteLine($"{person1.name} is {person1.age} years old.");

static (double Minimum, double Maximum, double Average) ComputeStats(List<double> values)
{
    var min = values.Min();
    var max = values.Max();
    var avg = values.Average();
    return (min, max, avg);
}

var point = (X: 3, Y: 4);

var (x, y) = point;
Console.WriteLine($"x={x}, y={y}");

(int px, int py) = point;
Console.WriteLine($"px={px}, py={py}");

int a, b;
(a, b) = point;
Console.WriteLine($"a={a}, b={b}");

List<double> data = [10, 20, 30];
var (min, max, avg) = ComputeStats(data);
Console.WriteLine($"min={min}, max={max}, avg={avg}");

List<(string Name, int Score)> results = [
    ("Alice", 90),
    ("Bob", 85),
    ("Charlie", 92)
];

foreach (var (name1, score) in results)
{
    Console.WriteLine($"{name1}: {score}");
}


// If dont need all the values from the tuples, can use discards _

List<double> data2 = [3, 56, 9];
var (_, max1, _) = ComputeStats(data2);
Console.WriteLine($"max={max1}");


// comparing tuples with == and != 
// comparing tuples with == and !=, the types and order of th elements must match at least to compare, else it wrun into a compile error
var tuple1 = (1 , 2);
var tuple2 = (Product: "coil", Quantity: 20);
var tuple3 = (Product: "coil", Quantity: 20);
var tuple4 = (Product: "bread", Quantity: 200);

// Console.WriteLine(tuple1 == tuple2);
Console.WriteLine(tuple2 == tuple3);
Console.WriteLine(tuple3 == tuple4);
// Console.WriteLine(tuple4 == tuple1);

var named = (X: 10, Y: 8);
var different = (A: 10, B: 8);
Console.WriteLine(named == different); // True because the element names are not considered in the comparison, only the values and their order. 

// Nondestructive mutation with with expression 
var original =(Name2: "Widget", Price2: 19.99m, InStock:true);
var discounted = original with { Price2= 14.99m};

Console.WriteLine($"Original: {original.Name2}, Price: {original.Price2}, InStock: {original.InStock}");
Console.WriteLine($"Discounted: {discounted.Name2}, Price: {discounted.Price2}, InStock: {discounted.InStock}");

// tuples with dictionary
var sizedChart = new Dictionary<string, (int Min2, int Max2)>{
    ["Small"] = (Min2: 0, Max2: 10),
    ["Medium"] = (Min2: 11, Max2: 20),
    ["Large"] = (Min2: 21, Max2: 30)
};

if (sizedChart.TryGetValue("Medium", out var range))
{
    Console.WriteLine($"Medium size range: {range.Min2} to {range.Max2}");
}

var grid = new Dictionary<(int Row, int Column), string>
{
    [(0, 0)]= "origin",
    [(1,3)]= "Sensor A",
    [(2,5)] = "Sensor B"
};

var target = (Row: 1, Column: 3);
if (grid.TryGetValue(target, out var label))
{
    Console.WriteLine($"({target.Row}, {target.Column}): {label}");
}
