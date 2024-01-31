using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsAsp.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata.Ecma335;
using Tools.Earn;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();

//Adding a Path
builder.Services.Configure<MyConfig>(builder.Configuration.GetSection("MyConfig"));

//Dependency Injection into Factory Method

builder.Services.AddScoped((x) => new LocalEarnFactory(builder.Configuration.GetSection("MyConfig").GetValue<decimal>("LocalPercentage")));

builder.Services.AddScoped((x) => new ForeignEarnFactory(builder.Configuration.GetSection("MyConfig").GetValue<decimal>("ForeignPercentage"),
    builder.Configuration.GetSection("MyConfig").GetValue<decimal>("Extra")));

// Adding ConnectionString
builder.Services.AddDbContext<BeerContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"));
});

//Adding Repository
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
