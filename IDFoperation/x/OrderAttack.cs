using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.IDF;
using IDFoperation.Aman.Interior.Data;

namespace IDFoperation.Aman.Exterior.Actions
{
    public class OrderAttack
    {
        string TimeOrder;
        //Trorist trorist;
        string munition;
        OperationsOfficer operationsOfficer;
        NewReport intelligenceReport;

        public OrderAttack(
            string timeOrder,
            //Trorist trorist,
            string munition,
            OperationsOfficer operationsOfficer,
            NewReport intelligenceReport)
        {
            this.TimeOrder = timeOrder;
            //this.trorist = trorist;
            this.munition = munition;
            this.operationsOfficer = operationsOfficer;
            this.intelligenceReport = intelligenceReport;

            Attacks attacks = new Attacks();
            attacks.attacks.Add(this);
        }
    }
}
