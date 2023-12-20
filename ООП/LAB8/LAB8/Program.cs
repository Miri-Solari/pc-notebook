using LAB8;

void Func(Mechanismus kek)
{
    kek.discription = "Треугольный червь прогнившей пластмассы";
    kek.coord = (1f, 1f);
    kek.Mass = 40000f; // А хули вы хотели 40 тонн
    kek.Move(23f, 334f);
    kek.ReduceMass(1f);
    kek.SelfDestroy();
}

Engine PD14 = new();
Ballista Romul = new();
Aircraft MS21 = new();
Func(PD14);
Console.WriteLine();
Func(MS21);
Console.WriteLine();
Func(Romul);

