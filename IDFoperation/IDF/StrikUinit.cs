using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.Aman.Interior.Data;

namespace IDFoperation.IDF
{

    public abstract class StrikeUinit
    {
        
        public string CodeName;
        public string Efficiency;
        public int AvailableAttacks;

        public StrikeUinit(string codeName)
        {
            this.CodeName = codeName;
            //Munitions.IdfMunitions.Add(this);
            //public abstract void AddToData();

        }

        public abstract void Attack();

        public void Add(string type, StrikeUinit current)
        {
            if (!Munitions.munitions.ContainsKey(type))
            {
                Munitions.munitions[type] = new List<StrikeUinit>() { current};

            }
            else
            {
                Munitions.munitions[type].Add(current);

            }

        }

    }

    public class F16 : StrikeUinit
    {
        public F16(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = "structures";
            this.AvailableAttacks = 8;
            Add("F16", this);
        }

        

        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

    public class ZikDrone : StrikeUinit
    {
        public ZikDrone(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = "people, vehicles";
            this.AvailableAttacks = 3;

            Add("Zik drone", this);

        }
        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

    public class Artillery : StrikeUinit
    {
        public Artillery(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = "open areas";
            this.AvailableAttacks = 40;
            Add("Artillery", this);
        }

        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

}







