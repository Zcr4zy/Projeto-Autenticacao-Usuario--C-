using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projeto_Autenticacao_Usuario__C_.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// criacao de string de conexão
string com = builder.Configuration.GetConnectionString("GranConn");
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySql(com, ServerVersion.AutoDetect(com))
);

// Criação de serviço de gestao de usuários
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

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
