using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Ocsp;
using TflWebAPI.Model;
using TflWebAPI.Services;
using TflWebAPI.Services.Interfaces;
using TflWebAPI.Contexts;
using TflWebAPI.Controllers;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using TflWebAPI.Repositories.Interfaces;
using TflWebAPI.Repositories;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddDbContext<DepartmentContext>();
builder.Services.AddTransient<IDepartmentRepository,DepartmentRepository>();
builder.Services.AddTransient<IDepartmentService, DepartmentService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
});
app.UseAuthorization();
app.MapControllers();
app.MapGet("/",()=>"Welcome to Transflower");
app.MapGet("api/departments",async ( IDepartmentService department)=>
                    await department.GetAllDepartment());
app.Run();

