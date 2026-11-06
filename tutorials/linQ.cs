string[] names = ["ana", "ben", "cleo", "dara"];

IEnumerable<string> query = from name in names
                            where name.Length >= 4
                            orderby name
                            select name;
                            
foreach (string name in query)
{
    Console.WriteLine(name);
}

(string Area, int Priority)[] workItems = [
    ("docs", 2),
    ("tests", 1),
    ("deploy", 4),
    ("api", 1)
];

IEnumerable<string> nextItems = from item in workItems
                                let label = $"{item.Area}: P{item.Priority}"
                                where item.Priority <= 2
                                orderby item.Priority, item.Area
                                select label;

foreach (string item in nextItems)
{
    Console.WriteLine(item);
}

List<string> wItems = ["design", "docs", "deploy", "review"];

int count = wItems.Count(item => item.StartsWith("d"));

Console.WriteLine($"Count of work items starting with 'd': {count}");

IEnumerable<string> shortNames = names
    .Where(name => name.Length == 3)
    .Select(name => name.ToUpper());

foreach (string name in shortNames)
{
    Console.WriteLine(name);
}

IEnumerable<string> querySyntax = from item in wItems
                                    where item.Length > 4
                                    select item;

IEnumerable<string> methodSyntax = wItems.Where(item => item.Length == 4);

foreach (string item in querySyntax)
{
    Console.WriteLine(item);


}

foreach (string item in methodSyntax)
{
    Console.WriteLine(item);
}

// Common LINQ methods

Dictionary<string, int> pppp = new()
{
    ["docs"] = 2,
    ["code"] = 1,
    ["tests"] = 3,
    ["deploy"] = 4
};

IEnumerable<string> plannedWork = pppp.Where(item => item.Value <= 3)
                                    .OrderBy(item => item.Value)
                                    .Select(item => $"{item.Key}: P{item.Value}");


foreach (string item in plannedWork)
{
    Console.WriteLine(item);
}

string[] labels = ["api", "auth", "docs", "deploy"];

IEnumerable<IGrouping<char, string>> groups = labels.GroupBy(label => label[0]);

foreach (IGrouping<char, string> group in groups)
{
    Console.WriteLine($"Group: {group.Key}: {string.Join(", ", group)}");
}


List<string> todolist = ["design", "docs"];

IEnumerable<string> query1 = todolist.Where(item => item.StartsWith('d'));

int q = query1.Count();
Console.WriteLine($"Count: {q}");

todolist.Add("deploy");

Console.WriteLine($"Stored count: {q}");
Console.WriteLine($"Current count: {query1.Count()}");

foreach (string item in query1)
{
    Console.WriteLine(item);
}


(string Title, int Priority, bool IsOpen)[] items = [
    ("docs", 2, true),
    ("tests", 1, true),
    ("deploy", 3, false),
    ("api", 1, true)
];

IEnumerable<(string Title, int Priority, bool IsOpen)> openItems = from item in items
                                                                    where item.IsOpen
                                                                    select item;

IEnumerable<string> topOpenItems = from item in openItems
                                    where item.Priority == 1
                                    orderby item.Title
                                    select item.Title;

foreach (string title in topOpenItems)
{
    Console.WriteLine(title);
}


(string Title, string Area, bool IsOpen)[] item1 = [
    ("write docs", "docs", true),
    ("fix tests", "tests", true),
    ("deploy app", "deploy", false),
    ("update api", "api", true)
];

bool onDoc = true;

IEnumerable<(string Title, string Area, bool IsOpen)> query2 = item1.Where(item => item.IsOpen);

if (onDoc)
{
    query2 = query2.Where(item => item.Area == "docs");
}

foreach (string title in query2.Select(item => item.Title))
{
    Console.WriteLine(title);
}


List<(string Title, int Prior, bool IsOpen)> values = items.Where(item => item.IsOpen).ToList();

values.Add(("plan work", 5, true));

IEnumerable<string> cachedTopOpenItems = values.Where(item => item.Prior == 1).OrderBy(item => item.Title).Select(item => item.Title);

foreach (string title in cachedTopOpenItems)
{
    Console.WriteLine(title);
}