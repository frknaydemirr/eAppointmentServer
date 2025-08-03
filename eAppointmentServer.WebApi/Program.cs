using DefaultAllowCorsPolicyNugetPackage;
using eAppointmentServer.Application;
using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Infrastructure;
using eAppointmentServer.WebApi;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using eAppointmentServer.Infrastructure.Context;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDefaultCors();
    
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);





builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();



app.UseAuthorization();

app.MapControllers();

//default olarak user oluþturur

Helper.CreateUserAsync(app).Wait();


app.Run();
