using System;

namespace TodoApp.Models;

public class TodoTask
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsDone { get; set; }


    public TodoTask(string title, string description, DateTime dueDate)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsDone = false;
    }
}