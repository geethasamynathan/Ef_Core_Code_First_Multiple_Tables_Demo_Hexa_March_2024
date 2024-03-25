using Ef_Core_Code_First_Multiple_Tables_Demo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DepartmentEmployeeContext>(opts =>
 opts.UseSqlServer(builder.Configuration["ConnectionStrings:myconnection"]));

var app = builder.Build();


//builder.Services.AddDbContext<DepartmentEmployeeContext>(opts => opts.UseSqlServer(
//    builder.Configuration["ConnectionStrings:myconnection"]));
//builder.Services.AddScoped<DbContext, DepartmentEmployeeContext>();
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
