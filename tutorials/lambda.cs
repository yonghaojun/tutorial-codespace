Transform doubler = x => x * 2;
Transform squarer = Square;

Console.WriteLine(doubler(5));
Console.WriteLine(squarer(5));

Func<int, int, int> add = (left, right) => left + right;
Func<int, bool> isEven = static value => value % 2 == 0;

Console.WriteLine($"Is 4 even? {isEven(4)}");
Console.WriteLine($"Is 5 even? {isEven(5)}");

Action<string> report = message => Console.WriteLine($"Report: {message}");
Action< int, int, string> statusUpdate = (_,_, message) => Console.WriteLine(message);
statusUpdate(1,2, "Operation Completed");


int total = add(3,4);
report($"Total: {total}");

int[] numbers = [1,2,3,4,5,6];
// int[] evenNumbers = Filter(numbers, value => value % 2 == 0).ToArray();

// Console.WriteLine(string.Join(", ", evenNumbers));

static int Square(int value) => value * value;

delegate int Transform(int value);

