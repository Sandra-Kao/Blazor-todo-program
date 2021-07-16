using System.ComponentModel.DataAnnotations;

namespace TodoItems_Crud_Blazor.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Name 是必填")]
        public bool IsComplete { get; set; }
        [Required(ErrorMessage = "IsComplete 是必填")]
        public string Secret { get;set; }
    }
}