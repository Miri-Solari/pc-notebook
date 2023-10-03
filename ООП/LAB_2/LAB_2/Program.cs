using LAB_2;


Atributes Alfreds = new(2, "Alfred", 10);
Dog Alfred = new(Alfreds, "Oleg");
Alfreds.PrintAll();
Alfred.WOOOF();
Atributes Mias = Alfreds with { name = "Mia" };
Dog Mia = (Dog)Alfred.Clone(Mias, "Sandra");
Mia.WOOOF();