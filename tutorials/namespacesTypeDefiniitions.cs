MyClass.TestMethod();
MyNameSpace.MyClass.MyMethod();

public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello World");
    }
}

namespace MyNameSpace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("HelloWorld from MyNameSpace.MyClass.MyMethod!");
        }
    }
}