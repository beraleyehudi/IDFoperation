using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.IDF;

namespace IDFoperation.Aman.Interior.Data
{
    public class Munitions
    {
        public static List<StrikeUinit> IdfMunitions = new List<StrikeUinit>();

        public void GetIdfMunitions()
        {
            foreach (StrikeUinit weapon in IdfMunitions)
            {
                Console.WriteLine(weapon);

            }
        }
    }
}
