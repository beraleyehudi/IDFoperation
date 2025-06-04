using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.Enemy
{
    public static class Enums{
        public enum WeaponType {
            Knife = 1,
            Gun = 2,
            M16 = 3,
            AK47 = 3

        }

        public enum TerroristStatus
        {
            Dead,
            Alive
        }

        public enum LocationType
        {
            structur,
            people,
            openArea

        }
    }
    
}
