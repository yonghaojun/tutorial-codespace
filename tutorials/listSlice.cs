static bool IsHeader(string[] columns) => columns is ["Name", "Score"];

static string GetAnnouncement(List<string> finishingOrder) => finishingOrder switch
{
    [var winner, _, var thirdPlace] => $"Winner: {winner}; third place: {thirdPlace}",
    _ => "A complete list of finishers is not available."
};

static string GetInputFile(string[] arguments) => arguments switch
{
    ["--verbose", .., var fileName] => $"Verbose processing: {fileName}",
    [.., var fileName] => $"Processing: {fileName}",
    [] => "No input file was provided"
};

// only 1 slice per list pattern 

static bool HasContent(string[] entries) => 
    entries is ["BEGIN", .. {Length: > 0}, "END"];