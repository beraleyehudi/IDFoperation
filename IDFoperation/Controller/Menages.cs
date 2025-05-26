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
       
        public static void Menage(OperationsOfficer operationsOfficer)
        {
            bool exit;
            Terrorist theTerrosit = null;
            StrikeUinit strikeUinit = null;
            do
            {

                exit = true;
                string choice = All.PrintMenu("menu", new string[] { "The terrorist with the highest number of reports", "The most dangerous terrorist", "All attack tools"});

                switch (choice)
                {
                    case "The terrorist with the highest number of reports":
                        theTerrosit = All.MostReports();
                        break;
                       


                    case "The most dangerous terrorist":
                        theTerrosit = All.MostDangerous();
                        break;
                       


                    case "All attack tools":
                        Munitions.GetMunitionsData(All.typeStrike);
                        exit = false;
                        break;
                }
            } while (!exit);

            strikeUinit = All.ChoosingAttackTool();

            NewReport lastReport = Reports.reports[theTerrosit][Reports.reports[theTerrosit].Count - 1];

            OrderAttack orderAttack = new OrderAttack
                (
                theTerrosit,
                strikeUinit,
                operationsOfficer,

                lastReport

                );
            Console.WriteLine("secces");
            strikeUinit.Attack();
            theTerrosit.UpdateTerroristStatus();
            return;

        }

    }
}
            

                    



























