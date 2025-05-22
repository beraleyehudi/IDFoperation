using IDFoperation.Aman.Exterior.Actions;
using IDFoperation.Aman.Exterior.Actions.Data;
using IDFoperation.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Terrorist m = new Terrorist("ahmed", 4,Enums.TerroristStatus.Alive,new List<Enums.WeaponType> {Enums.WeaponType.Knife});
            NewReport t = new NewReport(m,"lop","lko");
            Reports.f();
        }
    }
}
