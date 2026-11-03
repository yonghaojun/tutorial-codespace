var p1 = new Point { X = 3, Y = 4 };
var p2 = p1;
p2.X = 10;

Console.WriteLine($"p1: {p1}"); // p1: (3, 4)
Console.WriteLine($"p2: {p2}"); // p2: (10, 4)


var custom = new ConnectionSettings();
Console.WriteLine($"Host: {custom.Host}, Port: {custom.Port}, MaxRetries: {custom.Maxretries}");

var defaults = default(ConnectionSettings);
Console.WriteLine($"{defaults.Host ?? "(null)"}: {defaults.Port} (retries: {defaults.Maxretries}))");

var tile = new GameTile(2, 5);
Console.WriteLine($"Tile at row {tile.Row}, column {tile.Column}, blocked: {tile.IsBlocked}");

var temp = new Temperature(100);
Console.WriteLine(temp);

var v = new Velocity { X = 3, Y = 4 };
Console.WriteLine(v.Speed);
Console.WriteLine(v);
v.X = 6;
Console.WriteLine(v.Speed);

struct Point{
    public double X { get; set; }
    public double Y { get; set; }

    public readonly double DistanceTo (Point other){
        var dx = X - other.X;
        var dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public override string ToString(){
        return $"({X}, {Y})";
    }
}

struct ConnectionSettings
{
    public string Host {get; set;}
    public int Port {get; set;}
    public int Maxretries {get; set;}

    public ConnectionSettings()
    {
        Host = "localhost";
        Port = 8080;
        Maxretries = 3;
    }
}

struct GameTile
{
    public int Row {get; set;}
    public int Column {get; set;}
    public bool IsBlocked {get; set;}

    public GameTile(int row, int column)
    {
        Row = row;
        Column = column;
    }
}

readonly struct Temperature
{
    public double Celsius {get;}
    public Temperature(double Celsius) => this.Celsius = Celsius;
    public double Fahrenheit => Celsius * 9.0 / 5.0 + 32.0;
    public override string ToString() => $"{Celsius:F1}°C ({Fahrenheit:F1}°F)";
}

struct Velocity
{
    public double X
    {
        readonly get;
        set;
    }

    public double Y
    {
        readonly get;
        set;
    }


    public readonly double Speed => Math.Sqrt(X * X + Y * Y);

    public readonly override string ToString() => $"({X}, {Y}) speed={Speed:F2}";
}