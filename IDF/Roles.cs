using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.IDF
{
    public abstract class Roles
    {
        public string Name;


        public Roles(string name)
        {
            this.Name = name;
        }
    }
    public class IntelligenceResearcher : Roles
    {
        public int NumberOfReports = 0;
        public int NumberOfSuccesses = 0;
        public int NumberOfFailuers = 0;
        
        public IntelligenceResearcher(string name) : base(name)
        {
        }

        public double QualityOfExperience()
        {
            int attempts = this.NumberOfReports;
            int successes = this.NumberOfSuccesses;
            if (successes > 0 && attempts > 0)
            {
                return (((100 / (double)attempts) * (double)successes) / 100) * (double)successes;
            }
            return 0;
        }
    }

    public class OperationsOfficer : Roles
    {



        public OperationsOfficer(string name) : base(name)
        {
        }


    }

}