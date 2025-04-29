using System.Diagnostics.Metrics;
using System;
using Microsoft.EntityFrameworkCore;
using smartGadgetsStore.Models;
using smartGadgetsStore.Models.Repositorie;


var builder = WebApplication.CreateBuilder(args);

//Enable MVC IN project
builder.Services.AddControllersWithViews();



///////////////////DB/////////////////////////////////
///
IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("sqlCon"));
});

builder.Services.AddScoped<IRepositorie<Brand>, dbBrandRepositorie>();

////////////////////////////////////////////////////




var app = builder.Build();


//app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting(); // Controller/Action

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Country}/{action=Index}/{id?}"
    );


app.Run();
