// string[] names = {"Ana", "Bob", "Charlie"};

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

Person ivanNg = new Person("Ivan Ng");
Person roy = new Person("Roy");
Person peter = new Person("Peter");
Person dan = new Person("Dan");
Person enzo = new Person("Enzo");
Person snow = new Person("Snow");
Person june = new Person("June");
Person rex = new Person("Rex");
Person kyle = new Person("Kyle");
Person jy = new Person("Jy");
Person hongNian = new Person("Hong Nian");
Person smallIvan = new Person("Small Ivan");
Person yongKhai = new Person("Yong Khai");

List<Person> verendus = [ivanNg, roy, peter, dan, enzo, snow, 
                        june, rex, kyle, jy, hongNian, smallIvan];

verendus.Add(yongKhai);
Console.WriteLine("Yong Khai has joined verendus.");

whosInVerendus(verendus);

while (IsYongKhaiIn(verendus) == true)
{
    dan.CrashOut();
}

static bool IsYongKhaiIn(List<Person> group)
{
    foreach (Person person in group)
    {
        if (person.Name == "Yong Khai")
        {
            return true;
        }
    }
    return false;
}

static void whosInVerendus(List<Person> group)
{
    string names = "";
    foreach (Person person in group)
    {
        names += person.Name + ", ";
    }
    Console.WriteLine($"Verendus lineup: {names.TrimEnd(',', ' ')}");
}

public class Person
{
    public string Name { get; set; }
    public Person (string name)
    {
        Name = name;
    }

    public void CrashOut()
    {
        Console.WriteLine($"{Name} crashes out.");
    }
}