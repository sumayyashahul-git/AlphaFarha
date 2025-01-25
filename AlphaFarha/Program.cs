using Microsoft.EntityFrameworkCore;
using AlphaFarha.InfraStructure.Contexts;
using AlphaFarha.Core.Interfaces;
using AlphaFarha.InfraStructure.Repositories;
using AlphaFarha.Core.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMRFRepository, MRFRepsitory>();
builder.Services.AddScoped<IMRFItemRepository, MRFItemRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<MRFServices>();
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
    pattern: "{controller=MRF}/{action=Index}/{id?}");

app.Run();
