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
        public List<Terrorist> TerroristsList { get;private  set; }

        public TerrorOrganization(string fullName, string dateOfFormation, string currentCommander, List<Terrorist> terroristsList )
        {
            FullName = fullName;
            DateOfFormation = dateOfFormation;
            CurrentCommander = currentCommander;
            TerroristsList = terroristsList;
        }

        public void AddTerrorist(Terrorist terrorist)
        {
            TerroristsList.Add(terrorist);
        }

        public void RemoveTerrorist(Terrorist terrorist)
        {
            TerroristsList.Remove(terrorist);
        }
    }
}
