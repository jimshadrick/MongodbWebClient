using System.Net.Http.Json;
using System.Text.Json;
using MongodbWebClient.Models;

namespace MongodbWebClient.Services;

public class BookService : IBookService
{
    private readonly HttpClient _client;

    public BookService(HttpClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Book>> GetBooks()
    {
        try
        {
            var books = await _client.GetFromJsonAsync<IEnumerable<Book>>("api/Books");
            return books;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}