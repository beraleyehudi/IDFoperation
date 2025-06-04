using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.Aman.Interior.Data;
using IDFoperation.Enemy;


namespace IDFoperation.IDF
{
    //public enum Efficiency
    //{
    //    structurs,
    //    people,
    //    openAreas

    //}

    public abstract class StrikeUnit
    {
        
        public string CodeName;
        public Enums.LocationType Efficiency;
        public int AvailableAttacks;

        public StrikeUnit(string codeName)
        {
            this.CodeName = codeName;
            //Munitions.IdfMunitions.Add(this);
            //public abstract void AddToData();

        }

        public abstract void Attack();

        public void Add(string type, StrikeUnit current)
        {
            if (!Munitions.munitions.ContainsKey(type))
            {
                Munitions.munitions[type] = new List<StrikeUnit>() { current};

            }
            else
            {
                Munitions.munitions[type].Add(current);

            }

        }

    }

    public class F16 : StrikeUnit
    {
        public F16(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = Enums.LocationType.structur;
            this.AvailableAttacks = 8;
            Add("F16", this);
        }

        

        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

    public class ZikDrone : StrikeUnit
    {
        public ZikDrone(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = Enums.LocationType.people;
            this.AvailableAttacks = 3;

            Add("Zik drone", this);

        }
        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

    public class Artillery : StrikeUnit
    {
        public Artillery(string codeName) : base(codeName)
        {
            this.CodeName = codeName;
            this.Efficiency = Enums.LocationType.openArea;
            this.AvailableAttacks = 40;
            Add("Artillery", this);
        }

        public override void Attack()
        {
            AvailableAttacks--;
        }
    }

}







