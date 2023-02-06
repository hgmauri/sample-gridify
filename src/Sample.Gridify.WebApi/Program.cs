using Microsoft.EntityFrameworkCore;
using Sample.Gridify.Core.Context;
using Sample.Gridify.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddSerilog();

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
builder.Services.AddDbContext<BookContext>(opt => opt.UseInMemoryDatabase("BookContext"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();