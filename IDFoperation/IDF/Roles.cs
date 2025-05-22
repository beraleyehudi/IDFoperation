using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation.IDF
{
    public abstract class Roles
    {
        string Name;

        public Roles(string name)
        {
            this.Name = name;
        }
    }
    public class IntelligenceResearcher : Roles
    {
        public IntelligenceResearcher(string name) : base(name)
        { 
        }
    }

    public class OperationsOfficer : Roles
    {
        public OperationsOfficer(string name) : base(name)
        {
        }

    }

}