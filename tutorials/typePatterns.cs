static void ShowCompatibility()
{
    object destination = new ExpressRouteStop("8 Oak Avenue");

    Console.WriteLine($"Exact class: {destination is ExpressRouteStop}");
    Console.WriteLine($"Base class: {destination is RouteStop}");
    Console.WriteLine($"Interface: {destination is IRouteStop}");
}

ShowCompatibility();

interface IRouteStop {}

abstract class RouteStop(String street) : IRouteStop
{
    public string Street { get; } = street;
    public string GetDisplayName() => Street;
}

sealed class ExpressRouteStop(string street) : RouteStop(street)
{
    
}