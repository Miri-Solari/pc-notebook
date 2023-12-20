using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Ballista : Mechanismus
    {
        public override float Mass { get; set; }
        public override (float, float) coord { get; set; }
        public override string discription { get; set; } = string.Empty;
        public int Ammo = 10;

        public override void Move(float x, float y)
        {
            coord = (coord.Item1 + x, coord.Item2 + y);
            Console.WriteLine($"Солдаты перетащили баллисту на {Math.Sqrt(x*x + y*y)} метров");
        }

        public override void ReduceMass(float mass)
        {
            Mass -= mass;
            Console.WriteLine($"Произведён выстрел массой {mass} кг");
        }

        public override void SelfDestroy()
        {
            Console.WriteLine("CRANK");
        }

        public void Fire()
        {
            Ammo -= 1;
            Console.WriteLine("ГОСПОДИИИ, ОНО СТРЕЛЯЕТ");
        }
    }
}
