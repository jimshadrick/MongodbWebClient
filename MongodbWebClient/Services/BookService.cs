using System.Net.Http.Json;
using System.Text.Json;
using MongodbWebClient.Models;

namespace MongodbWebClient.Services;

public class BookService : IBookService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _options;

    public BookService(HttpClient client)
    {
        _client = client;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<IEnumerable<BookDTO>> GetBooks()
    {
        try
        {
            var books = await _client.GetFromJsonAsync<IEnumerable<BookDTO>>("api/Books");
            return books;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}