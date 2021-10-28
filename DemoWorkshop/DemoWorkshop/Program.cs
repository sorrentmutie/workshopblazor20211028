using DemoWorkshop.Library.Interfaces;
using DemoWorkshop.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using Polly;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoWorkshop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("reqres", client => {
                client.BaseAddress = new Uri("https://reqres.in");
            })
            .AddTransientHttpErrorPolicy(builder =>
                builder.WaitAndRetryAsync( new [] { 
                TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(20)
                }));

            builder.Services.AddScoped<IDatiEventi, DatiEventiStatici>();
            builder.Services.AddScoped<IReqResData, ReqResService>();

            await builder.Build().RunAsync();
        }
    }
}
