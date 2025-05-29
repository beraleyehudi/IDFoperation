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
 

        public static Dictionary<string, List<StrikeUnit>> munitions =
            new Dictionary<string, List<StrikeUnit>>();

        public static void GetMunitionsData(string[] typs)
        {
            foreach (string type in typs)
            { 

           
                int i = 1;
                Console.WriteLine($"{type}:");
                foreach (StrikeUnit s in munitions[type])
                {
                    Console.WriteLine(i + ": ");
                    Console.WriteLine($"code name: {s.CodeName}| available attacks: {s.AvailableAttacks}");
                    i++;

                }
                Console.WriteLine("\n");
            }
        }

        
      
        
    }
}
             

