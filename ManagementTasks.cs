using System;
using System.Collections.Generic;
using System.Linq;
using myAssignment;
using myPro;

namespace ManagementTasks
{

public class TasksManagement
{
    private static List<Assignment> assignments;

    public TasksManagement(List<Assignment> initialTasks)
    {
        assignments = initialTasks;
    }

    public static void AddTask(Assignment newtask)
    {
        assignments.Add(newtask);
        Console.WriteLine("The task has been added.");
    }

    public static void DeleteTask(string title)
    {
        Assignment TaskToRemove =  assignments.Find(z => z.Title == title);
        if (TaskToRemove != null)
        {
            assignments.Remove(TaskToRemove);
            Console.WriteLine("The task has been deleted.");
        }
        else
        {
            Console.WriteLine("The task with the given title was not found.");
        }
    }

    public static void DisplayTasks(int priority)
    {
        List<Assignment> TasksPriority = assignments.Where(z => z.Priority == priority).ToList();

        Console.WriteLine($"Priority tasks {priority}:");
        foreach (Assignment assignment in TasksPriority)
        {
            Console.WriteLine($"Title: {assignment.Title}");
            Console.WriteLine($"Priority: {assignment.Priority}");
            Console.WriteLine($"Deadline: {assignment.Deadline}");
            Console.WriteLine();
        }
    }
}

}
