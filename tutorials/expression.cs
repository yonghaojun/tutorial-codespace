int score = 80;
int bonus = 15;
int threshold = 90;
bool eligible = true;

// without parentheses: || binds less tightly than &&, so this reads as: 
// eligible && (score + bonus > threshold) || bonus > 20

bool result1 = eligible && score + bonus > threshold || bonus > 20;

bool result2 = (eligible && score + bonus > threshold) || bonus > 20;

Console.WriteLine($"result1: {result1}, result2: {result2}");

bool isAdmin = false;
bool isOwner = true; 

bool access1 = isAdmin && isOwner || true;
bool access2 = isAdmin && (isOwner || true);

Console.WriteLine($"access1: {access1}, access2: {access2}");

int result = 3 + 6 / 2;
Console.WriteLine($"result: {result}"); // result: 6

string? text = null;

bool hasContent = text != null && text.Length > 0;
Console.WriteLine($"hasContent: {hasContent}"); // hasContent: False

text = "Hello, World!";
hasContent = text != null && text.Length > 0;
Console.WriteLine($"hasContent: {hasContent}"); // hasContent: True

string word = "hello";
bool anyMatch = word.StartsWith("h") || word.StartsWith("x");
Console.WriteLine(anyMatch); // True

string? maybeNull = null;
int? length = maybeNull?.Length;
Console.WriteLine($"length.HasValue: {length.HasValue}"); // length.HasValue: False

