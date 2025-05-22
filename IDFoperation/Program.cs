using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation;
using IDFoperation.IDF;
using IDFoperation.Aman;
using IDFoperation.Aman.Exterior;
using IDFoperation.Aman.Exterior.Data;
using IDFoperation.Aman.Exterior.Actions;
using IDFoperation.Aman.Interior;
using IDFoperation.Aman.Interior.Data;







namespace IDFoperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewReport newReport = new NewReport("a", "b");
            foreach (NewReport r in Reports.reports)
            {
                Console.WriteLine(r.ReportTime);
            }
            
        }
    }
}
