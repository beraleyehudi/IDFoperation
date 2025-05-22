using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.Enemy
{
    internal class HamasOrganization : TerrorOrganization
    {


        public HamasOrganization() : base(
                "Islamic Resistance Movement",
                "1987",
                "Ismail haniya",
                new List<Terrorist>()
                )
               {
               }
    }
}
