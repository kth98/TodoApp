using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        Task AddTask(TodoTask task);
        Task<List<TodoTask>> GetTask();
        Task FinishTask(Guid taskId);
        Task DeleteTask(TodoTask task);
        Task UpdateTask(TodoTask task);
    }
}