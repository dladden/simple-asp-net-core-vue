var builder = WebApplication.CreateBuilder(args);

// This tells the app to use Startup for configuration
builder.ConfigureServices((context, services) => {
    Startup startup = new Startup();
    startup.ConfigureServices(services);
});


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

Startup startupInstance = new Startup();
startupInstance.Configure(app);

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
