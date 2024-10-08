using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//Database Context Dependency Injection
var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

var conString = $"server={dbHost};port=3306;database={dbName};user=root;password={dbPassword}";
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(conString,ServerVersion.AutoDetect(conString)));


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
