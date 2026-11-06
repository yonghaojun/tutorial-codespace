int itemCount = 42;
long widened = itemCount; // Implicit conversion from int to Long

double average = 19.75;
int truncated = (int)average;

Console.WriteLine($"itemCount: {itemCount}, widened: {widened}, average: {average}, truncated: {truncated}");

// boxing and unboxing 
int temperature = 72;
object boxedTemperature = temperature;
int unboxedTemperature = (int)boxedTemperature;

// Packet packet = new(7);
// Ilabelled labelledpacket = packet;

Console.WriteLine($"Unboxed temperature: {unboxedTemperature}");

// parse and tryparse, should use tryparse to avoid exceptions
string textValue = "512";
int parsed = int.Parse(textValue);

string userInput = "12x";
bool parsedSuccesfully = int.TryParse(userInput, out int safeValue);

Console.WriteLine($"parsed: {parsed}");
Console.WriteLine(parsedSuccesfully ? $"safe value: {safeValue}" : "Input is not a valid member");