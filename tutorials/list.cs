List<String> names = ["name", "Ana", "Felipe"];
foreach (var name in names){
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// Console.WriteLine();
// names.Add("Maria");
// names.Add("Sage");
// names.Remove("Ana");
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

// Console.WriteLine($"My name is {names[0]}.");
// Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
// Console.WriteLine($"The list has {names.Count} people in it");

// Search and sort lists

var index = names.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");

} else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1)
{
    Console.WriteLine($"When an iten is not found, IndexOf returns {index}");

} else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine($"\n \n \n");

List<int> fibonacciNumbers = [1,1];

for (int count = 0; count < 18; count++)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count -1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count -2];

    fibonacciNumbers.Add(previous + previous2);
}

foreach (var number in fibonacciNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"The 20th fibonacci number is {fibonacciNumbers[19]}");