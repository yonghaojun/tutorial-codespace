string[] names = { "Alice", "Bob", "Charlie" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

int countdown = 3;

while (countdown > 0)
{
    Console.WriteLine(countdown);
   // await Task.Delay(1000); // Wait for 1 second
    countdown--;
}
Console.WriteLine("Countdown finished!");

int attempts = 0;

do
{
    attempts++;
    Console.WriteLine($"Attempt {attempts}");
}
while (attempts < 3);

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

int[] numbers = [2,4,7,8];

foreach (int number in numbers)
{
    if (number % 2 != 0)
    {
        Console.WriteLine($"First odd number: {number}");
        break;
    }
}

int[] values = [1,2,3,4,5];

foreach (int value in values)
{
    if (value % 2 == 0)
    {
        continue; // the rest of the current iteration is skipped, and the loop moves to the next iteration
    }

    Console.WriteLine(value);
}

static async Task AwaitForeachExample()
{
    await foreach (int value in GenerateAsync())
    {
        Console.WriteLine(value);
    }
}

static async IAsyncEnumerable<int> GenerateAsync()
{
    for (int i = 0; i < 3; i++)
    {
        await Task.Delay(1);
        yield return i;
    }
}



