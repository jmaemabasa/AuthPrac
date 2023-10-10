global using AuthPrac.Shared.Models.User;
global using System.ComponentModel.DataAnnotations;
global using Blazored.LocalStorage;
global using AuthPrac.Client.Services.AuthService;
global using Microsoft.AspNetCore.Components.Authorization;
using AuthPrac.Client;
using AuthPrac.Client.Services.TokenServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//==================////////////================================
builder.Services.AddMudServices();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddOptions();
builder.Services.AddAuthentication();
builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredLocalStorage();
//==================////////////================================

await builder.Build().RunAsync();
