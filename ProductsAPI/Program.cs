using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductsAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductContext>(
options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("ProductInfo"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("127.0.0.1-mysql"));
});

builder.Services.AddMvc(option => option.EnableEndpointRouting = false)
    .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

builder.Services.AddDbContext<ProductContextProcedures>(
options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("ProductInfo"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("127.0.0.1-mysql"));
});

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

