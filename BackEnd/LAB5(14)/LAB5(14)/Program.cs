var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    // Политика для разрешения запросов с домена второго проекта
    options.AddPolicy("AllowProvDomain",
    policy => policy.WithOrigins("http://localhost:5165") //Определения источников с доступом к ресурсам приложения
    .WithMethods("GET") // Определения доступных HTTP методов
    .AllowAnyHeader()); // Управление заголовками
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseCors();
app.MapControllers();

app.MapRazorPages();

app.Run();
