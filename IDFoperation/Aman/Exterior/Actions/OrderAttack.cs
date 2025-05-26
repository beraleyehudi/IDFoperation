using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.IDF;
using IDFoperation.Aman.Interior.Data;
using IDFoperation.Enemy;

namespace IDFoperation.Aman.Exterior.Actions
{
    public class OrderAttack
    {
        DateTime TimeOrder;
        Terrorist terrorist;
        StrikeInit munition;
        OperationsOfficer operationsOfficer;
        NewReport intelligenceReport;

        public OrderAttack(
            Terrorist terrorist,
            StrikeInit munition,
            OperationsOfficer operationsOfficer,
            NewReport intelligenceReport)
        {
            this.TimeOrder = DateTime.Now;
            this.terrorist = terrorist;
            this.munition = munition;
            this.operationsOfficer = operationsOfficer;
            this.intelligenceReport = intelligenceReport;

            Attacks.AddAttack(this);
            Attacks.last = (this);
            Console.WriteLine("An attack order was placed"); //בדיקה
        }
    }
}
