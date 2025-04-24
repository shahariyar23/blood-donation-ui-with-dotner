var builder = WebApplication.CreateBuilder(args);
// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost") // Allow any localhost
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials(); // Optional if you're using cookies/auth
    });
});


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddControllers();


var app = builder.Build();
// Use CORS before authorization or routing
app.UseCors("AllowFrontend");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // if needed

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); // <-- Needed to respond to API requests!
app.MapRazorPages();

app.Run();