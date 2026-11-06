int apples = 10;
int oranges = 3;

Console.WriteLine(apples + oranges);
Console.WriteLine(apples - oranges);
Console.WriteLine(apples * oranges);
Console.WriteLine(apples / oranges);
Console.WriteLine(apples % oranges);

int result = 7/2;
Console.WriteLine(result); // result: 3

int negResult = -7/2;
Console.WriteLine(negResult); // negResult: -3

double preciseResult = 7.0/2.0;
Console.WriteLine(preciseResult); // preciseResult: 3.5

Console.WriteLine(-7 % 3);
Console.WriteLine(7 % -3);

int temperature = 20;
int windChill = -5;

int headIndex = +temperature;
int coldFactor = -windChill;

Console.WriteLine(headIndex);
Console.WriteLine(coldFactor);

bool isRaining = false;
bool isSunny = !isRaining;
Console.WriteLine(isSunny);

int counter = 5;
int a = ++ counter;
Console.WriteLine(a);
Console.WriteLine(counter);

int b = counter++;
Console.WriteLine(b);
Console.WriteLine(counter);

int score = 10;
Console.WriteLine(score--);
Console.WriteLine(score);

int speed = 75;
int limit = 60;

Console.WriteLine(speed > limit);
Console.WriteLine(speed < limit);
Console.WriteLine(speed <= limit);
Console.WriteLine(speed >= limit);

char grade = 'B';
Console.WriteLine(grade >= 'A' && grade <= 'F');

int expected = 42;
int actual = 42;

Console.WriteLine(expected == actual);
Console.WriteLine(actual != expected);

string name = "Alice";
Console.WriteLine(name == "Alice");
Console.WriteLine(name == "alice");

int x = 5;
Console.WriteLine(x == 10);

int age = 20;
bool hasTicket = true;

bool canEnter = age >= 18 && hasTicket;
Console.WriteLine(canEnter);

bool freeEntry = age < 5 || age >= 65;
Console.WriteLine(freeEntry);

List<string>? items = null;
bool hasItems = items != null && items.Count > 0;
Console.WriteLine(hasItems);

// conditional operators 
// condition ? value when true : value when false

int temperature2 = 35;

string weather = temperature2 > 30 ? "hot" : "comfortable";
Console.WriteLine(weather);

int divisor = 0;
int safe = divisor == 0 ? -1 : 10 / divisor;
Console.WriteLine(safe);

int level = 1;
level = 5;
Console.WriteLine(level);

int hp = 100;
hp += 20;
Console.WriteLine(hp);
hp -= 10;
Console.WriteLine(hp);
hp *= 2;
Console.WriteLine(hp);
hp /= 4;
Console.WriteLine(hp);
hp %= 7;
Console.WriteLine(hp);


int a2, b2, c2;
a2 = b2 = c2 = 0;
console.WriteLine($"a2: {a2}, b2: {b2}, c2: {c2}");

byte small = 200;
small += 10;
Console.WriteLine(small);


