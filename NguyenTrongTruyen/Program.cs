using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NguyenTrongTruyen.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TintucContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("TintucContextSQLite")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// builder.Services.AddDbContext<commentContext>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("commentContext") ?? throw new InvalidOperationException("Connection string 'commentContext' not found.")));

// builder.Services.AddDbContext<CategoryContext>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("CategoryContext") ?? throw new InvalidOperationException("Connection string 'CategoryContext' not found.")));

// builder.Services.AddDbContext<NewsContext>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("NewsContext") ?? throw new InvalidOperationException("Connection string 'NewsContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // app.UseHsts();
}

else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<TintucContext>();
    context.Database.EnsureCreated();
    // DbInitializer.Initialize(context);
}

// app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
