static string ClassifyTemperature(int temperature) =>
    temperature switch
    {
        < 0 => "Below Freezing",
        >= 18 and <= 24 => "Comfortable",
        (>= 0 and < 10) or 30 => "Far outside the comforatable range",
        _ => "Cool or warm"
    };

static void ShowExpressionAndPattern(int temperature, int threshold)
{
    bool belowThreshold = temperature < threshold;
    bool belowFreezing = temperature is < 0;

    string description = temperature switch
    {
        < 0 => "Freezing",
        0 => "Freezing Point",
        > 0 => "Above Freezing",
    };

    Console.WriteLine($"Below threshold: {belowThreshold}, Below Freezing: {belowFreezing}, Description: {description}");
}

static bool IsWeekendPattern(DayOfWeek day) => day is DayOfWeek.Saturday or DayOfWeek.Sunday;

static bool IsweekendImperative(DayOfWeek day) => day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;

static bool IsAcceptedPriority(int priority) => priority is (>= 1 and <= 3) or 9;

static string GetHeatWarning(int temperature, bool isOutdoors) => temeprature switch
{
    > 35 when isOutdoors => "Will die",
    > 35 => "i wanna sleep so bad",
    _ => "really can sleep"
};

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}