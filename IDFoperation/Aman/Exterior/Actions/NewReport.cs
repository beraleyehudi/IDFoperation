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
        public Terrorist terrorist{ get; private set; }
        public string Location { get; private set; }
        public DateTime ReportTime { get; private set; }

        public NewReport(Terrorist terrorist,string location)
        {
            this.terrorist = terrorist;
            Location = location;
            ReportTime = DateTime.Now;

            Reports.AddReport(terrorist, this);
            //Reports.last(this);

        }
    }
}
