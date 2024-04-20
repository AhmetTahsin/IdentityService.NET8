using IdentityService.Context;
using IdentityService.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Identity Setting
builder.Services.AddIdentity<AppUser, AppRole>(x =>
{
    x.Password.RequiredLength = 3;
    x.Password.RequireDigit = false;
    x.Password.RequireLowercase = false;
    x.Password.RequireUppercase = false;
    x.Password.RequireNonAlphanumeric = false;
    x.Lockout.MaxFailedAccessAttempts = 5;
    x.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);

}).AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();


builder.Services.AddDbContextPool<Context>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());

builder.Services.AddControllers();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
