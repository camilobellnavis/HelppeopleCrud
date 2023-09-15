using Microsoft.EntityFrameworkCore;
using HelppeopleCrud.DAL.DataContext;
using HelppeopleCrud.DAL.Repositories;
using HelppeopleCrud.Models;
using HelppeopleCrud.BLL.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<HpeopleContext>(opciones =>
{
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<IGenericRepository<Ciudadano>, CiudadanoRepository>();
builder.Services.AddScoped<ICiudadanoService, CiudadanoService>();

builder.Services.AddScoped<IGenericRepository<Vacante>, VacanteRepository>();
builder.Services.AddScoped<IVacanteService, VacanteService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
