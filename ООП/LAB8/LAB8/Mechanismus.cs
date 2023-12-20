using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    internal abstract class Mechanismus
    {
        public abstract float Mass { get; set;}
        public abstract (float, float) coord { get; set; }
        public abstract string discription { get; set; }

        public abstract void Move(float x, float y);

        public abstract void ReduceMass(float mass);

        public abstract void SelfDestroy();


    }
}
