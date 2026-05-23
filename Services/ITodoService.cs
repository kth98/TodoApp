using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        void AddTask(int id, string title, string description, DateTime dueDate);
        List<Task>?  GetTasks();
        void FinishTask(int id, string title, string description, DateTime dueDate);
        void DeleteTask(int id, string title, string description, DateTime dueDate);
        void UpdateTask(int id, string title, string description, DateTime dueDate);
        Task? GetTask(int id, string title, string description, DateTime dueDate);
        
    }
}