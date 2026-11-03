void double1()
{
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a+b) / c;
    Console.WriteLine(d);
}

void double2()
{
    double a = 19;
    double b = 23;
    double c = 8;
    double d = (a + b) / c;
    Console.WriteLine(d);
}

void doubleMax()
{
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    double third = 1.0/3.0;
    Console.WriteLine(third);
}

double1();
double2();
doubleMax();