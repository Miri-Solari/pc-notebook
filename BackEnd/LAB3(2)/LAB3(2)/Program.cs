using LAB3_2_;

var builder = WebApplication.CreateBuilder(args);


var services = builder.Services;
//��������� � �������� ��� � �������� ��������, ������ ������� �� ����� �������� ���������� ITime ����� ���������� ShortTime
services.AddTransient<ITime, LongTime>();
services.AddTransient<IConsolePainter, StarPainter>(); // ���������� ���� ��� ����

var app = builder.Build();

Console.WriteLine(app.Services.GetService<ITime>()?.GetTime()); // ���������� ���������� ������ � ������� ��������� � �������
app.Services.GetService<IConsolePainter>()?.Paint(3);

app.Run();
