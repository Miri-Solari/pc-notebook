using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Aircraft : Mechanismus
    {
        public override float Mass { get; set;}
        public override (float, float) coord { get; set; }
        public override string discription { get; set; } = string.Empty;
        public float Range = 1000f;


        public override void Move(float x, float y)
        {
            if (Math.Sqrt(x * x + y * y) < Range)
            {
                coord = (coord.Item1 + x, coord.Item2 + y);
                Console.WriteLine($"Самолёт перелетел на {Math.Sqrt(x * x + y * y)} километров");
            }
            else Console.WriteLine("Недолёт");
        }

        public override void ReduceMass(float mass)
        {
            Mass -= mass;
            Console.WriteLine($"Потрачено топливо массой {mass} кг");
        }

        public override void SelfDestroy()
        {
            Mass = 0;
            Console.WriteLine("PSHH BOOOOOM");
        }

        
    }
}
