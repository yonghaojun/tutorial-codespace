static string GetCrossingInstruction(PedastrianSignal signal, bool crossingIsClear) => 
(signal, crossingIsClear) switch
{
    (PedastrianSignal.Walk, true) => "Cross Now",
    (PedastrianSignal.Walk, false) => "Wait for traffic to clear",
    _ => "Wait for signal. "
};

static bool IsHotAndHumid(Weatherreading reading) => reading is { Temperature: > 30, HumidityPercent: > 70 };

sealed record Weatherreading(int TemperatureC, int HumidityPercent);

enum PedastrianSignal
{
    Stop, 
    Walk
}