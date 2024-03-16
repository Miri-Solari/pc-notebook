using LAB3_11_;

List<Human> Humani = new List<Human>
{
    new() { Id = Guid.NewGuid().ToString(), Name = "Oleg1", Mast = "Prog",Class = RabochiyClass.science, Age = 21 },
    new() { Id = Guid.NewGuid().ToString(), Name = "Oleg2", Mast = "Manager", Class = RabochiyClass.aristo, Age = 38 },
    new() { Id = Guid.NewGuid().ToString(), Name = "Oleg3", Mast = "Ozhaka", Class = RabochiyClass.worker, Age = 22 },
    new() { Id = Guid.NewGuid().ToString(), Name = "Vita1", Mast = "SoBR",Class = RabochiyClass.burjua, Age = 22 }
};

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/users", () => Humani);

app.MapGet("/api/users/{id}", (string id) =>
{
    Human? temp = Humani.FirstOrDefault(u => u.Id == id);
    if (temp == null) return Results.NotFound(new { message = "Пользователь не найден" });

    return Results.Json(temp);
});

app.MapDelete("/api/users/{id}", (string id) =>
{
    Human? temp = Humani.FirstOrDefault(u => u.Id == id);

    if (temp == null) return Results.NotFound(new { message = "Пользователь не найден" });

    Humani.Remove(temp);
    return Results.Json(temp);
});

app.MapPost("/api/users", (Human user) =>
{
    user.Id = Guid.NewGuid().ToString();
    Humani.Add(user);
    return user;
});

app.MapPut("/api/users", (Human userData) =>
{
    var user = Humani.FirstOrDefault(u => u.Id == userData.Id);
    if (user == null) return Results.NotFound(new { message = "Пользователь не найден" });

    user.Age = userData.Age;
    user.Name = userData.Name;
    user.Mast = userData.Mast;
    return Results.Json(user);
});

app.Run();