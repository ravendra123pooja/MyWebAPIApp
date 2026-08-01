using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MyWebApiApp.Controllers.Data;


var builder = WebApplication.CreateBuilder(args);
 builder.Configuration.AddAzureKeyVault(
   new Uri("https://ravendrakeyvault1234.vault.azure.net/"),
     new DefaultAzureCredential());

// Add services
//Change by Ravendra Kumar
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration["myconnection"]));
builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure middleware

// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();

    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();