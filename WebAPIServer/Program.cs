using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;
using WebAPIServer.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CryptoDbContext>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseCors();

app.UseStaticFiles();
app.UseDefaultFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "/{controller=Home}/{action=Index}/{id?}");

app.Run();
