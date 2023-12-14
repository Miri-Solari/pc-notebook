using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    internal class Centipede: Animal
    {
        int _legsCount;

        public Centipede(int legs,float weight, float power, float draught, string name): base(weight, power, draught, name)
        {
            _legsCount = legs;
        }

        public void LegCut(int num)
        {
            if (num >= _legsCount) {
                Console.WriteLine("Сороконожка вмерла");
                _legsCount = 0;
            }
            _legsCount -= num;
        }

        public new string ToString()
        {
            return $"{_legsCount}, {base.ToString()}";
        }
    }
}
