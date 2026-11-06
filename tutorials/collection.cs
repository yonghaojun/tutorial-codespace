// different collection types in C#

string[] sprintPlan = ["design", "code", "test"];
List<string> backlog = ["design", "code"];
Dictionary<string, int?> priorities = new()
{
    ["docs"] = 2,
    ["tests"] = 1
};

backlog.Add("test");

Console.WriteLine($"Array: {string.Join(", ", sprintPlan)}");
Console.WriteLine($"List count: {backlog.Count}");
Console.WriteLine($"Priority for docs: {priorities["docs"]}");


string[] stages = ["design", "code", "test", "review"];

Console.WriteLine($"First: {stages[0]}");
Console.WriteLine($"test index: {Array.IndexOf(stages, "test")}");

string[] stage = ["design", "code", "test"];

stage[0] = "plan";

Console.WriteLine(string.Join(", ", stage));
Console.WriteLine($"Length: {stage.Length}");

// grow or shrink of list
List<string> tasks = ["design", "code", "test"];

tasks.Add("review");
tasks.Remove("code");
tasks.Insert(1, "code");
tasks[1] = "verify";

Console.WriteLine(string.Join(", ", tasks));
Console.WriteLine($"Has review: {tasks.Contains("review")}");
Console.WriteLine($"Index of verify: {tasks.IndexOf("verify")}");


List<string> workItems = ["design", "test"];

workItems.Insert(1, "code");
Console.WriteLine(string.Join(", ", workItems));

workItems.Insert(0, "plan");
Console.WriteLine(string.Join(", ", workItems));

workItems.InsertRange(workItems.Count, ["review", "deploy"]);
Console.WriteLine(string.Join(", ", workItems));

workItems.RemoveAt(workItems.Count - 1);
Console.WriteLine(string.Join(", ", workItems));

workItems.RemoveAt(2);
Console.WriteLine(string.Join(", ", workItems));

workItems.RemoveAt(0);
Console.WriteLine(string.Join(", ", workItems));


// Dictionary <TKey, Tavalue>

Dictionary<string, int> priorities1 = new()
{
    ["docs"] = 2,
    ["tests"] = 1
};

priorities1["review"] = 3;
priorities1.Remove("review");

if (priorities1.TryGetValue("docs", out int docsPriority))
{
    Console.WriteLine($"docs priority: {docsPriority}");
} else
{
    Console.WriteLine("Docs missing");
}

if (priorities1.TryGetValue("deploy", out int deployPriority))
{
    Console.WriteLine($"deploy priority: {deployPriority}");
} else
{
    Console.WriteLine("Deploy missing");
}

Console.WriteLine($"Count: {priorities1.Count}");

priorities1["docs"] = 1;

if (priorities1.TryGetValue("tests", out int testsPriority))
{
    priorities1["tests"] = testsPriority + 1;
}

priorities1["deploy"] = 3;

Console.WriteLine($"docs priority: {priorities1["docs"]}");
Console.WriteLine($"tests priority: {priorities1["tests"]}");
Console.WriteLine($"deploy priority: {priorities1["deploy"]}");

string[] planned = ["design", "code"];
string[] upcoming = [.. planned, "test"];
List<string> blocked = ["docs"];

Console.WriteLine($"Upcoming: {string.Join(", ", upcoming)}");
Console.WriteLine($"Blocked: {string.Join(", ", blocked)}");


// read from positions and indexs

string[] phases = ["design", "code", "test", "deploy"];
List<string> checklist = ["design", "code", "test"];

Console.WriteLine($"Last phase: {phases[^1]}");
Console.WriteLine($"Middle: {string.Join(", ", phases[1 ..3])}");
Console.WriteLine($"Last two: {string.Join(", ", phases[^2..])}");
Console.WriteLine($"Without ends : {string.Join(", ", phases[1..^1])}");
Console.WriteLine($"First two: {string.Join(", ", phases[..2])}");
Console.WriteLine($"All: {string.Join(", ", phases[..])}");
Console.WriteLine($"from third to end: {string.Join(", ", phases[2..])}");
Console.WriteLine($"List last: {checklist[^1]}");
Console.WriteLine($"List first two: {string.Join(", ", checklist[..2])}");