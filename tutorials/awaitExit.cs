// Console.Write("Hello");
// await Task.Delay(5000);
// Console.WriteLine("World!");

string? s = Console.ReadLine();

int returnValue = int.Parse(s ?? "-1");
return returnValue;