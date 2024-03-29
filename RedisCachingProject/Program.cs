using Microsoft.EntityFrameworkCore;
using RedisCachingProject.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<RedisCacheDBContext>(options =>
{
    // Connect Sql Server with ConnectString and Nuget EntityFrameworkCore.SqlServer
    options.UseSqlServer(builder.Configuration.GetConnectionString("RedisCacheDBContext"));
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
