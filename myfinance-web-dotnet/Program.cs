using myfinance_web_dotnet.Infrastructure;
using myfinance_web_dotnet.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Dependecy Injection Extension
builder.RegisterServices();

//Add AutoMapper Injection
//builder.Services.AddAutoMapper(typeof(TransactionMap));
//builder.Services.AddAutoMapper(typeof(AccountPlanMap));

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
