int temperature = 28;

if (temperature >= 25)
{
    Console.WriteLine("its hot as fuck today omffg");
} else if (temperature >= 15)
{
    Console.WriteLine("we bingchiling today");
} else
{
    Console.WriteLine("Its cold as fuck today ");
}

int score = 82;

string grade = score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};

Console.WriteLine($"Score: {score}, Grade: {grade}");

int measurement = 42;

switch (measurement)
{
    case < 0:
        Console.WriteLine("Negative");
        break;
    case 0:
        Console.WriteLine("Zero");
        break;
    case > 0 and measurement % 2 == 0:
        Console.WriteLine("Positive even");
        break;
    default: 
        Console.WriteLine("Positive odd");
        break;
}
