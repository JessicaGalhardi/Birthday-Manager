using Friends.Domain.Interfaces;
using Friends.Service;
using Friends.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add service layer
builder.Services.AddScoped<IFriendsListService, FriendsListService>();
builder.Services.AddScoped<IMessage, MessageService>();


//DB Connection Instance
builder.Services.AddDbContext<FriendsDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Friends_DB")));

//Add Section
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Allowing the use of the section
app.UseSession();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Friends}/{action=Index}/{id?}");

app.Run();
