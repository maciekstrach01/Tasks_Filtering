using System;
using System.Collections.Generic;
using System.Linq;
namespace myAssignment

{
public class Assignment
{
    public string Title { get; set; }
    public int Priority { get; set; }
    public DateTime Deadline { get; set; }

    public Assignment(string title, int priority, DateTime deadline)
    {
        Title = title;
        Priority = priority;
        Deadline = deadline;
    }
}

}