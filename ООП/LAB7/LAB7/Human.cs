using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    internal class Human : Animal
    {
        bool _extremist;

        public Human(bool extremist, float weight, float power, float draught, string name): base(weight, power, draught, name)
        {
            _extremist = extremist;
        }

        public void AccuseToExtremism()
        {
            _extremist = true;
        }

        public void UnExtremismus()
        {
            _extremist = false;
        }

        public new string ToString()
        {
            return $"{_extremist}, {base.ToString()}";
        }
    }
}
