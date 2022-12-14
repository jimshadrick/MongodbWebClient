using System.Text.Json.Serialization;

namespace MongodbWebClient.Models;

public class Book
{
    public string? Id { get; set; }

    [JsonPropertyName("Name")]
    public string BookName { get; set; } = null!;

    public decimal Price { get; set; }
    
    public string? Category { get; set; }
    
    public string? Author { get; set; }
}