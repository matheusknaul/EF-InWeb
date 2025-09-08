using Application.Service;
using BlazorApp.Components;
using Domain.Entities;
using StackExchange.Profiling;
using StackExchange.Profiling.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<ApiService>();

builder.Services.AddMiniProfiler(options =>
{
    options.RouteBasePath = "/profiler";
    // Criar MemoryCacheStorage usando o IMemoryCache do DI
    options.Storage = new MemoryCacheStorage(
        builder.Services.BuildServiceProvider().GetRequiredService<Microsoft.Extensions.Caching.Memory.IMemoryCache>(),
        TimeSpan.FromMinutes(60)
    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseMiniProfiler();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
