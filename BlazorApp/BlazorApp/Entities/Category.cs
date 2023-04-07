using System.Text.Json.Serialization;

namespace BlazorApp.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
