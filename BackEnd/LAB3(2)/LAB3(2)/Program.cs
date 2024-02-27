using LAB3_2_;

var builder = WebApplication.CreateBuilder(args);


var services = builder.Services;
//добавляем к сервисам наш в коротком варианте, теперь система на место объектов интерфейса ITime будет передавать ShortTime
services.AddTransient<ITime, LongTime>();
services.AddTransient<IConsolePainter, StarPainter>(); // аналогично тому что выше

var app = builder.Build();

Console.WriteLine(app.Services.GetService<ITime>()?.GetTime()); // используем функционал класса и выводим результат в консоль
app.Services.GetService<IConsolePainter>()?.Paint(3);

app.Run();
