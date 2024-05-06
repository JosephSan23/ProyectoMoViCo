using CapaDatos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddNpgsql<ConexionContext>(builder.Configuration.GetConnectionString("Connection"));

var app = builder.Build();

app.MapGet("/dbconexion", async ([FromServices] ConexionContext dbContext) =>
{
    //Este metodo nos asegura que la base este creada y si no la crea
    dbContext.Database.EnsureCreated();
    return Results.Ok("Bases de datos ok");
});

// Crear las migraciones
//using(var scope = app.Services.CreateScope())
//{
//    var dataContext = scope.ServiceProvider.GetRequiredService<ConexionContext>;
//}


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
