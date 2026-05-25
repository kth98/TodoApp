using System;

namespace TodoApp.Models;

public class TodoTask
{
    internal Guid Id { get; set; }
    internal string Title { get; set; }
    internal string Description { get; set; }
    internal DateTime DueDate { get; set; }
    internal bool IsDone { get; set; }


    public TodoTask(Guid id, string title, string description, DateTime dueDate)
    {
        Id = id;
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsDone = false;
    }
}