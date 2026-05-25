using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly FileStorage _fileStorage;

        public TodoService()
        {
            _fileStorage = new FileStorage();
        }

        public async Task AddTask(TodoTask task)
        {
            var tasks = await _fileStorage.GetTasks();
            tasks.Add(task);
            await _fileStorage.SaveTasks(tasks);
        }

        public async Task<List<TodoTask>> GetTask()
        {
            return await _fileStorage.GetTasks();
        }

        public async Task FinishTask(Guid taskId)
        {
            var tasks = await _fileStorage.GetTasks();
            
            var task = tasks.FirstOrDefault(t => t.Id == taskId);

            if (task == null)
            {
                return;
            }
            task.IsDone = true;
            await _fileStorage.SaveTasks(tasks);
        }

        public async Task DeleteTask(TodoTask task)
        {
            var tasks = await _fileStorage.GetTasks();
            tasks.Remove(task);
            await _fileStorage.SaveTasks(tasks);
        }

        public async Task UpdateTask(TodoTask task)
        {
            var tasks = await _fileStorage.GetTasks();
            
            var taskToUpdate = tasks.FirstOrDefault(t => t.Id == task.Id);

            if (taskToUpdate == null)
            {
                return;
            }

            taskToUpdate.Title = task.Title;
            taskToUpdate.Description = task.Description;
            taskToUpdate.DueDate = task.DueDate;
            taskToUpdate.IsDone = task.IsDone;
            await _fileStorage.SaveTasks(tasks);
        }
    }
}
