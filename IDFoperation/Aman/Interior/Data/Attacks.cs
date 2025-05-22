using IDFoperation.Aman.Exterior.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.Aman.Interior.Data

    {
    public static class Attacks
    {
        private static List<OrderAttack> attacks = new List<OrderAttack>();

        public static void AddAttack(OrderAttack attack)
        {
            attacks.Add(attack);
        }
        public static List<OrderAttack> GetAttacks()
        {
            return attacks;
        }
    }
}

