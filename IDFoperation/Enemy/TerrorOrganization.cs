using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDFoperation.Enemy
{
    abstract class  TerrorOrganization
    {
        public string FullName {get; private set;}
        public string DateOfFormation {get; private set; }
        public string CurrentCommander {get; private set; }

        public TerrorOrganization(string fullName, string dateOfFormation, string currentCommander)
        {
            FullName = fullName;
            DateOfFormation = dateOfFormation;
            CurrentCommander = currentCommander;
        }
    }
}
