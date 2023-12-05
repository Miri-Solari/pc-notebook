using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Human
    {
        static int IdCount = 0;
        protected int _id = 0;
        protected string _name;
        protected string _secondName;
        protected DateTime _birdthDate;
        protected int _hieght;
        protected bool _isInMarrage;

        public Human(string name, string secondName, DateTime birdth, int h, bool marrage)
        {

            _id = IdCount++;
            IdCount = IdCount + 1;
            _birdthDate = birdth;
            _name = name;
            _secondName = secondName;
            _hieght = h;
            _isInMarrage = marrage;
            Humanity.AddHuman(this);
        }

        public int GetId()
        {
            return _id;
        }

        public string GetInfo()
        {
            return $"Имя: {_name} /nФамилая: {_secondName} /nДата рождения: {_birdthDate} /nРост: {_hieght} /nВ браке ли?: {_isInMarrage}";
        }

    }
}
