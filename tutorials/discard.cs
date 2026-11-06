// underscore token _

static void showStatus()
{
    int statusCode = 503;
    string message = statusCode switch
    {
        230 => "Ready",
        404 => "Not Found",
        _ => "Antoher status"
    };

    Console.WriteLine(message);
}

static void ShowForecast()
{
    var (city, high, _, _) = GetForecast();
    Console.WriteLine($"{city}: high {high}C");

    static (string city, int High, int Low, int RainChance) GetForecast() => ("Seattle", 20, 10, 80);
}

static void CheckInput()
{
    
    string text = "42";

    if (IsWholeNumber(text))
    {
        Console.WriteLine($"Accepted: {text}");
    } else
    {
        Console.WriteLine("Enter a whole number.");
    }

    static bool IsWholeNumber(string text) => int.TryParse(text, out _);
}

static void ShowLambdaDiscards()
{
    EventHandler handler = (_, _) => Console.WriteLine("Timer tick");
    handler(null, EventArgs.Empty);
}