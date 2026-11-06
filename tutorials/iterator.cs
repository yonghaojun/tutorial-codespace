int[] readings = [21, 27, 24, -1, 19];

IEnumerable<int> acceptedReadings = SelectTemperatures(readings, maximum: 25);

foreach (int temperature in acceptedReadings)
{
    Console.WriteLine($"Accepted reading: {temperature}");
}

static IEnumerable<int> SelectTemperatures(
    IEnumerable<int> readings,
    int maximum
)
{
    foreach (int reading in readings)
    {
        Console.WriteLine($"Checking reading {reading} against maximum {maximum}");

        if (reading == -1)
        {
            yield break;
        }

        if (reading <= maximum)
        {
            yield return reading;
        }
    }
}