using Microsoft.EntityFrameworkCore;
using Vendas.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();
var connectionStringMysql = "Server=localhost;initial catalog=vendas;uid=renato;pwd=taroba";
builder.Services.AddDbContext<AplicationDbContext>(options => options.UseMySql(
connectionStringMysql,
ServerVersion.Parse("5.5.22-MariaDb")
)
);

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
