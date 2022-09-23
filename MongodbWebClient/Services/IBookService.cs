using MongodbWebClient.Models;

namespace MongodbWebClient.Services;

public interface IBookService
{
    /*Task<List<BookDTO>> GetBooks();*/
    Task<IEnumerable<BookDTO>> GetBooks();
}