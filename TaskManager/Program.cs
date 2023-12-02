using System;
using System.Collections.Generic;

namespace TaskManager
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Task Manager");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Mark a task as completed");
                Console.WriteLine("3. View tasks");
                Console.WriteLine("4. Exit");

                int choice = GetUserChoice();

                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        MarkTaskAsCompleted();
                        break;
                    case 3:
                        ViewTasks();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static int GetUserChoice()
        {
            Console.Write("Enter your choice (1-4): ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return GetUserChoice();
            }
        }

        static void AddTask()
        {
            Console.Write("Enter the task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        static void MarkTaskAsCompleted()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to mark as completed.");
            }
            else
            {
                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }

                Console.Write("Enter the task number to mark as completed: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    tasks.RemoveAt(taskNumber - 1);
                    Console.WriteLine("Task marked as completed!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid task number.");
                }
            }
        }

        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
    }
}
