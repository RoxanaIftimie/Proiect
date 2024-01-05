using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Proiect_Iftimie_Roxana_Valentina_CIGgr3Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Proiect_Iftimie_Roxana_Valentina_CIGgr3Context") ?? throw new InvalidOperationException("Connection string 'Proiect_Iftimie_Roxana_Valentina_CIGgr3Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
