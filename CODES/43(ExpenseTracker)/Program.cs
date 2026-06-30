using ExpenseSharingApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ExpenseDbContext>(options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("ExpenseConnection")));

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
name: "default",
pattern: "{controller=Group}/{action=Index}/{id?}");

app.Run();
