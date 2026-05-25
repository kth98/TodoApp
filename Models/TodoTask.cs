using System;

namespace TodoApp.Models;

public class TodoTask
{
    internal Guid Id { get; set; }
    internal string Title { get; set; }
    internal string Description { get; set; }
    internal DateTime DueDate { get; set; }
    internal bool IsDone { get; set; }


    public TodoTask(string title, string description, DateTime dueDate)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsDone = false;
    }
}