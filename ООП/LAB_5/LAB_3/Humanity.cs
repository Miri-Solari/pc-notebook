using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal static class Humanity
    {
        private static readonly List<Human> humans = new();

        public static void AddHuman(Human human)
        {
            humans.Add(human);
        }

        public static Human? FindHuman(int id)
        {
            foreach (Human human in humans)
            {
                if (id == human.GetId())
                {
                    return human;
                }
            }
            return null;
        }
    }
}
