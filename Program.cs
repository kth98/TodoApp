using System;
using TodoApp.Services;

namespace TodoApp;

public static class Program
{
	
	public static void Main(string[] args)
	{
		ITodoService service = new TodoService();
		//var tasks = service.GetTasks();
		Menu();
		var input = Console.ReadLine();
		Choice(input);
	}
	

	private static void Menu()
	{
		Console.WriteLine("Menu");
		Console.WriteLine("1. Create a new task");
		Console.WriteLine("2. Delete a task");
		Console.WriteLine("3. Update a task");
		Console.WriteLine("4. Show all tasks");
		Console.WriteLine("5. Exit");
	}

	private static void Choice(string? choice)
	{
		switch (choice)
		{
			case "1":
				CreateTask();
				break;
			case "2":
			case "3":
			case "4":
			case "5":
			{
				break;
			}
		}
	}

	private static void CreateTask()
	{
		Console.Clear();
		Console.WriteLine("==== New task ====");
		
		
	}
}

