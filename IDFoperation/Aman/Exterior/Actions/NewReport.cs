using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.Aman.Exterior.Data;

namespace IDFoperation.Aman.Exterior.Actions
{
    public class NewReport
    {
        //public Terorist terorist;
        public string Location;
        public string ReportTime;

        public NewReport(
            //Terorist terorist,
            string location,
            string reportTime)
        {
            //this.terorist = terorist;
            Location = location;
            ReportTime = reportTime;
            //Reports reports = new Reports();
            Reports.reports.Add(this);

        }
    }


}
