int tpopulation = 67_000_000;
long distance = 384_400_000L;
short temperature = -40;
byte red = 255;

double pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011330530548820466521384146951941511609433057270365759591953092186117381932611793105118548074462379962749567351885752724891227938183011949128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450;
float gravity = 9.81f; // need to add f suffix to indicate float literal, else it will be treated as double
decimal price = 19.99m; // need to add m suffix to indicate decimal literal, else it will be treated as double

uint fileSize = 4_294_967_295;
ulong totalBytes = 18_446_744_073_709_551_615;
ushort port = 443;
// negative values arent valid for data

nint bufferSize = 1024;
nuint elementCount = 100;

bool isValid = true;
char grade = 'A';
string greeting = "Hello, World!";

int dec = 42;
int hex = 0x2A; // hexadecimal representation of 42
int bin = 0b00101010; // binary representation of 42
long big = 1_000_000_000_000L; // long literal with L suffix

double d = 3.14;
float f = 3.14f;
decimal m = 3.14m;
double scientific = 1.5e6; // scientific notation for 1.5 million

char newline = '\n';
char unicode = '\u03A9'; // Unicode character for Omega symbol

string message = $"Found {dec} items in the list. The value of pi is approximately {pi}.";
string path = @"C:\Users\Username\Documents"; // verbatim string literal, backslashes are treated as literal characters
string json = """
{
    "name": "John Doe",
    "age": 30,
    "isStudent": false
}
"""; // raw string literal, useful for multi-line strings and preserving formatting
string raw = $"""
    Found {dec} items in "{greeting}
    """;


int defaultInt = default; // default value for int is 0
bool defaultBool = default; // default value for bool is false
string? defaultString = default; // default value for string is null

var limit = (args.Length > 0) ? int.Parse(args[0]) : default(int);


//implicitly typed variables 
var count = 10;
var name = "C#";
var items = new List<int>();

// Target typed new expressions
List<string> names = new() {"Alice", "Bob", "Charlie"};
Dictionary<string, int> scores = new()
{
    [Alice] = 90,
    [Bob] = 85,
    [Charlie] = 95
};

