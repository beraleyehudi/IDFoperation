using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.Aman.Exterior.Actions.Data;
using IDFoperation.Enemy;

namespace IDFoperation.Aman.Exterior.Actions
{
    public class NewReport
    {
        public Terrorist terrorist;
        public string Location;
        public string ReportTime;

        public NewReport(
            Terrorist terrorist,
            string location,
            string reportTime)
        {
            this.terrorist = terrorist;
            Location = location;
            ReportTime = reportTime;
            Reports.AddReport(this);

        }
    }
}
