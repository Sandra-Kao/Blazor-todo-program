using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TodoItems_Crud_Blazor.Models;

namespace TodoItems_Crud_Blazor.Services
{
    public class TodoItemsService : ITodoItemsService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly HttpClient _httpClient;
        public TodoItemsService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _httpClient = _clientFactory.CreateClient("ServerAPI");
        }
        public async Task<IEnumerable<TodoItem>> GetAsync()
        {
            var obj = await
            _httpClient.GetFromJsonAsync<IEnumerable<TodoItem>>("api/TodoItems/");
            return obj;
        }
        public async Task<TodoItem> GetAsync(int id)
        {
            var obj = await _httpClient.GetFromJsonAsync<TodoItem>
            ($"api/TodoItems/{id}");
            return obj;
        }
        public async Task<TodoItem> Add(TodoItem todoItem)
        {
            var result = await _httpClient.PostAsJsonAsync<TodoItem>
            ($"api/TodoItems/", todoItem);
            var obj = await result.Content.ReadFromJsonAsync<TodoItem>();
            return obj;
        }
        public async Task<bool> Update(int id, TodoItem todoItem)
        {
            await _httpClient.PutAsJsonAsync<TodoItem>($"api/TodoItems/{id}", todoItem);
            return true;
        }
        public async Task<bool> Del(int id)
        {
            var result = await
            _httpClient.DeleteAsync($"api/TodoItems/{id}");
            return true;
        }
    }

}
