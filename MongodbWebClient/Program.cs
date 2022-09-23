using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MongodbWebClient;
using MongodbWebClient.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => 
    //new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
    new HttpClient { BaseAddress = new Uri("https://localhost:7130/") } );

builder.Services.AddScoped<IBookService, BookService>();

await builder.Build().RunAsync();