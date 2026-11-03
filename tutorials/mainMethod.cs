class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);
    }
}

// static void Main() {}
// static int Main() {}
// static void Main(string[] args) {}
// static int Main(string[] args) {}
// static async Task Main() {}
// static async Task<int> Main() {}
// static async Task Main(string[] args) {}
// static async Task<int> Main(string[] args) {}

class MainReturnValTest
{
    static int Main()
    {
        //..
        return 0;
    }
}

class Program
{
    static async Task<int> Main(string[] args)
    {
        return await AsyncConsoleWork();
    }

    private static async Task<int> AsyncConsoleWork()
    {
        return 0;
    }
}