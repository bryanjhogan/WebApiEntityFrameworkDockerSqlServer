using Microsoft.EntityFrameworkCore;
using WebApiEntityFrameworkDockerSqlServer.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SalesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SalesDb")));

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var salesContext = scope.ServiceProvider.GetRequiredService<SalesContext>();
    salesContext.Database.EnsureCreated();
    salesContext.Seed();
}

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
