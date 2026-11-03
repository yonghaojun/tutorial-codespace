void ExploreIf()
{
    int a = 5;
    int b = 3;
    int c = 4;
    if ((a + b + c > 10) || (a == b))
    {
        Console.WriteLine("the answer is greater than 10.");
        Console.WriteLine("and the first number is equal to the second");
    } else
    {
        Console.WriteLine("the answer is not greater than 10.");
        Console.WriteLine("or the first number is not equal to the second");
    }
}

// for (int counter = 0; counter < 10; counter++)
// {
//     Console.WriteLine($"Hello World! The counter is {counter}");
// }

// for (int row= 1; row < 11; row++)
// {
//     Console.WriteLine($"The row is {row}");
// }

// for (char column = 'a'; column < 'k'; column++)
// {
//     Console.WriteLine($"The column is {column}");
// }

// for (int row = 1; row < 11; row++)
// {
//     for(char column = 'a'; column < 'k'; column++)
//     {
//         Console.WriteLine($"The row is {row} and the column is {column}");
//     }
// }

int sum = 0;
for (int num = 0; num < 21; num++)
{
    if (num % 3 == 0)
    {
        sum += num;
    }
}

Console.WriteLine($"The sum of all numbers between 0 and 20 that are divisible by 3 is {sum}");