using Microsoft.AspNetCore.Components;
using MongodbWebClient.Services;
using MongodbWebClient.Models;

namespace MongodbWebClient.Pages;

public class BooksBase: ComponentBase
{
    [Inject]
    public IBookService BookService { get; set; }
    
    // Property to expose book collection to razor code 
    public IEnumerable<BookDTO> Books { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Books = await BookService.GetBooks();
    }
}