int quantity = 5;
Console.WriteLine($"Quantity: {quantity}");

if (quantity < 10)
{
    quantity = 10;
    Console.WriteLine("Restocked");
}

Console.WriteLine($"Quantity: {quantity}");


int outerValue = 10;

if (outerValue > 0)
{
    int innerValue = outerValue * 2;
    Console.WriteLine(innerValue);
}

