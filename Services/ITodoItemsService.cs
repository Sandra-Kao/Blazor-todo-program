using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TodoItems_Crud_Blazor.Models;

namespace TodoItems_Crud_Blazor.Services
{
    public interface ITodoItemsService
    {
        public Task<IEnumerable<TodoItem>> GetAsync();
        public Task<TodoItem> GetAsync(int id);
        public Task<TodoItem> Add(TodoItem todoItem);
        public Task<bool> Update(int id, TodoItem todoItem);
        public Task<bool> Del(int id);

    }
}