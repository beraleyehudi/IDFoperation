using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.Aman.Exterior.Actions.Data;
using IDFoperation.Enemy;
using IDFoperation.IDF;


namespace IDFoperation.Aman.Exterior.Actions
{
    public class NewReport
    {
        public Terrorist terrorist{ get; private set; }
        public Enums.LocationType Location;
        public DateTime ReportTime { get; private set; }

        public IntelligenceResearcher IntelligenceResearcher;


        public NewReport(IntelligenceResearcher intelligenceResearcher, Terrorist terrorist,Enums.LocationType location)
        {
            this.IntelligenceResearcher = intelligenceResearcher;
            this.terrorist = terrorist;
            Location = location;
            ReportTime = DateTime.Now;

            Reports.AddReport(terrorist, this);
            intelligenceResearcher.NumberOfReports++;
            //Reports.last(this);

        }
    }
}
