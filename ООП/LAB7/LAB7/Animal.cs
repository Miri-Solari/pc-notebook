using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    internal class Animal
    {
        float _weight; // вес
        float _powerSupply; // энерговооружённость
        float _draught; // водоизмещение
        string _name; // имя
        

        public Animal(float weight, float power, float draught, string name)
        {
            _weight = weight;
            _powerSupply = power;
            _draught = draught;
            _name = name;
        }


        public string ToString()
        {
            return $"{_name}, {_weight}, {_powerSupply}, {_draught}";
        }


    }
}
