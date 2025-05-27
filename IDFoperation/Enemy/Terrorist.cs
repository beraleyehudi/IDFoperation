using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.Enemy
{
    public class Terrorist
    {
        public string Name { get; private set; }
        public int Rank {get; private set; }
        public Enums.TerroristStatus Status { get; private set; }
        public List<Enums.WeaponType> Weapons { get; set; }

        public Terrorist(string name, int rank,Enums.TerroristStatus status, List<Enums.WeaponType> weapons)
        {
            Name = name;
            Rank = rank;
            Status = status;
            Weapons = weapons;
            HamasOrganization.terrorists.Add(this);

 
        }

        public void UpdateTerroristStatus()
        {
            if (this.Status == Enums.TerroristStatus.Alive)
            {
                this.Status = Enums.TerroristStatus.Dead;
                HamasOrganization.terrorists.Remove(this);
            }
            else
            {
                this.Status = Enums.TerroristStatus.Alive;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name of the terorist: {Name}");
            Console.WriteLine($"Rank of the terorist: {Rank}");
            Console.WriteLine($"Statuse of the terorist: {Status.ToString()}");
            Console.Write($"Weapons of the terorist: ");
            foreach (var i in Weapons)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}

