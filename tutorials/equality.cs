var order1 = new Order(42, "Shoes");
var order2 = new Order(42, "Shoes");

Console.WriteLine(order1 == order2);
Console.WriteLine(order1.Equals(order2));
Console.WriteLine(ReferenceEquals(order1, order2));

Order order3 = order1;
Console.WriteLine(order1 == order3);

var pt1 = new Point(3,4);
var pt2 = new Point(3,4);

Console.WriteLine(pt1 == pt2);
Console.WriteLine(pt1.Equals(pt2));

var t1 = (Name: "Grace", Role: "Engineer");
var t2 = (Name1: "Grace", ROle1: "Engineer");

Console.WriteLine(t1 == t2);

var doc1 = new Document("Report");
var doc2 = new Document("Report");
var doc3 = doc1;

Console.WriteLine(ReferenceEquals(doc1, doc2));
Console.WriteLine(ReferenceEquals(doc1, doc3));

var person1 = new Person("Grace", "Hopper");
var person2 = new Person("Grace", "Hopper");

Console.WriteLine("\nPerson");
Console.WriteLine(person1 == person2);
Console.WriteLine(person1.Equals(person2));
Console.WriteLine(ReferenceEquals(person1, person2));

var dim1 = new Dimension(1920, 1080);
var dim2 = new Dimension(1920, 1080);


Console.WriteLine("\nDimension");
Console.WriteLine(dim1 == dim2);
Console.WriteLine(dim1.Equals(dim2));  

var playlist1 = new Playlist("Chill", new List<string> { "Song1", "Song2" });
var playlist2 = new Playlist("Chill", new List<string> { "Song1", "Song2" });

Console.WriteLine("\nPlaylist");
Console.WriteLine(playlist1 == playlist2);
Console.WriteLine(playlist1.Equals(playlist2));
Console.WriteLine(playlist1.Tracks.SequenceEqual(playlist2.Tracks)); // Compare the contents of the mutable property

public class Order
{
    public int Id {get;}
    public string Name {get; set;}

    public Order(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public record Point(int X, int Y);

public record Document(string Title);

public record Person(string FirstName, string LastName); // record is more data focused type, reference type but compares value rather than reference

public record struct Dimension(int Width, int Height); // record struct is value type, compares value rather than reference

public record Playlist(string Name, List<string> Songs) // record with mutable property 
{
    public List<string> Tracks {get; set;} = Songs;

}