WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    // subtraction 
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division 
    c = a / b;
    Console.WriteLine(c);

    c = a + b - 12 * 17;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int d = 5;
    int e = 4;
    int f = 2;
    int g = (d + e) * f;
    Console.WriteLine(g);

    g = (d + f) - 6 * f + (12 * 4) / 3 + 12;
    Console.WriteLine(g);
}
