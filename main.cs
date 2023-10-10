using System;
using System.Collections.Generic;
using System.Linq;
using myAssignment;
using ManagementTasks;

namespace myPro
{
public class Program
{
    public static void Main()
    {
        try
        {
        List<Assignment> assignments = new List<Assignment>
        {
            new Assignment("Task 1", 1, DateTime.Today.AddDays(7)),
            new Assignment("Task 2", 2, DateTime.Today.AddDays(14)),
            new Assignment("Task 3", 3, DateTime.Today.AddDays(21))
        };

        TasksManagement tasksManagement = new TasksManagement(assignments);

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add the task");
            Console.WriteLine("2. Delete the task");
            Console.WriteLine("3. Display the tasks with the highest priority");
            Console.WriteLine("4. Display the tasks with the medium priority");
            Console.WriteLine("5. Display the tasks with the low priority");
            Console.WriteLine("6. Exit");

            Console.Write("Select an option: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("Incorrect choice. Give a number from 1 to 6.");
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    try
                    {
                    Console.Write("Give the title of the task: ");
                    string title = Console.ReadLine();

                    Console.Write("Specify the priority (1 - low, 2 - medium, 3 - high): ");
                    int priority;
                    while (!int.TryParse(Console.ReadLine(), out priority) || priority < 1 || priority > 3)
                    {
                        Console.WriteLine("Incorrect priority. Specify a number between 1 and 3.");
                    }

                    Console.Write("Specify the date (YYYY-MM-DD): ");
                    DateTime deadline;
                    while (!DateTime.TryParse(Console.ReadLine(), out deadline))
                    {
                        Console.WriteLine("Incorrect date format. Please provide date in YYYY-MM-DD format.");
                    }

                    Assignment newtask = new Assignment(title, priority, deadline);
                    ManagementTasks.TasksManagement.AddTask(newtask);
                    }
                catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while adding the task: " + ex.Message);
                    }
                    break;

                case 2:
                try
                    {
                    Console.Write("Give the title of the task to be removed:");
                    string TitleToRemove = Console.ReadLine();
                    ManagementTasks.TasksManagement.DeleteTask(TitleToRemove);
                    }
                catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while removing the task: " + ex.Message);
                    }
                    break;

                case 3:
                    ManagementTasks.TasksManagement.DisplayTasks(3);
                    break;

                case 4:
                    ManagementTasks.TasksManagement.DisplayTasks(2);
                    break;

                case 5:
                    ManagementTasks.TasksManagement.DisplayTasks(1);
                    break;

                case 6:
                    return;
            }

            Console.WriteLine();
        }
    }
    catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
}

