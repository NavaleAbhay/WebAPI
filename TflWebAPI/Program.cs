using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Ocsp;
using TflWebAPI.Model;
using TflWebAPI.Services;
using TflWebAPI.Services.Interfaces;
using TflWebAPI.Contexts;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddTransient<IDepartmentService,DepartmentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// app.UseCors(builder =>
//     {
//         builder.AllowAnyOrigin()
//                .AllowAnyMethod()
//                .AllowAnyHeader();
// });
app.UseAuthorization();
app.MapControllers();
app.MapGet("/api/departments",async (DepartmentContext departmentContext)=>
await departmentContext.Departments.ToListAsync());
app.Run();

