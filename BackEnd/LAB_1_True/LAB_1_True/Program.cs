    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddControllersWithViews();
    var LAB1 = builder.Build();

    LAB1.UseRouting();
    LAB1.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");


    LAB1.Run();
