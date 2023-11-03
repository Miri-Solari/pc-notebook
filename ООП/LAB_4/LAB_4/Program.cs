using LAB_4;

Stud Oleg = new Stud();
Oleg.Name = "Oleg";
Oleg.SecondName = "Sherbin";
Oleg.Age = -25;
Console.WriteLine(Oleg.GetInfo());
Oleg.Age = 25;
Console.WriteLine(Oleg.GetInfo());
Console.WriteLine(Oleg.GetInfo(true));
Console.WriteLine(Oleg.GetInfo(false));

