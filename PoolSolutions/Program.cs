using MySql.Data.MySqlClient;
using PoolSolutions.Models;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IDbConnection>((s) =>
{
    IDbConnection conn = new MySqlConnection(builder.Configuration.GetConnectionString("poolsolutions"));
    conn.Open();
    return conn;
});



builder.Services.AddTransient<IPoolRepository, PoolRepository>();
builder.Services.AddTransient<IChemRepository, ChemRepository>();
builder.Services.AddTransient<IMaintenanceRepository, MaintenanceRepository>();
builder.Services.AddTransient<IChem_HistoryRepository, Chem_HistoryRepository>();
builder.Services.AddTransient<IMaintenance_HistoryRepository, Maintenance_HistoryRepository>();

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
