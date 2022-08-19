using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Corretora_imovel_gustavo_martins.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Corretora_imovel_gustavo_martinsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Corretora_imovel_gustavo_martinsContext") ?? throw new InvalidOperationException("Connection string 'Corretora_imovel_gustavo_martinsContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
