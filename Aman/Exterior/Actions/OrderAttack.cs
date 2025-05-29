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
    public enum OrderAttckStatus
    {
        intelligenceinformation,
        strikeunit, 
        success
        

    }
    public class OrderAttack
    {
        public DateTime TimeOrder;
        public Terrorist terrorist;
        public StrikeUnit munition;
        public OperationsOfficer operationsOfficer;
        public NewReport Report;
        public OrderAttckStatus Status;

        public OrderAttack(
            Terrorist terrorist,
            StrikeUnit munition,
            OperationsOfficer operationsOfficer,
            NewReport intelligenceReport)
        {
            this.TimeOrder = DateTime.Now;
            this.terrorist = terrorist;
            this.munition = munition;
            this.operationsOfficer = operationsOfficer;
            this.Report = intelligenceReport;

            Attacks.AddAttack(this);
            Attacks.last = (this);
            Console.WriteLine("An attack order was placed"); //בדיקה
            
        }

        public void UpdataStatus(OrderAttckStatus status)
        {
            Status = status;

            switch(status)
            {
                case OrderAttckStatus.intelligenceinformation:
                    this.Report.IntelligenceResearcher.NumberOfFailuers++;
                    break;

                default:
                    this.Report.IntelligenceResearcher.NumberOfSuccesses++;
                    break;
            }

        }
    }
}
