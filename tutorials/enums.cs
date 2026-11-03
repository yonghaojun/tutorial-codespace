static string DescribeSeason(Season season) => season switch
{
    Season.Spring => "Flowers bloom and temperature rise.",
    Season.Summer => "Long days and warm weather.",
    Season.Autumn => "Leaves change color and fall.",
    Season.Winter => "Short days and cold temperatures.",
    _ => throw new ArgumentOutOfRangeException(nameof(season))
};

var today = Season.Autumn;
Console.WriteLine(DescribeSeason(today));

var permissions = fileAccess.Read | fileAccess.Write;

Console.WriteLine(permissions);
Console.WriteLine(permissions.HasFlag(fileAccess.Read));
Console.WriteLine(permissions.HasFlag(fileAccess.Execute));

var parsed = Enum.Parse<Season>("Winter");
Console.WriteLine(parsed);

if (Enum.TryParse<Season>("Monsoon", out var result))
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid season");
}

foreach (var season in Enum.GetValues<Season>())
{
    Console.WriteLine($"{season} = {(int)season}");
}

Season season = Season.Summer;

switch (season)
{
    case Season.Spring:
        Console.WriteLine("Spring is here!");
        break;
    case Season.Summer:
        Console.WriteLine("Summer is here!");
        break;
    case Season.Autumn:
        Console.WriteLine("Autumn is here!");
        break;
    case Season.Winter:
        Console.WriteLine("Winter is here!");
        break;
}

enum Season
{
    Spring, 
    Summer,
    Autumn,
    Winter
}

enum HttpStatus : ushort
{
    OK = 200,
    NotFound = 404,
    InternalServerError = 500
}

[Flags]
enum fileAccess
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    ReadWrite = Read | Write,
    All = Read | Write | Execute,
}
