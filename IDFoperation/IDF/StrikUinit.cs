using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.Aman.Interior.Data;

namespace IDFoperation.IDF
{
    public enum Efficiency
    {
        structurs,
        people,
        openAreas

    }

    public abstract class StrikeInit
    {
        
        public string CodeName;
        public Efficiency Efficiency;
        public int AvailableAttacks;

        public StrikeInit(string codeName)
        {
            this.CodeName = codeName;
            //Munitions.IdfMunitions.Add(this);
            //public abstract void AddToData();

        }

        public abstract void Attack();

        public void Add(string type, StrikeInit current)
        {
            if (!Munitions.munitions.ContainsKey(type))
            {
                Munitions.munitions[type] = new List<StrikeInit>() { current};

            }
            else
            {
                Munitions.munitions[type].Add(current);

            }

        }

    }

    public class F16 : StrikeInit
    {
        public F16(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = Efficiency.structurs;
            this.AvailableAttacks = 8;
            Add("F16", this);
        }

        

        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

    public class ZikDrone : StrikeInit
    {
        public ZikDrone(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = Efficiency.people;
            this.AvailableAttacks = 3;

            Add("Zik drone", this);

        }
        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

    public class Artillery : StrikeInit
    {
        public Artillery(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = Efficiency.openAreas;
            this.AvailableAttacks = 40;
            Add("Artillery", this);
        }

        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

}







