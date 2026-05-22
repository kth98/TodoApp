using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly List<Task>?  _tasks = new();
        public void AddTask(int id, string title, string description, DateTime dueDate)
        {
            var newTask = new Task(id, title, description, dueDate);
            _tasks.Add(newTask);
        }

        public List<Task>? GetTasks(int id)
        {
            return _tasks;
        }

        public void FinishTask(int id, string title, string description, DateTime dueDate)
        {
            var task = _tasks.FirstOrDefault(x => x.ID == id);
            if (task != null)
            {
                task.IsDone = true;
            }
        }

        public void DeleteTask(int id, string title, string description, DateTime dueDate)
        {
            var  task = _tasks.FirstOrDefault(x => x.ID == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }

        public void UpdateTask(int id, string title, string description, DateTime dueDate)
        {
            var task = _tasks.FirstOrDefault(x => x.ID == id);
            if (task != null)
            {
                
            }
        }

        public Task? GetTask(int id, string title, string description, DateTime dueDate)
        {
            var task = _tasks.FirstOrDefault(x => x.ID == id);
            if (task != null)
            {
                return task;
            }

            throw new InvalidOperationException();
        }
    }
}
