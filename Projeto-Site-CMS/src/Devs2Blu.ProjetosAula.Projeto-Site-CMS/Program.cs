using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Repository;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Implements;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context DB SQL Server
// ATUALIZAR STRING COM SEU DB
builder.Services.AddDbContext<ContextoDatabase>
	(options => options.UseSqlServer("Server=DESKTOP-UME51NM\\SQLMATEUS; Database=ListaVeiculos; User Id=sa;Password=zuky; TrustServerCertificate=True;"));

/*
 * Dependency Injection
 */

// Repositories
builder.Services.AddScoped<ConteudoRepository, ConteudoRepository>();

// Services
builder.Services.AddScoped<IConteudoService, ConteudoService>();


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
