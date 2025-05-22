using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.Enemy
{
    internal class Terrorist
    {
        public string Name { get; private set; }
        public int Rank {get; private set; }
        public string Status { get; private set; }
        public List<Enums.WeaponType> Weapons { get; set; }

        public Terrorist(string name, int rank, string status, List<Enums.WeaponType> weapons)
        {
            Name = name;
            Rank = rank;
            Status = status;
            Weapons = weapons;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name of the terorist: {Name}");
            Console.WriteLine($"Rank of the terorist: {Rank}");
            Console.WriteLine($"Statuseof the terorist: {Status}");
            Console.Write($"Weapons of the terorist: ");
            //foreach (var i in Weapons)
            //{
            //    Console.Write();
            //}
        }
    }
}

