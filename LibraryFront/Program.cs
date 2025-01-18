using LibraryFront;
using LibraryFront.Servicios;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7016/") });
builder.Services.AddScoped<IServiciosAutor,ServiciosAutor>();
builder.Services.AddScoped<IServiciosLibro,ServiciosLibro>();
builder.Services.AddScoped<IServiciosPrestamo,ServiciosPrestamo>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
