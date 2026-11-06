var person = new { Name = "Alice", Age = 30};
Console.WriteLine($"{person.Name} is {person.Age} years old.");

string productName = "Laptop";
decimal price = 999.99m;
var product = new { productName, price};
Console.WriteLine($"Product: {product.productName}, Price: {product.price:C}");

var words = new[] {"apple", "banana", "cherry"};
var results = words.Select(w => new {Word = w, Length = w.Length});

foreach (var result in results){
    Console.WriteLine($"Word: {result.Word}, Length: {result.Length}");
}


// unlike tuples, anonymous types are references types and preperty names, order and value types must match for two anonymous types to be considered equal.
var a = new { Name = "Alice", Age = 30};
var b = new { Name = "Alice", Age = 30};
var c = new { Name = "Bob", Age = 25};
var d = new { Paper = "Alice", Quantity = 30 };

Console.WriteLine($"a == b: {a.Equals(b)}"); // True
Console.WriteLine($"a == c: {a.Equals(c)}"); // False
Console.WriteLine($"a == d: {a.Equals(d)}"); // False

var order = new (
    OrderId: 12345,
    Customer:new { Name = "Alice", Age = 30},
    Total: 99.99m
);

Console.WriteLine($"Order ID: {order.OrderId}, Customer: {order.Customer.Name}, Total: {order.Total:C}");