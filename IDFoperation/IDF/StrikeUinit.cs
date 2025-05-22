using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{

    public abstract class StrikeUinit
    {
        public static List<StrikeUinit> idfWeapons = new List<StrikeUinit>();
        public string CodeName;
        public string Efficiency;
        public int AvailableAttacks;

        public StrikeUinit(string codeName)
        {
            this.CodeName = codeName;
            idfWeapons.Add(this);
           
        }

        public abstract void Attack();
        
    }

    public class F16 : StrikeUinit
    {
        public F16(string codeName) : base(codeName)
        { 
            this.Efficiency = "structures";
            this.AvailableAttacks = 8;
            idfWeapons.Add(this);
        }

        public override void Attack()
        {
            AvailableAttacks--;
        }
    }
        
}







