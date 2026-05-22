using System;

namespace TodoApp.Models;

public class Task
{
    internal int ID { get; set; }
    string Title { get; set; }
    string Description { get; set; }
    DateTime DueDate { get; set; }
    internal bool IsDone { get; set; }


    public Task(int id, string title, string description, DateTime dueDate)
    {
        ID = id;
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsDone = false;
    }
}