using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.AuxiliaryFunctions;
using IDFoperation.Enemy;
using IDFoperation.Aman.Interior.Data;
using IDFoperation.Aman.Exterior.Actions;
using IDFoperation.IDF;
using IDFoperation.Aman.Exterior.Actions.Data;

namespace IDFoperation.Controller
{
    public static class Menages
    {
       
        public static void Menage(OperationsOfficer operationsOfficer, IntelligenceResearcher intelligenceResearcher)
        {
            bool exit = false;
            do
            {

               
                string choice = All.PrintMenu("menu", new string[] { "The terrorist with the highest number of reports", "The most dangerous terrorist", "All attack tools", "Attack", "Exit"});

                switch (choice)
                {
                    case "The terrorist with the highest number of reports":
                        All.MostReports();

                        break;
                       
                    case "The most dangerous terrorist":
                        All.MostDangerous();
                        break;
                       


                    case "All attack tools":
                        Munitions.GetMunitionsData(All.typeStrike);
                        break;

                    case "Attack":
                        All.AttackTerrorist(operationsOfficer, intelligenceResearcher);
                        break;

                    case "Exit":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("");
                        break;


                }
            } while (!exit);

            return;

        }

    }
}
            

                    



























