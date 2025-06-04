using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.Enemy; 

namespace IDFoperation.Aman.Exterior.Actions.Data
{
    public static class Reports
    {
    //    private static List<NewReport> reports = new List<NewReport>();
        public static Dictionary<Terrorist, List<NewReport>> reports = new Dictionary<Terrorist, List<NewReport>>();

        public static NewReport GetlastReport(Terrorist terrorist)
        {
            return reports[terrorist][reports[terrorist].Count - 1];
        }


        public static void AddReport(Terrorist terrorist, NewReport report)
        {
            if (! reports.ContainsKey(terrorist))
            {
                reports[terrorist] = new List<NewReport>(); 
            }
            reports[terrorist].Add(report);
        }

        //public static void f()
        //{
        //    foreach (var i in reports)
        //    {
        //        Console.WriteLine(i.terrorist.Name);
        //    }
        //}
    }
   }
