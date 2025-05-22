using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.Aman.ForeignIntelligence
{
    internal class NewReport
    {
        public Terorist terorist;
        public string Location;
        public string ReportTime;

        public NewReport(
            Terorist terorist,
            string location,
            string reportTime)
        {
            this.terorist = terorist;
            Location = location;
            ReportTime = reportTime;
        }
    }


}
