using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TestNew.Client.ApiServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddScoped<IApiTest, ApiTest>();

await builder.Build().RunAsync();
