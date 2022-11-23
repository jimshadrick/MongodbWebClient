using MongodbWebClient.Models;

namespace MongodbWebClient.Services;

public interface IBookService
{
    /*Task<List<Book>> GetBooks();*/
    Task<IEnumerable<Book>> GetBooks();
}