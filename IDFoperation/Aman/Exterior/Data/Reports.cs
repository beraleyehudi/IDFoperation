using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.Aman.Exterior.Actions.Data
{
    public static class Reports
    {
        private static List<NewReport> reports = new List<NewReport>();

        public static void AddReport(NewReport report)
        {
            reports.Add(report);
        }

        public static void f()
        {
            foreach (var i in reports)
            {
                Console.WriteLine(i.terrorist.Name);
            }
        }
    }
   }
