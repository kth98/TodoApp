using System;
using TodoApp.Services;
using TodoApp.Models;
using System.Threading.Tasks;

namespace TodoApp;

public static class Program
{
	
	public static async Task Main(string[] args)
	{
		ITodoService service = new TodoService();
		//var tasks = service.GetTasks();
		Menu();
		var input = Console.ReadLine();
		await Choice(input, service);
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

	private static async Task Choice(string? choice, ITodoService service)
	{
		switch (choice)
		{
			case "1":
				await CreateTask(service);
				break;
			case "2":
				await DeleteTask(service);
				break;
			case "3":
				await UpdateTask(service);
				break;
			case "4":
				await ShowTask(service);
				break;
			case "5":
				break;
		}
	}

	private static async Task CreateTask(ITodoService service)
	{
		Console.Clear();
		Console.WriteLine("==== New task ====");
		Console.Write("Title: ");
		var title = Console.ReadLine()!;
		Console.Write("Description: ");
		var description = Console.ReadLine()!;
		Console.Write("Due Date (DD/MM/YYYY): ");
		var dueDate = DateTime.Parse(Console.ReadLine()!);
		
		var todo = new TodoTask(title, description, dueDate);

		await service.AddTask(todo);
		
		Console.WriteLine("Task added");
	}

	private static async Task DeleteTask(ITodoService service)
	{
		Console.Clear();
		Console.WriteLine("==== Delete task ====");
		
		var tasks =  await service.GetTask();

		for (int i = 0; i < tasks.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {tasks[i].Title}");
		}
		
		Console.WriteLine("Choose task number: ");
		int choice = Convert.ToInt32(Console.ReadLine());
		
		if (choice < 1 || choice > tasks.Count)
		{
			Console.WriteLine("Invalid choice");
			return;
		}
		
		var selectedTask =  tasks[choice - 1];
		
		await service.DeleteTask(selectedTask);
		Console.WriteLine("Task deleted");
	}

	private static Task UpdateTask(ITodoService service)
	{
		return Task.CompletedTask;
	}
	
	private static async Task ShowTask(ITodoService service)
	{
		var tasks = await service.GetTask();
		for (int i = 0; i < tasks.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {tasks[i].Title}");
		}
	}
}

