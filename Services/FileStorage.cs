using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Services;

public class FileStorage
{
    private static readonly string FileName = "tasks.json";

    public async Task<List<TodoTask>> GetTasks()
    {
        if (!File.Exists(FileName))
        {
            return new List<TodoTask>();
        }
        var json = await File.ReadAllTextAsync(FileName);
        return JsonSerializer.Deserialize<List<TodoTask>>(json) ?? new List<TodoTask>();
    }

    public async Task SaveTasks(List<TodoTask> tasks)
    {
        var json = JsonSerializer.Serialize(tasks);
        await File.WriteAllTextAsync(FileName, json);
    }
}