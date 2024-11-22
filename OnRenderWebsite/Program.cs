using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using OnRenderWebsite.Code;
using OnRenderWebsite.Code.Base;
using OnRenderWebsite.Code.Storage;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<StorageHandler>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

Global.Logger = app.Logger;

KeepAlive keepAlive = new KeepAlive(60000);
keepAlive.Start();

foreach(var dir in Directory.GetDirectories(Directory.GetCurrentDirectory()))
{
    Console.WriteLine(dir);
}

app.Run();

keepAlive.Stop();
