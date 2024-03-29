using EmployApi.Logic;
using EmployApi.Models;
using EmployApi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Injecting DbContext
builder.Services.AddDbContext<EmployDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("EmployDbConnectionString")));

//Injecting Repository Pattern and Business Logic Pattern
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<ICompanyLogic,CompanyLogic>();
builder.Services.AddScoped<IEmployeeLogic,EmployeeLogic>();

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
