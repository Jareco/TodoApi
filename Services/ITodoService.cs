using System;
using TodoApi.Models;

namespace TodoApi.Services;

public interface ITodoService
{
    Task<List<TodoItem>> GetAllAsync();
    Task<TodoItem?> GetByIdAsync(long id);
    Task<bool> UpdateAsync(long id, TodoItem todoItem);
    Task<TodoItem> CreateAsync(TodoItem todoItem);
    Task<bool> DeleteAsync(long id);
}
