// See https://aka.ms/new-console-template for more information
using LAB7;

Animal Oleg = new(24f, 32f, 342334f, "Oleg");
Human Victor = new(false, 32f, 453f, 5443f, "Vitya");
Animal Oleg1 = new(241f, 321f, 3423341f, "Oleg1");
Human Victor1 = new(true, 321f, 4531f, 54431f, "Vitya1");
Animal Oleg2 = new(242f, 322f, 3423342f, "Oleg2");
Human Victor2 = new(true, 322f, 4532f, 54432f, "Vitya2");
Centipede Gecktor = new(244, 3321f, 4432f, 422f, "Gecktor");
Centipede Gecktor1 = new(2441, 33211f, 44321f, 4221f, "Gecktor1");
Centipede Gecktor2 = new(2442, 33212f, 44322f, 4222f, "Gecktor2");
Console.WriteLine(Oleg.ToString());
Console.WriteLine(Victor.ToString());
Victor.AccuseToExtremism();
Console.WriteLine(Victor.ToString());
Victor.UnExtremismus();
Console.WriteLine(Victor.ToString());
Console.WriteLine(Gecktor.ToString());
Gecktor.LegCut(25);
Console.WriteLine(Gecktor.ToString());
Registry registry = new();
registry.Add(Oleg);
registry.Add(Oleg1);
registry.Add(Oleg2);
registry.Add(Victor);
registry.Add(Victor1);
registry.Add(Victor2);
registry.Add(Gecktor);
registry.Add(Gecktor1);
registry.Add(Gecktor2);
Console.WriteLine(registry.CountByType());



