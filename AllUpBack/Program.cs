using AllUpBack.DAL;
using AllUpBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddDbContext<DataBase>(option =>{
    option.UseSqlite(config.GetConnectionString("DefaultConnection"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<AppUser, IdentityRole>(options => {
    options.User.RequireUniqueEmail = true;

    options.Password.RequiredLength = 8;
    options.Password.RequireDigit = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;

    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);
    options.Lockout.AllowedForNewUsers = true;
}).AddEntityFrameworkStores<DataBase>().AddDefaultTokenProviders();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    "areas",
    "{area:exists}/{controller=dashboard}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

