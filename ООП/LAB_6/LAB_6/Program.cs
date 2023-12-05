using LAB_6;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
LAB666 ex1 = new("asdsads001", 23, 142d);
LAB666 ex2 = new("asdsads002", 43, 564d);
LAB666 ex3 = new("asdsads003", 63, 7655d);
LAB666.Info(ex1);
LAB666.Info(ex2);
LAB666.Info(ex3);
ex1._stringValue = null; // предупреждение о передаче null в переменную, тип которой не допускает этого, при выполнении программы null будет записан в переменную(ссылочный тип)
LAB666.Info(ex1);
ex2._stringValue = null!; // предупреждения больше нет, при выполнении программы null будет записан в переменную
LAB666.Info(ex2);
//ex1._intvalue = null;  ошибка компиляции
//ex1._intvalue = null!; то же самое int(значимый тип) не приемлет null
ex1._stringValue = "1234567890";
int al = ex1._stringValue!.Length;
Console.WriteLine(al);
// ссылочный и значимый тип работают с null по-разному







