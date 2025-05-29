using IDFoperation.Aman.Exterior.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using IDFoperation.Aman.Exterior.Actions;

namespace IDFoperation.Aman.Interior.Data

    {
    public static class Attacks
    {
        public static List<OrderAttack> attacks = new List<OrderAttack>();
        public static OrderAttack last = null;


        public static void AddAttack(OrderAttack attack)
        {
            attacks.Add(attack);
        }
        public static List<OrderAttack> GetAttacks()
        {
            return attacks;
        }

        public static void Display()
        {
            //Console.WriteLine(last.);

        }
    }
}

