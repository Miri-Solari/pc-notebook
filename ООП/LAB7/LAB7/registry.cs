using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    internal class Registry
    {
        List<Animal> _animals = new();

        public void Add(Animal candidate)
        {
            if (candidate != null)
            {
                _animals.Add(candidate);
            }           
        }

        public string CountByType()
        {
            int humans = 0;
            int centipedes = 0;
            foreach (Animal animal in _animals)
            {
                if( animal is Human)
                {
                    humans++;
                }
                else if (animal is Centipede) 
                { 
                    centipedes++; 
                };

            }
            return $"Людей: {humans}, \nСороконожек: {centipedes}, \nВсего: {_animals.Count}";
        }

    }
}
