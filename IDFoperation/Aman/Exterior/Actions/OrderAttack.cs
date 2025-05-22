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
        string TimeOrder;
        Terrorist terrorist;
        string munition;
        OperationsOfficer operationsOfficer;
        NewReport intelligenceReport;

        public OrderAttack(
            string timeOrder,
            Terrorist terrorist,
            string munition,
            OperationsOfficer operationsOfficer,
            NewReport intelligenceReport)
        {
            this.TimeOrder = timeOrder;
            this.terrorist = terrorist;
            this.munition = munition;
            this.operationsOfficer = operationsOfficer;
            this.intelligenceReport = intelligenceReport;

            Attacks.AddAttack(this);
        }
    }
}
