using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal class Engine : Mechanismus
    {
        public override float Mass { get; set; }
        public override (float, float) coord { get; set; }
        public override string discription { get; set; } = string.Empty;

        public int Power = 123;


        public override void Move(float x, float y)
        {
            Console.WriteLine("Error. Can't move");
        }

        public override void ReduceMass(float mass)
        {
            Console.WriteLine("Error. Can't reduce");
        }

        public override void SelfDestroy()
        {
            Console.WriteLine("BOOOOM");
        }

        public void Work()
        {
            Console.WriteLine("Что-ты пыхтит там, чихает, но вроде крутит");
        }
    }
}
