
var tasks = new[]
{
    new ProjectTask("Confirm venue", Priority: 3, isBlocked: false),
    new ProjectTask("Print badges", Priority: 2, isBlocked: true),
    new ProjectTask("Test microphones", Priority:2, isBlocked: false),
};

static void ShowDashboard(
    string projectName, 
    IEnumerable<PorjectTask> tasks,
    int minimumPriority
)
{
    var urgentTasks = tasks.Where(task => task.Priority >= minimumPriority);

    foreach (ProjectTask task in ReadyTasks(urgentTasks))
    {
        Console.WriteLine(FormatTask(task));
    }

    string FormatTask(ProjectTask task) => $"{projectname}: {task.Title} (priority {task.Priority})";
}

static IEnumerable<ProjectTask> ReadyTasks(
    IEnumerable<ProjectTask> tasks
)
{
    foreach (ProjectTask task in tasks)
    {
        if (!task.isBlocked)
        {
            yield return task;
        }
    }
}

record ProjectTask(string Title, int Priority, bool isBlocked);